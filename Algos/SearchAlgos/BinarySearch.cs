namespace SearchAlgos;

public class BinarySearch() {
    public List<int> MySearchList = [4, 6, 8, 9, 10, 15, 16, 25, 28];

    public void Run() {
        int left = 0;
        int right = MySearchList.Count;
        int middle = 0;
        int target = 10;

        while (left < right) {
            middle = (left + right) / 2;
            if (target == MySearchList[middle]) {
                Console.WriteLine("Found Target");
                Console.WriteLine($"Targed : {MySearchList[middle]} was found on Index {middle}");
                return;
            } else if (target > MySearchList[middle]) {
                left = middle + 1;
            } else if (target < MySearchList[middle]) {
                right = middle;
            }
        }
        Console.WriteLine($"Target {target} was not Found in Search List");
    }
}