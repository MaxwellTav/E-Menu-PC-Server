using System;
using System.Windows.Forms;

namespace E_Menu_PC_Server.Classes
{
    class GeneralScript
    {
        bool StaticData = false;

        public bool STATICDATA { get => StaticData; set => StaticData = value; }

        public void ShowError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHa ocurrido un error grave a la hora de hacer la consulta\nError: " + error.Message, "Código del error:\n" + error.HResult + "\n");
            Console.ForegroundColor = ConsoleColor.Green;

            MessageBox.Show("\nHa ocurrido un error grave a la hora de hacer la consulta\nError: " + error.Message, "Código del error:\n" + error.HResult + "\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
