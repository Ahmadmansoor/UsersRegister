Public Class ReportForm
    Private Sub InOutTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InOutTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InOutTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReprotDataSet)

    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReprotDataSet.UsersStamps' table. You can move, or remove it, as needed.
        Me.UsersStampsTableAdapter.Fill(Me.ReprotDataSet.UsersStamps)
        'TODO: This line of code loads data into the 'ReprotDataSet.InOutTable' table. You can move, or remove it, as needed.
        'Me.InOutTableTableAdapter.Fill(Me.ReprotDataSet.InOutTable)

    End Sub

    Private Sub Bu_GetData_Click(sender As Object, e As EventArgs) Handles Bu_GetData.Click
        If (UserNameComboBox.Text <> "" And CB_Year.Text <> "" And CB_Month.Text <> "") Then
            InOutTableTableAdapter.FillBy_UserIdDate(Me.ReprotDataSet.InOutTable, UsersIdTextBox.Text, CB_Year.Text, CB_Month.SelectedIndex + 1)
        End If
    End Sub
End Class