namespace Circunferencia
{
    partial class Form1
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
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.lblRespArea = new System.Windows.Forms.Label();
            this.lblRespComprimento = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(70, 9);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(37, 17);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(69, 56);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Location = new System.Drawing.Point(16, 97);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(91, 17);
            this.lblComprimento.TabIndex = 2;
            this.lblComprimento.Text = "Comprimento";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(114, 13);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 22);
            this.txtRaio.TabIndex = 3;
            // 
            // lblRespArea
            // 
            this.lblRespArea.AutoSize = true;
            this.lblRespArea.Location = new System.Drawing.Point(114, 56);
            this.lblRespArea.Name = "lblRespArea";
            this.lblRespArea.Size = new System.Drawing.Size(46, 17);
            this.lblRespArea.TabIndex = 4;
            this.lblRespArea.Text = "label4";
            // 
            // lblRespComprimento
            // 
            this.lblRespComprimento.AutoSize = true;
            this.lblRespComprimento.Location = new System.Drawing.Point(114, 97);
            this.lblRespComprimento.Name = "lblRespComprimento";
            this.lblRespComprimento.Size = new System.Drawing.Size(46, 17);
            this.lblRespComprimento.TabIndex = 5;
            this.lblRespComprimento.Text = "label5";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(19, 151);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(117, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 31);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(211, 150);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 31);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 205);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblRespComprimento);
            this.Controls.Add(this.lblRespArea);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblComprimento);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.Text = "Circunferência";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label lblRespArea;
        private System.Windows.Forms.Label lblRespComprimento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
    }
}

