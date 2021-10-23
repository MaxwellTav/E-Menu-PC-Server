using E_Menu_PC_Server.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Menu_PC_Server.Forms
{
    public partial class OrderViewForm : Form
    {
        #region Inicializador
        public OrderViewForm() { InitializeComponent(); }
        #endregion

        #region Variables
        int noorder = 0;

        string clientname = "";
        string[] StaticProductName =
            {"Pan con huevo",
            "Jugo de limón",
            "Tostada",
            "Yaroa",
            "Masita",
            "Jugo de uva",
            "100% natural",
            "Café",
            "Bebida energética"};
        List<OutputRead> outputReads = new List<OutputRead>();
        List<OutputItemReads> outputItemReads = new List<OutputItemReads>();

        Random RNG = new Random();
        GeneralScript generalScript = new GeneralScript();
        DataClass dataClass = new DataClass();
        #endregion

        #region Get Sets
        public int NOORDER { get => noorder; set => noorder = value; }
        public string CLIENTNAME { get => clientname; set => clientname = value; }
        #endregion

        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            ClientName_Label.Text = "Cliente\n" + CLIENTNAME;
            NoOrder_Label.Text = "Orden #" + NOORDER;

            #region Datos estáticos.
            if (generalScript.STATICDATA)
            {
                for (int i = 0; i < RNG.Next(1, 5); i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DGV);

                    //Nombre del artículo
                    row.Cells[0].Value = StaticProductName[RNG.Next(0, StaticProductName.Length)];

                    //Cantidad
                    int Cuatity = RNG.Next(1, 10);
                    row.Cells[1].Value = Cuatity;

                    //Precio (unitario)
                    Double UnitPrice = RNG.Next(50, 500);
                    row.Cells[2].Value = UnitPrice;

                    //Precio (total)
                    row.Cells[3].Value = (Cuatity * UnitPrice).ToString();

                    //Agregando toda la info
                    DGV.Rows.Add(row);
                }
            }
            #endregion

            #region Datos normales.
            else
            {
                outputItemReads = dataClass.OutputListItem("Select * From ItemTable Where ClientName = '" + CLIENTNAME + "'", ReadSelection.ItemTable);

                for (int i = 0; i < outputItemReads.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DGV);

                    row.Cells[0].Value = outputItemReads[i].ITEMNAME;
                    row.Cells[1].Value = outputItemReads[i].ITEMCUANTITY;
                    row.Cells[2].Value = outputItemReads[i].ITEMPRICE;
                    row.Cells[3].Value = outputItemReads[i].ITEMPRICETOTAL;

                    DGV.Rows.Add(row);
                }
            }
            #endregion
        }

        /// <summary>
        /// Botón que cancela y cierra el panel
        /// </summary>
        private void Cancel_Button_Click(object sender, EventArgs e)
        { Close(); }

        /// <summary>
        /// Botón para obrar y aplicar el pago del artículo.
        /// </summary>
        private void Invoice_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show("¡Compra realizada con éxito!", "¡Todo bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        /// <summary>
        /// Botón el cual cancela y elimina el pedido del programa y la base de datos.
        /// </summary>
        private void CancelOrder_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este pedido de la bandeja de espera?", "¡ESTÁ ELIMINANDO UNA ORDEN!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
