using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ComicXKCD.Api.Models;

namespace ComicXKCD.Api
{
    public class ComicApi
    {
        private const string API_BASE = "https://xkcd.com/";

        public static Result<Comic> GetTodayComic()
        {
            var client = new RestClient(API_BASE);

            var request = new RestRequest("info.0.json");

            var response = client.Execute<Comic>(request);

            if(response.IsSuccessful && response.Data != null)
            {
                return new Result<Comic>()
                {
                    Success = true,
                    Data = response.Data
                };
            }
            return new Result<Comic>()
            {
                Success = false,
                Message = "An error occurred retrieving the data"
            };

        }
    }
}
