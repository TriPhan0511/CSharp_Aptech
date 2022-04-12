using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        public int TuSo { get { return _tuSo; } set { _tuSo = value; } }
        public int MauSo
        {
            get { return _mauSo; }
            set
            {
                if (value == 0)
                {
                    _mauSo = 1;
                }
                else if (value < 0)
                {
                    _mauSo = -value;
                    TuSo = -TuSo;
                }
                else
                {
                    _mauSo = value;
                }
            }
        }

        public PhanSo()
        {
        }

        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
