
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer.Data
{
    public class DatabaseFactory
    {
        public DatabaseFactory()
        {

        }

        public PerkyPineDB CreateDB()
        {
            return new PerkyPineDB();
        }
    }
}
