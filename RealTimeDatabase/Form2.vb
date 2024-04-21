Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Imports System.Web.Script.Serialization
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class Form2
    Private client As IFirebaseClient
    Public HH As Integer
    Public MM As Integer
    Public SS As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HH = DateAndTime.Now.Hour
        MM = DateAndTime.Now.Minute
        SS = DateAndTime.Now.Second

        Dim AMPM As String = "AM"
        If HH > 12 Then
            HH = HH - 12
            AMPM = "PM"
        ElseIf HH = 0 Then
            HH = 12
        End If

        Dim time As String = $"{HH.ToString("00")}:{MM.ToString("00")}:{SS.ToString("00")}"
        Label1.Text = time
        Label2.Text = AMPM
    End Sub

    Public Async Sub fetchData()
        Try
            Dim firebaseResponse = client.Get($"regDB/user_info/")
            Dim firebaseData = firebaseResponse.ResultAs(Of Dictionary(Of String, DataModel))()
            If firebaseData IsNot Nothing AndAlso firebaseData.Count > 0 Then
                Dim dataList As New List(Of DataModel)
                For Each kvp As KeyValuePair(Of String, DataModel) In firebaseData
                    dataList.Add(kvp.Value)
                Next

                DataGridView1.DataSource = dataList

                DataGridView1.Columns("ID").HeaderText = "UID"
                DataGridView1.Columns("FirstName").HeaderText = "First Name"
                DataGridView1.Columns("LastName").HeaderText = "Last Name"
                DataGridView1.Columns("ContactNumber").HeaderText = "Contact Number"
                DataGridView1.Columns("Address").HeaderText = "Address"
                DataGridView1.Columns("Gender").HeaderText = "Gender"
                DataGridView1.Columns("Balance").HeaderText = "Balance"
            Else
                MessageBox.Show("No data found in Firebase.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching data from Firebase: {ex.Message}")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToFireBase()
        fetchData()
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
End Class