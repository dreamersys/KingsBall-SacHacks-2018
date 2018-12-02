using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.IO;



namespace client_tutorial
{

    public partial class frm_main : Form
    {
        Socket server = null;
        Socket client = null;  //create a client object

        int settime = 0;
        int setMin = 0, setSec = 0;

        //  create a list to store input scores from clients
        Dictionary<string, int> name_score_dic = new Dictionary<string, int>();
        SortedDictionary<int, string> score_sortdic = new SortedDictionary<int, string>();  

        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //  create server and start recieveing connections
            lblTimerMin.Text = "00";
            lblTimerSec.Text = "00";
        }

        private void create_new_socket()
        {
            //  Port number is defaulted to 6 if there's no input
            int servPort = (Int32.Parse(txt_port.Text)!=7)? Int32.Parse(txt_port.Text) : 7; 
            try
            {
                //  initialize server
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                servPort = Int32.Parse(txt_port.Text);
                server.Bind(new IPEndPoint(IPAddress.Parse(txt_ip.Text), servPort));
                server.Listen(1000); //queue up to 1000 people
            }
            catch (SocketException se)
            {
                MessageBox.Show("Invalid IP Address Input");
                lsb_info.Items.Add(se.ErrorCode + ": " + se.Message);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            create_new_socket();
            btn_downTri1.Enabled = false;
            btn_upTri1.Enabled = false;
            btn_downTri2.Enabled = false;
            btn_upTri2.Enabled = false;
            btnStart.Enabled = false;
            tmr_scoreUpdate.Enabled = true;
            //  set time in ms
            settime = 1000 * (60 * setMin + setSec);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btn_downTri1.Enabled = true;
            btn_upTri1.Enabled = true;
            btn_downTri2.Enabled = true;
            btn_upTri2.Enabled = true;
            btnStart.Enabled = true;
            tmr_scoreUpdate.Enabled = false;

            lbl_numConn.Text = 0.ToString();  //  clear number of connections
            lsb_info.Items.Clear();  //  clear the listbox entry
            name_score_dic.Clear();  //  clear dictionary
            score_sortdic.Clear();  // clear sorted dictionary

            //  reset timer
            settime = 0;
            setMin = 0;
            lblTimerMin.Text = setMin.ToString().PadLeft(2, '0');
            setSec = 0;
            lblTimerSec.Text = setSec.ToString().PadLeft(2, '0');
        }

        private void SocketWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                client = server.Accept(); //accept incoming client
            }
            catch
            {
                return;
            }
        }


        private void tmr_scoreUpdate_Tick(object sender, EventArgs e)
        {
            settime -= tmr_scoreUpdate.Interval;
            if (SocketWorker.IsBusy == false)
                SocketWorker.RunWorkerAsync();
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            lsb_info.Items.Add("WAITING FOR CONNECTION...");
            lsb_info.Items.Add("Client local IpAddress is :" + IPAddress.Parse(((IPEndPoint)server.LocalEndPoint).Address.ToString()));
            lsb_info.Items.Add("Client connected with port number " + ((IPEndPoint)server.LocalEndPoint).Port.ToString());
            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            try
            {
                if (client != null)
                {
                    byte[] rcvBuffer = new byte[32];  //  buffer to store inputs in bytes
                    lsb_info.Items.Add("Accept client - " + client.RemoteEndPoint);
                    client.Receive(rcvBuffer, 0, rcvBuffer.Length, SocketFlags.None);

                    //  encode byte to string and then convert to int
                    var parts = Encoding.UTF8.GetString(rcvBuffer).Split(' ');
                    //  split input string into two parts
                    string player_id = parts[0];
                    //  convert scores from string to int
                    int score_temp = Convert.ToInt32(parts[1]);

                    lsb_info.Items.Add("Recieved from client - " + player_id);
                    lsb_info.Items.Add("Client Score: " + score_temp);

                    //  keep the listbox scroll to the bottom automatically
                    lsb_info.SelectedIndex = lsb_info.Items.Count - 1;
                    //  store player_id as key into another dictionary
                    name_score_dic.Add(player_id, score_temp);
                    //  add client's score to sorted score dictionary
                    score_sortdic.Add(score_temp, player_id);
                    //  increment number of connections
                    lbl_numConn.Text = name_score_dic.Count.ToString();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                //lsb_info.Items.Add(ex.Message);
                client.Close();
            }

            //  if time is up, stop the timer and generate a winner
            if (settime <= 0)
            {
                //  increment number of connections
                lbl_numConn.Text = name_score_dic.Count.ToString();
                //  stop the timer
                tmr_scoreUpdate.Enabled = false;
                //  find out the winner
                dataanalysis(ref score_sortdic, ref name_score_dic);
                //  kill the server connection
                server.Close();
            }

            //  increment timer
            lblTimerSec.Text = ((settime / 1000) % 60).ToString().PadLeft(2, '0');
            lblTimerMin.Text = (((settime / 1000) - (settime / 1000) % 60) / 60).ToString().PadLeft(2, '0');

        }

        private void dataanalysis(ref SortedDictionary<int, string> scores, ref Dictionary<string, int> players)
        {
            if (scores.Count() != 0)
            {
                int WinnerScore = -99;
                WinnerScore = scores.Keys.Max(); //  find the winner with highest score
                lbl_score.Text = WinnerScore.ToString();
                lbl_winnerid.Text = scores[WinnerScore];
            }
        }

        private void btn_upTri1_Click(object sender, EventArgs e)
        {
            setMin += 1;
            if (setMin >= 59)
                setMin = 0;
            lblTimerMin.Text = setMin.ToString().PadLeft(2, '0');
        }

        private void btn_upTri2_Click(object sender, EventArgs e)
        {
            setSec += 1;
            if (setSec >= 59)
                setSec = 0;
            lblTimerSec.Text = setSec.ToString().PadLeft(2,'0');
        }

        private void btn_downTri2_Click(object sender, EventArgs e)
        {
            setSec -= 1;
            if (setSec <= 0)
                setSec = 59;
            lblTimerSec.Text = setSec.ToString().PadLeft(2, '0');

        }

        private void quitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          2018 SacHacks Project\n\n" +
                "           All Rights Reserved to\n" +
                "          Jerry Kuo     David Guo\n" +
                "         Andy Wu      Nathan Ng\n");
        }

        private void showIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (IPAddress ipaddr in Dns.Resolve(Dns.GetHostName()).AddressList)
            {
                DialogResult dialogResult = 
                    MessageBox.Show("         Current IP Address: " + ipaddr.ToString() + "\n" 
                    + "    Do you want to use this IP as address?", "IP Settings", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txt_ip.Text = ipaddr.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void showDomainNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dns.GetHostName());
        }

        private void exportResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\User\\Desktop\\client_test.txt";
            MessageBox.Show("Your Report File Will be in Directory: " + path);
            System.IO.StreamWriter sw = null;


            if (System.IO.File.Exists(path))
            {
                MessageBox.Show("File Already Exists");
                return;
            }
            else
            {
                sw = new System.IO.StreamWriter(System.IO.File.OpenWrite(path));
                IPAddress ipaddr = Dns.Resolve("localhost").AddressList[0];
                sw.WriteLine("Local IP Address: " + ipaddr.ToString());
                sw.WriteLine("Socket IP Address: " + txt_ip.Text);
                sw.WriteLine("Port Number: " + txt_port.Text);
                sw.WriteLine("Number of Connections " + lbl_numConn.Text);
                sw.WriteLine("-----------------------------");
                sw.WriteLine("   Winner ID:         " + lbl_winnerid.Text);
                sw.WriteLine("   Highest Score:     " + lbl_score.Text);
                sw.WriteLine("-----------------------------");
            }

            sw.WriteLine("UnSorted Score List (In Chronological Order):");
            foreach (var item in name_score_dic)
            {
                sw.WriteLine(item.Key.ToString() + ": " + item.Value);
            }

            sw.WriteLine("Sorted Score List:");
            name_score_dic = name_score_dic.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in name_score_dic)
            {
                sw.WriteLine(item.Key.ToString()+ ": " + item.Value);
            }
          
            sw.Flush();

            if (sw != null)
            {
                sw.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press 'ARROWS' to set timer\n" + 
                "Press 'START' to start receving connections\n" +
                "Press 'RESET' to start over\n"+
                "Change IP addresss through textbox if wish\n" +
                "Change Port number through textbox if wish");
        }

        private void btn_downTri1_Click(object sender, EventArgs e)
        {
            setMin -= 1;
            if (setMin <= 0)
                setMin = 59;
            lblTimerMin.Text = setMin.ToString().PadLeft(2, '0');
        }
    }
}
