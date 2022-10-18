using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cwiczenie_32._1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
        {
            if (!String.IsNullOrWhiteSpace(connectionString))
                this.ConnectionString = connectionString;
            else throw new InvalidCastException("You cannot supply empty string");
        }

        public override void Connect()
        {
            Console.WriteLine("Connecting to sql base");
            this.EstablishingConnection = DateTime.Now;            
            if ((DateTime.Now - EstablishingConnection) < Timeout)
                Console.WriteLine("Connection to sql base estabilished in " + (DateTime.Now - EstablishingConnection).TotalSeconds + "s");
            else throw new InvalidCastException("Connection to sql base cannot be estabilished");
        }

        public override void Close()
        {
            Console.WriteLine("Closing connection to sql Base");
        }
    }
}
