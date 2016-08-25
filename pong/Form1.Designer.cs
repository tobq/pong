namespace pong
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddle = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.paddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paddle.Location = new System.Drawing.Point(186, 403);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(200, 20);
            this.paddle.TabIndex = 0;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 16;
            this.update.Tick += new System.EventHandler(this.frame);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ball.Location = new System.Drawing.Point(273, 127);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Top;
            this.output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.output.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(584, 40);
            this.output.TabIndex = 2;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.output);
            this.Name = "Pong";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Release);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label paddle;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label output;
    }
}

