using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruno_Daniel_Stand
{
    public partial class formAluguer : Form
    {
        private meuStandRealContainer meustand;

        public formAluguer()
        {
            InitializeComponent();

            meustand = new meuStandRealContainer();

        }

        private void formAluguer_Load(object sender, EventArgs e)
        {
            meustand = new meuStandRealContainer();
            Ler_Dados();
        }

        private void Ler_Dados()
        {
            listClientes.DataSource = meustand.Clientes.ToList<Cliente>();

            listCarroAlugado.DataSource = meustand.CarroAluguerSet.ToList<CarroAluguer>();

        }


        //mudar de cliente seleccionado
        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;

            if (clienteSeleccionado == null)
                return;

            listAluguers.DataSource = null;
            listAluguers.DataSource = clienteSeleccionado.Alugueres.ToList<Aluguer>();

        }
        //adicionar Aluguer
        private void btnAdAluguer_Click(object sender, EventArgs e)
        {

            Aluguer aluTemp = new Aluguer();

            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;
            Aluguer aluguerSeleccionado = (Aluguer)listAluguers.SelectedItem;
            CarroAluguer carroSeleccionado = (CarroAluguer)listCarroAlugado.SelectedItem;

            if (aluguerSeleccionado == null)
                return;

            aluTemp.DataInicio = txtDataInicio.Text;
            aluTemp.DataFim = txtDataFim.Text;
            aluTemp.Valor = txtValor.Text;
            aluTemp.Kms = txtKms.Text;
            aluTemp.ClienteIdCliente = clienteSeleccionado.IdCliente;                      
            aluTemp.CarroAluguer.IdCarro = carroSeleccionado.IdCarro;



            clienteSeleccionado.Alugueres.Add(aluTemp);

            meustand.SaveChanges();

            listAluguers.DataSource = null;
            listAluguers.DataSource = clienteSeleccionado.Alugueres.ToList<Aluguer>();
        }

        //adicionar carro aluguer
        private void btnAdCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;
            Aluguer aluguerSeleccionado = (Aluguer)listAluguers.SelectedItem;

            formAdCarroAluguer faca = new formAdCarroAluguer(aluguerSeleccionado, meustand);

            if (faca.ShowDialog() == DialogResult.OK)
            {
                listCarroAlugado.DataSource = null;
                listCarroAlugado.DataSource = meustand.CarroAluguerSet.ToList<CarroAluguer>();
            }
            else
            {
                MessageBox.Show("Não existem dados para adicionar!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //mudar aluguer seleccionado
        private void listAluguers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerSeleccionado = (Aluguer)listAluguers.SelectedItem;

            if (aluguerSeleccionado == null)
                return;
        }


       

        
        private void listCarroAlugado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroAluguer carroSeleccionado = (CarroAluguer)listCarroAlugado.SelectedItem;

            if (carroSeleccionado == null)
                return;

            lblIdCarro.Text = carroSeleccionado.IdCarro.ToString();

            
           
        }
    }
}
