int level = 0;
while (level != 5)
{
    Console.Clear();
    int i, x = 100, z = 0, t = 1;
    int[] a = new int[x];
    bool oneortwo = true, every2times = false;

    level++;

    if (level == 5)
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
            if (!((level == 3 || level == 4) && (i == 0 || i == x - 1)))
            {
                if (level == 1)
                {
                    a[i] = (i / 10) % 2 == (i % 10) % 2 ? 1 : 2; 
                }
                else
                {
                    a[i] = oneortwo ? 1 : 0;
                }
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

        if (level == 1)
        {
            if (z == 10)
            {
                Console.WriteLine("");
                z = 0;
            }
        }
        else
        {
            if ((t == x / 8 && level == 2) || (t == x / 10 && (level == 3 || level == 4)))
            {
                if (!(every2times && level == 4))
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
        }
        z++;
        Console.ForegroundColor = (a[index] == 1) ? ConsoleColor.Red : ConsoleColor.White;
        if (a[index] == 1 && level == 5)
        {
            Console.Write("X ");
        }
        else
        {
            Console.Write(a[index] + " ");
        }
    }
    Thread.Sleep(6000);
}
Console.Read();
