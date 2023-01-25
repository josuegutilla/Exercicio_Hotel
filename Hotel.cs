using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hotel_Arrays
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Hotel(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name 
                + ", " 
                + Email;
        }
    }
}
