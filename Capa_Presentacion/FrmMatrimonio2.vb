Imports iText.Kernel.Pdf
Imports iText.Kernel
Imports iText.Layout.Element
Imports iText.Layout
Imports iText.Layout.Properties
Imports iText.IO.Image
Imports System.Threading
Imports System.Data.SqlClient



Public Class FrmMatrimonio2

    Private Sub Formato()
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True

        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False




        DataGridView1.Columns(0).Width = 250
        DataGridView1.Columns(1).Width = 250



    End Sub


    Dim connection As New SqlConnection("Server=PC-HEVER; Database = DB_Parroquia; Integrated Security = true")
    'declare my varible ::::::::::::: gaa
    Dim index As Integer
    '::::::::::::::::::::::::::folder location::::::::::::::::::::
    ' Dim location = "D:\"
    '::::::::::::::::::::::::::folder location::::::::::::::::::::



    Public Sub FilterData(valueToSearch As String)
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "Select PMatrimonio.Ma_NEsposo as Esposo,  PMatrimonio.Ma_NEsposa as Esposa ,PMatrimonio.Ma_FMatrimonio,PMatrimonio.Ma_LMatrimonio,
PMatrimonio.Ma_NPadrino,PMatrimonio.Ma_AnotacionesTextuales, PMatrimonio.Ma_Numero, PMatrimonio.Ma_NFoja, Libro.li_numero, Parroquia.pa_nombre, 
Sacerdote.sa_nombre
from PMatrimonio
inner join  Libro
on Libro.idlibro = PMatrimonio.IdLibro
inner join Sacerdote
on Sacerdote.idsacerdote = PMatrimonio.idsacerdote
inner join Parroquia
on Parroquia.idparroquia = PMatrimonio.IdParroquiaBautizado  WHERE PMatrimonio.Ma_NEsposo like '%" & valueToSearch & "%' or PMatrimonio.Ma_NEsposa like  '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub


    Private Sub GeneratePdfBautizo(dni As DataGridViewRow)
        '_________RAMDOM STRIG GENERATOR FOR NAME OF FILE_________
        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefg0123456789"

        Dim RND As New Random
        Dim cadena As String = ""
        Do Until cadena.Length = 3
            cadena += caracteres.ToCharArray(RND.Next(0, caracteres.Length), 1)
        Loop



        Dim location = "D:\"
        Dim namefile = dni.Cells(0).Value.ToString() + dni.Cells(1).Value.ToString() + cadena
        Dim extensionFile = ".pdf"
        Dim pdfOuput = location + namefile + extensionFile
        Using wPdf = New PdfWriter(pdfOuput, New WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0))
            Dim pdfDocument = New PdfDocument(wPdf)
            Dim document = New Document(pdfDocument)

            '::::::::::::::Name Parroquia
            Dim pNameParroqui = New Paragraph().SetTextAlignment(TextAlignment.CENTER)
            Dim nameParroquia = dni.Cells(9).Value.ToString()
            pNameParroqui.SetMargins(8, 0, 0, 0)
            pNameParroqui.Add(New Text(vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + nameParroquia).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12))
            document.Add(pNameParroqui)

            '::::::::::::::data Parroquia
            Dim pNumberBook = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            Dim numberBook = dni.Cells(6).Value.ToString()
            Dim foja = dni.Cells(7).Value.ToString()
            Dim bNumber = dni.Cells(8).Value.ToString()
            'right
            pNumberBook.SetMargins(2, 35, 0, 0)
            pNumberBook.Add(New Text(bNumber))
            pNumberBook.Add(New Text("                  " + foja + "                          "))
            pNumberBook.Add(New Text(numberBook))

            document.Add(pNumberBook)

            '::::::::::::::husband

            Dim lastname = dni.Cells(0).Value.ToString()
            Dim pLastName = New Paragraph(New Text(lastname))
            'left 16 ' 18
            pLastName.SetMargins(27, 0, 0, 80)
            document.Add(pLastName)

            '::::::::::::::wife
            Dim name = dni.Cells(1).Value.ToString()
            Dim pName = New Paragraph(New Text(name))
            pName.SetMargins(0, 0, 0, 80)
            document.Add(pName)



            '::::::::::::::date union
            Dim dateBaptism = Convert.ToDateTime(dni.Cells(2).Value).ToString("yyyy-MM-dd")
            Dim pDateBaptism = New Paragraph(New Text(dateBaptism))
            pDateBaptism.SetMargins(2, 0, 0, 145)
            document.Add(pDateBaptism)

            '::::::::::::::Place of union
            Dim placeBirth = dni.Cells(3).Value.ToString()
            Dim pBirth = New Paragraph(New Text(placeBirth))
            '6
            pBirth.SetMargins(1, 0, 0, 80)
            document.Add(pBirth)


            '::::::::::::::names godparents --- 
            Dim godparents = dni.Cells(4).Value.ToString()
            Dim pGodparents = New Paragraph(New Text(godparents))
            pGodparents.SetMargins(1, 0, 0, 83)
            document.Add(pGodparents)

            '::::::::::::::Anotation
            Dim anotation = dni.Cells(5).Value.ToString()
            Dim pAnotation = New Paragraph(New Text(anotation))
            '5
            pAnotation.SetMargins(1, 0, 0, 163)
            document.Add(pAnotation)

            '::::::::::::::Date Document --=7
            Dim pdate = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            '8
            pdate.SetMargins(22, 23, 0, 0)
            'Dim day = New Date()
            Dim Bday = DateTime.Now.ToString("dd")
            Dim Bmonth = DateTime.Now.ToString("MM")
            Bmonth = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(Bmonth - 1)

            Dim Byear = DateTime.Now.ToString("yy")
            pdate.Add(New Text(vbCr + vbCr + vbCr + vbCr + Bday))
            pdate.Add(New Text("                " + Bmonth + "               "))
            pdate.Add(New Text(Byear))
            document.Add(pdate)

            '::::::::::::::Parroco
            Dim parroco = dni.Cells(10).Value.ToString()
            Dim pParroco = New Paragraph(New Text(parroco)).SetTextAlignment(TextAlignment.RIGHT)
            '25
            pParroco.SetMargins(21, 35, 0, 0)
            document.Add(pParroco)

            '::::::::::::::Date Document
            Dim pdate2 = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            pdate2.SetMargins(12, 0, 0, 77)
            pdate2.Add(New Text(vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + Bday))
            pdate2.Add(New Text("                " + Bmonth + "               "))
            pdate2.Add(New Text(Byear))
            document.Add(pdate2)

            document.Close()
            MsgBox("Partida Generada Correctamente!!", vbExclamation)
        End Using

    End Sub

    Private Sub BtnSearchUser_Click(sender As Object, e As EventArgs) 

        If (TxtDNI.Text.Length > 1 And Not IsNumeric(TxtDNI.Text)) Then
            'SearchUserBautismo()
            FilterData(TxtDNI.Text)

        Else
            MsgBox("Por favor Ingresa solo Caracteres", vbExclamation)
        End If
    End Sub






    Private Sub TxtDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI.TextChanged
        If (Not IsNumeric(TxtDNI.Text)) Then
            'SearchUserBautismo()
            FilterData(TxtDNI.Text)
            Me.Formato()

        Else
            MsgBox("Por favor Ingresa solo Caracteres", vbExclamation)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        If (selectedRow.Selected) Then

            GeneratePdfBautizo(selectedRow)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim location = "D:\"
        Process.Start("explorer.exe", location)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmMatrimonio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub BtnSearchUser_Click_1(sender As Object, e As EventArgs) Handles BtnSearchUser.Click

    End Sub
End Class