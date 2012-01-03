using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace MicrosoftEnterpriseLibraryLogging
{
    class Program
    {
        private static LogWriter writer = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();

        static void Main(string[] args)
        {
            LogEntry entry = new LogEntry();

            entry.Message = "Application started.";
            entry.Categories.Add("General");

            writer.Write(entry);
            writer.FlushContextItems();
        }
    }
}
