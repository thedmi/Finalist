Finalist - A Final List
========================


The `IFinalList<T>` concept denotes a non-lazy, immutable list that is covariant in its item type `T`.

The motivation for `IFinalList` was that there is no concept of a list in .NET that carries all of these properties.

- `IReadOnlyList<T>` is covariant in T and eagerly loaded, but is read-only, not immutable 
- `System.Collections.Immutable.IImmutableList<T>` is immutable and carries eager loading semantics, but is not covariant in T
- `IEnumerable<T>` is covariant in T, but uses lazy-loading and also read-only semantics

`System.Collections.Immutable.IImmutableList<T>` would have been the perfect candidate for an immutable list concept. But unfortunately, someone decided to provide the immutable `Add()`, `Remove()` and similar methods not only on the implementation `ImmutableList<T>`, but also on the interface, effectively making the item type invariant. 

To differentiate the immutable list of this library from `System.Collections.Immutable.IImmutableList<T>`, I call it a *Final List*. 

For a discussion about immutable vs. read-only semantics see [the BCL team blog](http://blogs.msdn.com/b/bclteam/archive/2012/12/18/preview-of-immutable-collections-released-on-nuget.aspx).


