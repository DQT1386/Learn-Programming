namespace Algorithms;
public class Practice
{
    public static int Main()
    {
        PrimeNumber prime = new PrimeNumber();
        Console.WriteLine("Nhap 1 so can kiem tra");
        int num = int.Parse(Console.ReadLine());
        bool result = prime.CheckPrimeNumber(num);
        string message = "So " + num.ToString() + " is Prime:" + result.ToString();
        //Console.WriteLine($"So {num} is Prime: {result}");
        Console.WriteLine(message);
        Console.ReadLine();
        return 0;
    }

    /*
     1. Viết một chương trình C# để kiểm tra xem một số có phải số nguyên tố hay không.
        Đầu vào:
        Một số nguyên không âm n (0 ≤ n ≤ 1 000 000)
        Đầu ra:
        Nếu n là số nguyên tố thì hàm checkPrimeNumber sẽ trả về true, ngược lại trả về false


    Solution:
         n chia lần lượt cho 2 đến n-1, nếu mà nó chia hết cho bất kì số nào thì return false, nếu không thì return true.

    2. Viết một chương trình C# để tìm giá trị sau khi đảo ngược thứ tự các chữ số của một số. Ví dụ 123 là kết quả của quá trình đảo ngược thứ
        tự các chữ số của 321.
        Đầu vào:
        Một số nguyên n kiểu int
        Đầu ra:
        Hàm reverseNum sẽ trả về số thỏa yêu cầu bài toán

    3. Viết một chương trình C# để hoán đổi giá trị của 2 biến x, y.
        Đầu vào:
        Hai số nguyên x, y kiểu int
        Đầu ra:
        Sau khi thực thi hàm swap, giá trị của x,y được hoán đổi với nhau

    4. Write and run a program that performs the following steps:
        - Assigning value to the radius r.
        - Calculating the circumference using the formula: C = 2πr.
        - Displaying the circumference.
        Given π = 3.14, r is an integer (0 ≤ r ≤ 1000). Just print the answer of the circumference. You don't need to round up to any digit after decimal
   
    5. Write a program that converts the number of days into years, weeks and days. Example: 1532 days = 4 years + 10 weeks + 2 days. Student
        needs to assign value to number of days and display the result as example. Assume a year has 365 days.
        Input: one line contains number n - the number of days ( )
        For example:
        Test Input Result
        5 1532 1532 days = 4 years + 10 weeks + 2 days.

    6. There are many ways to calculate the distance between A and B.
        Below are 2 ways to calculate the distance between point A and point B
        Manhattan distance:
        Euclidean distance:
        Write and run a program that reads the coordinate of 2 points, A and B, from the
        keyboard and then displays the distance between A and B in 2 ways: Manhattan distance and Euclidean distance.
        When printing the distance using Euclidean distance, please round up to 2 digits after decimal by using this formula:
        cout<<fixed<<setprecision(2)<< ...;
        Input:
        The first line contains the coordinate of point A
        The second line contains the coordinate of point B
        Coordinate of point A and point B are integer
        Hint: You can use abs(), sqrt() function

    7.The Fibonacci sequence is 0, 1, 1, 2, 3, 5, 8, 13,…, where the first two terms are 0 and 1, and each term thereafter is the sum of the two
        preceding terms, that is, .
        Using this information, write a program that calculates the nth number in a Fibonacci sequence, where n is entered into the program by the
        user.
        Input:
        Integer n, 90 >= n >= 1
        Output:
        The calculated value
        For example:
        Test Input Result
        Test 1 5 3

    8. Write a program that inputs an array of N real numbers, and then finds and prints the largest element in the array. N should be an input
        parameter.
        Input:
        The first line contains integer N, N >= 1
        The second line contains N real numbers
        Output:
        The largest element in the array, round up to 2 digits after decimal point
     * 
     * 
     * 
     * 
     * 
     */
}