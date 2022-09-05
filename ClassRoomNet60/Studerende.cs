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

        public Studerende()
        {

        }
        
        public string Årstid(int fødselsmåned)
        {
            if (fødselsmåned == 12 || fødselsmåned == 1 || fødselsmåned == 2)
            {
                return "vinter";
            }

            if (fødselsmåned == 3 || fødselsmåned == 4 || fødselsmåned == 5)
            {
                return "forår";
            }

            if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                return "sommer";
            }

            if (fødselsmåned == 9 || fødselsmåned == 10 || fødselsmåned == 11)
            {
                return "efterår";
            }
            return null;
        }

        public override string ToString()
        {
            return $"Navn = {_navn}, FødselsMåned = {_fødselsmåned}, Fødselsdag = {_fødselsdag}";
        }
    }
}
