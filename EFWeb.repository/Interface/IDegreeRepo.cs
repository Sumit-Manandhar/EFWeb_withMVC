using EFWeb.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWeb.repository.Interface
{
   public  interface IDegreeRepo
    {
        void Add(Degree data);
        void Update(Degree data);
        Degree GetById(int Id);
        List<Degree> GetList();
        void Delete(Degree data);
    }
}
