using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using MjpegProcessor;


namespace MJPEG_bluetooth_tank
{
    public partial class Form1 : Form
    {
        //DEFINE GLOBAL VARIABLES, WHICH WILL BE USED TO SEND COMMANDS TO THE VEHICLE
        // their value changes with every change in the tBar.Value
        //*********************************************************
        byte[] FORWARD =    new byte[1];
        byte[] BACKWARD =   new byte[1];
        byte[] RIGHT =      new byte[1];
        byte[] LEFT =       new byte[1];
        byte[] FWD_RIGHT =  new byte[1];
        byte[] FWD_LEFT =   new byte[1];
        byte[] BWD_RIGHT =  new byte[1];
        byte[] BWD_LEFT =   new byte[1];
        byte[] STOP =       new byte[1];

        byte LAST_SENT_COMMAND = 0; //by using this new command will only be sent, if it is different from the last one
        byte SPEED_TMP = 9; //variable containing the speed of the vehicle, set by tBar.Value

        //********************************************************
        
        MjpegDecoder mjpeg; //MJPEG decoder appearing on the main Form

        
        
        public Form1()
        {
            InitializeComponent();

            List<String> tList = new List<String>();

            bluetoothBox.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            tList.Sort();
            bluetoothBox.Items.AddRange(tList.ToArray());
            bluetoothBox.SelectedIndex = 0;

            serialPort.BaudRate = 9600;

            labelSpeed.Text = "Speed: " + tBar.Value;

            //initilaize the set of codes
            STOP[0] =        0;
            FORWARD[0] =     (byte)(10 + SPEED_TMP);
            BACKWARD[0] =    (byte)(20 + SPEED_TMP);
            RIGHT[0] =       (byte)(30 + SPEED_TMP);
            LEFT[0] =        (byte)(40 + SPEED_TMP);
            FWD_RIGHT[0] =   (byte)(50 + SPEED_TMP);
            FWD_LEFT[0] =    (byte)(60 + SPEED_TMP);
            BWD_RIGHT[0] =   (byte)(70 + SPEED_TMP);
            BWD_LEFT[0] =    (byte)(80 + SPEED_TMP);

            mjpeg = new MjpegDecoder();

           }

        
        void timer_Tick(object sender, EventArgs e)
        {
            var left = KeyboardInfo.GetKeyState(Keys.Left);
            var right = KeyboardInfo.GetKeyState(Keys.Right);
            var up = KeyboardInfo.GetKeyState(Keys.Up);
            var down = KeyboardInfo.GetKeyState(Keys.Down);

            if (left.IsPressed)
            {
                if (up.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_up_left;
                    if (LAST_SENT_COMMAND != FWD_LEFT[0]) serialPort.Write(FWD_LEFT, 0, 1);
                    LAST_SENT_COMMAND = FWD_LEFT[0];
                    return;
                }
                if (down.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_down_left;
                    if (LAST_SENT_COMMAND != BWD_LEFT[0]) serialPort.Write(BWD_LEFT, 0, 1);
                    LAST_SENT_COMMAND = BWD_LEFT[0];
                    return;
                }
                if (right.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.stop;
                    if (LAST_SENT_COMMAND != STOP[0]) serialPort.Write(STOP, 0, 1);
                    LAST_SENT_COMMAND = STOP[0];
                    return;
                }
                arrowBox.Image = Properties.Resources.arrow_left;
                if (LAST_SENT_COMMAND != LEFT[0]) serialPort.Write(LEFT, 0, 1);
                LAST_SENT_COMMAND = LEFT[0];
            }

            if (right.IsPressed)
            {
                if (up.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_up_right;
                    if (LAST_SENT_COMMAND != FWD_RIGHT[0]) serialPort.Write(FWD_RIGHT, 0, 1);
                    LAST_SENT_COMMAND = FWD_RIGHT[0];
                    return;
                }
                if (down.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_down_right;
                    if (LAST_SENT_COMMAND != BWD_RIGHT[0]) serialPort.Write(BWD_RIGHT, 0, 1);
                    LAST_SENT_COMMAND = BWD_RIGHT[0];
                    return;
                }
                if (left.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.stop;
                    if (LAST_SENT_COMMAND != STOP[0]) serialPort.Write(STOP, 0, 1);
                    LAST_SENT_COMMAND = STOP[0];
                    return;
                }
                arrowBox.Image = Properties.Resources.arrow_right;
                if (LAST_SENT_COMMAND != RIGHT[0]) serialPort.Write(RIGHT, 0, 1);
                LAST_SENT_COMMAND = RIGHT[0];

            }

            if (up.IsPressed)
            {
                if (left.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_up_left;
                    if (LAST_SENT_COMMAND != FWD_LEFT[0]) serialPort.Write(FWD_LEFT, 0, 1);
                    LAST_SENT_COMMAND = FWD_LEFT[0];
                    return;
                }
                if (right.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_up_right;
                    if (LAST_SENT_COMMAND != FWD_RIGHT[0]) serialPort.Write(FWD_RIGHT, 0, 1);
                    LAST_SENT_COMMAND = FWD_RIGHT[0];
                    return;
                }
                if (down.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.stop;
                    if (LAST_SENT_COMMAND != STOP[0]) serialPort.Write(STOP, 0, 1);
                    LAST_SENT_COMMAND = STOP[0];
                    return;
                }
                arrowBox.Image = Properties.Resources.arrow_up;
                if (LAST_SENT_COMMAND != FORWARD[0]) serialPort.Write(FORWARD, 0, 1);
                LAST_SENT_COMMAND = FORWARD[0];

            }

            if (down.IsPressed)
            {
                if (left.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_down_left;
                    if (LAST_SENT_COMMAND != BWD_LEFT[0]) serialPort.Write(BWD_LEFT, 0, 1);
                    LAST_SENT_COMMAND = BWD_LEFT[0];
                    return;
                }
                if (right.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.arrow_down_right;
                    if (LAST_SENT_COMMAND != BWD_RIGHT[0]) serialPort.Write(BWD_RIGHT, 0, 1);
                    LAST_SENT_COMMAND = BWD_RIGHT[0];
                    return;
                }
                if (up.IsPressed)
                {
                    arrowBox.Image = Properties.Resources.stop;
                    if (LAST_SENT_COMMAND != STOP[0]) serialPort.Write(STOP, 0, 1);
                    LAST_SENT_COMMAND = STOP[0];
                    return;
                }
                arrowBox.Image = Properties.Resources.arrow_down;
                if (LAST_SENT_COMMAND != BACKWARD[0]) serialPort.Write(BACKWARD, 0, 1);
                LAST_SENT_COMMAND = BACKWARD[0];

            }

            if (!right.IsPressed && !left.IsPressed && !up.IsPressed && !down.IsPressed)
            {
                arrowBox.Image = Properties.Resources.stop;
                if (LAST_SENT_COMMAND != STOP[0]) serialPort.Write(STOP, 0, 1);
                LAST_SENT_COMMAND = STOP[0];

            }
        }

