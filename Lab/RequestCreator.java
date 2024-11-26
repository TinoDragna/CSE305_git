public abstract class RequestCreator {
    public abstract RequestProduct createRequest();

    public void processRequest() {
        RequestProduct request = createRequest();
        request.processRequest();
    }
}
