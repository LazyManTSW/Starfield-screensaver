using System;
using System.Drawing;
using System.Windows.Forms;
using static Starfield.Stars;

namespace Starfield
{
    public partial class Parameters : Form
    {
   

        public Parameters()
        {
            InitializeComponent();
            CountOfStars = (ushort)Count.Value;
            starSpeed = (int)Speed.Value;
            SizeOfStar = (int)numericUpDown1.Value;
        }

        private void Count_ValueChanged(object sender, EventArgs e)
        {
            CountOfStars = (ushort)Count.Value;
        }
        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            starSpeed = (int)Speed.Value;
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            if (Star.color.Count == 0)
            {
                MessageBox.Show("Choose color please");
                return;
            }
            Stars program = new Stars();
            program.Show();


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isChecked = false;
            Brush brush;

            /*Red
            White
            Green
            Yellow
            Orange
             Cyan
            Purple
             Blue
            */
            string color = (string)checkedListBox1.SelectedItem;

            switch (color)
            {
                case "Red":
                    brush = Brushes.Red;
                     Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;

                case "White":
                    brush = Brushes.White;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;

                case "Green":
                    brush = Brushes.Green;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;

                case "Yellow":
                    brush = Brushes.Yellow;
                    Check(brush, ref isChecked); ;
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;

                case "Orange":
                    brush = Brushes.Orange;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;
                case "Cyan":
                    brush = Brushes.Cyan;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;
                case "Purple":
                    brush = Brushes.Purple;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;
                case "Blue":
                    brush = Brushes.Blue;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;
                case "Pink":
                    brush = Brushes.Pink;
                    Check(brush, ref isChecked);
                    if (isChecked)
                        return;

                    Star.color.Add(brush);
                    break;

            }
            
            

            
        }
        private void Check(Brush brush, ref bool isChecked)
        {
            bool isTrue = Star.color.FindColor(brush);
            
            if (isTrue)
            {
                for (int i = 0; i < Star.color.Count; i++)
                {
                    int index = Star.color.IndexOf(brush);
                    if (index == -1)
                    {
                        isChecked = true;
                        return;
                    }

                     Star.color.RemoveAt(index);                 
                }
                isChecked = true;
                return;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SizeOfStar = (int)numericUpDown1.Value;
        }
    }
}
