namespace DesignPatterns.Creational.FactoryMethod.Products
{
    class ConsoleLogger : ILogger
    {
        private string Prepend(string level)
        {
            return $"{DateTime.Now} : [{level.ToUpper()}]";
        }

        public void Info(string message)
        {
            string prependMessage = Prepend("INFO");
            Console.WriteLine($"{prependMessage} : {message}");
        }

        public void Debug(string message)
        {
            string prependMessage = Prepend("DEBUG");
            Console.WriteLine($"{prependMessage} : {message}");
        }

        public void Warning(string message)
        {
            string prependMessage = Prepend("WARNING");
            Console.WriteLine($"{prependMessage} : {message}");
        }

        public void Error(string message, Exception exception)
        {
            string prependMessage = Prepend("ERROR");
            Console.WriteLine($"{prependMessage} : {message} : {exception.ToString()}");
        }
    }
}
