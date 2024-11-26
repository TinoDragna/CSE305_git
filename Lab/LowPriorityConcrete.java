import java.time.LocalDate;

public class LowPriorityConcrete implements RequestProduct {
    private String priority;
    private String expireDay;
    private String status;

    @Override
    public void setPriority(String priority) {
        this.priority = priority;
    }

    @Override
    public void setExpire(String expireDay) {
        this.expireDay = expireDay;
    }

    @Override
    public void setStatus(String status) {
        this.status = status;
    }

    @Override
    public void processRequest() {
        setPriority("Ignore");
        setStatus("Done");
        setExpire(LocalDate.now().toString());
        System.out.println("Request denied");
    }

}
