Public Class Form1

    Const FAT_CALORIES_PER_GRAM As Integer = 9
    Const PROTEIN_CALORIES_PER_GRAM As Integer = 4
    Const CARBOHYDRATE_CALORIES_PER_GRAM As Integer = 4

    Dim TotalItemInteger As Integer
    Dim TotalCaloriesInteger As Integer

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        Dim QtityGramsPerFatInteger, QtityGramsPerProteinInteger, QtityGramsPerCarbohydrateInteger As Integer
        Dim CaloriesPerItem As Integer

        Try
            QtityGramsPerFatInteger = Integer.Parse(FatTextBox.Text)
            QtityGramsPerCarbohydrateInteger = Integer.Parse(CarbsTextBox.Text)
            QtityGramsPerProteinInteger = Integer.Parse(ProteinTextBox.Text)

            CaloriesPerItem = (QtityGramsPerFatInteger * FAT_CALORIES_PER_GRAM) + (QtityGramsPerProteinInteger * PROTEIN_CALORIES_PER_GRAM) + (QtityGramsPerCarbohydrateInteger * CARBOHYDRATE_CALORIES_PER_GRAM)

            CurrentItemCaloriesTextBox.Text = CaloriesPerItem.ToString

            TotalItemInteger += 1
            TotalCaloriesInteger += CaloriesPerItem

            TotalItemsTextBox.Text = TotalItemInteger.ToString
            TotalCaloriesTextBox.Text = TotalCaloriesInteger.ToString

        Catch ex As Exception
            MessageBox.Show("Please enter a valid number.")
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FatTextBox.Clear()
        CarbsTextBox.Clear()
        ProteinTextBox.Clear()
        CurrentItemCaloriesTextBox.Clear()
    End Sub
End Class
