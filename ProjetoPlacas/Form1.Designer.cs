namespace ProjetoPlacas
{
    partial class FrmRodizio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFinalPlaca = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFinalPlaca
            // 
            this.txtFinalPlaca.Location = new System.Drawing.Point(301, 64);
            this.txtFinalPlaca.Name = "txtFinalPlaca";
            this.txtFinalPlaca.Size = new System.Drawing.Size(95, 38);
            this.txtFinalPlaca.TabIndex = 0;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(423, 64);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(190, 61);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(167, 152);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(24, 31);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Final da Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horário: 7h às 10h e \r\n               17h às 20h";
            // 
            // FrmRodizio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtFinalPlaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmRodizio";
            this.Text = "Rodizio de Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinalPlaca;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

