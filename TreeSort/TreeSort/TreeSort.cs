namespace TreeSort;

public class TreeSort<T>
    where T : IComparable
{
    public List<T> MakeSort(IEnumerable<T> items)
    {
        var tree = new Tree<T>(items);
        var sorted = tree.Inorder();
        return sorted;
    }
}