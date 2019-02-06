using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsList.Model
{
    class Department
    {
        public int Id { get; set; }
        public string D_Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {D_Name}";
        }
    }
}
