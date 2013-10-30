using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Mics.InterClient
{
    public class FlashKey
    {
        /// <summary>
        /// Generates a new random flash key to send.
        /// </summary>
        /// <returns>Randomly generated flash key.</returns>
        public string GetRandomFlashKey()
        {
            char[] HexChars = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            Random Random = new Random();
            int HexCharsEntry = 0;
            string FlashKey = string.Empty;

            for (int i = 0; i < 20; i++)
            {
                double Rand = Math.Ceiling(Random.NextDouble() * 100);
                double RandomCharCode = 0;

                if (Rand <= 40)
                    RandomCharCode = Math.Floor(Random.NextDouble() * 26) + 65;
                else if (Rand <= 80)
                    RandomCharCode = Math.Floor(Random.NextDouble() * 26) + 97;
                else
                    RandomCharCode = Math.Floor(Random.NextDouble() * 10) + 48;

                FlashKey += (char)RandomCharCode;
                HexCharsEntry += (int)RandomCharCode % 16;
            }

            return FlashKey + HexChars[HexCharsEntry % 16];
        }
    }
}
