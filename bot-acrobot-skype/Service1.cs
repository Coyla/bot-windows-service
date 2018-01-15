using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Log;
using System.Configuration;
using BuildABot.UC;
namespace bot_acrobot_skype
{
    public partial class Service1 : ServiceBase
    {
        private Timer botTimer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            botTimer = new Timer(StartBotListenerService, null, 0, Timeout.Infinite);
            Logger.Debug("Service is on start");
        }

        protected override void OnStop()
        {
            Logger.Debug("Service is on stop");
        }

        private void StartBotListenerService(object state)
        {
            
        }
    }
}
