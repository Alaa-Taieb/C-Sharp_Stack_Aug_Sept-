
// Private => Is only accessible from the same class.
// Public => Is accessible from anywhere else.
// Protected => Is accessible from the same class and child classes (Classes that inherit from this one)
// Static => means that the field or method is the same across all instances of the class

public class Animal{
    // public static string place = "THERE";
    // Attribute
    private string name;


    // Constructors
    public Animal(string name){
        this.name = name;
    }

    // public string GetName() => name;
    // public void SetName(string value) => name = value;


    public string Name {
        get {
            return name;
        }
        set {
            if (!string.IsNullOrEmpty(value)){
                name = value;
            }else{
                Console.WriteLine("ERROR: VALUE IS EMPTY OR NULL");
            }
        }
    }


}

/*


Object 1 => _name = Rex
Object 2 => _name = Diana

Object 1 => Change place to be "HERE"
Object 2 => place "HERE"

Animal.place

Animal.name

*/