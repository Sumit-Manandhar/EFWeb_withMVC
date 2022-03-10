using EFWeb.core;
using EFWeb.model;
using EFWeb.repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EFWeb.repository
{
    public class DoctorRepo : IDoctorRopo
    {
        private readonly Context context;
        public DoctorRepo()
        {
         context = new Context();
        }
   
        public void Add(Doctor data)
        {
            context.Doctor.Add(data);
            context.SaveChanges();
        }

        public void Delete(Doctor data)
        {
            context.Doctor.Attach(data);
            context.Entry(data).State = EntityState.Deleted;
            context.SaveChanges();

        }

        public Doctor GetById(int Id)
        {
            return context.Doctor.Include(x => x.Degree).FirstOrDefault(x=>x.Id==Id);
        }

        public List<Doctor> GetList()
        {
            IQueryable<Doctor> i = context.Doctor;
            var test = i.ToList();

            
            return context.Doctor.Include(x=>x.Degree).ToList();
        }

        public void Update(Doctor data)
        {
            var entity = GetById(data.Id);
            context.Entry(entity).State = EntityState.Detached;
            context.Doctor.Attach(data);
            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }
        public List<SelectListItem> DropDownList()
        {
            List<SelectListItem> item = new List<SelectListItem>();
            context.Degree.ToList().ForEach(x => {
                item.Add(new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
            });
            return item;
        }
    }
}
