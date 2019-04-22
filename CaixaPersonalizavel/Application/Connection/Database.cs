using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaPersonalizavel.Application.Util;
using MongoDB.Driver;
using MySql.Data.MySqlClient;

namespace CaixaPersonalizavel.Application.Connection
{
    class Database
    {
        private static IniFileHandler myIni = new IniFileHandler("Settings.ini");

        // MongoDB
        private static readonly MongoClient MongoClient = new MongoClient("mongodb://root:%7CcSFu%405rFv%23h8*%3D@localhost:12220/admin?readPreference=primary");
        //private static readonly MongoClient MongoClient = new MongoClient(myIni.Read("DatabaseUrl", "Mongo"));

        // MySQL        
        private static readonly String Address = myIni.Read("Address", "MySQL");
        private static readonly String User = myIni.Read("User", "MySQL");
        private static readonly String Password = myIni.Read("Password", "MySQL");
        private static readonly String Data = myIni.Read("Database", "MySQL");
        //private static readonly uint Port = Convert.ToUInt32(myIni.Read("Port", "MySQL"));


        private static readonly MySqlBaseConnectionStringBuilder _strBuilder = new MySqlConnectionStringBuilder
        {
            Server   = Address,
            UserID   = User,
            Password = Password,
            Database = Data,
            //Port = Port
        };

        private static readonly MySqlConnection MySqlClient = new MySqlConnection(_strBuilder.ToString());

        // Return Connections
        public static MongoClient MongoConnection() => MongoClient;
        public static MySqlConnection MySqlConnection() => MySqlClient;        
    }
}