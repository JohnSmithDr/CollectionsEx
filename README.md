# CollectionsEx

Useful extensions for C# collections.

## Examples

### #AddRange

**add range to collection, using enumerable**

``` C#
var col = new LinkedList<int>();
col.AddRange(new List<int>() { 0, 1, 2, 3 });
col.Should().HaveCount(4).And.Equal(0, 1, 2, 3);
```

**add range to collection, using params**

``` C#
var col = new LinkedList<int>();
col.AddRange(0, 1, 2, 3);
col.Should().HaveCount(4).And.Equal(0, 1, 2, 3);
```

### #ForEach

**iteration**

``` C#
var col = new string[] { "foo", "bar" };

col.ForEach((x) =>
{
    x.Should().NotBeNullOrEmpty();
});
```

**iteration with index**

``` C#
var col = new int[] { 0, 1, 2, 3, 4, 5 };

col.ForEach((x, i) =>
{
    x.Should().Be(i);
});
```

**iteration of dictionary**

``` C#
var dict = new Dictionary<string, int>()
{
    { "foo", 1 },
    { "bar", 2 }
};

dict.ForEach((key, value) =>
{
    key.Should().NotBeNullOrEmpty();
    value.Should().BeGreaterThan(0);
});
```

### #IsNullOrEmpty

``` C#
int[] arr = null;
arr.IsNullOrEmpty().Should().BeTrue();

var list = new List<int>();
list.IsNullOrEmpty().Should().BeTrue();
```

### #NotNullOrEmpty

``` C#
int[] arr = new int[] { 0, 1, 2, 3 };
arr.NotNullOrEmpty().Should().BeTrue();

var list = new List<int>() { 0, 1, 2, 3 };
list.NotNullOrEmpty().Should().BeTrue();
```
