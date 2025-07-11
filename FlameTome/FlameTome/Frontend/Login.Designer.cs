﻿namespace FlameTome.Frontend
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            btn_autenticar = new Button();
            txt_contraseña = new TextBox();
            txt_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_autenticar
            // 
            btn_autenticar.BackColor = Color.Orange;
            btn_autenticar.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_autenticar.Location = new Point(197, 297);
            btn_autenticar.Name = "btn_autenticar";
            btn_autenticar.Size = new Size(144, 45);
            btn_autenticar.TabIndex = 1;
            btn_autenticar.Text = "Ingresar";
            btn_autenticar.UseVisualStyleBackColor = false;
            btn_autenticar.Click += btn_autenticar_Click;
            // 
            // txt_contraseña
            // 
            txt_contraseña.ImeMode = ImeMode.NoControl;
            txt_contraseña.Location = new Point(139, 194);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.PasswordChar = '*';
            txt_contraseña.PlaceholderText = "Ingresar contraseña...";
            txt_contraseña.Size = new Size(253, 23);
            txt_contraseña.TabIndex = 2;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(139, 122);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Ingresar usuario...";
            txt_usuario.Size = new Size(253, 23);
            txt_usuario.TabIndex = 3;
            txt_usuario.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(139, 88);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(139, 163);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(139, 239);
            label3.Name = "label3";
            label3.Size = new Size(441, 19);
            label3.TabIndex = 6;
            label3.Text = "Usuario o contraseña incorrectos. Por favor, intenta nuevamente.";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.OrangeRed;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(txt_contraseña);
            panel1.Controls.Add(btn_autenticar);
            panel1.Location = new Point(780, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 398);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1470, 636);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "FlameTome";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_autenticar;
        private TextBox txt_contraseña;
        private TextBox txt_usuario;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}