using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProjectOne.PageObjectModel.GeneralUtilities
{
    public class ReadConfigData
    {
        public string JsonFilePath;
        public ConfigData configData;
        public ConfigData ReadConfig()
        {
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\bin\Debug    - BaseDirectory
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\  + 
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\PageObjectModel\TestData\DevData.json
            JsonFilePath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\netcoreapp3.1", @"\") + "TestData\\Config.json";
            configData = JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText(JsonFilePath));
            return configData;
        }
    }
    public class ConfigData
    {
        public string Browser;
        public string Environment;
    }
}

