<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits Bwl.Framework.FormAppBase

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMotorController = New System.Windows.Forms.TextBox()
        Me.motorControllerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTotalWater = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbWaterSystemOk = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbLastWater = New System.Windows.Forms.Label()
        Me.cbWaterStatus = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bFeedNow = New System.Windows.Forms.Button()
        Me.cbTotalFood = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFeedOk = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLastFeed = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 400)
        Me.logWriter.Size = New System.Drawing.Size(781, 160)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Плата управления"
        '
        'tbMotorController
        '
        Me.tbMotorController.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMotorController.Location = New System.Drawing.Point(110, 27)
        Me.tbMotorController.Name = "tbMotorController"
        Me.tbMotorController.Size = New System.Drawing.Size(662, 20)
        Me.tbMotorController.TabIndex = 4
        '
        'motorControllerStatus
        '
        Me.motorControllerStatus.Enabled = True
        Me.motorControllerStatus.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTotalWater)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbWaterSystemOk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbLastWater)
        Me.GroupBox1.Controls.Add(Me.cbWaterStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 136)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Вода"
        '
        'cbTotalWater
        '
        Me.cbTotalWater.AutoSize = True
        Me.cbTotalWater.Location = New System.Drawing.Point(219, 102)
        Me.cbTotalWater.Name = "cbTotalWater"
        Me.cbTotalWater.Size = New System.Drawing.Size(14, 20)
        Me.cbTotalWater.TabIndex = 5
        Me.cbTotalWater.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Всего налито:"
        '
        'cbWaterSystemOk
        '
        Me.cbWaterSystemOk.AutoSize = True
        Me.cbWaterSystemOk.Checked = True
        Me.cbWaterSystemOk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbWaterSystemOk.Location = New System.Drawing.Point(22, 23)
        Me.cbWaterSystemOk.Name = "cbWaterSystemOk"
        Me.cbWaterSystemOk.Size = New System.Drawing.Size(169, 24)
        Me.cbWaterSystemOk.TabIndex = 3
        Me.cbWaterSystemOk.Text = "Система исправна"
        Me.cbWaterSystemOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Последний долив воды:"
        '
        'cbLastWater
        '
        Me.cbLastWater.AutoSize = True
        Me.cbLastWater.Location = New System.Drawing.Point(219, 75)
        Me.cbLastWater.Name = "cbLastWater"
        Me.cbLastWater.Size = New System.Drawing.Size(14, 20)
        Me.cbLastWater.TabIndex = 1
        Me.cbLastWater.Text = "-"
        '
        'cbWaterStatus
        '
        Me.cbWaterStatus.AutoSize = True
        Me.cbWaterStatus.Checked = True
        Me.cbWaterStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbWaterStatus.Location = New System.Drawing.Point(22, 46)
        Me.cbWaterStatus.Name = "cbWaterStatus"
        Me.cbWaterStatus.Size = New System.Drawing.Size(127, 24)
        Me.cbWaterStatus.TabIndex = 0
        Me.cbWaterStatus.Text = "Вода полная"
        Me.cbWaterStatus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bFeedNow)
        Me.GroupBox2.Controls.Add(Me.cbTotalFood)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbFeedOk)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbLastFeed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(765, 153)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Еда"
        '
        'bFeedNow
        '
        Me.bFeedNow.Location = New System.Drawing.Point(15, 108)
        Me.bFeedNow.Name = "bFeedNow"
        Me.bFeedNow.Size = New System.Drawing.Size(211, 33)
        Me.bFeedNow.TabIndex = 6
        Me.bFeedNow.Text = "Кормить сейчас"
        Me.bFeedNow.UseVisualStyleBackColor = True
        '
        'cbTotalFood
        '
        Me.cbTotalFood.AutoSize = True
        Me.cbTotalFood.Location = New System.Drawing.Point(212, 79)
        Me.cbTotalFood.Name = "cbTotalFood"
        Me.cbTotalFood.Size = New System.Drawing.Size(14, 20)
        Me.cbTotalFood.TabIndex = 5
        Me.cbTotalFood.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Всего засыпано:"
        '
        'cbFeedOk
        '
        Me.cbFeedOk.AutoSize = True
        Me.cbFeedOk.Checked = True
        Me.cbFeedOk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFeedOk.Location = New System.Drawing.Point(15, 25)
        Me.cbFeedOk.Name = "cbFeedOk"
        Me.cbFeedOk.Size = New System.Drawing.Size(169, 24)
        Me.cbFeedOk.TabIndex = 3
        Me.cbFeedOk.Text = "Система исправна"
        Me.cbFeedOk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Последнее кормление:"
        '
        'cbLastFeed
        '
        Me.cbLastFeed.AutoSize = True
        Me.cbLastFeed.Location = New System.Drawing.Point(212, 52)
        Me.cbLastFeed.Name = "cbLastFeed"
        Me.cbLastFeed.Size = New System.Drawing.Size(14, 20)
        Me.cbLastFeed.TabIndex = 1
        Me.cbLastFeed.Text = "-"
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMotorController)
        Me.Name = "App"
        Me.Text = "Кормление кота"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.tbMotorController, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbMotorController As TextBox
    Friend WithEvents motorControllerStatus As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbWaterStatus As CheckBox
    Friend WithEvents cbTotalWater As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbWaterSystemOk As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbLastWater As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bFeedNow As Button
    Friend WithEvents cbTotalFood As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFeedOk As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLastFeed As Label
End Class
