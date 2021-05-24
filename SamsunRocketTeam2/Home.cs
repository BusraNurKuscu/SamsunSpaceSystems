using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamsunSpaceSystems
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            try
            {
                if (srlPortGiden.IsOpen == false)
                {
                    srlPortGiden.Open();
                    txtSbtPort2.Text = "Bağlandı";
                }
            }
            catch
            {
                txtSbtPort2.Text = "Bağlanamadı";
            }
        }

        
    }
}
