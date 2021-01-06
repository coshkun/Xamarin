using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using W04T01.Database.Helper;
using SQLite.Net.Platform.XamarinAndroid;
using W04T01.Database.Droid.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace W04T01.Database.Droid.Helper
{
    public class GetDroidConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = System.IO.Path.Combine(documentPath, App.DbName);

            var whatthefuckeveristhis = new SQLitePlatformAndroid();

            SQLiteConnection androConn = new SQLiteConnection(whatthefuckeveristhis, path);
            return androConn;
        }
    }
}