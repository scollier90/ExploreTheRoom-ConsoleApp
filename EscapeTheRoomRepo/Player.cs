using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheRoom
{
   public class Player
    {

        //needs player identifier, 
       
        public string PlayerName { get; set; }
        //public List<string>  PlayerBag { get; }
        public bool HasKey { get; set; }
        public bool HasCode { get; set; }
    }
}
