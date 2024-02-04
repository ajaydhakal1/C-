class Commission{

    public void sale(){
        double sales;
        Console.WriteLine("Enter number:");
         sales = Convert.ToDouble(Console.ReadLine());


        if (sales < 500)
        {
            Console.WriteLine("We can't get commission");

        }
    else{
        Console.WriteLine("Congratulation!! you will get 5% commission from your sales");
        double   commission = sales / 100 * 5;
        Console.WriteLine("Your commission is :"+commission);
    }

    }
}