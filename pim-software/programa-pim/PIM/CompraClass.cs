using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class CompraClass
    {
        private DateTime Dta_Compra;
        private Decimal Valor_Total;

        public DateTime getDta_Compra()
        {
            return this.Dta_Compra;
        }

        public DateTime setDta_Compra(DateTime n)
        {
            return this.Dta_Compra = n;
        }

        public Decimal getValor_Total()
        {
            return this.Valor_Total;
        }

        public Decimal setValor_Total(Decimal n)
        {
            return this.Valor_Total = n;
        }

        public CompraClass(DateTime Dta_Compra, Decimal Valor_Total)
        {
            this.Dta_Compra = Dta_Compra;
            this.Valor_Total = Valor_Total;
        }

    }
}
