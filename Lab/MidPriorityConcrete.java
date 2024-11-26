import java.time.LocalDate;

public class MidPriorityConcrete implements RequestProduct {
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
        setPriority("Medium"); 
        setStatus("Accepted"); 
        setExpire(LocalDate.now().plusMonths(1).toString()); 
        System.out.println("Request accepted, estimated completion date is " + this.expireDay);
    }

}
