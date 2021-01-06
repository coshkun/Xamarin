using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W04T01.Database.Model;
using Xamarin.Forms;

namespace W04T01.Database.Helper
{
    public class SQLiteManager : IDisposable
    {
        SQLiteConnection conn;

        public SQLiteManager()
        {
            conn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            conn.CreateTable<Student>();
        }
        #region CRUD
        public int Insert(Student s)
        { return conn.Insert(s); }
        public int Update(Student s)
        { return conn.Update(s); }
        public int Delete(int Id)
        { return conn.Delete<Student>(Id); }
        public List<Student> GetAll()
        { return conn.Table<Student>().ToList(); }
        public Student Get(int Id)
        { return conn.Table<Student>().FirstOrDefault(s => s.Id == Id); }
        public void Dispose()
        { conn.Dispose(); }
        #endregion
    }
}
