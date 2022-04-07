using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Crypto
{
    int seed;
    public Crypto(int Seed)
    {
        seed = Seed;
    }

    public string Encrypt(string Text)
    {
        int counter = 0;
        Random random = new Random(seed);
        char[] chars = Text.ToCharArray();
        foreach (char c in chars)
        {
            int temp = (int)c + random.Next(0, 128);
            if (temp > 127)
                temp = temp - 127;

            chars[counter] = Convert.ToChar(temp);
            File.AppendAllText(@"C:\Programmieren\Test.txt", chars[counter].ToString() + " - " + temp + "\n");
            counter++;
        }
        return new string(chars);
    }

    public string Decrypt(string Text)
    {
        int counter = 0;
        Random random = new Random(seed);
        char[] chars = Text.ToCharArray();
        foreach (char c in chars)
        {
            int temp = (int)c - random.Next(0, 128);
            if (temp < 0)
                temp = 127 + temp;
            chars[counter] = Convert.ToChar(temp);
            counter++;
        }
        return new string(chars);
    }

    public static int GenerateSeed()
    {
        int temp;
        int P1 = System.DateTime.Today.Year + DateTime.Now.TimeOfDay.Milliseconds;
        int P2 = (int)System.IO.DriveInfo.GetDrives()[0].AvailableFreeSpace;
        int P3 = (int)System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime.TotalMinutes;
        temp = P1 + P2;
        temp = temp / P1;
        Random rnd = new Random(temp);
        return rnd.Next(0, 999999999);
    }
}

