using System;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Core.Hashing
{
    public sealed class Cryptographer
    {
        public byte[] Hash(HashType hash, string plainText)
        {
            ArgumentNullException.ThrowIfNull(plainText);

            if (plainText.Length == 0)
            {
                return Array.Empty<byte>();
            }

#pragma warning disable CA5351
            return hash switch
            {
                HashType.MD5 => MD5.HashData(Encoding.UTF8.GetBytes(plainText)),
#pragma warning restore CA5351
                HashType.SHA256 => SHA256.HashData(Encoding.UTF8.GetBytes(plainText)),
                HashType.SHA512 => SHA512.HashData(Encoding.UTF8.GetBytes(plainText)),
                _ => throw new ArgumentOutOfRangeException(nameof(hash), hash, "Unsupported hash algorithm.")
            };
        }
    }
}
