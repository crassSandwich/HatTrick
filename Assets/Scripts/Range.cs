using System;

namespace HatTrick {

public struct Range {
	public readonly int Min;
	public readonly int Max;
	public Range (int min, int max) {
		if (min > max)
			throw new ArgumentException(min.ToString() + " > " + max.ToString());
		Min = min;
		Max = max;
	}
}

}