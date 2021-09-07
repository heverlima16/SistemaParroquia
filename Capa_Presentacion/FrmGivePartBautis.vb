Imports iText.Kernel.Pdf
Imports iText.Kernel
Imports iText.Layout.Element
Imports iText.Layout
Imports iText.Layout.Properties
Imports iText.IO.Image


Public Class FrmGivePartBautis

    Private Sub FrmGivePartBautis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GeneratePdfBautizo("61717100")
    End Sub
    Private Sub GeneratePdfBautizo(dni As String)
        Dim location = "D:\"
        Dim namefile = dni
        Dim extensionFile = ".pdf"
        Dim pdfOuput = location + namefile + extensionFile
        Using wPdf = New PdfWriter(pdfOuput, New WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0))
            Dim pdfDocument = New PdfDocument(wPdf)
            Dim document = New Document(pdfDocument)
            '::::::::::::::Name Parroquia
            Dim pNameParroqui = New Paragraph().SetTextAlignment(TextAlignment.CENTER)
            Dim nameParroquia = "Parroquia Sam Pedro de Pampas"
            pNameParroqui.Add(New Text(nameParroquia).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12))
            document.Add(pNameParroqui)
            '::::::::::::::Name Parroquia
            Dim pNumberBook = New Paragraph()
            Dim numberBook = 12
            Dim foja = "gaa"
            Dim bNumber = 51
            pNumberBook.Add(New Text(numberBook))
            pNumberBook.Add(New Text("  " + foja + "  "))
            pNumberBook.Add(New Text(bNumber))
            document.Add(pNumberBook)
            '::::::::::::::LastName
            Dim lastname = "salazar Irrazabal"
            Dim pLastName = New Paragraph(New Text(lastname))
            document.Add(pLastName)

            '::::::::::::::Name
            Dim name = "Papi Chulo"
            Dim pName = New Paragraph(New Text(name))
            document.Add(pName)

            '::::::::::::::Father
            Dim father = "Lucas mergara"
            Dim pFather = New Paragraph(New Text(father))
            document.Add(pFather)

            '::::::::::::::Mother
            Dim mother = "Maria la diosa"
            Dim pMother = New Paragraph(New Text(mother))
            document.Add(pMother)

            '::::::::::::::Place of Birth
            Dim placeBirth = "Egipto"
            Dim pBirth = New Paragraph(New Text(placeBirth))
            document.Add(pBirth)

            '::::::::::::::date of Birth
            Dim dateBirth = "12/12/1999"
            Dim pDateBirth = New Paragraph(New Text(dateBirth))
            document.Add(pDateBirth)

            '::::::::::::::date of Baptism
            Dim dateBaptism = "12/12/2018"
            Dim pDateBaptism = New Paragraph(New Text(dateBaptism))
            document.Add(pDateBaptism)

            '::::::::::::::place of Baptism
            Dim placeBaptism = "en el lugar donde ella cantaba"
            Dim pPlaceBaptism = New Paragraph(New Text(placeBaptism))
            document.Add(pPlaceBaptism)

            '::::::::::::::Anotation
            Dim anotation = "en este campo va anotaciones gaa"
            Dim pAnotation = New Paragraph(New Text(anotation))
            document.Add(pAnotation)

            '::::::::::::::Date Document
            Dim pdate = New Paragraph().SetTextAlignment(TextAlignment.RIGHT)
            Dim day = 21
            Dim month = "december"
            Dim year = 21
            pdate.Add(New Text(day))
            pdate.Add(New Text("  " + month + "  "))
            pdate.Add(New Text(year))
            document.Add(pdate)

            '::::::::::::::Date Document
            Dim pdate2 = New Paragraph().SetTextAlignment(TextAlignment.LEFT)
            pdate2.Add(New Text(day))
            pdate2.Add(New Text("  " + month + "  "))
            pdate2.Add(New Text(year))
            document.Add(pdate2)

            document.Close()
            MsgBox("Document Gereneted")
        End Using

    End Sub

End Class