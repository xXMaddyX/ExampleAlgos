namespace DataStructures;

public class RingBuffer<T>(int capacity){
    private readonly T[] Items = new T[capacity];
    private int Head = 0;
    public int Count { get; private set; } = 0;

    public void Add(T item) {
        Items[Head] = item;
        Head = (Head + 1) % Items.Length;
        if (Count < Items.Length) {
            Count ++;
        }
    }

    public T Get(int index) {
        var oldest = (Head - Count + Items.Length) % Items.Length;
        return Items[(oldest + index) % Items.Length];
    }

    public static void RunRingbuffer() {
        var BufferSize = 10;
        var frame = 0;
        var newRingbuffer = new RingBuffer<int>(BufferSize);

        while (frame < BufferSize) {
            frame++;
            newRingbuffer.Add(frame);
        }

        for (var i = 0; i < BufferSize; i++) {
            var item = newRingbuffer.Get(i);
            Console.WriteLine(item);
        }
    } 
}