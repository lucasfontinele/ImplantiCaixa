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
        private static readonly MongoClient _mongoClient = new MongoClient(myIni.Read("DatabaseUrl", "Mongo"));

        // MySQL        
        private static readonly String _address = myIni.Read("Address", "MySQL");
        private static readonly String _user = myIni.Read("User", "MySQL");
        private static readonly String _password = myIni.Read("Password", "MySQL");
        private static readonly String _database = myIni.Read("Database", "MySQL");
        private static readonly uint _port = Convert.ToUInt32(myIni.Read("Port", "MySQL"));


        private static readonly MySqlBaseConnectionStringBuilder _strBuilder = new MySqlConnectionStringBuilder
        {
            Server   = _address,
            UserID   = _user,
            Password = _password,
            Database = _database,
            Port     = _port
        };

        private static readonly MySqlConnection _mySqlClient = new MySqlConnection(_strBuilder.ToString());

        // Return Connections
        public static MongoClient MongoClient() => _mongoClient;
        public static MySqlConnection MySqlConnection() => _mySqlClient;
    }
}