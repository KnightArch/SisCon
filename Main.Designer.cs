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
            comboBox1 = new ComboBox();
            textBoxCustoTotal = new TextBox();
            textBoxMargemRiscoGTD = new TextBox();
            textBoxValorEnergia = new TextBox();
            textBoxValorConta = new TextBox();
            textBoxConsumo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabSalarios = new TabPage();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabEnergia.SuspendLayout();
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
            tabEnergia.Controls.Add(comboBox1);
            tabEnergia.Controls.Add(textBoxCustoTotal);
            tabEnergia.Controls.Add(textBoxMargemRiscoGTD);
            tabEnergia.Controls.Add(textBoxValorEnergia);
            tabEnergia.Controls.Add(textBoxValorConta);
            tabEnergia.Controls.Add(textBoxConsumo);
            tabEnergia.Controls.Add(label7);
            tabEnergia.Controls.Add(label6);
            tabEnergia.Controls.Add(label5);
            tabEnergia.Controls.Add(label4);
            tabEnergia.Controls.Add(label3);
            tabEnergia.Controls.Add(label2);
            tabEnergia.Controls.Add(label1);
            resources.ApplyResources(tabEnergia, "tabEnergia");
            tabEnergia.Name = "tabEnergia";
            tabEnergia.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5"), resources.GetString("comboBox1.Items6"), resources.GetString("comboBox1.Items7"), resources.GetString("comboBox1.Items8"), resources.GetString("comboBox1.Items9"), resources.GetString("comboBox1.Items10"), resources.GetString("comboBox1.Items11") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // textBoxCustoTotal
            // 
            resources.ApplyResources(textBoxCustoTotal, "textBoxCustoTotal");
            textBoxCustoTotal.Name = "textBoxCustoTotal";
            textBoxCustoTotal.TextChanged += textBoxCustoTotal_TextChanged;
            // 
            // textBoxMargemRiscoGTD
            // 
            resources.ApplyResources(textBoxMargemRiscoGTD, "textBoxMargemRiscoGTD");
            textBoxMargemRiscoGTD.Name = "textBoxMargemRiscoGTD";
            textBoxMargemRiscoGTD.TextChanged += textBoxMargemRiscoGTD_TextChanged;
            // 
            // textBoxValorEnergia
            // 
            resources.ApplyResources(textBoxValorEnergia, "textBoxValorEnergia");
            textBoxValorEnergia.Name = "textBoxValorEnergia";
            // 
            // textBoxValorConta
            // 
            resources.ApplyResources(textBoxValorConta, "textBoxValorConta");
            textBoxValorConta.Name = "textBoxValorConta";
            textBoxValorConta.TextChanged += textBoxValorConta_TextChanged;
            // 
            // textBoxConsumo
            // 
            resources.ApplyResources(textBoxConsumo, "textBoxConsumo");
            textBoxConsumo.Name = "textBoxConsumo";
            textBoxConsumo.TextChanged += textBoxConsumo_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
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
            tabEnergia.ResumeLayout(false);
            tabEnergia.PerformLayout();
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
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxCustoTotal;
        private TextBox textBoxMargemRiscoGTD;
        private TextBox textBoxValorEnergia;
        private TextBox textBoxValorConta;
        private TextBox textBoxConsumo;
        private ComboBox comboBox1;
    }
}
