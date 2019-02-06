using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsList.Model
{
    class Person
    {
        public string FirstName { get; set; } //имя
        public string MiddleName { get; set; } //отчество
        public string LastName { get; set; } //фамилия
        public int IdDep { get; set; } //департамент


        public override string ToString()
        {
            return $"FirstName: {FirstName}; MiddleName: {MiddleName}; LastName: {LastName}; Dept: {IdDep}";
        }
    }
}
