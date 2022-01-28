using ChatClient.MVVM.Core;
using ChatClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVVM.ViewModel
{
    class MainViewModel
    {
        public RelayCommand ConnectToServerComand { get; set; }

        private Server _server;

        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerComand = new RelayCommand(o => _server.ConnectToServer());
        }
    }
}
