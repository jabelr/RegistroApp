<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Group_Unlock As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.btCheck = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbSabor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFh = New System.Windows.Forms.Label()
        Me.BtGenerateUnLock = New System.Windows.Forms.Button()
        Me.TxtUnLockCode = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.txtCode_App = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnlockCode_version = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCode_date = New System.Windows.Forms.TextBox()
        Me.txtCode_checksum = New System.Windows.Forms.TextBox()
        Me.cbSoft = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbVersion = New System.Windows.Forms.ComboBox()
        Me.btUnlockKey = New System.Windows.Forms.Button()
        Me.txtUnlockKey = New System.Windows.Forms.TextBox()
        Me.txtCode_code = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnlockCode_checksum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnlockCode_date = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUnlockCode_App = New System.Windows.Forms.TextBox()
        Me.lblFhCode = New System.Windows.Forms.Label()
        Me.btReloadCodeAPP = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblFhCodeUnLock = New System.Windows.Forms.Label()
        Me.dtFh = New System.Windows.Forms.DateTimePicker()
        Me.btCheckReg = New System.Windows.Forms.Button()
        Me.dtFhRegister = New System.Windows.Forms.DateTimePicker()
        Me.lblSoft = New System.Windows.Forms.Label()
        Me.txtCrypt_key = New System.Windows.Forms.TextBox()
        Me.btDecode = New System.Windows.Forms.Button()
        Me.txtCrypt_unkey = New System.Windows.Forms.TextBox()
        Me.txtCrypt_keycode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Group_Unlock = New System.Windows.Forms.GroupBox()
        Group_Unlock.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_Unlock
        '
        Group_Unlock.Controls.Add(Me.btCheck)
        Group_Unlock.Controls.Add(Me.Label4)
        Group_Unlock.Controls.Add(Me.CbSabor)
        Group_Unlock.Controls.Add(Me.Label3)
        Group_Unlock.Controls.Add(Me.CbTipo)
        Group_Unlock.Controls.Add(Me.Label2)
        Group_Unlock.Controls.Add(Me.Label1)
        Group_Unlock.Controls.Add(Me.LblFh)
        Group_Unlock.Controls.Add(Me.BtGenerateUnLock)
        Group_Unlock.Controls.Add(Me.TxtUnLockCode)
        Group_Unlock.Controls.Add(Me.TxtCode)
        Group_Unlock.Location = New System.Drawing.Point(16, 15)
        Group_Unlock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Group_Unlock.Name = "Group_Unlock"
        Group_Unlock.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Group_Unlock.Size = New System.Drawing.Size(725, 245)
        Group_Unlock.TabIndex = 0
        Group_Unlock.TabStop = False
        Group_Unlock.Text = "Generar Código de Desbloqueo de aplicaciones"
        '
        'btCheck
        '
        Me.btCheck.Image = CType(resources.GetObject("btCheck.Image"), System.Drawing.Image)
        Me.btCheck.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btCheck.Location = New System.Drawing.Point(621, 192)
        Me.btCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btCheck.Name = "btCheck"
        Me.btCheck.Size = New System.Drawing.Size(96, 41)
        Me.btCheck.TabIndex = 11
        Me.btCheck.Text = "Check!"
        Me.btCheck.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CONTRACLAVE"
        '
        'CbSabor
        '
        Me.CbSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSabor.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSabor.FormattingEnabled = True
        Me.CbSabor.Items.AddRange(New Object() {"-- PymeGest.v3 --", "ESTANDAR", "LITE", "STECNICO", "COMerCIO", "ACceSOS", "soCIOS", "MAYORisTA", "PELUQUERIA", "Talleres", "AcadEMIas", "FACTurACION", "FerraLLa", "EvenTOS", "MeMORIamM", "webSHOP", "PUTAContabiLIDAD", "Fabricante", "NETSock", "hERMandad", "---", "aPyme", "iPyme", "wPyme", "---", "gTPV.v2"})
        Me.CbSabor.Location = New System.Drawing.Point(215, 123)
        Me.CbSabor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbSabor.Name = "CbSabor"
        Me.CbSabor.Size = New System.Drawing.Size(297, 37)
        Me.CbSabor.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SOFTWARE >> SABOR"
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"SERVIDOR", "CLIENTE", "TERMINAL", "PLUS", "ANONYMOUS"})
        Me.CbTipo.Location = New System.Drawing.Point(8, 123)
        Me.CbTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(197, 37)
        Me.CbTipo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TIPO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CÓDIGO DE APLICACIÓN"
        '
        'LblFh
        '
        Me.LblFh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFh.Location = New System.Drawing.Point(531, 16)
        Me.LblFh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFh.Name = "LblFh"
        Me.LblFh.Size = New System.Drawing.Size(179, 18)
        Me.LblFh.TabIndex = 4
        Me.LblFh.Text = "Fecha: 01/ene/1990"
        Me.LblFh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtGenerateUnLock
        '
        Me.BtGenerateUnLock.Enabled = False
        Me.BtGenerateUnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtGenerateUnLock.Image = CType(resources.GetObject("BtGenerateUnLock.Image"), System.Drawing.Image)
        Me.BtGenerateUnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtGenerateUnLock.Location = New System.Drawing.Point(547, 103)
        Me.BtGenerateUnLock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtGenerateUnLock.Name = "BtGenerateUnLock"
        Me.BtGenerateUnLock.Size = New System.Drawing.Size(171, 59)
        Me.BtGenerateUnLock.TabIndex = 2
        Me.BtGenerateUnLock.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UnLockCode"
        Me.BtGenerateUnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtGenerateUnLock.UseVisualStyleBackColor = True
        '
        'TxtUnLockCode
        '
        Me.TxtUnLockCode.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnLockCode.Location = New System.Drawing.Point(8, 192)
        Me.TxtUnLockCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUnLockCode.Name = "TxtUnLockCode"
        Me.TxtUnLockCode.ReadOnly = True
        Me.TxtUnLockCode.Size = New System.Drawing.Size(604, 39)
        Me.TxtUnLockCode.TabIndex = 1
        '
        'TxtCode
        '
        Me.TxtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCode.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(8, 41)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(686, 48)
        Me.TxtCode.TabIndex = 0
        '
        'txtCode_App
        '
        Me.txtCode_App.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode_App.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode_App.Location = New System.Drawing.Point(27, 373)
        Me.txtCode_App.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode_App.Name = "txtCode_App"
        Me.txtCode_App.Size = New System.Drawing.Size(171, 48)
        Me.txtCode_App.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 356)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(41, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "APP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 502)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(70, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "VERSIÓN"
        '
        'txtUnlockCode_version
        '
        Me.txtUnlockCode_version.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnlockCode_version.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnlockCode_version.Location = New System.Drawing.Point(205, 519)
        Me.txtUnlockCode_version.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnlockCode_version.Name = "txtUnlockCode_version"
        Me.txtUnlockCode_version.Size = New System.Drawing.Size(171, 48)
        Me.txtUnlockCode_version.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(381, 356)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "FECHA"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(384, 373)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 48)
        Me.TextBox3.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(560, 356)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(83, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "CHECKSUM"
        '
        'txtCode_date
        '
        Me.txtCode_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode_date.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode_date.Location = New System.Drawing.Point(384, 373)
        Me.txtCode_date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode_date.Name = "txtCode_date"
        Me.txtCode_date.Size = New System.Drawing.Size(171, 48)
        Me.txtCode_date.TabIndex = 3
        '
        'txtCode_checksum
        '
        Me.txtCode_checksum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode_checksum.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode_checksum.Location = New System.Drawing.Point(563, 373)
        Me.txtCode_checksum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode_checksum.Name = "txtCode_checksum"
        Me.txtCode_checksum.Size = New System.Drawing.Size(171, 48)
        Me.txtCode_checksum.TabIndex = 4
        '
        'cbSoft
        '
        Me.cbSoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSoft.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSoft.Items.AddRange(New Object() {"PYMEGEST.V3", "GTPV.V2", "GSAD.V2", "GRUTAMAHI.V2", "OTHERS"})
        Me.cbSoft.Location = New System.Drawing.Point(27, 284)
        Me.cbSoft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSoft.Name = "cbSoft"
        Me.cbSoft.Size = New System.Drawing.Size(252, 37)
        Me.cbSoft.TabIndex = 14
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"SERVIDOR", "CLIENTE", "TERMINAL", "PLUS", "ANONYMOUS", "MENSUAL"})
        Me.cbType.Location = New System.Drawing.Point(288, 284)
        Me.cbType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(197, 37)
        Me.cbType.TabIndex = 12
        '
        'cbVersion
        '
        Me.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVersion.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVersion.FormattingEnabled = True
        Me.cbVersion.Items.AddRange(New Object() {"ESTANDAR", "LITE", "COMERCIO", "STECNICO", "TALLERES", "MAYORISTA", "ESTETITA", "HERMANDADES", "OTROS", "GDV"})
        Me.cbVersion.Location = New System.Drawing.Point(495, 284)
        Me.cbVersion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbVersion.Name = "cbVersion"
        Me.cbVersion.Size = New System.Drawing.Size(244, 37)
        Me.cbVersion.TabIndex = 16
        '
        'btUnlockKey
        '
        Me.btUnlockKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUnlockKey.Image = CType(resources.GetObject("btUnlockKey.Image"), System.Drawing.Image)
        Me.btUnlockKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUnlockKey.Location = New System.Drawing.Point(775, 502)
        Me.btUnlockKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btUnlockKey.Name = "btUnlockKey"
        Me.btUnlockKey.Size = New System.Drawing.Size(242, 66)
        Me.btUnlockKey.TabIndex = 10
        Me.btUnlockKey.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UnLockCode"
        Me.btUnlockKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUnlockKey.UseVisualStyleBackColor = True
        '
        'txtUnlockKey
        '
        Me.txtUnlockKey.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnlockKey.Location = New System.Drawing.Point(27, 638)
        Me.txtUnlockKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnlockKey.Name = "txtUnlockKey"
        Me.txtUnlockKey.ReadOnly = True
        Me.txtUnlockKey.Size = New System.Drawing.Size(705, 39)
        Me.txtUnlockKey.TabIndex = 11
        '
        'txtCode_code
        '
        Me.txtCode_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode_code.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode_code.Location = New System.Drawing.Point(205, 373)
        Me.txtCode_code.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode_code.Name = "txtCode_code"
        Me.txtCode_code.Size = New System.Drawing.Size(171, 48)
        Me.txtCode_code.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(203, 356)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "CODE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(560, 502)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label11.Size = New System.Drawing.Size(83, 14)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "CHECKSUM"
        '
        'txtUnlockCode_checksum
        '
        Me.txtUnlockCode_checksum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnlockCode_checksum.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnlockCode_checksum.Location = New System.Drawing.Point(563, 519)
        Me.txtUnlockCode_checksum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnlockCode_checksum.Name = "txtUnlockCode_checksum"
        Me.txtUnlockCode_checksum.Size = New System.Drawing.Size(171, 48)
        Me.txtUnlockCode_checksum.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(381, 502)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(55, 14)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "FECHA"
        '
        'txtUnlockCode_date
        '
        Me.txtUnlockCode_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnlockCode_date.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnlockCode_date.Location = New System.Drawing.Point(384, 519)
        Me.txtUnlockCode_date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnlockCode_date.Name = "txtUnlockCode_date"
        Me.txtUnlockCode_date.Size = New System.Drawing.Size(171, 48)
        Me.txtUnlockCode_date.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(384, 519)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(169, 48)
        Me.TextBox5.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 502)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "CONTRACLAVE"
        '
        'txtUnlockCode_App
        '
        Me.txtUnlockCode_App.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnlockCode_App.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnlockCode_App.Location = New System.Drawing.Point(27, 519)
        Me.txtUnlockCode_App.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnlockCode_App.Name = "txtUnlockCode_App"
        Me.txtUnlockCode_App.Size = New System.Drawing.Size(171, 48)
        Me.txtUnlockCode_App.TabIndex = 6
        '
        'lblFhCode
        '
        Me.lblFhCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFhCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFhCode.Location = New System.Drawing.Point(384, 426)
        Me.lblFhCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFhCode.Name = "lblFhCode"
        Me.lblFhCode.Size = New System.Drawing.Size(170, 18)
        Me.lblFhCode.TabIndex = 33
        Me.lblFhCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btReloadCodeAPP
        '
        Me.btReloadCodeAPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReloadCodeAPP.Image = CType(resources.GetObject("btReloadCodeAPP.Image"), System.Drawing.Image)
        Me.btReloadCodeAPP.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btReloadCodeAPP.Location = New System.Drawing.Point(775, 373)
        Me.btReloadCodeAPP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btReloadCodeAPP.Name = "btReloadCodeAPP"
        Me.btReloadCodeAPP.Size = New System.Drawing.Size(242, 49)
        Me.btReloadCodeAPP.TabIndex = 5
        Me.btReloadCodeAPP.Text = "Reload"
        Me.btReloadCodeAPP.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btReloadCodeAPP.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(205, 572)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(78, 18)
        Me.lblTipo.TabIndex = 35
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(285, 572)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(91, 18)
        Me.lblVersion.TabIndex = 36
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFhCodeUnLock
        '
        Me.lblFhCodeUnLock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFhCodeUnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFhCodeUnLock.Location = New System.Drawing.Point(384, 572)
        Me.lblFhCodeUnLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFhCodeUnLock.Name = "lblFhCodeUnLock"
        Me.lblFhCodeUnLock.Size = New System.Drawing.Size(170, 18)
        Me.lblFhCodeUnLock.TabIndex = 37
        Me.lblFhCodeUnLock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtFh
        '
        Me.dtFh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFh.Location = New System.Drawing.Point(384, 448)
        Me.dtFh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtFh.Name = "dtFh"
        Me.dtFh.Size = New System.Drawing.Size(169, 27)
        Me.dtFh.TabIndex = 38
        '
        'btCheckReg
        '
        Me.btCheckReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCheckReg.Image = CType(resources.GetObject("btCheckReg.Image"), System.Drawing.Image)
        Me.btCheckReg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btCheckReg.Location = New System.Drawing.Point(775, 613)
        Me.btCheckReg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btCheckReg.Name = "btCheckReg"
        Me.btCheckReg.Size = New System.Drawing.Size(242, 64)
        Me.btCheckReg.TabIndex = 39
        Me.btCheckReg.Text = "Comprobar"
        Me.btCheckReg.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btCheckReg.UseVisualStyleBackColor = True
        '
        'dtFhRegister
        '
        Me.dtFhRegister.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFhRegister.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFhRegister.Location = New System.Drawing.Point(384, 594)
        Me.dtFhRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtFhRegister.Name = "dtFhRegister"
        Me.dtFhRegister.Size = New System.Drawing.Size(169, 27)
        Me.dtFhRegister.TabIndex = 40
        '
        'lblSoft
        '
        Me.lblSoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoft.Location = New System.Drawing.Point(205, 594)
        Me.lblSoft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoft.Name = "lblSoft"
        Me.lblSoft.Size = New System.Drawing.Size(171, 28)
        Me.lblSoft.TabIndex = 41
        Me.lblSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCrypt_key
        '
        Me.txtCrypt_key.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCrypt_key.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrypt_key.Location = New System.Drawing.Point(27, 699)
        Me.txtCrypt_key.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCrypt_key.Name = "txtCrypt_key"
        Me.txtCrypt_key.Size = New System.Drawing.Size(501, 32)
        Me.txtCrypt_key.TabIndex = 42
        '
        'btDecode
        '
        Me.btDecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDecode.Image = CType(resources.GetObject("btDecode.Image"), System.Drawing.Image)
        Me.btDecode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDecode.Location = New System.Drawing.Point(775, 699)
        Me.btDecode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btDecode.Name = "btDecode"
        Me.btDecode.Size = New System.Drawing.Size(242, 71)
        Me.btDecode.TabIndex = 43
        Me.btDecode.Text = "Decode"
        Me.btDecode.UseVisualStyleBackColor = True
        '
        'txtCrypt_unkey
        '
        Me.txtCrypt_unkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCrypt_unkey.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrypt_unkey.Location = New System.Drawing.Point(27, 740)
        Me.txtCrypt_unkey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCrypt_unkey.Name = "txtCrypt_unkey"
        Me.txtCrypt_unkey.ReadOnly = True
        Me.txtCrypt_unkey.Size = New System.Drawing.Size(705, 32)
        Me.txtCrypt_unkey.TabIndex = 44
        '
        'txtCrypt_keycode
        '
        Me.txtCrypt_keycode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrypt_keycode.Location = New System.Drawing.Point(537, 699)
        Me.txtCrypt_keycode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCrypt_keycode.Name = "txtCrypt_keycode"
        Me.txtCrypt_keycode.Size = New System.Drawing.Size(196, 32)
        Me.txtCrypt_keycode.TabIndex = 45
        Me.txtCrypt_keycode.Text = "PymeGest.v3"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(757, 119)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(297, 211)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(756, 15)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(298, 100)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "2025-08-09 (jabel)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todo lo que tiene un principio, tiene un final!"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 785)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCrypt_keycode)
        Me.Controls.Add(Me.txtCrypt_unkey)
        Me.Controls.Add(Me.btDecode)
        Me.Controls.Add(Me.txtCrypt_key)
        Me.Controls.Add(Me.lblSoft)
        Me.Controls.Add(Me.dtFhRegister)
        Me.Controls.Add(Me.btCheckReg)
        Me.Controls.Add(Me.dtFh)
        Me.Controls.Add(Me.lblFhCodeUnLock)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.btReloadCodeAPP)
        Me.Controls.Add(Me.lblFhCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUnlockCode_App)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtUnlockCode_date)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUnlockCode_checksum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCode_code)
        Me.Controls.Add(Me.txtUnlockKey)
        Me.Controls.Add(Me.btUnlockKey)
        Me.Controls.Add(Me.cbVersion)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.cbSoft)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCode_checksum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCode_date)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUnlockCode_version)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCode_App)
        Me.Controls.Add(Group_Unlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnLockApp'z"
        Group_Unlock.ResumeLayout(False)
        Group_Unlock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtGenerateUnLock As System.Windows.Forms.Button
    Friend WithEvents TxtUnLockCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents LblFh As System.Windows.Forms.Label
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbSabor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btCheck As System.Windows.Forms.Button
    Friend WithEvents txtCode_App As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUnlockCode_version As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCode_date As TextBox
    Friend WithEvents txtCode_checksum As TextBox
    Friend WithEvents cbSoft As ComboBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cbVersion As ComboBox
    Friend WithEvents btUnlockKey As Button
    Friend WithEvents txtUnlockKey As TextBox
    Friend WithEvents txtCode_code As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnlockCode_checksum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUnlockCode_date As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUnlockCode_App As TextBox
    Friend WithEvents lblFhCode As Label
    Friend WithEvents btReloadCodeAPP As Button
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblFhCodeUnLock As Label
    Friend WithEvents dtFh As DateTimePicker
    Friend WithEvents btCheckReg As Button
    Friend WithEvents dtFhRegister As DateTimePicker
    Friend WithEvents lblSoft As Label
    Friend WithEvents txtCrypt_key As TextBox
    Friend WithEvents btDecode As Button
    Friend WithEvents txtCrypt_unkey As TextBox
    Friend WithEvents txtCrypt_keycode As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
