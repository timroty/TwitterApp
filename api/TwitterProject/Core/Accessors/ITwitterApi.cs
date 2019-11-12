using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Accessors
{
    public interface ITwitterApi
    {
        List<string> RetrieveTweets(string userName, int numTweets, string userAccessSecret, string consumerSecret);
    }
}
