﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Algebra_Relacional = New System.Windows.Forms.GroupBox()
        Me.Algebra_label = New System.Windows.Forms.Label()
        Me.Consulta_SQL = New System.Windows.Forms.GroupBox()
        Me.SQL_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre_tabla = New System.Windows.Forms.TextBox()
        Me.operaciones = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Algebra_Relacional.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 258)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(16, 32)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(287, 199)
        Me.DataGridView2.TabIndex = 2
        '
        'Algebra_Relacional
        '
        Me.Algebra_Relacional.Controls.Add(Me.Algebra_label)
        Me.Algebra_Relacional.Location = New System.Drawing.Point(32, 421)
        Me.Algebra_Relacional.Name = "Algebra_Relacional"
        Me.Algebra_Relacional.Size = New System.Drawing.Size(200, 69)
        Me.Algebra_Relacional.TabIndex = 25
        Me.Algebra_Relacional.TabStop = False
        Me.Algebra_Relacional.Text = "Algebra Relacional"
        '
        'Algebra_label
        '
        Me.Algebra_label.AutoSize = True
        Me.Algebra_label.Location = New System.Drawing.Point(27, 27)
        Me.Algebra_label.MaximumSize = New System.Drawing.Size(388, 80)
        Me.Algebra_label.MinimumSize = New System.Drawing.Size(3, 5)
        Me.Algebra_label.Name = "Algebra_label"
        Me.Algebra_label.Size = New System.Drawing.Size(3, 13)
        Me.Algebra_label.TabIndex = 8
        '
        'Consulta_SQL
        '
        Me.Consulta_SQL.Location = New System.Drawing.Point(32, 331)
        Me.Consulta_SQL.Name = "Consulta_SQL"
        Me.Consulta_SQL.Size = New System.Drawing.Size(200, 26)
        Me.Consulta_SQL.TabIndex = 24
        Me.Consulta_SQL.TabStop = False
        Me.Consulta_SQL.Text = "Consulta_SQL"
        '
        'SQL_Label
        '
        Me.SQL_Label.AutoSize = True
        Me.SQL_Label.Location = New System.Drawing.Point(35, 370)
        Me.SQL_Label.MaximumSize = New System.Drawing.Size(388, 80)
        Me.SQL_Label.MinimumSize = New System.Drawing.Size(3, 5)
        Me.SQL_Label.Name = "SQL_Label"
        Me.SQL_Label.Size = New System.Drawing.Size(3, 13)
        Me.SQL_Label.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.resultado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nombre_tabla)
        Me.GroupBox1.Controls.Add(Me.operaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 280)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre de la Tabla resultante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Operaciones"
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(6, 180)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(149, 20)
        Me.resultado.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre de la Tabla I"
        '
        'nombre_tabla
        '
        Me.nombre_tabla.Location = New System.Drawing.Point(9, 59)
        Me.nombre_tabla.Name = "nombre_tabla"
        Me.nombre_tabla.Size = New System.Drawing.Size(146, 20)
        Me.nombre_tabla.TabIndex = 6
        '
        'operaciones
        '
        Me.operaciones.Location = New System.Drawing.Point(9, 108)
        Me.operaciones.Name = "operaciones"
        Me.operaciones.Size = New System.Drawing.Size(146, 20)
        Me.operaciones.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Agregacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 525)
        Me.Controls.Add(Me.SQL_Label)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Algebra_Relacional)
        Me.Controls.Add(Me.Consulta_SQL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Agregacion"
        Me.Text = "Agregacion"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Algebra_Relacional.ResumeLayout(False)
        Me.Algebra_Relacional.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Algebra_Relacional As GroupBox
    Friend WithEvents Algebra_label As Label
    Friend WithEvents Consulta_SQL As GroupBox
    Friend WithEvents SQL_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents resultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre_tabla As TextBox
    Friend WithEvents operaciones As TextBox
    Friend WithEvents Button1 As Button
End Class
