<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeaValidate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeaValidate))
        Me.txtPrescriber = New System.Windows.Forms.TextBox()
        Me.txtDea = New System.Windows.Forms.TextBox()
        Me.cmdValidate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblPrescriber = New System.Windows.Forms.Label()
        Me.lblDea = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblResultsPass = New System.Windows.Forms.Label()
        Me.lblResultsFail = New System.Windows.Forms.Label()
        Me.chkDetails = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtPrescriber
        '
        Me.txtPrescriber.BackColor = System.Drawing.Color.White
        Me.txtPrescriber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescriber.Location = New System.Drawing.Point(25, 35)
        Me.txtPrescriber.Name = "txtPrescriber"
        Me.txtPrescriber.Size = New System.Drawing.Size(180, 22)
        Me.txtPrescriber.TabIndex = 0
        '
        'txtDea
        '
        Me.txtDea.BackColor = System.Drawing.Color.White
        Me.txtDea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDea.Location = New System.Drawing.Point(25, 90)
        Me.txtDea.Name = "txtDea"
        Me.txtDea.Size = New System.Drawing.Size(180, 22)
        Me.txtDea.TabIndex = 1
        '
        'cmdValidate
        '
        Me.cmdValidate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdValidate.Location = New System.Drawing.Point(25, 155)
        Me.cmdValidate.Name = "cmdValidate"
        Me.cmdValidate.Size = New System.Drawing.Size(75, 23)
        Me.cmdValidate.TabIndex = 3
        Me.cmdValidate.Text = "Validate"
        Me.cmdValidate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(128, 155)
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
        Me.lblPrescriber.Location = New System.Drawing.Point(22, 15)
        Me.lblPrescriber.Name = "lblPrescriber"
        Me.lblPrescriber.Size = New System.Drawing.Size(134, 16)
        Me.lblPrescriber.TabIndex = 5
        Me.lblPrescriber.Text = "Prescriber Last Name"
        '
        'lblDea
        '
        Me.lblDea.AutoSize = True
        Me.lblDea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDea.Location = New System.Drawing.Point(22, 70)
        Me.lblDea.Name = "lblDea"
        Me.lblDea.Size = New System.Drawing.Size(83, 16)
        Me.lblDea.TabIndex = 6
        Me.lblDea.Text = "DEA Number"
        '
        'txtResults
        '
        Me.txtResults.BackColor = System.Drawing.SystemColors.Control
        Me.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResults.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(236, 24)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(331, 154)
        Me.txtResults.TabIndex = 8
        Me.txtResults.TabStop = False
        '
        'lblResultsPass
        '
        Me.lblResultsPass.AutoSize = True
        Me.lblResultsPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsPass.ForeColor = System.Drawing.Color.Green
        Me.lblResultsPass.Location = New System.Drawing.Point(156, 67)
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
        Me.lblResultsFail.Location = New System.Drawing.Point(165, 67)
        Me.lblResultsFail.Name = "lblResultsFail"
        Me.lblResultsFail.Size = New System.Drawing.Size(43, 19)
        Me.lblResultsFail.TabIndex = 10
        Me.lblResultsFail.Text = "FAIL"
        Me.lblResultsFail.Visible = False
        '
        'chkDetails
        '
        Me.chkDetails.AutoSize = True
        Me.chkDetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetails.Location = New System.Drawing.Point(25, 120)
        Me.chkDetails.Name = "chkDetails"
        Me.chkDetails.Size = New System.Drawing.Size(67, 20)
        Me.chkDetails.TabIndex = 11
        Me.chkDetails.Text = "Details"
        Me.chkDetails.UseVisualStyleBackColor = True
        '
        'frmDeaValidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 196)
        Me.Controls.Add(Me.chkDetails)
        Me.Controls.Add(Me.lblResultsFail)
        Me.Controls.Add(Me.lblResultsPass)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.lblDea)
        Me.Controls.Add(Me.lblPrescriber)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdValidate)
        Me.Controls.Add(Me.txtDea)
        Me.Controls.Add(Me.txtPrescriber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDeaValidate"
        Me.Text = "Validate DEA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrescriber As TextBox
    Friend WithEvents txtDea As TextBox
    Friend WithEvents cmdValidate As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents lblPrescriber As Label
    Friend WithEvents lblDea As Label
    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblResultsPass As Label
    Friend WithEvents lblResultsFail As Label
    Friend WithEvents chkDetails As CheckBox
End Class
