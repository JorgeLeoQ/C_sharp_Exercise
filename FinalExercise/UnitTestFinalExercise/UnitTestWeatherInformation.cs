using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalExercise;

namespace UnitTestFinalExercise
{
    [TestClass]
    public class UnitTestWeatherInformation
    {
        [TestMethod]
        public void GetCurrentWeatherByCityNameTest()
        {
            //Specifying optional settings
            ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5";
            ClientSettings.ApiKey = "ab25de4968aa6a65f4209cd2bed122da";


            //Do not Exist
            SingleResult<CurrentWeatherResult> result = new SingleResult<CurrentWeatherResult>();
            CurrentWeather currWeather = new CurrentWeather();
            result = currWeather.GetByCityName("London", "uk");
            
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Item);
        }
    }
}