using System;

namespace libFetchrVersion.Tests
{
    [TestClass]
    public class FetchrVersionData
    {
        [TestMethod]
        public void Unknown()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Unknown);
        }

        [TestMethod]
        public void Fetchr_5_0()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_0);
        }

        [TestMethod]
        public void Fetchr_5_0_1()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_0_1);
        }

        [TestMethod]
        public void Fetchr_5_1()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_1);
        }

        [TestMethod]
        public void Fetchr_5_1_1()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_1_1);
        }

        [TestMethod]
        public void Fetchr_5_1_2()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_1_2);
        }

        [TestMethod]
        public void Fetchr_5_1_3()
        {
            _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_1_3);
        }

        [TestMethod]
        public void Fetchr_5_2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_2); });
        }

        [TestMethod]
        public void Fetchr_5_2_1()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { _ = new libFetchrVersion.FetchrVersionData(FetchrVersion.Fetchr_5_2_1); });
        }
    }
}