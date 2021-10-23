using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace E_Menu_PC_Server.Classes
{
    class DataClass
    {
        #region Variables
        SQLiteConnection Connection = new SQLiteConnection();

        readonly string
            DataBaseName = "ConfigDataBase.db",
            DataBaseVersion = "3";

        List<OutputRead> outputReadsList = new List<OutputRead>();
        List<OutputItemReads> outputItemReadsList = new List<OutputItemReads>();
        List<OutputClientOrder> outputClientReadsList = new List<OutputClientOrder>();

        GeneralScript GeneralScript = new GeneralScript();
        #endregion

        #region General Voids
        void OpenConnection()
        {
            Connection = new SQLiteConnection("Data Source = C:\\" + DataBaseName + "; Version = " + DataBaseVersion);
            Connection.Open();
        }

        void CloseConnection()
        { Connection.Close(); }
        #endregion

        #region DataRead
        void ReadData(string Query, ReadSelection selection)
        {
            OpenConnection();

            SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
            SQLiteDataReader Reader = CMD.ExecuteReader();

            switch (selection)
            {
                #region Datos de configuraciones
                case ReadSelection.ConfigTable:
                    outputReadsList.Clear();
                    while (Reader.Read())
                    {

                        OutputRead read = new OutputRead();
                        read.ID = Reader.GetInt32(0).ToString();
                        read.CONFIG = Reader.GetString(1);
                        read.VALUE = Reader.GetString(2);

                        outputReadsList.Add(read);
                    }
                    break;
                #endregion

                #region Datos de los artículos pedidos
                case ReadSelection.ItemTable:
                    outputItemReadsList.Clear();

                    while (Reader.Read())
                    {
                        OutputItemReads read = new OutputItemReads();

                        read.ITEMNAME = Reader.GetString(2);
                        read.ITEMCUANTITY = Reader.GetValue(3).ToString();
                        read.ITEMPRICE = Reader.GetValue(4).ToString();
                        read.ITEMPRICETOTAL = Reader.GetValue(5).ToString();

                        outputItemReadsList.Add(read);
                    }
                    break;
                #endregion

                #region Datos de los nombres de los clientes anteriores
                case ReadSelection.OrderTable:
                    outputClientReadsList.Clear();

                    while (Reader.Read())
                    {
                        OutputClientOrder read = new OutputClientOrder();

                        read.CLIENTNAME = Reader.GetString(1);

                        outputClientReadsList.Add(read);
                    }
                    break;
                    #endregion
            }

            CloseConnection();
        }

        public List<OutputRead> OutputList(string Query, ReadSelection selection)
        { ReadData(Query, selection); return outputReadsList; }

        public List<OutputItemReads> OutputListItem(string Query, ReadSelection selection)
        { ReadData(Query, selection); return outputItemReadsList; }

        public List<OutputClientOrder> OutputListClient(string Query, ReadSelection selection)
        { ReadData(Query, selection); return outputClientReadsList; }

        #endregion

        #region Insert Into
        public bool InsertInto(string Query)
        {
            try
            {
                OpenConnection();

                DataSet DS = new DataSet();
                SQLiteDataAdapter Adapter = new SQLiteDataAdapter(Query, Connection);
                Adapter.Fill(DS);

                CloseConnection();
                return true;
            }
            catch (Exception error) { GeneralScript.ShowError(error); return false; }
        }
        #endregion

        #region Delete From
        public void DeleteFrom(string Query)
        {
            try
            {
                using (Connection)
                {
                    OpenConnection();

                    SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
                    CMD.ExecuteNonQuery();
                }
                CloseConnection();
            }
            catch (Exception error) { GeneralScript.ShowError(error); }
        }
        #endregion
    }

    public class OutputRead
    {
        string
            id = "",
            config = "",
            _value = "";

        //------------ Get - Sets ------------\\
        public string ID { get => id; set => id = value; }
        public string CONFIG { get => config; set => config = value; }
        public string VALUE { get => _value; set => _value = value; }
    }

    public class OutputItemReads
    {
        string ItemName = "";

        string ItemCuantity = "";

        string
            ItemPrice = "",
            ItemPrice_T = "";

        #region Get Sets
        public string ITEMNAME { get => ItemName; set => ItemName = value; }
        public string ITEMCUANTITY { get => ItemCuantity; set => ItemCuantity = value; }
        public string ITEMPRICE { get => ItemPrice; set => ItemPrice = value; }
        public string ITEMPRICETOTAL { get => ItemPrice_T; set => ItemPrice_T = value; }
        #endregion
    }

    public class OutputClientOrder
    {
        string ClientName = "";

        public string CLIENTNAME { get => ClientName; set => ClientName = value; }
    }
}
public enum ReadSelection
{
    ConfigTable,
    ItemTable,
    OrderTable
}