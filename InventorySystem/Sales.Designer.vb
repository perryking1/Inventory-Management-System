<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashSales
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.txtDateSold = New System.Windows.Forms.TextBox
        Me.dtpSold = New System.Windows.Forms.DateTimePicker
        Me.lblNotice = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.btnSales = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cboItemName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCustomerContact = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtQuantityBought = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAvailableQty = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(523, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ITEM NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CUSTOMER NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DATE SOLD"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(273, 222)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(235, 32)
        Me.txtCustomerName.TabIndex = 2
        '
        'txtDateSold
        '
        Me.txtDateSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateSold.Location = New System.Drawing.Point(273, 348)
        Me.txtDateSold.Multiline = True
        Me.txtDateSold.Name = "txtDateSold"
        Me.txtDateSold.ReadOnly = True
        Me.txtDateSold.Size = New System.Drawing.Size(216, 25)
        Me.txtDateSold.TabIndex = 3
        '
        'dtpSold
        '
        Me.dtpSold.Location = New System.Drawing.Point(488, 350)
        Me.dtpSold.Name = "dtpSold"
        Me.dtpSold.Size = New System.Drawing.Size(18, 20)
        Me.dtpSold.TabIndex = 4
        '
        'lblNotice
        '
        Me.lblNotice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.Lime
        Me.lblNotice.Location = New System.Drawing.Point(3, 58)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(940, 75)
        Me.lblNotice.TabIndex = 3
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(273, 163)
        Me.txtItemCode.Multiline = True
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(235, 32)
        Me.txtItemCode.TabIndex = 0
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Green
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSales.Location = New System.Drawing.Point(401, 450)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(167, 64)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = "MAKE SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 562)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(940, 194)
        Me.DataGridView1.TabIndex = 5
        '
        'cboItemName
        '
        Me.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemName.FormattingEnabled = True
        Me.cboItemName.Location = New System.Drawing.Point(678, 165)
        Me.cboItemName.Name = "cboItemName"
        Me.cboItemName.Size = New System.Drawing.Size(250, 21)
        Me.cboItemName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CUSTOMER CONTACT"
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerContact.Location = New System.Drawing.Point(273, 283)
        Me.txtCustomerContact.Multiline = True
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(236, 32)
        Me.txtCustomerContact.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(523, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "UNIT PRICE ( GHC )"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(756, 222)
        Me.txtUnitPrice.Multiline = True
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(173, 32)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "QUANTITY BOUGHT"
        '
        'txtQuantityBought
        '
        Me.txtQuantityBought.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityBought.Location = New System.Drawing.Point(756, 286)
        Me.txtQuantityBought.Multiline = True
        Me.txtQuantityBought.Name = "txtQuantityBought"
        Me.txtQuantityBought.Size = New System.Drawing.Size(173, 32)
        Me.txtQuantityBought.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(524, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(275, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL AMOUNT ( GHC )"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(797, 348)
        Me.txtTotalAmount.Multiline = True
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(131, 32)
        Me.txtTotalAmount.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(-16, 517)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(985, 41)
        Me.Label10.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(334, 525)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(283, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "AVAILABLE CASH SALES"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(372, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "MAKE CASH SALES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "AVAILABLE QUANTITY"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty.Location = New System.Drawing.Point(273, 411)
        Me.txtAvailableQty.Multiline = True
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.Size = New System.Drawing.Size(233, 32)
        Me.txtAvailableQty.TabIndex = 8
        '
        'CashSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 754)
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
        Me.MaximizeBox = False
        Me.Name = "CashSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashSales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtDateSold As System.Windows.Forms.TextBox
    Friend WithEvents dtpSold As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQuantityBought As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
End Class
