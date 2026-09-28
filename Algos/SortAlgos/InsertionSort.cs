namespace SortAlgos;

class InsertionSort() {
    public List<int> ListToSort = [15, 4, 8, 30, 44, 12, 22, 4, 2, 2];

    public void Run() {
        int i = 1;
        int j = i;
        int temp = 0;
        
        while (i < ListToSort.Count) {
            temp = ListToSort[i];
            j = i;
            while (j > 0 && ListToSort[j - 1] > temp) {
                ListToSort[j] = ListToSort[j -1];
                j--;
            }
            ListToSort[j] = temp;
            i++;
        }
        foreach (var item in ListToSort) {
            Console.WriteLine(item);
        }
    }
}