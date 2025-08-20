using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariodeCriaturas.Models
{
    public class Fenix : Criaturas
    {
        public int Renascer { get; set; }
      
        public override int ForcaTotal()
        {
            return Renascer * 2; 
        }

        public string Descricao()
        {
            return $"Poder: {Poder}, Força Total: {ForcaTotal()}";
        }
    }
}

