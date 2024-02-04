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

            Greatest gg = new Greatest();
            gg.findNumber();

            Factorial f = new Factorial();
            f.fact();
            AsteriskPattern f1 = new AsteriskPattern();
            f1.Asterisk();

            Sum f2 = new Sum();
            f2.Find();

            Character f3 = new Character();
            f3.vowel();

            Commission f4 = new Commission();
            f4.sale();

        }
    }
};