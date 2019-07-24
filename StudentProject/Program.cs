using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();           // CONSTRUCTOR  -  CREATING NEW INSTANCE OF CLASS (Student)
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student();
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            string name = jesse.FirstName;          // Retrieving the value stored in Firstname for Jesse

            Student Marianne = new Student();
            Marianne.FirstName = "Marianne";
            Marianne.IsPaid = true;
            Marianne.Birthdate = new DateTime(1990, 01, 01);
            Marianne.State = "OH";
            Marianne.Bootcamp = "C#";

            Student Glenn = new Student();
            Glenn.FirstName = "Glenn";
            Glenn.IsPaid = false;
            Glenn.Birthdate = new DateTime(1981, 12, 01);
            Glenn.State = "OH";
            Glenn.Bootcamp = "C#";
        }
    }
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; }                  // current, future, past
        public string email { get; set; }
        public string phone { get; set; }
        public bool IsPaid { get; set; } = false;           // defaulted to FALSE
        public DateTime Birthdate { get; set; }

        /*                                            // DEFAULT CONSTRUCTOR  -    
         *public Student() {                         // There is no return type
         *                                          // Name of method(Constructor) has to be same name as Class

          }
      */
    }
}
