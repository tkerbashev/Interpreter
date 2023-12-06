namespace Interpreter
{
    public interface ISQLExpression
    {
        void Interpret( SQLContext context );
    }
}
