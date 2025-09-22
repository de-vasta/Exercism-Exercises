using System;

public static class RunLengthEncoding
    {
        public static string Encode(string input)
        {
            if (input.Length <= 1) { return input; }
            string output = "";
            int count = 1;
            char letter = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (letter != input[i])
                {
                    output += count > 1 ? $"{count}" + letter : letter;
                    letter = input[i];
                    count = 1;
                }
                else { count++; }
            }
            output += count > 1 ? $"{count}" + letter : letter;
            return output;
        }

        public static string Decode(string input)
        {
            string output = "";
            string numberText = "";
            int number;
            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])) { numberText += input[i]; }
                else
                {
                    if (!int.TryParse(numberText, out number)) { number = 1; }
                    for (var k = 0; k < number; k++) { output += input[i]; }
                    numberText = "";
                }
            }
            return output;
        }
    }