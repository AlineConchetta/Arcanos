namespace Arcanos
{
    partial class telaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Comeco = new System.Windows.Forms.Button();
            this.textBoxApresentacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arcanos.Properties.Resources.arcanos_sem_fundo__login_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(43, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Comeco
            // 
            this.Comeco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.Comeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comeco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Comeco.Location = new System.Drawing.Point(108, 417);
            this.Comeco.Name = "Comeco";
            this.Comeco.Size = new System.Drawing.Size(167, 53);
            this.Comeco.TabIndex = 1;
            this.Comeco.Text = "Clique aqui para começar";
            this.Comeco.UseVisualStyleBackColor = false;
            // 
            // textBoxApresentacao
            // 
            this.textBoxApresentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApresentacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.textBoxApresentacao.Location = new System.Drawing.Point(50, 234);
            this.textBoxApresentacao.Multiline = true;
            this.textBoxApresentacao.Name = "textBoxApresentacao";
            this.textBoxApresentacao.Size = new System.Drawing.Size(257, 132);
            this.textBoxApresentacao.TabIndex = 2;
            this.textBoxApresentacao.Text = resources.GetString("textBoxApresentacao.Text");
            this.textBoxApresentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcanos.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.textBoxApresentacao);
            this.Controls.Add(this.Comeco);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "telaInicio";
            this.Text = "telaInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Comeco;
        private System.Windows.Forms.TextBox textBoxApresentacao;
    }
}