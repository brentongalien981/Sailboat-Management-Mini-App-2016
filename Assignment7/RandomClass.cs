using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class RandomClass
    {
        public RandomClass(object sender)
        {
            MessageBox.Show("sender: " + sender.GetType());
        }
    }
}
