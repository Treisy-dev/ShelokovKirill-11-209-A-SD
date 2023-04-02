using TreeSort;

namespace TreeSortTests;

public class Tests
{
    List<int> Items = new();
    List<int> Sorted = new();

    [Test]
        public void TreeSortDataGenerate()
        {
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
                
                Sorted.AddRange(Items.OrderBy(x => x).ToArray());
                
                var tree = new TreeSort<int>();
                var result = tree.MakeSort(Items);
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], result[i]);
                }
                Items.Clear();
                Sorted.Clear();
            }
        }
}