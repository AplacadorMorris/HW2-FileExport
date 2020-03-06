Public Class Form1
    Private Sub text_btn_Click(sender As Object, e As EventArgs) Handles text_btn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("..\..\file_created\Text.txt", True)
        Txt.WriteLine("Name : " + name)
        Txt.WriteLine("Age : " + age)
        Txt.WriteLine("Address : " + add)
        Txt.Close()

        If Btn Then
            MessageBox.Show("Text is Created @ '\HW2-FileExport\file_created' ")
        End If
    End Sub

    REM XML FILE
    Private Sub xml_btn_Click(sender As Object, e As EventArgs) Handles xml_btn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("..\..\file_created\XML.xml", True)
        Txt.WriteLine("<Name>" + name + "</Name>")
        Txt.WriteLine("<Age>" + age + "</Age>")
        Txt.WriteLine("<Address>" + add + "</Address>")
        Txt.Close()

        If Btn Then
            MessageBox.Show("XML is Created @ '\HW2-FileExport\file_created' ")
        End If
    End Sub

    REM JSON FILE
    Private Sub json_btn_Click(sender As Object, e As EventArgs) Handles json_btn.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("..\..\file_created\JSON.json", True)
        Txt.WriteLine("{")
        Txt.WriteLine("  ""Name:"" " + name + ",")
        Txt.WriteLine("  ""Age:"" " + age + ",")
        Txt.WriteLine("  ""Address:"" " + add)
        Txt.WriteLine("},")
        Txt.Close()

        If Btn Then
            MessageBox.Show("JSON is Created @ '\HW2-FileExport\file_created' ")
        End If
    End Sub

    REM EXIT BUTTON
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    REM ROUND EDGES w/ NO BORDER
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
    End Sub

End Class
