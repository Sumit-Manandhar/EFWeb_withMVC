using EFWeb.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EFWeb.repository.Interface
{
   public  interface IDoctorRopo
    {

         void Add(Doctor data);
         void Update(Doctor data);
        Doctor GetById(int Id);
        List<Doctor> GetList();
        void Delete(Doctor data);
        List<SelectListItem> DropDownList();


    }
}
