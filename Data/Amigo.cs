using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAmigos.Data
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NameMother { get; set; }
        public string NameDad { get; set; }
        public int Cpf { get; set; }
    }
}
