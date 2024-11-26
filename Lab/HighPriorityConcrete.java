import java.time.LocalDate;

public class HighPriorityConcrete implements RequestProduct{
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
        setPriority("Emergency"); 
        setStatus("Accepted"); 
        setExpire(LocalDate.now().toString()); 
        System.out.println("Emergency request, our Administer will contact you immediately!");
    }
}
