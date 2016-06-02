using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruno_Daniel_Stand
{
    public partial class formVenda : Form
    {
        private meuStandRealContainer meustand;
        public formVenda()
        {
            InitializeComponent();

            meustand = new meuStandRealContainer();
        }

        private void formVenda_Load(object sender, EventArgs e)
        {
            meustand = new meuStandRealContainer();
            Ler_Dados();
        }

        private void Ler_Dados()
        {
            listClientes.DataSource = meustand.Clientes.ToList<Cliente>();
        }

        //adcionar um carro a venda
        private void btnAdCarro_Click(object sender, EventArgs e)
        {
            Venda vendaSeleccionada = (Venda)listVenda.SelectedItem;

            formAdCarroVenda facv = new formAdCarroVenda(vendaSeleccionada, meustand);

            if (facv.ShowDialog() == DialogResult.OK)
            {
                listCarroVenda.DataSource = null;
                listCarroVenda.DataSource = meustand.CarroVendaSet;
            }
            else
            {
                MessageBox.Show("Não existem dados para adicionar!");
            }
        }


        //adicionar uma venda ao cliente
        private void btnAdVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;
            Venda sale = new Venda();

            sale.Data = txtData.Text;
            sale.Estado = txtEstado.Text;

            Decimal valorAdicionar = 0;
            try
            {
                valorAdicionar = Decimal.Parse(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor inserido não é válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sale.Valor = valorAdicionar;
           


            clienteSeleccionado.Vendas.Add(sale);
            meustand.SaveChanges();

            listVenda.DataSource = null;
            listVenda.DataSource = clienteSeleccionado.Vendas.ToList<Venda>();

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;

            listVenda.DataSource = null;
            listVenda.DataSource = clienteSeleccionado.Vendas.ToList<Venda>();
        }

        private void listVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venda vendaSeleccionada = (Venda)listVenda.SelectedItem;

            listCarroVenda.DataSource = null;
            listCarroVenda.DataSource = meustand.CarroVendaSet.ToList<CarroVenda>();
        }
    }
}
