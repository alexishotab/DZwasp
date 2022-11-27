using System;
using machines;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoparking
{
    public class Autopark
    {
        protected string _name;
        protected List<Car> _spisok = new List<Car>();
        public Autopark(string name, List<Car> spisok)
        {
            this._name = name;
            this._spisok = spisok;
        }
        public override string ToString()
        {
            foreach (Car car123 in _spisok)
                Console.WriteLine(car123.ToString());
            return $"\nName of autopark:{_name}\n";
        }
    }
}
