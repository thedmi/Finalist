// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinalList.cs" company="Dani Michel">
//   Dani Michel 2013
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Finalist
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    public static class FinalList
    {
        public static IFinalList<T> Create<T>(params T[] values)
        {
            return new FinalList<T>(values);
        }

        public static IFinalList<T> Create<T>(ImmutableList<T> immutableList)
        {
            return new FinalList<T>(immutableList);
        } 

        public static IFinalList<T> Empty<T>()
        {
            return FinalList<T>.Empty;
        }
    }

    internal sealed class FinalList<T> : IFinalList<T>
    {
        private static readonly FinalList<T> _empty = new FinalList<T>(ImmutableList<T>.Empty);

        private readonly ImmutableList<T> _list;

        public FinalList(params T[] values)
        {
            _list = System.Collections.Immutable.ImmutableList.Create(values);
        }

        public FinalList(ImmutableList<T> immutableList)
        {
            _list = immutableList;
        }

        public static FinalList<T> Empty { get { return _empty; } }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index] { get { return _list[index]; } }

        public int Count { get { return _list.Count; } }

        public bool IsEmpty { get { return _list.IsEmpty; } }

        public ImmutableList<T> ImmutableList { get { return _list; } }
    }
}