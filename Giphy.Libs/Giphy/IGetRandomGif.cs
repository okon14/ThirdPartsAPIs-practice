using Giphy.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Giphy.Libs.Giphy
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCriteria);
    }
}
