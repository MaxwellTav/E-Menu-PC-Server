using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;

namespace E_Menu_PC_Server.Classes
{
    class NetData
    {
        #region Variables
        GeneralScript GeneralScript = new GeneralScript();

        IFirebaseConfig IFC = new FirebaseConfig();
        IFirebaseClient Client;

        List<Articulo> articulos = new List<Articulo>();
        #endregion

        /// <summary>
        /// Evento que le da la configuración base para poder funcionar.
        /// </summary>
        private void SetNetConfig()
        {
            IFC = new FirebaseConfig()
            {
                AuthSecret = Properties.Settings.Default.AuthSecret,
                BasePath = Properties.Settings.Default.BasePath,
            };
            Client = new FireSharp.FirebaseClient(IFC);

        }

        public void SendData(string ClientName, int i, Articulo Data)
        {
            SetNetConfig();

            #region Insertar datos en la RED
            try
            { var setClient = Client.Set("Orders/" + ClientName + "/" + i, Data); }
            catch (Exception error) { GeneralScript.ShowError(error); }
            #endregion
        }
    }
}
