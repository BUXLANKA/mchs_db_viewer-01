using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mchs_db_viewer_01.DataContol
{
    internal class DataController
    {
        public string GetConnectionString()
        {
            return @"Data Source=DESKTOP-Q8UCL02\SQLEXPRESS;Initial Catalog=MCHS;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
