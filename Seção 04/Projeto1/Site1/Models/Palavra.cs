using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Models {
    public class Palavra {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        //1-Fácil, 2-Médio, 3-Difícil
        public byte Nivel { get; set; }
    }
}
