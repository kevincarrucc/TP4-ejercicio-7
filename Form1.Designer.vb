<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.GrillaVectorB = New System.Windows.Forms.DataGridView()
        Me.GrillaVectorA = New System.Windows.Forms.DataGridView()
        CType(Me.GrillaVectorB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaVectorA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(208, 22)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(140, 23)
        Me.BtnEjecutar.TabIndex = 0
        Me.BtnEjecutar.Text = "Cargar valores"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'GrillaVectorB
        '
        Me.GrillaVectorB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaVectorB.ColumnHeadersVisible = False
        Me.GrillaVectorB.Location = New System.Drawing.Point(112, 12)
        Me.GrillaVectorB.Name = "GrillaVectorB"
        Me.GrillaVectorB.RowHeadersVisible = False
        Me.GrillaVectorB.Size = New System.Drawing.Size(67, 237)
        Me.GrillaVectorB.TabIndex = 1
        '
        'GrillaVectorA
        '
        Me.GrillaVectorA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaVectorA.ColumnHeadersVisible = False
        Me.GrillaVectorA.Location = New System.Drawing.Point(12, 12)
        Me.GrillaVectorA.Name = "GrillaVectorA"
        Me.GrillaVectorA.RowHeadersVisible = False
        Me.GrillaVectorA.Size = New System.Drawing.Size(71, 237)
        Me.GrillaVectorA.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrillaVectorA)
        Me.Controls.Add(Me.GrillaVectorB)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaVectorB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaVectorA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents GrillaVectorB As DataGridView
    Friend WithEvents GrillaVectorA As DataGridView
End Class
