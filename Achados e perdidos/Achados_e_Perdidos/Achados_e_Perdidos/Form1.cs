namespace Achados_e_Perdidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Layout();
        }
        private void Layout()
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }
        private void emEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var perdhist = new EstoquePerdido();
            pnlHome.Controls.Clear();
            pnlHome.Controls.Add(perdhist);
        }
        private void novoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var perdadd = new AdicionarPerdido();
            pnlHome.Controls.Clear();
            pnlHome.Controls.Add(perdadd);
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}