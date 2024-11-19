public class App {
    public static void main(String[] args) {
        // Low Priority Request
        RequestCreator lowPriorityCreator = new LowPriorityConcreteCreator();
        lowPriorityCreator.processRequest();

        // Medium Priority Request
        RequestCreator midPriorityCreator = new MidPriorityConcreteCreator();
        midPriorityCreator.processRequest();

        // High Priority Request
        RequestCreator highPriorityCreator = new HighPriorityConcreteCreator();
        highPriorityCreator.processRequest();
    }
}
