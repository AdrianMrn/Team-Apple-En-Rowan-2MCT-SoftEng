using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class MarketController
    {
        MarketModel _model;
        MarketView _view;
        Object[] buttons_arr;

        public MarketController()
        {
            _model = new MarketModel();
            _view = new MarketView(this);

            

        }

        public MarketView getView()
        {
            //TeerlingVieuw teerling = new TeerlingVieuw();
            return _view;

        }

        public void setText() {
          
            _view.button1.Text = _model.MarketData[0,0];
            _view.button2.Text = _model.MarketData[1,0];
            _view.button3.Text = _model.MarketData[2,0];
            _view.button4.Text = _model.MarketData[3,0];
            _view.button5.Text = _model.MarketData[4, 0];

            _view.lab
        } 




    }
}
