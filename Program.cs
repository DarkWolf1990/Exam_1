//1. Задать массив любым способом:
//а) на старте выполнения алгоритма;
// или 
// б) ввести с клавиатуры;
// 2. сформировать массив из строк, чья длина 
//меньше или равна 3 символам;
// *** 
// # Примеры
// ***
// `["hello", "2", "world", ":-)"] ->["2", ":-)"]`
// `["1234", "1567","-2","computer science"] -> ["-2"]`
// `["Russia","Denmark","Kazan"]->[]`





Console.Clear();

string[] outputArray (string[] inputArray)
{
	  int size = 3;
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= size)
        {
            count++;
        }
    }

    string[] outputArray = new string [count];
    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= size)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    return outputArray;
}






string[] inputArray = {"Hello", "2", "world", ":-)"};
PrintArray(inputArray);
PrintArray(outputArray(inputArray)); 
