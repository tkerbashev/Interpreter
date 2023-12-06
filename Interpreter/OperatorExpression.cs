namespace Interpreter
{
    public class OperatorExpression : ISQLExpression
    {
        public void Interpret( SQLContext context )
        {
            if (context.ParsedInput.Length > 1)
            {
                if (context.ParsedInput[1].ToLower( ).Trim( ) == "or")
                {
                    context.OutputParts[ 0 ] = "select ISNULL(T1.ID, T2.ID) as ID from \n";
                    context.OutputParts[1] += " FULL OUTER JOIN ";
                }
                else
                {
                    context.OutputParts[ 0 ] = "select T1.ID as ID from \n";
                    context.OutputParts[1] += " INNER JOIN ";
                }
                context.OutputParts[ 2 ] = "\non T1.ID = T2.ID";
            }

        }
    }
}
