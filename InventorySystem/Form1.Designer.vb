<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportOnSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportOnStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADMINISTRATORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcceptDebtPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateSalesPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReportOnSalesToolStripMenuItem, Me.ReportOnStockToolStripMenuItem, Me.ADMINISTRATORToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1133, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(120, 20)
        Me.ToolStripMenuItem1.Text = "Register New Stock"
        '
        'ReportOnSalesToolStripMenuItem
        '
        Me.ReportOnSalesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ReportOnSalesToolStripMenuItem.Name = "ReportOnSalesToolStripMenuItem"
        Me.ReportOnSalesToolStripMenuItem.Size = New System.Drawing.Size(172, 20)
        Me.ReportOnSalesToolStripMenuItem.Text = "Report On Credit Sales ( OIL )"
        '
        'ReportOnStockToolStripMenuItem
        '
        Me.ReportOnStockToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ReportOnStockToolStripMenuItem.Name = "ReportOnStockToolStripMenuItem"
        Me.ReportOnStockToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ReportOnStockToolStripMenuItem.Text = "Report On Stock"
        '
        'ADMINISTRATORToolStripMenuItem
        '
        Me.ADMINISTRATORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStockToolStripMenuItem, Me.AcceptDebtPaymentToolStripMenuItem, Me.CreateSalesPersonToolStripMenuItem})
        Me.ADMINISTRATORToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ADMINISTRATORToolStripMenuItem.Name = "ADMINISTRATORToolStripMenuItem"
        Me.ADMINISTRATORToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ADMINISTRATORToolStripMenuItem.Text = "ADMINISTRATOR"
        '
        'UpdateStockToolStripMenuItem
        '
        Me.UpdateStockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateStockToolStripMenuItem.Name = "UpdateStockToolStripMenuItem"
        Me.UpdateStockToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.UpdateStockToolStripMenuItem.Text = "Update Stock"
        '
        'AcceptDebtPaymentToolStripMenuItem
        '
        Me.AcceptDebtPaymentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptDebtPaymentToolStripMenuItem.Name = "AcceptDebtPaymentToolStripMenuItem"
        Me.AcceptDebtPaymentToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AcceptDebtPaymentToolStripMenuItem.Text = "Accept Debt Payment"
        '
        'CreateSalesPersonToolStripMenuItem
        '
        Me.CreateSalesPersonToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateSalesPersonToolStripMenuItem.Name = "CreateSalesPersonToolStripMenuItem"
        Me.CreateSalesPersonToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CreateSalesPersonToolStripMenuItem.Text = "Create Sales Person"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "InventorySystem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportOnSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportOnStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINISTRATORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcceptDebtPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateSalesPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
