public class Singleton 
{
    private static Singleton instance {get;set;}

    private string sigValue {get;set;}

    private Singleton() 
    {
      
    }

    public static Singleton getInstance() 
    {
        if (instance == null) 
        {
            instance = new Singleton();
        }

        return instance;
    }

    public string getValue() 
    {
        return sigValue;
    }

    public void setValue(string value)
    {
        sigValue = value;
    }
}
