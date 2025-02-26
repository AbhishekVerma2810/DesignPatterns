namespace DesignPatterns.Creational.FactoryMethod.Products
{
    class FileLogger : ILogger
    {
        private string logFilePath = "logFile.log";
        private void WriteMessage(string message)
        {
            using(StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(message);
            }
        }
        private string PrependMessage(string level)
        {
            return $"{DateTime.Now} : [{level.ToUpper()}]";
        }

        public void Debug(string message)
        {
            string prependMessage = PrependMessage("DEBUG");
            WriteMessage($"{prependMessage} : {message}");
        }

        public void Error(string message, Exception exception)
        {
            string prependMessage = PrependMessage("ERROR");
            WriteMessage($"{prependMessage} : {message} : {exception.ToString()}");
        }

        public void Info(string message)
        {
            string prependMessage = PrependMessage("INFO");
            WriteMessage($"{prependMessage} : {message}");
        }

        public void Warning(string message)
        {
            string prependMessage = PrependMessage("WARNING");
            WriteMessage($"{prependMessage} : {message}");
        }
    }
}
