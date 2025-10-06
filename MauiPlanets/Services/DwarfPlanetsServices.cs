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
                Name = "Pluto",
                Subtitle = "The outcast",
                HeroImage = "dwarf_pluuto.png",
                Description = "Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume by a small margin, but is less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has roughly one-sixth the mass of the Moon and one-third of its volume. Originally considered a planet, its classification was changed when astronomers adopted a new definition of planet.\r\n\r\nPluto has a moderately eccentric and inclined orbit, ranging from 30 to 49 astronomical units (4.5 to 7.3 billion kilometres; 2.8 to 4.6 billion miles) from the Sun. Light from the Sun takes 5.5 hours to reach Pluto at its orbital distance of 39.5 AU (5.91 billion km; 3.67 billion mi). Pluto's eccentric orbit periodically brings it closer to the Sun than Neptune, but a stable orbital resonance prevents them from colliding.",
                AccentColorStart = Color.FromArgb("#344CB7"),
                AccentColorEnd = Color.FromArgb("#577BC1"),
                Images = new()
                {
                    "https://images.theconversation.com/files/115326/original/image-20160316-30206-h27pf.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1000&fit=clip",
                    "https://pyxis.nymag.com/v1/imgs/25c/4ce/1dee1e98d5e9e558cd0426ffae3d85776c-Pluto.rsquare.w400.jpg",
                    "https://i.pinimg.com/736x/72/fe/10/72fe10f13ae6f6ec4312c783f82b14c8.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The rogue",
                HeroImage = "dwarf_ceres.png",
                Description = "Ceres is a dwarf planet in the main asteroid belt between the orbits of Mars and Jupiter. It was the first known asteroid, discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new planet. Ceres was later classified as an asteroid and more recently as a dwarf planet, the only one not beyond the orbit of Neptune and the largest that does not have a moon.\r\n\r\nCeres's diameter is about a quarter that of the Moon. Its small size means that even at its brightest it is too dim to be seen by the naked eye, except under extremely dark skies. Its apparent magnitude ranges from 6.7 to 9.3, peaking at opposition (when it is closest to Earth) once every 15- to 16-month synodic period. As a result, its surface features are barely visible even with the most powerful telescopes, and little was known about it until the robotic NASA spacecraft Dawn approached Ceres for its orbital mission in 2015.",
                AccentColorStart = Color.FromArgb("#6C48C5"),
                AccentColorEnd = Color.FromArgb("#C68FE6"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/c/ceres_th.jpg?fit=clip&crop=faces%2Cfocalpoint&w=300",
                    "https://ww2.kqed.org/app/uploads/sites/35/2016/01/ceres-occator-672x372.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The deformed",
                HeroImage = "dwarf_haumea.png",
                Description = "Haumea (minor-planet designation: 136108 Haumea) is a dwarf planet located beyond Neptune's orbit.[25] It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory, and formally announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in Spain, who had discovered it that year in precovery images taken by the team in 2003. From that announcement, it received the provisional designation 2003 EL61.\r\n\r\nOn 17 September 2008, it was named after Haumea, the Hawaiian goddess of childbirth and fertility, under the expectation by the International Astronomical Union (IAU) that it would prove to be a dwarf planet. Nominal estimates make it the third-largest known trans-Neptunian object, after Eris and Pluto, and approximately the size of Uranus's moon Titania. Precovery images of Haumea have been identified back to 22 March 1955.",
                AccentColorStart = Color.FromArgb("#4FB7B3"),
                AccentColorEnd = Color.FromArgb("#A8FBD3"),
                Images = new()
                {
                    "https://cdn.sci.news/images/enlarge10/image_11303e-Haumea.jpg",
                    "https://www.universetoday.com/article_images/haumea_nasa.jpg",
                    "https://www.crystalvaults.com/wp-content/uploads/2025/04/Haumea.png"
                }
            },

            new()
            {
                Name = "Makemake",
                Subtitle = "The maker",
                HeroImage = "dwarf_makemake.png",
                Description = "Makemake[g] (minor-planet designation: 136472 Makemake) is a dwarf planet and the largest of what is known as the classical population of Kuiper belt objects,[b] with a diameter of 1,430 kilometres (890 mi), or 60% that of Pluto.[24] It has one known satellite, which has not been named. Its extremely low average temperature, between 30 and 40 K (−240 and −230 °C), means its surface is covered with frozen methane, which eventually breaks down into heavier organic compounds including ethane, ethylene, and acetylene.[13] Makemake appears reddish-brown in color like Pluto,[h] due to tholins on its surface. Makemake shows signs of geothermal activity and thus may be capable of supporting active geology and harboring an active subsurface ocean.[25]\r\n\r\nMakemake was discovered on March 31, 2005, by a team led by Michael E. Brown, and announced on July 29, 2005. It was initially known as 2005 FY9 and later given the minor-planet number 136472. In July 2008, it was named after Makemake, a creator god in the Rapa Nui mythology of Easter Island, under the expectation by the International Astronomical Union (IAU) that it would prove to be a dwarf planet.",
                AccentColorStart = Color.FromArgb("#FAD691"),
                AccentColorEnd = Color.FromArgb("#ED775A"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8-430-80.jpg",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/makemake.png",
                    "https://www.universetoday.com/article_images/Makemake.jpg"
                }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "The outcast",
                HeroImage = "dwarf_eris.png",
                Description = "Eris (minor-planet designation: 136199 Eris) is the most massive and second-largest known dwarf planet in the Solar System.[22] It is a trans-Neptunian object (TNO) in the scattered disk and has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team led by Mike Brown and verified later that year. It was named in September 2006 after the Greco–Roman goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the sixteenth-most massive in the Solar System (counting moons). It is also the largest known object in the Solar System that has not been visited by a spacecraft. Eris has been measured at 2,326 ± 12 kilometres (1,445 ± 7 mi) in diameter;[12] its mass is 0.28% that of the Earth and 27% greater than that of Pluto,[23][24] although Pluto is slightly larger by volume.[25] Both Eris and Pluto have a surface area that is comparable to that of Russia or South America.\r\n\r\nEris has one large known moon, Dysnomia. In February 2016, Eris's distance from the Sun was 96.3 AU (14.41 billion km; 8.95 billion mi),[20] more than three times that of Neptune or Pluto. With the exception of long-period comets, Eris and Dysnomia were the most distant known natural objects in the Solar System until the discovery of 2018 AG37 and 2018 VG18 in 2018.",
                AccentColorStart = Color.FromArgb("#AED6CF"),
                AccentColorEnd = Color.FromArgb("#91ADC8"),
                Images = new()
                {
                    "https://www.universetoday.com/article_images/2007-0613eris.jpg",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/eris.png",
                    "https://starchild.gsfc.nasa.gov/Images/StarChild/solar_system_level2/eris_and_dysnomia_485.jpg"
                }
            },

        };

        public static List<DwarfPlanet> GetAllDwarfPlanets()
            => dwarfPlanets;
    }
}
