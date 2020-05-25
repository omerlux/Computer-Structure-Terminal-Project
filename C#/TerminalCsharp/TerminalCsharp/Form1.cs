using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics; //for timer
using System.Timers;

namespace TerminalCsharp
{
    public partial class Form1 : Form
    {
        public delegate void myDelegate(string sData);
        private System.Timers.Timer timer2 = new System.Timers.Timer();
        SerialPort mySerialPort = new SerialPort();
        bool init_con = true;
        public string Messege = "";
        int filecount = 1;
        int bytecount = 0;
        string text = "";


        public Form1()
        {
            InitializeComponent();
        }

        public void Log_Write(string Add)
        {
            LogText.Text = Add + LogText.Text;
        }


        public void Init_Connect()
        {
            mySerialPort.BaudRate = 9600;
            mySerialPort.PortName = COMbox.Text;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            try
            {
                //mySerialPort.Open();   //7_6_2019
                //mySerialPort.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Connect()  //Connection
        {
            if (init_con)
            {
                Init_Connect();
                init_con = false;
            }
            int parity;
            if (ParityBox.Text == "None")
                parity = 0;
            else if (ParityBox.Text == "Even")
                parity = 1;
            else
                parity = 2;
            mySerialPort.Open();
            // In Naveh configuration
            mySerialPort.Write("connect config " + BaudRateBox.Text + " " + StopBitBox.Text + " " + parity + "$");
            System.Threading.Thread.Sleep(100);
            mySerialPort.Close();
            mySerialPort.BaudRate = Convert.ToInt32(BaudRateBox.Text); 
            mySerialPort.PortName = COMbox.Text;
            mySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityBox.Items[ParityBox.SelectedIndex].ToString());
            mySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBitBox.Items[StopBitBox.SelectedIndex].ToString());
            mySerialPort.Open();
            mySerialPort.Write("$");
            System.Threading.Thread.Sleep(1000); // wait till data transmited
            Messege = mySerialPort.ReadExisting().ToString();
            mySerialPort.Close();
            //GetMessege(8, "");
        }

        private void GetMessege (int Bytes, String SendText) //8_7_9
        {
            try 
            {
                mySerialPort.Open();
                if(SendText !="")
                    mySerialPort.Write(SendText);
                Stopwatch timer = new Stopwatch();
                timer.Start();
                while (timer.Elapsed.TotalSeconds < 2)
                {
                    if (mySerialPort.BytesToRead.Equals(Bytes))
                        break;
                }
                System.Threading.Thread.Sleep(200); // wait till data ready
                Messege = mySerialPort.ReadExisting().ToString();
                timer.Stop();
                mySerialPort.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void DataTake(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;

        }
        private void BufferClear(byte[] buff)
        {
            for (int i = 0; i < buff.Length; i++)
                buff[i] = 0;
        }

        //private void DataTake(object sender, SerialDataReceivedEventArgs e)
        //{
        //    System.Threading.Thread.Sleep(500); // wait till data ready
        //    SerialPort sp = (SerialPort)sender;
        //    string inData = sp.ReadLine();          //reading a line antil \n
        //    MessageBox.Show(inData);
        ////////mySerialPort.DiscardInBuffer();
        ////////mySerialPort.Dispose();
        ////////mySerialPort.Close();

        //LogText.Text = LogText.Text + indata;          // NOT WORKING!@$!@#!#!@#
        //MessageBox.Show(indata);

        //LogText.Text = LogText.Text + indata;
        //if (indata == "ack")
        //{
        //    MessageBox.Show("Request Recieved");
        //}
        //else
        //    MessageBox.Show("Connection Failed: " + indata);
        //port.Close();

        //StopBits stopBits = (StopBits)(comboBoxSTPBIT.SelectedItem);
        //Parity parity = (Parity)comboBoxParity.SelectedIndex;

        //port = new SerialPort(comboBoxCOM.SelectedItem.ToString(),
        //                      int.Parse(comboBoxBaud.SelectedItem.ToString()),
        //                      parity,
        //                      int.Parse(comboBoxDATABITS.SelectedItem.ToString()),
        //                      stopBits);
        //}

        private void Button1_Click(object sender, EventArgs e) // UPDATE CONNECTION
        {
            Connect();  // Initiate and connect together
            if (Messege.Take(7).SequenceEqual("Updated")) // for timer option \n is gone
            {
                Log_Write("Connection has been updated!\r\n");
                // ENABLING BUTTONS
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                TestConnection.Enabled = true;
            }
            else
            {
                Log_Write("Connection error!\r\n");
            }
            Messege = "";
            //WORKING SITUATION EXAMPLE
            //Init_Connect();
            //mySerialPort.Open();
            //mySerialPort.Write("connect config 9600 1 0$");
            //System.Threading.Thread.Sleep(800); // wait till data ready
            //MessageBox.Show(mySerialPort.ReadExisting());
            //mySerialPort.Close();
        }

        private void Button2_Click(object sender, EventArgs e)  // CHECK CONNECTION
        {
            GetMessege(8, "connect check$");
            Log_Write(Messege);
            Messege = "";
            //mySerialPort.Open();  // 7_7_19 Working...
            //mySerialPort.Write("connect check$");
            //System.Threading.Thread.Sleep(800); // wait till data ready
            //                                    //     for (int i = 0; i < 100; i++) ;
            //string text = mySerialPort.ReadExisting().ToString();
            //LogText.Text = LogText.Text + text;
            //mySerialPort.Close();

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxChat.Visible = true;
            GroupBoxCommands.Visible = false;
            GroupBoxFile.Visible = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxCommands.Visible = true;
            GroupBoxChat.Visible = false;
            GroupBoxFile.Visible = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxFile.Visible = true;
            GroupBoxCommands.Visible = false;
            GroupBoxChat.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

        }

        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e) // FILE picker
        {
            ChosenFileLabel.Visible = true;
            ChosenFileLabel.Text = FilePicker.Text + " has been chosen!";
            SendFileButton.Enabled = true;
            SendByte.Enabled = true;
        }

        private void CommandsBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string cmd = this.Text;
            }
        }

