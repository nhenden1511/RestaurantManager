using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using System.Reflection;
using TypeConverter;
using SQLite.Net.Interop;

namespace RestaurantManager
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity, new()
    {
        protected IList<PropertyInfo> LanguageProperties;
        protected ISQLitePlatform platform;
        protected string TableName;

        protected SQLiteConnection NewConnection()
        {
            return new SQLiteConnection(DbInitialization.Platform, DbInitialization.DbPath);
        }

        public BaseRepository()
        {
            LanguageProperties = new List<PropertyInfo>();
            var properties = typeof(T).GetRuntimeProperties();
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    db.CreateTable<T>();
                }
            }
        }

        public int CreateTable()
        {
            return 1;
        }
        public virtual IList<T> GetAll(int skip = 0, int take = 0)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var query = from c in db.Table<T>()
                                select c;
                    //if (skip != 0)
                    //    return db.Table<T>().Skip(skip).Take(take).ToList();
                    return query.ToList();
                }
            }
        }
        public virtual T GetById(int id)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Table<T>().Where(p => p.Id == id).FirstOrDefault();
                }
            }
        }
        public TU ExecuteScalar<TU>(string cmdText, params object[] args)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var contentTrigger = db.CreateCommand(cmdText, args);
                    return contentTrigger.ExecuteScalar<TU>();
                }
            }
        }

        public IList<TU> ExecuteQuery<TU>(string cmdText, params object[] args)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var contentTrigger = db.CreateCommand(cmdText, args);
                    return contentTrigger.ExecuteQuery<TU>();
                }
            }
        }

        public int Update<TU>(TU o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Update(o);
                }
            }
        }

        public int UpdateAll<TU>(IList<TU> o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.UpdateAll(o);
                }
            }
        }

        public virtual int InsertAll<TU>(IList<TU> o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertAll(o);
                }
            }
        }

        public virtual int InsertOrReplace<TU>(TU o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertOrReplace(o);
                }
            }
        }

        public virtual int InsertOrReplaceAll<TU>(IList<TU> o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertOrReplaceAll(o);
                }
            }
        }

        public int Delete<TU>(TU o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Delete(o);
                }
            }
        }

        public int DeleteAll<TU>()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.DeleteAll<TU>();
                }
            }
        }

        public virtual int ExecuteNonQuery(string cmdText, params object[] args)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var contentTrigger = db.CreateCommand(cmdText, args);
                    return contentTrigger.ExecuteNonQuery();
                }
            }
        }

        public virtual T ExecuteScalar(string cmdText, params object[] args)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var contentTrigger = db.CreateCommand(cmdText, args);
                    return contentTrigger.ExecuteScalar<T>();
                }
            }
        }

        public virtual IList<T> ExecuteQuery(string cmdText, params object[] args)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var contentTrigger = db.CreateCommand(cmdText, args);
                    return contentTrigger.ExecuteQuery<T>();
                }
            }
        }

        public virtual int Update(T o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Update(o);
                }
            }
        }

        public virtual int Insert(T o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Insert(o);
                }
            }
        }

        public virtual int Insert<U>(U o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Insert(o);
                }
            }
        }

        public virtual int UpdateAll(IList<T> os)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.UpdateAll(os);
                }
            }
        }

        public virtual int InsertAll(IList<T> os)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertAll(os);
                }
            }
        }

        public virtual int InsertOrReplaceAll(IList<T> os)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertOrReplaceAll(os);
                }
            }
        }

        public virtual int InsertOrReplace(T o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.InsertOrReplace(o);
                }
            }
        }

        public virtual int Delete(T o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Delete(o);
                }
            }
        }

        public virtual int DeleteAll()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.DeleteAll<T>();
                }
            }
        }

    }
}
