foreach(int i in Enumerable.Range(1, 100))
{
    var str = (i % 3, i % 5) switch
    {
        (0, 0) => "FizzBuzz",
        (0, _) => "Fizz",
        (_, 0) => "Buzz",
        _ => i.ToString()
    };
    Console.WriteLine(str);
}