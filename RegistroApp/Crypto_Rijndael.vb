'### Autor: Mercenario > gDevelop.dll v.2.x
'### Date: 06/11/2007

Imports System.Text
Imports System.IO
Imports System.Security.Cryptography

Public Class Crypto_Rijndael
    Private EncryptKey() As Byte
    Private EncryptIV() As Byte

#Region "Propiedades"
    Private _KeyCrypt As String = My.Application.Info.CompanyName
    Public Property KeyCrypt() As String
        Get
            Return _KeyCrypt
        End Get
        Set(ByVal Value As String)
            If Value.Length = 0 Then Exit Property
            _KeyCrypt = Value
        End Set
    End Property
#End Region

#Region "Funciones Generales"
    'Inicializacion por defecto
    Public Sub New()
    End Sub

    'Inicializacion con clave
    Public Sub New(ByVal StrFraseSecreta As String)
        If StrFraseSecreta.Length Then Me._KeyCrypt = StrFraseSecreta
    End Sub

    'Funcion que me devuelve la cadena encriptada
    Public Function Crypt(ByVal StrCadena As String) As String
        If StrCadena Is Nothing OrElse StrCadena.Length = 0 Then Return ""

        'Return StrCadena
        GenerateKey(Me._KeyCrypt)       'Generamos las claves de codificacion

        Dim MemStream As MemoryStream = New MemoryStream        'Para almacenar los datos
        Dim EncryptStream As CryptoStream                       'Usado para encriptar los datos
        Dim Rijndael As RijndaelManaged                         'Proveedor de encriptacion
        Dim RijndaelEncrypt As ICryptoTransform                 'Objeto de encriptacion

        'Creamos el metodo de encriptacion Rijndael
        Rijndael = New RijndaelManaged
        Rijndael.Key = EncryptKey
        Rijndael.IV = EncryptIV

        'Dependiento de que accion realizemos aplicamos un tipo u otro para crear el obj de criptacion
        RijndaelEncrypt = Rijndael.CreateEncryptor

        'Cargamos el objeto memoria
        EncryptStream = New CryptoStream(MemStream, RijndaelEncrypt, CryptoStreamMode.Write)

        'Escriptamos la cadena de entrada y la escribimos en memoria(MemStream)
        Dim CadByte() As Byte
        CadByte = Encoding.UTF8.GetBytes(StrCadena)
        EncryptStream.Write(CadByte, 0, CadByte.Length)
        EncryptStream.FlushFinalBlock()

        'Retornamos el valor 
        Return Convert.ToBase64String(MemStream.ToArray) & ""
    End Function

    'Funcion que me desencripta la cadena
    Public Function Decrypt(ByVal StrCadena As String) As String
        If StrCadena Is Nothing OrElse StrCadena.Length = 0 Then Return ""

       

        GenerateKey(Me._KeyCrypt)       'Generamos las claves de codificacion

        Dim MemStream As MemoryStream = New MemoryStream        'Para almacenar los datos
        Dim EncryptStream As CryptoStream                       'Usado para encriptar los datos
        Dim Rijndael As RijndaelManaged                         'Proveedor de encriptacion
        Dim RijndaelEncrypt As ICryptoTransform                 'Objeto de encriptacion

        'Creamos el metodo de encriptacion Rijndael
        Rijndael = New RijndaelManaged
        Rijndael.Key = EncryptKey
        Rijndael.IV = EncryptIV

        'Dependiento de que accion realizemos aplicamos un tipo u otro para crear el obj de criptacion
        RijndaelEncrypt = Rijndael.CreateDecryptor

        'Cargamos el objeto memoria
        EncryptStream = New CryptoStream(MemStream, RijndaelEncrypt, CryptoStreamMode.Write)

        'Escriptamos la cadena de entrada y la escribimos en memoria(MemStream)
        Dim CadByte() As Byte
        CadByte = Convert.FromBase64String(StrCadena)
        EncryptStream.Write(CadByte, 0, CadByte.Length)
        EncryptStream.FlushFinalBlock()

        'Retornamos el valor 
        Return New System.Text.ASCIIEncoding().GetString(MemStream.ToArray)
    End Function
#End Region

#Region "Funciones de Apoyo"
    'Funcion para generar la clave secreta de encriptacion
    Private Sub GenerateKey(ByVal StrFraseSecreta As String)
        Dim i As Integer
        'Redimensionamos las claves
        ReDim EncryptKey(23)
        ReDim EncryptIV(15)

        Dim sha384 As New SHA384Managed
        sha384.ComputeHash(Encoding.ASCII.GetBytes(StrFraseSecreta))
        Dim ByteResultado() As Byte = sha384.Hash

        'Rellenamos los valores
        For i = 0 To 23 : EncryptKey(i) = ByteResultado(i) : Next
        For i = 24 To 39 : EncryptIV(i - 24) = ByteResultado(i) : Next
    End Sub
#End Region

End Class
