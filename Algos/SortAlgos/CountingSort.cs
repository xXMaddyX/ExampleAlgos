namespace SortAlgos;

public class CountingSort() {
    public List<int> UnsortetList = [4, 4, 10, 20, 20, 25, 23, 11, 11];

    public void Run() {
        int[] CountArr = new int[UnsortetList.Max() + 1];
        List<int> Results = [];

        for (var i = 0; i < UnsortetList.Count; i++) {
            CountArr[UnsortetList[i]] += 1;
        }

        for (var i = 0; i < CountArr.Length; i++) {
            var counter = CountArr[i];
            while (counter > 0) {
                Results.Add(i);
                counter--;
            }
        }

        foreach (var item in Results) {
            Console.WriteLine(item);
        }
    }
}