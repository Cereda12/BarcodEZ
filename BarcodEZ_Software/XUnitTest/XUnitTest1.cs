using System;
using System.Net;
using Xunit;
using FluentAssertions;

namespace XUnitTest
{
<<<<<<< HEAD:BarcodEZ_Software/XUnitTest/TestClasseAPI.cs
    public class TestClasseAPI
=======
    public class XUnitTest1
>>>>>>> ElaborazioneImmagine:BarcodEZ_Software/XUnitTest/XUnitTest1.cs
    {
        [Fact]
        public void Ping_sito()
        {
            //Arrange
            var ping = new System.Net.NetworkInformation.Ping();

            //Act
            var result = ping.Send("www.rapidapi.com");

            //Assert
            result.Status.Should().Be(System.Net.NetworkInformation.IPStatus.Success);
        }
    }
}
