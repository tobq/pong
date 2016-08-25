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
        static bool ballL = false;
        static int padspeed = 5;
        static int ballspeed = 5;

        public Form1()
        {
            InitializeComponent();
            paddle.Location = new Point((ClientRectangle.Width / 2), ClientRectangle.Height - 50);
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

            Text = ball.Location.Y.ToString() + " speed: " + ballspeed;
            ball.Location = new Point(ballL ? ball.Location.X - Math.Abs(ballspeed): ball.Location.X + Math.Abs(ballspeed), Math.Max(Math.Min(ball.Location.Y + ballspeed, ClientRectangle.Height), 0));
            if (ball.Location.Y <= 0) ballspeed *= -1;
            else if (ball.Location.Y >= paddle.Location.Y - ball.Height && ball.Location.X + ball.Width >= paddle.Location.X && ball.Location.X <= paddle.Location.X + paddle.Width - ball.Width && ball.Location.Y <= paddle.Location.Y) ballspeed *= -1;
            if (ball.Location.X <= 0) ballL = false;
            else if (ball.Location.X >= ClientRectangle.Width - ball.Width) ballL = true;

            if (ball.Location.Y >= ClientRectangle.Height)
            {
                update.Stop();
                output.Text = "You've Lost";
            }
        }
    }
    class Ball : Label
    {
        // looking to create custom ball class with static ball speed ect.
    }
}
