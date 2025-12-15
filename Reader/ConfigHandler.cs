/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        ConfigHandler.cs
 * Author:      JustDrvens
 * 
 *******************************************/

using praxe_desktop_client.Utilities;

namespace praxe_desktop_client.Reader
{
    internal class ConfigHandler
    {

        private static readonly string Sep = "=";
        private static ConfigHandler? instance;

        public static ConfigHandler Instance()
        {
            if (instance == null)
            {
                instance = new ConfigHandler();
            }

            return instance;
        }



        private readonly Dictionary<string, string> _configNames;
        private readonly Dictionary<string, ConfigData> _configs;

        private ConfigHandler()
        {
            _configNames = [];
            _configs = [];
        }



        public void AddConfig(string configName, string configIdentifier)
        {
            _configNames.Add(configName, configIdentifier);
        }




        public void LoadConfigs()
        {

            UtilList.ClearMap(_configs);




            foreach (var config in _configNames)
            {
                string configName = config.Key.Trim();
                string configIdentifier = config.Value.Trim();


                string dbName = "unknown";
                bool trustServerCertificate = false;
                bool encrypt = false;


                var lines = File.ReadAllLines(configName);

                foreach (var line in lines)
                {

                    if (string.IsNullOrEmpty(line)) continue;
                    if (!line.Contains(Sep)) continue;



                    var data = line.Split(Sep, 2);
                    string key = data[0].Trim().ToLower();
                    string value = data[1].Trim();


                    if (key.Equals("db"))
                        dbName = value;

                    if (key.Equals("trustservercertificate"))
                        trustServerCertificate = bool.Parse(value);

                    if (key.Equals("encrypt"))
                        encrypt = bool.Parse(value);


                }


                _configs.Add(configIdentifier, new ConfigData(
                    dbName,
                    trustServerCertificate,
                    encrypt
                ));


            }
        }


        public ConfigData GetConfig(string configIdentifier)
        {
            return _configs[configIdentifier];
        }


    }
}
