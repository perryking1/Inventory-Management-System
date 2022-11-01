<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportOnSales
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
        Me.crvSales = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnReportSales = New System.Windows.Forms.Button
        Me.btnViewAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSelectSalesPerson = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 141)
        Me.Label1.TabIndex = 0
        '
        'crvSales
        '
        Me.crvSales.ActiveViewIndex = -1
        Me.crvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvSales.Location = New System.Drawing.Point(11, 153)
        Me.crvSales.Name = "crvSales"
        Me.crvSales.SelectionFormula = ""
        Me.crvSales.Size = New System.Drawing.Size(792, 516)
        Me.crvSales.TabIndex = 1
        Me.crvSales.ViewTimeSelectionFormula = ""
        '
        'btnReportSales
        '
        Me.btnReportSales.BackColor = System.Drawing.Color.ForestGreen
        Me.btnReportSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportSales.ForeColor = System.Drawing.Color.White
        Me.btnReportSales.Location = New System.Drawing.Point(165, 100)
        Me.btnReportSales.Name = "btnReportSales"
        Me.btnReportSales.Size = New System.Drawing.Size(106, 30)
        Me.btnReportSales.TabIndex = 2
        Me.btnReportSales.Text = "Generate"
        Me.btnReportSales.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewAll.BackColor = System.Drawing.Color.ForestGreen
        Me.btnViewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(631, 40)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(168, 58)
        Me.btnViewAll.TabIndex = 6
        Me.btnViewAll.Text = "View All Report"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SELECT INDIVIDUAL OIL SALES-PERSON REPORT"
        '
        'cboSelectSalesPerson
        '
        Me.cboSelectSalesPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectSalesPerson.FormattingEnabled = True
        Me.cboSelectSalesPerson.Location = New System.Drawing.Point(24, 51)
        Me.cboSelectSalesPerson.Name = "cboSelectSalesPerson"
        Me.cboSelectSalesPerson.Size = New System.Drawing.Size(267, 21)
        Me.cboSelectSalesPerson.TabIndex = 8
        '
        'ReportOnSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 681)
        Me.Controls.Add(Me.cboSelectSalesPerson)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnReportSales)
        Me.Controls.Add(Me.crvSales)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "ReportOnSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report On Oil-Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crvSales As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnReportSales As System.Windows.Forms.Button
    Friend WithEvents btnViewAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSelectSalesPerson As System.Windows.Forms.ComboBox
End Class
