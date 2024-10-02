namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            bSaludo = new Button();
            rButtonSr = new RadioButton();
            rButtonSrta = new RadioButton();
            rButtonSra = new RadioButton();
            lMomentoDia = new Label();
            lTituloSaludo = new Label();
            textBox1 = new TextBox();
            lNombreSaludo = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Mañana", "Tarde", "Noche" });
            comboBox1.Location = new Point(418, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 83);
            label1.Name = "label1";
            label1.Size = new Size(36, 56);
            label1.TabIndex = 1;
            label1.Text = " ";
            label1.Click += label1_Click;
            // 
            // bSaludo
            // 
            bSaludo.Font = new Font("Comic Sans MS", 14F);
            bSaludo.Location = new Point(418, 307);
            bSaludo.Name = "bSaludo";
            bSaludo.Size = new Size(91, 36);
            bSaludo.TabIndex = 2;
            bSaludo.Text = "Saludar";
            bSaludo.UseVisualStyleBackColor = true;
            bSaludo.Click += button1_Click;
            // 
            // rButtonSr
            // 
            rButtonSr.AutoSize = true;
            rButtonSr.Location = new Point(418, 264);
            rButtonSr.Name = "rButtonSr";
            rButtonSr.Size = new Size(35, 19);
            rButtonSr.TabIndex = 3;
            rButtonSr.TabStop = true;
            rButtonSr.Text = "Sr";
            rButtonSr.UseVisualStyleBackColor = true;
            rButtonSr.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rButtonSrta
            // 
            rButtonSrta.AutoSize = true;
            rButtonSrta.Location = new Point(459, 264);
            rButtonSrta.Name = "rButtonSrta";
            rButtonSrta.Size = new Size(45, 19);
            rButtonSrta.TabIndex = 4;
            rButtonSrta.TabStop = true;
            rButtonSrta.Text = "Srta";
            rButtonSrta.UseVisualStyleBackColor = true;
            // 
            // rButtonSra
            // 
            rButtonSra.AutoSize = true;
            rButtonSra.Location = new Point(510, 264);
            rButtonSra.Name = "rButtonSra";
            rButtonSra.Size = new Size(41, 19);
            rButtonSra.TabIndex = 5;
            rButtonSra.TabStop = true;
            rButtonSra.Text = "Sra";
            rButtonSra.UseVisualStyleBackColor = true;
            // 
            // lMomentoDia
            // 
            lMomentoDia.AutoSize = true;
            lMomentoDia.Location = new Point(311, 181);
            lMomentoDia.Name = "lMomentoDia";
            lMomentoDia.Size = new Size(101, 15);
            lMomentoDia.TabIndex = 6;
            lMomentoDia.Text = "Momento del día:";
            lMomentoDia.Click += label2_Click;
            // 
            // lTituloSaludo
            // 
            lTituloSaludo.AutoSize = true;
            lTituloSaludo.Location = new Point(314, 268);
            lTituloSaludo.Name = "lTituloSaludo";
            lTituloSaludo.Size = new Size(98, 15);
            lTituloSaludo.TabIndex = 7;
            lTituloSaludo.Text = "Título del Saludo:";
            lTituloSaludo.Click += label2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lNombreSaludo
            // 
            lNombreSaludo.AutoSize = true;
            lNombreSaludo.Location = new Point(262, 224);
            lNombreSaludo.Name = "lNombreSaludo";
            lNombreSaludo.Size = new Size(150, 15);
            lNombreSaludo.TabIndex = 9;
            lNombreSaludo.Text = "Nombre de a quién saludo:";
            lNombreSaludo.Click += label2_Click_2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lNombreSaludo);
            Controls.Add(textBox1);
            Controls.Add(lTituloSaludo);
            Controls.Add(lMomentoDia);
            Controls.Add(rButtonSra);
            Controls.Add(rButtonSrta);
            Controls.Add(rButtonSr);
            Controls.Add(bSaludo);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Saludo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button bSaludo;
        private RadioButton rButtonSr;
        private RadioButton rButtonSrta;
        private RadioButton rButtonSra;
        private Label lMomentoDia;
        private Label lTituloSaludo;
        private TextBox textBox1;
        private Label lNombreSaludo;
        private Panel panel1;
    }
}
