using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicXKCD.Api.Models
{
    public class Comic
    {
        /// <summary>
        /// Year
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// Month
        /// </summary>
        public string month { get; set; }
        /// <summary>
        /// Day
        /// </summary>
        public string day { get; set; }
        /// <summary>
        /// Comic number
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// Url
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string news { get; set; }
        /// <summary>
        /// Safe Title
        /// </summary>
        public string safe_title { get; set; }
        /// <summary>
        /// Transcript
        /// </summary>
        public string transcript { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        public string alt { get; set; }
        /// <summary>
        /// Image
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string title { get; set; }
    }
}
