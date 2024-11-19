public class HighPriorityConcreteCreator extends RequestCreator {
    private String priority;
    private String expireDay;
    private String status;

    // Constructor to accept custom values
    public HighPriorityConcreteCreator(String priority, String expireDay, String status) {
        this.priority = priority;
        this.expireDay = expireDay;
        this.status = status;
    }

    @Override
    public RequestProduct createRequest() {
        return new HighPriorityConcrete(priority, expireDay, status);
    }
}
