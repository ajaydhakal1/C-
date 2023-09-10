using System;
namespace Program
{

    class FirstProgram
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");

            Calculation cal = new Calculation();
            cal.ClassName();

            Student details = new Student();
            details.Details();

            NumberCheck check = new NumberCheck();
            check.Check();

            Grade rank = new Grade();
            rank.GradeCheck();


            SumNum sum = new SumNum();
            sum.Add();

            CheckNP test = new CheckNP();
            test.Check();

            PrimeCheck obj = new PrimeCheck();
            obj.Check(9);

            Cast c = new Cast();
            c.Convert();

            Size s = new Size();
            s.Type();
        }
    }







    class Calculation
    {
        public void ClassName()
        {
            Console.WriteLine("Class Name is Calculation");
        }
    }

    class Student
    {
        String name;
        String friendname;
        int age;
        int friendage;
        public void Details()
        {
          Student student = new Student();
          student.name="Ajay Dhakal";
          student.age=18;  
          student.friendname = "Rohit Dalle";
          student.friendage= 18;

          Console.WriteLine("My Name:"+student.name);
          Console.WriteLine("My Age:"+student.age);
          Console.WriteLine("Friend Name:"+student.friendname);
          Console.WriteLine("Friend Age:"+student.friendage);
        }
    }

    class NumberCheck
    {
        public void Check()
        {

            int num = 10;

            if (num % 2 == 0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }
        }
    }

    class Grade
    {
        public void GradeCheck()
        {
            int marks = 94;

            if (marks > 90)
            {
                Console.WriteLine("Congratulations! You got 'A+' grade.");
            }

            else if (marks >= 80)
            {
                Console.WriteLine("Congratulations! You got 'A' grade.");
            }

            else if (marks < 80)
            {
                Console.WriteLine("Congratulations! You got 'B+' grade.");
            }

            else if (marks >= 60)
            {
                Console.WriteLine("Congratulations! You got 'B' grade.");
            }

            else
            {
                Console.WriteLine("You got less than 'B' grade.");
            }
        }
    }


    class SumNum
    {
        public void Add()
        {
            int num = 20;
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum:" + sum);
        }
    }


    class CheckNP
    {
        public void Check()
        {
            int num = -190;

            if (num == 0)
            {
                Console.WriteLine("The number is zero!");
            }
            else if (num > 0)
            {
                Console.WriteLine("The number is positive!");
            }
            else
            {
                Console.WriteLine("The number is negative!");
            }
        }
    }

    //Program to find if the number is prime or composite
    class PrimeCheck
    {
        public void Check(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; // Exit the loop as soon as a divisor is found
                }
            }

            if (isPrime)
            {
                Console.WriteLine("The Number Is Prime");
            }
            else
            {
                Console.WriteLine("The Number Is Composite");
            }
        }
    }
    class Cast
    {
        public void Convert()
        {
            double myDouble = 99.99;
            int myInt = 100;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
        }
    }

    class Size
    {
        public void Type()
        {
            int sizeoflong = sizeof(long);
            Console.WriteLine("The size of long is:" + sizeoflong);
        }
        public void IntType()
        {
            int sizeofint = sizeof(int);
            Console.WriteLine("The size of int is:" + sizeofint);
        }
        public void DoubleType()
        {
            int sizeofdouble = sizeof(double);
            Console.WriteLine("The size of int is:" + sizeofdouble);
        }
        public void FloatType()
        {
            int sizeoffloat = sizeof(float);
            Console.WriteLine("The size of int is:" + sizeoffloat);
        }
    }
};