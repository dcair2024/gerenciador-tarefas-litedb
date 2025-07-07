using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace WinFormsApp6
{
    public class Tarefa
    {
        [BsonId]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public override string ToString()
        {
            return Concluida ? "[✔]" + Descricao : "[ ] " + Descricao;
        }

    }
}
