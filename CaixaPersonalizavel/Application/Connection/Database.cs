using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaPersonalizavel.Application.Util;
using MongoDB.Driver;

namespace CaixaPersonalizavel.Application.Connection
{
    class Database
    {
        private static IniFileHandler myIni = new IniFileHandler("Settings.ini");
        private static readonly MongoClient _client = new MongoClient(myIni.Read("DatabaseUrl", "Settings"));

        public static MongoClient MongoClient() => _client;



    }
}