<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Algebra_Relacional = New System.Windows.Forms.GroupBox()
        Me.Algebra_label = New System.Windows.Forms.Label()
        Me.Consulta_SQL = New System.Windows.Forms.GroupBox()
        Me.SQL_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.p = New System.Windows.Forms.TextBox()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Algebra_Relacional.SuspendLayout()
        Me.Consulta_SQL.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(248, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 258)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.Location = New System.Drawing.Point(16, 32)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.Size = New System.Drawing.Size(287, 199)
        Me.DataGridView2.TabIndex = 2
        '
        'Algebra_Relacional
        '
        Me.Algebra_Relacional.Controls.Add(Me.Algebra_label)
        Me.Algebra_Relacional.Location = New System.Drawing.Point(14, 326)
        Me.Algebra_Relacional.Name = "Algebra_Relacional"
        Me.Algebra_Relacional.Size = New System.Drawing.Size(200, 69)
        Me.Algebra_Relacional.TabIndex = 15
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
        Me.Consulta_SQL.Controls.Add(Me.SQL_Label)
        Me.Consulta_SQL.Location = New System.Drawing.Point(14, 236)
        Me.Consulta_SQL.Name = "Consulta_SQL"
        Me.Consulta_SQL.Size = New System.Drawing.Size(200, 69)
        Me.Consulta_SQL.TabIndex = 14
        Me.Consulta_SQL.TabStop = False
        Me.Consulta_SQL.Text = "Consulta_SQL"
        '
        'SQL_Label
        '
        Me.SQL_Label.AutoSize = True
        Me.SQL_Label.Location = New System.Drawing.Point(27, 33)
        Me.SQL_Label.MaximumSize = New System.Drawing.Size(388, 80)
        Me.SQL_Label.MinimumSize = New System.Drawing.Size(3, 5)
        Me.SQL_Label.Name = "SQL_Label"
        Me.SQL_Label.Size = New System.Drawing.Size(3, 13)
        Me.SQL_Label.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.p)
        Me.GroupBox1.Controls.Add(Me.p1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 194)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre de la tabla 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre de la Tabla"
        '
        'p
        '
        Me.p.Location = New System.Drawing.Point(19, 59)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(118, 20)
        Me.p.TabIndex = 6
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(19, 122)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(118, 20)
        Me.p1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 397)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Algebra_Relacional)
        Me.Controls.Add(Me.Consulta_SQL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Unión"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Algebra_Relacional.ResumeLayout(False)
        Me.Algebra_Relacional.PerformLayout()
        Me.Consulta_SQL.ResumeLayout(False)
        Me.Consulta_SQL.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Algebra_Relacional As GroupBox
    Friend WithEvents Algebra_label As Label
    Friend WithEvents Consulta_SQL As GroupBox
    Friend WithEvents SQL_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents p As TextBox
    Friend WithEvents p1 As TextBox
    Friend WithEvents Button1 As Button
End Class
