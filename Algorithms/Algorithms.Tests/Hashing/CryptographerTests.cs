using System;
using Xunit;
using Algorithms.Core.Hashing;

namespace Algorithms.Core.Tests.Hashing
{
    public class CryptographerTests
    {
        private readonly Cryptographer _cryptographer = new Cryptographer();

        [Fact]
        public void EmptyStringReturnsEmptyResult()
        {
            Assert.Empty(_cryptographer.Hash(HashType.SHA256, string.Empty));
        }

        [Theory]
        [InlineData(HashType.MD5, "5D41402ABC4B2A76B9719D911017C592")]
        [InlineData(HashType.SHA256, "2CF24DBA5FB0A30E26E83B2AC5B9E29E1B161E5C1FA7425E73043362938B9824")]
        [InlineData(HashType.SHA512, "9B71D224BD62F3785D96D46AD3EA3D73319BFBC2890CAADAE2DFF72519673CA72323C3D99BA5C11D7C7ACC6E14B8C5DA0C4663475C2E5C3ADEF46F73BCDEC043")]
        public void HashesKnownValue(HashType hashType, string expectedHex)
        {
            var result = _cryptographer.Hash(hashType, "hello");

            Assert.Equal(expectedHex, Convert.ToHexString(result));
        }

        [Fact]
        public void NullInputIsRejected()
        {
            Assert.Throws<ArgumentNullException>(() => _cryptographer.Hash(HashType.SHA256, null));
        }
    }
}
