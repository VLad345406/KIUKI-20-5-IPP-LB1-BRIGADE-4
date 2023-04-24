using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace IPP_LB1
{
    public partial class Form1 : Form
    {
        private List<ThreadPriority> _threadPriorities = new List<ThreadPriority> { ThreadPriority.Lowest, ThreadPriority.BelowNormal, ThreadPriority.Normal, ThreadPriority.AboveNormal, ThreadPriority.Highest}; 
        
        private static int _c1 = 1;
        private static int _c2 = 1;
        
        private static void FuncThread1()
        {
            _c1 = 1;
            while (true)
            {
                Console.WriteLine(_c1 + @" (First thread)");
                //Thread.Sleep(1);
                _c1++;
                if (_c1 != 100000) continue;
                Thread.Sleep(10000);
                _c1 = 1;
            }
        }

        private static void FuncThread2()
        {
            _c2 = 1;
            while (true)
            {
                Console.WriteLine(new string(' ', 100) + _c2 + @" (Second thread)");
                //Thread.Sleep(1);
                _c2++;
                if (_c2 != 100000) continue;
                Thread.Sleep(10000);
                _c2 = 1;
            }
        }

        private static ThreadStart _threadStart1 = new ThreadStart(FuncThread1);
        private static Thread _thread1 = new Thread(_threadStart1);
        private Stopwatch _swThread1;
        
        private void FuncStatusThread1()
        {
            while (true)
            {
                MessageBox.Show(@"Current value: " + _c1 + '\n' + 
                                @"Spent time: " + _swThread1.Elapsed, @"Thread 1");
                Thread.Sleep(2000);
            }
        }
        
        private Thread _threadStatus1;
        
        private static ThreadStart _threadStart2 = new ThreadStart(FuncThread2);
        private Thread _thread2 = new Thread(_threadStart2);
        private Stopwatch _swThread2;
        
        private void FuncStatusThread2()
        {
            while (true)
            {
                MessageBox.Show(@"Current value: " + _c2 + '\n' + 
                                @"Spent time: " + _swThread2.Elapsed, @"Thread 2");
                Thread.Sleep(2000);
            }
        }
        
        private Thread _threadStatus2;
        
        public Form1()
        {
            InitializeComponent();
            Consondeb();
            var threadStartStatus2 = new ThreadStart(FuncStatusThread2);
            _threadStatus2 = new Thread(threadStartStatus2);
            
            var threadStartStatus1 = new ThreadStart(FuncStatusThread1);
            _threadStatus1 = new Thread(threadStartStatus1);
        }

        private static void Consondeb()
        {
            if (NativeMethods.AllocConsole())
            {
                IntPtr stdHandle = NativeMethods.GetStdHandle(NativeMethods.STD_OUTPUT_HANDLE);
            }
        }
        
        public abstract class NativeMethods
        {
            public static Int32 STD_OUTPUT_HANDLE = -11;

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "GetStdHandle")]
            public static extern System.IntPtr GetStdHandle(Int32 nStdHandle);

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "AllocConsole")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool AllocConsole();
        }

        private void buttonStartFirstThread_Click(object sender, EventArgs e)
        {
            if (!_thread1.IsAlive)
            {
                buttonUpPriorityThread1.Enabled = true;
                buttonDownPriorityThread1.Enabled = true;
                buttonStartFirstThread.Text = @"Зупинити перший потік";
                labelStatus1.Text = @"Status: active";
                _thread1.Start();
                _threadStatus1.Start();
                _swThread1 = Stopwatch.StartNew();
                labelPriorityThread1.Text = @"Priority: " + _thread1.Priority.ToString();
            }
            else
            {
                buttonUpPriorityThread1.Enabled = false;
                buttonDownPriorityThread1.Enabled = false;
                buttonStartFirstThread.Text = @"Запустити перший потік";
                labelStatus1.Text = @"Status: inactive";
                _thread1.Abort();
                _swThread1.Stop();
                _threadStatus1.Abort();
                _threadStatus1 = new Thread(FuncStatusThread1);
                _thread1 = new Thread(_threadStart1);
                labelPriorityThread1.Text = @"Priority: null";
            }
        }

        private void buttonStartSecondThread_Click(object sender, EventArgs e)
        {
            if (!_thread2.IsAlive)
            {
                buttonUpPriorityThread2.Enabled = true;
                buttonDownPriorityThread2.Enabled = true;
                buttonStartSecondThread.Text = @"Зупинити другий потік";
                labelStatus2.Text = @"Status: active";
                _thread2.Start();
                _swThread2 = Stopwatch.StartNew();
                _threadStatus2.Start();
                labelPriorityThread2.Text = @"Priority: " + _thread2.Priority.ToString();
            }
            else
            {
                buttonUpPriorityThread2.Enabled = false;
                buttonDownPriorityThread2.Enabled = false;
                buttonStartSecondThread.Text = @"Запустити другий потік";
                labelStatus2.Text = @"Status: inactive";
                _thread2.Abort();
                _swThread2.Stop();
                _threadStatus2.Abort();
                _thread2 = new Thread(_threadStart2);
                _threadStatus2 = new Thread(FuncStatusThread2);
                labelPriorityThread2.Text = @"Priority: null";
            }
        }

        private void buttonUpPriorityThread1_Click(object sender, EventArgs e)
        {
            var findPrioritiesIndex = _threadPriorities.FindIndex(x => x.Equals(_thread1.Priority));
            _thread1.Priority = _threadPriorities[findPrioritiesIndex + 1];
            labelPriorityThread1.Text = @"Priority: " + _thread1.Priority.ToString();
            buttonDownPriorityThread1.Enabled = true;
            if (findPrioritiesIndex == 3)
                buttonUpPriorityThread1.Enabled = false;
        }

        private void buttonDownPriorityThread1_Click(object sender, EventArgs e)
        {
            var findPrioritiesIndex = _threadPriorities.FindIndex(x => x.Equals(_thread1.Priority));
            _thread1.Priority = _threadPriorities[findPrioritiesIndex - 1];
            labelPriorityThread1.Text = @"Priority: " + _thread1.Priority.ToString();
            buttonUpPriorityThread1.Enabled = true;
            if (findPrioritiesIndex == 1)
                buttonDownPriorityThread1.Enabled = false;
        }

        private void buttonUpPriorityThread2_Click(object sender, EventArgs e)
        {
            var findPrioritiesIndex = _threadPriorities.FindIndex(x => x.Equals(_thread2.Priority));
            _thread2.Priority = _threadPriorities[findPrioritiesIndex + 1];
            labelPriorityThread2.Text = @"Priority: " + _thread2.Priority.ToString();
            buttonDownPriorityThread2.Enabled = true;
            if (findPrioritiesIndex == 3)
                buttonUpPriorityThread2.Enabled = false;
        }

        private void buttonDownPriorityThread2_Click(object sender, EventArgs e)
        {
            var findPrioritiesIndex = _threadPriorities.FindIndex(x => x.Equals(_thread2.Priority));
            _thread2.Priority = _threadPriorities[findPrioritiesIndex - 1];
            labelPriorityThread2.Text = @"Priority: " + _thread2.Priority.ToString();
            buttonUpPriorityThread2.Enabled = true;
            if (findPrioritiesIndex == 1)
                buttonDownPriorityThread2.Enabled = false;
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_thread1.IsAlive)
            {
                _thread1.Abort();
                _threadStatus1.Abort();
            }
            if (_thread2.IsAlive)
            {
                _thread2.Abort();
                _threadStatus2.Abort();
            }

            e.Cancel = false;
        }
    }
}