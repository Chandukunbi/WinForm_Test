using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinForm_Test
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        //[DllImport("user32.dll")]
        //public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]

        //Activate an application.
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbOtherApps.Items.Add("New Tab - Profile 1 - Microsoft Edge");
            FillKeys();
        }
        private void FillKeys()
        {
            listKeys.Items.Add("{DEL}" + "\t\t\t" + "(F6)");
            listKeys.Items.Add("{CAPSLOCK}" + "\t\t" + "(F5)");
           
            listKeys.Items.Add("{DOWN}" + "\t\t\t" + "(F7)");
            listKeys.Items.Add("{END}" + "\t\t\t" + "(F8)");
            listKeys.Items.Add("{ENTER}" + "\t\t\t" + "(F9)");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInputToOtherApp_Click(object sender, EventArgs e)
        {
            //IntPtr iHandle = FindWindow("Notepad", "Untitled - Notepad");

            //IntPtr iHandle = FindWindow("Notepad++", "*new 8 - Notepad++");
            ////IntPtr iHandle = FindWindow("Chrome_WidgetWin_1", "WhatsApp");
            IntPtr iHandle = FindWindow("XLMAIN", "Microsoft Excel - Book1");
            //IntPtr iHandle = FindWindow("Chrome_WidgetWin_1", "New tab - Personal - Microsoft​ Edge");
            if (iHandle != IntPtr.Zero)            {
                //SendMessage(iHandle, WM_SYSCOMMAND, SC_CLOSE, 0);
                SetForegroundWindow(iHandle);
                SendKeys.SendWait("INDIA");
                SendKeys.Send("{ENTER}");
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.Send("{TAB}");
                    SendKeys.SendWait("INDIA");
                    SendKeys.Send("{ENTER}");
                }

            }
            //var process = Process.Start("microsoft-edge:https://www.bing.com/","India");
            //process.StandardInput.Write("India");
            ////writer.Write("India");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(listKeys.SelectedIndex != -1)
            {
                listSendKeys.Items.Add(listKeys.SelectedItem);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listSendKeys.SelectedIndex != -1)
            {
                listSendKeys.Items.Remove(listKeys.SelectedItem);
            }
        }
    }
}
