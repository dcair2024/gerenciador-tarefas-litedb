namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            string descricao = txtTarefa.Text.Trim();

            if (!string.IsNullOrEmpty(descricao))
            {
                Tarefa tarefa = new Tarefa
                {
                    Descricao = descricao,
                    Concluida = false
                };

                TarefaRepository tarefaRepository = new TarefaRepository();
                tarefaRepository.Adcionar(tarefa);
                lstTarefa.Items.Add(tarefa);//adciona a tarefa na listabox
                txtTarefa.Clear(); // Limpa o campo de texto
                txtTarefa.Focus(); // Foca no campo de texto

            }
            else
            {
                MessageBox.Show("Por favor, digite uma tarefa válida.", "Tarefa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTarefa.SelectedItem is Tarefa tarefaSelecionada)

            {

                try

                {

                    if (tarefaSelecionada.Id > 0)

                    {

                        TarefaRepository tarefa = new TarefaRepository();

                        tarefa.Remover(tarefaSelecionada.Id);

                    }




                    if (lstTarefa.SelectedItem != null)

                    {

                        lstTarefa.Items.Remove(lstTarefa.SelectedItem);

                    }

                    else

                    {

                        MessageBox.Show("Selecione uma tarefa para remover.");

                    }





                }

                catch (Exception ex)

                {

                    MessageBox.Show($"Erro ao remover a tarefa: {ex.Message}", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            else

            {

                MessageBox.Show($"Nenhuma tarefa foi Selcionada", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void CarregarTarefas()
        {
            try
            {
                TarefaRepository tarefaRepository = new TarefaRepository();
                List<Tarefa> tarefas = tarefaRepository.ListarTodas();

                lstTarefa.Items.Clear();

                foreach (var tarefa in tarefas)
                {
                    lstTarefa.Items.Add(tarefa);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar tarefas: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTarefas();
        }

        private void lstTarefa_DoubleClick(object sender, EventArgs e)
        {
            if (lstTarefa.SelectedItem is Tarefa tarefaSelecionada)
            {
                try
                {
                    tarefaSelecionada.Concluida = !tarefaSelecionada.Concluida;

                    TarefaRepository tarefa = new TarefaRepository();
                    tarefa.Atualizar(tarefaSelecionada);

                    int index = lstTarefa.SelectedIndex;
                    lstTarefa.Items[index] = tarefaSelecionada;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar a tarefa: {ex.Message}", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Nanhuma tarefa foi Selcionada", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
