using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace IronFtpService.Extensions
{
    public static class SocketExtension{
        public static Task<Socket> AcceptSocketAsync(this Socket socket) {
            TaskCompletionSource<Socket> tcs = new TaskCompletionSource<Socket>();

            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.Completed += (object sender, SocketAsyncEventArgs e) => {
                tcs.SetResult(e.AcceptSocket);
            };
            socket.AcceptAsync(args);

            return tcs.Task;
        }


        public static Stream GetStream(this Socket socket) {
            return new NetworkStream(socket);
        }
    }
}
