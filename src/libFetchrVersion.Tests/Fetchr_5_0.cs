using libMinecraftVersion;

namespace libFetchrVersion.Tests
{
    [TestClass]
    public class Fetchr_5_0
    {
        private readonly FetchrVersion fetchr = FetchrVersion.Fetchr_5_0;

        [TestMethod]
        public void Unknown()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Unknown));
        }

        [TestMethod]
        public void Minecraft_1_16_5()
        {
            Assert.IsTrue(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_16_5));
        }

        [TestMethod]
        public void Minecraft_1_20_2()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_20_2));
        }

        [TestMethod]
        public void Minecraft_1_20_6()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_20_6));
        }

        [TestMethod]
        public void Minecraft_1_21()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_21));
        }

        [TestMethod]
        public void Minecraft_1_21_1()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_21_1));
        }

        [TestMethod]
        public void Minecraft_1_21_2()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_21_2));
        }

        [TestMethod]
        public void Minecraft_1_21_3()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_21_3));
        }

        [TestMethod]
        public void Minecraft_1_21_4()
        {
            Assert.IsFalse(fetchr.IsValidMinecraftVersion(FetchrMinecraftVersion.Minecraft_1_21_4));
        }
    }
}