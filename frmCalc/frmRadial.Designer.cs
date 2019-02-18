namespace frmCalc
{
    partial class frmRadial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadial));
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbComparacao = new System.Windows.Forms.RadioButton();
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.btCalcular = new System.Windows.Forms.Button();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.BackColor = System.Drawing.Color.Pink;
            this.rdbSubtracao.Location = new System.Drawing.Point(19, 81);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(101, 22);
            this.rdbSubtracao.TabIndex = 1;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "SUBTRAÇÃO";
            this.rdbSubtracao.UseVisualStyleBackColor = false;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.BackColor = System.Drawing.Color.Pink;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(137, 53);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(125, 22);
            this.rdbMultiplicacao.TabIndex = 2;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "MULTIPLICAÇÃO";
            this.rdbMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.BackColor = System.Drawing.Color.Pink;
            this.rdbDivisao.Location = new System.Drawing.Point(19, 53);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(78, 22);
            this.rdbDivisao.TabIndex = 3;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "DIVISÃO";
            this.rdbDivisao.UseVisualStyleBackColor = false;
            // 
            // rdbComparacao
            // 
            this.rdbComparacao.AutoSize = true;
            this.rdbComparacao.BackColor = System.Drawing.Color.Pink;
            this.rdbComparacao.Location = new System.Drawing.Point(137, 25);
            this.rdbComparacao.Name = "rdbComparacao";
            this.rdbComparacao.Size = new System.Drawing.Size(116, 22);
            this.rdbComparacao.TabIndex = 4;
            this.rdbComparacao.TabStop = true;
            this.rdbComparacao.Text = "COMPARAÇÃO";
            this.rdbComparacao.UseVisualStyleBackColor = false;
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.BackColor = System.Drawing.Color.Aquamarine;
            this.lblPrimeiroNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(117, 36);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(125, 30);
            this.lblPrimeiroNumero.TabIndex = 6;
            this.lblPrimeiroNumero.Text = "Primeiro Número";
            this.lblPrimeiroNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(117, 85);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(123, 20);
            this.txtPrimeiroNumero.TabIndex = 7;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.BackColor = System.Drawing.Color.Aquamarine;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(117, 117);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 30);
            this.lblSegundoNumero.TabIndex = 8;
            this.lblSegundoNumero.Text = "Segundo Número";
            this.lblSegundoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(117, 164);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(123, 20);
            this.txtSegundoNumero.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Aquamarine;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(85, 195);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(191, 31);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado: ";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.BackColor = System.Drawing.Color.Pink;
            this.rdbAdicao.Location = new System.Drawing.Point(19, 25);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(75, 22);
            this.rdbAdicao.TabIndex = 11;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "ADIÇÃO";
            this.rdbAdicao.UseVisualStyleBackColor = false;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Aquamarine;
            this.btCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCalcular.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(120, 345);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(124, 22);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.BackColor = System.Drawing.Color.Transparent;
            this.gbOperacoes.Controls.Add(this.btnLimpar);
            this.gbOperacoes.Controls.Add(this.rdbSubtracao);
            this.gbOperacoes.Controls.Add(this.rdbAdicao);
            this.gbOperacoes.Controls.Add(this.rdbMultiplicacao);
            this.gbOperacoes.Controls.Add(this.rdbDivisao);
            this.gbOperacoes.Controls.Add(this.rdbComparacao);
            this.gbOperacoes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes.Location = new System.Drawing.Point(46, 229);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(274, 110);
            this.gbOperacoes.TabIndex = 13;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Pink;
            this.btnLimpar.Location = new System.Drawing.Point(137, 79);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 24);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmRadial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 372);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txtPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Name = "frmRadial";
            this.Text = "Calculadora Radial";
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbComparacao;
        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.Button btnLimpar;
    }
}