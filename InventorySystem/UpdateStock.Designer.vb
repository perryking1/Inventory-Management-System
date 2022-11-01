<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStock
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
        Me.txtAvailableQty = New System.Windows.Forms.TextBox
        Me.cboItemName = New System.Windows.Forms.ComboBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtInputBal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNewStockBal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNewPrice = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "AVAILABLE QUANTITY"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty.Location = New System.Drawing.Point(272, 225)
        Me.txtAvailableQty.Multiline = True
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.Size = New System.Drawing.Size(187, 32)
        Me.txtAvailableQty.TabIndex = 48
        '
        'cboItemName
        '
        Me.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemName.FormattingEnabled = True
        Me.cboItemName.Location = New System.Drawing.Point(629, 149)
        Me.cboItemName.Name = "cboItemName"
        Me.cboItemName.Size = New System.Drawing.Size(250, 21)
        Me.cboItemName.TabIndex = 47
        '
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(211, 143)
        Me.txtItemCode.Multiline = True
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(248, 32)
        Me.txtItemCode.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(485, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "ITEM NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ITEM CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 25)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ENTER NEW STOCK"
        '
        'txtInputBal
        '
        Me.txtInputBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputBal.Location = New System.Drawing.Point(722, 229)
        Me.txtInputBal.Multiline = True
        Me.txtInputBal.Name = "txtInputBal"
        Me.txtInputBal.Size = New System.Drawing.Size(157, 32)
        Me.txtInputBal.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "NEW STOCK BALANCE"
        '
        'txtNewStockBal
        '
        Me.txtNewStockBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStockBal.Location = New System.Drawing.Point(273, 326)
        Me.txtNewStockBal.Multiline = True
        Me.txtNewStockBal.Name = "txtNewStockBal"
        Me.txtNewStockBal.ReadOnly = True
        Me.txtNewStockBal.Size = New System.Drawing.Size(186, 32)
        Me.txtNewStockBal.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 25)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ACCEPT NEW STOCK"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(-7, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(903, 45)
        Me.Label7.TabIndex = 54
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(333, 546)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 56)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "UPDATE STOCK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(-7, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(903, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(485, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(306, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "ENTER NEW STOCK PRICE"
        '
        'txtNewPrice
        '
        Me.txtNewPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPrice.Location = New System.Drawing.Point(797, 326)
        Me.txtNewPrice.Multiline = True
        Me.txtNewPrice.Name = "txtNewPrice"
        Me.txtNewPrice.Size = New System.Drawing.Size(82, 32)
        Me.txtNewPrice.TabIndex = 48
        '
        'UpdateStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 636)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewStockBal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNewPrice)
        Me.Controls.Add(Me.txtInputBal)
        Me.Controls.Add(Me.txtAvailableQty)
        Me.Controls.Add(Me.cboItemName)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "UpdateStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
    Friend WithEvents cboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInputBal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewStockBal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNewPrice As System.Windows.Forms.TextBox
End Class
