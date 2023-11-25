using System;
using KLACodeTest.Business;

namespace KLACodeTest.BusinessLayer
{

    public class NumberToWordsConverter : INumberToWordsConverter
    {

        public string ConvertNumberToWords(double number)
        {
            int decimalPart = (int)((number * 100) % 100);
            long wholeNumber = (long)(number);
            string dollor = wholeNumber == 1 ? Constants.dollar : Constants.dollars;
            string cent = decimalPart > 1 ? Constants.cents : Constants.cent;
            string wholeNumberPartInWords = wholeNumber == 0 ? $"{Constants.zero} " : "";
            int counter = 0;
            while (wholeNumber >= 1)
            {
                var thousandPart = (int)wholeNumber % 1000;
                wholeNumber = wholeNumber / 1000;
                if (thousandPart > 0)
                {
                    string thousandPartInWords = NumberPartToWords(thousandPart);
                    wholeNumberPartInWords = $"{thousandPartInWords} {Constants.ThousandPositions[counter]} {wholeNumberPartInWords}";
                }
                counter++;
            }
            return decimalPart > 0 ? $"{wholeNumberPartInWords.Trim()} {dollor} {Constants.and} {NumberPartToWords(decimalPart)} {cent}" : $"{wholeNumberPartInWords.Trim()} {dollor}";
        }

        private string NumberPartToWords(int numberPart)
        {
            var hundredPart = numberPart / 100;
            var tensPart = numberPart >= 100 ? numberPart % 100 : numberPart;

            string numberInWords = numberPart >= 100 ? $"{Constants.NumberToWordDictionary[hundredPart]} {Constants.NumberToWordDictionary[100]}" : "";

            if (tensPart > 19)
            {
                var tens = (tensPart / 10) * 10;
                var ones = tensPart % 10;
                numberInWords = $"{numberInWords} {Constants.NumberToWordDictionary[tens]}";
                if (ones > 0)
                {
                    numberInWords = $"{numberInWords}-{Constants.NumberToWordDictionary[ones]}";
                }
            }
            else
            {
                numberInWords = $"{numberInWords} {Constants.NumberToWordDictionary[tensPart]}";
            }

            return numberInWords.Trim();
        }
    }
}

