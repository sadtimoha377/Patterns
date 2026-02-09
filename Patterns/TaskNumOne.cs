using System;
using System.Collections.Generic;

/* public class AppConfig
{
   private static AppConfig _instance;
   private static readonly object _lock = new object();
   private Dictionary<string, string> _settings;

   private AppConfig()
   {
       _settings = new Dictionary<string, string>();
   }

   public static AppConfig Instance
   {
       get
       {
           if (_instance == null)
           {
               lock (_lock)
               {
                   if (_instance == null)
                       _instance = new AppConfig();
               }
           }
           return _instance;
       }
   }

   public void SetSetting(string key, string value)
   {
       _settings[key] = value;
   }

   public string GetSetting(string key)
   {
       if (_settings.ContainsKey(key))
           return _settings[key];

       return null;
   }
}
class TaskNumOne
{
   static void Main()
   {
       AppConfig config = AppConfig.Instance;

       config.SetSetting("Theme", "Dark");
       config.SetSetting("Language", "English");

       Console.WriteLine(config.GetSetting("Theme"));
       Console.WriteLine(config.GetSetting("Language"));
   }
}  */