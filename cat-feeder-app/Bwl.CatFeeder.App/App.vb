Imports Bwl.Framework
Imports Bwl.Hardware.MotorController

Public Class App
    Private _mc As New MotorControllerFour

    Private _parameters As SettingsStorage = _storage.CreateChildStorage("Parameters")
    Private _waterTime As New IntegerSetting(_parameters, "Water Time Seconds", 5)
    Private _waterGramsPerTime As New IntegerSetting(_parameters, "Water Grams Per Time", 6)

    Private _feedTime As New IntegerSetting(_parameters, "Feed Time Seconds", 2)
    Private _feedPower As New IntegerSetting(_parameters, "Feed Power", 20)
    Private _foodGramsPerTime As New IntegerSetting(_parameters, "Food Grams Per Time", 50)

    Private _waterOk As New BooleanSetting(_storage, "Water Syste mOk", True)
    Private _waterLast As New StringSetting(_storage, "Water Last", "")
    Private _waterCounter As New IntegerSetting(_storage, "Water Counter", 0)
    Private _waterCounterReset As New StringSetting(_storage, "Water Counter Reset", "")

    Private _feedOk As New BooleanSetting(_storage, "Feed System Ok", True)
    Private _feedLast As New StringSetting(_storage, "Feed Last", "0")
    Private _feedOkCurrent As New IntegerSetting(_storage, "Feed Ok Current", 200)
    Private _foodCounter As New IntegerSetting(_storage, "Food Counter", 0)


#Region "HAL"
    Private Function IsWaterFull()
        Try
            Dim val = _mc.GetADCVoltage(4, 4)
            Return val < 2.2
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub WaterPump(seconds As Integer)
        Try
            For i = 0 To seconds * 2
                _mc.MotorDriver = 5
                _mc.MotorCD = 100
                _mc.SendValues()
                Threading.Thread.Sleep(500)
            Next
        Catch ex As Exception
        End Try
        Try
            _mc.MotorDriver = 0
            _mc.MotorCD = 0
            _mc.MotorAB = 0
            _mc.SendValues()
        Catch ex As Exception
        End Try
    End Sub

    Private Function FoodMotor(seconds As Integer, power As Integer) As Single
        Dim startCurrent As Single
        Dim current As Single
        Dim currentCount As Integer

        Try
            startCurrent = _mc.GetPowerInfo.Current
            For i = 0 To seconds * 2
                _mc.MotorDriver = 5
                _mc.MotorAB = power
                _mc.SendValues()
                Threading.Thread.Sleep(500)
                current += _mc.GetPowerInfo.Current
                currentCount += 1
            Next
        Catch ex As Exception
        End Try
        Try
            _mc.MotorDriver = 5
            _mc.MotorCD = 0
            _mc.MotorAB = 0
            _mc.SendValues()
        Catch ex As Exception
        End Try

        If currentCount > 0 Then current /= currentCount
        current -= startCurrent

        Return current
    End Function
#End Region

    Private Sub RefillWater()
        Dim waterCounter = 0
        Do While Not IsWaterFull() And waterCounter < 400
            Me.Invoke(Sub()
                          cbWaterStatus.Checked = False
                          cbWaterStatus.Text = "Долив до датчика, долито " + waterCounter.ToString + " мл"
                      End Sub)
            WaterPump(_waterTime.Value)
            waterCounter += _waterGramsPerTime.Value
        Loop
        If IsWaterFull() Then
            For i = 1 To 3
                Me.Invoke(Sub()
                              cbWaterStatus.Checked = False
                              cbWaterStatus.Text = "Долив дополнительно, долито " + waterCounter.ToString + " мл"
                          End Sub)
                WaterPump(_waterTime.Value)
                waterCounter += _waterGramsPerTime.Value
            Next
            Me.Invoke(Sub()
                          cbWaterStatus.Checked = True
                          cbWaterStatus.Text = "Вода полная"
                          cbWaterSystemOk.Checked = True
                          cbLastWater.Text = Now.ToString + ", " + waterCounter.ToString + " мл"
                          If _waterCounter.Value = 0 Then _waterCounterReset.Value = Now.ToString
                          _waterCounter.Value += waterCounter
                          _waterLast.Value = Now.ToString
                          cbTotalWater.Text = _waterCounter.Value.ToString + " мл"
                      End Sub)
            _logger.AddMessage("Долито " + waterCounter.ToString + "мл воды")
        Else
            _logger.AddError("Было долито 400 мл, но датчик не сработал. Долив заблокирован")
            _waterOk.Value = False
        End If
    End Sub

    Private Sub Feed()
        Me.Invoke(Sub() cbLastFeed.Text = "идет")

        Dim current = FoodMotor(_feedTime.Value, _feedPower.Value)
        If current > _feedOkCurrent.Value / 1000.0 Then
            _logger.AddMessage("Насыпано " + _foodGramsPerTime.Value.ToString + "гр корма, ток " + current.ToString("0.00") + "А")
            Me.Invoke(Sub()
                          cbLastFeed.Text = Now.ToString + " ," + _foodGramsPerTime.Value.ToString + " гр, ток " + current.ToString("0.00") + "А"
                          _feedLast.Value = Now.ToString
                          _foodCounter.Value += _foodGramsPerTime.Value
                          cbTotalFood.Text = _foodCounter.Value.ToString + " гр"
                          cbFeedOk.Checked = True
                      End Sub)
        Else
            _logger.AddWarning("Потенциально, корм, не насыпан, ток " + current.ToString("0.00") + "А")
            Me.Invoke(Sub()
                          cbLastFeed.Text = Now.ToString + " ?, ток " + current.ToString("0.00") + "А"
                          _feedLast.Value = Now.ToString
                          cbFeedOk.Checked = False
                      End Sub)
        End If
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim workThread As New Threading.Thread(AddressOf WorkCycle)
        workThread.IsBackground = True
        workThread.Start()
        cbTotalWater.Text = _waterCounter.Value.ToString + " мл"
        cbTotalFood.Text = _foodCounter.Value.ToString + " гр"
        cbLastFeed.Text = _feedLast.Value
        cbLastWater.Text = _waterLast.Value
    End Sub

    Private Sub WorkCycle()
        Do
            Try
                Me.Invoke(Sub() tbMotorController.Text = _mc.BoardState.ToString + " " + _mc.BoardInfo())
                If _mc.IsConnected Then
                    Dim power = _mc.GetPowerInfo
                    Me.Invoke(Sub() tbMotorController.Text += " " + power.ToString)
                    If _waterOk.Value Then
                        If IsWaterFull() = False Then
                            _logger.AddMessage("Воды недостаточно, начинаем долив")
                            RefillWater()
                        End If
                    Else
                        Me.Invoke(Sub()
                                      cbWaterSystemOk.Checked = False
                                      cbWaterStatus.Text = "Состояние воды неизвестно"
                                      cbWaterStatus.Checked = False
                                  End Sub)
                    End If
                    Dim lastFeedTime As DateTime
                    DateTime.TryParse(_feedLast.Value, lastFeedTime)
                    If (Now - lastFeedTime).TotalHours >= 6 Then
                        _logger.AddMessage("Последнее кормление 6 часов назад, кормим")
                        Feed()
                    End If
                End If
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Private Sub bFeedNow_Click(sender As Object, e As EventArgs) Handles bFeedNow.Click
        Feed()
    End Sub
End Class
