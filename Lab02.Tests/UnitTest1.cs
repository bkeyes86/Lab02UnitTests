using System;
using Xunit;
using UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalances_shows_balance_and_returns()
        {

            decimal Balance = 100.00M;

            decimal result = Program.ViewBalance(Balance);

            decimal expected = Balance;

            Assert.Equal(expected, result);

        }

    }

}
            

            
   


