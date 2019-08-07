using System;
using System.Linq;
using System.Windows.Forms;

namespace Fihrist
{
    public partial class frmDüzenle : Form
    {
        dbDataContext db=new dbDataContext();
        public frmDüzenle()
        {
            InitializeComponent();
        }
        private void frmDuzenle_Load(object sender, EventArgs e)
        {
            txtAdg.Text = frmMain.ads; txtBirimG.Text = frmMain.birims; txttelG.Text = frmMain.nos;
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtAdg.Text != "" && txtBirimG.Text != "" && txttelG.Text != "")
            {
                fihrist fih = db.fihrists.First(f => f.id == int.Parse(frmMain.ids));
                fih.ad = txtAdg.Text;
                fih.tel = txttelG.Text;
                fih.birim = txtBirimG.Text;
                db.SubmitChanges();
                MessageBox.Show("Güncellendi"); this.Close();
                
            }
            else { MessageBox.Show("Boş alan bırakmayınız. "); }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txttelG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

        private void txtBirimG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAdg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
