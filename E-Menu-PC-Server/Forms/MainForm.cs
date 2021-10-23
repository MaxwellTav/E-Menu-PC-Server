using E_Menu_PC_Server.Classes;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace E_Menu_PC_Server
{
    public partial class MainForm : Form
    {
        #region Inicializador
        public MainForm() { InitializeComponent(); }

        #endregion

        #region Variables
        string currentClientName = "";
        string[] ClientRandomName =
            { "Cliente sin nombre", "Pedro", "Plinio", "Lucas", "Alberto", "José", "Hans", "Rose", "Maxiel", "Natha" };

        int currentNoOrderToDelete = 0,
            currenNoOrder = 0;

        Random RNG = new Random();
        GeneralScript GeneralScript = new GeneralScript();
        DataClass DataClass = new DataClass();

        List<OutputRead> outputReadsList = new List<OutputRead>();
        List<OutputItemReads> outputItemReadsList = new List<OutputItemReads>();
        List<OutputClientOrder> outputClientReadsList = new List<OutputClientOrder>();

        IFirebaseConfig IFC = new FirebaseConfig();
        IFirebaseClient Client;
        #endregion

        /// <summary>
        /// Toma lugar cuando se termina de cargar el formulario.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Location = new Point(0, 0);

            #region Datos estáticos.
            if (GeneralScript.STATICDATA)
            {
                for (int i = 1; i < RNG.Next(6, 20); i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    row.CreateCells(DGV);

                    //No orden
                    row.Cells[0].Value = i.ToString();

                    //Nombre del cliente
                    row.Cells[1].Value = ClientRandomName[RNG.Next(0, ClientRandomName.Length)];

                    //Botón de ver la orden
                    row.Cells[2].Value = "Ver la orden";

                    //Poniendo la data en el DGV
                    DGV.Rows.Add(row);
                }
                return;
            }
            #endregion

            #region Datos NO estáticos.
            outputReadsList = DataClass.OutputList("Select * From ConfigTable", ReadSelection.ConfigTable);
            for (int i = 0; i < outputReadsList.Count; i++)
            {
                switch (outputReadsList[i].CONFIG)
                {
                    case "AuthSecret":
                        Properties.Settings.Default.AuthSecret = outputReadsList[i].VALUE;
                        break;

                    case "BasePath":
                        Properties.Settings.Default.BasePath = outputReadsList[i].VALUE;
                        break;
                }
            }
            Properties.Settings.Default.Save();

            #region Rellenar el DGV con datos guardados
            outputClientReadsList = DataClass.OutputListClient("Select * From OrderTable", ReadSelection.OrderTable);

            for (int i = 0; i < outputClientReadsList.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DGV);

                row.Cells[0].Value = (i + 1);
                row.Cells[1].Value = outputClientReadsList[i].CLIENTNAME;
                row.Cells[2].Value = "Ver la orden";

                DGV.Rows.Add(row);
            }
            #endregion

            #endregion
        }

        /// <summary>
        /// Click a la celda del botón
        /// </summary>
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 2)
                    return;

                currentNoOrderToDelete = int.Parse(DGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                currentClientName = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();

                Forms.OrderViewForm orderViewForm = new Forms.OrderViewForm();
                orderViewForm.NOORDER = currentNoOrderToDelete;
                orderViewForm.CLIENTNAME = currentClientName;

                orderViewForm.ShowDialog();

                if (orderViewForm.DialogResult == DialogResult.OK)
                {
                    DGV.Rows.Remove(DGV.Rows[e.RowIndex]);

                    for (int i = 0; i < DGV.RowCount; i++)
                        DGV.Rows[i].Cells[0].Value = "" + (i + 1);

                    #region Eliminar los artículos
                    DataClass.DeleteFrom("Delete From ItemTable Where ClientName = '" + currentClientName + "'");
                    DataClass.DeleteFrom("Delete From OrderTable Where ClientName = '" + currentClientName + "'");
                    #endregion
                }
            }
            catch { /*MessageBox.Show("Ocurrió un error grave en el sistema\n" + error.Message, "¿Qué pasó aquí? | Error: " + error.HResult,MessageBoxButtons.OK, MessageBoxIcon.Error);*/ }
        }

        #region Event update data
        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        { WentDataIsUpdated(); }

        private void DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        { WentDataIsUpdated(); }

        void WentDataIsUpdated()
        {
            currenNoOrder = int.Parse(DGV.RowCount.ToString());
            NoOrder_Label.Text = "En espera: " + currenNoOrder;
        
            if (currenNoOrder < 1)
            {
                Witing_Panel.Enabled = true;
                Witing_Panel.Visible = true;
            }
            else
            {
                Witing_Panel.Enabled = false;
                Witing_Panel.Visible = false;
            }
        }
        #endregion

        /// <summary>
        /// Abre el formulario para creación de una nueva orden
        /// </summary>
        private void NewOrder_Button_Click(object sender, EventArgs e)
        {
            Forms.NewOrder newOrder = new Forms.NewOrder();
            newOrder.NOORDER = currenNoOrder;
            newOrder.ShowDialog();

            if (newOrder.DialogResult == DialogResult.Yes)
            {
                #region Crear artículo en DataGridView
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(DGV);

                row.Cells[0].Value = currenNoOrder + 1;
                row.Cells[1].Value = newOrder.CLIENTNAME;
                row.Cells[2].Value = "Ver la orden";

                DGV.Rows.Add(row);
                #endregion
            }
        }

        /// <summary>
        /// Boton de salir
        /// </summary>
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult ExitQuestion = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "¡Ateción, está saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); ;

            if (ExitQuestion == DialogResult.Yes)
                Application.Exit();
        }
    }
}
