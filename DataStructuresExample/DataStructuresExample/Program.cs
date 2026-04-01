


//Array
//Get Big O(1)
//Add/Remove Big O(n)
//Search Big O(n)




//LinkedList
//Get Big O(n)
//Add/Remove Big O(1)
////Search Big O(n)
///

//Doubled LinkedList


//Queue/Stack
//Get Big O(1)
//Add/Remove Big O(1)

//LIFO
Stack<string> names = new Stack<string>();

names.Push("Nigar");
names.Push("Malik");


Console.WriteLine(names.Pop());

Console.WriteLine("-----------------------");



//FIFO
Queue<string> names2 = new Queue<string>();

names2.Enqueue("Nigar");
names2.Enqueue("Malik");

Console.WriteLine(names2.Dequeue());


// Get Big O(V+E)













int[] arr = { 15, 2, 7, 13};

//{15, 2, 7, 13,70}
//int step = 0;


//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length-1-i; j++)
//    {
//        step++;
//        if (arr[j] > arr[j + 1])
//        {
//            int temp = arr[j];
//            arr[j]=arr[j + 1];
//            arr[j+1]=temp;

//        }
//    }
//}



//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine("Addimlar:"+step);

//int step = 0;
//for(int i = 0; i < arr.Length-1;)
//{
//    step++;
//    if (arr[i] > arr[i + 1])
//    {
//        int temp = arr[i];
//        arr[i]=arr[i + 1];
//        arr[i+1]=temp;

//        i = 0;
//    }
//    else
//    {
//        i++;
//    }
//}


//for(int i = 0;i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Console.WriteLine("Addimlar:"+step);












//int[] nums = { 13, 12, 9, 20, 11 };


//for (int i = 0; i < nums.Length; i++)
//{
//    bool result = false;
//    for (int j = 2; j * j <= nums[i]; j++)
//    {
//        if (nums[i] % j == 0)
//        {
//            result = true;
//            break;
//        }
//    }
//    if (result)
//    {
//        Console.WriteLine("Murekkebdir: " + nums[i]);
//    }
//    else
//    {
//        Console.WriteLine("Sadedir: " + nums[i]);
//    }
//}







//int[] nums = { 13, 12, 9, 20, 11 };


//for (int i = 0; i < nums.Length; i++)
//{

//    for (int j = 2; j * j <= nums[i]; j++)
//    {
//        if (nums[i] % j == 0)
//        {
//            Console.WriteLine("Murekkebdir: " + nums[i]);
//            break;
//        }
//    }
//}















//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = 2; j < nums[i];j++)
//    {
//        if (nums[i] % j == 0)
//        {
//            Console.WriteLine(nums[i]);
//            break;
//        }
//    }
//}



