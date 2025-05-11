namespace SisCon
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tabControl1 = new TabControl();
            tabOrcamento = new TabPage();
            tabProdutos = new TabPage();
            tabFilamentos = new TabPage();
            tabMaquinas = new TabPage();
            tabMateriaisInsumos = new TabPage();
            tabFornecedores = new TabPage();
            tabEnergia = new TabPage();
            tabSalarios = new TabPage();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabOrcamento);
            tabControl1.Controls.Add(tabProdutos);
            tabControl1.Controls.Add(tabFilamentos);
            tabControl1.Controls.Add(tabMaquinas);
            tabControl1.Controls.Add(tabMateriaisInsumos);
            tabControl1.Controls.Add(tabFornecedores);
            tabControl1.Controls.Add(tabEnergia);
            tabControl1.Controls.Add(tabSalarios);
            tabControl1.HotTrack = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabOrcamento
            // 
            tabOrcamento.BackColor = Color.Transparent;
            resources.ApplyResources(tabOrcamento, "tabOrcamento");
            tabOrcamento.Name = "tabOrcamento";
            tabOrcamento.UseVisualStyleBackColor = true;
            // 
            // tabProdutos
            // 
            resources.ApplyResources(tabProdutos, "tabProdutos");
            tabProdutos.Name = "tabProdutos";
            tabProdutos.UseVisualStyleBackColor = true;
            // 
            // tabFilamentos
            // 
            resources.ApplyResources(tabFilamentos, "tabFilamentos");
            tabFilamentos.Name = "tabFilamentos";
            tabFilamentos.UseVisualStyleBackColor = true;
            // 
            // tabMaquinas
            // 
            resources.ApplyResources(tabMaquinas, "tabMaquinas");
            tabMaquinas.Name = "tabMaquinas";
            tabMaquinas.UseVisualStyleBackColor = true;
            // 
            // tabMateriaisInsumos
            // 
            resources.ApplyResources(tabMateriaisInsumos, "tabMateriaisInsumos");
            tabMateriaisInsumos.Name = "tabMateriaisInsumos";
            tabMateriaisInsumos.UseVisualStyleBackColor = true;
            // 
            // tabFornecedores
            // 
            resources.ApplyResources(tabFornecedores, "tabFornecedores");
            tabFornecedores.Name = "tabFornecedores";
            tabFornecedores.UseVisualStyleBackColor = true;
            // 
            // tabEnergia
            // 
            resources.ApplyResources(tabEnergia, "tabEnergia");
            tabEnergia.Name = "tabEnergia";
            tabEnergia.UseVisualStyleBackColor = true;
            // 
            // tabSalarios
            // 
            resources.ApplyResources(tabSalarios, "tabSalarios");
            tabSalarios.Name = "tabSalarios";
            tabSalarios.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            resources.ApplyResources(arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabOrcamento;
        private TabPage tabProdutos;
        private TabPage tabMaquinas;
        private TabPage tabMateriaisInsumos;
        private TabPage tabFornecedores;
        private TabPage tabEnergia;
        private TabPage tabSalarios;
        private TabPage tabFilamentos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
    }
}
