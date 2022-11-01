<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.btnStock = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.dtpSold = New System.Windows.Forms.DateTimePicker
        Me.dateRecorded = New System.Windows.Forms.TextBox
        Me.txtItemID = New System.Windows.Forms.TextBox
        Me.txtQtyRecorded = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.Green
        Me.btnStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStock.Location = New System.Drawing.Point(159, 482)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(180, 75)
        Me.btnStock.TabIndex = 6
        Me.btnStock.Text = "RECORD STOCK"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(0, 43)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(755, 96)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSold
        '
        Me.dtpSold.Location = New System.Drawing.Point(567, 400)
        Me.dtpSold.Name = "dtpSold"
        Me.dtpSold.Size = New System.Drawing.Size(18, 20)
        Me.dtpSold.TabIndex = 5
        Me.dtpSold.Value = New Date(2019, 12, 12, 0, 0, 0, 0)
        '
        'dateRecorded
        '
        Me.dateRecorded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRecorded.Location = New System.Drawing.Point(356, 397)
        Me.dateRecorded.Multiline = True
        Me.dateRecorded.Name = "dateRecorded"
        Me.dateRecorded.ReadOnly = True
        Me.dateRecorded.Size = New System.Drawing.Size(211, 25)
        Me.dateRecorded.TabIndex = 4
        '
        'txtItemID
        '
        Me.txtItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemID.Location = New System.Drawing.Point(297, 158)
        Me.txtItemID.Multiline = True
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(290, 32)
        Me.txtItemID.TabIndex = 0
        '
        'txtQtyRecorded
        '
        Me.txtQtyRecorded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyRecorded.Location = New System.Drawing.Point(420, 276)
        Me.txtQtyRecorded.Multiline = True
        Me.txtQtyRecorded.Name = "txtQtyRecorded"
        Me.txtQtyRecorded.Size = New System.Drawing.Size(167, 32)
        Me.txtQtyRecorded.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DATE RECORDED"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "QUANTITY RECORDED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ITEM NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ITEM CODE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "REGISTER NEW STOCK"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(420, 332)
        Me.txtUnitPrice.Multiline = True
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(167, 32)
        Me.txtUnitPrice.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "UNIT PRICE ( GHC )"
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(297, 215)
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(290, 32)
        Me.txtItemName.TabIndex = 1
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.Red
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.ForeColor = System.Drawing.Color.White
        Me.btnClearAll.Location = New System.Drawing.Point(405, 486)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(180, 71)
        Me.btnClearAll.TabIndex = 20
        Me.btnClearAll.Text = "CLEAR ALL FIELDS"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 569)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dtpSold)
        Me.Controls.Add(Me.dateRecorded)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.txtQtyRecorded)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents dtpSold As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateRecorded As System.Windows.Forms.TextBox
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtQtyRecorded As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
End Class
