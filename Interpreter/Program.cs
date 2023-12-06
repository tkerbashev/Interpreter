using Interpreter;

Console.WriteLine( "Interpreter Behavioural Design Pattern example\n" );

var expressions = new List<ISQLExpression>
{
    new FirstTermExpression(),
    new OperatorExpression(),
    new SecondTermExpression()
};

var contextOr = new SQLContext( "Tom or Jerry" );
foreach ( var expression in expressions )
{
    expression.Interpret( contextOr );
}

Console.WriteLine( $"Translating a Google style query to SQL: '{contextOr.Input}' ->\n {contextOr.Output}" );

Console.WriteLine();

var contextAnd = new SQLContext( "Tom and Jerry" );
foreach (var expression in expressions)
{
    expression.Interpret( contextAnd );
}

Console.WriteLine( $"Translating a Google style query to SQL: '{contextAnd.Input}' ->\n {contextAnd.Output}" );