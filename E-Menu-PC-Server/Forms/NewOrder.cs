using System;
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
        #endregion

        #region Get Sets
        public int NOORDER { get => NoOrder; set => NoOrder = value; }
        #endregion

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult SalirDialog = MessageBox.Show("¿Seguro que desea cancelar este pedido?", "¡Está cancelando el pedido y saliendo de esta ventana!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (SalirDialog == DialogResult.Yes) Close();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        { NoOrder_Label.Text = "Orden #" + (NOORDER + 1); }

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
    }
}
