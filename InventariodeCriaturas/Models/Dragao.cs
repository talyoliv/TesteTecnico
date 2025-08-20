using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariodeCriaturas.Models
{
    public class Dragao : Criaturas
    {
        public int Fogo { get; set; }
        public int Mana { get; set; }

        public override int ForcaTotal()
        {
            return Fogo * 5; 
        }

        public string Descricao()
        {
            return $"Poder: {Poder}, Força Total: {ForcaTotal()}";
        }
    }
}



