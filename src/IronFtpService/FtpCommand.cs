using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronFtpService{
    public static class FtpResponse{
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
            public const int EnteringPassiveMode = 227;
            public const int EnteringLongPassiveMode = 228;
            public const int EnteringExtendedPassiveMode = 229;
            public const int UserLoggedIn = 230;
            public const int UserLoggedOut = 231;
            public const int LogoutCommandNoted = 232;
            public const int RequestedFileActionOkay = 250;
            public const int PathNameCreated = 257;
        }

        public static class PositiveIntermediateReply {
            public const int UserNameOkayNeedPassword = 331;
            public const int NeedAccountForLogin = 332;
            public const int RequestedFileActionPendingFurtherInformation = 350;
        }

        //public static class 
    }
}
