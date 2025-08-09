Public Class FrmMain

    'Codigos de verificación
    Private m_StrYear As String = "ZRCHUXÑKEBM"
    Private m_StrMounth As String = "ZACHUFXWKEBMTIO"
    Private m_StrDate As String = "PLMNJIUHBVGY"
    Private m_StrCodesNum As String = "WITJZSPLYOA"

    Private m_Tipo_Servidor As String = "TJAIKQLSHV"
    Private m_Tipo_Cliente As String = "RNEOYZXPWB"

    '    'El tipo de aplicación que es
    Public Enum m_AppSabor
        gDevelop = -1                 'me... para mis cositas....  para lo mio
        Estandar = 0                   'Solucion general para todos
        Lite = 1                          'Versión recortada de la aplicacion estandar
        STecnico = 2                  'Tiendas de informatica, servicios tecnicos y demas
        Comercio = 3                   'Zapaterias, librerias, tiendas de pesca, caza,...
        Distribuidor = 4                   'Para distribuidores y/o mayorista
        Accesos = 5                   'Control de accesos
        Facturacion = 6               'Para una gestion de la facturacion
        Estetica = 7                'Para peluquerías y centros de estética
        Academias = 8                'Academias
        Talleres = 9                'Para talleres y concesionarios
        Ferralla = 10                 'Empresas de pesaje y aluminio


        Contabilidad = 11           'Puta contabilidad
        Eventos = 12                'Para talleres y concesionarios
        Socios = 14                 'Socios
        Fabricante = 15               'Fabricante
        webShop = 17                'Para tiendas online
        memoriam = 20               'Funerarias

        Hermandad = 21               'Hermandad


    End Enum



#Region "Eventos Principales"
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'm_RegisterApp = New gDevelop.ClassRegisterApp


        'MsgBox(Asc("a") & " - " & Asc("A"))

        'Me.TxtCode.Text = m_RegisterApp.GetCodeApp
        Me.TxtCode.Text = GetCodeApp()
        Me.LblFh.Text = "Fecha de código: " & Me.GetDateFromCode(Me.TxtCode.Text)

        Me.CbTipo.SelectedIndex = 0
        Me.CbSabor.SelectedIndex = 0

        Me.cbType.Items.Clear()
        For i As Integer = 0 To UBound(Me.arrTipo)
            Me.cbType.Items.Add(Me.arrTipo(i))
        Next

        Me.cbVersion.Items.Clear()
        For i As Integer = 0 To UBound(Me.arrVersiones)
            Me.cbVersion.Items.Add(Me.arrVersiones(i))
        Next

        Me.cbSoft.SelectedIndex = 0
        'Me.GeneraCodigoAPP("PYMEGEST.V3")
    End Sub

#End Region

#Region "Eventos Auxiliares"
    Private Sub BtGenerateUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGenerateUnLock.Click

        If Not Me.CbSabor.Text.Substring(0, 1) = "a" Then
            Me.TxtUnLockCode.Text = GetUnLockCodeApp(Me.TxtCode.Text)
        Else
            MsgBox("Generado magicamente, no se sabe porque, del codigo de la aplicación Android.", MsgBoxStyle.Information)
            Me.TxtUnLockCode.Text = "GDV_" & "1234"
        End If
        Me.LblFh.Text = "Fecha de código: " & Me.GetDateFromCode(Me.TxtCode.Text)
    End Sub

    Private Sub TxtUnLockCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUnLockCode.TextChanged
        'Me.BtUnLock.Enabled = (Me.TxtUnLockCode.TextLength > 0)
    End Sub

    Private Sub TxtCode_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCode.DoubleClick
        Me.TxtCode.Text = GetCodeApp()
        Me.TxtUnLockCode.Text = GetUnLockCodeApp(Me.TxtCode.Text)
        Me.LblFh.Text = "Fecha de código: " & Me.GetDateFromCode(Me.TxtCode.Text)
    End Sub

    Private Sub TxtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCode.TextChanged
        Me.BtGenerateUnLock.Enabled = (Me.TxtCode.TextLength > 0)
    End Sub
