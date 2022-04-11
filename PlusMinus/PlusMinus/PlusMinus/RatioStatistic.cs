using System;
using System.Collections.Generic;
using System.Text;

namespace PlusMinus
{
    public class RatioStatistic
    {
        private const string STRING_FORMAT = "0.000000";
        private int _negative, _positive, _zero;
        private float _total;

        public void AddNegative()
        {
            _negative++;
            _total++;
        }

        public void AddPositive()
        {
            _positive++;
            _total++;
        }

        public void AddZero()
        {
            _zero++;
            _total++;
        }

        public float Positive
        {
            get
            {
                if(_total <= float.Epsilon)
                {
                    return 0F;
                }
                return _positive / _total;
            }
        }

        public float Negative
        {
            get
            {
                if (_total <= float.Epsilon)
                {
                    return 0F;
                }
                return _negative / _total;
            }
        }

        public float Zero
        {
            get
            {
                if (_total <= float.Epsilon)
                {
                    return 0F;
                }
                return _zero / _total;
            }
        }

        public override string ToString()
        {
            float t = _total;
            StringBuilder sb = new StringBuilder();
            //Positive first
            sb.AppendLine((_positive / t).ToString(STRING_FORMAT));
            
            sb.AppendLine((_negative / t).ToString(STRING_FORMAT));
            sb.AppendLine((_zero / t).ToString(STRING_FORMAT));
            return sb.ToString();
        }

        public string Format(float n)
        {
            return n.ToString(STRING_FORMAT);
        }
    }
}
