using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public interface ITweetManager
    {
        IEnumerable<string> SelectTweets(string userName, int numTweets, string userAccessSecret,
            string consumerSecret);
    }
}
