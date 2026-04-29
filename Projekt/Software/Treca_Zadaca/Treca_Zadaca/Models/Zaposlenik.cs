using Treca_Zadaca.Repozitoriji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treca_Zadaca.Models
{
    public class Zaposlenik
    {
        public int Id {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }

}
