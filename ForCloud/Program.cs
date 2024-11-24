
/// 10 => 2

//Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
//int number = int.Parse(Console.ReadLine());

//string binary = ConvertToBinary(number);

//Console.WriteLine($"2-lik sanoq sistemasida: {binary}");


//static string ConvertToBinary(int number)
//{
//    if (number == 0)
//        return "0";

//    string binary = "";

//    while (number > 0)
//    {
//        int remainder = number % 2;
//        binary = remainder + binary;
//        number /= 2;
//    }

//    return binary;
//}



// 10 => 8

//Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
//int decimalNumber = int.Parse(Console.ReadLine());

//string octalNumber = ConvertToOctal(decimalNumber);
//Console.WriteLine($"8-lik sanoq sistemasidagi qiymat: {octalNumber}");


//static string ConvertToOctal(int decimalNumber)
//{
//    string octal = string.Empty;

//    while (decimalNumber > 0)
//    {
//        int remainder = decimalNumber % 8;
//        octal = remainder + octal;
//        decimalNumber /= 8;
//    }

//    return string.IsNullOrEmpty(octal) ? "0" : octal;
//}