using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Achado_e_Perdido
{
    public partial class FileManager : UserControl
    {
        public FileManager()
        {
            InitializeComponent();
        }
        private async void btnImagem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.SpecialFolder.UserProfile + @"\Downloads";
                ofd.Filter = "Imagen (*.jpg)|*.jpg|Imagen (*.png)|*.png|Imagen (*.bmp)|*.bmp"/*|All files (*.*)|*.*"*/;
                //ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    try
                    {
                        pbImagem.Image = Image.FromFile(filePath);
                        await Task.Delay(200);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Tente Novamente", "Erro de Leitura" + a.Message);
                        return;
                    }
                    MessageBox.Show(filePath, "Arquivo Selecionado", MessageBoxButtons.OK);
                }
            }
        }
    }
}

