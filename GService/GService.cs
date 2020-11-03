using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace GService
{
    public partial class GService : ServiceBase
    {
        protected ServiceHost serviceHost = null;

        public GService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // It makes sense to add try - catch block here to log 
            // unsuccessful operations to a text log
            // Currently it logs exceptions to Application event log

            // Close ServiceHost if it exist and in open state
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create SrviceHost for IGServiceHost
            serviceHost = new ServiceHost(typeof(GServiceHost));

            // Open the selfHost to create listeners and start listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