#End Region

    'Funcion que me obtiene el codigo de bloqueo de la aplicacion
    Public Function GetCodeApp() As String
        Dim StrAux As String = "", StrTmp As String = "", StrTmp1 As String = "", i As Integer = 0
        StrAux = My.Application.Info.ProductName.ToUpper
        Dim St As String = "", St1 As Integer = 0, St2 As String = "", St3 As String = "", StAux As String = "", intAux As Integer = 0

        'Codifico el nombre de la aplicacion en 2 cadenas
        For i = 0 To StrAux.Length - 1
            If i Mod 2 = 0 Then      'Codificacion de la primera
                StrTmp &= Format(Asc(StrAux.Substring(i, 1)), "000")
                'Si el ascii de la letra +23 no es una letra
                If Asc(StrAux.Substring(i, 1)) + 23 < 97 Then
                    St &= StrReverse(Asc(StrAux.Substring(i, 1)))
                Else
                    St &= Chr(Asc(StrAux.Substring(i, 1)) + 23)
                End If
            Else
                'StrTmp1 &= Format(Asc(StrAux.Substring(i, 1)), "000")
            End If

        Next
        St = St.ToUpper
        StrTmp1 = St
        For i = 0 To StrTmp1.Length - 1
            If IsNumeric(StrTmp1.Substring(i, 1)) Then       'Si es numerico lo sumo, si es char sumo el valor ascii
                St1 += StrTmp1.Substring(i, 1)
            Else
                St1 += (Asc(StrTmp1.Substring(i, 1)) Mod 23)
            End If
        Next
        St1 += StrTmp1.Length
        St1 += St1 Mod 23



        Dim StrYear As String = "ZRCHUXAKEBM", StrMounth As String = "ZACHUFXWKEBMTIO", StrDate As String = "PLMNJIUHBVGY"
        St2 = StrReverse(Format(Date.Now.Day, "00"))
        St2 &= StrYear.Substring(Format(Date.Now.Year, "0000").Substring(3, 1), 1)
        St2 &= StrMounth.Substring(Date.Now.Month, 1)

        'Le meto un codigo de verificacion a la fecha
        StAux = Asc(St2.Substring(2, 1)) + Asc(St2.Substring(3, 1))
        Do
            intAux = 0
            For i = 0 To StAux.Length - 1
                intAux += StAux.Substring(i, 1)
            Next
            StAux = intAux
        Loop While (StAux.Length > 1)
        intAux += Asc(StrDate.Substring(intAux, 1))
        St2 &= intAux

        'Numero aleatorio
        Dim rnd1 As New Random(DateTime.Now.Millisecond * 23)
        Dim rnd As New Random(DateTime.UtcNow.Millisecond Mod rnd1.Next(23, 180))
        St3 = Format(rnd.Next(0, 9999), "0000")

        Return St & "-" & St2 & "-" & St3 & "-" & St1
    End Function

    'Funcion que me genera el codigo de des-bloqueo
    Private Function GetUnLockCodeApp(ByVal strCode As String) As String
        Dim St As String = "", St1 As String = "", St2 As String, St3 As String, StrUnLockCode As String = "", intControl As Integer
        Dim i As Integer, IntAux As Integer = 0, StrAux As String = "", StrTmp As String = ""
        Dim StAux As String() = strCode.Split("-")
        'Verificaciones previas
        '- Tres guiones ('2')
        If StAux.Length <> 4 Then
            MsgBox("Error de formato del código", MsgBoxStyle.Critical)
            Return "ERROR FORMAT"
        End If

        'El codigo de verifacion
        St = StAux(0)
        St1 = StAux(3)
        St2 = StAux(1)
        St3 = StAux(2)

        '- El codigo de encriptacion del primer miembro
        For i = 0 To St.Length - 1
            If IsNumeric(St.Substring(i, 1)) Then       'Si es numerico lo sumo, si es char sumo el valor ascii
                IntAux += St.Substring(i, 1)
            Else
                IntAux += (Asc(St.Substring(i, 1)) Mod 23)
            End If
        Next
        IntAux += St.Length
        IntAux += IntAux Mod 23

        If IntAux <> St1 Then
            MsgBox("Error de verificación del código", MsgBoxStyle.Critical)
            Return "ERROR CODE VERIFICATION"
        End If

        'Verifico el st3 es numerico solo
        If Not IsNumeric(St3) Then
            MsgBox("Error de verificación del código numerico", MsgBoxStyle.Critical)
            Return "ERROR CODE VERIFICATION NUMBER"
        End If

        '- Verefico el formato de la fecha
        Dim StrYear As String = "ZRCHUXÑKEBM", StrMounth As String = "ZACHUFXWKEBMTIO", StrDate As String = "PLMNJIUHBVGY", StrCodesNum As String = "WITJZSPLYOA"
        'IntAux = StrYear.IndexOf(St2.Substring(0, 1))

        'Verifico el dia
        If Not IsNumeric(St2.Substring(0, 2)) OrElse (StrReverse(St2.Substring(0, 2)) < 1 And StrReverse(St2.Substring(0, 2)) > 31) Then
            MsgBox("Error de verificación de formato de fecha", MsgBoxStyle.Critical)
            Return "ERROR CODE VERIFICATION FORMAT DATE"
        End If


        StrAux = Asc(St2.Substring(2, 1)) + Asc(St2.Substring(3, 1))
        Do
            IntAux = 0
            For i = 0 To StrAux.Length - 1
                IntAux += StrAux.Substring(i, 1)
            Next
            StrAux = IntAux
        Loop While (StrAux.Length > 1)
        IntAux += Asc(StrDate.Substring(IntAux, 1))
        intControl = IntAux
        If St2.Substring(4) <> IntAux Then
            MsgBox("Error de verificación del fecha", MsgBoxStyle.Critical)
            Return "ERROR CODE VERIFICATION DATE"
        End If


        'Genero una primera contraclave numerica del primer miembro
        StrAux = St
        IntAux = 0
        For i = 0 To StrAux.Length - 1
            If IsNumeric(StrAux.Substring(i, 1)) Then
                StrTmp &= StrCodesNum.Substring(StrAux.Substring(i, 1), 1)
            Else
                'Si es una letra, vez si, vez no la tomo mayuscula/minuscula
                If i Mod 2 = 0 Then
                    IntAux += Asc(StrAux.Substring(i, 1).ToLower)
                Else
                    IntAux -= Asc(StrAux.Substring(i, 1).ToUpper)

                End If
            End If
            'IntAux 
        Next

        Dim StrTmp1 As String = "", IntTmp As Integer = 0, StrTipo As String = ""
        'Codifico las letras obteniadas anteriores
        For i = 0 To StrTmp.Length - 1
            If i Mod 2 = 0 Then      'Codificacion de la primera
                'Si el ascii de la letra +23 no es una letra
                If Asc(StrTmp.Substring(i, 1)) + 23 < 97 Then
                    StrTmp1 &= StrReverse(Asc(StrAux.Substring(i, 1)))
                Else
                    StrTmp1 &= Chr(Asc(StrTmp.Substring(i, 1)) + 23)
                End If
            End If
        Next


        Dim StrTmp2 As String = StrCodesNum.Substring(St3.Substring(0, 1), 1) & StrCodesNum.Substring(St3.Substring(1, 1), 1)
        For i = 0 To St3.Length - 1
            IntTmp += St3.Substring(i, 1)
        Next
        StrTmp2 &= ((St3 * St1) Mod IntTmp)

        'Codifico el tipo de aplicacion
        Dim str As String = IIf(Me.CbTipo.SelectedIndex = 0, Me.m_Tipo_Servidor, Me.m_Tipo_Cliente)
        Dim y As Integer = 0
        Dim generator As New Random
        i = generator.Next(str.Length)

        StrTipo = str.Substring(i, 1)
        y = Asc(StrTipo) Mod 17
        StrTipo = StrTipo & StrReverse(Format(y, "00"))

        IntTmp = 0
        For i = 0 To Me.CbSabor.Text.Length - 1
            IntTmp += Asc(Me.CbSabor.Text.Substring(i, 1))
        Next

        StrTipo &= IntTmp \ y

        StrUnLockCode = StrTmp & "-" & Format((IntAux * St1) - intControl, "########") & "-" & StrTmp1.ToUpper & "-" & StrTipo & "-" & StrTmp2

        Return StrUnLockCode
    End Function


    'Funcion que me saca de la contraclave la fecha de instalacion
    Private Function GetDateFromCode(ByVal StrLockCode As String) As Date
        On Error GoTo ErrHandler
        'Chequeamos que el codigo es correcto

        Dim StDate As String = ""
        Dim i As Integer, StrAux As String = ""
        Dim StAux As String() = StrLockCode.Split("-")

        'El codigo de verifacion
        StDate = StAux(1)
        StrAux = StrReverse(StDate.Substring(0, 2)) & "/"      'El dia


        StrAux &= Format(Me.m_StrMounth.IndexOf(StDate.Substring(3, 1)), "00") & "/"      'El mes
        StrAux &= "201" & Me.m_StrYear.IndexOf(StDate.Substring(2, 1))       'El año

        Return CDate(StrAux)
