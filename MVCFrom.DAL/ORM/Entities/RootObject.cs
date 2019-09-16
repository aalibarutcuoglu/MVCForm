using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrom.DAL.ORM.Entities
{
    public class RootObject : Base
    {
        
        public string name { get; set; }
        public string description { get; set; }
        public string createdAt { get; set; }
        public int createdBy { get; set; }
        public List<Field> field { get; set; }
    }
}
