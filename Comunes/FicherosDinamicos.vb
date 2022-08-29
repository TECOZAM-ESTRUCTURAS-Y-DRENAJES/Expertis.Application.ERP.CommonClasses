Public Module FicherosDinamicos

    Public Function ComprobarExistenciaFichero(ByVal PathCompletoFichero As String) As Boolean
        If IO.File.Exists(PathCompletoFichero) Then
            If ExpertisApp.GenerateMessage("El Fichero ya existe. ¿Desea sobreescribir el fichero existente?", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                IO.File.Delete(PathCompletoFichero)
                Return True
            End If
        Else : Return True
        End If
    End Function

    Public Function CrearFicheroXML(ByVal StDatos As FicherosModeloDetalle.EstDatosFichero, ByVal PathCompletoFichero As String, ByVal ContenidoFichero As Byte(), ByVal EncodingXML As String) As Boolean
        '//Nombre del fichero completo (ruta con el nombre del fichero)
        Dim FilEx As New IO.FileInfo(PathCompletoFichero)
        If Not IO.Directory.Exists(FilEx.DirectoryName) Then
            IO.Directory.CreateDirectory(FilEx.DirectoryName)
        End If

        '//Codificación. Convertimos el array de bytes en String
        Dim enc As System.Text.Encoding
        Select Case UCase(EncodingXML)
            Case "UTF-8"
                enc = System.Text.Encoding.UTF8
            Case "UTF-7"
                enc = System.Text.Encoding.UTF7
            Case "UTF-32"
                enc = System.Text.Encoding.UTF32
            Case "ASCII"
                enc = System.Text.Encoding.ASCII
            Case Else
                enc = System.Text.Encoding.Unicode
        End Select
        Dim encChars(enc.GetCharCount(ContenidoFichero, 0, ContenidoFichero.Length) - 1) As Char
        enc.GetChars(ContenidoFichero, 0, ContenidoFichero.Length, encChars, 0)
        Dim encString As New String(encChars)

        Dim writer As Xml.XmlWriter = Xml.XmlWriter.Create(PathCompletoFichero)
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.LoadXml(encString)
        If TypeOf xmlDoc.FirstChild Is Xml.XmlDeclaration Then xmlDoc.RemoveChild(xmlDoc.FirstChild) '//Quitamos el nodo XmlDecaration

        '//Crear el nodo Declaración 
        Dim decl As Xml.XmlDeclaration
        decl = xmlDoc.CreateXmlDeclaration("1.0", EncodingXML, Nothing)

        '//Añadimos el nodo declaración al documento
        Dim root As Xml.XmlElement = xmlDoc.DocumentElement
        xmlDoc.InsertBefore(decl, root)

        '//Añadimos el atributo al nodo Raiz
        Dim fNodoRaiz As New Filter
        fNodoRaiz.Add("IDTipoFichero", FilterOperator.Equal, StDatos.DtDatos.Rows(0)("IDTipoFichero"))
        fNodoRaiz.Add("Tipo", FilterOperator.Equal, CInt(enumtbTipoDeclaracion.RaizXML))
        Dim adrRegistroRaiz() As DataRow = StDatos.DtDatos.Select(fNodoRaiz.Compose(New AdoFilterComposer))
        If Not adrRegistroRaiz Is Nothing AndAlso adrRegistroRaiz.Length > 0 AndAlso Length(adrRegistroRaiz(0)("Expresion")) > 0 Then
            Dim NombreAtributo, ValorAtributo As String
            Dim indice As Integer = Strings.InStr(adrRegistroRaiz(0)("Expresion"), "=")
            If indice > 0 Then
                NombreAtributo = Strings.Left(adrRegistroRaiz(0)("Expresion"), indice - 1)
                ValorAtributo = Strings.Right(adrRegistroRaiz(0)("Expresion"), Length(adrRegistroRaiz(0)("Expresion")) - indice)
                ValorAtributo = Replace(ValorAtributo, """", "")
            End If
            If Length(NombreAtributo) > 0 AndAlso Length(ValorAtributo) > 0 Then
                Dim elemRaiz As Xml.XmlElement = xmlDoc.DocumentElement
                elemRaiz.SetAttribute(NombreAtributo, ValorAtributo)
            End If
        End If

        xmlDoc.WriteTo(writer)
        writer.Close()

        CrearFicheroXML = True
    End Function

End Module
