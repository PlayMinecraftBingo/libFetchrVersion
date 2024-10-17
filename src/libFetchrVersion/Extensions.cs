using System;

namespace libFetchrVersion
{
	public static class Extensions
	{
		public static string ToVersionString(this FetchrVersion version)
		{
			return version switch
			{
				FetchrVersion.Fetchr_5_0 => "5.0",
				FetchrVersion.Fetchr_5_0_1 => "5.0.1",
				FetchrVersion.Fetchr_5_1 => "5.1",
				FetchrVersion.Fetchr_5_1_1 => "5.1.1",
				FetchrVersion.Fetchr_5_1_2 => "5.1.2",
                FetchrVersion.Fetchr_5_1_3 => "5.1.3",
                FetchrVersion.Fetchr_5_1_4 => "5.1.4",
                _ => throw new NotImplementedException(),
			};
		}

        public static string ToVersionString(this MinecraftVersion version)
        {
            return version switch
            {
                MinecraftVersion.Minecraft_1_16_5 => "1.16.5",
                MinecraftVersion.Minecraft_1_20_2 => "1.20.2",
                MinecraftVersion.Minecraft_1_20_6 => "1.20.6",
                MinecraftVersion.Minecraft_1_21 => "1.21",
                MinecraftVersion.Minecraft_1_21_1 => "1.21.1",
                MinecraftVersion.Minecraft_1_21_2 => "1.21.2",
                _ => throw new NotImplementedException(),
            };
        }

        public static bool IsValidMinecraftVersion(this FetchrVersion version, MinecraftVersion minecraft)
        {
            switch (version)
            {
                case FetchrVersion.Unknown:
                    if (minecraft== MinecraftVersion.Unknown) return true;
                    break;
                case FetchrVersion.Fetchr_5_0:
                case FetchrVersion.Fetchr_5_0_1:
                    if (minecraft == MinecraftVersion.Minecraft_1_16_5) return true;
                    break;
                case FetchrVersion.Fetchr_5_1:
                case FetchrVersion.Fetchr_5_1_1:
                    if (minecraft == MinecraftVersion.Minecraft_1_20_2) return true;
                    break;
                case FetchrVersion.Fetchr_5_1_2:
                case FetchrVersion.Fetchr_5_1_3:
                    if ((minecraft >= MinecraftVersion.Minecraft_1_20_2) && (minecraft < MinecraftVersion.Minecraft_1_21)) return true;
                    break;
                case FetchrVersion.Fetchr_5_1_4:
                    if (minecraft >= MinecraftVersion.Minecraft_1_21) return true;
                    break;
            }

            return false;
        }
    }
}
