namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 79);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 182);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBREUSER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 284);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 284);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 5;
            textBox3.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(206, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 382);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 329);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 337);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "FECHAREG";
            // 
            // button3
            // 
            button3.Location = new Point(581, 119);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Seleccionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button3;
    }
}