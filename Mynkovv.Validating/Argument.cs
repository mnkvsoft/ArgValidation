using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating
{
    internal sealed class Argument<TValue>
    {
        public string Name { get; }
        public TValue Value { get; }

        public Argument(Expression<Func<TValue>> arg)
        {
            Func<TValue> func = arg.Compile();
            TValue value = func();

            string name;
            if (arg.Body.NodeType == ExpressionType.Constant)
            {
                ConstantExpression c = (ConstantExpression)arg.Body;
                name = $"Static value '{value}'";

            }
            else if (arg.Body.NodeType == ExpressionType.New)
            {
                NewExpression c = (NewExpression)arg.Body;
                name = $"Static value '{value}'";
            }
            else
            {
                MemberExpression exp = (MemberExpression)arg.Body;
                name = exp.Member.Name;
            }

            Name = name;
            Value = value;
        }
    }
}
