using CommandLine;
using CommandLine.Text;


namespace CalculatorConsole
{
    public enum OperationType
    {
        suma,
        divide
    }

    public class ArgumentsOptions
    {
        
        public OperationType Operacion { get; set; }

        [ValueOption(1)]
        public int Value1 { get; set; }

        [ValueOption(2)]
        public int Value2 { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
