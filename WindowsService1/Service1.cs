using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            File.AppendAllText("cc.txt",$"OnStart:{DateTime.Now.ToString()}");
        }

        protected override void OnStop()
        {
            File.AppendAllText("cc.txt", $"OnStop:{DateTime.Now.ToString()}");
        }
    }
}
