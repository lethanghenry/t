using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class AccessoryDAO
    {
        Database database = Database.GetInstance;
        List<Accessory> listAccessory = new List<Accessory>();
        public void insertTableAccessoryTest()
        {
            object accessory = new Accessory(3, "kim");
            database.insertTable("Accessory", accessory);
        }

        public void selectTableAccessoryTest()
        {
            List<Object> listAccessory = database.selectTable("Accessory", "kim");
            foreach (Accessory a in listAccessory)
            {
                Console.WriteLine(a);
            }
        }
        public void updateTableAccessoryTest()
        {
            object accessory = new Accessory(3, "kim");
            database.updateTable("Accessory", accessory);
        }
        public void deleteTableAccessoryTest()
        { }
        public void truncateTableAccessoryTest()
        { }
        public void initAccessoryDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                listAccessory[i].id = i + 20;
                listAccessory[i].name = (i + 20).ToString();
            }
        }
        public void printTableAccessory()
        { }

    }
}
