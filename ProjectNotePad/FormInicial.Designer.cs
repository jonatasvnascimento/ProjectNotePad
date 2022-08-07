
namespace ProjectNotePad
{
    partial class FormInicial
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
            this.btnLeituraOffline = new System.Windows.Forms.Button();
            this.btnExportarBlocoDeNotas = new System.Windows.Forms.Button();
            this.btnExportarAntigoOfflineMod05 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeituraOffline
            // 
            this.btnLeituraOffline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeituraOffline.Location = new System.Drawing.Point(69, 52);
            this.btnLeituraOffline.Name = "btnLeituraOffline";
            this.btnLeituraOffline.Size = new System.Drawing.Size(468, 117);
            this.btnLeituraOffline.TabIndex = 0;
            this.btnLeituraOffline.Text = "LEITURA OFFLINE";
            this.btnLeituraOffline.UseVisualStyleBackColor = true;
            this.btnLeituraOffline.Click += new System.EventHandler(this.btnLeituraOffline_Click);
            // 
            // btnExportarBlocoDeNotas
            // 
            this.btnExportarBlocoDeNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarBlocoDeNotas.Location = new System.Drawing.Point(69, 226);
            this.btnExportarBlocoDeNotas.Name = "btnExportarBlocoDeNotas";
            this.btnExportarBlocoDeNotas.Size = new System.Drawing.Size(468, 117);
            this.btnExportarBlocoDeNotas.TabIndex = 1;
            this.btnExportarBlocoDeNotas.Text = "EXPORTAR BLOCO DE NOTAS";
            this.btnExportarBlocoDeNotas.UseVisualStyleBackColor = true;
            this.btnExportarBlocoDeNotas.Click += new System.EventHandler(this.btnExportarBlocoDeNotas_Click);
            // 
            // btnExportarAntigoOfflineMod05
            // 
            this.btnExportarAntigoOfflineMod05.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarAntigoOfflineMod05.Location = new System.Drawing.Point(69, 405);
            this.btnExportarAntigoOfflineMod05.Name = "btnExportarAntigoOfflineMod05";
            this.btnExportarAntigoOfflineMod05.Size = new System.Drawing.Size(468, 117);
            this.btnExportarAntigoOfflineMod05.TabIndex = 2;
            this.btnExportarAntigoOfflineMod05.Text = "EXPORTAR ANTIGO OFFLINE MOD05";
            this.btnExportarAntigoOfflineMod05.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(570, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 585);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExportarAntigoOfflineMod05);
            this.Controls.Add(this.btnExportarBlocoDeNotas);
            this.Controls.Add(this.btnLeituraOffline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeituraOffline;
        private System.Windows.Forms.Button btnExportarBlocoDeNotas;
        private System.Windows.Forms.Button btnExportarAntigoOfflineMod05;
        private System.Windows.Forms.Button btnSair;
    }
}