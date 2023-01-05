using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadEndNumber
{
    public class Sequence
    {
        private int _sum { get; set; } = 0;
        private int _count { get; set; } = 0;
        private int _previousSequence { get; set; }
        private int _numberSequence { get; set; }
        private int _temp { get; set; }
        private string _numberString { get; set; }
        public void SequenceLenght(int number)
        {
            _previousSequence = number;
            _numberSequence=number;
            do
            {
                if (_numberSequence == _previousSequence&&_count>0)
                {
                    Console.WriteLine($"The sequence is {_count} long and the last number is {_numberSequence}");
                    return;
                }

                if (_count > 1)
                {
                    _previousSequence = _temp;
                }

                _temp = _numberSequence;
                _count++;
                _sum = 0;

                if (_numberSequence < 10)
                {
                    _sum = _numberSequence;
                }
                else
                {
                    _numberString = _numberSequence.ToString();
                    for(int i = 0; i < _numberString.Length; i++)
                    {
                        _sum += Int32.Parse(_numberString.Substring(i, 1));
                    }
                }

                if (_numberSequence % _sum == 0)
                {
                    _numberSequence /= _sum;
                }
                else
                {
                    _numberSequence *= _sum;
                }

            } while (true);

        }
    }
}
