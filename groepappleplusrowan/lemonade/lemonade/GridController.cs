using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class GridController
    {
        public GridView _view;
        public GridModel _model;
       

        public GridController()
        {
            _view = new GridView(this);
            _model = new GridModel();
        }

        public GridView getView()
        {
            //TeerlingVieuw teerling = new TeerlingVieuw();
            return _view;

        }

        public void CheckGrid()
        {



            _model.Counter++;


        }

    }  
}
