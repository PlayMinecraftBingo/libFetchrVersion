using libMinecraftVersion;
using System;

namespace libFetchrVersion
{
    public record FetchrVersionData
    {
        public FetchrVersion Fetchr { get; init; }
        public FetchrMinecraftVersion Minecraft { get; init; }

        public FetchrVersionData(FetchrVersion fetchr, FetchrMinecraftVersion minecraft)
        {
            if (fetchr.IsValidMinecraftVersion(minecraft))
            {
                Fetchr = fetchr;
                Minecraft = minecraft;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(minecraft), "Invalid combination of Fetchr and Minecraft versions.");
            }
        }

        public FetchrVersionData(FetchrVersion fetchr)
        {
            FetchrMinecraftVersion minecraft = fetchr switch
            {
                FetchrVersion.Unknown => FetchrMinecraftVersion.Unknown,
                FetchrVersion.Fetchr_5_0 => FetchrMinecraftVersion.Minecraft_1_16_5,
                FetchrVersion.Fetchr_5_0_1 => FetchrMinecraftVersion.Minecraft_1_16_5,
                FetchrVersion.Fetchr_5_1 => FetchrMinecraftVersion.Minecraft_1_20_2,
                FetchrVersion.Fetchr_5_1_1 => FetchrMinecraftVersion.Minecraft_1_20_2,
                FetchrVersion.Fetchr_5_1_2 => FetchrMinecraftVersion.Minecraft_1_20_6,
                FetchrVersion.Fetchr_5_1_3 => FetchrMinecraftVersion.Minecraft_1_20_6,
                _ => throw new ArgumentOutOfRangeException(nameof(fetchr), "Minecraft version must be specified for this Fetchr version.")
            };

            if (fetchr.IsValidMinecraftVersion(minecraft))
            {
                Fetchr = fetchr;
                Minecraft = minecraft;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(fetchr), "Invalid combination of Fetchr and Minecraft versions.");
            }
        }
    }
}
