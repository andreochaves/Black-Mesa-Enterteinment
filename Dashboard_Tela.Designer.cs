namespace Lets_Musics
{
    partial class Dashboard_Tela
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
            this.LabelNomeConta = new System.Windows.Forms.Label();
            this.BtnTorneios = new System.Windows.Forms.Button();
            this.BtnMusics = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnBanda = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.btnAmigos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNomeConta
            // 
            this.LabelNomeConta.Location = new System.Drawing.Point(455, 10);
            this.LabelNomeConta.Name = "LabelNomeConta";
            this.LabelNomeConta.Size = new System.Drawing.Size(100, 25);
            this.LabelNomeConta.TabIndex = 0;
            this.LabelNomeConta.Text = "NomeConta";
            this.LabelNomeConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTorneios
            // 
            this.BtnTorneios.Location = new System.Drawing.Point(220, 255);
            this.BtnTorneios.Name = "BtnTorneios";
            this.BtnTorneios.Size = new System.Drawing.Size(135, 65);
            this.BtnTorneios.TabIndex = 1;
            this.BtnTorneios.Text = "Torneios";
            this.BtnTorneios.UseVisualStyleBackColor = true;
            this.BtnTorneios.Click += new System.EventHandler(this.BtnTorneios_Click);
            // 
            // BtnMusics
            // 
            this.BtnMusics.Location = new System.Drawing.Point(220, 115);
            this.BtnMusics.Name = "BtnMusics";
            this.BtnMusics.Size = new System.Drawing.Size(135, 65);
            this.BtnMusics.TabIndex = 2;
            this.BtnMusics.Text = "Musicas/Playslists";
            this.BtnMusics.UseVisualStyleBackColor = true;
            this.BtnMusics.Click += new System.EventHandler(this.BtnMusics_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Location = new System.Drawing.Point(455, 115);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(100, 25);
            this.BtnConfig.TabIndex = 3;
            this.BtnConfig.Text = "Configurar Conta";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnBanda
            // 
            this.BtnBanda.Location = new System.Drawing.Point(220, 185);
            this.BtnBanda.Name = "BtnBanda";
            this.BtnBanda.Size = new System.Drawing.Size(135, 65);
            this.BtnBanda.TabIndex = 4;
            this.BtnBanda.Text = "Banda";
            this.BtnBanda.UseVisualStyleBackColor = true;
            this.BtnBanda.Click += new System.EventHandler(this.BtnBanda_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(455, 145);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(100, 25);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Deslogar";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.Location = new System.Drawing.Point(455, 40);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(100, 25);
            this.LabelCodigo.TabIndex = 6;
            this.LabelCodigo.Text = "Codigo";
            this.LabelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAmigos
            // 
            this.btnAmigos.Location = new System.Drawing.Point(455, 86);
            this.btnAmigos.Name = "btnAmigos";
            this.btnAmigos.Size = new System.Drawing.Size(100, 23);
            this.btnAmigos.TabIndex = 7;
            this.btnAmigos.Text = "Amigos";
            this.btnAmigos.UseVisualStyleBackColor = true;
            // 
            // Dashboard_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.btnAmigos);
            this.Controls.Add(this.LabelCodigo);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnBanda);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnMusics);
            this.Controls.Add(this.BtnTorneios);
            this.Controls.Add(this.LabelNomeConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard_Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Tela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_Tela_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNomeConta;
        private System.Windows.Forms.Button BtnTorneios;
        private System.Windows.Forms.Button BtnMusics;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnBanda;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Button btnAmigos;
    }
}