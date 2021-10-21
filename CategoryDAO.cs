using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class CategoryDAO
    {
        Database database = Database.GetInstance;
        public Boolean insert(Category row)
        {
           
            Object category = new Category(1, "thang");
           if( database.insertTable("Category", category)==0)
           {
               return false;
           }
           else
           {
               return true;
           }
        }
        public int update(Category row)
        { }
        public Boolean delete(Category row)
        { }
        public List<Category> findAll()
        { }
        public Object findById(string name)
        { }

    }
}
