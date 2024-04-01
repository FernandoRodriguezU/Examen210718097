namespace SistemasVentas.VISTA.inicio
{
    partial class In
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In));
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(411, 72);
            label1.Name = "label1";
            label1.Size = new Size(218, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 140);
            label2.Name = "label2";
            label2.Size = new Size(267, 25);
            label2.TabIndex = 1;
            label2.Text = "Haz clic en lo correspondiente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(195, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Más";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(525, 360);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Más";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(885, 360);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(48, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Más";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(138, 313);
            button1.Name = "button1";
            button1.Size = new Size(105, 41);
            button1.TabIndex = 8;
            button1.Text = "Venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(468, 313);
            button2.Name = "button2";
            button2.Size = new Size(105, 41);
            button2.TabIndex = 9;
            button2.Text = "Inventario";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(828, 313);
            button3.Name = "button3";
            button3.Size = new Size(105, 41);
            button3.TabIndex = 10;
            button3.Text = "Gerente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(817, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(138, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 601);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "In";
            Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}