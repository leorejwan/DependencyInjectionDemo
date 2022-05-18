using LibraryDemo.Utilities;

namespace LibraryDemo
{
    public class BusinnessLogic : IBusinnessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinnessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the processing of data");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing the data");
        }
    }
}