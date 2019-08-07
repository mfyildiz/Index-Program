using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Fihrist
{
    public partial class frmMain : Form
    {
        dbDataContext db = new dbDataContext();
        public static string ids;
        public static string ads;
        public static string birims;
        public static string nos;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            var result = from f in db.fihrists
                         orderby f.id descending
                         select new
                         {
                             ID = f.id,
                             ADI = f.ad,
                             BIRIM=f.birim,
                             TELEFON=f.tel
                         };
            dgv.DataSource = result.ToList();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        { 
            doldur(txtArama.Text);
        }

        private void doldur(string text)
        {
            var result = from f in db.fihrists
                         where f.ad.Contains(text) || f.birim.Contains(text) || f.tel.Contains(text)
                         orderby f.id descending
                         select new
                         {
                             ID = f.id,
                             ADI = f.ad,
                             BIRIM = f.birim,
                             TELEFON = f.tel
                         };
            dgv.DataSource = result.ToList();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEkle yeni = new frmEkle();
            yeni.ShowDialog();
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.fihrists);
            doldur();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ads = dgv.SelectedRows[0].Cells[1].Value.ToString();
            birims = dgv.SelectedRows[0].Cells[3].Value.ToString();
            nos = dgv.SelectedRows[0].Cells[2].Value.ToString();
            ids = dgv.SelectedRows[0].Cells[0].Value.ToString();
            frmDüzenle yenid = new frmDüzenle();
            yenid.ShowDialog();
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.fihrists);
            doldur();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idds = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                fihrist fihr = db.fihrists.First(f => f.id == idds);
                db.fihrists.DeleteOnSubmit(fihr);
                db.SubmitChanges();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.fihrists);
                doldur();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ads = dgv.SelectedRows[0].Cells[1].Value.ToString();
            birims = dgv.SelectedRows[0].Cells[3].Value.ToString();
            nos = dgv.SelectedRows[0].Cells[2].Value.ToString();
            ids = dgv.SelectedRows[0].Cells[0].Value.ToString();
            frmDüzenle yenid = new frmDüzenle();
            yenid.ShowDialog();
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.fihrists);
            doldur();
        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtArama.Clear();
            }
        }
    }
}
