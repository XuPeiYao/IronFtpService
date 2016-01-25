using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronFtpService{
    public static class FtpCommand{
        public static class PositivePreliminaryReply {
            public const int ServiceReadyInSomeMinutes = 120;
            public const int DataConnectionAlreadyOpen = 125;
            public const int FileStatusOkay = 150;             
        }

        public static class PositiveCompletionReply {
            public const int CommandSuccessful = 200;
            public const int CommandNotImplemented = 202;
            public const int SystemStatus = 211;
            public const int DirectoryStatus = 212;
            public const int FileStatus = 213;
            public const int HelpMessage = 214;
            public const int NameSystemType = 215;
            public const int ServiceReady = 220;
            public const int ServiceClosing = 221;
            public const int DataConnectionOpen = 225;
            public const int DataConnectionClosing = 226;
            public const int 
        }
    }
}
