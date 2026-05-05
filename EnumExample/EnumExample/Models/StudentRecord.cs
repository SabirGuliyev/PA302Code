using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Models
{
    internal record StudentRecord(string name, string surname, string UniName):PersonRecord(name,surname);



    //internal record StudentRecord:PersonRecord
    //{
    //    public string UniName { get; init; }
    //    public StudentRecord(string name, string surname,string uniName):base(name,surname)
    //    {
    //        UniName = name;
    //    }
    //}
}
