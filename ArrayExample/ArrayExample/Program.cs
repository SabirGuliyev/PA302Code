

//int[] nums = { 1, 5, 6, 7, 10, 20, 40, 60, 70,300 };

//int step = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//    step++;
//}


//Console.WriteLine("-------------------------");
//Console.WriteLine("Addimlarin sayi:" +step);



int num = 100;

int step= 0;    

for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        step++;
    }
}

Console.WriteLine(step);







//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("1ci dovr ishe dushdu");
//    for (int j = 0; j < 10; j++)
//	{
//        Console.WriteLine("2-ci dovr");
//    }
//}


















//                    1        2        3         4           5           6
//string[] names = { "Fardi", "Tunar", "Yusif", "Artogrul", "Mahammadali", "Nigar" };
//////////////////////0        1        2         3           4          5

//1ci for Fardi
//2ci for F,a,r,d,i

//for(int i=0;i<names.Length; i++)
//{
//	for (int j = 0; j < names[i].Length; j++)
//	{

//		if (names[i][j] == 'r')
//		{
//			Console.WriteLine(names[i]);
//			break;
//        }
//	}
//}


//for (int i = 0; i < names.Length; i++)
//{
//    //names[i] += " PA302";
//    Console.WriteLine(names[i]);
//}

//names[0] = "Shirin";

//Console.WriteLine(names[]);

//Console.WriteLine(names[names.Length - 1]);


//Console.WriteLine(names.Length);



//int[] nums = { 1, 2, 5, 9, 12, 33 };

//for(int i=0; i<nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}


//string name = "Sabir";

//bool result = false;

//for(int i=0;i<name.Length; i++)
//{
//    if (name[i] == 'a')
//    {
//        result = true;

//        break;
//    }

//}

//if (result)
//{
//    Console.WriteLine("A herfi  var");
//}
//else
//{
//    Console.WriteLine("Yoxdur");
//}



//MultiDimensional Array
//int[] nums = { 1, 2, 9, 12, 33 };

//int[,] cinema =
//{
//    {1,2 },

//    {4,5 },

//    {8,9 }
//};
//Console.WriteLine(cinema.Rank);
//Console.WriteLine(cinema[2,0]);


//Jagged
//int[][] test = new int[][]
//{
//    new int[]{ 1,2},
//    new int[]{ 1,2,3},
//    new int[]{ 3},

//};