        private void bluetoothBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right))
                e.Handled = true;
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
            timer.Stop();
        }

        private void tBar_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right))
                e.Handled = true;
        }

        
        
        private void MJPEGstartButton_Click(object sender, EventArgs e)
        {
            
            mjpeg.FrameReady += mjpeg_FrameReady;
            mjpeg.Error += mjpeg_Error;
            mjpeg.ParseStream(new Uri((string)addressBox.Text));
        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            videoBox.Image = e.Bitmap;
        }

        void mjpeg_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void tBar_ValueChanged(object sender, EventArgs e)
        {
            SPEED_TMP = (byte)tBar.Value;

            FORWARD[0] =    (byte)(10 + SPEED_TMP);
            BACKWARD[0] =   (byte)(20 + SPEED_TMP);
            RIGHT[0] =      (byte)(30 + SPEED_TMP);
            LEFT[0] =       (byte)(40 + SPEED_TMP);
            FWD_RIGHT[0] =  (byte)(50 + SPEED_TMP);
            FWD_LEFT[0] =   (byte)(60 + SPEED_TMP);
            BWD_RIGHT[0] =  (byte)(70 + SPEED_TMP);
            BWD_LEFT[0] =   (byte)(80 + SPEED_TMP);

            labelSpeed.Text = "Speed: " + tBar.Value;
        }

        private void BLUETOOTHstartButton_Click(object sender, EventArgs e)
        {
            if (bluetoothBox.SelectedText != "COM1" || bluetoothBox.SelectedText != "COM3")
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    timer.Start();
                    BLUETOOTHstartButton.Text = "End communication";
                }
                else
                {
                    serialPort.Close();
                    timer.Stop();
                    BLUETOOTHstartButton.Text = "Start communication";
                    arrowBox.Image = Properties.Resources.comm_stopped;
                }
            }
            else MessageBox.Show("Choose the appropriate port first!", "!!! FATAL UBER ERROR 666 !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void bluetoothBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bluetoothBox.SelectedText != "COM1" || bluetoothBox.SelectedText != "COM3")
            {
                serialPort.PortName = (string)bluetoothBox.SelectedItem;
            }
        }

        private void addressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right))
                e.Handled = true;
        }

        private async void MJPEGstopButton_Click(object sender, EventArgs e)
        {
            mjpeg.StopStream();
            await Task.Delay(200);
            videoBox.Image = Properties.Resources.no_video;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 HelpForm = new Form2();
            HelpForm.Show();
        }

        
    }


    public struct KeyStateInfo
    {
        private Keys key;
        private bool isPressed;
        private bool isToggled;
 
        public KeyStateInfo(Keys key, bool ispressed, bool istoggled)
        {
            this.key = key;
            isPressed = ispressed;
            isToggled = istoggled;
        }
 
        public static KeyStateInfo Default
        {
            get
            {
                return new KeyStateInfo(Keys.None, false, false);
            }
        }
 
        public Keys Key
        {
            get { return key; }
        }
 
        public bool IsPressed
        {
            get { return isPressed; }
        }
 
        public bool IsToggled
        {
            get { return isToggled; }
        }
    }
    
    public class KeyboardInfo
    {
        [DllImport("user32")]
        private static extern short GetKeyState(int vKey);

        private KeyboardInfo()
        {

        }

        public static KeyStateInfo GetKeyState(Keys key)
        {
            short keyState = GetKeyState((int)key);
            int low = Low(keyState), high = High(keyState);
            bool toggled = low == 1;
            bool pressed = high == 1;
            return new KeyStateInfo(key, pressed, toggled);
        }

        private static int High(int keyState)
        {
            return keyState > 0 ? keyState >> 0x10
                    : (keyState >> 0x10) & 0x1;
        }

        private static int Low(int keyState)
        {
            return keyState & 0xffff;
        }
    }
}
