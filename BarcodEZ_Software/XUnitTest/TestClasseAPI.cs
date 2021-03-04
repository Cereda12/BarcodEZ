using System;
using System.Net;
using Xunit;

namespace XUnitTest
{
    public class TestClasseAPI
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
