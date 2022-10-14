using System;

class program
{
    
        static void Main(string[] args)
        {
            Console.WriteLine("Login");
            Console.WriteLine("Regiter");
            Console.WriteLine("Exhibitor statistics");
            Console.WriteLine("**********************");

            Console.WriteLine("Input Menu number 1:Login number 2: Regiter number3 : Exhibitor statistics ");
            double Menu = double.Parse(Console.ReadLine());
            if(Menu == 1)
            {
                Console.WriteLine("Login");
                Console.WriteLine("*******************");
                Console.Write("Login:");
                string Login1 = Console.ReadLine();
                Console.Write("Password:");
                string Password1=Console.ReadLine();
            }

            if(Menu == 2)
            {
                Console.WriteLine("Login Input the role number" );
                Console.WriteLine("1 = Teacher , number 2 = Student of University , number 3 student ");
                double Role = double.Parse(Console.ReadLine());
                if(Role == 1)
                {
                    Console.WriteLine("Teacher Regiter");
                    Console.WriteLine("*********************");
                    Console.WriteLine("prefix Name");
                    string PN = Console.ReadLine();
                    Console.WriteLine("Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Surenmame");
                    string Surename = Console.ReadLine();
                    Console.WriteLine("Age");
                    string Age = Console.ReadLine();
                    Console.WriteLine("position");
                    string position = Console.ReadLine();
                    Console.WriteLine("Allergy");
                    string Allergy = Console.ReadLine();
                    Console.WriteLine("religion");
                    string religion =Console.ReadLine();
                    Console.WriteLine("Car Yes/No");
                    string Car = Console.ReadLine();
                    Console.WriteLine("Are you an administrator? Yes/No");
                    string administrator = Console.ReadLine();
                    Console.WriteLine("Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Password");
                    string Password = Console.ReadLine();
                     Console.WriteLine("***********************");
                     Console.WriteLine("Name:{0}.{1}{2} " , PN ,Name , Surename);
                     Console.WriteLine("Age{0}" , Age);
                     Console.WriteLine("position:{0}" , position);
                     Console.WriteLine("Allergy:{0}", Allergy);
                     Console.WriteLine("religion:{0}" , religion);
                     Console.WriteLine("Car{0}:", Car);
                     Console.WriteLine("Are you an administrator:{0}",administrator);
                     Console.WriteLine("Email:{0}" , Email);
                     Console.WriteLine("Password:{0}", Password);
                     Console.WriteLine("***********************");
                }
                if(Role == 2)
                {
                    Console.WriteLine("Student of University");
                    Console.WriteLine("*********************");
                    Console.WriteLine("prefix Name");
                    string PN = Console.ReadLine();
                    Console.WriteLine("Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Surenmame");
                    string Surename = Console.ReadLine();
                    Console.WriteLine("Age");
                    string Age = Console.ReadLine();
                    Console.WriteLine("Student ID");
                    string position = Console.ReadLine();
                    Console.WriteLine("Allergy");
                    string Allergy = Console.ReadLine();
                    Console.WriteLine("religion");
                    string religion =Console.ReadLine();
                    Console.WriteLine("Are you an administrator? Yes/No");
                    string administrator = Console.ReadLine();
                    Console.WriteLine("Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Password");
                    string Password = Console.ReadLine();
                     Console.WriteLine("***********************");
                     Console.WriteLine("Name:{0}.{1}{2} " , PN ,Name , Surename);
                     Console.WriteLine("Age{0}" , Age);
                     Console.WriteLine("Student ID:{0}" , position);
                     Console.WriteLine("Allergy:{0}", Allergy);
                     Console.WriteLine("religion:{0}" , religion);
                     Console.WriteLine("Are you an administrator:{0}",administrator);
                     Console.WriteLine("Email:{0}" , Email);
                     Console.WriteLine("Password:{0}", Password);
                     Console.WriteLine("***********************");
                }
                if(Role == 3)
                {
                    Console.WriteLine("Student");
                    Console.WriteLine("*********************");
                    Console.WriteLine("prefix Name");
                    string PN = Console.ReadLine();
                    Console.WriteLine("Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Surenmame");
                    string Surename = Console.ReadLine();
                    Console.WriteLine("Age");
                    string Age = Console.ReadLine();
                    Console.WriteLine("Grade 4 / 5 / 6");
                    string position = Console.ReadLine();
                    Console.WriteLine("Allergy");
                    string Allergy = Console.ReadLine();
                    Console.WriteLine("religion");
                    string religion =Console.ReadLine();
                    Console.WriteLine("School");
                    string administrator = Console.ReadLine();
                     Console.WriteLine("***********************");
                     Console.WriteLine("Name:{0}.{1}{2} " , PN ,Name , Surename);
                     Console.WriteLine("Age{0}" , Age);
                     Console.WriteLine("Grade:{0}" , position);
                     Console.WriteLine("Allergy:{0}", Allergy);
                     Console.WriteLine("religion:{0}" , religion);
                     Console.WriteLine("Are you an administrator:{0}",administrator);
                     Console.WriteLine("School:{0}" , administrator);
                     Console.WriteLine("***********************");
                     
             }   
             Console.WriteLine("Login");
            Console.WriteLine("Regiter");
            Console.WriteLine("Exhibitor statistics");
            Console.WriteLine("**********************");

            Console.WriteLine("Input Menu number 1:Login number 2: Regiter number3 : Exhibitor statistics ");
            double Menu1 = double.Parse(Console.ReadLine());
            if(Menu1 == 1)
            {
                Console.WriteLine("Login");
                Console.WriteLine("*******************");
                Console.Write("Login:");
                string Login1 = Console.ReadLine();
                Console.Write("Password:");
                string Password1=Console.ReadLine();
                Console.WriteLine("*******************");
                Console.WriteLine("Input 1 to the Exhibitor statistics ");
                double ES = double.Parse(Console.ReadLine());
                if(ES==1)
                {
                    Console.WriteLine("Teacher 10 , Student of University 5 ,student 45");
                }



            }
            }
    }

}  
            
    
