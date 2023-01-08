using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulsLogAgendamento.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Container { get; set; }
        public string Numero_Book { get; set; }
        public string NF { get; set; }
        public DateTime Data_Limite { get; set; }
        public DateTime Data_Escolhida { get; set; }
    }
}
