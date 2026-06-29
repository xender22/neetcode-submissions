public interface IObserver {
    void notify(string itemName);
}

public class Customer : IObserver {
    private string name;
    private int notifications;

    public Customer(string name) {
        this.name = name;
        this.notifications = 0;
    }

    public string getName() {
        return this.name;
    }

    public void notify(string itemName) {
        this.notifications += 1;
    }

    public int countNotifications() {
        return this.notifications;
    }
}

public class OnlineStoreItem {
    private string itemName;
    private int stock;
    private List<IObserver> customers;

    public OnlineStoreItem(string itemName, int stock) {
        this.itemName = itemName;
        this.stock = stock;
        this.customers = new List<IObserver>();
    }

    public void subscribe(IObserver observer) 
    {
        this.customers.Add(observer);
    }

    public void unsubscribe(IObserver observer) 
    {
        this.customers.Remove(observer);
    }

    public void updateStock(int newStock) 
    {
        if (this.stock <= 0 && newStock > 0)
        {
            foreach (var customer in customers)
                customer.notify(this.itemName);
        }

        this.stock = newStock;
    }
}
