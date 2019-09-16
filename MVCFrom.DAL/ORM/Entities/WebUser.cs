using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrom.DAL.ORM.Entities
{
    public class WebUser : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
