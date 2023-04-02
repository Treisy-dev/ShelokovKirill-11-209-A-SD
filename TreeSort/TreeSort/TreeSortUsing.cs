namespace TreeSort;

public class TreeSortUsing
{

    public void DoTreeSort()
    {
        List<int> Items = new();
        string[] files = Directory.GetFiles(@"/Users/kirillshelokov/RiderProjects/TreeSort/TreeSort/TestData");
        foreach (var file in files)
        {
            StreamReader sr = new StreamReader(file);
            int element;
            while (!sr.EndOfStream)
            {
                element = int.Parse(sr.ReadLine());
                Items.Add(element);
            }
            sr.Close();
            
            var tree = new TreeSort<int>();
            
            var result = tree.MakeSort(Items);

            Items.Clear();

            //return result;
        }
        
    }
}