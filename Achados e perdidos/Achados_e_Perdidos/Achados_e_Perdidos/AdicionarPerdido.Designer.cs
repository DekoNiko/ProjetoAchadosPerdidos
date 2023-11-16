namespace Achados_e_Perdidos
{
    partial class AdicionarPerdido
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbItem = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbEntregador = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txbObs = new TextBox();
            cbxLocal = new ComboBox();
            cbxCor = new ComboBox();
            cbxMaterial = new ComboBox();
            label8 = new Label();
            btnSalvar = new Button();
            btnDescartar = new Button();
            pnlImagem = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txbItem
            // 
            txbItem.Location = new Point(6, 37);
            txbItem.Name = "txbItem";
            txbItem.Size = new Size(271, 23);
            txbItem.TabIndex = 1;
            txbItem.KeyPress += txbItem_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Cor predominante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 159);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Local encontrado:";
            // 
            // txbEntregador
            // 
            txbEntregador.Location = new Point(6, 225);
            txbEntregador.Name = "txbEntregador";
            txbEntregador.Size = new Size(169, 23);
            txbEntregador.TabIndex = 7;
            txbEntregador.KeyPress += txbEntregador_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 207);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 6;
            label4.Text = "Funcionário que entregou:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(678, 21);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(347, 21);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(67, 23);
            textBox6.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 3);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Nº Registro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(731, 3);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txbObs);
            groupBox1.Controls.Add(cbxLocal);
            groupBox1.Controls.Add(cbxCor);
            groupBox1.Controls.Add(cbxMaterial);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txbItem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbEntregador);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(20, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 312);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 267);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 16;
            label7.Text = "Observações:";
            // 
            // txbObs
            // 
            txbObs.Location = new Point(6, 285);
            txbObs.Name = "txbObs";
            txbObs.Size = new Size(296, 23);
            txbObs.TabIndex = 15;
            txbObs.KeyPress += txbObs_KeyPress;
            // 
            // cbxLocal
            // 
            cbxLocal.FormattingEnabled = true;
            cbxLocal.Location = new Point(6, 177);
            cbxLocal.Name = "cbxLocal";
            cbxLocal.Size = new Size(169, 23);
            cbxLocal.TabIndex = 14;
            cbxLocal.SelectionChangeCommitted += cbxLocal_SelectionChangeCommitted;
            // 
            // cbxCor
            // 
            cbxCor.FormattingEnabled = true;
            cbxCor.Location = new Point(6, 83);
            cbxCor.Name = "cbxCor";
            cbxCor.Size = new Size(169, 23);
            cbxCor.TabIndex = 12;
            cbxCor.SelectionChangeCommitted += cbxCor_SelectionChangeCommitted;
            // 
            // cbxMaterial
            // 
            cbxMaterial.FormattingEnabled = true;
            cbxMaterial.Location = new Point(6, 133);
            cbxMaterial.Name = "cbxMaterial";
            cbxMaterial.Size = new Size(169, 23);
            cbxMaterial.TabIndex = 11;
            cbxMaterial.SelectionChangeCommitted += cbxMaterial_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 115);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 10;
            label8.Text = "Material:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(347, 301);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDescartar
            // 
            btnDescartar.Location = new Point(690, 301);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(88, 23);
            btnDescartar.TabIndex = 15;
            btnDescartar.Text = "Descartar";
            btnDescartar.UseVisualStyleBackColor = true;
            btnDescartar.Click += btnDescartar_Click;
            // 
            // pnlImagem
            // 
            pnlImagem.Location = new Point(347, 50);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(431, 245);
            pnlImagem.TabIndex = 17;
            // 
            // AdicionarPerdido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlImagem);
            Controls.Add(btnDescartar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Name = "AdicionarPerdido";
            Size = new Size(800, 345);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbItem;
        private Label label2;
        private Label label3;
        private TextBox txbEntregador;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox cbxLocal;
        private ComboBox cbxCor;
        private ComboBox cbxMaterial;
        private Button btnSalvar;
        private Button btnDescartar;
        private Label label7;
        private TextBox txbObs;
        private Panel pnlImagem;
    }
}
