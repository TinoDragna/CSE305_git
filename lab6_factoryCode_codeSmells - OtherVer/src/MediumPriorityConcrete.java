// MediumPriorityConcrete Product
public class MediumPriorityConcrete implements RequestProduct {
    private String priority;
    private String expireDay;
    private String status;

    // Constructor to accept custom values
    public MediumPriorityConcrete(String priority, String expireDay, String status) {
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
        System.out.println("Request accepted, estimated completion date is " + this.expireDay);
    }
}
