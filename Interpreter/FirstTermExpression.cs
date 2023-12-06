namespace Interpreter
{
    public class FirstTermExpression : ISQLExpression
    {
        public void Interpret( SQLContext context )
        {
            if ( context.ParsedInput.Length > 0 ) 
            {
                context.OutputParts[1] = $"(select ID from TestTable where FIELD like '%{context.ParsedInput[ 0 ]}%') as T1";
            }
        }
    }
}
