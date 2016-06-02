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
    public partial class formAdCarroOficina : Form
    {
        private meuStandRealContainer meustand;

        private Cliente clienteSeleccionado;
            

        public formAdCarroOficina(Cliente clienteSeleccionado, meuStandRealContainer meustand)
        {
            InitializeComponent();
            this.clienteSeleccionado = clienteSeleccionado;
            this.meustand = meustand;

          
        }

        private void formAdCarroOficina_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            CarroOficina car = new CarroOficina();


            car.Combustivel = txtCombustivel.Text;
            car.Kms = txtKms.Text;
            car.Marca = txtMarca.Text;
            car.Matricula = txtMatricula.Text;
            car.Modelo = txtModelo.Text;
            car.NumeroChassis = txtNChassis.Text;
            car.ClienteIdCliente = clienteSeleccionado.IdCliente;

            clienteSeleccionado.CarrosOficina.Add(car);

            meustand.SaveChanges();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
