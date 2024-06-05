namespace Administracion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            NombreUsu = new TextBox();
            button1 = new Button();
            Password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 547);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += Inicio_Load;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(NombreUsu);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(Password);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(212, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 251);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // NombreUsu
            // 
            NombreUsu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            NombreUsu.Location = new Point(87, 72);
            NombreUsu.Name = "NombreUsu";
            NombreUsu.Size = new Size(215, 23);
            NombreUsu.TabIndex = 11;
            NombreUsu.TextChanged += NombreUsu_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(150, 204);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 10;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Password.Location = new Point(87, 147);
            Password.Name = "Password";
            Password.Size = new Size(215, 23);
            Password.TabIndex = 9;
            Password.TextChanged += Password_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(87, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(87, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre de Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.DeliexpresslogoJPG;
            pictureBox1.Location = new Point(307, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Deliexpress";
            Load += Inicio_Load;
            SizeChanged += Inicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox Password;
        private Label label2;
        private Label label1;
        private TextBox NombreUsu;
    }
}