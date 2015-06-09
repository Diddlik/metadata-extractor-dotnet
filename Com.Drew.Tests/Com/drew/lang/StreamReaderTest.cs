using System;
using System.IO;
using NUnit.Framework;

namespace Com.Drew.Lang
{
    /// <author>Drew Noakes https://drewnoakes.com</author>
    public sealed class StreamReaderTest : SequentialAccessTestBase
    {
        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructWithNullStreamThrows()
        {
            new StreamReader(null);
        }

        protected override SequentialReader CreateReader(byte[] bytes)
        {
            return new StreamReader(new MemoryStream(bytes));
        }
    }
}
