using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Menu_PC_Server.Forms
{
    public partial class NewOrder : Form
    {
        #region Inicializador
        public NewOrder() { InitializeComponent(); }
        #endregion

        #region Variables
        int NoOrder;

        List<Classes.Articulo> ListaArticulos = new List<Classes.Articulo>();
        #endregion

        #region Get Sets
        public int NOORDER { get => NoOrder; set => NoOrder = value; }
        public string CLIENTNAME { get; set; }
        #endregion

        #region UpdateDGV
        private void EventoAnadido(object sender, DataGridViewRowsAddedEventArgs e)
        { UpdateDGV(); }

        void UpdateDGV()
        {
            if (DGV.RowCount < 1)
                MakeOrder_Button.Enabled = false;
            else
                MakeOrder_Button.Enabled = true;
        }

        private void EventoEliminar(object sender, DataGridViewRowsRemovedEventArgs e)
        { UpdateDGV(); }
        #endregion

        #region Agregar artículo.
        /// <summary>
        /// Agregar un artículo al carrito
        /// </summary>
        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ItenName_Combo.Text))
            {
                MessageBox.Show("¡No has elegido un artículo valido!\nDebes de elegir un artículo el cual esté en el inventario", "¡Ocurrió un error leve!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region Agregar a la clase "Artículo"
                Classes.Articulo articulo = new Classes.Articulo();

                articulo.ITEMCUANTITY = int.Parse(Cuantity_Textbox.Text);
                articulo.ITEMNAME = ItenName_Combo.Text;
                articulo.ITEMPRICE = Double.Parse(PriceUnity_Textbox.Text);

                ListaArticulos.Add(articulo);
                #endregion


            #region Agregar al DataGridView
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DGV);

            //ID
            row.Cells[0].Value = DGV.RowCount + 1;

            //Nombre del Artículo
            row.Cells[1].Value = articulo.ITEMNAME;

            //Cantidad
            row.Cells[2].Value = articulo.ITEMCUANTITY;

            //Precio unitario
            row.Cells[3].Value = articulo.ITEMCUANTITY;

            //Precio total
            row.Cells[4].Value = (articulo.ITEMPRICE * articulo.ITEMCUANTITY);

            //Botón eliminar
            row.Cells[5].Value = "Eliminar";

            //Añadiendo Al DGV.
            DGV.Rows.Add(row);
            #endregion
        }
        #endregion

        /// <summary>
        /// Botón para agregar la orden en el DGV de la vista principal
        /// </summary>
        private void MakeOrder_Button_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Código aquí el cual relacionará
            /// la base de datos.
            /// </summary>

            if (String.IsNullOrWhiteSpace(ClientName_Textbox.Text))
            {
                DialogResult NameDialog =
                    MessageBox.Show("El cliente no tiene nombre, ¿Quiere continuar?", "Cliente desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (NameDialog == DialogResult.Yes)
                    CLIENTNAME = "Cliente sin nombre";
                else
                {
                    ClientName_Textbox.Focus();
                    return;
                }
            }
            else
                CLIENTNAME = ClientName_Textbox.Text;

            DialogResult = DialogResult.Yes;
            Close();
        }


        /// <summary>
        /// Botón para salir
        /// </summary>
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult SalirDialog = MessageBox.Show("¿Seguro que desea cancelar este pedido?", "¡Está cancelando el pedido y saliendo de esta ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (SalirDialog == DialogResult.Yes) Close();
        }

        /// <summary>
        /// Botón para crear la orden.
        /// </summary>
        private void NewOrder_Load(object sender, EventArgs e)
        { NoOrder_Label.Text = "Orden #" + (NOORDER + 1); }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5)
                return;

            DGV.Rows.Remove(DGV.Rows[e.RowIndex]);
            ListaArticulos.Remove(ListaArticulos[e.RowIndex]);
        }
    }
}
