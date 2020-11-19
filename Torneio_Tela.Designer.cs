namespace Lets_Musics
{
    partial class Torneio_Tela
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
            this.btnPart = new System.Windows.Forms.Button();
            this.lbTorneio = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPart
            // 
            this.btnPart.Location = new System.Drawing.Point(283, 194);
            this.btnPart.Name = "btnPart";
            this.btnPart.Size = new System.Drawing.Size(75, 23);
            this.btnPart.TabIndex = 3;
            this.btnPart.Text = "Participar";
            this.btnPart.UseVisualStyleBackColor = true;
            // 
            // lbTorneio
            // 
            this.lbTorneio.FormattingEnabled = true;
            this.lbTorneio.Location = new System.Drawing.Point(72, 39);
            this.lbTorneio.Name = "lbTorneio";
            this.lbTorneio.Size = new System.Drawing.Size(286, 121);
            this.lbTorneio.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 225);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Torneio_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 258);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPart);
            this.Controls.Add(this.lbTorneio);
            this.Name = "Torneio_Tela";
            this.Text = "Torneio_Tela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPart;
        private System.Windows.Forms.ListBox lbTorneio;
        private System.Windows.Forms.Button btnVoltar;
    }
}