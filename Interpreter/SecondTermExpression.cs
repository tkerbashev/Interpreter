namespace Interpreter
{
    public class SecondTermExpression : ISQLExpression
    {
        public void Interpret( SQLContext context )
        {
            if (context.ParsedInput.Length > 2)
            {
                context.OutputParts[1] += $"(select ID from TestTable where FIELD like '%{context.ParsedInput[ 2 ]}%') as T2";
            }
        }
    }
}
