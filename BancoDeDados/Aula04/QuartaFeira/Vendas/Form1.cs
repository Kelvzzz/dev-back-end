using Vendas.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CarregarDados()
        {
            try
            {
                VendasContexto vendasContexto = new VendasContexto();

                var listaDeVenda = vendasContexto.vendas.ToList();
                dataGridView1.DataSource = listaDeVenda;
            }

            catch (Exception ex)
            { MessageBox.Show("Erro ao carregar dados: " + ex.Message);

            }

  
        }
       
    }

}
