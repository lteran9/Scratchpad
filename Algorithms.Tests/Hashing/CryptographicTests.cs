using Algorithms.Hashing;
using System;
using System.Text;
using Xunit;

namespace Algorithms.Tests.Hashing
{
   public class CryptographicTests : Cryptographer
   {
      [Fact]
      public void BaseTests()
      {
         var emptyString = string.Empty;

         var md5HashResult = Hash(HashType.MD5, emptyString);

         Assert.True(md5HashResult.Length == 0);
         Assert.True(string.IsNullOrEmpty(Encoding.UTF8.GetString(md5HashResult)));

         var sha256HashResult = Hash(HashType.SHA256, emptyString);

         Assert.True(sha256HashResult.Length == 0);
         Assert.True(string.IsNullOrEmpty(Encoding.UTF8.GetString(sha256HashResult)));

         var sha512HashResult = Hash(HashType.SHA512, emptyString);

         Assert.True(sha512HashResult.Length == 0);
         Assert.True(string.IsNullOrEmpty(Encoding.UTF8.GetString(sha512HashResult)));
      }

      [Fact]
      public void AdvancedTests()
      {
         var password = "a@4bs9vvKL";

         var md5HashResult = Hash(HashType.MD5, password);

         Assert.True(md5HashResult.Length != 0);
         Assert.True(Encoding.UTF8.GetString(md5HashResult) != password);

         var sha256HashResult = Hash(HashType.SHA256, password);

         Assert.True(sha256HashResult.Length != 0);
         Assert.True(Encoding.UTF8.GetString(sha256HashResult) != password);

         var sha512HashResult = Hash(HashType.SHA512, password);

         Assert.True(sha512HashResult.Length != 0);
         Assert.True(Encoding.UTF8.GetString(sha512HashResult) != password);
      }

      // SHA256: The length of the message to encode should be less than 264 bits

      // All: Should be irreversible
   }
}