using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_32._1
{
    class DbCommand
    {
        public DbCommand(string command)
        {
            var sqlConnection = new SqlConnection("yo");
            sqlConnection.Connect();
            Console.WriteLine($"Executing command: {command}");
            Console.WriteLine("Command executed");
            sqlConnection.Close();
        }
    }
}
