﻿using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2= "Dersimiz CSharp";
            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //concat
            Console.WriteLine(string.Concat(degisken," Merhaba!"));

            //Compare, CompareTO

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Dersimiz"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Fatih"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));

            //PadLeft ,PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
