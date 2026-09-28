namespace SortAlgos;

public class QuickSort() {
    public List<int> Unsortet = [5, 2, 10, 9, 25, 15, 15, 18];

    public void Run() {
        var sorted = Sort(Unsortet);

        foreach (var item in sorted) {
            Console.WriteLine(item);
        }
    }

    private List<int> Sort(List<int> list) {
        
        var pivot = list[0];
        var smaller = new List<int>();
        var bigger = new List<int>();

        for (var i = 1; i < list.Count; i++) {
            if (list[i] < pivot) {
                smaller.Add(list[i]);
            } else {
                bigger.Add(list[i]);
            }
        }

        var result = Sort(smaller);
        result.Add(pivot);
        result.AddRange(Sort(bigger));
        return result;
    }
}