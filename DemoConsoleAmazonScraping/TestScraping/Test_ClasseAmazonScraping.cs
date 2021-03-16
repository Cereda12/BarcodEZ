using Xunit;
using FluentAssertions;
using DemoConsoleScraping;

namespace TestScraping
{
    public class Test_ClasseAmazonScraping
    {
        [Fact]
        public void WebResponseTest()
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
            result.price.Should().Be(decimal.Parse("16,56"));
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
            //result.name.Should().Be("cjixnji Fascia da Capitano Junior, Elasticizzata, per Bambini, con Chiusura in Velcro per Regolare la Misura, Adatte per molteplici Sport con Palla,  Fasce da Capitano per Calcio");
            result.price.Should().Be(decimal.Parse("7,99"));
            result.description.Should().Be("La fascia da capitano ideale per una varietà di sport tra cui calcio, Rugby, football gaelico e molto altro ancora Colore: blu, rosso Dimensioni:23 cm*6 cm/9.1in * 2.4in Peso:13 g Materiale:poliestere Dopo il servizio:si prega di acquistare con fiducia e non esitare a contattarci in caso di qualsiasi problema, vi arriva a entro 24 ore");
        }
    }
}
