﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VwCargo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CargoTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.CargoTableAdapter()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtCargo"
        ReportDataSource1.Value = Me.CargoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCAP_LMBA_Tech.rptCargo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'VwCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VwCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo"
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As LMBADataSetTableAdapters.CargoTableAdapter
End Class
