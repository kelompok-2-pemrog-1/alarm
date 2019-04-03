<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alarm))
        Me.lb_nama = New System.Windows.Forms.Label()
        Me.lb_jam = New System.Windows.Forms.Label()
        Me.lb_waktu = New System.Windows.Forms.Label()
        Me.lb_nada = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bt_atur = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.bt_pilih = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_nama
        '
        Me.lb_nama.AutoSize = True
        Me.lb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.Location = New System.Drawing.Point(74, 9)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(240, 31)
        Me.lb_nama.TabIndex = 0
        Me.lb_nama.Text = " Kelompok 2 Alarm"
        '
        'lb_jam
        '
        Me.lb_jam.AutoSize = True
        Me.lb_jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_jam.Location = New System.Drawing.Point(126, 62)
        Me.lb_jam.Name = "lb_jam"
        Me.lb_jam.Size = New System.Drawing.Size(140, 25)
        Me.lb_jam.TabIndex = 1
        Me.lb_jam.Text = "Jam Sekarang"
        '
        'lb_waktu
        '
        Me.lb_waktu.AutoSize = True
        Me.lb_waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_waktu.Location = New System.Drawing.Point(25, 112)
        Me.lb_waktu.Name = "lb_waktu"
        Me.lb_waktu.Size = New System.Drawing.Size(55, 20)
        Me.lb_waktu.TabIndex = 2
        Me.lb_waktu.Text = "Waktu"
        '
        'lb_nada
        '
        Me.lb_nada.AutoSize = True
        Me.lb_nada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nada.Location = New System.Drawing.Point(25, 150)
        Me.lb_nada.Name = "lb_nada"
        Me.lb_nada.Size = New System.Drawing.Size(47, 20)
        Me.lb_nada.TabIndex = 3
        Me.lb_nada.Text = "Nada"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 20)
        Me.TextBox1.TabIndex = 5
        '
        'bt_atur
        '
        Me.bt_atur.Location = New System.Drawing.Point(303, 109)
        Me.bt_atur.Name = "bt_atur"
        Me.bt_atur.Size = New System.Drawing.Size(75, 23)
        Me.bt_atur.TabIndex = 6
        Me.bt_atur.Text = "Atur"
        Me.bt_atur.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(29, 196)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(107, 31)
        Me.AxWindowsMediaPlayer1.TabIndex = 7
        '
        'bt_pilih
        '
        Me.bt_pilih.Location = New System.Drawing.Point(304, 150)
        Me.bt_pilih.Name = "bt_pilih"
        Me.bt_pilih.Size = New System.Drawing.Size(75, 23)
        Me.bt_pilih.TabIndex = 8
        Me.bt_pilih.Text = "Pilih"
        Me.bt_pilih.UseVisualStyleBackColor = True
        '
        'form_alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 237)
        Me.Controls.Add(Me.bt_pilih)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.bt_atur)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lb_nada)
        Me.Controls.Add(Me.lb_waktu)
        Me.Controls.Add(Me.lb_jam)
        Me.Controls.Add(Me.lb_nama)
        Me.Name = "form_alarm"
        Me.Text = "Alarm"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_nama As Label
    Friend WithEvents lb_jam As Label
    Friend WithEvents lb_waktu As Label
    Friend WithEvents lb_nada As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bt_atur As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents bt_pilih As Button
End Class
