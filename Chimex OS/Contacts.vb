Public Class Contacts

    Private Sub DataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)

    End Sub

    Private Sub Contacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.ContactsDataSet.Data)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            BindingNavigatorAddNewItem.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            BindingNavigatorDeleteItem.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            DataBindingNavigatorSaveItem.PerformClick()
            MsgBox("Database Updated", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class