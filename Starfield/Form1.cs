using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starfield
{
    public partial class Stars : Form
    {
        public static int starSpeed;
        public static int SizeOfStar;
        public static ushort CountOfStars;
        

        public class Star
        {
           
            public static List<Brush> color = new List<Brush>();
           
            public static Brush GetRandomColor()
            {            
                return color[new Random().Next(color.Count)];
            }
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        private Star[] stars = new Star[CountOfStars];

        private Random random = new Random();

        private Graphics graphics;

        public Stars()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            foreach (var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }

            Picture.Refresh();
            
        }

        private void MoveStar(Star star)
        {
            star.Z -= starSpeed;
            if (star.Z < 1)
            {
                star.X = random.Next(-Picture.Width, Picture.Width);
                star.Y = random.Next(-Picture.Height, Picture.Height);
                star.Z = random.Next(1, Picture.Width);
            }
        }

        private void DrawStar(Star star)
        {
            float starSize = Map(star.Z, 0, Picture.Width, SizeOfStar, 0); ;

            float x = Map(star.X / star.Z, 0, 1, 0, Picture.Width) + Picture.Width / 2;

            float y = Map(star.Y / star.Z, 0, 1, 0, Picture.Height) + Picture.Height / 2;

            
            graphics.FillEllipse(Star.GetRandomColor(), x, y, starSize, starSize);
        }

        public float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
            //return ((n + start1) * (stop1 + start1)) / (stop2 + start2) - start2;
            //return ((n + start1) / (stop1 + start1)) * (stop2 + start2) + start2;
        }

        private void Stars_Load(object sender, EventArgs e)
        {
            Picture.Image = new Bitmap(Picture.Width, Picture.Height);

            graphics = Graphics.FromImage(Picture.Image);

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-Picture.Width, Picture.Width),
                    Y = random.Next(-Picture.Height, Picture.Height),
                    Z = random.Next(1, Picture.Width)
                };
            }
            Timer.Start();
        }

        
       
    }
}
