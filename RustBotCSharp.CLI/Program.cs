﻿using RustBotCSharp.MessageConverter;

namespace RustBotCSharp.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            SEVDataFileSaver fileSaver = new SEVDataFileSaver();
            fileSaver.InitializeSubscriber(args[0], args[1]);
            fileSaver.StartReceivingDataSynchronously();
        }
    }
}
