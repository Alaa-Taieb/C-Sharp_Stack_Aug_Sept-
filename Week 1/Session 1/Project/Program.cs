// This is a comment


// Primitive Types

// Integers (int)
int myInt = 10;

// Strings (string)
string myString = "Hello, world!";

// Boolean (bool)
bool myBool = true;

Console.WriteLine("Premitive DataTypes: ");
Console.WriteLine("My Int: " + myInt);
Console.WriteLine("My String: " + myString);
Console.WriteLine("My Bool: " + myBool);


// Collections
// Array
int[] myArray = new int[4] {1, 2, 3, 5};

Console.WriteLine("Array: ");
foreach (int item in myArray)
    Console.WriteLine(item);

// List
// Different from Arrays because it'a size can CHANGE!
List<int> myList = new List<int>() {1, 2, 3, 4};

Console.WriteLine("List Before Adding: ");
foreach (int item in myList)
    Console.WriteLine(item);

// Adding values to Lists
myList.Add(5);

Console.WriteLine("List After Adding: ");
foreach (int item in myList)
    Console.WriteLine(item);

// Dictionaries
// It contains key-Value pairs
Dictionary<string , int> myDictionary = new Dictionary<string, int>(){
    {"apple", 1},
    {"banana", 2}
};
Console.WriteLine("Dictionary: ");
foreach (KeyValuePair<string, int> item in myDictionary){
    Console.WriteLine(item.Key + ": " + item.Value);
}
// apple: 1 

// "apple" != 'apple'


// A dictionary called dict_food
// [key , value]
// ['name', 'Beef']
// ['weight', '1 Pound']
// ['calories', '700 Kcal']
// what is the name inside of this dict_food variable
// dict_food['name'] => 'Beef'
// dict_food['weight'] => '1 Pound'

// Functions
static int Sum(int a , int b){
    return a + b;
}

static void PrintSum(int a , int b){
    Console.WriteLine("Sum of 5 and 20: "+ (a + b));
}
int yourInt = Sum(5, 3);
Console.WriteLine("Functions: ");
Console.WriteLine("Sum of 5 and 10: "+ myInt);
// PrintSum(5, 20);

// Conditionals
Console.WriteLine("Conditionals");
if (yourInt > myInt){
    Console.WriteLine("Your int is bigger than mine!");
}else{
    Console.WriteLine("Your int is smaller than mine!");
}

Console.WriteLine("Loops: ");
for (int i = 1; i <= 20; i++){
    Console.WriteLine(i);
}




