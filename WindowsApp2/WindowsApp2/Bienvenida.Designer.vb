<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Seleccion = New System.Windows.Forms.Button()
        Me.Proyección_btn = New System.Windows.Forms.Button()
        Me.Unión = New System.Windows.Forms.Button()
        Me.Diferencia_de_Conjuntos_btn = New System.Windows.Forms.Button()
        Me.Producto_Cartesiano_btn = New System.Windows.Forms.Button()
        Me.Interseccion = New System.Windows.Forms.Button()
        Me.DivisionBtn = New System.Windows.Forms.Button()
        Me.Renombrar = New System.Windows.Forms.Button()
        Me.Concatenacion = New System.Windows.Forms.Button()
        Me.Concatenacion_natural = New System.Windows.Forms.Button()
        Me.Agregacio = New System.Windows.Forms.Button()
        Me.Agrupación = New System.Windows.Forms.Button()
        Me.Conectar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TablasTemporales = New System.Windows.Forms.Button()
        Me.tablasPermanentes = New System.Windows.Forms.Button()
        Me.acercaDe = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Seleccion
        '
        Me.Seleccion.Location = New System.Drawing.Point(21, 46)
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.Size = New System.Drawing.Size(75, 23)
        Me.Seleccion.TabIndex = 0
        Me.Seleccion.Text = "Selección"
        Me.Seleccion.UseVisualStyleBackColor = True
        '
        'Proyección_btn
        '
        Me.Proyección_btn.Location = New System.Drawing.Point(21, 94)
        Me.Proyección_btn.Name = "Proyección_btn"
        Me.Proyección_btn.Size = New System.Drawing.Size(75, 23)
        Me.Proyección_btn.TabIndex = 1
        Me.Proyección_btn.Text = "Proyección"
        Me.Proyección_btn.UseVisualStyleBackColor = True
        '
        'Unión
        '
        Me.Unión.Location = New System.Drawing.Point(21, 141)
        Me.Unión.Name = "Unión"
        Me.Unión.Size = New System.Drawing.Size(75, 23)
        Me.Unión.TabIndex = 2
        Me.Unión.Text = "Unión"
        Me.Unión.UseVisualStyleBackColor = True
        '
        'Diferencia_de_Conjuntos_btn
        '
        Me.Diferencia_de_Conjuntos_btn.Location = New System.Drawing.Point(218, 46)
        Me.Diferencia_de_Conjuntos_btn.Name = "Diferencia_de_Conjuntos_btn"
        Me.Diferencia_de_Conjuntos_btn.Size = New System.Drawing.Size(150, 23)
        Me.Diferencia_de_Conjuntos_btn.TabIndex = 3
        Me.Diferencia_de_Conjuntos_btn.Text = "Diferencia de Conjuntos"
        Me.Diferencia_de_Conjuntos_btn.UseVisualStyleBackColor = True
        '
        'Producto_Cartesiano_btn
        '
        Me.Producto_Cartesiano_btn.Location = New System.Drawing.Point(218, 94)
        Me.Producto_Cartesiano_btn.Name = "Producto_Cartesiano_btn"
        Me.Producto_Cartesiano_btn.Size = New System.Drawing.Size(150, 23)
        Me.Producto_Cartesiano_btn.TabIndex = 4
        Me.Producto_Cartesiano_btn.Text = "Producto Cartesiano"
        Me.Producto_Cartesiano_btn.UseVisualStyleBackColor = True
        '
        'Interseccion
        '
        Me.Interseccion.Location = New System.Drawing.Point(484, 46)
        Me.Interseccion.Name = "Interseccion"
        Me.Interseccion.Size = New System.Drawing.Size(96, 23)
        Me.Interseccion.TabIndex = 5
        Me.Interseccion.Text = "Intersección"
        Me.Interseccion.UseVisualStyleBackColor = True
        '
        'DivisionBtn
        '
        Me.DivisionBtn.Location = New System.Drawing.Point(21, 193)
        Me.DivisionBtn.Name = "DivisionBtn"
        Me.DivisionBtn.Size = New System.Drawing.Size(75, 23)
        Me.DivisionBtn.TabIndex = 6
        Me.DivisionBtn.Text = "División"
        Me.DivisionBtn.UseVisualStyleBackColor = True
        '
        'Renombrar
        '
        Me.Renombrar.Location = New System.Drawing.Point(484, 193)
        Me.Renombrar.Name = "Renombrar"
        Me.Renombrar.Size = New System.Drawing.Size(96, 23)
        Me.Renombrar.TabIndex = 7
        Me.Renombrar.Text = "Renombrar"
        Me.Renombrar.UseVisualStyleBackColor = True
        '
        'Concatenacion
        '
        Me.Concatenacion.Location = New System.Drawing.Point(218, 193)
        Me.Concatenacion.Name = "Concatenacion"
        Me.Concatenacion.Size = New System.Drawing.Size(150, 23)
        Me.Concatenacion.TabIndex = 8
        Me.Concatenacion.Text = "Concatenación"
        Me.Concatenacion.UseVisualStyleBackColor = True
        '
        'Concatenacion_natural
        '
        Me.Concatenacion_natural.Location = New System.Drawing.Point(218, 141)
        Me.Concatenacion_natural.Name = "Concatenacion_natural"
        Me.Concatenacion_natural.Size = New System.Drawing.Size(150, 23)
        Me.Concatenacion_natural.TabIndex = 9
        Me.Concatenacion_natural.Text = "Concatenacion Natural"
        Me.Concatenacion_natural.UseVisualStyleBackColor = True
        '
        'Agregacio
        '
        Me.Agregacio.Location = New System.Drawing.Point(484, 142)
        Me.Agregacio.Name = "Agregacio"
        Me.Agregacio.Size = New System.Drawing.Size(96, 23)
        Me.Agregacio.TabIndex = 10
        Me.Agregacio.Text = "Agregación"
        Me.Agregacio.UseVisualStyleBackColor = True
        '
        'Agrupación
        '
        Me.Agrupación.Location = New System.Drawing.Point(484, 94)
        Me.Agrupación.Name = "Agrupación"
        Me.Agrupación.Size = New System.Drawing.Size(96, 23)
        Me.Agrupación.TabIndex = 11
        Me.Agrupación.Text = "Agrupación"
        Me.Agrupación.UseVisualStyleBackColor = True
        '
        'Conectar
        '
        Me.Conectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Conectar.Location = New System.Drawing.Point(496, 75)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(75, 23)
        Me.Conectar.TabIndex = 12
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tablasPermanentes)
        Me.GroupBox1.Controls.Add(Me.TablasTemporales)
        Me.GroupBox1.Controls.Add(Me.Diferencia_de_Conjuntos_btn)
        Me.GroupBox1.Controls.Add(Me.Seleccion)
        Me.GroupBox1.Controls.Add(Me.Agrupación)
        Me.GroupBox1.Controls.Add(Me.Proyección_btn)
        Me.GroupBox1.Controls.Add(Me.Agregacio)
        Me.GroupBox1.Controls.Add(Me.Unión)
        Me.GroupBox1.Controls.Add(Me.Concatenacion_natural)
        Me.GroupBox1.Controls.Add(Me.Producto_Cartesiano_btn)
        Me.GroupBox1.Controls.Add(Me.Concatenacion)
        Me.GroupBox1.Controls.Add(Me.Interseccion)
        Me.GroupBox1.Controls.Add(Me.Renombrar)
        Me.GroupBox1.Controls.Add(Me.DivisionBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 290)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas"
        '
        'TablasTemporales
        '
        Me.TablasTemporales.Location = New System.Drawing.Point(0, 261)
        Me.TablasTemporales.Name = "TablasTemporales"
        Me.TablasTemporales.Size = New System.Drawing.Size(150, 23)
        Me.TablasTemporales.TabIndex = 12
        Me.TablasTemporales.Text = "Ver tablas temporales"
        Me.TablasTemporales.UseVisualStyleBackColor = True
        '
        'tablasPermanentes
        '
        Me.tablasPermanentes.Location = New System.Drawing.Point(218, 261)
        Me.tablasPermanentes.Name = "tablasPermanentes"
        Me.tablasPermanentes.Size = New System.Drawing.Size(150, 23)
        Me.tablasPermanentes.TabIndex = 13
        Me.tablasPermanentes.Text = "Ver tablas permanentes"
        Me.tablasPermanentes.UseVisualStyleBackColor = True
        '
        'acercaDe
        '
        Me.acercaDe.Location = New System.Drawing.Point(12, 12)
        Me.acercaDe.Name = "acercaDe"
        Me.acercaDe.Size = New System.Drawing.Size(96, 23)
        Me.acercaDe.TabIndex = 14
        Me.acercaDe.Text = "Acerca De"
        Me.acercaDe.UseVisualStyleBackColor = True
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 451)
        Me.Controls.Add(Me.acercaDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Conectar)
        Me.Name = "Bienvenida"
        Me.Text = "Bienvenidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Seleccion As Button
    Friend WithEvents Proyección_btn As Button
    Friend WithEvents Unión As Button
    Friend WithEvents Diferencia_de_Conjuntos_btn As Button
    Friend WithEvents Producto_Cartesiano_btn As Button
    Friend WithEvents Interseccion As Button
    Friend WithEvents DivisionBtn As Button
    Friend WithEvents Renombrar As Button
    Friend WithEvents Concatenacion As Button
    Friend WithEvents Concatenacion_natural As Button
    Friend WithEvents Agregacio As Button
    Friend WithEvents Agrupación As Button
    Friend WithEvents Conectar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tablasPermanentes As Button
    Friend WithEvents TablasTemporales As Button
    Friend WithEvents acercaDe As Button
End Class
