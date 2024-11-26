public class HighPriorityConcrete implements RequestProduct {
    private String priority;
    private String expireDay;
    private String status;

    @Override
    public void setPriority() {
        this.priority = "High";
    }

    @Override
    public void setExpire() {
        this.expireDay = this.expireDay; // Current day
    }

    @Override
    public void setStatus() {
        this.status = this.status;
    }

    @Override
    public void processRequest() {
        System.out.println("LowPriorityConcrete [priority=" + priority + ", expireDay=" + expireDay + ", status=" + status + "]"); 
    }
}
