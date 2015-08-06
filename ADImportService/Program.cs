﻿using System.ServiceProcess;

namespace Kentico.ADImportService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase.Run(new ListenerService());
        }
    }
}
