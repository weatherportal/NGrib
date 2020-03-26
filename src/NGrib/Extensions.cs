﻿using System;

namespace NGrib
{
	public static class Extensions
	{
		/// <summary>
		/// Convert to radians.
		/// </summary>
		/// <param name="val">The value to convert to radians</param>
		/// <returns>The value in radians</returns>
		public static double ToRadians(this float val) => Math.PI / 180d * val;

		/// <summary>
		/// Convert to degrees.
		/// </summary>
		/// <param name="val">The value to convert to degrees</param>
		/// <returns>The value in degrees</returns>
		public static double ToDegrees(this double val) => 180d / Math.PI * val;
	}
}
