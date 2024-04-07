using System;

class Program
{
    static void Main()
    {
        // Write Number
        Console.Write("Nhập số thứ nhất: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int Number2 = Convert.ToInt32(Console.ReadLine());

        // Sum
        int Sum = Number1 + Number2;

        // divide and get the remainder
        int Remainder = Sum % 10;

        // In kết quả ra màn hình
        Console.WriteLine("Tổng của hai số là: " + Sum);
        Console.WriteLine("Dư khi chia tổng cho 10 là: " + Remainder);

        Console.ReadLine(); // Để chương trình không đóng ngay sau khi in kết quả
    }
}
