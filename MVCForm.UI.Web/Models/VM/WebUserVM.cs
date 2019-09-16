using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCForm.UI.Web.Models.VM
{
    public class WebUserVM
    {
        public int id { get; set; }

        public string AdSoyad { get; set; }

        public int Yas { get; set; }

        public DateTime SonGirisTarih { get; set; }
    }
}