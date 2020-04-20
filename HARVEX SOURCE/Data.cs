using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eggpies
{
    public partial class Form1 : Form
    {
        Image imgAFR = Image.FromFile(@"continents/AFR.png");
        Image imgAFRsat = Image.FromFile(@"continents/AFR-sat.png");
        Image imgANT = Image.FromFile(@"continents/ANT.png");
        Image imgANTsat = Image.FromFile(@"continents/ANT-sat.png");
        Image imgASI = Image.FromFile(@"continents/ASI.png");
        Image imgASIsat = Image.FromFile(@"continents/ASI-sat.png");
        Image imgEUR = Image.FromFile(@"continents/EUR.png");
        Image imgEURsat = Image.FromFile(@"continents/EUR-sat.png");
        Image imgNAM = Image.FromFile(@"continents/NAM.png");
        Image imgNAMsat = Image.FromFile(@"continents/NAM-sat.png");
        Image imgOCE = Image.FromFile(@"continents/OCE.png");
        Image imgOCEsat = Image.FromFile(@"continents/OCE-sat.png");
        Image imgSAM = Image.FromFile(@"continents/SAM.png");
        Image imgSAMsat = Image.FromFile(@"continents/SAM-sat.png");

        private void InitializeRealmCountries()
        {
            RC = new string[] { "AUS", "FJI", "IDN", "NRU", "NCL",
            "NZL", "NFK", "PNG", "SLB", "TLS", "TUV", "VUT",
            "ATA", "ATF", "BVT", "HMD", "SGS",
            "AGO", "BDI", "BEN", "BFA", "BWA", "CAF", "CIV", "CMR", "COD", "COG",
            "COM", "CPV", "DJI", "ERI", "ETH", "GAB", "GHA", "GIN", "GMB", "GNB",
            "GNQ", "KEN", "LBR", "LSO", "MDG", "MLI", "MOZ", "MRT", "MUS", "MWI",
            "MYT", "NAM", "NER", "NGA", "OMN", "REU", "RWA", "SEN", "SHN", "SLE",
            "SOM", "SSD", "STP", "SWZ", "SYC", "TCD", "TGO", "TZA", "UGA", "YEM",
            "ZAF", "ZMB", "ZWE",
            "BGD", "BRN", "BTN", "CCK", "CHN", "CXR", "HKG", "IDN", "IND", "IOT",
            "JPN", "KHM", "LAO", "LKA", "MAC", "MDV", "MMR", "MYS", "NPL", "PAK",
            "PHL", "SGP", "THA", "TWN", "VNM",
            "BMU", "CAN", "GRL", "MEX", "SPM", "USA",
            "AIA", "ATG", "ARG", "ABW", "BHS", "BRB", "BLZ", "BOL", "BES", "BRA",
            "CYM", "CHL", "COL", "CRI", "CUB", "CUW", "DMA", "DOM", "ECU", "MEX",
            "SLV", "FLK", "GUF", "GRD", "GLP", "GTM", "GUY", "HTI", "HND", "JAM",
            "MTQ", "MSR", "NIC", "PAN", "PRY", "PER", "PRI", "BLM", "KNA", "LCA",
            "MAF", "VCT", "SXM", "SUR", "TTO", "TCA", "URY", "VEN", "VGB", "VIR",
            "ASM", "COK", "PYF", "GUM", "KIR", "MHL", "FSM", "NIU", "MNP", "PLW",
            "PCN", "WSM", "TKL", "TON", "UMI", "WLF",
            "AFG", "ALA", "ALB", "AND", "ARE", "ARM", "AUT", "AZE", "BEL", "BGR",
            "BHR", "BIH", "BLR", "BTN", "CHE", "CHN", "CYP", "CZE", "DEU", "DNK",
            "DZA", "EGY", "ESH", "ESP", "EST", "FIN", "FRA", "FRO", "GBR", "GEO",
            "GGY", "GIB", "GRC", "HRV", "HUN", "IMN", "IRL", "IRN", "IRQ", "ISL",
            "ISR", "ITA", "JEY", "JOR", "JPN", "KAZ", "KGZ", "KOR", "KWT", "LBN",
            "LBY", "LIE", "LTU", "LUX", "LVA", "MAR", "MCO", "MDA", "MKD", "MLI",
            "MLT", "MNE", "MNG", "MRT", "NER", "NLD", "NOR", "NPL", "OMN", "PAK",
            "POL", "PRK", "PRT", "PSE", "QAT", "ROU", "RUS", "SAU", "SDN", "SJM",
            "SMR", "SRB", "SVK", "SVN", "SWE", "SYR", "TCD", "TJK", "TKM", "TUN",
            "TUR", "UKR", "UZB", "VAT", "YEM"
            };
            int AA = 12, AN = 5, AT = 53, IM = 25, NA = 6, NT = 50, OC = 16, PA = 95;
            startRC[0] = 0;
            endRC[0] = startRC[0] + AA;
            startRC[1] = endRC[0];
            endRC[1] = startRC[1] + AN;
            startRC[2] = endRC[1];
            endRC[2] = startRC[2] + AT;
            startRC[3] = endRC[2];
            endRC[3] = startRC[3] + IM;
            startRC[4] = endRC[3];
            endRC[4] = startRC[4] + NA;
            startRC[5] = endRC[4];
            endRC[5] = startRC[5] + NT;
            startRC[6] = endRC[5];
            endRC[6] = startRC[6] + OC;
            startRC[7] = endRC[6];
            endRC[7] = startRC[7] + PA;
        }

        public class Mode {
            public bool byRealm, byCountry, byAuthor,
                genus, family, subfamily,
                byGenus, byFamily, bySubfamily,
                endemic, realm, country, byContinents;
            public Mode()
            {
                byRealm = false;
                byCountry = false;
                byAuthor = false;
                genus = true;
                family = false;
                subfamily = false;
                byGenus = false;
                byFamily = false;
                bySubfamily = false;
                endemic = false;
                realm = true;
                country = false;
                byContinents = false;
            }
            public void ByRealm()
            {
                byRealm = true;
                byCountry = false;
                byGenus = false;
                byFamily = false;
                bySubfamily = false;
                byContinents = false;
            }
            public void ByCountry()
            {
                byRealm = false;
                byCountry = true;
                byGenus = false;
                byFamily = false;
                bySubfamily = false;
                byContinents = false;
            }
            public void Genus()
            {
                genus = true;
                family = false;
                subfamily = false;
            }
            public void Family()
            {
                genus = false;
                family = true;
                subfamily = false;
            }
            public void Subfamily()
            {
                genus = false;
                family = false;
                subfamily = true;
            }
            public void ByGenus()
            {
                byAuthor = false;
                byRealm = false;
                byCountry = false;
                byGenus = true;
                byFamily = false;
                bySubfamily = false;
                byContinents = false;
            }
            public void ByFamily()
            {
                byAuthor = false;
                byRealm = false;
                byCountry = false;
                byGenus = false;
                byFamily = true;
                bySubfamily = false;
                byContinents = false;
            }
            public void BySubfamily()
            {
                byAuthor = false;
                byRealm = false;
                byCountry = false;
                byGenus = false;
                byFamily = false;
                byContinents = false;
                bySubfamily = true;
            }
            public void Realm()
            {
                country = false;
                realm = true;
            }
            public void Country()
            {
                country = true;
                realm = false;
            }
            public void ByContinents()
            {
                byAuthor = false;
                byRealm = false;
                byCountry = false;
                byGenus = false;
                byFamily = false;
                bySubfamily = false;
                byContinents = true;
            }
        }

        private string ShowCountryName(string s)
        {
            if (s == "AND") return "Andorra";
            else if (s == "AA") return "Australasian";
            else if (s == "AN") return "Antarctica";
            else if (s == "AT") return "Afrotropical";
            else if (s == "IM") return "Indo-Malayan";
            else if (s == "NA") return "Nearctic";
            else if (s == "NT") return "Neotropical";
            else if (s == "OC") return "Oceania";
            else if (s == "PA") return "Palearctic";
            else if (s == "ARE") return "United Arab Emirates";
            else if (s == "AFG") return "Afghanistan";
            else if (s == "ATG") return "Antigua and Barbuda";
            else if (s == "AIA") return "Anguilla";
            else if (s == "ALB") return "Albania";
            else if (s == "ARM") return "Armenia";
            else if (s == "AGO") return "Angola";
            else if (s == "ATA") return "Antarctica";
            else if (s == "ARG") return "Argentina";
            else if (s == "ASM") return "American Samoa";
            else if (s == "AUT") return "Austria";
            else if (s == "AUS") return "Australia";
            else if (s == "ABW") return "Aruba";
            else if (s == "AZE") return "Azerbaijan";
            else if (s == "BIH") return "Bosnia and Herzegovina";
            else if (s == "BRB") return "Barbados";
            else if (s == "BGD") return "Bangladesh";
            else if (s == "BEL") return "Belgium";
            else if (s == "BFA") return "Burkina Faso";
            else if (s == "BGR") return "Bulgaria";
            else if (s == "BHR") return "Bahrain";
            else if (s == "BDI") return "Burundi";
            else if (s == "BEN") return "Benin";
            else if (s == "BLM") return "Saint Barthelemy";
            else if (s == "BMU") return "Bermuda";
            else if (s == "BRN") return "Brunei Darussalam";
            else if (s == "BOL") return "Bolivia";
            else if (s == "BES") return "Bonaire";
            else if (s == "BRA") return "Brazil";
            else if (s == "BHS") return "Bahamas";
            else if (s == "BTN") return "Bhutan";
            else if (s == "BVT") return "Bouvet Island";
            else if (s == "BWA") return "Botswana";
            else if (s == "BLR") return "Belarus";
            else if (s == "BLZ") return "Belize";
            else if (s == "CAN") return "Canada";
            else if (s == "CCK") return "Cocos (Keeling) Islands";
            else if (s == "COD") return "Democratic Republic of the Congo";
            else if (s == "CAF") return "Central African Republic";
            else if (s == "COG") return "Congo";
            else if (s == "CHE") return "Switzerland";
            else if (s == "CIV") return "Cote d'Ivoire";
            else if (s == "COK") return "Cook Islands";
            else if (s == "CHL") return "Chile";
            else if (s == "CMR") return "Cameroon";
            else if (s == "CHN") return "China";
            else if (s == "COL") return "Colombia";
            else if (s == "CRI") return "Costa Rica";
            else if (s == "CUB") return "Cuba";
            else if (s == "CPV") return "Cape Verde";
            else if (s == "CUW") return "Curacao";
            else if (s == "CXR") return "Christmas Island";
            else if (s == "CYP") return "Cyprus";
            else if (s == "CZE") return "Czech Republic";
            else if (s == "DEU") return "Germany";
            else if (s == "DJI") return "Djibouti";
            else if (s == "DNK") return "Denmark";
            else if (s == "DMA") return "Dominica";
            else if (s == "DOM") return "Dominican Republic";
            else if (s == "DZA") return "Algeria";
            else if (s == "ECU") return "Ecuador";
            else if (s == "EST") return "Estonia";
            else if (s == "EGY") return "Egypt";
            else if (s == "ESH") return "Western Sahara";
            else if (s == "ERI") return "Eritrea";
            else if (s == "ESP") return "Spain";
            else if (s == "ETH") return "Ethiopia";
            else if (s == "FIN") return "Finland";
            else if (s == "FJI") return "Fiji";
            else if (s == "FLK") return "Falkland Islands (Malvinas)";
            else if (s == "FSM") return "Micronesia, Federated States of";
            else if (s == "FRO") return "Faroe Islands";
            else if (s == "FRA") return "France";
            else if (s == "GAB") return "Gabon";
            else if (s == "GBR") return "United Kingdom";
            else if (s == "GRD") return "Grenada";
            else if (s == "GEO") return "Georgia";
            else if (s == "GUF") return "French Guiana";
            else if (s == "GGY") return "Guernsey";
            else if (s == "GHA") return "Ghana";
            else if (s == "GIB") return "Gibraltar";
            else if (s == "GRL") return "Greenland";
            else if (s == "GMB") return "Gambia";
            else if (s == "GIN") return "Guinea";
            else if (s == "GLP") return "Guadeloupe";
            else if (s == "GNQ") return "Equatorial Guinea";
            else if (s == "GRC") return "Greece";
            else if (s == "SGS") return "South Georgia and the South Sandwich Islands";
            else if (s == "GTM") return "Guatemala";
            else if (s == "GUM") return "Guam";
            else if (s == "GNB") return "Guinea-Bissau";
            else if (s == "GUY") return "Guyana";
            else if (s == "HKG") return "Hong Kong";
            else if (s == "HMD") return "Heard Island and McDonald Islands";
            else if (s == "HND") return "Honduras";
            else if (s == "HRV") return "Croatia";
            else if (s == "HTI") return "Haiti";
            else if (s == "HUN") return "Hungary";
            else if (s == "IDN") return "Indonesia";
            else if (s == "IRL") return "Ireland";
            else if (s == "ISR") return "Israel";
            else if (s == "IMN") return "Isle of Man";
            else if (s == "IND") return "India";
            else if (s == "IOT") return "British Indian Ocean Territory";
            else if (s == "IRQ") return "Iraq";
            else if (s == "IRN") return "Iran, Islamic Republic of";
            else if (s == "ISL") return "Iceland";
            else if (s == "ITA") return "Italy";
            else if (s == "JEY") return "Jersey";
            else if (s == "JAM") return "Jamaica";
            else if (s == "JOR") return "Jordan";
            else if (s == "JPN") return "Japan";
            else if (s == "KEN") return "Kenya";
            else if (s == "KGZ") return "Kyrgyzstan";
            else if (s == "KHM") return "Cambodia";
            else if (s == "KIR") return "Kiribati";
            else if (s == "COM") return "Comoros";
            else if (s == "KNA") return "Saint Kitts and Nevis";
            else if (s == "PRK") return "Korea, Democratic People's Republic of";
            else if (s == "KOR") return "Korea, Republic of";
            else if (s == "KWT") return "Kuwait";
            else if (s == "CYM") return "Cayman Islands";
            else if (s == "KAZ") return "Kazakhstan";
            else if (s == "LAO") return "Lao People's Democratic Republic";
            else if (s == "LBN") return "Lebanon";
            else if (s == "LCA") return "Saint Lucia";
            else if (s == "LIE") return "Liechtenstein";
            else if (s == "LKA") return "Sri Lanka";
            else if (s == "LBR") return "Liberia";
            else if (s == "LSO") return "Lesotho";
            else if (s == "LTU") return "Lithuania";
            else if (s == "LUX") return "Luxembourg";
            else if (s == "LVA") return "Latvia";
            else if (s == "LBY") return "Libya";
            else if (s == "MAR") return "Morocco";
            else if (s == "MCO") return "Monaco";
            else if (s == "MDA") return "Moldova, Republic of";
            else if (s == "MNE") return "Montenegro";
            else if (s == "MAF") return "Saint Martin (French part)";
            else if (s == "MDG") return "Madagascar";
            else if (s == "MHL") return "Marshall Islands";
            else if (s == "MKD") return "Macedonia, the Former Yugoslav Republic of";
            else if (s == "MLI") return "Mali";
            else if (s == "MMR") return "Myanmar";
            else if (s == "MNG") return "Mongolia";
            else if (s == "MAC") return "Macao";
            else if (s == "MNP") return "Northern Mariana Islands";
            else if (s == "MTQ") return "Martinique";
            else if (s == "MRT") return "Mauritania";
            else if (s == "MSR") return "Montserrat";
            else if (s == "MLT") return "Malta";
            else if (s == "MUS") return "Mauritius";
            else if (s == "MDV") return "Maldives";
            else if (s == "MWI") return "Malawi";
            else if (s == "MEX") return "Mexico";
            else if (s == "MYS") return "Malaysia";
            else if (s == "MOZ") return "Mozambique";
            else if (s == "NAM") return "Namibia";
            else if (s == "NCL") return "New Caledonia";
            else if (s == "NER") return "Niger";
            else if (s == "NFK") return "Norfolk Island";
            else if (s == "NGA") return "Nigeria";
            else if (s == "NIC") return "Nicaragua";
            else if (s == "NLD") return "Netherlands";
            else if (s == "NOR") return "Norway";
            else if (s == "NPL") return "Nepal";
            else if (s == "NRU") return "Nauru";
            else if (s == "NIU") return "Niue";
            else if (s == "NZL") return "New Zealand";
            else if (s == "OMN") return "Oman";
            else if (s == "PAN") return "Panama";
            else if (s == "PER") return "Peru";
            else if (s == "PYF") return "French Polynesia";
            else if (s == "PNG") return "Papua New Guinea";
            else if (s == "PHL") return "Philippines";
            else if (s == "PAK") return "Pakistan";
            else if (s == "POL") return "Poland";
            else if (s == "SPM") return "Saint Pierre and Miquelon";
            else if (s == "PCN") return "Pitcairn";
            else if (s == "PRI") return "Puerto Rico";
            else if (s == "PSE") return "Palestine, State of";
            else if (s == "PRT") return "Portugal";
            else if (s == "PLW") return "Palau";
            else if (s == "PRY") return "Paraguay";
            else if (s == "QAT") return "Qatar";
            else if (s == "REU") return "Reunion";
            else if (s == "ROU") return "Romania";
            else if (s == "SRB") return "Serbia";
            else if (s == "RUS") return "Russian Federation";
            else if (s == "RWA") return "Rwanda";
            else if (s == "SAU") return "Saudi Arabia";
            else if (s == "SLB") return "Solomon Islands";
            else if (s == "SYC") return "Seychelles";
            else if (s == "SDN") return "Sudan";
            else if (s == "SWE") return "Sweden";
            else if (s == "SGP") return "Singapore";
            else if (s == "SHN") return "Saint Helena";
            else if (s == "SVN") return "Slovenia";
            else if (s == "SJM") return "Svalbard and Jan Mayen";
            else if (s == "SVK") return "Slovakia";
            else if (s == "SLE") return "Sierra Leone";
            else if (s == "SMR") return "San Marino";
            else if (s == "SEN") return "Senegal";
            else if (s == "SOM") return "Somalia";
            else if (s == "SUR") return "Suriname";
            else if (s == "SSD") return "South Sudan";
            else if (s == "STP") return "Sao Tome and Principe";
            else if (s == "SLV") return "El Salvador";
            else if (s == "SXM") return "Sint Maarten (Dutch part)";
            else if (s == "SYR") return "Syrian Arab Republic";
            else if (s == "SWZ") return "Swaziland";
            else if (s == "TCA") return "Turks and Caicos Islands";
            else if (s == "TCD") return "Chad";
            else if (s == "ATF") return "French Southern Territories";
            else if (s == "TGO") return "Togo";
            else if (s == "THA") return "Thailand";
            else if (s == "TJK") return "Tajikistan";
            else if (s == "TKL") return "Tokelau";
            else if (s == "TLS") return "Timor-Leste";
            else if (s == "TKM") return "Turkmenistan";
            else if (s == "TUN") return "Tunisia";
            else if (s == "TON") return "Tonga";
            else if (s == "TUR") return "Turkey";
            else if (s == "TTO") return "Trinidad and Tobago";
            else if (s == "TUV") return "Tuvalu";
            else if (s == "TWN") return "Taiwan";
            else if (s == "TZA") return "United Republic of Tanzania";
            else if (s == "UKR") return "Ukraine";
            else if (s == "UGA") return "Uganda";
            else if (s == "UMI") return "United States Minor Outlying Islands";
            else if (s == "USA") return "United States";
            else if (s == "URY") return "Uruguay";
            else if (s == "UZB") return "Uzbekistan";
            else if (s == "VAT") return "Holy See (Vatican City State)";
            else if (s == "VCT") return "Saint Vincent and the Grenadines";
            else if (s == "VEN") return "Venezuela";
            else if (s == "VGB") return "British Virgin Islands";
            else if (s == "VIR") return "US Virgin Islands";
            else if (s == "VNM") return "Viet Nam";
            else if (s == "VUT") return "Vanuatu";
            else if (s == "WLF") return "Wallis and Futuna";
            else if (s == "WSM") return "Samoa";
            else if (s == "YEM") return "Yemen";
            else if (s == "MYT") return "Mayotte";
            else if (s == "ZAF") return "South Africa";
            else if (s == "ZMB") return "Zambia";
            else if (s == "ZWE") return "Zimbabwe";
            else if (s == "?") return "Unknown";
            else if (s == "ECUorPER") return "Ecuador or Peru";
            else return "ERROR";
        }

        private string[] countriesAFR = { "BWA", "CAF", "CIV", "CMR", "COD", "COG", "COM", "CPV", "DJI", "DZA", "EGY", "ERI", "ESH", "ETH", "GAB", "GHA", "GIN", "GMB", "GNB", "GNQ", "KEN", "LBR", "LBY", "LSO", "MAR", "MDG", "MLI", "MOZ", "MRT", "MUS", "MWI", "MYT", "NAM", "NER", "NGA", "REU", "RWA", "SDN", "SEN", "SHN", "SLE", "SOM", "SSD", "STP", "SWZ", "SYC", "TCD", "TGO", "TUN", "TZA", "UGA", "ZAF", "ZMB", "ZWE" };
        private string[] countriesANT = { "ATA", "ATF", "BVT", "HMD", "SGS" };
        private string[] countriesASI = { "AFG", "ARE", "BGD", "BHR", "BRN", "BTN", "CCK", "CHN", "CXR", "HKG", "IDN", "IND", "IOT", "IRN", "IRQ", "ISR", "JOR", "JPN", "KAZ", "KGZ", "KHM", "KOR", "KWT", "LAO", "LBN", "LKA", "MAC", "MDV", "MMR", "MNG", "MYS", "NPL", "OMN", "PAK", "PHL", "PRK", "PSE", "QAT", "RUS", "SAU", "SGP", "SYR", "THA", "TJK", "TKM", "TUR", "TWN", "UZB", "VNM", "YEM" };
        private string[] countriesEUR = { "ALB", "AND", "ARM", "AUT", "AZE", "BEL", "BGR", "BIH", "BLR", "CHE", "CYP", "CZE", "DEU", "DNK", "ESP", "EST", "FIN", "FRA", "FRO", "GBR", "GEO", "GGY", "GIB", "GRC", "HRV", "HUN", "IMN", "IRL", "ISL", "ITA", "JEY", "LIE", "LTU", "LUX", "LVA", "MCO", "MDA", "MKD", "MLT", "MNE", "NLD", "NOR", "POL", "PRT", "ROU", "RUS", "SJM", "SMR", "SRB", "SVK", "SVN", "SWE", "UKR", "VAT" };
        private string[] countriesNAM = { "ABW", "AIA", "ATG", "BES", "BHS", "BLM", "BLZ", "BMU", "BRB", "CAN", "CRI", "CUB", "CUW", "CYM", "DMA", "DOM", "GLP", "GRD", "GRL", "GTM", "HND", "HTI", "JAM", "KNA", "LCA", "MAF", "MEX", "MSR", "MTQ", "NIC", "PAN", "PRI", "SLV", "SPM", "SXM", "TCA", "USA", "VCT", "VGB", "VIR" };
        private string[] countriesOCE = { "ASM", "AUS", "COK", "FJI", "FSM", "GUM", "KIR", "MHL", "MNP", "NCL", "NFK", "NIU", "NRU", "NZL", "PCN", "PLW", "PNG", "PYF", "SLB", "TKL", "TLS", "TON", "TUV", "UMI", "VUT", "WLF", "WSM" };
        private string[] countriesSAM = { "ARG", "BOL", "BRA", "CHL", "COL", "ECU", "FLK", "GUF", "GUY", "PER", "PRY", "SUR", "TTO", "URY", "VEN" };
    }
}
