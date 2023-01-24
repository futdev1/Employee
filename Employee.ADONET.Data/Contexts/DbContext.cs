using Employee.Domain.Customs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ADONET.Data.Contexts
{
    public class DbContext
    {
        private NpgsqlConnection connection;

        public DbContext()
        {
            connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
            connection.Open();
        }
    }
}
