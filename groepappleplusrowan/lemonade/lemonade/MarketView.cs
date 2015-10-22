using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemonade
{
    public partial class MarketView : UserControl
    {
        MarketController _controller;
        public MarketView(MarketController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void MarketView_Load(object sender, EventArgs e)
        {
            _controller.setText();
        }
    }
}
