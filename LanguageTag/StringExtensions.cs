using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	public static class StringExtensions
	{
		public static string ToLower(this string input, CultureInfo cultureInfo)
		{
			return cultureInfo.TextInfo.ToLower(input);
		}
	}
}