        private void SendFileButton_Click(object sender, EventArgs e) // FILE TO NAVEH
        {
            string CurrentFile = this.FilePicker.Text;
            text = System.IO.File.ReadAllText(@"D:\Documents\BGU Programing\computer structure\Terminal Project\C#\TerminalCsharp\TerminalCsharp\txt\" + CurrentFile + ".txt");
            Log_Write( this.FilePicker.Text + " has been sent!\r\n");

            mySerialPort.Open();
            mySerialPort.Write("file ToNaveh " + text.Length + " " + CurrentFile + "$");       // "file ToNaveh ## filenum$"
            System.Threading.Thread.Sleep(120); // wait till data ready
            mySerialPort.Write(text); //UART CONFIGED TO DMA
            System.Threading.Thread.Sleep(1000); // wait till data ready
            Messege = mySerialPort.ReadExisting().ToString();
            //mySerialPort.Write("$");
            mySerialPort.DiscardInBuffer();
            mySerialPort.Close();
            if (Messege.Take(4).SequenceEqual("Done"))
            {
                DisplayContext.Enabled = true;
            }
            Log_Write(Messege);
            Messege = "";
        }

        private void SendByte_Click(object sender, EventArgs e) // SEND BYTE BY BYTE TO NAVEH
        {
            string CurrentFile = this.FilePicker.Text;
            text = System.IO.File.ReadAllText(@"D:\Documents\BGU Programing\computer structure\Terminal Project\C#\TerminalCsharp\TerminalCsharp\txt\" + CurrentFile + ".txt");
            Log_Write(this.FilePicker.Text + " is sending!\r\n");

            
            mySerialPort.Open();
            mySerialPort.Write("file ToNaveh " + text.Length + " " + CurrentFile + "$");       // "file ToNaveh ## filenum$"

            timer2.Enabled = true;
            timer2.Interval = 300;
            timer2.Elapsed += new EapsedEvelntHandler(timer_Elapsed);
            timer2.Start();
            while (timer2.Enabled) ;
           // STOP ANYTHING TILL FINISHED TRANSACTION
            Messege = mySerialPort.ReadExisting().ToString();
            mySerialPort.DiscardInBuffer();
            mySerialPort.Close();
            if (Messege.Take(4).SequenceEqual("Done"))
            {
                DisplayContext.Enabled = true;
            }
            Log_Write(Messege);
            Messege = "";
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)  //TIMER EVENT FOR BYTE BY BYTE
        {
            if (bytecount > text.Length - 1)
            {
                timer2.Enabled = false;
                timer2.Stop();
                bytecount = 0;
            }

            else
            {
                mySerialPort.Write(""+text[bytecount]); //text in the spesific place
                bytecount++;
            }
        }

        private void ReciveButton_Click(object sender, EventArgs e)     //RECIEVE FILE - ONLY IF SENT 1
        {
            mySerialPort.Open();
            mySerialPort.Write("file ToPC$");       // "file ToNaveh ## filenum$"
            System.Threading.Thread.Sleep(50); // wait till data ready
            Messege = mySerialPort.ReadExisting().ToString();
            if (!Messege.Take(3).SequenceEqual("~No"))  // means the file exist! - ~NoFile
            {
                string name = Messege;
                mySerialPort.DiscardInBuffer();
                mySerialPort.Write("$");       // "file ToNaveh ## filenum$"
                System.Threading.Thread.Sleep(300); // wait till data ready
                Messege = mySerialPort.ReadExisting().ToString();
                mySerialPort.DiscardInBuffer();
                mySerialPort.Close();
                string URL = @"D:\Documents\BGU Programing\computer structure\Terminal Project\C#\TerminalCsharp\TerminalCsharp\received\" + name + "_#" + filecount + ".txt";

                System.Threading.Thread.Sleep(1000); // wait till data ready
                using (FileStream fs1 = File.Create(URL))
                {
                    // StreamWriter writer = new StreamWriter(fs1);
                    Byte[] info = new UTF8Encoding(true).GetBytes(Messege);
                    fs1.Write(info, 0, info.Length);
                    //fs1.Close();
                }
                Log_Write(" ' " + name + "_#" + filecount + " ' has been saved.\r\n");
                filecount += 1; // give a number to a file
            }
            else
            {
                mySerialPort.Write("$");
                mySerialPort.Close();
            }
            Messege = "";
        }
        private void DisplayContext_Click(object sender, EventArgs e)   // DISPLAY CONTEXT
        {
            mySerialPort.Open();
            mySerialPort.Write("file LCDswipe$");       // File show
            System.Threading.Thread.Sleep(300); // wait till data ready
            Messege = mySerialPort.ReadExisting().ToString();
            mySerialPort.DiscardInBuffer();
            mySerialPort.Close();
            Log_Write( Messege);
            ReciveButton.Enabled = true;
            Messege = "";
        }

        private void CommandsBox_KeyDown(object sender, KeyEventArgs e)     // RGB SET AND CLEAR
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;          //No sound
                Log_Write( "You'r command is: " + this.CommandsBox.Text + "\r\n");

                mySerialPort.Open();
                mySerialPort.Write("command " + this.CommandsBox.Text + "$");
                CommandsBox.Text = "";
                System.Threading.Thread.Sleep(200); // wait till data ready
                if (Messege.Take(8).SequenceEqual("ErrorCmd"))
                    Log_Write("ErrorCmd: Something went wrong...");
                mySerialPort.Close();
                Messege = "";
            }
        }

