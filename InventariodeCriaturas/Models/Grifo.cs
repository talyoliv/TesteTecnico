using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariodeCriaturas.Models
{
    public class Grifo : Criaturas
    {
        public int Agua { get; set; }
      
        public override int ForcaTotal()
        {
            return Agua * 2; 
        }

        public string Descricao()
        {
            return $"Poder: {Poder}, Força Total: {ForcaTotal()}";
        }
    }
}