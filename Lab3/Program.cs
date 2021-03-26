using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;



namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            load("https://openexchangerates.org/api/latest.json?app_id=72a8ed46e61f49c09af2017a0c3dd6a5&symbols=PLN,EUR,GBP");
            Console.Read();
        }// w ciagu godziny mamy zrobic uzycie api

        public static async void load(string x)
        {
            string call = x;
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(call);
            Console.WriteLine(json);
            Money m = JsonConvert.DeserializeObject<Money>(json);
            Console.WriteLine(m.Rates.EUR);
            Console.WriteLine(m.Rates.PLN);
            Console.WriteLine(m.license);
            Console.WriteLine(m.Base);
            Console.WriteLine(m.timestamp); //sprawdzic jak jest opisany czas dokładnie
            //mozemy dac ze uzytkownik wyklikuje, albo np. automat zeby sciagal dla wybranej waluty z okresu - ostatni rok

    }
    }
}
