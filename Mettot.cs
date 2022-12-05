using Phonebook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Methods
{
    public class Method
    {
        public void YeniNumaraKaydetmek(List<Person> phonebook)
        {
            Person newPerson = new Person();
            Console.Write("Lütfen isim giriniz             : ");
            newPerson.Name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            newPerson.SurName = Console.ReadLine();
            bool input = false;
            while (input == false)
            {
                long number = 0;
                Console.Write("Lütfen telefon numarası giriniz : ");
                input = long.TryParse(Console.ReadLine(), out number);
                if (input)
                    newPerson.Number = number.ToString();
                else
                    Console.WriteLine("Lütfen telefon numarasını doğru giriniz!");
            }
            phonebook.Add(newPerson);
        }

        public void VarOlanNumarayıSilmek(List<Person> phonebook)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();
            int ans = 0;
            foreach (var item in phonebook.ToList())
            {
                if (item.Name.ToLower() == input.ToLower() || item.SurName.ToLower() == input.ToLower())
                {
                    ans++;
                    Console.WriteLine($"{input} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        phonebook.Remove(item);
                        break;
                    }
                    else
                        break;
                }
            }
            if (ans == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                    return;
                else
                    VarOlanNumarayıSilmek(phonebook);
            }

        }

        public void VarolanNumarayıGüncelleme(List<Person> phonebook)
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();
            int ans = 0;
            long cont = 0;
            bool sum = false;
            foreach (var item in phonebook.ToList())
            {
                if (item.Name.ToLower() == input.ToLower() || item.SurName.ToLower() == input.ToLower())
                {
                    ans++;
                    while (sum == false)
                    {
                        Console.Write("Lütfen güncel telefon numarasını girin: ");
                        sum = long.TryParse(Console.ReadLine(), out cont);
                        if (sum)
                        {
                            item.Number = cont.ToString();
                            break;
                        }
                        else
                            Console.WriteLine("Lütfen telefon numarasını doğru girin.");
                    }
                }
            }
            if (ans == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                    return;
                else
                    VarolanNumarayıGüncelleme(phonebook);
            }
        }

        public void RehberiListeleme(List<Person> phonebook)
        {
            Console.WriteLine("Telefon Rehberi\n**********************************************");
            foreach (var item in phonebook.ToList())
            {
                Console.WriteLine($"İsim            : {item.Name}\nSoyisim         : {item.SurName}\nTelefon Numarası: {item.Number}");
                Console.WriteLine("-");
            }
        }

        public void RehberdeAramaYapmak(List<Person> phonebook)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("Lütfen isim veya soyisim giriniz: ");
                string ans = Console.ReadLine();
                foreach (var item in phonebook.ToList())
                {
                    if (item.Name.ToLower() == ans.ToLower() || item.SurName.ToLower() == ans.ToLower())
                    {
                        Console.WriteLine($"İsim            : {item.Name}\nSoyisim         : {item.SurName}\nTelefon Numarası: {item.Number}");
                        Console.WriteLine("-");
                    }
                }
            }
            else if (input == 2)
            {
                Console.Write("Lütfen telefon numarası giriniz: ");
                string phone = Console.ReadLine();
                int number = 0;
                foreach (var item in phonebook.ToList())
                {
                    if (item.Number == phone)
                    {
                        Console.WriteLine($"İsim            : {item.Name}\nSoyisim         : {item.SurName}\nTelefon Numarası: {item.Number}");
                        Console.WriteLine("-");
                        number++;
                    }
                }
                if (number == 0)
                    Console.WriteLine("Böyle bir numara rehberinizde kayıtlı değil.");
            }
        }
    }
}