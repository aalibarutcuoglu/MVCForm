﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrom.DAL.ORM.Interfaces
{
    public interface IUserLog
    {
        int InsertedUserID { get; set; }

        int UpdatedUserID { get; set; }

        int? DeletedUserID { get; set; }
    }
}
