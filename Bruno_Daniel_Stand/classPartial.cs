using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruno_Daniel_Stand
{

    public partial class meuStandRealContainer : DbContext
    {
        public virtual DbSet<CarroOficina> CarroOficinaSet { get; set; }
        public virtual DbSet<CarroAluguer> CarroAluguerSet { get; set; }
        public virtual DbSet<CarroVenda> CarroVendaSet { get; set; }

    }

  






    public partial class Cliente
    {
        public override string ToString()
        {
            return this.Nome + "(" + this.IdCliente + ")" + this.NIF + ", " + this.getTotal();

        }
        public Decimal getTotal()
         {
             Decimal temp = 0;
             foreach (CarroOficina item in this.CarrosOficina)
             {
                 temp += item.getTotal();
             }
             return temp;
         }
    }




    public partial class CarroOficina
    {
        public override string ToString()
        {
            return this.IdCarro + ", " + this.Matricula + ", " +  this.Marca + ", " + this.Modelo;
        }

        public Decimal getTotal()
        {
            Decimal temp = 0;
            foreach (Servico item in this.Servicos)
            {
                temp += item.getTotal();
            }
            return temp;
        }
    }




    public partial class CarroAluguer
    {
        public override string ToString()
        {
            return this.IdCarro + ", " + this.Matricula + ", " + this.Estado;
        }
    }




    public partial class CarroVenda
    {
        public override string ToString()
        {
            return this.IdCarro + ", " + this.Extras + ", " + this.VendaIdVenda; 
        }
    }





    public partial class Carro
    {

        public override string ToString()
        {
            return this.IdCarro.ToString() ;
        }
        
    }





    public partial class Servico
        {
            public override string ToString()
            {
                return this.Tipo + ", Total: " + this.getTotal() + "€";

            }
        
            public Decimal getTotal()
            {
                Decimal temp = 0;
                foreach (Parcela item in this.Parcelas)
                {
                    temp += item.Valor;
                }
                return temp;
            }

        }




    public partial class Parcela
        {
            public override string ToString()
            {
                return this.Descricao + ", " + this.Valor + "€";
            }
        }



    public partial class Aluguer
        {
            public override string ToString()
            {
                return this.CarroAluguer + ", " + this.DataInicio + ", " + this.Kms + ", " +  this.Valor + "€";
            }
        }



    public partial class Venda
        {
            public override string ToString()
            {
            return this.IdVenda + ", " + this.Valor + ", " + this.Data;
            }
        }

}

