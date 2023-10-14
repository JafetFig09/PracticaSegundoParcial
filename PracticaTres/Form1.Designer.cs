namespace PracticaTres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarAlumno = new Button();
            btnAlumnosReprobados = new Button();
            btnAlumnosAprobados = new Button();
            panel1 = new Panel();
            btnAgregar = new Button();
            btnCancelar = new Button();
            tbCalificacion = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnMostrar = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Cursor = Cursors.Hand;
            btnAgregarAlumno.Location = new Point(30, 35);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(189, 48);
            btnAgregarAlumno.TabIndex = 0;
            btnAgregarAlumno.Text = "Agregar";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // btnAlumnosReprobados
            // 
            btnAlumnosReprobados.Cursor = Cursors.Hand;
            btnAlumnosReprobados.Location = new Point(877, 37);
            btnAlumnosReprobados.Name = "btnAlumnosReprobados";
            btnAlumnosReprobados.Size = new Size(166, 47);
            btnAlumnosReprobados.TabIndex = 1;
            btnAlumnosReprobados.Text = "Reprobados";
            btnAlumnosReprobados.UseVisualStyleBackColor = true;
            btnAlumnosReprobados.Click += btnAlumnosReprobados_Click;
            // 
            // btnAlumnosAprobados
            // 
            btnAlumnosAprobados.Cursor = Cursors.Hand;
            btnAlumnosAprobados.Location = new Point(557, 37);
            btnAlumnosAprobados.Name = "btnAlumnosAprobados";
            btnAlumnosAprobados.Size = new Size(207, 46);
            btnAlumnosAprobados.TabIndex = 2;
            btnAlumnosAprobados.Text = "Aprobados";
            btnAlumnosAprobados.UseVisualStyleBackColor = true;
            btnAlumnosAprobados.Click += btnAlumnosAprobados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(tbCalificacion);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(415, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 369);
            panel1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(179, 290);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 36);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(33, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbCalificacion
            // 
            tbCalificacion.Location = new Point(142, 166);
            tbCalificacion.Name = "tbCalificacion";
            tbCalificacion.Size = new Size(104, 27);
            tbCalificacion.TabIndex = 4;
            tbCalificacion.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(131, 96);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(106, 27);
            tbNombre.TabIndex = 3;
            tbNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 169);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Calificacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Alumno";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(292, 37);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(161, 46);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar Alumnos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(314, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(586, 404);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1125, 553);
            Controls.Add(listBox1);
            Controls.Add(btnMostrar);
            Controls.Add(panel1);
            Controls.Add(btnAlumnosAprobados);
            Controls.Add(btnAlumnosReprobados);
            Controls.Add(btnAgregarAlumno);
            Name = "Form1";
            Text = "Practica Tres";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarAlumno;
        private Button btnAlumnosReprobados;
        private Button btnAlumnosAprobados;
        private Panel panel1;
        private TextBox tbCalificacion;
        private TextBox tbNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnMostrar;
        private ListBox listBox1;
    }
}