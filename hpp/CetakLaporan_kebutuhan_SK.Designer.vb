﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakLaporan_kebutuhan_SK
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Cetak_hpp_menit1 = New hpp.Cetak_hpp_menit
        Me.Cetak_hpp_waktu_sk1 = New hpp.Cetak_hpp_waktu_sk
        Me.Cetak_laporan_kebutuhan_SK1 = New hpp.Cetak_laporan_kebutuhan_SK
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Cetak_laporan_kebutuhan_SK1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(784, 562)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CetakLaporan_kebutuhan_SK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "CetakLaporan_kebutuhan_SK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CetakLaporan_kebutuhan_SK"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cetak_laporan_kebutuhan_SK1 As hpp.Cetak_laporan_kebutuhan_SK
    Friend WithEvents Cetak_hpp_menit1 As hpp.Cetak_hpp_menit
    Friend WithEvents Cetak_hpp_waktu_sk1 As hpp.Cetak_hpp_waktu_sk
End Class
