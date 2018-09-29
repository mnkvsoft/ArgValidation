﻿using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public sealed class ValidatingObject<TValue>
    {
        public string Name { get; }
        public TValue Value { get; }

        private ValidatingObject(string name, TValue value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Validating object name cannot be empty");

            Name = name;
            Value = value;
        }
        
        public static ValidatingObject<TValue> FromExpression(Expression<Func<TValue>> expression)
        {
            Func<TValue> func = expression.Compile();
            TValue value = func();

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

            return new ValidatingObject<TValue>(name, value);
        }
    }
}