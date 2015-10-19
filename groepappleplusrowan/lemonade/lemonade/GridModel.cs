using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
   public class GridModel
    {

      static List<GridController> gridjes = new List<GridController>();
      static int _counter = 0;
      bool _isBought = false;
      public int Counter { get { return _counter; } set { _counter = value; } }
        


      public List<GridController> TheList
      {
          get { return gridjes; }
          set { gridjes = new List<GridController>(value); }
      }
      // bool _enabled;
        int _waardeButton;
        public int WaardeButton {
            get {
                return _waardeButton;
            } 
            set{
                _waardeButton = value;
            } 
        }
        public bool IsBought { get { return _isBought; } set { _isBought = value; } }


       // public bool Gridbool { get {return _enabled } set { _enabled = value } }
    }
}
