using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace NUnit.Tests1
{
    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        int Divide(int param1, int param2);
        int ConvertUSDtoRMB(int unit);
    }
    public interface IUSD_RMB_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }
    public class Calculator : ICalculator
    {
        private IUSD_RMB_ExchangeRateFeed _feed;
        public Calculator(IUSD_RMB_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }
        #region ICalculator Members
        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }
        public int ConvertUSDtoRMB(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }
        #endregion
    }

    // 添加TestFixture标识类是测试类
    [TestFixture]
    public class CalculatorTester
    {
        // 定义mock的逻辑
        private IUSD_RMB_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_RMB_ExchangeRateFeed> mockObject = new Mock<IUSD_RMB_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);

            mockObject.Object.GetActualUSDValue();
            return mockObject.Object;
        }
        // 测试divide方法
        [Test(Description = "Divide 9 by 3. Expected result is 3.")]
        public void TC1_Divide9By3()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test(Description = "Divide any number by zero. Should throw an System.DivideByZeroException exception.")]
        public void TC2_DivideByZero()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 0);
        }
        [Test(Description = "Convert 1 USD to RMB. Expected result is 500.")]
        public void TC3_ConvertUSDtoRMBTest()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoRMB(1);
            int expectedResult = 500;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}
