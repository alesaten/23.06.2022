using System;
class HeritageApp
{
    static void Main()
    {
        int[] lockers = new int[100];
        int[] opened_lockers = new int[9];
        int buffer = 0;

        for (int locker = 0; locker < 100; locker++)
        {
            lockers[locker] = 0;
        }

        for (int heir = 1; heir <= 100; heir++)
        {
            for (int opener = heir; opener < 100; opener += heir)
            {
                if (lockers[opener] == 0)
                {
                    lockers[opener] = 1;
                }
                else
                {
                    lockers[opener] = 0;
                }
            }
        }

        for (int locker_opened = 0; locker_opened < 100; locker_opened++)
        {
            if (lockers[locker_opened] == 1)
            {
                opened_lockers[buffer++] = locker_opened;
            }
        }

        string opened_lockers_string = string.Join(", ", opened_lockers);
        Console.WriteLine("Шкафчики, которые по итогу останутся открытыми: " + opened_lockers_string);
    }
}