        private void ChatBox_KeyDown(object sender, KeyEventArgs e)         // CHAT SENDER
        {
            //if (ChatBox.Text.Length % 16 == 0 && ChatBox.Text.Length >= 16)
            //{
            //    ChatBox.Text += Environment.NewLine;
            //    // This sets the caret to end
            //    ChatBox.SelectionStart = ChatBox.Text.Length;
            //}
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;          //No sound
                Log_Write ("You: ' " + this.ChatBox.Text + " '.\r\n");
                String meser = ChatBox.Text;
                while (meser.Length !=16 && meser.Length != 32)
                    meser += " ";

                mySerialPort.Open();
                mySerialPort.Write("chat " + meser + "$");
                ChatBox.Text = "";
                System.Threading.Thread.Sleep(200); // wait till data ready
                if (Messege.Take(8).SequenceEqual("ErrorWrd"))
                    Log_Write ("ErrorWrd: Something went wrong...");
                mySerialPort.Close();
                Messege = "";
                CountLabel.Text = "";
            }
        }

        private void COMbox_Click(object sender, EventArgs e)
        {
            COMbox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                COMbox.Items.Add(s);
            }
        }

        private void BaudRateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMbox.Text != "" && BaudRateBox.Text != "" && StopBitBox.Text != "" && ParityBox.Text != "")
                UpdateButton.Enabled = true;
        }

        private void StopBitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMbox.Text != "" && BaudRateBox.Text != "" && StopBitBox.Text != "" && ParityBox.Text != "")
                UpdateButton.Enabled = true;
        }

        private void ParityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMbox.Text != "" && BaudRateBox.Text != "" && StopBitBox.Text != "" && ParityBox.Text != "")
                UpdateButton.Enabled = true;
        }

        private void COMbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMbox.Text != "" && BaudRateBox.Text != "" && StopBitBox.Text != "" && ParityBox.Text != "")
                UpdateButton.Enabled = true;
        }

        private void ChatBox_KeyUp(object sender, KeyEventArgs e)
        {
            CountLabel.Text = "" + ChatBox.Text.Length;
        }

        private void LogText_TextChanged(object sender, EventArgs e) //TRIED TO FIX SCROLLING IN LOG TEXT
        {
            //LogText.scrollBar.Value = scrollBar.Maximum;
            //LogText.ScrollToCaret 
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }

    }
}
