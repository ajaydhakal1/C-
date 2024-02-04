class Greatest{
    public void findNumber(){
        Console.WriteLine("Enter the first number:");
      int n1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the second number:");
      int n2=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the third number:");
      int n3=Convert.ToInt32(Console.ReadLine());

   if(n1>n2 && n1>n3){
        Console.WriteLine("First number is the greatest i.e'{0}'", n1);
      }
      else if(n2>n1 && n2>n3){
        Console.WriteLine("Second Number is the greatest i.e'{0}'", n2);
      }
      else if(n3>n1 && n3>n2){
        Console.WriteLine("Third Number is the greatest i.e'{0}'", n3);
      }
      else{
        Console.WriteLine("Invalid Input");
      }
    }
}