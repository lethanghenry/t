using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.enity
{
    class Accessory
    {
        public int id
        {
            get; set;
        }
        public string name { get; set; }
        public Accessory()
        { }
        public Accessory(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    public string toString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
