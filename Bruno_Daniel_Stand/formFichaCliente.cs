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
    public partial class formFichaCliente : Form
    {
        private meuStandRealContainer meustand;
        public formFichaCliente()
        {
           
            InitializeComponent();

            meustand = new meuStandRealContainer();

            (from Cliente in meustand.Clientes
             select Cliente).Load();

            clienteBindingSource.DataSource = meustand.Clientes.Local.ToBindingList();
        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void formFichaCliente_Load(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            meustand.SaveChanges();
        }
    }
}
