namespace Interpreter
{
    public class SQLContext
    {
        private string _input = string.Empty;
        public string Input
        {
            get => _input;
            set
            {
                _input = value;
                ParsedInput = _input.Split( " " );
            }
        }

        public string[] ParsedInput { get; private set; } = [];
        public string Output => string.Join( ' ', OutputParts );
        public string[] OutputParts { get; set; } = new string[3];
        public SQLContext( string input )
        {
            Input = input;
        }
    }
}
