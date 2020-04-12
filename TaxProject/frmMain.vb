Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim welcome As New Media.SoundPlayer("C:\source\workspaces\mhs\TaxProject\sounds\nickhi.wav")
        welcome.Play()
    End Sub
End Class