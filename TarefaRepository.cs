using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class TarefaRepository
    {
        private readonly string _caminhoDb = "tarefas.db";

        public void Adcionar(Tarefa tarefa)
        {
            using var db = new LiteDatabase(_caminhoDb);
            var colecao = db.GetCollection<Tarefa>("tarefas");
            colecao.Insert(tarefa);

        }

        public List<Tarefa> ListarTodas()
        {
            using var db = new LiteDatabase(_caminhoDb);
            var colecao = db.GetCollection<Tarefa>("tarefas");
            return colecao.FindAll().ToList();

        }

        public void Remover(int id)
        {
            using var db = new LiteDatabase(_caminhoDb);
            var colecao = db.GetCollection<Tarefa>("tarefas");
            colecao.Delete(id);
        }

        public void Atualizar(Tarefa tarefa)
        {
            using var db = new LiteDatabase(_caminhoDb);
            var colecao = db.GetCollection<Tarefa>("tarefas");
            colecao.Update(tarefa);
        }
    }

}
