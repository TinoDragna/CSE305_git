// HighPriorityConcrete Product
public class HighPriorityConcrete implements RequestProduct {
    private String priority;
    private String expireDay;
    private String status;

    // Constructor to accept custom values
    public HighPriorityConcrete(String priority, String expireDay, String status) {
        this.priority = priority;
        this.expireDay = expireDay;
        this.status = status;
    }

    @Override
    public void setPriority() {
        System.out.println("Priority: " + this.priority);
    }

    @Override
    public void setExpire() {
        System.out.println("Expire Date: " + this.expireDay);
    }

    @Override
    public void setStatus() {
        System.out.println("Status: " + this.status);
    }

    @Override
    public void processRequest() {
        System.out.println("Emergency request, our Administrator will contact you immediately!");
    }
}
