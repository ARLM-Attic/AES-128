using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AES;
namespace UnitTest
{



    [TestClass]
    public class UnitTest1
    {
        private static byte[] plaintext = { 0x32, 0x88, 0x31, 0xe0, 0x43, 0x5a, 0x31, 0x37, 0xf6, 0x30, 0x98, 0x07, 0xa8, 0x8d, 0xa2, 0x34 };
        private static byte[] expected = { 0x54, 0x67, 0xb9, 0x2a, 0xaa, 0xd0, 0x7d, 0x03, 0xbd, 0x1c, 0x62, 0x2c, 0x7c, 0xb6, 0xfb, 0x1a };

        private OFB createOFB(int sizeKey, int sizeIV, int sizeBlock)
        {
            var key = new byte[sizeKey];
            var iv = new byte[sizeIV];
            Array.Clear(key, 0, sizeKey);
            Array.Clear(iv, 0, sizeIV);

            return new OFB(key, iv, sizeBlock);
        }

        [TestMethod]
        public void TestCorrect1()
        {
            OFB ofb = createOFB(16, 16, 127);
            var actual = ofb.Decode(plaintext);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCorrect2()
        {
            byte[] plain = { 0x32, 0x88, 0x31, 0xe0, 0x43 };
            byte[] ciphertext = { 0x54, 0x67, 0xb9 };
            byte[] actual = new byte[3];
            OFB ofb = createOFB(16, 16, 3);
            Array.Copy(ofb.Decode(plain), actual, 3);
            CollectionAssert.AreEqual(ciphertext, actual);
        }

        [TestMethod]
        public void TestCorrect3()
        {
            byte[] plain = { 0x32 };
            byte[] ciphertext = { 0x54 };
            OFB ofb = createOFB(16, 16, 1);
            CollectionAssert.AreEqual(ciphertext, ofb.Decode(plain));
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void TestNotCorrectText()
        {
            OFB ofb = createOFB(16, 16, 127);
            var actual = ofb.Decode(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Key not correct")]
        public void TestNotCorrectKey1()
        {
            createOFB(15, 16, 127);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Key not correct")]
        public void TestNotCorrectKey2()
        {
            createOFB(17, 16, 127);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Init vector not correct")]
        public void TestNotCorrectIV1()
        {
            createOFB(16, 15, 127);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Init vector not correct")]
        public void TestNotCorrectIV2()
        {
            createOFB(16, 17, 127);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Size block not correct")]
        public void TestNotCorrectSizeBlock1()
        {
            createOFB(16, 16, 0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ExceptionOFB), "Size block not correct")]
        public void TestNotCorrectSizeBlock2()
        {
            createOFB(16, 16, 128);
        }


    }
}
