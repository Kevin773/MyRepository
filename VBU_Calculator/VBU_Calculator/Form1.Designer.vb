<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstNumTextBox = New System.Windows.Forms.TextBox()
        Me.secondNumTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.subtractButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter first number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter second number: "
        '
        'firstNumTextBox
        '
        Me.firstNumTextBox.Location = New System.Drawing.Point(113, 31)
        Me.firstNumTextBox.Name = "firstNumTextBox"
        Me.firstNumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstNumTextBox.TabIndex = 2
        Me.firstNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'secondNumTextBox
        '
        Me.secondNumTextBox.Location = New System.Drawing.Point(128, 64)
        Me.secondNumTextBox.Name = "secondNumTextBox"
        Me.secondNumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.secondNumTextBox.TabIndex = 3
        Me.secondNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 144)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 48)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.Location = New System.Drawing.Point(93, 144)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(75, 48)
        Me.subtractButton.TabIndex = 5
        Me.subtractButton.Text = "Subtract"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(174, 144)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(75, 48)
        Me.divideButton.TabIndex = 6
        Me.divideButton.Text = "Divide"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(255, 144)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(75, 48)
        Me.multiplyButton.TabIndex = 7
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result:"
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(84, 93)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.ReadOnly = True
        Me.resultTextBox.Size = New System.Drawing.Size(100, 20)
        Me.resultTextBox.TabIndex = 9
        Me.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.SubtractToolStripMenuItem, Me.DivideToolStripMenuItem, Me.MultiplyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 114)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SubtractToolStripMenuItem
        '
        Me.SubtractToolStripMenuItem.Name = "SubtractToolStripMenuItem"
        Me.SubtractToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SubtractToolStripMenuItem.Text = "Subtract"
        '
        'DivideToolStripMenuItem
        '
        Me.DivideToolStripMenuItem.Name = "DivideToolStripMenuItem"
        Me.DivideToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DivideToolStripMenuItem.Text = "Divide"
        '
        'MultiplyToolStripMenuItem
        '
        Me.MultiplyToolStripMenuItem.Name = "MultiplyToolStripMenuItem"
        Me.MultiplyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MultiplyToolStripMenuItem.Text = "Multiply"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 270)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.subtractButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.secondNumTextBox)
        Me.Controls.Add(Me.firstNumTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Calculator"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents firstNumTextBox As TextBox
    Friend WithEvents secondNumTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents subtractButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents resultTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubtractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplyToolStripMenuItem As ToolStripMenuItem
End Class
