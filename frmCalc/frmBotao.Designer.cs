namespace frmCalc
{
    partial class frmBotao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotao));
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnComparacao = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.BackColor = System.Drawing.Color.Aquamarine;
            this.lblPrimeiroNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(117, 36);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(125, 30);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Primeiro Número";
            this.lblPrimeiroNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(117, 164);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(123, 20);
            this.txtPrimeiroNumero.TabIndex = 1;
            this.txtPrimeiroNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrimeiroNumero.TextChanged += new System.EventHandler(this.txtPrimeiroNumero_TextChanged);
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.BackColor = System.Drawing.Color.Aquamarine;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(117, 117);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 30);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Segundo Número";
            this.lblSegundoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(117, 85);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(123, 20);
            this.txtSegundoNumero.TabIndex = 3;
            this.txtSegundoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSegundoNumero.TextChanged += new System.EventHandler(this.txtSegundoNumero_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Aquamarine;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(105, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(147, 31);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(62, 258);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(107, 29);
            this.btnAdicao.TabIndex = 5;
            this.btnAdicao.Text = "&ADIÇÃO";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(188, 258);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(106, 29);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = "&SUBTRAÇÃO";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(62, 293);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(107, 28);
            this.btnMultiplicacao.TabIndex = 7;
            this.btnMultiplicacao.Text = "&MULTIPLICAÇÃO";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(188, 292);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(106, 29);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "&DIVISÃO";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnComparacao
            // 
            this.btnComparacao.Location = new System.Drawing.Point(62, 327);
            this.btnComparacao.Name = "btnComparacao";
            this.btnComparacao.Size = new System.Drawing.Size(107, 28);
            this.btnComparacao.TabIndex = 9;
            this.btnComparacao.Text = "&COMPARAÇÃO";
            this.btnComparacao.UseVisualStyleBackColor = true;
            this.btnComparacao.Click += new System.EventHandler(this.btnComparacao_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Location = new System.Drawing.Point(188, 326);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(106, 29);
            this.btnParImpar.TabIndex = 10;
            this.btnParImpar.Text = "&PAR OU IMPAR";
            this.btnParImpar.UseVisualStyleBackColor = true;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(264, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 28);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmBotao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 372);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.btnComparacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txtPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Name = "frmBotao";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnComparacao;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

