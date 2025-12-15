/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        Program.cs
 * Author:      JustDrven
 * 
 *******************************************/


using praxe_desktop_client.Reader;

namespace praxe_desktop_client
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ConfigHandler.Instance().AddConfig("configs\\produkty.dat", "Produkty");
            ConfigHandler.Instance().AddConfig("configs\\objednavky.dat", "Objednavky");

            ConfigHandler.Instance().LoadConfigs();
            





            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}