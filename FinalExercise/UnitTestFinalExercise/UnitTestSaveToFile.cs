using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Step02;
using FinalExercise;
using WeatherServices;

namespace UnitTestFinalExercise
{
    [TestClass]
    public class UnitTestSaveToFile
    {
        [TestMethod]
        public void TestSaveTologFile()
        {
            //Specifying optional settings
            ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5";
            ClientSettings.ApiKey = "ab25de4968aa6a65f4209cd2bed122da";


            //Simply Test if file is created
            WeatherConditions weatherConditions = new WeatherConditions();
            Log.SaveLog(weatherConditions);
            Assert.IsTrue(File.Exists("log.txt"));            
        }
    }
}