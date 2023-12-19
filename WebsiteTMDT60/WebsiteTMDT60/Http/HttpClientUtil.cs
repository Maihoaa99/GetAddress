namespace WebsiteTMDT60.Http
{
    public class HttpClientUtil : HttpClient
    {
        public HttpClientUtil(string? baseApiUrl = null)
        {
            if (!string.IsNullOrEmpty(baseApiUrl))
            {
                this.BaseAddress = new Uri(baseApiUrl);
            }
        }
        public async Task<T> Get<T>(string pathUri)
        {
            HttpResponseMessage response = await this.GetAsync(pathUri);
            if (response.IsSuccessStatusCode)
            {
                var resultData = await response.Content.ReadAsAsync<T>();
                return resultData;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
