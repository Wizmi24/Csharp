using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_32._1
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
        {
            if (!String.IsNullOrWhiteSpace(connectionString))
                this.ConnectionString = connectionString;
            else throw new InvalidCastException("You cannot supply empty string");
        }

        public override void Connect()
        {
            Console.WriteLine("Connecting to oracle base");
            this.EstablishingConnection = DateTime.Now;
            if ((DateTime.Now - EstablishingConnection) < Timeout)
                Console.WriteLine("Connection to oracle base estabilished in " + (DateTime.Now - EstablishingConnection).TotalSeconds + "s");
            else throw new InvalidCastException("Connection to oracle base cannot be estabilished");
        }

        public override void Close()
        {
            Console.WriteLine("Closing connection to oracle Base");
        }
    }
}
