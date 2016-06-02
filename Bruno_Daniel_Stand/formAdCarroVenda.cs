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
    public partial class formAdCarroVenda : Form
    {
        private meuStandRealContainer meustand;

        private Venda vendaSeleccionada;

        public formAdCarroVenda(Venda vendaSeleccionada, meuStandRealContainer meustand)
        {
            InitializeComponent();

            this.vendaSeleccionada = vendaSeleccionada;
            this.meustand = meustand;
        }

        private void formAdCarroVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CarroVenda car = new CarroVenda();


            car.Combustivel = txtCombustivel.Text;
            car.Extras = txtExtras.Text;
            car.Marca = txtMarca.Text;            
            car.Modelo = txtModelo.Text;
            car.NumeroChassis = txtNChassis.Text;
            
            meustand.CarroVendaSet.Add(car);
                
            meustand.SaveChanges();

        }
    }
}
