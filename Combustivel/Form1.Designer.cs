namespace Combustivel
{
    partial class Form1
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlPainel = new System.Windows.Forms.Panel();
            this.txtAbastecer = new System.Windows.Forms.TextBox();
            this.lblAbastecer = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.txtEtanol = new System.Windows.Forms.TextBox();
            this.lblEtanol = new System.Windows.Forms.Label();
            this.pnlPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(73, 203);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(338, 203);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnlPainel
            // 
            this.pnlPainel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPainel.Controls.Add(this.txtAbastecer);
            this.pnlPainel.Controls.Add(this.lblAbastecer);
            this.pnlPainel.Location = new System.Drawing.Point(1, 74);
            this.pnlPainel.Name = "pnlPainel";
            this.pnlPainel.Size = new System.Drawing.Size(554, 100);
            this.pnlPainel.TabIndex = 2;
            // 
            // txtAbastecer
            // 
            this.txtAbastecer.Location = new System.Drawing.Point(120, 47);
            this.txtAbastecer.Name = "txtAbastecer";
            this.txtAbastecer.Size = new System.Drawing.Size(229, 20);
            this.txtAbastecer.TabIndex = 8;
            // 
            // lblAbastecer
            // 
            this.lblAbastecer.AutoSize = true;
            this.lblAbastecer.Location = new System.Drawing.Point(194, 31);
            this.lblAbastecer.Name = "lblAbastecer";
            this.lblAbastecer.Size = new System.Drawing.Size(80, 13);
            this.lblAbastecer.TabIndex = 7;
            this.lblAbastecer.Text = "Qual Abastecer";
            this.lblAbastecer.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(24, 22);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(48, 13);
            this.lblGasolina.TabIndex = 3;
            this.lblGasolina.Text = "Gasolina";
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(27, 38);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(100, 20);
            this.txtGasolina.TabIndex = 4;
            // 
            // txtEtanol
            // 
            this.txtEtanol.Location = new System.Drawing.Point(313, 38);
            this.txtEtanol.Name = "txtEtanol";
            this.txtEtanol.Size = new System.Drawing.Size(100, 20);
            this.txtEtanol.TabIndex = 6;
            // 
            // lblEtanol
            // 
            this.lblEtanol.AutoSize = true;
            this.lblEtanol.Location = new System.Drawing.Point(310, 22);
            this.lblEtanol.Name = "lblEtanol";
            this.lblEtanol.Size = new System.Drawing.Size(40, 13);
            this.lblEtanol.TabIndex = 5;
            this.lblEtanol.Text = "Etanol:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 258);
            this.Controls.Add(this.txtEtanol);
            this.Controls.Add(this.lblEtanol);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.pnlPainel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlPainel.ResumeLayout(false);
            this.pnlPainel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlPainel;
        private System.Windows.Forms.TextBox txtAbastecer;
        private System.Windows.Forms.Label lblAbastecer;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.TextBox txtEtanol;
        private System.Windows.Forms.Label lblEtanol;
    }
}

