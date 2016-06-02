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
    public partial class formOficina : Form
    {
        private meuStandRealContainer meustand;
        public formOficina()
        {
            InitializeComponent();
            
            meustand = new meuStandRealContainer();     
        }

        private void formOficina_Load(object sender, EventArgs e)
        {
            meustand = new meuStandRealContainer();
            Ler_Dados();

            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void Ler_Dados()
        {
            listClientes.DataSource = meustand.Clientes.ToList<Cliente>();                    
        }

        //adicionar carro a lista carrosOficina
        private void btnAdCarroOficina_Click(object sender, EventArgs e)
        {

            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;

            formAdCarroOficina faco = new formAdCarroOficina(clienteSeleccionado, meustand);

            if (faco.ShowDialog() == DialogResult.OK)
            {
                listCarrosOficina.DataSource = null;
                listCarrosOficina.DataSource = clienteSeleccionado.CarrosOficina.ToList<CarroOficina>();
            }
            else
            {
                MessageBox.Show("Não existem dados para adicionar!");
            }
        }
        
        //adicionar serviço a lista de servicos
        private void btnAdServicos_Click(object sender, EventArgs e)
        {
            Servico serTemp = new Servico();
            CarroOficina carroSeleccionado = (CarroOficina)listCarrosOficina.SelectedItem;

            serTemp.DataEntrada = lblData.Text;
            serTemp.DataSaida = txtDataSaida.Text;
            serTemp.Tipo = txtTipo.Text;

            carroSeleccionado.Servicos.Add(serTemp);

            meustand.SaveChanges();

            listServicos.DataSource = null;
            listServicos.DataSource = carroSeleccionado.Servicos.ToList<Servico>();
        }

        //adcionar parcela a lista de parcelas
        private void btnAdParcelas_Click(object sender, EventArgs e)
        {

            Parcela parTemp = new Parcela();
            Servico servicoSeleccionado = (Servico)listServicos.SelectedItem;

            parTemp.Descricao = txtDescricao.Text;

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

            parTemp.Valor = valorAdicionar;
            
            servicoSeleccionado.Parcelas.Add(parTemp);

            meustand.SaveChanges();

            listParcelas.DataSource = null;
            listParcelas.DataSource = servicoSeleccionado.Parcelas.ToList<Parcela>();
        }

        //mudar de cliente
        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)listClientes.SelectedItem;
            
            //alterar os carrosOficina consoante o cliente seleccionado
            listCarrosOficina.DataSource = null;
            listCarrosOficina.DataSource = clienteSeleccionado.CarrosOficina.ToList<CarroOficina>();

            listServicos.DataSource = null;

            listParcelas.DataSource = null;
            
            lblNomeCliente.Text = clienteSeleccionado.Nome;
            lblNif.Text = clienteSeleccionado.NIF;
            lblContacto.Text = clienteSeleccionado.Contacto;

            Decimal total;
            total = clienteSeleccionado.getTotal();

            lblTotal.Text = total.ToString();                      
        }

        //mudar de carro
        private void listCarrosOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
           CarroOficina carroSeleccionado = (CarroOficina)listCarrosOficina.SelectedItem;

            if (carroSeleccionado == null)
                return;

            listServicos.DataSource = null;
            listServicos.DataSource = carroSeleccionado.Servicos.ToList<Servico>();
        }
                
        //mudar de servico
        private void listServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSeleccionado = (Servico)listServicos.SelectedItem;

            if (servicoSeleccionado == null)
                return;

            listParcelas.DataSource = null;
            listParcelas.DataSource = servicoSeleccionado.Parcelas.ToList<Parcela>();
        }



        private void listParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
