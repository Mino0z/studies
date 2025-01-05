using System;
using System.Collections.Generic;
namespace StrukturaStos{
    public class Stos<T> : IStos<T>
    {

        private List<T> _list;
        public Stos(){
            _list = new List<T>();
        }
        public T Peek {
            get{
                if(IsEmpty) throw new StosEmptyException("Stos jest pusty");
                return _list[_list.Count - 1];
            }
        }
        public int Count => _list.Count;   
        public bool IsEmpty => _list.Count == 0;
        public void Clear() => _list.Clear();
        public T Pop(){
            if(IsEmpty) throw new StosEmptyException("Stos jest pusty");
            T value = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return value;
        }
        public void Push(T value) => _list.Add(value);

        public T[] ToArray() => _list.ToArray();
    }
}