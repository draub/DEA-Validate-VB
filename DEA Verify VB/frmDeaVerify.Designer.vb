<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeaVerify
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
        Me.txtPrescriber = New System.Windows.Forms.TextBox()
        Me.txtDea = New System.Windows.Forms.TextBox()
        Me.cmdVerify = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblPrescriber = New System.Windows.Forms.Label()
        Me.lblDea = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblResultsPass = New System.Windows.Forms.Label()
        Me.lblResultsFail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrescriber
        '
        Me.txtPrescriber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescriber.Location = New System.Drawing.Point(23, 28)
        Me.txtPrescriber.Name = "txtPrescriber"
        Me.txtPrescriber.Size = New System.Drawing.Size(180, 22)
        Me.txtPrescriber.TabIndex = 0
        '
        'txtDea
        '
        Me.txtDea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDea.Location = New System.Drawing.Point(23, 85)
        Me.txtDea.Name = "txtDea"
        Me.txtDea.Size = New System.Drawing.Size(180, 22)
        Me.txtDea.TabIndex = 1
        '
        'cmdVerify
        '
        Me.cmdVerify.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerify.Location = New System.Drawing.Point(23, 139)
        Me.cmdVerify.Name = "cmdVerify"
        Me.cmdVerify.Size = New System.Drawing.Size(75, 23)
        Me.cmdVerify.TabIndex = 3
        Me.cmdVerify.Text = "Verify"
        Me.cmdVerify.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(128, 139)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 4
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lblPrescriber
        '
        Me.lblPrescriber.AutoSize = True
        Me.lblPrescriber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriber.Location = New System.Drawing.Point(20, 12)
        Me.lblPrescriber.Name = "lblPrescriber"
        Me.lblPrescriber.Size = New System.Drawing.Size(134, 16)
        Me.lblPrescriber.TabIndex = 5
        Me.lblPrescriber.Text = "Prescriber Last Name"
        '
        'lblDea
        '
        Me.lblDea.AutoSize = True
        Me.lblDea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDea.Location = New System.Drawing.Point(20, 69)
        Me.lblDea.Name = "lblDea"
        Me.lblDea.Size = New System.Drawing.Size(83, 16)
        Me.lblDea.TabIndex = 6
        Me.lblDea.Text = "DEA Number"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Enabled = False
        Me.lblResults.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(231, 12)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(56, 16)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "Results:"
        '
        'txtResults
        '
        Me.txtResults.BackColor = System.Drawing.SystemColors.Control
        Me.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResults.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(234, 32)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(331, 145)
        Me.txtResults.TabIndex = 8
        Me.txtResults.TabStop = False
        '
        'lblResultsPass
        '
        Me.lblResultsPass.AutoSize = True
        Me.lblResultsPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsPass.ForeColor = System.Drawing.Color.Green
        Me.lblResultsPass.Location = New System.Drawing.Point(291, 10)
        Me.lblResultsPass.Name = "lblResultsPass"
        Me.lblResultsPass.Size = New System.Drawing.Size(52, 19)
        Me.lblResultsPass.TabIndex = 9
        Me.lblResultsPass.Text = "PASS"
        Me.lblResultsPass.Visible = False
        '
        'lblResultsFail
        '
        Me.lblResultsFail.AutoSize = True
        Me.lblResultsFail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsFail.ForeColor = System.Drawing.Color.Red
        Me.lblResultsFail.Location = New System.Drawing.Point(293, 10)
        Me.lblResultsFail.Name = "lblResultsFail"
        Me.lblResultsFail.Size = New System.Drawing.Size(43, 19)
        Me.lblResultsFail.TabIndex = 10
        Me.lblResultsFail.Text = "FAIL"
        Me.lblResultsFail.Visible = False
        '
        'frmDeaVerify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 189)
        Me.Controls.Add(Me.lblResultsFail)
        Me.Controls.Add(Me.lblResultsPass)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblDea)
        Me.Controls.Add(Me.lblPrescriber)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdVerify)
        Me.Controls.Add(Me.txtDea)
        Me.Controls.Add(Me.txtPrescriber)
        Me.Name = "frmDeaVerify"
        Me.Text = "Verify DEA Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrescriber As TextBox
    Friend WithEvents txtDea As TextBox
    Friend WithEvents cmdVerify As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents lblPrescriber As Label
    Friend WithEvents lblDea As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblResultsPass As Label
    Friend WithEvents lblResultsFail As Label
End Class
