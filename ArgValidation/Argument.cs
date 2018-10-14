using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public struct Argument<T>
    {
        public string Name { get; }
        public T Value { get; }

        public Argument(T value, string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Argument name cannot be empty");

            Name = name;
            Value = value;
        }

        public bool IsNotInitialized()
        {
            return Name == null;
        }
        
        public static Argument<T> FromExpression(Expression<Func<T>> expression)
        {
            Func<T> func = expression.Compile();
            T value = func();

            string name;
            if (expression.Body.NodeType == ExpressionType.Constant)
            {
                name = $"Static value '{value}'";

            }
            else if (expression.Body.NodeType == ExpressionType.New)
            {
                name = $"Static value '{value}'";
            }
            else
            {
                MemberExpression exp = (MemberExpression)expression.Body;
                name = exp.Member.Name;
            }

            return new Argument<T>(value, name);
        }
    }
}
