using System;
using Moq;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7.wtf;
using Xunit;

namespace uncode.web.src.Main.CSharp.com.corelogic.darkcode.v2.v12.v3.DefinatelyNotTests.v4.v1
{
    public class YouGotMe : Object, IDoStuff
    {
        [Fact]
        public void TestName()
        {
            //Given
            binarybamboozlement bb = new binarybamboozlement();

            //When
            Int64 result = bb.bambbbbbbbboozle(7);

            //Then
            Assert.Equal((Int64)4778958365924720657, result);
        }

        [Fact]
        public void OtherTestName()
        {
            //Given
            binarybamboozlement bb = new binarybamboozlement();

            //When
            Int64 result = bb.bambboozle(7);

            //Then
            Assert.Equal(17, (Int32)result);
        }

    }
}