using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyHttpServiceDemo
{
    public partial class HelloService : ServiceBase
    {
        private readonly NancyHost nancyHost;
        public HelloService()
        {
            InitializeComponent();
            nancyHost = new NancyHost(new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            }, new Uri("http://localhost:8866/"));
        }

        protected override void OnStart(string[] args)
        {
            nancyHost.Start();
        }

        protected override void OnStop()
        {
            nancyHost.Stop();
        }
    }
}
