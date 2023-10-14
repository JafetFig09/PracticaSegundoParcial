namespace PracticaUno
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            btnMostrarEliminados = new Button();
            btnRetirar = new Button();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnEliminarCantidad = new Button();
            tbCantidad = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cantidad, Precio });
            dataGridView1.Location = new Point(306, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(426, 265);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio Unitario";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(108, 68);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(306, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(501, 70);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(148, 38);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Productos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnMostrarEliminados
            // 
            btnMostrarEliminados.Location = new Point(699, 70);
            btnMostrarEliminados.Name = "btnMostrarEliminados";
            btnMostrarEliminados.Size = new Size(168, 39);
            btnMostrarEliminados.TabIndex = 4;
            btnMostrarEliminados.Text = "Productos Eliminados";
            btnMostrarEliminados.UseVisualStyleBackColor = true;
            btnMostrarEliminados.Click += btnMostrarEliminados_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(926, 70);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(152, 42);
            btnRetirar.TabIndex = 5;
            btnRetirar.Text = "Retirar stock";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnEliminarCantidad);
            panel1.Controls.Add(tbCantidad);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(368, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 386);
            panel1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(41, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminarCantidad
            // 
            btnEliminarCantidad.Location = new Point(167, 300);
            btnEliminarCantidad.Name = "btnEliminarCantidad";
            btnEliminarCantidad.Size = new Size(110, 32);
            btnEliminarCantidad.TabIndex = 4;
            btnEliminarCantidad.Text = "Eliminar";
            btnEliminarCantidad.UseVisualStyleBackColor = true;
            btnEliminarCantidad.Click += btnEliminarCantidad_Click;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(167, 176);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(114, 27);
            tbCantidad.TabIndex = 3;
            tbCantidad.TextAlign = HorizontalAlignment.Right;
            tbCantidad.TextChanged += tbCantidad_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(167, 109);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(122, 27);
            tbNombre.TabIndex = 2;
            tbNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 176);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad a retirar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 109);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1163, 709);
            Controls.Add(panel1);
            Controls.Add(btnRetirar);
            Controls.Add(btnMostrarEliminados);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "PracticaUno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Button btnMostrarEliminados;
        private Button btnRetirar;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox tbCantidad;
        private TextBox tbNombre;
        private Button btnEliminarCantidad;
        private Button btnCancelar;
    }
}