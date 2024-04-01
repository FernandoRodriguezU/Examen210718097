namespace SistemasVentas.VISTA.login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            pass = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 76);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(744, 12);
            button1.Name = "button1";
            button1.Size = new Size(53, 34);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(172, 281);
            user.Name = "user";
            user.Size = new Size(415, 20);
            user.TabIndex = 2;
            user.Text = "Ingrese su Usuario";
            user.TextAlign = HorizontalAlignment.Center;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(172, 323);
            pass.Name = "pass";
            pass.Size = new Size(415, 20);
            pass.TabIndex = 3;
            pass.Text = "Ingrese su Contraseña";
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(520, 349);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(198, 374);
            button2.Name = "button2";
            button2.Size = new Size(98, 39);
            button2.TabIndex = 5;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(448, 374);
            button3.Name = "button3";
            button3.Size = new Size(98, 39);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 79);
            label1.Name = "label1";
            label1.Size = new Size(223, 42);
            label1.TabIndex = 7;
            label1.Text = "Bienvenidos";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox pass;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}