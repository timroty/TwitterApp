using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Engines
{
    public interface ITweetEngine
    {
        int CalculateAvgFavorites(List<TweetObject> tweets);
        int CalculateAvgRetweets(List<TweetObject> tweets);
    }
}
