// See https://aka.ms/new-console-template for more information

//int[] myFirstArray = new int[7];

//myFirstArray[0] = 34;
//myFirstArray[1] = -233;
//myFirstArray[2] = 9801;
//myFirstArray[3] = 67;
//myFirstArray[4] = 2;
//myFirstArray[5] = -9582;
//myFirstArray[6] = 770;

int[] myFirstArray = new int[] { 34, -233, 9801, 67, 2, -9582, 770 };

myFirstArray[5] = 1000;

myFirstArray[1] = myFirstArray[0] + 2;
myFirstArray[6]++;

//Console.WriteLine(myFirstArray[0]);

for (int i = 0; i < myFirstArray.Length; i++)
{
    Console.WriteLine($"Plads {i} : {myFirstArray[i]}");
}

//Console.WriteLine("Foreach loop");
//foreach(int y in myFirstArray)
//{
//    Console.WriteLine(y);

//}

for (int i = myFirstArray.Length -1 ; i>=0; i--)
{
    Console.WriteLine($"Plads {i} : {myFirstArray[i]}");

}


