using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace CompanyECommerce.Model
{
    public class DBResponse : CommonProperty
    {
        public DataSet ds { get; set; }
    }
}
