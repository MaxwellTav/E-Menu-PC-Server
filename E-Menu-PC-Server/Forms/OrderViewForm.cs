using System;
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

        Random RNG = new Random();
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
            for (int i = 0; i < RNG.Next(1, 5); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DGV);

                //ID
                row.Cells[0].Value = i.ToString();

                //Nombre del artículo
                row.Cells[1].Value = StaticProductName[RNG.Next(0, StaticProductName.Length)];

                //Cantidad
                int Cuatity = RNG.Next(1, 10);
                row.Cells[2].Value = Cuatity;

                //Precio (unitario)
                Double UnitPrice = RNG.Next(50, 500);
                row.Cells[3].Value = UnitPrice;

                //Precio (total)
                row.Cells[4].Value = (Cuatity * UnitPrice).ToString();

                //Agregando toda la info
                DGV.Rows.Add(row);
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
    }
}
