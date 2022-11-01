<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebtorsForm
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
        Me.txtAmountOwing = New System.Windows.Forms.TextBox
        Me.txtTotalQty = New System.Windows.Forms.TextBox
        Me.cboSalesPersonsName = New System.Windows.Forms.ComboBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDateRecorded = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAcceptPayment = New System.Windows.Forms.TextBox
        Me.txtNewAmountOwing = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDateOfPayment = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpDateOfPayment = New System.Windows.Forms.DateTimePicker
        Me.btnRecord = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(-5, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(887, 38)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UPDATE DEBTORS INFORMATION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALES PERSON'S NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmountOwing
        '
        Me.txtAmountOwing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountOwing.Location = New System.Drawing.Point(713, 242)
        Me.txtAmountOwing.Multiline = True
        Me.txtAmountOwing.Name = "txtAmountOwing"
        Me.txtAmountOwing.ReadOnly = True
        Me.txtAmountOwing.Size = New System.Drawing.Size(153, 32)
        Me.txtAmountOwing.TabIndex = 4
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(231, 237)
        Me.txtTotalQty.Multiline = True
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(235, 32)
        Me.txtTotalQty.TabIndex = 3
        '
        'cboSalesPersonsName
        '
        Me.cboSalesPersonsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesPersonsName.FormattingEnabled = True
        Me.cboSalesPersonsName.Location = New System.Drawing.Point(234, 162)
        Me.cboSalesPersonsName.Name = "cboSalesPersonsName"
        Me.cboSalesPersonsName.Size = New System.Drawing.Size(235, 21)
        Me.cboSalesPersonsName.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(713, 157)
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(153, 32)
        Me.txtContact.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "TOTAL QUANTITY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "AMOUNT OWING ( GHC )"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "DATE RECORDED"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDateRecorded
        '
        Me.txtDateRecorded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateRecorded.Location = New System.Drawing.Point(230, 328)
        Me.txtDateRecorded.Multiline = True
        Me.txtDateRecorded.Name = "txtDateRecorded"
        Me.txtDateRecorded.ReadOnly = True
        Me.txtDateRecorded.Size = New System.Drawing.Size(236, 32)
        Me.txtDateRecorded.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ACCEPT PAYMENT ( GHC )"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAcceptPayment
        '
        Me.txtAcceptPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcceptPayment.Location = New System.Drawing.Point(713, 328)
        Me.txtAcceptPayment.Multiline = True
        Me.txtAcceptPayment.Name = "txtAcceptPayment"
        Me.txtAcceptPayment.Size = New System.Drawing.Size(153, 32)
        Me.txtAcceptPayment.TabIndex = 1
        '
        'txtNewAmountOwing
        '
        Me.txtNewAmountOwing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAmountOwing.Location = New System.Drawing.Point(713, 397)
        Me.txtNewAmountOwing.Multiline = True
        Me.txtNewAmountOwing.Name = "txtNewAmountOwing"
        Me.txtNewAmountOwing.ReadOnly = True
        Me.txtNewAmountOwing.Size = New System.Drawing.Size(153, 32)
        Me.txtNewAmountOwing.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(484, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "NEW AMOUNT OWING"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDateOfPayment
        '
        Me.txtDateOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfPayment.Location = New System.Drawing.Point(276, 398)
        Me.txtDateOfPayment.Multiline = True
        Me.txtDateOfPayment.Name = "txtDateOfPayment"
        Me.txtDateOfPayment.ReadOnly = True
        Me.txtDateOfPayment.Size = New System.Drawing.Size(174, 32)
        Me.txtDateOfPayment.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 408)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SELECT DATE OF PAYMENT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDateOfPayment
        '
        Me.dtpDateOfPayment.Location = New System.Drawing.Point(449, 405)
        Me.dtpDateOfPayment.Name = "dtpDateOfPayment"
        Me.dtpDateOfPayment.Size = New System.Drawing.Size(16, 20)
        Me.dtpDateOfPayment.TabIndex = 7
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.Lime
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(377, 554)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(182, 62)
        Me.btnRecord.TabIndex = 9
        Me.btnRecord.Text = "RECORD"
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CONTACT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DebtorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 691)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.dtpDateOfPayment)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDateOfPayment)
        Me.Controls.Add(Me.txtNewAmountOwing)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboSalesPersonsName)
        Me.Controls.Add(Me.txtAcceptPayment)
        Me.Controls.Add(Me.txtDateRecorded)
        Me.Controls.Add(Me.txtAmountOwing)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "DebtorsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DebtorsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmountOwing As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalQty As System.Windows.Forms.TextBox
    Friend WithEvents cboSalesPersonsName As System.Windows.Forms.ComboBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDateRecorded As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAcceptPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtNewAmountOwing As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDateOfPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfPayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
