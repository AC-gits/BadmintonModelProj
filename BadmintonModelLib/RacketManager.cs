using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Business logic

namespace BadmintonModelLib
{
    public class RacketManager
    {
        public BadmintonRacket GetRacket(string brand, string model)
        {
            switch (brand)
            {
                case "Yonex":
                    return RacketData.GetYonexRacket(model);
                case "Victor":
                    return RacketData.GetVictorRacket(model);
                case "Li-Ning":
                    return RacketData.GetLiNingRacket(model);
                default:
                    return null;
            }
        }
    }
}
