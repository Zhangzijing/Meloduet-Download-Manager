using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Meloduet_Download_Manager.Controller
{
    public static class ConfigController
    {
        public static Model.ApplicationConfig GetAppConfig()
        {
            var configPath = Environment.CurrentDirectory + @"\ApplicationConfig.json";
            if (File.Exists(configPath))
            {
                return JsonHelper.DeserializeJsonToObject<Model.ApplicationConfig>(File.ReadAllText(configPath));
            }
        else
            {
                File.Create(configPath);
                return GetAppConfig();
            }
            
        }
    }
}
