using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.Infrastracture.SqlServer
{
    public class SqlServerHelper
    {
        internal static string ConnectionString { get; }

        static SqlServerHelper()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "BottomUp";
            builder.IntegratedSecurity = true;
            ConnectionString = builder.ToString();
        }
    }
}
