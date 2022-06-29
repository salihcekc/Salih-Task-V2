using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Level2_Test_App2
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int PersonalID { get; set; }
        public DateTime HireDate { get; set; }

    }
    /*
     * 
     * import butonunda çalışırken export butonu içerisinde değişkenleri çağırma konusunda süre sıkıntısı yaşadım.
     * örnek aşağıdaki gibi olacaktır.
     * 
         public class Employee
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public int PersonalID { get; set; }
        public DateTime HireDate { get; set; }
    }
    public class Name
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
     */
}
