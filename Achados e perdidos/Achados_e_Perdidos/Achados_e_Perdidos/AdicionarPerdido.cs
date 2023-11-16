using Achado_e_Perdido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Achados_e_Perdidos
{
    public partial class AdicionarPerdido : UserControl
    {
        public string defaultValue = "-- Selecione --";
        public AdicionarPerdido()
        {
            InitializeComponent();
            ListaUnica();
        }

        public void ListaUnica()
        {
            ListagemCor();
            ListagemLocal();
            ListagemMaterial();
        }

        #region Lista_combo_Box
        public void ListagemCor()
        {
            cbxCor.DataSource = Enum.GetValues(typeof(EnumCombobox.Cor));
            cbxCor.SelectedIndex = -1;
            cbxCor.Text = defaultValue;
        }
        public void ListagemMaterial()
        {
            cbxMaterial.DataSource = Enum.GetValues(typeof(EnumCombobox.Material));
            cbxMaterial.SelectedIndex = -1;
            cbxMaterial.Text = defaultValue;
        }

        public void ListagemLocal()
        {
            cbxLocal.DataSource = Enum.GetValues(typeof(EnumCombobox.Local));
            cbxLocal.SelectedIndex = -1;
            cbxLocal.Text = defaultValue;
        }

        #endregion

        #region CadastroNvItem
        private void txbItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbxCor.Focus();
            }
            var addImagem = new FileManager();
            pnlImagem.Controls.Clear();
            pnlImagem.Controls.Add(addImagem);
        }

        private void cbxCor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxCor.SelectedIndex != -1)
            {
                cbxMaterial.Focus();
            }
        }
        private void cbxMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxMaterial.SelectedIndex != -1)
            {
                cbxLocal.Focus();
            }
        }

        private void cbxLocal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxLocal.SelectedIndex != -1)
            {
                txbEntregador.Focus();
            }
        }
        private void txbEntregador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txbObs.Focus();
            }
        }
        private void txbObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSalvar_Click(sender, e);
            }
        }

        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja salvar este item?", "Confirmar", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var preenchimento = $"{txbItem.Text},{txbObs.Text},{txbEntregador.Text},{cbxCor.Text},{cbxLocal.Text},{cbxMaterial.Text}";
                var cadastroUpper = preenchimento.ToUpper();
                MessageBox.Show(cadastroUpper);
            }
            if (result == DialogResult.Cancel)
            {
                //when its cancel i prefer to stay on the same window 
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            txbItem.Focus();
            txbItem.Clear();
            txbEntregador.Clear();
            ListaUnica();
        }

    }
}
