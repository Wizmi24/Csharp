using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_32._1
{
    public abstract class DbConnection
    {
        protected string ConnectionString;
        protected TimeSpan Timeout = TimeSpan.FromSeconds(10);
        protected DateTime EstablishingConnection;

        public abstract void Connect();

        public abstract void Close();

    }
}
