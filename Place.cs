using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_app_Diplom
{
    [ToolboxItem(true)]
    public class Place : Button
    {
        public int Row { get; set; }
        public int Number { get; set; }


        private void this_Click(object sender, EventArgs e)
        {
            if ((sender as Place).BackColor == Color.Purple)
            {
                (sender as Place).BackColor = Color.Green;
            }
            else
            {
                (sender as Place).BackColor = Color.Purple;
            }
        }


        public Place()
        {
            this.FlatStyle = FlatStyle.Popup;
            this.Size = new Size(28, 23);
            this.Click += this_Click;
        }
    }
}
