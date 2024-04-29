<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        FatTextBox = New TextBox()
        CarbsTextBox = New TextBox()
        ProteinTextBox = New TextBox()
        GroupBox1 = New GroupBox()
        CalculateButton = New Button()
        ClearButton = New Button()
        ExitButton = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CurrentItemCaloriesTextBox = New TextBox()
        TotalItemsTextBox = New TextBox()
        TotalCaloriesTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 32)
        Label1.TabIndex = 0
        Label1.Text = "Fat:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 32)
        Label2.TabIndex = 1
        Label2.Text = "Carbs:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(81, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 32)
        Label3.TabIndex = 2
        Label3.Text = "Protein:"
        ' 
        ' FatTextBox
        ' 
        FatTextBox.AcceptsReturn = True
        FatTextBox.Location = New Point(226, 117)
        FatTextBox.Name = "FatTextBox"
        FatTextBox.Size = New Size(200, 39)
        FatTextBox.TabIndex = 3
        ' 
        ' CarbsTextBox
        ' 
        CarbsTextBox.Location = New Point(226, 200)
        CarbsTextBox.Name = "CarbsTextBox"
        CarbsTextBox.Size = New Size(200, 39)
        CarbsTextBox.TabIndex = 4
        ' 
        ' ProteinTextBox
        ' 
        ProteinTextBox.Location = New Point(226, 282)
        ProteinTextBox.Name = "ProteinTextBox"
        ProteinTextBox.Size = New Size(200, 39)
        ProteinTextBox.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(26, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(476, 280)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter the # of Grams"
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(587, 110)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(150, 46)
        CalculateButton.TabIndex = 7
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(587, 193)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(150, 46)
        ClearButton.TabIndex = 8
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(587, 278)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(150, 46)
        ExitButton.TabIndex = 9
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(278, 32)
        Label4.TabIndex = 10
        Label4.Text = "Calories for current item:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(81, 503)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 32)
        Label5.TabIndex = 11
        Label5.Text = "Total # of items:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(80, 593)
        Label6.Name = "Label6"
        Label6.Size = New Size(207, 32)
        Label6.TabIndex = 12
        Label6.Text = "Total # of calories:"
        ' 
        ' CurrentItemCaloriesTextBox
        ' 
        CurrentItemCaloriesTextBox.Location = New Point(366, 381)
        CurrentItemCaloriesTextBox.Name = "CurrentItemCaloriesTextBox"
        CurrentItemCaloriesTextBox.ReadOnly = True
        CurrentItemCaloriesTextBox.Size = New Size(225, 39)
        CurrentItemCaloriesTextBox.TabIndex = 13
        ' 
        ' TotalItemsTextBox
        ' 
        TotalItemsTextBox.Location = New Point(293, 500)
        TotalItemsTextBox.Name = "TotalItemsTextBox"
        TotalItemsTextBox.ReadOnly = True
        TotalItemsTextBox.Size = New Size(200, 39)
        TotalItemsTextBox.TabIndex = 14
        ' 
        ' TotalCaloriesTextBox
        ' 
        TotalCaloriesTextBox.Location = New Point(293, 590)
        TotalCaloriesTextBox.Name = "TotalCaloriesTextBox"
        TotalCaloriesTextBox.ReadOnly = True
        TotalCaloriesTextBox.Size = New Size(200, 39)
        TotalCaloriesTextBox.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 777)
        Controls.Add(TotalCaloriesTextBox)
        Controls.Add(TotalItemsTextBox)
        Controls.Add(CurrentItemCaloriesTextBox)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ExitButton)
        Controls.Add(ClearButton)
        Controls.Add(CalculateButton)
        Controls.Add(ProteinTextBox)
        Controls.Add(CarbsTextBox)
        Controls.Add(FatTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FatTextBox As TextBox
    Friend WithEvents CarbsTextBox As TextBox
    Friend WithEvents ProteinTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CurrentItemCaloriesTextBox As TextBox
    Friend WithEvents TotalItemsTextBox As TextBox
    Friend WithEvents TotalCaloriesTextBox As TextBox

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles ProteinTextBox.TextChanged

    End Sub
End Class
