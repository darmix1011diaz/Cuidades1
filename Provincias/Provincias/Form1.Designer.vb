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
        Me.gbx_provincias = New System.Windows.Forms.GroupBox()
        Me.lv_provincias = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_mayor = New System.Windows.Forms.Button()
        Me.btn_menor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_poblacion = New System.Windows.Forms.TextBox()
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbx_provincias.SuspendLayout()
        Me.gbx_agregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_provincias
        '
        Me.gbx_provincias.BackColor = System.Drawing.Color.Transparent
        Me.gbx_provincias.Controls.Add(Me.lv_provincias)
        Me.gbx_provincias.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_provincias.ForeColor = System.Drawing.Color.White
        Me.gbx_provincias.Location = New System.Drawing.Point(26, 321)
        Me.gbx_provincias.Name = "gbx_provincias"
        Me.gbx_provincias.Size = New System.Drawing.Size(511, 174)
        Me.gbx_provincias.TabIndex = 4
        Me.gbx_provincias.TabStop = False
        '
        'lv_provincias
        '
        Me.lv_provincias.FullRowSelect = True
        Me.lv_provincias.GridLines = True
        Me.lv_provincias.HideSelection = False
        Me.lv_provincias.Location = New System.Drawing.Point(57, 21)
        Me.lv_provincias.Name = "lv_provincias"
        Me.lv_provincias.Size = New System.Drawing.Size(381, 147)
        Me.lv_provincias.TabIndex = 5
        Me.lv_provincias.UseCompatibleStateImageBehavior = False
        Me.lv_provincias.View = System.Windows.Forms.View.List
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SISTEMA DE PROVINCIAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CODIGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROVINCIA"
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(151, 30)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(147, 31)
        Me.txt_provincia.TabIndex = 2
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(151, 74)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(147, 31)
        Me.txt_codigo.TabIndex = 3
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.LightGray
        Me.btn_agregar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(354, 74)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(111, 38)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_mayor
        '
        Me.btn_mayor.BackColor = System.Drawing.Color.LightGray
        Me.btn_mayor.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mayor.ForeColor = System.Drawing.Color.Black
        Me.btn_mayor.Location = New System.Drawing.Point(354, 30)
        Me.btn_mayor.Name = "btn_mayor"
        Me.btn_mayor.Size = New System.Drawing.Size(111, 38)
        Me.btn_mayor.TabIndex = 5
        Me.btn_mayor.Text = "MAYOR"
        Me.btn_mayor.UseVisualStyleBackColor = False
        '
        'btn_menor
        '
        Me.btn_menor.BackColor = System.Drawing.Color.LightGray
        Me.btn_menor.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menor.ForeColor = System.Drawing.Color.Black
        Me.btn_menor.Location = New System.Drawing.Point(354, 117)
        Me.btn_menor.Name = "btn_menor"
        Me.btn_menor.Size = New System.Drawing.Size(111, 38)
        Me.btn_menor.TabIndex = 6
        Me.btn_menor.Text = "MENOR"
        Me.btn_menor.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "POBLACION"
        '
        'txt_poblacion
        '
        Me.txt_poblacion.Location = New System.Drawing.Point(151, 118)
        Me.txt_poblacion.Name = "txt_poblacion"
        Me.txt_poblacion.Size = New System.Drawing.Size(147, 31)
        Me.txt_poblacion.TabIndex = 8
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.Button2)
        Me.gbx_agregar.Controls.Add(Me.Button1)
        Me.gbx_agregar.Controls.Add(Me.txt_poblacion)
        Me.gbx_agregar.Controls.Add(Me.Label3)
        Me.gbx_agregar.Controls.Add(Me.btn_menor)
        Me.gbx_agregar.Controls.Add(Me.btn_mayor)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Controls.Add(Me.txt_codigo)
        Me.gbx_agregar.Controls.Add(Me.txt_provincia)
        Me.gbx_agregar.Controls.Add(Me.Label1)
        Me.gbx_agregar.Controls.Add(Me.Label2)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(26, 55)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Size = New System.Drawing.Size(511, 233)
        Me.gbx_agregar.TabIndex = 3
        Me.gbx_agregar.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(272, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(151, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Provincias.My.Resources.Resources._222453_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(576, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbx_provincias)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbx_provincias.ResumeLayout(False)
        Me.gbx_agregar.ResumeLayout(False)
        Me.gbx_agregar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_provincias As GroupBox
    Friend WithEvents lv_provincias As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_provincia As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_mayor As Button
    Friend WithEvents btn_menor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_poblacion As TextBox
    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
