namespace SortAlgos;

public class BubbleSort() {
    public List<int> Unsortet = [5, 2, 10, 9, 25, 15, 15, 18];

    public void Run() {
        var i = 0;
        var swapped = true;
        while (i < Unsortet.Count && swapped) {
            swapped = false;
            for (var j = 0; j < Unsortet.Count - 1 - i; j++) {
                var temp = Unsortet[j];
                if (Unsortet[j + 1] < temp) {
                    Unsortet[j] = Unsortet[j + 1];
                    Unsortet[j + 1] = temp;
                    swapped = true;
                }
            }
            i++;
        }

        foreach (var item in Unsortet) {
            Console.WriteLine(item);
        }
    }
}