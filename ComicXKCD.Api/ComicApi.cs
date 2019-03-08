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
        /// <summary>
        /// Returns today's comic
        /// </summary>
        /// <returns></returns>
        public static Result<Comic> GetTodayComic()
        {
            var client = new RestClient(API_BASE);

            var request = new RestRequest("info.0.json");

            var response = client.Execute<Comic>(request);

            if (response.IsSuccessful && response.Data != null)
            {
                return new Result<Comic>()
                {
                    Success = true,
                    Data = response.Data,
                    Message = response.Data.num.ToString()
                };
            }
            return new Result<Comic>()
            {
                Success = false,
                Message = "An error occurred retrieving the data"
            };

        }
        /// <summary>
        /// Returns a comic by its number
        /// </summary>
        /// <param name="num">Comic's number to retrieve</param>
        /// <returns></returns>
        public static Result<Comic> GetByNumber(int num)
        {
            var today = GetTodayComic();
            if (num < 1)
            {
                num = 1;
            }
            else if (today.Success && today.Data.num < num)
            {
                return today;
            }

            var client = new RestClient(API_BASE);

            var request = new RestRequest("{num}/info.0.json");

            request.AddUrlSegment("num", num);

            var response = client.Execute<Comic>(request);

            if (response.IsSuccessful && response.Data != null)
            {
                return new Result<Comic>()
                {
                    Success = true,
                    Data = response.Data,
                    Message = today.Data.num.ToString()
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
