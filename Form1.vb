Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.FileIO

Public Class Form1

    Private Shared Function EncryptSHA1(text As String) As String
        Dim buffer As Byte() = Encoding.UTF8.GetBytes(text)
        Dim CrypToSha1 As New SHA1CryptoServiceProvider()
        Dim hash As String = BitConverter.ToString(CrypToSha1.ComputeHash(buffer)).Replace("-", "")
        Return hash
    End Function

    Public Shared Function EncryptSHA256(inputString As String) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Public Shared Function EncryptSHA384(inputString As String) As String
        Dim sha384 As SHA384 = SHA384Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha384.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Public Shared Function EncryptSHA512(inputString As String) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Private Shared Function FileEncryptSHA1(ByVal file_name As String)
        Dim sha1 As SHA1 = SHA1.Create()
        Dim hashValue() As Byte
        Dim fStream As FileStream = File.OpenRead(file_name)
        fStream.Position = 0
        hashValue = sha1.ComputeHash(fStream)
        Dim hash = GetStringFromHash(hashValue)
        fStream.Close()
        Return hash
    End Function

    Private Shared Function FileEncryptSHA256(ByVal file_name As String)
        Dim sha256 As SHA256 = SHA256.Create()
        Dim hashValue() As Byte
        Dim fStream As FileStream = File.OpenRead(file_name)
        fStream.Position = 0
        hashValue = sha256.ComputeHash(fStream)
        Dim hash = GetStringFromHash(hashValue)
        fStream.Close()
        Return hash
    End Function

    Private Shared Function FileEncryptSHA384(ByVal file_name As String)
        Dim sha384 As SHA384 = SHA384.Create()
        Dim hashValue() As Byte
        Dim fStream As FileStream = File.OpenRead(file_name)
        fStream.Position = 0
        hashValue = sha384.ComputeHash(fStream)
        Dim hash = GetStringFromHash(hashValue)
        fStream.Close()
        Return hash
    End Function

    Private Shared Function FileEncryptSHA512(ByVal file_name As String)
        Dim sha512 As SHA512 = SHA512.Create()
        Dim hashValue() As Byte
        Dim fStream As FileStream = File.OpenRead(file_name)
        fStream.Position = 0
        hashValue = sha512.ComputeHash(fStream)
        Dim hash = GetStringFromHash(hashValue)
        fStream.Close()
        Return hash
    End Function

    Private Shared Function GetStringFromHash(hash As Byte()) As String
        Dim result As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            result.Append(hash(i).ToString("X2"))
        Next
        Return result.ToString()
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        txtSHA1.Text = EncryptSHA1(txtText.Text)
        txtSHA256.Text = EncryptSHA256(txtText.Text)
        txtSHA384.Text = EncryptSHA384(txtText.Text)
        txtSHA512.Text = EncryptSHA512(txtText.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog()

        OpenFileDialog1.InitialDirectory = SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtFile.Text = OpenFileDialog1.FileName
                txtSHA1.Text = FileEncryptSHA1(txtFile.Text)
                txtSHA256.Text = FileEncryptSHA256(txtFile.Text)
                txtSHA384.Text = FileEncryptSHA384(txtFile.Text)
                txtSHA512.Text = FileEncryptSHA512(txtFile.Text)
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtText.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(txtSHA1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Clipboard.SetText(txtSHA256.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Clipboard.SetText(txtSHA384.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Clipboard.SetText(txtSHA512.Text)
    End Sub
End Class