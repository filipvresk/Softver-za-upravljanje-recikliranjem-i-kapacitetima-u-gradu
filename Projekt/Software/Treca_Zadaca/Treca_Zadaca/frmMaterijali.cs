using Treca_Zadaca.Models;
using Treca_Zadaca.Repozitoriji;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treca_Zadaca
{
    public partial class frmMaterijali : Form
    {
        public frmMaterijali()
        {
            InitializeComponent();
        }

        private void frmMaterijali_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_fvresk21_DB", "PI2324_fvresk21_User", "M5;!H@v%");
            ShowMaterijal();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            frmUnesiMaterijal frmUnesiMaterijal = new frmUnesiMaterijal();
            frmUnesiMaterijal.ShowDialog();
            RefreshMaterijal();
        }
        private void RefreshMaterijal()
        {
            List<Materijal> listaMaterijala = RepozitorijMaterijala.GetMaterijals();
            dgvMaterijali.DataSource= listaMaterijala;
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            Materijal oznacenMaterijal=dgvMaterijali.CurrentRow.DataBoundItem as Materijal;
            RepozitorijMaterijala.Delete(oznacenMaterijal);
            RefreshMaterijal();
        }

        private void ShowMaterijal()
        {
            var materijali = RepozitorijMaterijala.GetMaterijals();
            dgvMaterijali.DataSource= materijali;

            dgvMaterijali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMaterijali.Columns["IdMaterijal"].DisplayIndex = 0;
            dgvMaterijali.Columns["Vrsta"].DisplayIndex = 1;
            dgvMaterijali.Columns["CijenaPoKg"].DisplayIndex = 2;
            dgvMaterijali.Columns["Kolicina"].DisplayIndex = 3;

            dgvMaterijali.Columns["IdMaterijal"].HeaderText = "ID materijala";
            dgvMaterijali.Columns["Vrsta"].HeaderText = "Vrsta materijala";
            dgvMaterijali.Columns["CijenaPoKg"].HeaderText = "Cijena po KG(eurocenti)";
            dgvMaterijali.Columns["Kolicina"].HeaderText = "Količina";
        }

        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            Materijal oznacenMaterijal = dgvMaterijali.CurrentRow.DataBoundItem as Materijal;
            frmAzurirajMaterijal frmAzurirajMaterijal = new frmAzurirajMaterijal(oznacenMaterijal);
            frmAzurirajMaterijal.ShowDialog();
            RefreshMaterijal();
        }
    }
}
