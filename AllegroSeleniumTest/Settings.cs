using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AllegroSeleniumTest
{
    public class Settings
    {
        private static Settings instance;

        public string AllegroHost { get; set; }
        public string AllegroLogin { get; set; }
        public string AllegroPassword { get; set; }

        public static Settings Default
        {
            get 
            {
                if (instance == null)
                {
                    instance = Settings.FromJsonFile("Settings.json");
                }
                return instance;
            }
        }


        //metoda fabrykująca (klasa typu dataClass - zaiwerajaca dane)
        public static Settings FromJsonFile(string path)
        {
            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<Settings>(json);
        }
    }
}
