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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.textBox1.Text = $"111 balabala. My Thread ID is :{Thread.CurrentThread.ManagedThreadId}\r\n";
                AsyncMethod();
                this.textBox1.Text += $"222 balabala. My Thread ID is :{Thread.CurrentThread.ManagedThreadId}\r\n";
            }
        }
        private async Task AsyncMethod()
        {
            var ResultFromTimeConsumingMethod = TimeConsumingMethod();
            string Result = await ResultFromTimeConsumingMethod + " + AsyncMethod. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId;
            this.textBox1.Text += $"result:{Result}\r\n";
            //返回值是Task的函数可以不用return
        }

        //这个函数就是一个耗时函数，可能是IO操作，也可能是cpu密集型工作。
        private Task<string> TimeConsumingMethod()
        {
            var task = Task.Run(() => {
                Console.WriteLine("Helo I am TimeConsumingMethod. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                Console.WriteLine("Helo I am TimeConsumingMethod after Sleep(5000). My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);
                return "Hello I am TimeConsumingMethod";
            });

            return task;
        }

    }
}
