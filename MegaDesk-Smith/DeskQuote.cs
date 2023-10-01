using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Smith
{
    internal class DeskQuote
    {
        private String _name;
        public String Name { get => _name; set => _name = value; }
        private Desk _order;
        public Desk Order { get => _order; set => _order = value; }
        private DateTime _date;
        public DateTime Date { get => _date; set => _date = value ; }
        private double _total;
        public double Total { get => _total; set => _total = value; }
        private Rush _time;
        public Rush Time { get => _time; set => _time = value; }




    }

    enum Rush : int
    {
        Rush = 3,
        Fast = 5,
        Expedited = 7,
        Standard = 14
    }
}
