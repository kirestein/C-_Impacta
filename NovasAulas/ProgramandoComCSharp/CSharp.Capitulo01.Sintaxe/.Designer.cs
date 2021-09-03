
namespace CSharp.Capitulo01.Sintaxe
{
    partial class VariaveisForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduzidasToolStripMenuItem,
            this.aritmeticasToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(951, 516);
            this.listBox1.TabIndex = 1;
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somaToolStripMenuItem,
            this.subtracaoToolStripMenuItem,
            this.multiplicacaoToolStripMenuItem,
            this.divisaoToolStripMenuItem,
            this.restoToolStripMenuItem});
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aritmeticasToolStripMenuItem.Text = "&Aritmeticas";
            // 
            // somaToolStripMenuItem
            // 
            this.somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            this.somaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.somaToolStripMenuItem.Text = "&Soma";
            this.somaToolStripMenuItem.Click += new System.EventHandler(this.somaToolStripMenuItem_Click);
            // 
            // subtracaoToolStripMenuItem
            // 
            this.subtracaoToolStripMenuItem.Name = "subtracaoToolStripMenuItem";
            this.subtracaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.subtracaoToolStripMenuItem.Text = "&Subtracao";
            this.subtracaoToolStripMenuItem.Click += new System.EventHandler(this.subtracaoToolStripMenuItem_Click);
            // 
            // multiplicacaoToolStripMenuItem
            // 
            this.multiplicacaoToolStripMenuItem.Name = "multiplicacaoToolStripMenuItem";
            this.multiplicacaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.multiplicacaoToolStripMenuItem.Text = "&Multiplicacao";
            this.multiplicacaoToolStripMenuItem.Click += new System.EventHandler(this.multiplicacaoToolStripMenuItem_Click);
            // 
            // divisaoToolStripMenuItem
            // 
            this.divisaoToolStripMenuItem.Name = "divisaoToolStripMenuItem";
            this.divisaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.divisaoToolStripMenuItem.Text = "&Divisao";
            this.divisaoToolStripMenuItem.Click += new System.EventHandler(this.divisaoToolStripMenuItem_Click);
            // 
            // restoToolStripMenuItem
            // 
            this.restoToolStripMenuItem.Name = "restoToolStripMenuItem";
            this.restoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restoToolStripMenuItem.Text = "&Resto";
            this.restoToolStripMenuItem.Click += new System.EventHandler(this.restoToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 555);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variáveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

