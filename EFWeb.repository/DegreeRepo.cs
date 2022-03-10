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
    public class DegreeRepo : IDegreeRepo
    {

        private readonly Context context;
        public DegreeRepo()
        {
            context = new Context();
        }


        public void Add(Degree data)
        {
            context.Degree.Add(data);
            context.SaveChanges();
        }

        public void Delete(Degree data)
        {
            context.Degree.Attach(data);
            context.Entry(data).State = EntityState.Deleted;
            context.SaveChanges();

        }

        public Degree GetById(int Id)
        {
            return context.Degree.Find(Id);
        }

        public List<Degree> GetList()
        {
            return context.Degree.ToList();
        }

        public void Update(Degree data)
        {
            var entity = GetById(data.Id);
            context.Entry(entity).State = EntityState.Detached;
            context.Degree.Attach(data);
            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }
       
    }
}
