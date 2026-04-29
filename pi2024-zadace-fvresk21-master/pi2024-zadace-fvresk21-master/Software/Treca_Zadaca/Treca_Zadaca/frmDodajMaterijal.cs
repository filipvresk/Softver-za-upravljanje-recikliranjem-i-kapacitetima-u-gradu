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
    public partial class frmUnesiMaterijal : Form
    {
        public frmUnesiMaterijal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertMaterial_Click(object sender, EventArgs e)
        {
            string vrsta = txtMaterialType.Text;
            int cijenakg = int.Parse(txtMaterialPriceKg.Text);
            int kolicina = int.Parse(txtMaterialQuantity.Text);

            var materijal = new Materijal
            {
                
                Vrsta = vrsta,
                CijenapoKg = cijenakg,
                Kolicina = kolicina
            };
            RepozitorijMaterijala.Add(materijal);
            this.Close();
        }

        private void frmUnesiMaterijal_Load(object sender, EventArgs e)
        {

        }
    }
}
