<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Concatenacion__join_
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Algebra_Relacional = New System.Windows.Forms.GroupBox()
        Me.Algebra_label = New System.Windows.Forms.Label()
        Me.Consulta_SQL = New System.Windows.Forms.GroupBox()
        Me.SQL_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.predicado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tablaR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabla1 = New System.Windows.Forms.TextBox()
        Me.tabla2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelSQL = New System.Windows.Forms.Label()
        Me.LabelA = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Location = New System.Drawing.Point(258, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 258)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(16, 32)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Size = New System.Drawing.Size(287, 199)
        Me.DataGridView2.TabIndex = 2
        '
        'Algebra_Relacional
        '
        Me.Algebra_Relacional.Controls.Add(Me.LabelA)
        Me.Algebra_Relacional.Controls.Add(Me.Algebra_label)
        Me.Algebra_Relacional.Location = New System.Drawing.Point(24, 422)
        Me.Algebra_Relacional.Name = "Algebra_Relacional"
        Me.Algebra_Relacional.Size = New System.Drawing.Size(483, 69)
        Me.Algebra_Relacional.TabIndex = 20
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
        Me.Consulta_SQL.Controls.Add(Me.LabelSQL)
        Me.Consulta_SQL.Controls.Add(Me.SQL_Label)
        Me.Consulta_SQL.Location = New System.Drawing.Point(24, 335)
        Me.Consulta_SQL.Name = "Consulta_SQL"
        Me.Consulta_SQL.Size = New System.Drawing.Size(483, 69)
        Me.Consulta_SQL.TabIndex = 19
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.predicado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tablaR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tabla1)
        Me.GroupBox1.Controls.Add(Me.tabla2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 280)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Predicado"
        '
        'predicado
        '
        Me.predicado.Location = New System.Drawing.Point(6, 173)
        Me.predicado.Name = "predicado"
        Me.predicado.Size = New System.Drawing.Size(149, 20)
        Me.predicado.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre de la Tabla resultante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre de la tabla II"
        '
        'tablaR
        '
        Me.tablaR.Location = New System.Drawing.Point(6, 234)
        Me.tablaR.Name = "tablaR"
        Me.tablaR.Size = New System.Drawing.Size(149, 20)
        Me.tablaR.TabIndex = 17
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
        'tabla1
        '
        Me.tabla1.Location = New System.Drawing.Point(9, 59)
        Me.tabla1.Name = "tabla1"
        Me.tabla1.Size = New System.Drawing.Size(146, 20)
        Me.tabla1.TabIndex = 6
        '
        'tabla2
        '
        Me.tabla2.Location = New System.Drawing.Point(9, 108)
        Me.tabla2.Name = "tabla2"
        Me.tabla2.Size = New System.Drawing.Size(146, 20)
        Me.tabla2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelSQL
        '
        Me.LabelSQL.AutoSize = True
        Me.LabelSQL.Location = New System.Drawing.Point(6, 26)
        Me.LabelSQL.Name = "LabelSQL"
        Me.LabelSQL.Size = New System.Drawing.Size(0, 13)
        Me.LabelSQL.TabIndex = 8
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(6, 27)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(0, 13)
        Me.LabelA.TabIndex = 9
        '
        'Concatenacion__join_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 514)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Algebra_Relacional)
        Me.Controls.Add(Me.Consulta_SQL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Concatenacion__join_"
        Me.Text = "Concatenacion__join_"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents predicado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tablaR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tabla1 As TextBox
    Friend WithEvents tabla2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelA As Label
    Friend WithEvents LabelSQL As Label
End Class
