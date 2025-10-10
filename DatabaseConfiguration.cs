using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBoto
{
    internal class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
        public DatabaseConfiguration()
        {
            // Update the connection string with your database details
            ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=eBotoDB;Integrated Security=True";
        }
       
    }
}
