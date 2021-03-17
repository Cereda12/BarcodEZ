using Xunit;
using FluentAssertions;
using DemoConsoleScraping;

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
    }
}
