using System;

namespace AlbumApp.Domain.ValueObjects
{
    public sealed class Nome
    {
        private string _value;

        public Nome(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public static implicit operator string(Nome value)
        {
            return value._value;
        }        

        public static implicit operator Nome(string value)
        {
            return new Nome(value);
        }

        

        public static bool operator ==(Nome nome1, Nome nome2)
        {
            return nome1._value == nome2._value;
        }

        public static bool operator !=(Nome nome1, Nome nome2)
        {
            return nome1._value != nome2._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return (string)obj == _value;
            }

            return ((Nome)obj)._value == _value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
