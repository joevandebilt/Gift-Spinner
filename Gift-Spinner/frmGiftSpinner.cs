using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace GiftPicker
{
    public partial class frmGiftSpinner : Form
    {
        bool CloseThread;
        object myLock = new object();
        Thread PageFinder;
        int StartStop = 0;
        bool FindOne;

        public frmGiftSpinner()
        {
            InitializeComponent();
            rbtFindOne.Select();
            FindOne = true;
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Quitting";
            lock (myLock)
            {
                CloseThread = true;
            }
            try
            {
                PageFinder.Join();
            }
            catch { }
            Application.Exit();
        }

        private void cmdSpin_Click(object sender, EventArgs e)
        {
            if (StartStop == 0) //Thread is not running
            {
                CloseThread = false;
                rtbOutput.Clear();


                if (rbtFindMany.Checked == true)
                {
                    cmdSpin.Text = "Stop";
                    FindOne = false;
                    StartStop = 1;
                }
                else if (rbtFindOne.Checked == true)
                {
                    cmdSpin.Text = "Find a Gift";
                    FindOne = true;
                    StartStop = 0;
                }                
                PageFinder = new Thread(FindRandomPage);
                PageFinder.Start();
            }
            else
            {
                lock (myLock)
                {
                    CloseThread = true;
                }
                PageFinder.Join();
                cmdSpin.Text = "Start";
                StartStop = 0;
            }
            //FindRandomPage();
        }

        private void FindRandomPage()
        {
            HttpWebRequest request;
            HttpWebResponse response;
            bool PageFound = false;
            string URL = "http://www.amazon.co.uk/dp/product/B00";
            int Tries = 0;
            while (!CloseThread && !PageFound)
            {
                string PageURL = URL + GenerateRandomString(7) + '/';
                //string PageURL = "http://www.amazon.co.uk/dp/product/B00CIV6990/";    //Test Success
                //string PageURL = "http://www.amazon.co.uk/dp/product/B00CFART0/";     //Test Failure
                try
                {
                    Output(PageURL);
                    request = (HttpWebRequest)WebRequest.Create(PageURL);
                    request.Timeout = 1000;
                    response = (HttpWebResponse)request.GetResponse();
                    response.Dispose();

                    if (FindOne == true) PageFound = true;
                    System.Diagnostics.Process.Start(PageURL);
                    Output(" - Success");
                }
                catch (Exception ex) //404 more than likely
                {
                    PageFound = false;
                    if (ex.Message.Contains("404"))
                    {
                        Output(" - 404");
                    }
                    else Output(" - "+ ex.Message);
                }
                Tries++;
                Output(Environment.NewLine);

                if (this.lblOutput.InvokeRequired)
                {
                    this.lblOutput.BeginInvoke((MethodInvoker)delegate() { this.lblOutput.Text = "Number of Attempts: " + Tries; ;});
                }
                else
                {
                    this.lblOutput.Text = "Number of Attempts: " + Tries;
                }                
            }
        }

        private static Random random = new Random();
        private string GenerateRandomString (int Length)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            int NextChar ;
            for (int i = 0; i < Length; i++)
            {
                NextChar = random.Next(48, 90);
                while (NextChar > 57 && NextChar < 65)
                {
                    NextChar = random.Next(48, 90);
                }
                ch = Convert.ToChar(NextChar);
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void Output(string Input)
        {

            if (this.rtbOutput.InvokeRequired)
            {
                this.rtbOutput.BeginInvoke((MethodInvoker)delegate() { this.rtbOutput.AppendText(Input); ;});
            }
            else
            {
                this.rtbOutput.AppendText(Input);
            }
        }
    }
}