ErrHandler:
    End Function

    Private Sub btCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheck.Click
        'Tengo que sacar que tipo de aplicación es por el codigo de registro
        Dim _strTipo_Servidor As String = "TJAIKQLSHV"
        Dim _strTipo_Cliente As String = "RNEOYZXPWB"

        'Los nombre tipo de la aplicacion
        Dim _typeApp_gDevelop As String = "gDevelop©"
        Dim _typeApp_Estandar As String = "ESTANDAR"
        Dim _typeApp_Lite As String = "LITE"
        Dim _typeApp_STecnico As String = "STECNICO"
        Dim _typeApp_Comercio As String = "COMerCIO"
        Dim _typeApp_Mayorista As String = "MAYORisTA"
        Dim _typeApp_Accesos As String = "ACceSOS"
        Dim _typeApp_Socios As String = "soCIOS"
        Dim _typeApp_Peluqueria As String = "PELUQUERIA"
        Dim _typeApp_Talleres As String = "Talleres"
        Dim _typeApp_Academias As String = "AcadEMIas"
        Dim _typeApp_Feralla As String = "FerraLLa"
        Dim _typeApp_Facturacion As String = "FACTurACION"


        Dim _typeApp_Eventos As String = "EvenTOS"
        Dim _typeApp_MemoriamM As String = "MeMORIamM"
        Dim _typeApp_webSHOP As String = "webSHOP"
        Dim _typeApp_PUTAContabiLIDAD As String = "PUTAContabiLIDAD"

        Dim _typeApp_Fabricante As String = "Fabricante"

        Dim _typeApp_Hermandad As String = "hERMandad"


        Dim arrUnLock As String() = Me.TxtUnLockCode.Text.Split("-")
        If arrUnLock.Length <> 5 Then
            MsgBox("Error de validación de código.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        'Verifico si es una clave servidor o cliente
        Dim i As Integer = 0, y As Integer = 0, intTmp As Integer = 0, strAux As String = ""
        Dim idSabor As m_AppSabor
        Dim str As String = arrUnLock(3).Substring(0, 1)

        y = Asc(str) Mod 17
        str = str & StrReverse(Format(y, "00"))

        ' ### -1 >> Verifico si es gDevelop©
        intTmp = 0
        For i = 0 To _typeApp_gDevelop.Length - 1
            intTmp += Asc(_typeApp_gDevelop.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.gDevelop


        '###  0 >> Verifico si es el ESTANDAR
        intTmp = 0
        For i = 0 To _typeApp_Estandar.Length - 1
            intTmp += Asc(_typeApp_Estandar.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Estandar


        '###  1 >> Verifico si es el LITE
        intTmp = 0
        For i = 0 To _typeApp_Lite.Length - 1
            intTmp += Asc(_typeApp_Lite.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Lite


        '###  2 >> Verifico si es STecnico
        intTmp = 0
        For i = 0 To _typeApp_STecnico.Length - 1
            intTmp += Asc(_typeApp_STecnico.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.STecnico


        '###  3 >> Verifico si es Comercio
        intTmp = 0
        For i = 0 To _typeApp_Comercio.Length - 1
            intTmp += Asc(_typeApp_Comercio.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Comercio


        '###  4 >> Verifico si es Mayorista
        intTmp = 0
        For i = 0 To _typeApp_Mayorista.Length - 1
            intTmp += Asc(_typeApp_Mayorista.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Distribuidor


        '### 5 >> Verifico si es Accesos
        intTmp = 0
        For i = 0 To _typeApp_Accesos.Length - 1
            intTmp += Asc(_typeApp_Accesos.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Accesos


        '### 6 >> Verifico si es Facturacion
        intTmp = 0
        For i = 0 To _typeApp_Facturacion.Length - 1
            intTmp += Asc(_typeApp_Facturacion.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Facturacion

        '###  7 >> Verifico si es Peluqueria
        intTmp = 0
        For i = 0 To _typeApp_Peluqueria.Length - 1
            intTmp += Asc(_typeApp_Peluqueria.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Estetica

        '###  8 >> Verifico si es Taller
        intTmp = 0
        For i = 0 To _typeApp_Talleres.Length - 1
            intTmp += Asc(_typeApp_Talleres.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Talleres

        '### 9 >> Verifico si es una academia
        intTmp = 0
        For i = 0 To _typeApp_Academias.Length - 1
            intTmp += Asc(_typeApp_Academias.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Academias

        '### 10 >> Verifico si es Ferralla
        intTmp = 0
        For i = 0 To _typeApp_Feralla.Length - 1
            intTmp += Asc(_typeApp_Feralla.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Ferralla

        '### 10 >> Verifico si es Ferralla
        intTmp = 0
        For i = 0 To _typeApp_Feralla.Length - 1
            intTmp += Asc(_typeApp_Feralla.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Ferralla

        '### 11 >> Verifico si es Contabilidad
        intTmp = 0
        For i = 0 To _typeApp_PUTAContabiLIDAD.Length - 1
            intTmp += Asc(_typeApp_PUTAContabiLIDAD.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Contabilidad

        '### 12 >> Verifico si es Eventos
        intTmp = 0
        For i = 0 To _typeApp_Eventos.Length - 1
            intTmp += Asc(_typeApp_Eventos.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Eventos

        '### 14 >> Verifico si es socios
        intTmp = 0
        For i = 0 To _typeApp_Socios.Length - 1
            intTmp += Asc(_typeApp_Socios.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Socios

        '### 15 >> Verifico si es FABRICANTE
        intTmp = 0
        For i = 0 To _typeApp_fabricante.Length - 1
            intTmp += Asc(_typeApp_Socios.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Socios

        '### 17 >> Verifico si es webSHOP
        intTmp = 0
        For i = 0 To _typeApp_webSHOP.Length - 1
            intTmp += Asc(_typeApp_webSHOP.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.webShop

        '### 20 >> Verifico si es Memoriam
        intTmp = 0
        For i = 0 To _typeApp_MemoriamM.Length - 1
            intTmp += Asc(_typeApp_MemoriamM.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.memoriam

        '### 21 >> Verifico si es HERMANDAD
        intTmp = 0
        For i = 0 To _typeApp_Hermandad.Length - 1
            intTmp += Asc(_typeApp_Hermandad.Substring(i, 1))
        Next
        strAux = str & (intTmp \ y)
        If arrUnLock(3) = strAux Then idSabor = m_AppSabor.Hermandad


        'Obtengo el tipo de sabor
        str = ""
        Select Case idSabor
            Case m_AppSabor.gDevelop : str = "gDevelop"
            Case m_AppSabor.Estandar : str = "Estandar"
            Case m_AppSabor.Lite : str = "Lite"
            Case m_AppSabor.STecnico : str = "STécnico"
            Case m_AppSabor.Comercio : str = "Comercio"
            Case m_AppSabor.Distribuidor : str = "Distribuidor"
            Case m_AppSabor.Accesos : str = "Accesos"
            Case m_AppSabor.Socios : str = "Socios"
            Case m_AppSabor.Estetica : str = "Estetica"
            Case m_AppSabor.Talleres : str = "Talleres"
            Case m_AppSabor.Academias : str = "Academias"
            Case m_AppSabor.Facturacion : str = "Facturación"

            Case m_AppSabor.Contabilidad : str = "Contabilidad"
            Case m_AppSabor.Eventos : str = "Eventos"
            Case m_AppSabor.webShop : str = "webShop"
            Case m_AppSabor.memoriam : str = "Memoriam"

            Case m_AppSabor.Fabricante : str = "Fabricante"

            Case m_AppSabor.Hermandad : str = "Hermandades"

            Case Else : str = "NO CONTROLADO"
        End Select
        MsgBox(str)
    End Sub

    Private Sub CbSabor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSabor.SelectedIndexChanged
        Me.BtGenerateUnLock.Enabled = IIf(Me.CbSabor.Text.Substring(0, 2) = "--", False, True)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub cbSoft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSoft.SelectedIndexChanged
        Me.GeneraCodigoAPP(Me.cbSoft.Text)
        Me.GeneraUnLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text)
    End Sub

    ' CÓDIGOS NUMERICOS
    Private _strLockCodesNum As String = "WITJZSPLYOA"
    Private _strUnlockCodesNum As String = "RTWLLBIOASP"

    ' CÓDIGOS LETRAS
    Private _strLockCodesLetters As String = "1SD05H48KGZES2TLBFR4AY369"
    Private _strUnLockCodesLetters As String = "81H464AY3S2T9SLBF5KD0GZER"

    ' CÓDIGOS DE MESES
    Private _strLockMonths As String = "DGZS2TFR4A971"
    Private _strunLockMonths As String = "ZS4RAGF92TD17"

    'TIPOS
    Private arrSoft() As String = New String() {"PYMEGEST.V3", "GTPV.V2", "GSAD.V2", "GRUTAMAHI.V2", "OTHERS"}
    Private arrTipo() As String = New String() {"SERVIDOR", "CLIENTE", "TERMINAL", "PLUS", "ANONYMOUS"}

    ' Se usan las dos primeras letras para la generación del código
    Private arrVersiones() As String = New String() {"NINGUNO", "ESTANDAR", "LITE", "COMERCIO", "STECNICO", "MAYORISTA", "PELUQUERIA", "HERMANDADES", "TALLERES", "ACADEMIAS", "CONTABILIDAD", "FACTURACION", "REALSTATE", "ENTRADAS", "OTROS", "GDV"}

    Private Sub GeneraCodigoAPP(Optional sSoft As String = "PYMEGEST.V3")
        Dim sAPP As String = "", sCode As String = "", sDate As String = "", sChecksum As String = ""

        Dim str As String = ""
        Dim sTemp As String = ""
        Dim sTmpChk As String = ""

        ' CODIGO DE APP
        sSoft = sSoft.ToUpper

        ' Compruebo los tipos de softwares
        Select Case sSoft
            Case "PYMEGEST.V3" : sTmpChk = "Y"
            Case "GTPV.V2" : sTmpChk = "S"
            Case "GSAD.V2" : sTmpChk = "3"
            Case "GRUTAMAHI.V2" : sTmpChk = "1"
            Case "OTHERS" : sTmpChk = "I"
            Case Else
                Err.Raise(22, "gdv", "Versión de app incorrecta")
        End Select

        sAPP = sSoft.Substring(0, 1)
        sAPP &= sSoft.Substring(1, 1)
        sAPP &= sSoft.Substring(sSoft.Length - 1, 1)

        sTemp = Asc(sAPP.Substring(0, 1))
        sAPP &= sTemp.Substring(sTemp.Length - 1, 1)

        sTemp = Asc(sSoft.Substring(sSoft.Length - 1, 1))
        sAPP &= sTemp.Substring(sTemp.Length - 1, 1)



        ' CÓDIGO DE APP (GENERO 2 numeros aleatorios y asigno
        sCode = ""

        Dim rnd1 As New Random(DateTime.Now.Millisecond * 23)
        sTemp = rnd1.Next(9)
        sCode = sTemp
        sCode &= Me._strLockCodesNum.Substring(sTemp, 1)
        sCode &= Me._strLockCodesLetters.Substring(sTemp, 1)

        rnd1 = New Random(DateTime.Now.Second * 50)
        sTemp = rnd1.Next(9)
        'sTemp = sTemp
        sTemp &= Me._strLockCodesNum.Substring(sTemp, 1)
        sCode &= StrReverse(sTemp)



        'FECHA
        sDate = ""
        Dim dt As Date = Me.dtFh.Value
        sDate &= Me._strLockCodesLetters.Substring(Format(dt.Day, "00").Substring(1, 1), 1)
        sDate &= Me._strLockCodesLetters.Substring(Format(dt.Day, "00").Substring(0, 1), 1)
        sDate &= Me._strLockMonths.Substring(dt.Month, 1)

        sDate &= Me._strLockMonths.Substring(dt.Year.ToString.Substring(2, 1), 1)
        sDate &= Me._strLockMonths.Substring(dt.Year.ToString.Substring(3, 1), 1)

        ' CHECKSUM
        sChecksum = ""

        Select Case sAPP.Substring(0, 2)
            Case "PY" : sChecksum = "7"
            Case "GT" : sChecksum = "N"
            Case "GS" : sChecksum = "2"
            Case "GR" : sChecksum = "0"
            Case "OT" : sChecksum = "9"
        End Select


        sChecksum &= sTmpChk

        sChecksum &= StrReverse(dt.Year.ToString.Substring(2, 2))

        rnd1 = New Random(DateTime.Now.Millisecond * 32)
        sTemp = rnd1.Next(9)
        sChecksum &= sTemp.Substring(0, 1)

        ''MsgBox(Me.CbSabor.Text)

        Me.txtCode_App.Text = sAPP
        Me.txtCode_code.Text = sCode
        Me.txtCode_date.Text = sDate
        Me.txtCode_checksum.Text = sChecksum
    End Sub


    Private Function GeneraUnLockCodeApp(ByVal sApp As String, sCode As String, sDate As String, sChecksum As String) As String
        Dim str As String = "", sTemp As String = ""
        Dim sUnlockAPP As String = "", sUnlockVersion As String = "", sUnlockDate As String = "", sUnlockChecksum As String = ""

        If Not checkCodeApp(sApp, sCode, sDate, sChecksum) Then Return ""


        Dim sTmpChk As String = ""

        ' Compruebo las dos primeras letras
        Select Case sApp.Substring(0, 2)
            Case "PY" : sTmpChk = "J" : sUnlockAPP = "GD" : sTemp = "7"
            Case "GT" : sTmpChk = "5" : sUnlockAPP = "TV" : sTemp = "N"
            Case "GS" : sTmpChk = "7" : sUnlockAPP = "AD" : sTemp = "2"
            Case "GR" : sTmpChk = "O" : sUnlockAPP = "GM" : sTemp = "0"
            Case "OT" : sTmpChk = "P" : sUnlockAPP = "TR" : sTemp = "9"
            Case Else
                Return ""
        End Select

        If sChecksum.Substring(0, 1) <> sTemp Then Return ""

        sUnlockAPP &= StrReverse(Asc(sApp.Substring(2, 1)).ToString).Substring(0, 1)
        sUnlockAPP &= _strUnlockCodesNum.Substring(sApp.Substring(3, 1), 1)

        sUnlockAPP &= sTemp



        '        Dim rnd1 As New Random(DateTime.Now.Millisecond * 23)

        ' TIPO DE INSTALACION
        sUnlockVersion = ""
        If Me.cbType.SelectedIndex >= 0 Then
            'sUnlockVersion &= sChecksum.Substring(2, 1)
            sUnlockVersion &= Me._strunLockMonths(sChecksum.Substring(4, 1))
            sUnlockVersion &= Me._strunLockMonths.Substring(Me._strLockCodesLetters.IndexOf(sDate.Substring(0, 1)), 1)
            sUnlockVersion &= Me._strunLockMonths.Substring(Me.cbType.SelectedIndex, 1)
        End If

        ' TIPO DE VERSION
        sTemp = ""
        If Me.cbVersion.SelectedIndex >= 0 Then

            sUnlockVersion &= Me._strLockCodesLetters.Substring(Asc(Me.cbVersion.Text.Substring(0, 1)) - 65, 1)
            sUnlockVersion &= Me._strLockCodesLetters.Substring(Asc(Me.cbVersion.Text.Substring(1, 1)) - 65, 1)

            sTemp = (Asc(Me.cbVersion.Text.Substring(0, 1)) + Asc(Me.cbVersion.Text.Substring(1, 1))) Mod 9
        End If


        'DATE
        sUnlockDate = ""
        Dim dt As Date = Me.dtFhRegister.Value
        sUnlockDate &= Me._strUnLockCodesLetters.Substring(Format(Me.dtFhRegister.Value.Day, "00").Substring(1, 1), 1)
        sUnlockDate &= Me._strUnLockCodesLetters.Substring(Format(Me.dtFhRegister.Value.Day, "00").Substring(0, 1), 1)

        sUnlockDate &= Me._strunLockMonths.Substring(dt.Month, 1)

        sUnlockDate &= Me._strunLockMonths.Substring(dt.Year.ToString.Substring(2, 1), 1)
        sUnlockDate &= Me._strunLockMonths.Substring(dt.Year.ToString.Substring(3, 1), 1)

        sUnlockDate = StrReverse(sUnlockDate)




        'CHECKSUM
        sUnlockChecksum = ""
        If sUnlockVersion.Length = 5 Then
            sUnlockChecksum &= sTemp
            sUnlockChecksum &= StrReverse(sChecksum.Substring(1, 2))
            sUnlockChecksum &= Asc(sUnlockVersion.Substring(2, 1)).ToString.Substring(1, 1)
            sUnlockChecksum &= Me._strUnlockCodesNum(sChecksum.Substring(4, 1))
        End If
        Me.txtUnlockCode_App.Text = sUnlockAPP
        Me.txtUnlockCode_version.Text = sUnlockVersion
        Me.txtUnlockCode_date.Text = sUnlockDate
        Me.txtUnlockCode_checksum.Text = sUnlockChecksum

        Return sUnlockAPP & "-" & sUnlockVersion & "-" & sUnlockDate & "-" & sUnlockChecksum
    End Function

    Private Sub btUnlockKey_Click(sender As Object, e As EventArgs) Handles btUnlockKey.Click
        Me.lblFhCode.Text = ""
        Me.lblFhCodeUnLock.Text = ""
        Me.lblTipo.Text = ""
        Me.lblVersion.Text = ""
        Me.txtUnlockKey.Text = ""
        Me.lblSoft.Text = ""

        If Me.cbType.SelectedIndex < 0 Then
            MsgBox("Establezca tipo", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.cbVersion.SelectedIndex < 0 Then
            MsgBox("Establezca versión", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim str As String = ""
        str = Me.GeneraUnLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text)
        If str.Length <> 23 Then
            MsgBox("Clave no válida.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            Me.lblSoft.Text = Me.arrSoft(Me.GetSoftAPP(Me.txtCode_App.Text))
        Catch ex As Exception
            Me.lblSoft.Text = "ERROR"
            Exit Sub
        End Try

        Try
            Me.lblTipo.Text = Me.arrTipo(Me.GetTypeAPP(Me.txtUnlockCode_version.Text))
        Catch ex As Exception
            Me.lblTipo.Text = "ERROR"
            Exit Sub
        End Try

        Try
            Me.lblVersion.Text = Me.arrVersiones(Me.GetVersionAPP(Me.txtUnlockCode_version.Text))
        Catch ex As Exception
            Me.lblVersion.Text = "ERROR"
            Exit Sub
        End Try

        Me.lblFhCode.Text = Me.GetDateInstall(Me.txtCode_date.Text)
        Me.lblFhCodeUnLock.Text = Me.GetDateInstallDone(Me.txtUnlockCode_date.Text)

        Me.txtUnlockKey.Text = Me.txtUnlockCode_App.Text & "-" & Me.txtUnlockCode_version.Text & "-" & Me.txtUnlockCode_date.Text & "-" & Me.txtUnlockCode_checksum.Text
    End Sub

    Private Function GetDateInstall(sCode As String) As Date
        Dim str As String = ""

        str &= "" & Me._strLockCodesLetters.IndexOf(sCode.Substring(1, 1))
        str &= "" & Me._strLockCodesLetters.IndexOf(sCode.Substring(0, 1))


        str &= "/" & Format(Me._strLockMonths.IndexOf(sCode.Substring(2, 1)), "00")
        str &= "/20"

        str &= "" & Me._strLockMonths.IndexOf(sCode.Substring(3, 1))
        str &= "" & Me._strLockMonths.IndexOf(sCode.Substring(4, 1))

        Return str
    End Function

    Private Function GetDateInstallDone(sCode As String) As Date
        Dim str As String = ""
        sCode = StrReverse(sCode)
        str &= "" & Me._strUnLockCodesLetters.IndexOf(sCode.Substring(1, 1))
        str &= "" & Me._strUnLockCodesLetters.IndexOf(sCode.Substring(0, 1))


        str &= "/" & Format(Me._strunLockMonths.IndexOf(sCode.Substring(2, 1)), "00")
        str &= "/20"

        str &= "" & Me._strunLockMonths.IndexOf(sCode.Substring(3, 1))
        str &= "" & Me._strunLockMonths.IndexOf(sCode.Substring(4, 1))


        Return str
    End Function

    Private Function GetSoftAPP(sApp As String) As Integer
        Dim n As Integer = -1
        ' Compruebo las dos primeras letras
        Select Case sApp.Substring(0, 2)
            Case "PY" : n = 0
            Case "GT" : n = 1
            Case "GS" : n = 2
            Case "GR" : n = 3
            Case "OT" : n = 4
            Case Else
                Err.Raise(22, "gdv", "Tipo de app no controlada")
        End Select
        Return n
    End Function

    Private Function GetTypeAPP(sCode As String) As Integer
        Dim sw As Boolean = True

        If Not Me._strunLockMonths.Contains(sCode.Substring(2, 1)) Then sw = False
        If InStr(Me._strunLockMonths, sCode.Substring(2, 1)) - 1 > UBound(Me.arrTipo) Then sw = False

        If Not sw Then Err.Raise(22, "gdv", "Tipo de app no controlada")

        Return InStr(Me._strunLockMonths, sCode.Substring(2, 1)) - 1
    End Function

    Private Function GetVersionAPP(sCode As String) As Integer
        For i As Integer = 0 To UBound(Me.arrVersiones)
            If sCode.Substring(3, 2) = Me._strLockCodesLetters.Substring(Asc(Me.arrVersiones(i).ToString.Substring(0, 1)) - 65, 1) & Me._strLockCodesLetters.Substring(Asc(Me.arrVersiones(i).ToString.Substring(1, 1)) - 65, 1) Then
                Return i
            End If
        Next
        Err.Raise(22, "gdv", "Versión de app no controlada")
    End Function

    Private Sub cbUnlock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged, cbVersion.SelectedIndexChanged
        Me.GeneraUnLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text)
    End Sub

    Private Sub btReloadCodeAPP_Click(sender As Object, e As EventArgs) Handles btReloadCodeAPP.Click
        Me.lblFhCode.Text = ""
        Me.lblFhCodeUnLock.Text = ""
        Me.lblTipo.Text = ""
        Me.lblVersion.Text = ""
        Me.txtUnlockKey.Text = ""

        Me.GeneraCodigoAPP(Me.cbSoft.Text)
        Me.GeneraUnLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text)
    End Sub

    Private Sub dtFh_ValueChanged(sender As Object, e As EventArgs) Handles dtFh.ValueChanged, dtFhRegister.ValueChanged
        Me.GeneraCodigoAPP(Me.cbSoft.Text)
        Me.GeneraUnLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text)
    End Sub

    Private Sub btCheckReg_Click(sender As Object, e As EventArgs) Handles btCheckReg.Click
        Me.lblFhCode.Text = ""
        Me.lblFhCodeUnLock.Text = ""
        Me.lblTipo.Text = ""
        Me.lblVersion.Text = ""
        Me.txtUnlockKey.Text = ""
        Me.lblSoft.Text = ""

        If checkunLockCodeApp(Me.txtCode_App.Text, Me.txtCode_code.Text, Me.txtCode_date.Text, Me.txtCode_checksum.Text, Me.txtUnlockCode_App.Text, Me.txtUnlockCode_version.Text, Me.txtUnlockCode_date.Text, Me.txtUnlockCode_checksum.Text) Then
            Try
                Me.lblSoft.Text = Me.arrSoft(Me.GetSoftAPP(Me.txtCode_App.Text))
            Catch ex As Exception
                Me.lblSoft.Text = "ERROR"
                Exit Sub
            End Try

            Try
                Me.lblTipo.Text = Me.arrTipo(Me.GetTypeAPP(Me.txtUnlockCode_version.Text))
            Catch ex As Exception
                Me.lblTipo.Text = "ERROR"
                Exit Sub
            End Try

            Try
                Me.lblVersion.Text = Me.arrVersiones(Me.GetVersionAPP(Me.txtUnlockCode_version.Text))
            Catch ex As Exception
                Me.lblVersion.Text = "ERROR"
                Exit Sub
            End Try

            Me.lblFhCode.Text = Me.GetDateInstall(Me.txtCode_date.Text)
            Me.lblFhCodeUnLock.Text = Me.GetDateInstallDone(Me.txtUnlockCode_date.Text)

            Me.txtUnlockKey.Text = Me.txtUnlockCode_App.Text & "-" & Me.txtUnlockCode_version.Text & "-" & Me.txtUnlockCode_date.Text & "-" & Me.txtUnlockCode_checksum.Text

            MsgBox("Código válido", MsgBoxStyle.Information)
        Else
            MsgBox("Código inválido", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Function checkCodeApp(ByVal sApp As String, sCode As String, sDate As String, sChecksum As String) As Boolean
        If sApp.Length <> 5 OrElse sCode.Length <> 5 OrElse sDate.Length <> 5 OrElse sChecksum.Length <> 5 Then Return False

        Dim sTmpChk As String = "", str As String = ""
        Dim sSoft As String = "", sTemp As String = ""

        ' Compruebo las dos primeras letras
        Select Case sApp.Substring(0, 2)
            Case "PY" : sTmpChk = "7" : sSoft = "PYMEGEST.V3"
            Case "GT" : sTmpChk = "N" : sSoft = "GTPV.V2"
            Case "GS" : sTmpChk = "2" : sSoft = "GSAD.V2"
            Case "GR" : sTmpChk = "0" : sSoft = "GRUTAMAHI.V2"
            Case "OT" : sTmpChk = "9" : sSoft = "OTHERS"
            Case Else
                Return False
        End Select
        If sChecksum.Substring(0, 1) <> sTmpChk Then Return False

        'Compruebo validez del tipo del software
        Select Case sSoft
            Case "PYMEGEST.V3" : sTmpChk = "Y"
            Case "GTPV.V2" : sTmpChk = "S"
            Case "GSAD.V2" : sTmpChk = "3"
            Case "GRUTAMAHI.V2" : sTmpChk = "1"
            Case "OTHERS" : sTmpChk = "I"
            Case Else
                Err.Raise(22, "gdv", "Versión de app incorrecta")
        End Select

        If sTmpChk <> sChecksum.Substring(1, 1) Then Return False

        str = sSoft.Substring(0, 1)
        str &= sSoft.Substring(1, 1)
        str &= sSoft.Substring(sSoft.Length - 1, 1)

        sTemp = Asc(sApp.Substring(0, 1))
        str &= sTemp.Substring(sTemp.Length - 1, 1)

        sTemp = Asc(sSoft.Substring(sSoft.Length - 1, 1))
        str &= sTemp.Substring(sTemp.Length - 1, 1)

        If str <> sApp Then Return False

        'Compruebo código aleatorio
        sTemp = sCode.Substring(0, 1)
        If Not IsNumeric(sTemp) Then Return False
        str = sTemp
        str &= Me._strLockCodesNum.Substring(sTemp, 1)
        str &= Me._strLockCodesLetters.Substring(sTemp, 1)

        If str <> sCode.Substring(0, 3) Then Return False

        str = sCode.Substring(3, 2)
        If Not IsNumeric(str.Substring(1, 1)) Then Return False
        If Me._strLockCodesNum.Substring(str.Substring(1, 1), 1) <> str.Substring(0, 1) Then Return False

        'sTemp = rnd1.Next(9)
        'sTemp &= Me._strLockCodesNum.Substring(sTemp, 1)
        'sCode &= StrReverse(sTemp)

        ' FECHA
        Try
            If Not IsDate(Me.GetDateInstall(sDate)) Then Return False
            str = StrReverse(CDate(Me.GetDateInstall(sDate)).Year.ToString.Substring(2, 2))
            If str <> sChecksum.Substring(2, 2) Then Return False
        Catch ex As Exception
            Return False
        End Try

        'sChecksum &= StrReverse(dt.Year.ToString.Substring(2, 2))

        Return True
    End Function


    Private Function checkunLockCodeApp(ByVal sApp As String, sCode As String, sDate As String, sChecksum As String, ByVal suApp As String, suCode As String, suDate As String, suChecksum As String) As Boolean
        If sApp.Length <> 5 OrElse sCode.Length <> 5 OrElse sDate.Length <> 5 OrElse sChecksum.Length <> 5 Then Return False
        If suApp.Length <> 5 OrElse suCode.Length <> 5 OrElse suDate.Length <> 5 OrElse suChecksum.Length <> 5 Then Return False

        If Not checkCodeApp(sApp, sCode, sDate, sChecksum) Then Return False

        Dim sTmpChk As String = "", sUnlockAPP As String = "", sTemp As String = "", n As Integer = 0, sw As Boolean = False

        Dim sVersion As String = "", sTipo As String = ""

        ' Compruebo las dos primeras letras
        Select Case suApp.Substring(0, 2)
            Case "GD" : sTmpChk = "J" : sUnlockAPP = "GD" : sTemp = "7"
            Case "TV" : sTmpChk = "5" : sUnlockAPP = "TV" : sTemp = "N"
            Case "AD" : sTmpChk = "7" : sUnlockAPP = "AD" : sTemp = "2"
            Case "GM" : sTmpChk = "O" : sUnlockAPP = "GM" : sTemp = "0"
            Case "TR" : sTmpChk = "P" : sUnlockAPP = "TR" : sTemp = "9"
            Case Else
                Return False
        End Select

        If suApp.Substring(4, 1) <> sTemp Then Return False

        sUnlockAPP &= StrReverse(Asc(sApp.Substring(2, 1)).ToString).Substring(0, 1)
        sUnlockAPP &= _strUnlockCodesNum.Substring(sApp.Substring(3, 1), 1)

        sUnlockAPP &= sTemp

        If sUnlockAPP <> suApp Then Return False


        ''        Dim rnd1 As New Random(DateTime.Now.Millisecond * 23)

        ' TIPO DE INSTALACION
        If suCode.Substring(0, 1) <> Me._strunLockMonths(sChecksum.Substring(4, 1)) Then Return False
        If suCode.Substring(1, 1) <> Me._strunLockMonths.Substring(Me._strLockCodesLetters.IndexOf(sDate.Substring(0, 1)), 1) Then Return False

        If Not Me._strunLockMonths.Contains(suCode.Substring(2, 1)) Then Return False
        If InStr(Me._strunLockMonths, suCode.Substring(2, 1)) - 1 > UBound(Me.arrTipo) Then Return False

        ' TIPO DE VERSION
        If Not Me._strLockCodesLetters.Contains(suCode.Substring(3, 1)) Then Return False
        If Not Me._strLockCodesLetters.Contains(suCode.Substring(4, 1)) Then Return False

        sw = False
        For i As Integer = 0 To UBound(Me.arrVersiones)
            If suCode.Substring(3, 2) = Me._strLockCodesLetters.Substring(Asc(Me.arrVersiones(i).ToString.Substring(0, 1)) - 65, 1) & Me._strLockCodesLetters.Substring(Asc(Me.arrVersiones(i).ToString.Substring(1, 1)) - 65, 1) Then
                sw = True
                sTemp = (Asc(Me.arrVersiones(i).ToString.Substring(0, 1)) + Asc(Me.arrVersiones(i).ToString.Substring(1, 1))) Mod 9
                Exit For
            End If
        Next
        If Not sw Then Return False

        'DATE
        If Not IsDate(Me.GetDateInstallDone(suDate)) Then Return False

        'CHECKSUM
        Dim stmp As String = ""
        stmp &= sTemp
        stmp &= StrReverse(sChecksum.Substring(1, 2))
        stmp &= Asc(suCode.Substring(2, 1)).ToString.Substring(1, 1)
        stmp &= Me._strUnlockCodesNum(sChecksum.Substring(4, 1))
        If stmp <> suChecksum Then Return False


        Return True
    End Function



    Private m_crypt As Crypto_Rijndael               'Para codificacion
    Private Sub btDecode_Click(sender As Object, e As EventArgs) Handles btDecode.Click
        If Me.txtCrypt_keycode.TextLength <= 0 Then
            MsgBox("No ha establecido ninguna clave de codificación", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.txtCrypt_key.TextLength <= 0 Then
            MsgBox("No ha establecido ningún valor a codificar", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Me.m_crypt = New Crypto_Rijndael(Me.txtCrypt_keycode.Text)
        Me.txtCrypt_unkey.Text = Me.m_crypt.Decrypt(Me.txtCrypt_unkey.Text)

    End Sub
End Class
