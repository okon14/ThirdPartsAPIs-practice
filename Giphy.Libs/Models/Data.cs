using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Giphy.Libs.Models
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "bitly_gif_url")]
        public string BitlyGifUrl { get; set; }
    }
}
