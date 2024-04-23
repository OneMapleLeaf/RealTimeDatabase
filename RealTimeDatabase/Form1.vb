Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Imports System.Web.Script.Serialization
Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Form1
    Dim con As MySqlConnection
    Dim com As MySqlCommand
    Private personCount As Integer = 0

    Dim clearDGVCol As Boolean = True
    Private dtTableGrd As DataTable

    Private client As IFirebaseClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToFireBase()
        Form2.Timer1.Start()
    End Sub
    Private Sub UploadData()
        Dim IDGen As String = $"{Now.Year}{Now.Month.ToString("00")}{Now.Day.ToString("00")}{Now.Hour.ToString("00")}{Now.Minute.ToString("00")}{Now.Second.ToString("00")}"
        Dim data As New DataModel() With {
            .ID = IDGen,
            .FirstName = fName_txt.Text,
            .LastName = lName_txt.Text,
            .ContactNumber = contNum_txt.Text,
            .Address = address_txt.Text,
            .Gender = gender_combo.Text,
            .Balance = 5000
            }

        Dim json As String = JsonConvert.SerializeObject(data)
        Dim response = client.SetAsync(Of DataModel)($"regDB/user_info/{IDGen}", data)
        If response.Result.StatusCode = System.Net.HttpStatusCode.OK Then
            MessageBox.Show("Data uploaded successfully")
        Else
            MessageBox.Show("Data upload failed")
        End If

        fName_txt.Clear()
        lName_txt.Clear()
        contNum_txt.Clear()
        address_txt.Clear()
        gender_combo.Text = ""
    End Sub

    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        UploadData()
    End Sub

    Private Sub contNum_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contNum_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
        If contNum_txt.Text.Length >= 11 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub gender_combo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gender_combo.KeyPress
        e.Handled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        Form2.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class

