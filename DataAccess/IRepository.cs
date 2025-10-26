using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.DataAccess
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        //T GetById();
        //int DeleteById(int id);
        //int Insert(int id);
        //int Update(int id);
    }
}
