Console.WriteLine(power(32));

string power (int n)
{   int two = 2;
    while (n > two)
    {
        if (n==1)
        {
            return $"{n} 2nin quvvetidir";
        }

        if (n % two == 0)
        {
            two *= 2;

            if (n / two == 1)
            return $"{n} 2nin quvvetidir";
        }
    }
return $"{n} 2nin quvveti deyil";
}
