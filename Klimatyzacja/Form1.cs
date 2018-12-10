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

namespace Klimatyzacja
{
    public partial class Form1 : Form
    {
        int[] Zima = new int[1440];
        int[] Lato = new int[1440];
        public bool running = false;

        public Form1()
        {

            InitializeComponent();
            this.CenterToScreen();
            Pb1.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/winter.jpg");
            Pb2.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/wood.png");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            trackBar5.Enabled = false;
            trackBar4.Enabled = false;
            trackBar2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex.Equals(0))
            {
                Pb2.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/wood.png");
            }

            if (comboBox2.SelectedIndex.Equals(1))
            {
                Pb2.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/brick.jpg");
            }

            if (comboBox2.SelectedIndex.Equals(2))
            {
                Pb2.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/concrete.jpg");
            }
        }

        #region Zbiory Scenariuszy + generate

        private void button1_Click(object sender, EventArgs e)
        {
            //zima
            for (int i = 0; i < 180; i++)
            {
                Zima[i] = -18;
            }

            for (int i = 180; i < 420; i++)
            {
                Zima[i] = -16;
            }

            for (int i = 420; i < 780; i++)
            {
                Zima[i] = -12;
            }

            for (int i = 780; i < 900; i++)
            {
                Zima[i] = -10;
            }

            for (int i = 900; i < 1200; i++)
            {
                Zima[i] = -14;
            }

            for (int i = 1200; i < 1320; i++)
            {
                Zima[i] = -16;
            }

            for (int i = 1320; i < 1440; i++)
            {
                Zima[i] = -19;
            }

            for (int i = 0; i < 1440; i++)
            {
                Console.WriteLine(i + "   " + Zima[i]);
            }

            //lato
            for (int i = 0; i < 180; i++)
            {
                Lato[i] = 15;
            }

            for (int i = 180; i < 420; i++)
            {
                Lato[i] = 17;
            }

            for (int i = 420; i < 780; i++)
            {
                Lato[i] = 19;
            }

            for (int i = 780; i < 960; i++)
            {
                Lato[i] = 24;
            }

            for (int i = 960; i < 1260; i++)
            {
                Lato[i] = 27;
            }

            for (int i = 1260; i < 1440; i++)
            {
                Lato[i] = 23;
            }

            for (int i = 1320; i < 1440; i++)
            {
                Lato[i] = 16;
            }

            for (int i = 0; i < 1440; i++)
            {
                Console.WriteLine(i + "   " + Lato[i]);
            }

        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                Pb1.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/winter.jpg");
            }

            if (comboBox1.SelectedIndex.Equals(1))
            {
                Pb1.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/summer.png");
            }

            if (comboBox1.SelectedIndex.Equals(2))
            {
                Pb1.Image = Image.FromFile("D:/Klimatyzacja/fotoIO/roll.png");
            }


        }

        private async void trackBar2_Scroll(object sender, EventArgs e)
        {
            OBox.Text = trackBar2.Value.ToString();
            if (running == true)
            {
                StpBtn.PerformClick();
                await Task.Delay(1001);
                StartBtn.PerformClick();
            }
        }

        private async void trackBar1_Scroll(object sender, EventArgs e)
        {
            IBox.Text = trackBar1.Value.ToString();
            if (running == true)
            {
                StpBtn.PerformClick();
                await Task.Delay(1001);
                StartBtn.PerformClick();
            }
        }

        private async void trackBar3_Scroll(object sender, EventArgs e)
        {
            DesiredBox.Text = trackBar3.Value.ToString();
            if (running == true)
            {
                StpBtn.PerformClick();
                await Task.Delay(1001);
                StartBtn.PerformClick();
            }
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;

            trackBar3.Enabled = false; 
            trackBar1.Enabled = false;

            running = true;
            var s1 = trackBar2.Value.ToString();
            var s2 = trackBar1.Value.ToString();
            var s3 = textBox2.Text;


            var roomT = new Progress<int>(x => trackBar1.Value = x);
            var desiredT = new Progress<int>(x => trackBar3.Value = x);
            var airconT = new Progress<int>(x => trackBar5.Value = x);
            var heating = new Progress<int>(x => trackBar4.Value  = x);

            var roomTbox = new Progress<string>(x => IBox.Text = x);
            var outsidebox = new Progress<string>(x => OBox.Text = x);
            var airconbox = new Progress<string>(x => textBox2.Text = x);




            int[] outsideT = Zima;
            double materialQ;

            int roomTi = trackBar1.Value;
            int desiredTi = trackBar3.Value;
            int airconTi = trackBar5.Value;
            int heatingi = trackBar4.Value;

            if (comboBox1.SelectedIndex.Equals(0))
            {
                outsideT = Zima;
            }
            else
            {
                outsideT = Lato;
            }

            if (comboBox2.SelectedIndex.Equals(0))
            {
                materialQ = 0.2;
            }
            else if (comboBox2.SelectedIndex.Equals(1))
            {
                materialQ = 0.8;
            }
            else
            {
                materialQ = 1.7;
            }

            var progress1 = new Progress<string>(x => Logs.Text += x);

            await Task.Factory.StartNew(() => SecondThreadConcern.LongWork(progress1, s1, s2, s3, roomT, roomTi, roomTbox, desiredT, desiredTi, heating, heatingi, outsideT, outsidebox, airconT, airconTi, airconbox, materialQ),
                                TaskCreationOptions.LongRunning);
        }

        private async void StpBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;
            running = false;
            await Task.Factory.StartNew(() => SecondThreadConcern.Staph(),
                                TaskCreationOptions.LongRunning);
            trackBar3.Enabled = true;
            trackBar1.Enabled = true;
        }
    }

}
