namespace Achados_e_Perdidos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            achadosEPerdidosToolStripMenuItem = new ToolStripMenuItem();
            emEstoqueToolStripMenuItem = new ToolStripMenuItem();
            novoItemToolStripMenuItem = new ToolStripMenuItem();
            pnlHome = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, achadosEPerdidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(153, 22);
            aToolStripMenuItem.Text = "Manuel de Uso";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(153, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // achadosEPerdidosToolStripMenuItem
            // 
            achadosEPerdidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emEstoqueToolStripMenuItem, novoItemToolStripMenuItem });
            achadosEPerdidosToolStripMenuItem.Name = "achadosEPerdidosToolStripMenuItem";
            achadosEPerdidosToolStripMenuItem.Size = new Size(123, 20);
            achadosEPerdidosToolStripMenuItem.Text = "Achados e Perdidos";
            // 
            // emEstoqueToolStripMenuItem
            // 
            emEstoqueToolStripMenuItem.Name = "emEstoqueToolStripMenuItem";
            emEstoqueToolStripMenuItem.Size = new Size(180, 22);
            emEstoqueToolStripMenuItem.Text = "Em estoque";
            emEstoqueToolStripMenuItem.Click += emEstoqueToolStripMenuItem_Click;
            // 
            // novoItemToolStripMenuItem
            // 
            novoItemToolStripMenuItem.Name = "novoItemToolStripMenuItem";
            novoItemToolStripMenuItem.Size = new Size(180, 22);
            novoItemToolStripMenuItem.Text = "Novo Item";
            novoItemToolStripMenuItem.Click += novoItemToolStripMenuItem_Click;
            // 
            // pnlHome
            // 
            pnlHome.Location = new Point(0, 27);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(800, 345);
            pnlHome.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 373);
            Controls.Add(pnlHome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem achadosEPerdidosToolStripMenuItem;
        private ToolStripMenuItem emEstoqueToolStripMenuItem;
        private ToolStripMenuItem novoItemToolStripMenuItem;
        private Panel pnlHome;
    }
}