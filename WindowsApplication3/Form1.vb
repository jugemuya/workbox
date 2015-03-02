Imports System.IO
Imports JigFuncs
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim isec As Integer = CInt(Val(Me.TextBox1.Text))

        Dim handleWrk As IntPtr
        Dim rs As New ReadSector.SectorReaderTest
        Dim lstBytes As New List(Of Byte)(rs.ReadRawPartition(0, 1, isec, 10, handleWrk)) 'driveWrk.Name, 200))
        'Dim lstBytes2 As New List(Of Byte)(rs.ReadRawPartition(0, 1, 1, 1))

        MsgBox(handleWrk.ToString)

        MsgBox(handleWrk.ToString)

        MsgBox(handleWrk.ToString)

        MsgBox(handleWrk.ToString)

        MsgBox(handleWrk.ToString)

        Dim lstWrk As New List(Of String)
        For Each readD In lstBytes
            lstWrk.Add(readD.ToString)
        Next
        MsgBox(Join(lstWrk.ToArray, ""))
        Clipboard.SetText(Join(lstWrk.ToArray, ""))
    End Sub
End Class