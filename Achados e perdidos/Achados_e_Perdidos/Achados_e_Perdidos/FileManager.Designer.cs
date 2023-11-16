namespace Achado_e_Perdido
{
    partial class FileManager
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
            pbImagem = new PictureBox();
            btnImagem = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            SuspendLayout();
            // 
            // pbImagem
            // 
            pbImagem.Location = new Point(0, 32);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(431, 213);
            pbImagem.TabIndex = 0;
            pbImagem.TabStop = false;
            // 
            // btnImagem
            // 
            btnImagem.Location = new Point(153, 3);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(121, 23);
            btnImagem.TabIndex = 1;
            btnImagem.Text = "Selecionar Imagem";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnImagem);
            Controls.Add(pbImagem);
            Name = "FileManager";
            Size = new Size(431, 245);
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImagem;
        private Button btnImagem;
        private OpenFileDialog openFileDialog1;
    }
}
