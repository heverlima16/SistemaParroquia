Imports iText.Kernel.Pdf
Imports iText.Kernel
Imports iText.Layout.Element
Imports iText.Layout
Imports iText.Layout.Properties
Imports iText.IO.Image
Imports System.Threading
Imports System.Data.SqlClient

Public Class FrmMatrimonio



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
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Columns(15).Visible = False
        DataGridView1.Columns(16).Visible = False


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
        Dim searchQuery As String = "Select 
 pma.Ma_NEsposo as Esposo,pma.Ma_NEsposa as Esposa, pma.Ma_LEsposo, pma.Ma_FNEsposo,pma.Ma_NPadreEsposo,pma.Ma_LEsposa, pma.Ma_FNEsposa, pma.Ma_NMadreEsposa,
 Parroquia.pa_nombre as Parroquia, pma.Ma_Numero as Numero, pma.Ma_NFoja as Foja, Libro.li_numero as Libro, 
 pma.Ma_FMatrimonio as FECH_MATRIMONIO, pma.Ma_LMatrimonio as LugarMatrimonio,
 pma.Ma_NPadrino as Padrino, pma.Ma_AnotacionesTextuales as Anotaciones, Sacerdote.sa_nombre as Sacerdote


from PMatrimonio as pma
inner join  Libro
on Libro.idlibro = pma.idlibro
inner join Sacerdote
on Sacerdote.idsacerdote = pma.idsacerdote
inner join Parroquia
on Parroquia.idparroquia = pma.IdParroquiaBautizado 
WHERE pma.Ma_NEsposo like  '%" & valueToSearch & "%'   or pma.Ma_NEsposa like  '%" & valueToSearch & "%'


