using System;
using System.Windows.Forms;

namespace Fihrist
{
    public partial class frmEkle : Form
    {
        dbDataContext db=new dbDataContext();
        public frmEkle()
        {
            InitializeComponent();
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtbirim.Text != "" && txttel.Text != "")
            {
                fihrist fih = new fihrist()
                {
                    ad = txtad.Text,
                    birim = txtbirim.Text,
                    tel = txttel.Text
                };
                db.fihrists.InsertOnSubmit(fih);
                db.SubmitChanges();
                MessageBox.Show("Eklendi"); this.Close();
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

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtbirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
