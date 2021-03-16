using System;
using Xunit;
using FluentAssertions;

namespace XUnitTest
{
    public class XUnitTest1
    {
        /// <summary>
        /// Prova a pingare il sito di RapidApi
        /// </summary>
        [Fact]
        public void Test1()
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
