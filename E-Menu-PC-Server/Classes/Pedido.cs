using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Menu_PC_Server.Classes
{
    class Pedido
    {
        string ClientName = null;
        List<Articulo> Item = new List<Articulo>();

        #region Get Sets
        public string CLIENTNAME { get => ClientName; set => ClientName = value; }
        public List<Articulo> ARTICULOS { get => Item; set => Item = value; }
        #endregion
    }

    class Articulo
    {
        string ItemName = null;
        Double ItemPrice = 0;
        int ItemCuantity = 0;

        #region Get Sets
        public string ITEMNAME { get => ItemName; set => ItemName = value; }
        public Double ITEMPRICE { get => ItemPrice; set => ItemPrice = value; }
        public int ITEMCUANTITY { get => ItemCuantity; set => ItemCuantity = value; }
        #endregion
    }
}
