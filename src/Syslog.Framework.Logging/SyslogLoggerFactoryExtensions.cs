﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syslog.Framework.Logging
{
    public static class SyslogLoggerFactoryExtensions
    {
        public static void AddSyslog(this ILoggerFactory loggerFactory, IConfigurationSection configuration, string hostName = "localhost", LogLevel logLevel = LogLevel.Debug)
        {
            var settings = new SyslogLoggerSettings();
            configuration.Bind(settings);
            loggerFactory.AddProvider(new SyslogLoggerProvider(settings, hostName, logLevel));
        }
    }
}
