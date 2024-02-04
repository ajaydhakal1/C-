class Factorial{
    public void fact(){
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int mul;
        for(int i=1; i<=10; i++){
            mul = i*num;
            Console.WriteLine($"{num}*{i}={mul}");
        }
    }
}