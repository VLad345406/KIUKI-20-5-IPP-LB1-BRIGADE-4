using System;
using System.Threading;
using System.Windows.Forms;

namespace IPP_LB1
{
    public partial class Form1 : Form
    {
        private static int _c1 = 1;
        
        private static void FuncThread1()
        {
            _c1 = 1;
            while (true)
            {
                Console.WriteLine(_c1 + @" (First thread)");
                Thread.Sleep(1);
                _c1++;
                if (_c1 != 100000) continue;
                Thread.Sleep(10000);
                _c1 = 1;
            }
        }

        

        private static void FuncThread2()
        {
            var c = 1;
            while (true)
            {
                Console.WriteLine(new string(' ', 100) + c + @" (Second thread)");
                Thread.Sleep(1);
                c++;
                if (c != 100000) continue;
                Thread.Sleep(10000);
                c = 1;
            }
        }
        
        

        private static ThreadStart _threadStart1 = new ThreadStart(FuncThread1);
        private static Thread _thread1 = new Thread(_threadStart1);
        
        private static void FuncStatusThread1()
        {

            //_thread1.Priority = ;
        }
        
        private static ThreadStart _threadStartStatus1 = new ThreadStart(FuncStatusThread1);
        private Thread _threadStatus1 = new Thread(_threadStartStatus1);
        
        private static ThreadStart _threadStart2 = new ThreadStart(FuncThread2);
        private Thread _thread2 = new Thread(_threadStart2);
        
        private static void FuncStatusThread2()
        {
            
        }
        
        private static ThreadStart _threadStartStatus2 = new ThreadStart(FuncStatusThread2);
        private Thread _threadStatus2 = new Thread(_threadStartStatus2);
        
        public Form1()
        {
            InitializeComponent();
            Consondeb();
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
                buttonStartFirstThread.Text = @"Зупинити перший потік";
                labelStatus1.Text = @"Status: active";
                _thread1.Start();
            }
            else
            {
                buttonStartFirstThread.Text = @"Запустити перший потік";
                labelStatus1.Text = @"Status: inactive";
                _thread1.Abort();
                _thread1 = new Thread(_threadStart1);
            }
        }

        private void buttonStartSecondThread_Click(object sender, EventArgs e)
        {
            if (!_thread2.IsAlive)
            {
                buttonStartSecondThread.Text = @"Зупинити другий потік";
                labelStatus2.Text = @"Status: active";
                _thread2.Start();
            }
            else
            {
                buttonStartSecondThread.Text = @"Запустити другий потік";
                labelStatus2.Text = @"Status: inactive";
                _thread2.Abort();
                _thread2 = new Thread(_threadStart2);
            }
        }
    }
}