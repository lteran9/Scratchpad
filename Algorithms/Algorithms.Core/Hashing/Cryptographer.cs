using System;
using System.Text;
using System.Security.Cryptography;

namespace Algorithms.Core.Hashing
{
    public abstract class Cryptographer
    {
#pragma warning disable CA5351
        static readonly MD5 md5 = MD5.Create();
#pragma warning restore CA5351
        static readonly SHA256 sha256 = SHA256.Create();
        static readonly SHA512 sha512 = SHA512.Create();

        public byte[] Hash(HashType hash, string plainText)
        {
            if (!string.IsNullOrEmpty(plainText))
            {
                switch (hash)
                {
                    case HashType.MD5:
                        return md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                    case HashType.SHA256:
                        return sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                    case HashType.SHA512:
                        return sha512.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                    default:
                        break;
                }
            }

            return new byte[0];
        }
    }
}
