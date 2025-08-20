using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariodeCriaturas.Models
{
    // Classe base abstrata
    public abstract class Criaturas
    {
        public string Nome { get; set; }
        public string Poder { get; set; }
        public int ForcaBase { get; set; }

        // Método abstrato que cada subclasse precisa implementar
        public abstract int ForcaTotal(); 
    }
}
