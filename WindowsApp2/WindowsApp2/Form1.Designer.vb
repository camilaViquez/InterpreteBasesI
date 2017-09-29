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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.p = New System.Windows.Forms.TextBox()
        Me.SQL_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Consulta_SQL = New System.Windows.Forms.GroupBox()
        Me.Algebra_Relacional = New System.Windows.Forms.GroupBox()
        Me.Algebra_label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CantonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasDataSet = New WindowsApp2.VentasDataSet()
        Me.CantonesTableAdapter = New WindowsApp2.VentasDataSetTableAdapters.cantonesTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.VentasDataSetTableAdapters.TableAdapterManager()
        Me.FacturasTableAdapter1 = New WindowsApp2.VentasDataSetTableAdapters.facturasTableAdapter()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Consulta_SQL.SuspendLayout()
        Me.Algebra_Relacional.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CantonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(19, 122)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(118, 20)
        Me.p1.TabIndex = 3
        '
        'p
        '
        Me.p.Location = New System.Drawing.Point(19, 59)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(118, 20)
        Me.p.TabIndex = 6
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 194)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Atributos"
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
        'Consulta_SQL
        '
        Me.Consulta_SQL.Controls.Add(Me.SQL_Label)
        Me.Consulta_SQL.Location = New System.Drawing.Point(12, 252)
        Me.Consulta_SQL.Name = "Consulta_SQL"
        Me.Consulta_SQL.Size = New System.Drawing.Size(217, 69)
        Me.Consulta_SQL.TabIndex = 9
        Me.Consulta_SQL.TabStop = False
        Me.Consulta_SQL.Text = "Consulta_SQL"
        '
        'Algebra_Relacional
        '
        Me.Algebra_Relacional.Controls.Add(Me.Algebra_label)
        Me.Algebra_Relacional.Location = New System.Drawing.Point(12, 342)
        Me.Algebra_Relacional.Name = "Algebra_Relacional"
        Me.Algebra_Relacional.Size = New System.Drawing.Size(217, 69)
        Me.Algebra_Relacional.TabIndex = 10
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 258)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'CantonesBindingSource
        '
        Me.CantonesBindingSource.DataMember = "cantones"
        Me.CantonesBindingSource.DataSource = Me.VentasDataSet
        '
        'VentasDataSet
        '
        Me.VentasDataSet.DataSetName = "VentasDataSet"
        Me.VentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CantonesTableAdapter
        '
        Me.CantonesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cantonesTableAdapter = Me.CantonesTableAdapter
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.facturasTableAdapter = Nothing
        Me.TableAdapterManager.lineas_de_facturasTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.VentasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturasTableAdapter1
        '
        Me.FacturasTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Algebra_Relacional)
        Me.Controls.Add(Me.Consulta_SQL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Consulta_SQL.ResumeLayout(False)
        Me.Consulta_SQL.PerformLayout()
        Me.Algebra_Relacional.ResumeLayout(False)
        Me.Algebra_Relacional.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CantonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents VentasDataSet As VentasDataSet
    Friend WithEvents CantonesBindingSource As BindingSource
    Friend WithEvents CantonesTableAdapter As VentasDataSetTableAdapters.cantonesTableAdapter
    Friend WithEvents TableAdapterManager As VentasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturasTableAdapter1 As VentasDataSetTableAdapters.facturasTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents p1 As TextBox
    Friend WithEvents p As TextBox
    Friend WithEvents SQL_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Consulta_SQL As GroupBox
    Friend WithEvents Algebra_Relacional As GroupBox
    Friend WithEvents Algebra_label As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
