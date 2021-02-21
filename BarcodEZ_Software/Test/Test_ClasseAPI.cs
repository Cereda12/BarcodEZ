using System;
using Xunit;
using System.Net.Http;
using RestSharp;
using FluentAssertions;

namespace Test
{
    public class Test_ClasseAPI
    {
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
