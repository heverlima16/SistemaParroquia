Imports iText.Kernel.Pdf
Imports iText.Kernel
Imports iText.Layout.Element
Imports iText.Layout
Imports iText.Layout.Properties
Imports iText.IO.Image
Imports System.Threading
Imports System.Data.SqlClient

Public Class FrmGivePartBautis
    Dim connection As New SqlConnection("Server= LAPTOP-7HVTS7G6; Database = DB_Parroquia; Integrated Security = true")
    'declare my varible ::::::::::::: gaa
    Dim index As Integer
    Public Sub FilterData(valueToSearch As String)
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = " Select PBautismo.Ba_Nombre as Nombre,PBautismo.Ba_Nombre as Apellido, PBautismo.Ba_Numero  as Bautismo ,PBautismo.Ba_NMadre as Madre, 
PBautismo.Ba_NPadre as Padre,  PBautismo.Ba_LNacimiento,Foja.fo_numero,Libro.li_numero,   PBautismo.Ba_FNacimiento, PBautismo.Ba_FBautismo, 
PBautismo.Ba_LBautismo,  CONCAT(PBautismo.Ba_NPadrino,' y ', PBautismo.Ba_NMadrina) as padrinos, PBautismo.Ba_AnotacionesTextuales from PBautismo
inner join Foja
on PBautismo.IdFoja = Foja.idfoja
inner join Libro
on Libro.idfoja = PBautismo.IdFoja WHERE Ba_Nombre like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub


    Private Sub GeneratePdfBautizo(dni As DataGridViewRow)


        Dim location = "D:\"
        Dim namefile = dni.Cells(0).Value.ToString() + dni.Cells(1).Value.ToString()
        Dim extensionFile = ".pdf"
        Dim pdfOuput = location + namefile + extensionFile
        Using wPdf = New PdfWriter(pdfOuput, New WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0))
            Dim pdfDocument = New PdfDocument(wPdf)
            Dim document = New Document(pdfDocument)
            '::::::::::::::Name Parroquia
            Dim pNameParroqui = New Paragraph().SetTextAlignment(TextAlignment.CENTER)
            Dim nameParroquia = "Parroquia San Pedro de Pampas"
            pNameParroqui.Add(New Text(nameParroquia).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12))
            document.Add(pNameParroqui)
            '::::::::::::::data Parroquia
            Dim pNumberBook = New Paragraph()
            Dim numberBook = dni.Cells(2).Value.ToString()
            Dim foja = dni.Cells(6).Value.ToString()
            Dim bNumber = dni.Cells(7).Value.ToString()
            pNumberBook.Add(New Text(numberBook))
            pNumberBook.Add(New Text("  " + foja + "  "))
            pNumberBook.Add(New Text(bNumber))
            document.Add(pNumberBook)
            '::::::::::::::LastName
            Dim lastname = dni.Cells(1).Value.ToString()
            Dim pLastName = New Paragraph(New Text(lastname))
            document.Add(pLastName)

            '::::::::::::::Name
            Dim name = dni.Cells(0).Value.ToString()
            Dim pName = New Paragraph(New Text(name))
            document.Add(pName)

            '::::::::::::::Father
            Dim father = dni.Cells(4).Value.ToString()
            Dim pFather = New Paragraph(New Text(father))
            document.Add(pFather)

            '::::::::::::::Mother
            Dim mother = dni.Cells(3).Value.ToString()
            Dim pMother = New Paragraph(New Text(mother))
            document.Add(pMother)

            '::::::::::::::Place of Birth
            Dim placeBirth = dni.Cells(5).Value.ToString()
            Dim pBirth = New Paragraph(New Text(placeBirth))
            document.Add(pBirth)

            '::::::::::::::date of Birth
            Dim dateBirth = dni.Cells(8).Value.ToString()
            Dim pDateBirth = New Paragraph(New Text(dateBirth))
            document.Add(pDateBirth)

            '::::::::::::::date of Baptism
            Dim dateBaptism = dni.Cells(9).Value.ToString()
            Dim pDateBaptism = New Paragraph(New Text(dateBaptism))
            document.Add(pDateBaptism)

            '::::::::::::::place of Baptism
            Dim placeBaptism = dni.Cells(10).Value.ToString()
            Dim pPlaceBaptism = New Paragraph(New Text(placeBaptism))
            document.Add(pPlaceBaptism)

            '::::::::::::::names godparents
            Dim godparents = dni.Cells(11).Value.ToString()
            Dim pGodparents = New Paragraph(New Text(godparents))
            document.Add(pGodparents)

            '::::::::::::::Anotation
            Dim anotation = dni.Cells(12).Value.ToString()
            Dim pAnotation = New Paragraph(New Text(anotation))
            document.Add(pAnotation)

            '::::::::::::::Date Document
            Dim pdate = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            'Dim day = New Date()
            Dim Bday = DateTime.Now.ToString("dd")
            Dim Bmonth = DateTime.Now.ToString("MM")
            Bmonth = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(Bmonth - 1)

            Dim Byear = DateTime.Now.ToString("yy")
            pdate.Add(New Text(Bday))
            pdate.Add(New Text("  " + Bmonth + "  "))
            pdate.Add(New Text(Byear))
            document.Add(pdate)

            '::::::::::::::Date Document
            Dim pdate2 = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            pdate2.Add(New Text(Bday))
            pdate2.Add(New Text("  " + Bmonth + "  "))
            pdate2.Add(New Text(Byear))
            document.Add(pdate2)

            document.Close()
            MsgBox("Document Gereneted", vbExclamation)
        End Using

    End Sub

    Private Sub BtnSearchUser_Click(sender As Object, e As EventArgs) Handles BtnSearchUser.Click

        If (TxtDNI.Text.Length > 2 And Not IsNumeric(TxtDNI.Text)) Then
            'SearchUserBautismo()
            FilterData(TxtDNI.Text)

        Else
            MsgBox("Por favor Ingresa solo Caracteres", vbExclamation)
        End If
    End Sub





    Private Sub FrmGivePartBautis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI.TextChanged
        'If (TxtDNI.Text.Length = 1 And Not IsNumeric(TxtDNI.Text)) Then
        'SearchUserBautismo()
        'FilterData(TxtDNI.Text)

        'Else
        'MsgBox("Por favor Ingresa solo Caracteres", vbExclamation)
        ' End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        If (selectedRow.Selected) Then

            GeneratePdfBautizo(selectedRow)
        End If



    End Sub


End Class