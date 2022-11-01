<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaltForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbo1kg = New System.Windows.Forms.ComboBox
        Me.cbo500g = New System.Windows.Forms.ComboBox
        Me.cbo250g = New System.Windows.Forms.ComboBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.dtpCurrentDate = New System.Windows.Forms.DateTimePicker
        Me.cboSelectSalesPerson = New System.Windows.Forms.ComboBox
        Me.btnSaveSaltSales = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtOverallAmount = New System.Windows.Forms.TextBox
        Me.txtOverallQty = New System.Windows.Forms.TextBox
        Me.txt1kgTotalAmount = New System.Windows.Forms.TextBox
        Me.txt1kgUPrice = New System.Windows.Forms.TextBox
        Me.txtAvailableQty1kg = New System.Windows.Forms.TextBox
        Me.txt1kgQty = New System.Windows.Forms.TextBox
        Me.txt500gTotalAmount = New System.Windows.Forms.TextBox
        Me.txt500gUPrice = New System.Windows.Forms.TextBox
        Me.txtAvailableQty500g = New System.Windows.Forms.TextBox
        Me.txt500gQty = New System.Windows.Forms.TextBox
        Me.txt250gTotalAmount = New System.Windows.Forms.TextBox
        Me.txt250gUPrice = New System.Windows.Forms.TextBox
        Me.txtSalesPersonContact = New System.Windows.Forms.TextBox
        Me.txtAvailableQty250g = New System.Windows.Forms.TextBox
        Me.txt250gQty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cbo1kg
        '
        Me.cbo1kg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo1kg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo1kg.FormattingEnabled = True
        Me.cbo1kg.Location = New System.Drawing.Point(277, 450)
        Me.cbo1kg.Name = "cbo1kg"
        Me.cbo1kg.Size = New System.Drawing.Size(179, 23)
        Me.cbo1kg.TabIndex = 69
        '
        'cbo500g
        '
        Me.cbo500g.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo500g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo500g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo500g.FormattingEnabled = True
        Me.cbo500g.Location = New System.Drawing.Point(277, 259)
        Me.cbo500g.Name = "cbo500g"
        Me.cbo500g.Size = New System.Drawing.Size(179, 23)
        Me.cbo500g.TabIndex = 70
        '
        'cbo250g
        '
        Me.cbo250g.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo250g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo250g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo250g.FormattingEnabled = True
        Me.cbo250g.Location = New System.Drawing.Point(277, 63)
        Me.cbo250g.Name = "cbo250g"
        Me.cbo250g.Size = New System.Drawing.Size(179, 23)
        Me.cbo250g.TabIndex = 25
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(824, 340)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(246, 21)
        Me.txtDate.TabIndex = 67
        '
        'dtpCurrentDate
        '
        Me.dtpCurrentDate.Location = New System.Drawing.Point(1069, 340)
        Me.dtpCurrentDate.Name = "dtpCurrentDate"
        Me.dtpCurrentDate.Size = New System.Drawing.Size(17, 20)
        Me.dtpCurrentDate.TabIndex = 66
        '
        'cboSelectSalesPerson
        '
        Me.cboSelectSalesPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectSalesPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectSalesPerson.FormattingEnabled = True
        Me.cboSelectSalesPerson.Location = New System.Drawing.Point(820, 108)
        Me.cboSelectSalesPerson.Name = "cboSelectSalesPerson"
        Me.cboSelectSalesPerson.Size = New System.Drawing.Size(266, 21)
        Me.cboSelectSalesPerson.TabIndex = 65
        '
        'btnSaveSaltSales
        '
        Me.btnSaveSaltSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveSaltSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSaltSales.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSaltSales.Location = New System.Drawing.Point(458, 656)
        Me.btnSaveSaltSales.Name = "btnSaveSaltSales"
        Me.btnSaveSaltSales.Size = New System.Drawing.Size(200, 63)
        Me.btnSaveSaltSales.TabIndex = 68
        Me.btnSaveSaltSales.Text = "RECORD"
        Me.btnSaveSaltSales.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(181, 588)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 18)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "( GH¢ )"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(179, 543)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 18)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "( GH¢ )"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(179, 384)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 18)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "( GH¢ )"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(179, 340)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 18)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "( GH¢ )"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(179, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "( GH¢ )"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(152, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 18)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "( GH¢ )"
        '
        'txtOverallAmount
        '
        Me.txtOverallAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverallAmount.Location = New System.Drawing.Point(950, 567)
        Me.txtOverallAmount.Multiline = True
        Me.txtOverallAmount.Name = "txtOverallAmount"
        Me.txtOverallAmount.ReadOnly = True
        Me.txtOverallAmount.Size = New System.Drawing.Size(191, 52)
        Me.txtOverallAmount.TabIndex = 64
        '
        'txtOverallQty
        '
        Me.txtOverallQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverallQty.Location = New System.Drawing.Point(950, 466)
        Me.txtOverallQty.Multiline = True
        Me.txtOverallQty.Name = "txtOverallQty"
        Me.txtOverallQty.ReadOnly = True
        Me.txtOverallQty.Size = New System.Drawing.Size(191, 52)
        Me.txtOverallQty.TabIndex = 63
        '
        'txt1kgTotalAmount
        '
        Me.txt1kgTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1kgTotalAmount.Location = New System.Drawing.Point(280, 581)
        Me.txt1kgTotalAmount.Multiline = True
        Me.txt1kgTotalAmount.Name = "txt1kgTotalAmount"
        Me.txt1kgTotalAmount.ReadOnly = True
        Me.txt1kgTotalAmount.Size = New System.Drawing.Size(179, 38)
        Me.txt1kgTotalAmount.TabIndex = 62
        '
        'txt1kgUPrice
        '
        Me.txt1kgUPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1kgUPrice.Location = New System.Drawing.Point(280, 536)
        Me.txt1kgUPrice.Multiline = True
        Me.txt1kgUPrice.Name = "txt1kgUPrice"
        Me.txt1kgUPrice.ReadOnly = True
        Me.txt1kgUPrice.Size = New System.Drawing.Size(179, 38)
        Me.txt1kgUPrice.TabIndex = 61
        '
        'txtAvailableQty1kg
        '
        Me.txtAvailableQty1kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty1kg.Location = New System.Drawing.Point(502, 496)
        Me.txtAvailableQty1kg.Multiline = True
        Me.txtAvailableQty1kg.Name = "txtAvailableQty1kg"
        Me.txtAvailableQty1kg.ReadOnly = True
        Me.txtAvailableQty1kg.Size = New System.Drawing.Size(179, 38)
        Me.txtAvailableQty1kg.TabIndex = 74
        '
        'txt1kgQty
        '
        Me.txt1kgQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1kgQty.Location = New System.Drawing.Point(280, 488)
        Me.txt1kgQty.Multiline = True
        Me.txt1kgQty.Name = "txt1kgQty"
        Me.txt1kgQty.Size = New System.Drawing.Size(179, 38)
        Me.txt1kgQty.TabIndex = 60
        '
        'txt500gTotalAmount
        '
        Me.txt500gTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500gTotalAmount.Location = New System.Drawing.Point(279, 374)
        Me.txt500gTotalAmount.Multiline = True
        Me.txt500gTotalAmount.Name = "txt500gTotalAmount"
        Me.txt500gTotalAmount.ReadOnly = True
        Me.txt500gTotalAmount.Size = New System.Drawing.Size(179, 38)
        Me.txt500gTotalAmount.TabIndex = 59
        '
        'txt500gUPrice
        '
        Me.txt500gUPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500gUPrice.Location = New System.Drawing.Point(279, 330)
        Me.txt500gUPrice.Multiline = True
        Me.txt500gUPrice.Name = "txt500gUPrice"
        Me.txt500gUPrice.ReadOnly = True
        Me.txt500gUPrice.Size = New System.Drawing.Size(179, 38)
        Me.txt500gUPrice.TabIndex = 58
        '
        'txtAvailableQty500g
        '
        Me.txtAvailableQty500g.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty500g.Location = New System.Drawing.Point(502, 286)
        Me.txtAvailableQty500g.Multiline = True
        Me.txtAvailableQty500g.Name = "txtAvailableQty500g"
        Me.txtAvailableQty500g.ReadOnly = True
        Me.txtAvailableQty500g.Size = New System.Drawing.Size(179, 38)
        Me.txtAvailableQty500g.TabIndex = 73
        '
        'txt500gQty
        '
        Me.txt500gQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500gQty.Location = New System.Drawing.Point(279, 286)
        Me.txt500gQty.Multiline = True
        Me.txt500gQty.Name = "txt500gQty"
        Me.txt500gQty.Size = New System.Drawing.Size(179, 38)
        Me.txt500gQty.TabIndex = 55
        '
        'txt250gTotalAmount
        '
        Me.txt250gTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt250gTotalAmount.Location = New System.Drawing.Point(277, 180)
        Me.txt250gTotalAmount.Multiline = True
        Me.txt250gTotalAmount.Name = "txt250gTotalAmount"
        Me.txt250gTotalAmount.ReadOnly = True
        Me.txt250gTotalAmount.Size = New System.Drawing.Size(179, 38)
        Me.txt250gTotalAmount.TabIndex = 50
        '
        'txt250gUPrice
        '
        Me.txt250gUPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt250gUPrice.Location = New System.Drawing.Point(277, 136)
        Me.txt250gUPrice.Multiline = True
        Me.txt250gUPrice.Name = "txt250gUPrice"
        Me.txt250gUPrice.ReadOnly = True
        Me.txt250gUPrice.Size = New System.Drawing.Size(179, 38)
        Me.txt250gUPrice.TabIndex = 49
        '
        'txtSalesPersonContact
        '
        Me.txtSalesPersonContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPersonContact.Location = New System.Drawing.Point(821, 185)
        Me.txtSalesPersonContact.Multiline = True
        Me.txtSalesPersonContact.Name = "txtSalesPersonContact"
        Me.txtSalesPersonContact.ReadOnly = True
        Me.txtSalesPersonContact.Size = New System.Drawing.Size(266, 33)
        Me.txtSalesPersonContact.TabIndex = 71
        '
        'txtAvailableQty250g
        '
        Me.txtAvailableQty250g.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty250g.Location = New System.Drawing.Point(502, 97)
        Me.txtAvailableQty250g.Multiline = True
        Me.txtAvailableQty250g.Name = "txtAvailableQty250g"
        Me.txtAvailableQty250g.ReadOnly = True
        Me.txtAvailableQty250g.Size = New System.Drawing.Size(179, 38)
        Me.txtAvailableQty250g.TabIndex = 72
        '
        'txt250gQty
        '
        Me.txt250gQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt250gQty.Location = New System.Drawing.Point(277, 92)
        Me.txt250gQty.Multiline = True
        Me.txt250gQty.Name = "txt250gQty"
        Me.txt250gQty.Size = New System.Drawing.Size(179, 38)
        Me.txt250gQty.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(38, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "1 KILOGRAM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(38, 589)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 18)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "TOTAL AMOUNT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(38, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "TOTAL AMOUNT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(38, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "TOTAL AMOUNT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(38, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "UNIT. PRICE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(38, 340)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "UNIT. PRICE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(38, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 18)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "UNIT. PRICE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(753, 585)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(197, 18)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "TOTAL AMOUNT ( GH¢ )"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(773, 483)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(146, 18)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "TOTAL QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "QUANTITY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(38, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "QUANTITY"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(899, 309)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 18)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "SELECT DATE"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(852, 156)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(219, 18)
        Me.Label30.TabIndex = 38
        Me.Label30.Text = "SALES PERSON CONTACT"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(852, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(204, 18)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "SELECT SALES PERSON"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(503, 471)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(178, 18)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "AVAILABLE QUANTITY"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(500, 261)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(178, 18)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "AVAILABLE QUANTITY"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(503, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(178, 18)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "AVAILABLE QUANTITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "500 GRAMS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "250 GRAMS"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(-3, 637)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(1172, 12)
        Me.Label22.TabIndex = 23
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-3, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1172, 12)
        Me.Label15.TabIndex = 24
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-3, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1172, 12)
        Me.Label14.TabIndex = 26
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1172, 45)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "SALT FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaltForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 726)
        Me.Controls.Add(Me.cbo1kg)
        Me.Controls.Add(Me.cbo500g)
        Me.Controls.Add(Me.cbo250g)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.dtpCurrentDate)
        Me.Controls.Add(Me.cboSelectSalesPerson)
        Me.Controls.Add(Me.btnSaveSaltSales)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtOverallAmount)
        Me.Controls.Add(Me.txtOverallQty)
        Me.Controls.Add(Me.txt1kgTotalAmount)
        Me.Controls.Add(Me.txt1kgUPrice)
        Me.Controls.Add(Me.txtAvailableQty1kg)
        Me.Controls.Add(Me.txt1kgQty)
        Me.Controls.Add(Me.txt500gTotalAmount)
        Me.Controls.Add(Me.txt500gUPrice)
        Me.Controls.Add(Me.txtAvailableQty500g)
        Me.Controls.Add(Me.txt500gQty)
        Me.Controls.Add(Me.txt250gTotalAmount)
        Me.Controls.Add(Me.txt250gUPrice)
        Me.Controls.Add(Me.txtSalesPersonContact)
        Me.Controls.Add(Me.txtAvailableQty250g)
        Me.Controls.Add(Me.txt250gQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SaltForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaltForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo1kg As System.Windows.Forms.ComboBox
    Friend WithEvents cbo500g As System.Windows.Forms.ComboBox
    Friend WithEvents cbo250g As System.Windows.Forms.ComboBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpCurrentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSelectSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveSaltSales As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtOverallAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtOverallQty As System.Windows.Forms.TextBox
    Friend WithEvents txt1kgTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt1kgUPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQty1kg As System.Windows.Forms.TextBox
    Friend WithEvents txt1kgQty As System.Windows.Forms.TextBox
    Friend WithEvents txt500gTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt500gUPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQty500g As System.Windows.Forms.TextBox
    Friend WithEvents txt500gQty As System.Windows.Forms.TextBox
    Friend WithEvents txt250gTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt250gUPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesPersonContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQty250g As System.Windows.Forms.TextBox
    Friend WithEvents txt250gQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
