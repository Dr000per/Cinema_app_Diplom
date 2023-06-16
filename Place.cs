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
        public static List<Place> list = new List<Place>();

        private void this_Click(object sender, EventArgs e)
        {
            Place place = (Place)sender;
            if (place.BackColor == Color.Purple)
            {
                place.BackColor = Color.Lime;
                if (list.Contains(place))
                {
                    list.Remove(place);
                    MessageBox.Show($"Кнопка удалена из списка: {place}");
                    MessageBox.Show(list.Count.ToString());
                    foreach (Place item in list)
                    {
                        MessageBox.Show($"Место: {item.Number} Ряд: {item.Row}");
                    }
                }
            }
            else
            {
                place.BackColor = Color.Purple;
                list.Add(place);
                MessageBox.Show($"Кнопка добавлена в список: {place}");
                MessageBox.Show(list.Count.ToString());
                foreach(Place item in list)
                {
                    MessageBox.Show($"Место: {item.Number} Ряд: {item.Row}");
                }
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
