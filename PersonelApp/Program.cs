﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();
            Console.WriteLine("Adınızı giriniz:");
            personel1.persadi = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            personel1.perssoyadi = Console.ReadLine();
            Console.WriteLine("İşe giriş yılınızı giriniz:");
            personel1.giristarihi = int.Parse(Console.ReadLine());
            Console.WriteLine(personel1.PersonelBilgileri());

        }
    }

    class Personel
    {
        public string persadi;
        public string perssoyadi;
        public int giristarihi;
        double maas = 1000.00;
        double katsayi = 0.8f;


        public double MaasHesap()
        {
            int calismayili = DateTime.Now.Year - this.giristarihi;
            maas = maas * katsayi * calismayili;
            return maas;
        }

        public string PersonelBilgileri()
        {
            return $"Personel Adı:{this.persadi}\nPersonel Soyadı:{this.perssoyadi}\nGiriş Yılı:{this.giristarihi}\nMaaş:{this.MaasHesap().ToString("C2")}\n-----------------";
        }
    }
}
