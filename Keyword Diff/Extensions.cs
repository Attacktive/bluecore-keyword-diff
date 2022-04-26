using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keyword_Diff {
	public static class Extensions {
		public static bool In<T>(this T objectOfT, params T[] array) {
			return array.Contains(objectOfT);
		}

		public static string FlattenToString<T>(this IEnumerable<T> set, char delimiter) {
			StringBuilder stringBuilder = new StringBuilder();
			foreach (var element in set) {
				stringBuilder.Append(element?.ToString()?.Trim()).Append(delimiter);
			}

			return stringBuilder.ToString().TrimEnd(delimiter);
		}
	}
}