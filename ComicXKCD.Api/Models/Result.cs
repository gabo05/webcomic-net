using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicXKCD.Api.Models
{
    public class Result<T>
    {
        /// <summary>
        /// Whether the response is success or not
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// A message that describes the response
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Retrieved data
        /// </summary>
        public T Data { get; set; }
    }
}
