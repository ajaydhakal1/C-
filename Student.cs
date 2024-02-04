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