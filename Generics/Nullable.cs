namespace Generics
{
    //where T: IComparable
    //where T: struct
    //where T: class
    //where T: new()
    public class Nullable<T> where T : struct //constraint
    {
        private object _value;

        public Nullable()
        {
                
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue) return (T)_value; //example of unboxing

            return default(T);
        }
    }

}
