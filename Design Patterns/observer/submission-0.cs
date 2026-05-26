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
    private List<IObserver> _subscribers;

    public OnlineStoreItem(string itemName, int stock) {
        this.itemName = itemName;
        this.stock = stock;
        _subscribers = new List<IObserver>();
    }

    public void subscribe(IObserver observer) {
        _subscribers.Add(observer);
    }

    public void unsubscribe(IObserver observer) {
        _subscribers.Remove(observer);
    }

    public void updateStock(int newStock) 
    {
        notify(newStock);
        stock = newStock;
    }

    public void notify(int newStock)
    {
        if (!(stock <= 0 && newStock > 0)) return;
        
        foreach (var sub in _subscribers) 
        {
            sub.notify(itemName);
        }
      
    }
}
