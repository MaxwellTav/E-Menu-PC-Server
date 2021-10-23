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
        string CLIENTNAME { get => ClientName; set => ClientName = value; }
        public List<Articulo> ARTICULOS { get => Item; set => Item = value; }
        #endregion
    }

    public class Articulo
    {
        string ItemName = null;
        int ItemCuantity = 0;
        Double ItemPrice = 0;
        Double ItemPrice_T = 0;

        #region Get Sets
        public string ITEMNAME { get => ItemName; set => ItemName = value; }
        public int ITEMCUANTITY { get => ItemCuantity; set => ItemCuantity = value; }
        public Double ITEMPRICE { get => ItemPrice; set => ItemPrice = value; }
        public Double ITEMPRICETOTAL { get => ItemPrice_T; set => ItemPrice_T = value; }
        #endregion
    }
}