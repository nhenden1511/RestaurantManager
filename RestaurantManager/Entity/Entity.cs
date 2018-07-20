using System;
using SQLite.Net.Attributes;

namespace RestaurantManager
{
    public abstract class Entity : IDisposable
    {
        bool disposed = false;
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsDelete { get; set; }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
            }

            // Free any unmanaged objects here. 
            disposed = true;
        }

        ~Entity()
        {
            Dispose(false);
        }

        public virtual Entity Copy()
        {
            return (Entity)MemberwiseClone();
        }
    }
}
