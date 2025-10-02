using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    internal class DwarfPlanetsServices
    {
        private static List<DwarfPlanet> dwarfPlanets = new()
        {
            new()
            {
                Name = "TestDwarf",
                Subtitle = "Testing",
                HeroImage = "mercury.png",
                Description = "Test",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("FFFFFF"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg"
                }
            },
        };

        public static List<DwarfPlanet> GetAllDwarfPlanets()
            => dwarfPlanets;
    }
}
