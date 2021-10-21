using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class ProductDAO
    {
        Database database = Database.GetInstance;
        public int insert(Product row)
        {
            object product = new Product(2, "An", 5);
            database.insertTable("Product", product);
            }
        public int update(Product row)
        { }
        public Boolean delete(Product row)
        { }
        public List<Product> findAll()
        { }
        public Product findById(string name)
        { }
        public Product findByName(string name)
        { }
        public List<Product> search(string where)
        { }

    }
}
