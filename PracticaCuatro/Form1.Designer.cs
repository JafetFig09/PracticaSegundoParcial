namespace PracticaCuatro
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
            btnAgregarProducto = new Button();
            btnMostrarProducto = new Button();
            btnComprarProductos = new Button();
            btnMostrarOrden = new Button();
            panel1 = new Panel();
            label3 = new Label();
            tbPrecio = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            agregar = new Button();
            cancelar = new Button();
            listBox1 = new ListBox();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.Location = new Point(86, 41);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(140, 50);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnMostrarProducto
            // 
            btnMostrarProducto.Cursor = Cursors.Hand;
            btnMostrarProducto.Location = new Point(262, 41);
            btnMostrarProducto.Name = "btnMostrarProducto";
            btnMostrarProducto.Size = new Size(144, 50);
            btnMostrarProducto.TabIndex = 1;
            btnMostrarProducto.Text = "Mostrar Productos";
            btnMostrarProducto.UseVisualStyleBackColor = true;
            btnMostrarProducto.Click += btnMostrarProducto_Click;
            // 
            // btnComprarProductos
            // 
            btnComprarProductos.Cursor = Cursors.Hand;
            btnComprarProductos.Location = new Point(447, 43);
            btnComprarProductos.Name = "btnComprarProductos";
            btnComprarProductos.Size = new Size(157, 48);
            btnComprarProductos.TabIndex = 2;
            btnComprarProductos.Text = "Comprar Producto";
            btnComprarProductos.UseVisualStyleBackColor = true;
            btnComprarProductos.Click += btnComprarProductos_Click;
            // 
            // btnMostrarOrden
            // 
            btnMostrarOrden.Cursor = Cursors.Hand;
            btnMostrarOrden.Location = new Point(690, 43);
            btnMostrarOrden.Name = "btnMostrarOrden";
            btnMostrarOrden.Size = new Size(163, 48);
            btnMostrarOrden.TabIndex = 3;
            btnMostrarOrden.Text = "Productos Comprados";
            btnMostrarOrden.UseVisualStyleBackColor = true;
            btnMostrarOrden.Click += btnMostrarOrden_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPrecio);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregar);
            panel1.Controls.Add(cancelar);
            panel1.Location = new Point(431, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 394);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 32);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 6;
            label3.Text = "Agregar producto";
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(151, 176);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(115, 27);
            tbPrecio.TabIndex = 5;
            tbPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(151, 119);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(110, 27);
            tbNombre.TabIndex = 4;
            tbNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 170);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 122);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // agregar
            // 
            agregar.Cursor = Cursors.Hand;
            agregar.Location = new Point(200, 335);
            agregar.Name = "agregar";
            agregar.Size = new Size(115, 32);
            agregar.TabIndex = 1;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // cancelar
            // 
            cancelar.Cursor = Cursors.Hand;
            cancelar.Location = new Point(50, 335);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(94, 34);
            cancelar.TabIndex = 0;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(192, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(764, 464);
            listBox1.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(919, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 48);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1256, 602);
            Controls.Add(btnEliminar);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(btnMostrarOrden);
            Controls.Add(btnComprarProductos);
            Controls.Add(btnMostrarProducto);
            Controls.Add(btnAgregarProducto);
            Name = "Form1";
            Text = "Practica Cuatro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProducto;
        private Button btnMostrarProducto;
        private Button btnComprarProductos;
        private Button btnMostrarOrden;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button agregar;
        private Button cancelar;
        private Label label3;
        private TextBox tbPrecio;
        private TextBox tbNombre;
        private ListBox listBox1;
        private Button btnEliminar;
    }
}