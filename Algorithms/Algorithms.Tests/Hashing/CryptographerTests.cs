using System;
using System.Text;
using Xunit;
using Algorithms.Core.Hashing;

namespace Algorithms.Core.Tests.Hashing
{
   /// <summary>
   /// Inherits all functionality to be tested.
   /// </summary>
   public class CryptographerTests : Cryptographer
   {
      [Fact]
      public void EmptyStringTests()
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
      public void PasswordHashingTests()
      {
         string password = "a@4bs9&vKL_33!;";
         string internetMD5 = string.Empty; // Get from a website to compare result
         string internetSHA256 = string.Empty; // Get from a website to compare result
         string internetSha512 = string.Empty; // Get from a website to compare result

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