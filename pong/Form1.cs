using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        static bool lef = false;
        static bool rig = false;
        static int padspeed = 5;
        static int ballspeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void FormDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) lef = true;
            if (e.KeyCode == Keys.Right) rig = true;
        }

        private void Release(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) lef = false;
            if (e.KeyCode == Keys.Right) rig = false;
        }

        private void frame(object sender, EventArgs e)
        {
            Point loc = paddle.Location;
            if (lef) loc = new Point(Math.Max(Math.Min(loc.X - padspeed, ClientRectangle.Width - paddle.Width), 0), ClientRectangle.Height - 50);
            if (rig) loc = new Point(Math.Max(Math.Min(loc.X + padspeed, ClientRectangle.Width - paddle.Width), 0), ClientRectangle.Height - 50);
            paddle.Location = loc;

            if (ball.Location.Y <= 0 || ball.Location.Y >= paddle.Location.Y-ball.Height) ballspeed *= -1;
            Text = ball.Location.Y.ToString()+" speed: "+ballspeed;
            ball.Location = new Point(Math.Min(Math.Max(ball.Location.X,0),paddle.Location.Y), ball.Location.Y + ballspeed);
        }
    }
    class Ball : Label
    {
        // looking to create custom ball class with static ball speed ect.
    }
}
