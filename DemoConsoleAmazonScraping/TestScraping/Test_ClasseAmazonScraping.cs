using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using DemoConsoleScraping;
using System.Text.RegularExpressions;

namespace TestScraping
{
    //Test Coverage al 20/03: 92%
    public class Test_ClasseAmazonScraping
    {
        [Fact]
        public void PingTest()
        {
            //Arrange
            var ping = new System.Net.NetworkInformation.Ping();

            //Act
            var result = ping.Send("www.amazon.it");

            //Assert
            result.Status.Should().Be(System.Net.NetworkInformation.IPStatus.Success);
        }
        [Fact]
        public void Layout1Test()
        {
            //Arrange
            string url = "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
            
            //Act
            string html = AmazonScraping.GetRequest(url);
            AmazonProduct result = AmazonScraping.DataParse(html);            

            //Assert
            result.name.Should().Be("Eastpak Oval Single Astuccio, 22 Cm, Nero (Black)");
            result.price.Should().Be(decimal.Parse("15,73"));
            result.description.Should().Be("Astuccio: Eastpak: Il nostro astuccio compatto ottimo per tenere tutti gli articoli da ufficio in ordine in un solo scomparto.");
        }
        [Fact]
        public void Layout2Test()
        {
            //Arrange
            string url = "https://www.amazon.it/Capitano-Elasticizzata-Chiusura-Regolare-molteplici/dp/B07JJNJ5G4/ref=sr_1_2_sspa?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=fascia+da+capitano&qid=1614421466&sr=8-2-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUFMSk9aVVhTVjVCNUYmZW5jcnlwdGVkSWQ9QTA0MTg3ODUzQzZYVkRSWFRTNTIyJmVuY3J5cHRlZEFkSWQ9QTA2NzI2MjQyUkdBNjU0NlVLUzM0JndpZGdldE5hbWU9c3BfYXRmJmFjdGlvbj1jbGlja1JlZGlyZWN0JmRvTm90TG9nQ2xpY2s9dHJ1ZQ==";

            //Act
            string html = AmazonScraping.GetRequest(url);
            AmazonProduct result = AmazonScraping.DataParse(html);

            //Assert            
            result.price.Should().Be(decimal.Parse("7,99"));
            result.description.Should().Be("La fascia da capitano ideale per una varietà di sport tra cui calcio, Rugby, football gaelico e molto altro ancora Colore: blu, rosso Dimensioni:23 cm*6 cm/9.1in * 2.4in Peso:13 g Materiale:poliestere Dopo il servizio:si prega di acquistare con fiducia e non esitare a contattarci in caso di qualsiasi problema, vi arriva a entro 24 ore");
        }
        [Fact]
        public void NullHtmlTest()
        {
            //Arrange
            string url = "https://www.amazon.it/dp/B286LY2YYZ";

            //Act
            string html = AmazonScraping.GetRequest(url);

            //Assert            
            html.Should().Be("");
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
        [InlineData("https://www.amazon.it/dp/B086LY2YYZ", 249.90, 255.90)]
        [InlineData("https://www.amazon.it/dp/B013R7Y1SE", 15.21)]
        [InlineData("https://www.amazon.it/dp/B00R3Z4FR4", 7.94)]
        [InlineData("https://www.amazon.it/dp/B082YTW968", 24.99)]
        [InlineData("https://www.amazon.it/dp/B005D6OKZM", 5.90)]
        [InlineData("https://www.amazon.it/dp/B08GH2M7WL", 10.14)]
        [InlineData("https://www.amazon.it/dp/B01MDSMHVC", 39.90)]
        [InlineData("https://www.amazon.it/dp/B076H8YD8W", 60.70)]
        [InlineData("https://www.amazon.it/dp/B0851GMVQ2", 91.90)]
        [InlineData("https://www.amazon.it/dp/B07GP882W5", 49.99)]
        public void GenericLayoutPriceTest(string url, decimal price, decimal fullprice=-1.00M)
        {
            string html = AmazonScraping.GetRequest(url);
            AmazonProduct result = AmazonScraping.DataParse(html);

            result.price.Should().Be(price);
            result.fullprice.Should().Be(fullprice);
        }
        [Theory]
        [InlineData("https://www.amazon.it/dp/B086LY2YYZ")]
        [InlineData("https://www.amazon.it/dp/B013R7Y1SE")]
        [InlineData("https://www.amazon.it/dp/B00R3Z4FR4")]
        [InlineData("https://www.amazon.it/dp/B082YTW968")]
        [InlineData("https://www.amazon.it/dp/B005D6OKZM")]
        [InlineData("https://www.amazon.it/dp/B08GH2M7WL")]
        [InlineData("https://www.amazon.it/dp/B01MDSMHVC")]
        [InlineData("https://www.amazon.it/dp/B0851GMVQ2")]
        [InlineData("https://www.amazon.it/dp/B07GP882W5")]
        public void GenericLayoutASINTest(string url)
        {
            string UrlAsin = url.Substring(url.IndexOf("dp/")+3,10);
            string html = AmazonScraping.GetRequest(url);
            AmazonProduct result = AmazonScraping.DataParse(html);

            if (string.Compare(result.ASIN, "AMAZONPROD") != 0)
                result.ASIN.Should().Be(UrlAsin);
            else
                result.ASIN.Should().Be("AMAZONPROD");
        }

    }
}
