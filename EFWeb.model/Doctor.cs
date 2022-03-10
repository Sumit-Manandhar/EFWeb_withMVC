using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EFWeb.model
{
    public class Doctor
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public int DegreeID { get; set; }
        public Degree Degree { get; set; }


        [NotMapped]
        public List<SelectListItem> DegreeList { get; set; }
    }
}
