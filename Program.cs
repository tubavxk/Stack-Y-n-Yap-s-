using System;

class Stack
{
    private int[] stackArray;
    private int top;
    private int capacity;

    public Stack(int size)
    {
        capacity = size;
        stackArray = new int[size];
        top = -1;
    }
    public void Push(int data)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack dolu! Yeni eleman eklenemez.");
            return;
        }

        stackArray[++top] = data;
        Console.WriteLine($"{data} eklendi.");
    }
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack boş! Eleman çıkarılamaz.");
            return -1;
        }

        Console.WriteLine($"{stackArray[top]} çıkarıldı.");
        return stackArray[top--];
    }
    public int Top()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack boş! Eleman yok.");
            return -1;
        }

        return stackArray[top];
    }
    public bool IsEmpty()
    {
        return top == -1;
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack şu anda boş.");
            return;
        }

        Console.Write("Stack elemanları: ");
        for (int i = top; i >= 0; i--)
        {
            Console.Write(stackArray[i] + " ");
        }
        Console.WriteLine();
    } 
    static void Main()
    {
        Console.Write("Stack'in kapasitesini girin: ");
        int capacity = int.Parse(Console.ReadLine());

        Stack stack = new Stack(capacity);

        while (true)
        {
            Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Eleman Ekle (Push)");
            Console.WriteLine("2 - Eleman Çıkar (Pop)");
            Console.WriteLine("3 - Üstteki Elemanı Gör (Top)");
            Console.WriteLine("4 - Stack'i Yazdır");
            Console.WriteLine("5 - Çıkış");

            Console.Write("Seçiminizi yapın: ");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Eklemek istediğiniz sayıyı girin: ");
                    int pushValue = int.Parse(Console.ReadLine());
                    stack.Push(pushValue);  // Push işlemine geç
                    break;

                case 2:
                    stack.Pop();
                    break;

                case 3:
                    int topValue = stack.Top();
                    if (topValue != -1)
                        Console.WriteLine($"Üstteki eleman: {topValue}");
                    break;

                case 4:
                    stack.PrintStack();
                    break;

                case 5:
                    Console.WriteLine("Çıkılıyor...");
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-5 arasında bir seçim yapın.");
                    break;
            }
        }
    }
}
