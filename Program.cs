using Phonebook.Data;
using Phonebook.Entities;
using Phonebook.Methods;
using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> phonebook = new List<Person>();
            Database database = new Database();
            database.Start(phonebook);
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************\n(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak﻿");

                int number = 0;
                bool input = int.TryParse(Console.ReadLine(), out number);
                Method method = new Method();
                if (input && number > 0 && number < 6)
                {
                    switch (number)
                    {
                        case 1:
                            method.YeniNumaraKaydetmek(phonebook);
                            break;
                        case 2:
                            method.VarOlanNumarayıSilmek(phonebook);
                            break;
                        case 3:
                            method.VarolanNumarayıGüncelleme(phonebook);
                            break;
                        case 4:
                            method.RehberiListeleme(phonebook);
                            break;
                        case 5:
                            method.RehberdeAramaYapmak(phonebook);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen seçeneklerden birini seçiniz!");
                }
            }
        }
    }
}