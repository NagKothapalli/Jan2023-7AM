using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProjectOne.PageObjectModel.GeneralUtilities
{
    public class ReadJsonData
    {
        public string JsonFilePath;
        public UserData userData;
        public UserData ReadTestData(String env)
        {
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\bin\Debug    - BaseDirectory
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\  + 
            //F:\GE-WorkSpace\Jan2023-7AM\UnitTestProjectOne\PageObjectModel\TestData\DevData.json
            JsonFilePath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", @"\") + "PageObjectModel\\TestData\\"+env+"Data.json";
            userData = JsonConvert.DeserializeObject<UserData>(File.ReadAllText(JsonFilePath));
            return userData;
        }
    }
    public class UserData
    {
        public string URL;
        public string UserName;
        public string PassWord;
        public string FromCity;
        public string ToCity;
        public string JDate;
        public string TicketNumber;
        public string ServiceNumber;
        public string UIDNumber;
        public string MobileNumber;
    }

   
}
