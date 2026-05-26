public class Person {
    private string lastName;
    private int age;
    private bool married;

    public Person(string lastName, int age, bool married) {
        this.lastName = lastName;
        this.age = age;
        this.married = married;
    }

    public string getLastName() {
        return lastName;
    }

    public int getAge() {
        return age;
    }

    public bool isMarried() {
        return married;
    }
}

public interface IPersonFilter {
    bool apply(Person person);
}

public class AdultFilter : IPersonFilter {
    public bool apply(Person person) 
    {
        var age = person.getAge();
        if (age >= 18)
            return true;
        return false; 
    }
}

public class SeniorFilter : IPersonFilter {
    public bool apply(Person person) 
    {
        var age = person.getAge();
        if (age >= 65)
            return true;
        return false; 
    }
}

public class MarriedFilter : IPersonFilter {
    public bool apply(Person person) 
    {
        var isMarried = person.isMarried();
        if (isMarried)
            return true;
        return false;
    }
}

public class PeopleCounter {
    private IPersonFilter filter;

    public void setFilter(IPersonFilter filter) {
        this.filter = filter;
    }

    public int count(List<Person> people)
    {
        int counter = 0;
        foreach (var person in people) 
        {
            if (filter.apply(person))
                counter++;
        }

        return counter;
    }
}
