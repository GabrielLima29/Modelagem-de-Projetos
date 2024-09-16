using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridgeLive
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdvancedLive advancedLive = new AdvancedLive(new Facebook());
            advancedLive.Broadcasting();
            advancedLive.Result();
            advancedLive.Subtitles();
            advancedLive.Comments();

            advancedLive = new AdvancedLive(new Youtube());
            advancedLive.Broadcasting();
            advancedLive.Result();
            advancedLive.Subtitles();
            advancedLive.Comments();

            advancedLive = new AdvancedLive(new TwitchTV());
            advancedLive.Broadcasting();
            advancedLive.Result();
            advancedLive.Subtitles();
            advancedLive.Comments();
        }
    }
}
