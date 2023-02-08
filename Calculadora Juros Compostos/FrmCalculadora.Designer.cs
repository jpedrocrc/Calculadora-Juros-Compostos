namespace Calculadora_Juros_Compostos
{
    partial class FrmCalculadora
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
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.txtValorMensal = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorInvestidoFinal = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.txtValorDeJurosFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(215, 174);
            this.txtValorInicial.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(150, 31);
            this.txtValorInicial.TabIndex = 0;
            this.txtValorInicial.TextChanged += new System.EventHandler(this.txtValorInicial_TextChanged);
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.Location = new System.Drawing.Point(563, 177);
            this.txtValorMensal.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Size = new System.Drawing.Size(150, 31);
            this.txtValorMensal.TabIndex = 1;
            this.txtValorMensal.TextChanged += new System.EventHandler(this.txtValorMensal_TextChanged);
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(215, 239);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(6);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(150, 31);
            this.txtJuros.TabIndex = 2;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(563, 239);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(6);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(150, 31);
            this.txtTempo.TabIndex = 3;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(45, 380);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(325, 81);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ValorMensal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taxa Anual de Juros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Período em anos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -20);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 180);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(736, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calculadora de Juros Compostos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(417, 393);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(278, 56);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Investido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor Final";
            // 
            // txtValorInvestidoFinal
            // 
            this.txtValorInvestidoFinal.Location = new System.Drawing.Point(215, 294);
            this.txtValorInvestidoFinal.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorInvestidoFinal.Name = "txtValorInvestidoFinal";
            this.txtValorInvestidoFinal.ReadOnly = true;
            this.txtValorInvestidoFinal.Size = new System.Drawing.Size(150, 31);
            this.txtValorInvestidoFinal.TabIndex = 13;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(215, 337);
            this.txtValorFinal.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(150, 31);
            this.txtValorFinal.TabIndex = 14;
            // 
            // txtValorDeJurosFinal
            // 
            this.txtValorDeJurosFinal.Location = new System.Drawing.Point(563, 291);
            this.txtValorDeJurosFinal.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorDeJurosFinal.Name = "txtValorDeJurosFinal";
            this.txtValorDeJurosFinal.ReadOnly = true;
            this.txtValorDeJurosFinal.Size = new System.Drawing.Size(150, 31);
            this.txtValorDeJurosFinal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor de Juros";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 497);
            this.Controls.Add(this.txtValorDeJurosFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtValorInvestidoFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.txtValorInicial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.TextBox txtValorMensal;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorInvestidoFinal;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.TextBox txtValorDeJurosFinal;
        private System.Windows.Forms.Label label8;
    }
}

