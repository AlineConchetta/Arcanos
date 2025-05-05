namespace Arcanos
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelCadastrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Location = new System.Drawing.Point(34, 232);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSenha.Location = new System.Drawing.Point(34, 305);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 20);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(38, 255);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(312, 20);
            this.textUsuario.TabIndex = 2;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(38, 328);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(312, 20);
            this.textSenha.TabIndex = 3;
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.buttonEntrar.Location = new System.Drawing.Point(150, 373);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(74, 30);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelCadastrar
            // 
            this.labelCadastrar.AutoSize = true;
            this.labelCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.labelCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCadastrar.Location = new System.Drawing.Point(144, 431);
            this.labelCadastrar.Name = "labelCadastrar";
            this.labelCadastrar.Size = new System.Drawing.Size(89, 18);
            this.labelCadastrar.TabIndex = 5;
            this.labelCadastrar.Text = "Cadastre-se";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arcanos.Properties.Resources.arcanos_sem_fundo__login_1;
            this.pictureBox1.Location = new System.Drawing.Point(102, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 147);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.BackgroundImage = global::Arcanos.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCadastrar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}