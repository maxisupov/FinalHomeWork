string[] array = AskArray();
string[] newArray = ReadyArray(array, 3);
Console.WriteLine();
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"Массив с элементами менее трех символов: [{string.Join(", ", newArray)}]");



string[] AskArray() {
    Console.Write("Введите все элементы массива через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CountCheck(string[] arr, int n) {
    int count = 0;

    for(int i = 0; i < arr.Length; i++) {
        if(arr[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] ReadyArray(string[] arr, int n) {
    string[] readyArr = new string[CountCheck(arr, n)];

    for(int i = 0, j = 0; i < arr.Length; i++) {
        if(arr[i].Length <= n) {
            readyArr[j] = arr[i];
            j++;
        }
    }

    return readyArr;
}


