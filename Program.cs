Console.Clear();

string[] AppendStringArray(string[] array, string item){
    if (array == null) {
        return new string[] { item };
    }
    string[] result = new string[array.Length + 1];
    array.CopyTo(result, 0);
    result[array.Length] = item;
    return result;
}

string[] GetSmallElementsFromArray(string[] array){
    string[] result = new string[0];
    for(int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            result = AppendStringArray(result, array[i]);
        }
    }
    return result;
}

void PrintArray(string[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}

string[] array = { "one", "two", "three", "four", "9-4", "six", "seven", "8", "nine", "ten" };
PrintArray(GetSmallElementsFromArray(array));