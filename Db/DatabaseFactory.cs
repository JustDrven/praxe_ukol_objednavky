/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        DatabaseFactory.cs
 * Author:      JustDrven
 * 
 *******************************************/


using Microsoft.Data.SqlClient;
using praxe_desktop_client.Reader;

namespace praxe_desktop_client.Db
{
    internal class DatabaseFactory
    {


        private static SqlConnection CreateConnectionFromConfig(ConfigData config)
        {

            string dbConfigString = string.Format(
                "Data Source=bleksql2;Initial Catalog={0};Integrated Security=True; TrustServerCertificate={1}; Encrypt={2}",
            
              
                config.GetDbName(),
                config.IsTrustServerCertificate(),
                config.IsEncrypt()
            );


            return new SqlConnection(dbConfigString);
        
        }

        public static SqlConnection CreateConnection(string configIndentifier)
        {
            return CreateConnectionFromConfig(
                ConfigHandler.Instance().GetConfig(configIndentifier)
            );
        }

    }
}
