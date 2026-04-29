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
    public partial class frmLogin : Form
    {
        public static Zaposlenik PrijavljeniZaposlenik { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_fvresk21_DB", "PI2324_fvresk21_User", "M5;!H@v%");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrijavljeniZaposlenik = RepozitorijZaposlenika.GetZaposlenik(txtUsername.Text);

                if (PrijavljeniZaposlenik != null && PrijavljeniZaposlenik.Password == txtPassword.Text)
                {
                    frmMaterijali frmMaterijali = new frmMaterijali();
                    Hide();
                    frmMaterijali.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
