using System;

namespace RednilianUtlilitiesNC.Math
{
    public static class MathUtility
    {
        /// <summary>
        /// Returns an integer parsed from a string value. Returns NULL if string value cannot be parsed as an integer.
        /// </summary>
        /// <param name="intAsString"></param>
        /// <returns></returns>
        public static int? IntFromString(string intAsString)
        {
            bool isParsed = int.TryParse(intAsString, out int intValue);
            return isParsed ? intValue : null;
        }

        /// <summary>
        /// Returns True if EVEN Integer. False if not an integer or not Even.
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static bool IsEvenInteger(int intValue)
        {
            try
            {
                return intValue % 2 == 0;
            }
            catch (Exception e)
            {
                _ = e.ToString();
                return false;
            }
        }

        /// <summary>
        /// Returns true if the parameter 'intAsString' can be parsed as an integer.
        /// </summary>
        /// <param name="intAsString">String value to be parsed as an integer (TryPars)</param>
        /// <returns></returns>
        public static bool IsInteger(string intAsString)
        {   
            bool isInt = int.TryParse(intAsString, out _);
            return isInt;
        }

        /// <summary>
        /// Returns True if Odd Integer. False if not an integer or not Odd.
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static bool IsOddInteger(int intValue)
        {
            try
            {
                return intValue % 2 != 0;
            }
            catch (Exception e)
            {
                _ = e.ToString();
                return false;
            }
        }
        
    }
}
