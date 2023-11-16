namespace Achados_e_Perdidos
{
    partial class EstoquePerdido
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
            btnRemove = new Button();
            btnAdd = new Button();
            btnDetalhes = new Button();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 8);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "LISTAGEM ESTOQUE";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(35, 299);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDetalhes
            // 
            btnDetalhes.Location = new Point(127, 270);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(75, 52);
            btnDetalhes.TabIndex = 5;
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(19, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(196, 238);
            checkedListBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(221, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 310);
            panel1.TabIndex = 7;
            // 
            // EstoquePerdido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(checkedListBox1);
            Controls.Add(btnDetalhes);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Name = "EstoquePerdido";
            Size = new Size(800, 324);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnDetalhes;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
    }
}
