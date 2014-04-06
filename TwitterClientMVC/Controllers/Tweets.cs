using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterClientMVC.Controllers
{
    public class Tweets
    {
        public Tweet[] results;

    }


    public class Tweet {
        [JsonProperty("from_user")]
        public string UserName { get; set; }
        [JsonProperty("text")]
        public string TweetText { get; set; }
     }
}
