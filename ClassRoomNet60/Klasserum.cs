using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Klasserum
    {
        private string _klassenavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        public string Klassenavn
        {
            get { return _klassenavn; }
            set { _klassenavn = value; }
        }

        public List<Studerende> Klasseliste
        {
            get { return _klasseliste; }
            set { _klasseliste = value; }
        }

        public DateTime Semesterstart
        {
            get { return _semesterstart; }
            set { _semesterstart = value; }
        }

        public Klasserum()
        {
            
        }

        public Klasserum(string klassenavn, List<Studerende> klasseliste, DateTime semesterstart)
        {
            Klassenavn = klassenavn;
            Klasseliste = klasseliste;
            Semesterstart = semesterstart;

        }

        public override string ToString()
        {
            return $"Klassenavn = {_klassenavn}, Klasselist = {_klasseliste}, Semesterstart = {_semesterstart}";
        }
    }
}
