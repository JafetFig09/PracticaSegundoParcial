namespace PracticaDos
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
            btnLlenar = new Button();
            btnListaPar = new Button();
            btnListaImpar = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            tbSize = new TextBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnLlenar
            // 
            btnLlenar.Location = new Point(28, 70);
            btnLlenar.Name = "btnLlenar";
            btnLlenar.Size = new Size(155, 52);
            btnLlenar.TabIndex = 0;
            btnLlenar.Text = "Generar lista";
            btnLlenar.UseVisualStyleBackColor = true;
            btnLlenar.Click += btnLlenar_Click;
            // 
            // btnListaPar
            // 
            btnListaPar.Location = new Point(538, 60);
            btnListaPar.Name = "btnListaPar";
            btnListaPar.Size = new Size(224, 72);
            btnListaPar.TabIndex = 1;
            btnListaPar.Text = "Lista Par";
            btnListaPar.UseVisualStyleBackColor = true;
            btnListaPar.Click += btnListaPar_Click;
            // 
            // btnListaImpar
            // 
            btnListaImpar.Location = new Point(818, 60);
            btnListaImpar.Name = "btnListaImpar";
            btnListaImpar.Size = new Size(180, 72);
            btnListaImpar.TabIndex = 2;
            btnListaImpar.Text = "Lista Impar";
            btnListaImpar.UseVisualStyleBackColor = true;
            btnListaImpar.Click += btnListaImpar_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(154, 238);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(730, 304);
            listBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 170);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Tamaño Lista:";
            // 
            // tbSize
            // 
            tbSize.Location = new Point(202, 167);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(99, 27);
            tbSize.TabIndex = 5;
            tbSize.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(248, 70);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(160, 52);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Lista";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1046, 567);
            Controls.Add(btnMostrar);
            Controls.Add(tbSize);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(btnListaImpar);
            Controls.Add(btnListaPar);
            Controls.Add(btnLlenar);
            Name = "Form1";
            Text = "Practica Dos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnLlenar;
        private Button btnListaPar;
        private Button btnListaImpar;
        private ListBox listBox2;
        private Label label1;
        private TextBox tbSize;
        private Button btnMostrar;
    }
}