using System;
using System.IO;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7.wtf;

namespace uncode.web.src.Main.CSharp.com.corelogic.darkcode
{
    [pantz.AutoWired]
    public class binarybamboozlement
    {

        public Int64 bambbbbbbbboozle(int pantz)
        {
            Byte b0 = (Byte)(char)0;
            Byte bnot0 = (Byte)('a' - 'P');
            byte[] bytes = new byte[] {
                bnot0,
                b0,
                (Byte) 'S',
                (Byte) 'U',
                (Byte) 'P',
                (Byte) 'E',
                (Byte) 'R',
                (Byte) 'B'
            };
            MemoryStream ms = new MemoryStream(bytes);
            BinaryReader reader = new BinaryReader(ms);
            return reader.ReadInt64();
        }

        public Int32 bambboozle(int pantz)
        {
            Int16 value = (Int16)bambbbbbbbboozle(pantz++);
            return (Int32)value;
        }

    }
}