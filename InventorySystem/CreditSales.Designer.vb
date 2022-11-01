<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditSales
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtQuantityBought = New System.Windows.Forms.TextBox
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.txtAvailableQty = New System.Windows.Forms.TextBox
        Me.txtCustomerContact = New System.Windows.Forms.TextBox
        Me.cboItemName = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSales = New System.Windows.Forms.Button
        Me.dtpSold = New System.Windows.Forms.DateTimePicker
        Me.txtDateSold = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNotice = New System.Windows.Forms.Label
        Me.timeOfSales = New System.Windows.Forms.DateTimePicker
        Me.txtTimeOfCreditSales = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 25)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "AVAILABLE QUANTITY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(366, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(246, 25)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "MAKE CREDIT SALES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(355, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(304, 25)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "AVAILABLE CREDIT SALES"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(-22, 508)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(985, 41)
        Me.Label10.TabIndex = 40
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(791, 339)
        Me.txtTotalAmount.Multiline = True
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(131, 32)
        Me.txtTotalAmount.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(518, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(275, 25)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "TOTAL AMOUNT ( GHC )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(517, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 25)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "QUANTITY BOUGHT"
        '
        'txtQuantityBought
        '
        Me.txtQuantityBought.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityBought.Location = New System.Drawing.Point(750, 277)
        Me.txtQuantityBought.Multiline = True
        Me.txtQuantityBought.Name = "txtQuantityBought"
        Me.txtQuantityBought.Size = New System.Drawing.Size(173, 32)
        Me.txtQuantityBought.TabIndex = 34
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(750, 213)
        Me.txtUnitPrice.Multiline = True
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(173, 32)
        Me.txtUnitPrice.TabIndex = 33
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty.Location = New System.Drawing.Point(267, 402)
        Me.txtAvailableQty.Multiline = True
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.Size = New System.Drawing.Size(233, 32)
        Me.txtAvailableQty.TabIndex = 36
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerContact.Location = New System.Drawing.Point(267, 274)
        Me.txtCustomerContact.Multiline = True
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(236, 32)
        Me.txtCustomerContact.TabIndex = 35
        '
        'cboItemName
        '
        Me.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemName.FormattingEnabled = True
        Me.cboItemName.Location = New System.Drawing.Point(672, 156)
        Me.cboItemName.Name = "cboItemName"
        Me.cboItemName.Size = New System.Drawing.Size(250, 21)
        Me.cboItemName.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 553)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(940, 194)
        Me.DataGridView1.TabIndex = 31
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Green
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSales.Location = New System.Drawing.Point(411, 441)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(201, 64)
        Me.btnSales.TabIndex = 29
        Me.btnSales.Text = "RECORD CREDIT SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'dtpSold
        '
        Me.dtpSold.Location = New System.Drawing.Point(482, 341)
        Me.dtpSold.Name = "dtpSold"
        Me.dtpSold.Size = New System.Drawing.Size(18, 20)
        Me.dtpSold.TabIndex = 30
        '
        'txtDateSold
        '
        Me.txtDateSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateSold.Location = New System.Drawing.Point(267, 339)
        Me.txtDateSold.Multiline = True
        Me.txtDateSold.Name = "txtDateSold"
        Me.txtDateSold.ReadOnly = True
        Me.txtDateSold.Size = New System.Drawing.Size(216, 25)
        Me.txtDateSold.TabIndex = 27
        '
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(267, 154)
        Me.txtItemCode.Multiline = True
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(235, 32)
        Me.txtItemCode.TabIndex = 21
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(267, 213)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(235, 32)
        Me.txtCustomerName.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "DATE SOLD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(517, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "UNIT PRICE ( GHC )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "CUSTOMER CONTACT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "CUSTOMER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ITEM NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ITEM CODE"
        '
        'lblNotice
        '
        Me.lblNotice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.Lime
        Me.lblNotice.Location = New System.Drawing.Point(-3, 49)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(940, 75)
        Me.lblNotice.TabIndex = 28
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeOfSales
        '
        Me.timeOfSales.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeOfSales.Location = New System.Drawing.Point(74, 12)
        Me.timeOfSales.Name = "timeOfSales"
        Me.timeOfSales.Size = New System.Drawing.Size(16, 20)
        Me.timeOfSales.TabIndex = 44
        '
        'txtTimeOfCreditSales
        '
        Me.txtTimeOfCreditSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOfCreditSales.ForeColor = System.Drawing.Color.Red
        Me.txtTimeOfCreditSales.Location = New System.Drawing.Point(7, 12)
        Me.txtTimeOfCreditSales.Multiline = True
        Me.txtTimeOfCreditSales.Name = "txtTimeOfCreditSales"
        Me.txtTimeOfCreditSales.ReadOnly = True
        Me.txtTimeOfCreditSales.Size = New System.Drawing.Size(84, 20)
        Me.txtTimeOfCreditSales.TabIndex = 45
        '
        'CreditSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 754)
        Me.Controls.Add(Me.txtTimeOfCreditSales)
        Me.Controls.Add(Me.timeOfSales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtQuantityBought)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtAvailableQty)
        Me.Controls.Add(Me.txtCustomerContact)
        Me.Controls.Add(Me.cboItemName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.dtpSold)
        Me.Controls.Add(Me.txtDateSold)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNotice)
        Me.Name = "CreditSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreditSales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQuantityBought As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerContact As System.Windows.Forms.TextBox
    Friend WithEvents cboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents dtpSold As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateSold As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents timeOfSales As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTimeOfCreditSales As System.Windows.Forms.TextBox
End Class
