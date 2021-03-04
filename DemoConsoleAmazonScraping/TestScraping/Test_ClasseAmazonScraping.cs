using System.Net;
using Xunit;
using FluentAssertions;
using DemoConsoleAmazonScraping;
using Newtonsoft.Json;

namespace TestScraping
{
    public class Test_ClasseAmazonScraping
    {
        [Fact]
        public void WebResponseTest()
        {
            //Arrange
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.amazon.it");

            //Act
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Assert
            response.Should().Be(request.GetResponse());
        }
        [Fact]
        public void Layout1Test()
        {
            //Arrange
            string url = "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
            string html = string.Empty;
            AmazonProduct total;

            //Act
            html = AmazonScraping.GetRequest(url);
            object result = AmazonScraping.DataParse(html);
            total = (AmazonProduct)result;
            

            //Assert
            total.name.Should().Be("Eastpak Oval Single Astuccio, 22 Cm, Nero (Black)");
            total.price.Should().Be("16,89 €");
            total.description.Should().Be("Astuccio: Eastpak: Il nostro astuccio compatto ottimo per tenere tutti gli articoli da ufficio in ordine in un solo scomparto.");
        }
    }
}
