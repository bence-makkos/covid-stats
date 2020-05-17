using CsvHelper;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CovidStats
{
    interface IRecordProvider
    {
        IList<Record> GetRecords();
    }

    class RecordProvider : IRecordProvider
    {
        private readonly string _csvPath;

        public RecordProvider(IOptions<ApplicationOptions> options)
        {
            _csvPath = options.Value.CsvPath;
        }

        public IList<Record> GetRecords()
        {
            using var reader = new StreamReader(_csvPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Record>().ToList();
        }
    }
}
