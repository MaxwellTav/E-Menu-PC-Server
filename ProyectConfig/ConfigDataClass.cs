using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ProyectConfig
{
    class ConfigDataClass
    {
        #region Variables
        SQLiteConnection Connection = new SQLiteConnection();

        readonly string
            DataBaseName = "ConfigDataBase.db",
            DataBaseVersion = "3";

        List<OutputRead> outputReadsList = new List<OutputRead>();
        #endregion

        #region General Voids
        void OpenConnection()
        {
            Connection = new SQLiteConnection("Data Source = C:\\" + DataBaseName + "; Version = " + DataBaseVersion);
            Connection.Open();
        }

        void CloseConnection()
        { Connection.Close(); }

        void ShowError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHa ocurrido un error grave a la hora de hacer la consulta\n\n" + "Error:\n" + "Código del error:\n" + error.Message + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        #endregion

        #region Insert Into
        public bool InsertInto(string Query)
        {
            try
            {
                OpenConnection();

                DataSet ds = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, Connection);
                adapter.Fill(ds);

                CloseConnection();

                return true;
            }
            catch (Exception error) { ShowError(error); return false; }
        }
        #endregion

        #region Consults
        public bool TestCon()
        {
            try
            { OpenConnection(); CloseConnection(); return true; }
            catch (Exception error) { ShowError(error); return false; }
        }

        void ConsultData(string Query)
        {
            outputReadsList.Clear();
            OpenConnection();

            SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
            SQLiteDataReader Reader = CMD.ExecuteReader();

            while (Reader.Read())
            {
                OutputRead read = new OutputRead();
                read.ID = Reader.GetInt32(0).ToString();
                read.CONFIG = Reader.GetString(1);
                read.VALUE = Reader.GetString(2);

                outputReadsList.Add(read);
            }

            CloseConnection();
        }

        public List<OutputRead> ConsultDataInDB(string Query)
        { ConsultData(Query); return outputReadsList; }
        #endregion
        
        #region Create
        public bool CreateDB()
        {
            try
            {
                if (!System.IO.File.Exists(@"C:\ConfigDataBase.db"))
                {
                    Console.WriteLine("Creando base de datos...");
                    SQLiteConnection.CreateFile(@"C:\ConfigDataBase.db");

                    return true;
                }
                return false;
            }
            catch (Exception error)
            {
                ShowError(error);
                return false;
            }
            
        }
        #endregion

        #region Delete From
        public bool DeleteFrom(string Query)
        {
            try
            {
                using (Connection)
                {
                    OpenConnection();

                    SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
                    CMD.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception error) { ShowError(error); return false; }
        }
        #endregion

        #region Update
        public bool UpdateData(string Query)
        {
            try
            {
                OpenConnection();

                SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
                CMD.CommandText = Query;
                CMD.ExecuteNonQuery();

                CloseConnection();
                return true;
            }
            catch (Exception error)
            {
                ShowError(error);
                return false;
            }
        }
        #endregion

        #region DoCommand
        public bool DoCommand(string Query)
        {
            try
            {
                OpenConnection();

                SQLiteCommand CMD = new SQLiteCommand(Query, Connection);
                CMD.ExecuteNonQuery();

                CloseConnection();
                return true;
            }
            catch (Exception error) { ShowError(error); return false; }
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
}
