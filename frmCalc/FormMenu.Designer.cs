namespace frmCalc
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCalculadoras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBotoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRadial = new System.Windows.Forms.ToolStripMenuItem();
            this.tradicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculadoras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCalculadoras
            // 
            this.tsmCalculadoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBotoes,
            this.tsmRadial,
            this.tradicionalToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.tsmCalculadoras.Name = "tsmCalculadoras";
            this.tsmCalculadoras.Size = new System.Drawing.Size(87, 20);
            this.tsmCalculadoras.Text = "Calculadoras";
            // 
            // tsmBotoes
            // 
            this.tsmBotoes.Name = "tsmBotoes";
            this.tsmBotoes.Size = new System.Drawing.Size(152, 22);
            this.tsmBotoes.Text = "Botões";
            this.tsmBotoes.Click += new System.EventHandler(this.tsmBotoes_Click);
            // 
            // tsmRadial
            // 
            this.tsmRadial.Name = "tsmRadial";
            this.tsmRadial.Size = new System.Drawing.Size(152, 22);
            this.tsmRadial.Text = "Radial";
            this.tsmRadial.Click += new System.EventHandler(this.tsmRadial_Click);
            // 
            // tradicionalToolStripMenuItem
            // 
            this.tradicionalToolStripMenuItem.Name = "tradicionalToolStripMenuItem";
            this.tradicionalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tradicionalToolStripMenuItem.Text = "Tradicional";
            this.tradicionalToolStripMenuItem.Click += new System.EventHandler(this.tradicionalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 520);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculadoras;
        private System.Windows.Forms.ToolStripMenuItem tsmBotoes;
        private System.Windows.Forms.ToolStripMenuItem tsmRadial;
        private System.Windows.Forms.ToolStripMenuItem tradicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}