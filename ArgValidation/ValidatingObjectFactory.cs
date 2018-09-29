//using System;
//using System.Linq.Expressions;
//
//namespace ArgValidation
//{
//    public static class ValidatingObjectFactory
//    {
//        public static ValidatingObject<TValue> FromExpression<TValue>(Expression<Func<TValue>> expression)
//        {
//            var value = GetValue(expression);
//            string name = GetName(expression, value);
//
//            return new ValidatingObject<TValue>(name, value);
//        }
//        
//        public static ComparableValidatingObject<TValue> ComparableFromExpression<TValue>(Expression<Func<TValue>> expression) where TValue: IComparable<TValue>
//        {
//            var value = GetValue(expression);
//            string name = GetName(expression, value);
//
//            return new ComparableValidatingObject<TValue>(name, value);
//        }
//
//        private static string GetName<TValue>(Expression<Func<TValue>> expression, TValue value)
//        {
//            string name;
//            if (expression.Body.NodeType == ExpressionType.Constant)
//            {
//                name = $"Static value '{value}'";
//            }
//            else if (expression.Body.NodeType == ExpressionType.New)
//            {
//                name = $"Static value '{value}'";
//            }
//            else
//            {
//                MemberExpression exp = (MemberExpression) expression.Body;
//                name = exp.Member.Name;
//            }
//
//            return name;
//        }
//
//        private static TValue GetValue<TValue>(Expression<Func<TValue>> expression)
//        {
//            Func<TValue> func = expression.Compile();
//            TValue value = func();
//            return value;
//        }
//    }
//}