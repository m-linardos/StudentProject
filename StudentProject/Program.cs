using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();           // CONSTRUCTOR  -  CREATING NEW INSTANCE OF CLASS (Student)
            //brailee.Status = "Hello";
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);         // this is a constructor for date & time

            

            brailee.SetStatus("PAST");       // 
            Console.WriteLine("Brailee credit score is {brailee.Status);  // EX to show better way that multiple nested if statements

     // test exercise SetCreditScore
            //brailee.CreditScore = 2000;             // entered to test after attaching private to 
            brailee.SetCreditScore(9000);
            brailee.SetCreditScore(90);
            brailee.SetCreditScore(900);


            Student jesse = new Student("Jesse", "Kyle");
            Console.WriteLine($"Jess: {jesse.FirstName} {jesse.LastName}");      // INTERPOLATION
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);
            jesse.SetStatus("past");
            string name = jesse.FirstName;          // Retrieving the value stored in Firstname for Jesse
            Console.WriteLine($"Brailee's Bootcamp is {brailee.Bootcamp}");          // Using constructor with no parameters
            Console.WriteLine($"Jess's Bootcamp is {jesse.Bootcamp}");          

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
        public string Id { get; set; }      // primary key

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
        public DateTime Birthdate { get; set; };

        public string CreditScore { get; private set; };   // Can read, but not write to credit score
        //private string CreditScore { get; set; };

        public void SetStatus(string status) {      // ACCESS MODIFIER - public makes it accessible; RETURN TYPE - 
                                                    /*
                                                     *if (status == "CURRENT") {       // Limits Status options to PAST, CURRENT or FUTURE
                                                            this.Status = status;       // Too much code to write & too much duplication of code
                                                        } else {                         // There's a better way - 
                                                            if (status == "PAST") {      // boolean expression - T or F
                                                                this.Status = status;
                                                            }
                                                            else {
                                                                if (status == "FUTURE") {
                                                                    this.Status = status;
                                                                }
                                                                else {
                                                                    Console.WriteLine("Status must be: PAST, CURRENT or FUTURE");
                                                                }
                                                            }

                                                        }
                                            */

        }


        public void SetStatus(string status) {      // ACCESS MODIFIER - public makes it accessible; RETURN TYPE - 
            if((status == "CURRENT") 
                || (STATUS == "PAST")          // Using || (or) allows us to cut out the duplicated code
                || (STATUS == "FUTURE")) {
                this.Status = status;                   
            } else {
                Console.WriteLine("Status must be CURRENT, PAST, or FUTURE");
            }
                
        }


        public Student(string firstName, string lastName) { }       // this instance that I am creating
            this.FirstName = firstName;
            this.LastName = firstName;
            this.Bootcamp = ".Java"; 


          public Student() {                                          // DEFAULT CONSTRUCTOR  -    
                                    // There is no return type
         }                                       // Name of method(Constructor) has to be same name as Class
                                                 // Default only exist if you do not create a constructor yourself


        public Student() {
            this.Bootcamp = ".Net";     // example
        }

            public Student(string firstName, string lastName) { 
            this.FirstName = firstName;
            this.LastName = firstName;
        }



        // exercise
        /// Method that allows yyou to set credit status between low: 400 & high:900 inclusive
        /// test with:
              // brailee.SetCreditScore(9000); brailee.SetCreditScore(90); brailee.SetCreditScore(900);
        public void SetCreditScore(int score) {            
            if (score >= 400) && (score <= 900)   {       // Using || (or) allows us to cut out the duplicated code
                this.CreditScore = score;
            } else {
                Console.WriteLine("Credit Score is not within the acceptable range of values");
            }
        }


    }
}
