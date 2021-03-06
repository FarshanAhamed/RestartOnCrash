﻿using System;

namespace RestartOnCrash
{
    public class Configuration
    {
        /// <summary>
        /// The full path to the application to monitor
        /// </summary>
        public string PathToApplicationToMonitor { get; set; }

        /// <summary>
        /// The check interval for every operation
        /// </summary>
        public TimeSpan CheckInterval { get; set; }

        /// <summary>
        /// If true, the monitored application gets started only if it is already started a first time by its own.
        /// It is useful when you have an application in "startup".
        /// </summary>
        public bool StartApplicationOnlyAfterFirstExecution { get; set; }
    }
}
