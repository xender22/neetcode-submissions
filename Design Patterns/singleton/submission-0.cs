public class Singleton {

    private static Singleton singleton = null;
    private string text = null;

    private Singleton() {
      
    }

    public static Singleton getInstance() {
        if (singleton == null)
            singleton = new Singleton();

        return singleton;
    }

    public string getValue() {
        return text;
    }

    public void setValue(string value){
        text = value;
    }
}
