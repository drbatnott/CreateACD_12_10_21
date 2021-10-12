using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateACD_12_10_21
{
    public partial class Form1 : Form
    {
        List<CD> cdList;
        public Form1()
        {
            InitializeComponent();
            cdList = new List<CD>();
            float[] lot = { 20.25f, 18.8f, 9.6f, 15.6f, 14.5f };
            CD newCD = new CD("Rachmaninov 2", 5,lot);
            cdList.Add(newCD);
            //float f1 = newCD.TrackLength(5);
            listBox1.Items.Add(newCD.Title);
            listBox1.Items.Add(newCD.NTracks);
            for(int i = 0; i < newCD.NTracks; i++)
            {
                listBox1.Items.Add(newCD.TrackLength(i));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
