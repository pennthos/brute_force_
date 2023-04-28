using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("kaç eleman gireceksiniz");
            int i = Convert.ToInt32(Console.ReadLine());
            int say = 0;
            List<char> li = new List<char>();
            while (say < i)
            {
                Console.WriteLine((say + 1) + ". elemanı giriniz");
                string kelime = Console.ReadLine();
                char[] array = new char[kelime.Length];
                array = kelime.ToCharArray();
                foreach (char item in array)
                {
                    li.Add(item);
                }
                say++;
            }
            for (int sayac = 0; sayac < li.Count; sayac++)
            {
                for (int sayac2 = 0; sayac2 < li.Count; sayac2++)
                {
                    if (sayac != sayac2)
                    {
                        if (li[sayac] == li[sayac2])
                        {
                            li.RemoveAt(sayac2);
                        }
                    }
                    else sayac2++;
                }
            }
            li.Sort();
            char[] array1 = li.ToArray();
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            i = 0;

            string sifre;
            FileStream fs = new FileStream("C:\\Users\\sahip\\Desktop\\sifreler3.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SW = new StreamWriter(fs);
            for (p1 = 0; p1 < li.Count; p1++)
            {
                sifre = li[p1].ToString();
                for (p2 = 0; p2 < li.Count; p2++)
                {
                    sifre = sifre + li[p2].ToString();
                    for (p3 = 0; p3 < li.Count; p3++)
                    {
                        sifre = sifre + li[p3].ToString();

                        for (p4 = 0; p4 < li.Count; p4++)
                        {
                            sifre = sifre + li[p4].ToString();
                            for (p5 = 0; p5 < li.Count; p5++)
                            {
                                sifre = sifre + li[p5].ToString();
                                Console.WriteLine(sifre);
                                i++;
                                
                                SW.WriteLine(sifre);
                                sifre = sifre.Substring(0, sifre.Length - 1);
                            }
                            sifre = sifre.Substring(0, sifre.Length - 1);
                        }
                        sifre = sifre.Substring(0, sifre.Length - 1);
                    }
                    sifre = sifre.Substring(0, sifre.Length - 1);
                }
                sifre = sifre.Substring(0, sifre.Length - 1);
            }
            SW.Flush();
            SW.Close();
            fs.Close();
            Console.WriteLine(i.ToString());
            Console.ReadKey();
        }
    }
}