using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treca_Zadaca.Models;
using Treca_Zadaca.Repozitoriji;

namespace Treca_Zadaca
{
    public partial class frmAzurirajMaterijal : Form
    {
        private Materijal materijal;
        public frmAzurirajMaterijal(Materijal materijali)
        {
            InitializeComponent();
            materijal = materijali; 
        }

        private void btnExitUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAzurirajMaterijal_Load(object sender, EventArgs e)
        {
            txtIdMaterialUpdate.Text = materijal.IdMaterijal.ToString();
            txtMaterialTypeUpdate.Text = materijal.Vrsta;
            txtMaterialPriceKgUpdate.Text=materijal.CijenapoKg.ToString();
            txtMaterialQuantityUpdate.Text=materijal.Kolicina.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int identifikator;
            if(int.TryParse(txtIdMaterialUpdate.Text, out identifikator))
            {
                materijal.IdMaterijal = identifikator;
            }
            materijal.Vrsta = txtMaterialTypeUpdate.Text;
            int cijena;
            if(int.TryParse(txtMaterialPriceKgUpdate.Text, out cijena))
            {
                materijal.CijenapoKg = cijena;
            }
            int koliko;
            if(int.TryParse(txtMaterialQuantityUpdate.Text, out koliko))
            {
                materijal.Kolicina = koliko;
            }
            RepozitorijMaterijala.Update(materijal);
            this.Close();
        }
    }
}
