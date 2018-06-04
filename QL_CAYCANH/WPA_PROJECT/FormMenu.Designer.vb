<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_quidinh = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_baocao = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_phieumua = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_tracuu = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_lich = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_cay = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Baocao = New WPA_PROJECT.BAOCAO()
        Me.Vattu = New WPA_PROJECT.VATTU()
        Me.Tracuucay = New WPA_PROJECT.TRACUUCAY()
        Me.Lichchamsoc = New WPA_PROJECT.LICHCHAMSOC()
        Me.Caycanh = New WPA_PROJECT.caycanh()
        Me.Quidinh = New WPA_PROJECT.QUIDINH()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 508)
        Me.Panel1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btn_quidinh)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 338)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(202, 43)
        Me.Panel8.TabIndex = 8
        '
        'btn_quidinh
        '
        Me.btn_quidinh.Location = New System.Drawing.Point(0, 0)
        Me.btn_quidinh.Name = "btn_quidinh"
        Me.btn_quidinh.Size = New System.Drawing.Size(202, 43)
        Me.btn_quidinh.TabIndex = 2
        Me.btn_quidinh.Text = "Qui dinh"
        Me.btn_quidinh.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btn_baocao)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 295)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(202, 43)
        Me.Panel7.TabIndex = 7
        '
        'btn_baocao
        '
        Me.btn_baocao.Location = New System.Drawing.Point(0, 0)
        Me.btn_baocao.Name = "btn_baocao"
        Me.btn_baocao.Size = New System.Drawing.Size(202, 43)
        Me.btn_baocao.TabIndex = 2
        Me.btn_baocao.Text = "Bao cao"
        Me.btn_baocao.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_phieumua)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 252)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(202, 43)
        Me.Panel6.TabIndex = 6
        '
        'btn_phieumua
        '
        Me.btn_phieumua.Location = New System.Drawing.Point(0, 0)
        Me.btn_phieumua.Name = "btn_phieumua"
        Me.btn_phieumua.Size = New System.Drawing.Size(202, 43)
        Me.btn_phieumua.TabIndex = 2
        Me.btn_phieumua.Text = "Lap phieu mua vat tu"
        Me.btn_phieumua.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_tracuu)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 209)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(202, 43)
        Me.Panel5.TabIndex = 5
        '
        'btn_tracuu
        '
        Me.btn_tracuu.Location = New System.Drawing.Point(0, 0)
        Me.btn_tracuu.Name = "btn_tracuu"
        Me.btn_tracuu.Size = New System.Drawing.Size(202, 43)
        Me.btn_tracuu.TabIndex = 2
        Me.btn_tracuu.Text = "Tra cuu cay canh"
        Me.btn_tracuu.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_lich)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 166)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(202, 43)
        Me.Panel4.TabIndex = 4
        '
        'btn_lich
        '
        Me.btn_lich.Location = New System.Drawing.Point(0, 0)
        Me.btn_lich.Name = "btn_lich"
        Me.btn_lich.Size = New System.Drawing.Size(202, 43)
        Me.btn_lich.TabIndex = 2
        Me.btn_lich.Text = "Lap lich cham soc"
        Me.btn_lich.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_cay)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 43)
        Me.Panel3.TabIndex = 3
        '
        'btn_cay
        '
        Me.btn_cay.Location = New System.Drawing.Point(0, 0)
        Me.btn_cay.Name = "btn_cay"
        Me.btn_cay.Size = New System.Drawing.Size(202, 43)
        Me.btn_cay.TabIndex = 1
        Me.btn_cay.Text = "Trong cay canh moi"
        Me.btn_cay.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(202, 123)
        Me.Panel2.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Quidinh)
        Me.Panel9.Controls.Add(Me.Baocao)
        Me.Panel9.Controls.Add(Me.Vattu)
        Me.Panel9.Controls.Add(Me.Tracuucay)
        Me.Panel9.Controls.Add(Me.Lichchamsoc)
        Me.Panel9.Controls.Add(Me.Caycanh)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(202, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(693, 508)
        Me.Panel9.TabIndex = 1
        '
        'Baocao
        '
        Me.Baocao.Location = New System.Drawing.Point(0, 0)
        Me.Baocao.Name = "Baocao"
        Me.Baocao.Size = New System.Drawing.Size(693, 508)
        Me.Baocao.TabIndex = 4
        '
        'Vattu
        '
        Me.Vattu.BackColor = System.Drawing.Color.White
        Me.Vattu.Location = New System.Drawing.Point(0, 0)
        Me.Vattu.Name = "Vattu"
        Me.Vattu.Size = New System.Drawing.Size(693, 508)
        Me.Vattu.TabIndex = 3
        '
        'Tracuucay
        '
        Me.Tracuucay.Location = New System.Drawing.Point(0, 0)
        Me.Tracuucay.Name = "Tracuucay"
        Me.Tracuucay.Size = New System.Drawing.Size(693, 508)
        Me.Tracuucay.TabIndex = 2
        '
        'Lichchamsoc
        '
        Me.Lichchamsoc.BackColor = System.Drawing.Color.White
        Me.Lichchamsoc.Location = New System.Drawing.Point(0, 0)
        Me.Lichchamsoc.Name = "Lichchamsoc"
        Me.Lichchamsoc.Size = New System.Drawing.Size(693, 508)
        Me.Lichchamsoc.TabIndex = 1
        '
        'Caycanh
        '
        Me.Caycanh.BackColor = System.Drawing.Color.White
        Me.Caycanh.Location = New System.Drawing.Point(0, 3)
        Me.Caycanh.Name = "Caycanh"
        Me.Caycanh.Size = New System.Drawing.Size(704, 508)
        Me.Caycanh.TabIndex = 0
        '
        'Quidinh
        '
        Me.Quidinh.Location = New System.Drawing.Point(0, 0)
        Me.Quidinh.Name = "Quidinh"
        Me.Quidinh.Size = New System.Drawing.Size(693, 508)
        Me.Quidinh.TabIndex = 5
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 508)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_cay As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btn_quidinh As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_baocao As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_phieumua As Button
    Friend WithEvents btn_tracuu As Button
    Friend WithEvents btn_lich As Button


    Friend WithEvents Panel9 As Panel
    Friend WithEvents Lichchamsoc As LICHCHAMSOC
    Friend WithEvents Caycanh As caycanh
    Friend WithEvents Tracuucay As TRACUUCAY
    Friend WithEvents Vattu As VATTU
    Friend WithEvents Baocao As BAOCAO
    Friend WithEvents Quidinh As QUIDINH
End Class
