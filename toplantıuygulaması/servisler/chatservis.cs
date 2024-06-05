using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplantıuygulaması.servisler
{
    public class chatservis
    {
        HubConnection connection;
        public HubConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new HubConnectionBuilder().WithUrl("https://pdedtestapi.ibrahimbagislar.com/chathub").Build();
                    connection.Closed += HubConnection_Closed;
                }
                return connection;
            }
        }

        private async Task HubConnection_Closed(Exception exception)
        {
            await connection.StartAsync();
        }
    }
}
