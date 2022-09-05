using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public string Navn
        {
            get { return _navn; }
            private set { _navn = value; }
        }

        public int FødselsMåned
        {
            get { return _fødselsmåned; }
            private set { _fødselsmåned = value; }
        }

        public int FødselsDag
        {
            get { return _fødselsdag; }
            private set { _fødselsdag = value; }
        }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public override string ToString()
        {
            return $"Navn = {_navn}, FødselsMåned = {_fødselsmåned}, Fødselsdag = {_fødselsdag}";
        }
    }
}
