using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    public class LoggingProxyDataset : IDataset
    {
        private ConsoleLogger logger;
        private Dataset dataset;
        private string filePath;

        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
            logger = ConsoleLogger.GetInstance();
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }

        public void LogMessage(string message)
        {
            logger.LogMessage(message);
        }

    }
}
