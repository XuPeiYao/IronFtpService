using IronFtpService.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace IronFtpService{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class FtpSocket{
        Socket serviceSocket;
        List<Socket> clientSocket = new List<Socket>();

        public string Host { get;private set; }
        public int Port { get;private set; }
        public FtpSocket(string Host = "127.0.0.1",int Port = 21){
            this.Host = Host;
            this.Port = Port;
        }

        public async Task Start() {
            serviceSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            serviceSocket.Bind(new IPEndPoint(IPAddress.Parse(this.Host),this.Port));
            serviceSocket.Listen(64);

            while (true) {
                Socket newSocket = await serviceSocket.AcceptSocketAsync();
                this.clientSocket.Add(newSocket);

                Task.Run(async()=>await Listen(newSocket));
            }
        }


        protected async Task Listen(Socket socket) {
            Stream ioStream = socket.GetStream();
            StreamReader reader = new StreamReader(ioStream);
            StreamWriter writer = new StreamWriter(ioStream);

            await writer.WriteLineAsync(FtpCommand.ServiceReady);
            await writer.FlushAsync();
            string command;
            while (true) {
                string result = await RunCommand(await reader.ReadLineAsync());
                await writer.WriteLineAsync(result);
                await writer.FlushAsync();
            }
        }

        protected async Task<string> RunCommand(string Command) {
            //OPTS UTF8 ON  

            try {
                string[] CommandSegments = Command.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                switch (CommandSegments[0].ToUpper()) {
                    case "OPTS":

                        break;
                }

                return await Task.FromResult(FtpCommand.CommandSuccessful);
            } catch {
                return await Task.FromResult(FtpCommand.)
            }
        }

    }
}
