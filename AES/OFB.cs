using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    public class ExceptionOFB : Exception {
        public ExceptionOFB(string message) : base(message)
        {

        }
    };

    public class OFB
    {
        private Aes _aes;
        private byte[] _initVector;
        private List<byte> _shiftRegistr;
        private int _sizeBlock;

        public OFB(byte[] key, byte[] iv, int sizeBlock = 127)
        {
            if (sizeBlock < 1 || sizeBlock > 127)
                throw new ExceptionOFB("Size block not correct");

            if (key.Count() != 16)
                throw new ExceptionOFB("Key not correct");

            if (iv.Count() != 16)
                throw new ExceptionOFB("Init vector not correct");

            _initVector = iv;
            _sizeBlock = sizeBlock;
            _shiftRegistr = new List<byte>();
            _aes = new Aes(key);
            resetShiftRegistr();
        }

        public void resetShiftRegistr()
        {
            _shiftRegistr.Clear();
            Array.ForEach(_initVector, item => _shiftRegistr.Add(item));
        }

        public byte[] Decode(byte[] input)
        {

            var output = new List<byte>();
            var countBlock = Math.Ceiling((double) input.Length / _sizeBlock);

            for (var i = 0; i < countBlock; i++)
            {
                var cipherRegistr = _aes.Encrypt(_shiftRegistr.ToArray());

                for (var j = 0; j < _sizeBlock; j++)
                {
                    var index = i * _sizeBlock + j;
                    if (index >= input.Length)
                        break;

                    var currentByte = cipherRegistr[j];
                    output.Add((byte)(input[index] ^ currentByte));
                    _shiftRegistr.RemoveAt(0);
                    _shiftRegistr.Add(currentByte);
                }


            }
            return output.ToArray();
        }


    }
}
