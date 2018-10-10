using System;
using System.Collections.Generic;

namespace uncode.web.src.Main.CSharp.com.corelogic.darkcode
{
    public class brainsPantz
    {
        [Flags]
        private enum FlagTest
        {
            None = 0x0,
            one = 0x1,
            two = 0x2,
            four = 0x4,
            eight = 0x8,
            sixteen = 0x16,
            thirtytwo = 0x32,
            sixtyfour = 0x64
        }

        private static Random random = new Random();

        public static int DoSomething(int input)
        {
            int loops = 0;
            while (input % 128 != 17 && loops < 10)
            {
                FlagTest functions = (FlagTest)(input % 128);
                if (functions.HasFlag(FlagTest.one))
                {
                    input = Bit0(input);
                }
                if (functions.HasFlag(FlagTest.two))
                {
                    input = Bit1(input);
                }
                if (functions.HasFlag(FlagTest.four))
                {
                    input = Bit2(input);
                }
                if (functions.HasFlag(FlagTest.eight))
                {
                    input = Bit3(input);
                }
                if (functions.HasFlag(FlagTest.sixteen))
                {
                    input = Bit4(input);
                }
                if (functions.HasFlag(FlagTest.thirtytwo))
                {
                    input = Bit5(input);
                }
                if (functions.HasFlag(FlagTest.sixtyfour))
                {
                    input = Bit6(input);
                }
                loops++;
            }
            return input;

        }

        public static int Bit0(int input)
        {
            float x = (float)input;
            float xhalf = 0.5f * x;
            int i = BitConverter.ToInt32(BitConverter.GetBytes(x), 0);
            i = 0x5f3759df - (i >> 1);
            x = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
            x = x * (1.5f - xhalf * x * x);
            input = (int)x ^ 2;
            if (input == 0) input = lastValue;
            return input;
        }
        public static int Bit1(int input)
        {
            return (int)Math.Sqrt(input * 8);
        }
        public static int Bit2(int input)
        {
            return input ^ 3;
        }
        public static int Bit3(int input)
        {
            return (int)Math.Sqrt((input ^ 2 + 25)) ^ 8;
        }
        public static int Bit4(int input)
        {
            return input << 1;
        }
        public static int Bit5(int input)
        {
            return input >> 1;
        }

        private static int lastValue = 1027;
        public static int Bit6(int input)
        {
            lastValue = input + lastValue;
            return lastValue; // this is not thread safe and i don't care
        }

    }
}