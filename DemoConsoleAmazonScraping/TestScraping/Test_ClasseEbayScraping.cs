using Xunit;
using FluentAssertions;
using DemoConsoleScraping;
using System.Text.RegularExpressions;

namespace TestScraping
{
    public class Test_ClasseEbayScraping
    {
        [Fact]
        public void WebResponseTest()
        {
            //Arrange
            var ping = new System.Net.NetworkInformation.Ping();

            //Act
            var result = ping.Send("www.ebay.it");

            //Assert
            result.Status.Should().Be(System.Net.NetworkInformation.IPStatus.Success);
        }
        [Fact]
        public void LayoutTest()
        {
            //Arrange
            string url = "https://www.ebay.it/itm/COMPUTER-PORTATILE-NOTEBOOK-HP-255-G8-15-6-AMD-RAM-4GB-SSD-256GB-NVMe-WEBCAM/362797930441?hash=item54787117c9:g:EnQAAOSwixNgBsTN";

            //Act
            string html = EbayScraping.GetRequest(url);
            EbayProduct result = EbayScraping.DataParse(html);

            //Assert
            result.name.Should().Be("COMPUTER PORTATILE NOTEBOOK HP 255 G8 15,6&#034; AMD RAM 4GB SSD 256GB NVMe WEBCAM");
            result.price.Should().Be(decimal.Parse("419,90"));
        }
        [Fact]
        public void WrongHtmlFormatTest()
        {
            //Arrange
            bool valid = false;
            string url = "https://www.amazon.it/dp/B086LY2YYZ";
            Regex tagRegex = new Regex(@"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");

            //Act
            string html = AmazonScraping.GetRequest(url);
            valid = tagRegex.IsMatch(html);

            //Assert            
            valid.Should().Be(true);
        }
        [Theory]
        [InlineData("https://www.ebay.it/itm/Faber-Castell-Grip-2001-Pencil/153597490820?hash=item23c31fb684:g:XVQAAOSwQkNgaBiq", 2.31)]
        [InlineData("https://www.ebay.it/itm/Adidas-ADILETTE-AQUA-UOMO-DONNA-BAMBINO-art-EG4159/153968057938?var=454049278996", 19.98, 25.00)]
        [InlineData("https://www.ebay.it/itm/CONSOLE-NINTENDO-SWITCH-GREY-JOYCON-BLUE-RED-BLU-ROSSO-GARANZIA-ITALIA/164478878906?hash=item264bb484ba:g:FmUAAOSwePdfnDGU", 309.90)]
        [InlineData("https://www.ebay.it/itm/127x95-cm-Portapacchi-Universale-in-Alluminio-Auto-Portapacchi-Cesto-Cargo-NERO/252989224108?hash=item3ae75534ac:g:2e4AAOSwXeJe7G6H", 99.99)]
        [InlineData("https://www.ebay.it/itm/Einhell-Rasaerba-Pxc-18V-Ge-Cm-18-30-Li-Batteria-Inclusa/193915408552?_trkparms=5373%3A0%7C5374%3AFeatured", 159.99)]
        [InlineData("https://www.ebay.it/itm/YM-TAP-70-TAPIS-ROULANT-ELETTRICO-PIEGHEVOLE-500W-2-0-HP-PICCO-7-KM-H-COMPATTO/162429461012?_trkparms=5373%3A0%7C5374%3AFeatured", 279.99, 400.00)]
        [InlineData("https://www.ebay.it/itm/Ferro-Da-Stiro-A-Caldaia-Rowenta-2200-W-1-2-Litri-Blu-Bianco-VR7040/222626368374?_trkparms=5373%3A0%7C5374%3AFeatured", 82.99)]
        [InlineData("https://www.ebay.it/itm/TP-Link-TL-MR6400-Router-WIRELESS-4G-LTE-Wi-Fi-N300-CON-SIM-SCHEDA-MOBILE-DATI/273610672592?hash=item3fb47789d0%3Ag%3AlFkAAOSw%7EhZeS9bV&_trkparms=%2526rpp_cid%253D5cc05b1ec642f01ac7367a43", 69.90, 110.00)]
        [InlineData("https://www.ebay.it/itm/SAMSUNG-GALAXY-TAB-A7-10-4-TFT-2020-GRAY-RAM-3GB-ROM-32GB-SOLO-WI-FI-SM-T5/254791446155?hash=item3b52c0ee8b%3Ag%3AtPgAAOSw70FgQ5sm&_trkparms=%2526rpp_cid%253D5cc05b1ec642f01ac7367a43", 194.49)]
        [InlineData("https://www.ebay.it/itm/HP-STAMPANTE-MULTIFUNZIONE-SERIE-ENVY-6020-5SE16B-3IN1-WI-FI-DUAL-BAND-USB-2-0/193755925373?hash=item2d1cc0cb7d%3Ag%3APbsAAOSwtM1ftSvV&_trkparms=%2526rpp_cid%253D5cc05b1ec642f01ac7367a43", 159.00)]
        [InlineData("https://www.ebay.it/itm/CASCO-INTEGRALE-LS2-FF353-RAPID-NERO-LUCIDO-FULL-DARK-VISIERA-DARK-SMOKE/153542405534?hash=item23bfd72d9e:g:FhAAAOSwFKldEjVK", 79.90)]        
        public void GenericLayoutTest(string url, decimal price, decimal fullprice = -1.00M)
        {
            string html = EbayScraping.GetRequest(url);
            EbayProduct result = EbayScraping.DataParse(html);

            result.price.Should().Be(price);
            result.fullprice.Should().Be(fullprice);
        }
        [Theory]
        [InlineData("4006381333627", "Stabilo-Boss-Highlighter-Pens-Original-Pastel-Highlighters-Buy-3-Get-1-Free")]
        [InlineData("4012700619631", "TG-30-Stuck-Pelikan-619635-per-cancellare-GOM-della-penna-colori-assortiti")]
        [InlineData("4005401170020", "Faber-Castell-Grip-2001-Pencil")]
        public void ExtractHrefTest(string ean, string contain)
        {
            //Arrange
            string extractedHref = string.Empty;

            //Act
            extractedHref = EbayScraping.ExtractFirstHref(ean);

            //Assert
            extractedHref.Should().Contain(contain);
        }
    }
}
