using System;
using SQLite.Net;
using W04T01.Database.Helper;
using SQLite.Net.Platform.XamarinIOS;
using W04T01.Database.iOS.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(GetIOSConnection))]
namespace W04T01.Database.iOS.Helper
{
    public class GetIOSConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();

            var ioConn = new SQLiteConnection(platform, path);
            return ioConn;
        }
    }
}