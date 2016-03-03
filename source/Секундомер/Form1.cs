using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimeWorkCounter
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            
            timer.Interval = 10;
            timer.Start();
            timer.Tick += new EventHandler(tickTimer);
            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = System.Drawing.SystemColors.Window;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void tickTimer(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            /*string elepsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                                       ts.Milliseconds / 10);*/
            label1.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "00:00:00.00" && button1.Text != "Resume")
            {
                stopwatch.Stop();
                button1.Text = "Resume";
                richTextBox1.Text += DateTime.Now.ToString(@"HH:mm:ss") + ": Pause.\nWork current time: " + label1.Text + "\n";
            }
            else
            {
                stopwatch.Start();
                button1.Text = "Pause";
                richTextBox1.Text += DateTime.Now.ToString(@"HH:mm:ss") + ": Resume.\nWork current time: " + label1.Text + "\n";
            }
            //stopwatch.Reset();
           // stopwatch.Start();
         }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            button1.Text = "Start";
            richTextBox1.Text += DateTime.Now.ToString(@"HH:mm:ss") + ": Stop.\nWork current time: " + label1.Text + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString(@"HH:mm:ss");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
