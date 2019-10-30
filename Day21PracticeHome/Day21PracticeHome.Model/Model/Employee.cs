using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21PracticeHome.Model.Model
{
    public class Employee
    {
        private int id;
        private string name;
        private string address;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public Employee()
        {

        }
        public Employee(int id,string name,string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
    }
}
