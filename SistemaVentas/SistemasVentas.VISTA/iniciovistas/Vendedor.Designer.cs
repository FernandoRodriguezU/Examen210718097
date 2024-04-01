namespace SistemasVentas.VISTA.inicio
{
    partial class Vendedor
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Size = new Size(349, 50);
            label1.TabIndex = 1;
            label1.Text = " Vendedor Persona";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(96, 369);
            button2.Name = "button2";
            button2.Size = new Size(98, 39);
            button2.TabIndex = 6;
            button2.Text = " Listar  Persona";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(365, 369);
            button1.Name = "button1";
            button1.Size = new Size(98, 39);
            button1.TabIndex = 7;
            button1.Text = "Crear Persona";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(622, 369);
            button3.Name = "button3";
            button3.Size = new Size(98, 39);
            button3.TabIndex = 8;
            button3.Text = "Editar Persona";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(176, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(504, 249);
            dataGridView1.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Blue;
            button4.FlatAppearance.MouseOverBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(719, 12);
            button4.Name = "button4";
            button4.Size = new Size(69, 31);
            button4.TabIndex = 10;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(701, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 100);
            panel1.TabIndex = 11;
            // 
            // Vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Vendedor";
            Text = "Vendedor";
            Load += Vendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Panel panel1;
    }
}