using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSports
{
    public class FindTitles
    {
        public int Page { get; set; }
        public int Per_Page { get; set; }
        public int Total { get; set; }
        public int Total_Pages { get; set; }
        public List<Titles> Data { get; set; }

    }

    public class Titles
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string ImdbID { get; set; }
    }
}
