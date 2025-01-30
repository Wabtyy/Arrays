int level = 0;
while (true)
{
    Console.Clear();
    int i, x = 100, z = 0, t = 1;
    int[] a = new int[x];
    bool oneortwo = true, every2times = false;

    level++;
    if (level == 5){ Console.Read(); Environment.Exit(0); }
    if (level == 4)
    {
        Random rnd = new Random();
        for (i = 0; i < 10; i++)
        {
            a[rnd.Next(0, x)] = 1;
        }
        for (i = 0; i < x; i++)
        {
            output(i);
        }
    }
    else
    {
        for (i = 0; i < x; i++)
        {
            every2times = !every2times;

            if (!((level == 2 || level == 3) && (i == 0 || i == x - 1)))
            {
                a[i] = oneortwo ? 1 : 0;
            }
            else
            {
                a[i] = 0;
            }

            output(i);
        }
    }

    void output(int index)
    {
        oneortwo = false;
        t++;
        if ((t == x/8 && level == 1) || (t == x/10 && (level == 2 || level == 3)))
        {
            if (!(every2times && level == 3))
            {
                oneortwo = true;
            }
            t = 1;
        }

        if (z == x / 10)
        {
            Console.WriteLine("");
            z = 0;
        }

        z++;
        Console.ForegroundColor = (a[index] == 1) ? ConsoleColor.Red : ConsoleColor.White;
        Console.Write(a[index] + " ");
    }
    Thread.Sleep(6000);
}
