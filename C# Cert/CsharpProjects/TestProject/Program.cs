// Fizz Buzz program
// Output values 1-100, one number per line, inside code block of iteration statment
//      If current value divisible by 3, print "Fizz" next to the number. 
//      "                        " by 5, print "Buzz" 
//      "                        " by both, print "FizzBuzz"

for (int i = 1; i <= 100; i++)
{
    string fizzBuzz = "";
    if (i % 3 == 0)
    {
        if (i % 5 == 0) fizzBuzz = " - FizzBuzz";
        else fizzBuzz = " - Fizz";
    }
    if (i % 5 == 0)
    {
        fizzBuzz = " - Buzz";
    }

    Console.WriteLine($"{i}{fizzBuzz}");
}
