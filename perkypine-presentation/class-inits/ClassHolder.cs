using data_layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inits
{
    public class ClassHolder
    { 

        public ClassHolder()
        {
            
        }

        public DataStorageTemp DataStorage { get; set; } = new DataStorageTemp();

    }
}