"

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
            Dim nameParroquia = dni.Cells(8).Value.ToString()
            pNameParroqui.SetMargins(7, 0, 0, 0)
            pNameParroqui.Add(New Text(vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + vbCr + nameParroquia).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12))
            document.Add(pNameParroqui)

            '::::::::::::::data Parroquia
            Dim pNumberBook = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            Dim numberBook = dni.Cells(9).Value.ToString()
            Dim foja = dni.Cells(10).Value.ToString()
            Dim bNumber = dni.Cells(11).Value.ToString()





            'right
            pNumberBook.SetMargins(1, 35, 0, 0)
            pNumberBook.Add(New Text(bNumber))
            pNumberBook.Add(New Text("                  " + foja + "                          "))
            pNumberBook.Add(New Text(numberBook))

            document.Add(pNumberBook)

            '::::::::::::::Esposo

            Dim lastname = dni.Cells(0).Value.ToString()
            Dim pLastName = New Paragraph().SetTextAlignment(TextAlignment.CENTER)
            'lugar nacimiento+n fecha
            Dim lugar = dni.Cells(2).Value.ToString()
            pLastName.Add(New Text(vbCr + lastname))
            pLastName.Add(New Text("                                             " + lugar))

            'left 36
            pLastName.SetMargins(0, 0, 0, 80)
            document.Add(pLastName)

            '::::::::::::::Esposo fecha y padre name

            Dim fechaesposo = Convert.ToDateTime(dni.Cells(3).Value).ToString("yyyy-MM-dd")
            Dim pfechaesposo = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            'lugar nacimiento+n fecha
            Dim padreesposo = dni.Cells(4).Value.ToString()
            pfechaesposo.Add(New Text(fechaesposo))
            pfechaesposo.Add(New Text("                    " + padreesposo))

            'left
            pfechaesposo.SetMargins(22, 0, 0, 30)
            document.Add(pfechaesposo)


            '::::::::::::::Esposa

            Dim nombreesposa = dni.Cells(1).Value.ToString()
            Dim pnombreesposa = New Paragraph().SetTextAlignment(TextAlignment.CENTER)
            'lugar nacimiento+n fecha
            Dim lugaresposa = dni.Cells(5).Value.ToString()
            pnombreesposa.Add(New Text(nombreesposa))
            pnombreesposa.Add(New Text("                                             " + lugaresposa))

            'left
            pnombreesposa.SetMargins(24, 0, 0, 80)
            document.Add(pnombreesposa)

            '::::::::::::::Esposa fecha y padre name

            Dim fechaesposa = Convert.ToDateTime(dni.Cells(6).Value).ToString("yyyy-MM-dd")
            Dim pfechaesposa = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            'lugar nacimiento+n fecha
            Dim madreesposa = dni.Cells(7).Value.ToString()
            pfechaesposa.Add(New Text(fechaesposa))
            pfechaesposa.Add(New Text("                    " + madreesposa))

            'left
            pfechaesposa.SetMargins(26, 0, 0, 90)
            document.Add(pfechaesposa)




            '::::::::::::::Fechamatrimonio
            Dim father = Convert.ToDateTime(dni.Cells(12).Value).ToString("yyyy-MM-dd")
            Dim pFather = New Paragraph(New Text(father))
            pFather.SetMargins(1, 0, 0, 78)
            document.Add(pFather)



            '::::::::::::::lUGAR DE MATRI
            Dim mother = dni.Cells(13).Value.ToString()
            Dim pMother = New Paragraph(New Text(mother))
            pMother.SetMargins(0, 0, 0, 78)
            document.Add(pMother)

            '::::::::::::::PADRINO
            Dim placeBirth = dni.Cells(14).Value.ToString()
            Dim pBirth = New Paragraph(New Text(placeBirth))
            pBirth.SetMargins(6, 0, 0, 153)
            document.Add(pBirth)

            '::::::::::::::date of Birth
            ' Dim dateBirth = dni.Cells(8).Value


            ' Dim dateBirth = Convert.ToDateTime(dni.Cells(6).Value).ToString("yyyy-MM-dd")
            'Dim pDateBirth = New Paragraph(New Text(dateBirth))
            'pDateBirth.SetMargins(2, 0, 0, 153)
            'document.Add(pDateBirth)

            '::::::::::::::date of Baptism
            'Dim dateBaptism = dni.Cells(9).Value
            ' Dim dateBaptism = Convert.ToDateTime(dni.Cells(9).Value).ToString("yyyy-MM-dd")
            'Dim pDateBaptism = New Paragraph(New Text(dateBaptism))
            'pDateBaptism.SetMargins(0, 0, 0, 153)
            'document.Add(pDateBaptism)

            '::::::::::::::place of Baptism
            ' Dim placeBaptism = dni.Cells(10).Value.ToString()
            'Dim pPlaceBaptism = New Paragraph(New Text(placeBaptism))
            'pPlaceBaptism.SetMargins(1, 0, 0, 153)
            'document.Add(pPlaceBaptism)

            '::::::::::::::names godparents --- =2
            ' Dim godparents = dni.Cells(11).Value.ToString()
            'Dim pGodparents = New Paragraph(New Text(godparents))
            'pGodparents.SetMargins(2, 0, 0, 83)
            'document.Add(pGodparents)

            '::::::::::::::Anotation
            Dim anotation = dni.Cells(15).Value.ToString()
            Dim pAnotation = New Paragraph(New Text(anotation))
            pAnotation.SetMargins(3, 0, 0, 163)
            document.Add(pAnotation)

            '::::::::::::::Date Document --=7
            Dim pdate = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            pdate.SetMargins(0, 27, 0, 0)
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
            Dim parroco = dni.Cells(16).Value.ToString()
            Dim pParroco = New Paragraph(New Text(vbCr + vbCr + vbCr + parroco)).SetTextAlignment(TextAlignment.RIGHT)
            pParroco.SetMargins(14, 37, 0, 0)
            document.Add(pParroco)

            '::::::::::::::Date Document
            Dim pdate2 = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            pdate2.SetMargins(0, 0, 0, 73)
            pdate2.Add(New Text(vbCr + vbCr + vbCr + vbCr + Bday))
            pdate2.Add(New Text("                " + Bmonth + "               "))
            pdate2.Add(New Text(Byear))
            document.Add(pdate2)

            document.Close()
            MsgBox("Partida Generada Correctamente!!", vbExclamation)
        End Using

    End Sub

    Private Sub BtnSearchUser_Click(sender As Object, e As EventArgs) Handles BtnSearchUser.Click



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

    Private Sub FrmMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class