using System;
using Microsoft.AspNetCore.Components.Forms;

namespace KLACodeTest.Business
{
	public static class Constants
    {
        public static string dollar = "dollar";
        public static string cent = "cent";
        public static string dollars = "dollars";
        public static string cents = "cents";
        public static string zero = "zero";
        public static string and = "and";

        public static string[] ThousandPositions = { "", "thousand", "million", "billion", "trillion" };
		public static Dictionary<int, string> NumberToWordDictionary = new()
        {
			{0,"" },
            {1, "one" },
            {2, "two" },
			{3, "three" },
			{4, "four" },
			{5, "five" },
			{6, "six" },
			{7, "seven" },
			{8, "eight" },
			{9, "nine" },
			{10, "ten" },
			{11, "eleven" },
			{12, "twelve" },
			{13, "thirteen" },
			{14, "fourteen" },
			{15, "fifteen" },
			{16, "sixteen" },
			{17, "seventeen" },
			{18, "eighteen" },
			{19, "ninteen" },
			{20, "twenty" },
			{30, "thirty" },
			{40, "forty" },
			{50, "fifty" },
			{60, "sixty" },
			{70, "seventy" },
			{80, "eighty" },
			{90, "ninety" },
			{100, "hundred" }
        };
    }
}

