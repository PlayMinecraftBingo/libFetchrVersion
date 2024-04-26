using System;

namespace libFetchrVersion
{
	public static class Extensions
	{
		public static string ToVersionString(this FetchrVersion version)
		{
			return version switch
			{
				FetchrVersion.Fetchr50 => "5.0",
				FetchrVersion.Fetchr501 => "5.0.1",
				FetchrVersion.Fetchr51 => "5.1",
				FetchrVersion.Fetchr511 => "5.1.1",
				FetchrVersion.Fetchr512 => "5.1.2",
				FetchrVersion.Fetchr513 => "5.1.3",
				_ => throw new NotImplementedException(),
			};
		}
	}
}
