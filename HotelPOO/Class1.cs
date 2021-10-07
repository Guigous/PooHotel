using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPOO
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email{ get; set; }
        //Encapsulamento
        public Hospede(string nome , string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + " , " + Email ;
        }
    }
}
