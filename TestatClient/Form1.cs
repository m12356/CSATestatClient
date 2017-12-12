using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrackLineEnter_Click(object sender, EventArgs e)
        {
            
            String text = String.Concat(this.TrackLineLabel.Text, this.textBoxTrackLine.Text);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", true))
            {
                file.WriteLine(text);
            }



            
        }

        private void TrackLineLeftEnter_Click(object sender, EventArgs e)
        {
            String text = String.Concat(this.TrackTurnLeftLabel.Text, this.textBoxTurnLeft.Text,";");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", true))
            {
                file.WriteLine(text);
            }
        }

        private void TrackTurnRightEnter_Click(object sender, EventArgs e)
        {
            String text = String.Concat(this.TrackTurnRightLabel.Text, this.textBoxTurnRight.Text,";");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", true))
            {
                file.WriteLine(text);
            }

        }

        private void TrackArcLeftEnter_Click(object sender, EventArgs e)
        {
            String text = String.Concat(this.TrackArcLeftLabel.Text, this.textBoxArcLeftWinkel.Text,";", this.textBoxArcLeftRadius.Text,";");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", true))
            {
                file.WriteLine(text);
            }
        }

        private void TrackArcRightEnter_Click(object sender, EventArgs e)
        {

            String text = String.Concat(this.TrackArcRightLabel.Text, this.textBoxArcRightWinkel.Text, ";", this.textBoxArcRightRadius.Text,";");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", true))
            {
                file.WriteLine(text);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\Gruber Martin\Desktop\fahrt.txt", "");
            this.Status.BackColor = System.Drawing.Color.Red;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.Status.BackColor = System.Drawing.Color.Green;
        }

        
    }
}
