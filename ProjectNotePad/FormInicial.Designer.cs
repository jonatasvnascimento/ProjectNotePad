
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnExportarBlocoDeNotas.Location = new System.Drawing.Point(69, 199);
            this.btnExportarBlocoDeNotas.Name = "btnExportarBlocoDeNotas";
            this.btnExportarBlocoDeNotas.Size = new System.Drawing.Size(468, 117);
            this.btnExportarBlocoDeNotas.TabIndex = 1;
            this.btnExportarBlocoDeNotas.Text = "EXPORTAR BLOCO DE NOTAS";
            this.btnExportarBlocoDeNotas.UseVisualStyleBackColor = true;
            this.btnExportarBlocoDeNotas.Click += new System.EventHandler(this.btnExportarBlocoDeNotas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jonatas";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarBlocoDeNotas);
            this.Controls.Add(this.btnLeituraOffline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicial_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeituraOffline;
        private System.Windows.Forms.Button btnExportarBlocoDeNotas;
        private System.Windows.Forms.Label label1;
    }
}