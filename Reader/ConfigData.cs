/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        ConfigData.cs
 * Author:      JustDrven
 * 
 *******************************************/

namespace praxe_desktop_client.Reader
{
    internal class ConfigData
    {

        private readonly string _dbName;
        private readonly bool _trustServerCertificate;
        private readonly bool _encrypt;

        public ConfigData(string dbName, bool trustServerCertificate, bool encrypt)
        {
            _dbName = dbName;
            _trustServerCertificate = trustServerCertificate;
            _encrypt = encrypt;
        }

        public string GetDbName()
        {
            return _dbName;
        }


        public bool IsTrustServerCertificate()
        {
            return _trustServerCertificate;
        }


        public bool IsEncrypt()
        {
            return _encrypt;
        }

    }
}
