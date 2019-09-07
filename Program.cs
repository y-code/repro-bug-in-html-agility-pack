using System;
using System.Text;
using HtmlAgilityPack;

namespace repro_bug_in_html_agility_pack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Decode by the encoding in Content-Encoding ===");

                var web = new HtmlWeb();
                web.Load("https://www.jamieoliver.com/recipes/chicken-recipes/chicken-tofu-noodle-soup/");
            }
            catch (ArgumentException e)
            {
                Console.Error.WriteLine(e);

                Console.WriteLine("=== Decode by UTF8 ===");

                var web = new HtmlWeb();
                web.OverrideEncoding = Encoding.UTF8;
                web.Load("https://www.jamieoliver.com/recipes/chicken-recipes/chicken-tofu-noodle-soup/");
            }


        }
    }
}
