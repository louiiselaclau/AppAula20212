using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pessoa
    {
        public class Pessoas
        {
            public Int64 CPF { get; set; }

            public String Nome { get; set; }

            public String Email { get; set; }

            public String Cel { get; set; }

            public String Profissao { get; set; }

            public DateTime Nascimento { get; set; }

            public String Sexo { get; set; }

            public Endereco Endereco { get; set; }
        }
    }
}
