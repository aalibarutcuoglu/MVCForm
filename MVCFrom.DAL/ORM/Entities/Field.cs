using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrom.DAL.ORM.Entities
{
    public class Field : Base
    {
        
        public bool required { get; set; }
        public string name { get; set; }
        public string dataType { get; set; }
      
    }
}
