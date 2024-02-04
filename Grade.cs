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

