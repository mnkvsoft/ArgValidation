namespace ArgValidation
{
    public struct Argument<T>
    {
        public string Name { get; }
        public T Value { get; }

        public Argument(T value, string name)
        {
            Name = name;
            Value = value;
        }

        public static implicit operator T(Argument<T> argument)
        {
            return argument.Value;
        }
    }
}
