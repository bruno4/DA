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
    public partial class formAdCarroAluguer : Form
    {
        private meuStandRealContainer meustand;

        private Aluguer aluguerSeleccionado;


        public formAdCarroAluguer(Aluguer aluguerSeleccionado, meuStandRealContainer meustand)
        {
            InitializeComponent();

            this.aluguerSeleccionado = aluguerSeleccionado;
            this.meustand = meustand;


        }

        private void formAdCarroAluguer_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CarroAluguer car = new CarroAluguer();
            
           
            car.Combustivel = txtCombustivel.Text;
            car.Estado = txtEstado.Text;
            car.Marca = txtMarca.Text;
            car.Matricula = txtMatricula.Text;
            car.Modelo = txtModelo.Text;
            car.NumeroChassis = txtNChassis.Text;

            meustand.Carros.Add(car);

            meustand.SaveChanges();

        }
    }
}
