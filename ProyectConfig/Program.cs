using System;
using System.Collections.Generic;

namespace ProyectConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string
                User = "Admiñ+",
                Pass = "1234";

            List<OutputRead> outputReadsList = new List<OutputRead>();

            string Comandos =
                @"1. \Help = Comando para obtener ayuda" + "\n" +
                @"2. \UpdateData = Comando para cambiar algún dato en la base de datos" + "\n" +
                @"3. \CreateItem = Comando para cambiar el código BasePath que dirige a Firebase" + "\n" +
                @"4. \ClearScreen = Limpia la pantalla" + "\n" +
                @"5. \CreateNewConfig = Comando para crear una nueva configuración en la base de datos" + "\n" +
                @"6. \Exit = Comando para salir de la aplicación" + "\n" +
                @"7. \FactoryReset = Comando borrar todos los datos de la base de datos" + "\n" +
                @"8. \TestCon = Comando para comprobar la conexión de la aplicación" + "\n" +
                @"9. \LockApp = Comando para bloquear la aplicación" + "\n" +
                @"10. \JesusChristITrustInYou = Comando para bloquear la aplicación" + "\n" +
                @"11. \CreateDB  = Comando para bloquear la aplicación" + "\n" +
                @"12. \UseStaticData  = Comando para saber si la aplicación usará datos estáticos y/o de puebas." + "\n" +
                @"13. \ConsultAllData  = Comando para listar todas las configuraciones actuales de la base de datos." + "\n" +
                "";

            ConfigDataClass dataClass = new ConfigDataClass();
            #endregion

            Console.SetWindowSize((Console.LargestWindowWidth - 10), (Console.LargestWindowHeight - 5));
            Console.SetWindowPosition(0, 0);

            if (LockApp())
            { return; }

            Console.WriteLine("\n¡Bienvenido!\n");
            Wait4Intruction();

            void Wait4Intruction()
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("¿Qué desea hacer? \"\\Help\" Para ayuda (puede escribir el número directamente)\n");
                string Instruction = Console.ReadLine();

                switch (Instruction)
                {
                    #region Eater Eggs
                    case @"\I Love You":
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < 69; i++)
                            for (int ij = 0; ij < 100; ij++)
                                Console.Write("♥");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n");
                        break;
                    #endregion

                    #region 1. Help
                    case @"\Help":
                    case "1":
                        Console.WriteLine(Comandos);
                        break;
                    #endregion

                    #region 2 SetFireBaseAuthSecret
                    case @"\UpdateData":
                    case "2":
                        try
                        {
                            Console.WriteLine("Inserte la nueva Configuración (ConfigName, ConfigValue)");
                            Console.WriteLine("\n\nEjemplo:\nUpdate ConfigTable Set ConfigValue = 'Nuevo valor' Where ConfigName = 'Nombre de la configuración'\n");

                            Instruction = Console.ReadLine();

                            if (dataClass.UpdateData(Instruction))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n¡La configuración de \"AuthSecret\" fue actualizada con éxito!\n\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        catch { }
                        break;
                    #endregion

                    #region 3 CreateItem
                    case @"\CreateItem":
                    case "3":
                        NotCreatedCommand();
                        break;
                    #endregion

                    #region 4. ClearScreen
                    case @"\ClearScreen":
                    case @"4":
                        ClearWindows();
                        break;
                    #endregion

                    #region 5. Crear Nueva Configuración
                    case @"\CreateNewConfig":
                    case @"5":
                        Console.WriteLine("Inserte la nueva Configuración (ConfigName, ConfigValue)");
                        Console.WriteLine("\n\nEjemplo:\nInsert Into ConfigTable (ConfigName, ConfigValue) Values ('Nombre_De_La_Configuración', 'Valor_De_La_Configuración')\n");
                        Instruction = Console.ReadLine();

                        if (dataClass.InsertInto(Instruction))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n¡La configuración fue creada con éxito!\n\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    #endregion

                    #region 6. Salir
                    case @"\Exit":
                    case @"6":
                        ClearWindows();
                        Console.WriteLine("¿Está seguro que desea salir de la aplicación?\nSi = Salir\nEnter = No salir");
                        Instruction = Console.ReadLine();

                        if (Instruction == "Si")
                            Environment.Exit(0);
                        else
                            Console.WriteLine("Ha cancelado la salida de la consola");
                        break;
                    #endregion

                    #region 7. FactoryReset
                    case @"\FactoryReset":
                    case "7":
                        ClearWindows();
                        Console.WriteLine("¿Está seguro que desea borrar todos los datos de la aplicación?\nSi = BORRAR TODOS LOS DATOS\nEnter = No borrar los datos");
                        Instruction = Console.ReadLine();

                        if (Instruction == "Si")
                        {
                            if (dataClass.DeleteFrom("Drop Table ConfigTable"))
                            {
                                dataClass.DoCommand("CREATE TABLE \"ConfigTable\" (\"ID\"	INTEGER NOT NULL UNIQUE, \"ConfigName\"	TEXT NOT NULL UNIQUE, \"ConfigValue\"	TEXT NOT NULL, PRIMARY KEY(\"ID\" AUTOINCREMENT));");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n¡La configuración fue completamente borrada con éxito!\n\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ha cancelado la eliminación del programa");
                        }
                        break;
                    #endregion

                    #region 8. Probar Conexión
                    case @"\TestCon":
                    case "8":
                        if (dataClass.TestCon())
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n¡La base de datos está conectada!\n\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    #endregion

                    #region 9. LockApp
                    case @"\LockApp":
                    case "9":
                        if (LockApp())
                        { Environment.Exit(0); }
                        break;
                    #endregion

                    #region 10. En ti confio
                    case @"\JesusChristITrustInYou":
                    case "10":
                        JesusIThrustInYou();
                        break;
                    #endregion

                    #region 11. CreateDB
                    case @"\CreateDB":
                    case "11":
                        if (dataClass.CreateDB())
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n¡La base de datos está creada!\n\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo se pudo crear la base de datos, debido a que ya existía una u ocurrió un error en el sistema\n\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    #endregion

                    #region 12. UseStaticData
                    case @"\UseStaticData":
                    case "12":
                        NotCreatedCommand();
                        break;
                    #endregion

                    #region 13. ConsultAllData
                    case @"\ConsultAllData":
                    case "13":
                        outputReadsList.Clear();
                        outputReadsList = dataClass.ConsultDataInDB("Select * From ConfigTable");

                        for (int i = 0; i < outputReadsList.Count; i++)
                        {
                            Console.WriteLine("\n--------------------------------------------\n");
                            Console.WriteLine("       ID:      " + outputReadsList[i].ID);
                            Console.WriteLine(" Configuración: " + outputReadsList[i].CONFIG);
                            Console.WriteLine("     Valor:     " + outputReadsList[i].VALUE + "\n");
                        }
                        break;
                    #endregion

                    #region PlaceHolderCommand
                    //case @"HolderCommand":
                    //case "#":

                    //    break;
                    #endregion

                    #region Si nada es aplicable
                    default:
                        Console.WriteLine("¡El comando \"" + Instruction + "\" no está disponible!, o no lo ha escrito correctamente,\nAsegurese de que respete las mayusculas y escriba el \"\\\" antes de algunos comandos\n");
                        break;
                        #endregion
                }

                Wait4Intruction();
            }

            void JesusIThrustInYou()
            { NotCreatedCommand(); }

            bool LockApp()
            {
                string
                    user,
                    pass;

                user = "";
                pass = "";

                ClearWindows();

                #region Login Desing
                Console.WriteLine("#########Login#########");
                Console.WriteLine("#       Usuario       #");
                Console.WriteLine("#       _______       #");
                Console.WriteLine("#      Contraseña     #");
                Console.WriteLine("#      __________     #");
                Console.WriteLine("=======================");
                user = Console.ReadLine();
                ClearWindows();

                Console.WriteLine("#########Login#########");
                Console.WriteLine("#       Usuario       #");
                Console.WriteLine("#       *******       #");
                Console.WriteLine("#      Contraseña     #");
                Console.WriteLine("#      __________     #");
                Console.WriteLine("=======================");
                pass = Console.ReadLine();
                ClearWindows();

                Console.WriteLine("#########Login#########");
                Console.WriteLine("#       Usuario       #");
                Console.WriteLine("#       *******       #");
                Console.WriteLine("#      Contraseña     #");
                Console.WriteLine("#      **********     #");
                Console.WriteLine("=======================");

                Console.ForegroundColor = ConsoleColor.Green;
                #endregion

                if (user == User && pass == Pass)
                    return false;

                return true;
            }

            void ClearWindows()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine(@" █████╗ ██████╗ ███╗   ███╗██╗███╗   ██╗     ██████╗ ██████╗ ███╗   ███╗███╗   ███╗ █████╗ ███╗   ██╗██████╗     ██╗     ██╗███╗   ██╗███████╗");
                Console.WriteLine(@"██╔══██╗██╔══██╗████╗ ████║██║████╗  ██║    ██╔════╝██╔═══██╗████╗ ████║████╗ ████║██╔══██╗████╗  ██║██╔══██╗    ██║     ██║████╗  ██║██╔════╝");
                Console.WriteLine(@"███████║██║  ██║██╔████╔██║██║██╔██╗ ██║    ██║     ██║   ██║██╔████╔██║██╔████╔██║███████║██╔██╗ ██║██║  ██║    ██║     ██║██╔██╗ ██║█████╗  ");
                Console.WriteLine(@"██╔══██║██║  ██║██║╚██╔╝██║██║██║╚██╗██║    ██║     ██║   ██║██║╚██╔╝██║██║╚██╔╝██║██╔══██║██║╚██╗██║██║  ██║    ██║     ██║██║╚██╗██║██╔══╝  ");
                Console.WriteLine(@"██║  ██║██████╔╝██║ ╚═╝ ██║██║██║ ╚████║    ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║██║  ██║██║ ╚████║██████╔╝    ███████╗██║██║ ╚████║███████╗");
                Console.WriteLine(@"╚═╝  ╚═╝╚═════╝ ╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝     ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝     ╚══════╝╚═╝╚═╝  ╚═══╝╚══════╝");

                Console.WriteLine("************************************************************************************************************");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            void NotCreatedCommand()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("************************************************************************************************************");

                Console.WriteLine("\nExcepción no programada o controlada, próximamente estará disponible.\n");

                Console.WriteLine("************************************************************************************************************");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
