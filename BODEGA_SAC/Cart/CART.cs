using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BODEGA_SAC.Cart
{
    public class CART
    {
        public int ID_PRODUCT { get; set; }
        public int CODIGO { get; set; }
        public string PRODUCTO { get; set; }
        public decimal PRECIO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal SUB_TOTAL { get; set; }
    }
}
