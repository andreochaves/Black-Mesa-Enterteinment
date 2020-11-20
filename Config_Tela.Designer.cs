namespace Lets_Musics
{
    partial class Config_Tela
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
            this.btnMSenha = new System.Windows.Forms.Button();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtSAtual = new System.Windows.Forms.TextBox();
            this.txtNSenha = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnMSenha
            // 
            this.btnMSenha.Location = new System.Drawing.Point(322, 22);
            this.btnMSenha.Name = "btnMSenha";
            this.btnMSenha.Size = new System.Drawing.Size(66, 63);
            this.btnMSenha.TabIndex = 0;
            this.btnMSenha.Text = "Mudar Senha";
            this.btnMSenha.UseVisualStyleBackColor = true;
            this.btnMSenha.Click += new System.EventHandler(this.btnMSenha_Click);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(226, 183);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(66, 47);
            this.btnEscolha.TabIndex = 1;
            this.btnEscolha.Text = "Escolher Pasta";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 223);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtSAtual
            // 
            this.txtSAtual.Location = new System.Drawing.Point(206, 22);
            this.txtSAtual.Name = "txtSAtual";
            this.txtSAtual.Size = new System.Drawing.Size(100, 20);
            this.txtSAtual.TabIndex = 6;
            // 
            // txtNSenha
            // 
            this.txtNSenha.Location = new System.Drawing.Point(206, 65);
            this.txtNSenha.Name = "txtNSenha";
            this.txtNSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNSenha.TabIndex = 7;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(162, 157);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(175, 20);
            this.txtCaminho.TabIndex = 8;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(343, 155);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(75, 23);
            this.btnProc.TabIndex = 10;
            this.btnProc.Text = "Procurar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Senha Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha Nova";
            // 
            // Config_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.txtNSenha);
            this.Controls.Add(this.txtSAtual);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.btnMSenha);
            this.Name = "Config_Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config_Tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMSenha;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtSAtual;
        private System.Windows.Forms.TextBox txtNSenha;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}