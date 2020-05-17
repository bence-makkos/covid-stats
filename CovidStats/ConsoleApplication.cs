namespace CovidStats
{
    class ConsoleApplication
    {
        private readonly IRecordProvider _recordProvider;

        public ConsoleApplication(IRecordProvider recordProvider)
        {
            _recordProvider = recordProvider;
        }

        public void Run()
        {
            var records = _recordProvider.GetRecords();
        }
    }
}
