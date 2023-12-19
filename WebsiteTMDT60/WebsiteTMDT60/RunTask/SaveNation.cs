using WebsiteTMDT60.Http;
using WebsiteTMDT60.Models;

namespace WebsiteTMDT60.RunTask
{
    public class SaveNation
    {
        public static async Task RunTMDT()
        {
            string apiUrl = "https://provinces.open-api.vn/";
            string apitk = "api/?depth=3";
            HttpClientUtil clientUtil = new HttpClientUtil(apiUrl);
            List<City> cities = await clientUtil.Get<List<City>>(apitk);

            DatabaseContext citiesSet = new DatabaseContext();
            foreach (City city in cities)
            {
                citiesSet.Citys.Add(city);
            }
            citiesSet.SaveChanges();
        }
    }
}
