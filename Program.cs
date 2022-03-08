foreach(int i in Enumerable.Range(1, 100))
{
    switch(i % 3, i % 5)
    {
        case (0, 0):
            Console.WriteLine("FizzBuzz");
            break;
        case (0, _):
            Console.WriteLine("Fizz");
            break;
        case (_, 0):
            Console.WriteLine("Buzz");
            break;
        default:
            Console.WriteLine(i.ToString());
            break;
    }
}