Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Mysqlx.Cursor

Public Class Form3
    Private client As IFirebaseClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectToFireBase()
        UpdateBalance(TextBox1.Text, Convert.ToDecimal(TextBox2.Text))
    End Sub

    Public Sub ConnectToFireBase()
        Dim fcon As New FirebaseConfig() With {
        .AuthSecret = "LsBgkAmK485VYAW1mkoRw1gROtA6dV1FwkncTQzg",
        .BasePath = "https://testing-firebase-b6205-default-rtdb.asia-southeast1.firebasedatabase.app/"
        }
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show($"There is a problem with your internet")
        End Try
    End Sub

    Public Async Sub UpdateBalance(userID As String, newBalance As Decimal)
        Try
            Dim firebaseResponse = client.Get($"regDB/user_info/{userID}")
            Dim userData = firebaseResponse.ResultAs(Of DataModel)()

            If userData IsNot Nothing Then
                userData.Balance += newBalance

                Dim updateResponse = Await client.UpdateAsync($"regDB/user_info/{userID}", userData)


                If updateResponse.StatusCode = System.Net.HttpStatusCode.OK Then
                    MessageBox.Show($"Balance updated successfully for {userID}")
                Else
                    MessageBox.Show("Balance update failed")
                End If
            Else
                MessageBox.Show("User not found")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error update balance: {ex.Message}")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
        Form2.fetchData()
    End Sub
End Class