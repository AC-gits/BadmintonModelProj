using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DataLogic

namespace BadmintonModelLib
{
    public class RacketData
    {

        public static BadmintonRacket GetYonexRacket(string model)
        {
            switch (model)
            {
                case "Astrox 99":
                    return new BadmintonRacket { Brand = "Yonex", Model = "Astrox 99", Material = "Graphite", Weight = 85, Flexibility = 9 };
                case "Voltric Z-Force II":
                    return new BadmintonRacket { Brand = "Yonex", Model = "Voltric Z-Force II", Material = "Graphene", Weight = 88, Flexibility = 8 };
                case "Nanoflare 800":
                    return new BadmintonRacket { Brand = "Yonex", Model = "Nanoflare 800", Material = "Nanocell", Weight = 83, Flexibility = 9 };
                default:
                    return null;
            }
        }

        public static BadmintonRacket GetVictorRacket(string model)
        {
            switch (model)
            {
                case "Thruster K Falcon":
                    return new BadmintonRacket { Brand = "Victor", Model = "Thruster K Falcon", Material = "Graphene", Weight = 85, Flexibility = 9 };
                case "Jetspeed S 12":
                    return new BadmintonRacket { Brand = "Victor", Model = "Jetspeed S 12", Material = "Nanocell", Weight = 88, Flexibility = 8 };
                case "Auraspeed 90K":
                    return new BadmintonRacket { Brand = "Victor", Model = "Auraspeed 90K", Material = "Nano Tec", Weight = 83, Flexibility = 9 };
                default:
                    return null;
            }
        }

        public static BadmintonRacket GetLiNingRacket(string model)
        {
            switch (model)
            {
                case "Turbo Charging 75D":
                    return new BadmintonRacket { Brand = "Li-Ning", Model = "Turbo Charging 75D", Material = "Carbon fiber", Weight = 85, Flexibility = 9 };
                case "Windstorm 72":
                    return new BadmintonRacket { Brand = "Li-Ning", Model = "Windstorm 72", Material = "Graphite", Weight = 88, Flexibility = 8 };
                case "N9 II":
                    return new BadmintonRacket { Brand = "Li-Ning", Model = "N9 II", Material = "Nanocell", Weight = 83, Flexibility = 9 };
                default:
                    return null;
            }
        }
    }
}
