class Character{
    public void vowel(){

        Console.WriteLine("Enter character:");
        char ch = Convert.ToChar(Console.ReadLine());
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ){
            Console.WriteLine("The entered character is a Vowel.");
        }
        else {
            Console.WriteLine("The entered character is consonent.");
        
    }
}
}