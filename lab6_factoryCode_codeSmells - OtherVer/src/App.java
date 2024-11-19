public class App {
    public static void main(String[] args) {
        // High Priority Request
        RequestCreator highPriorityCreator = new HighPriorityConcreteCreator(
                "high",        // Priority
                "12/10/2025",  // Expire Date
                "on going"     // Status
        );

        System.out.println("----- High Priority Request -----");
        highPriorityCreator.processRequest();

        // Medium Priority Request
        RequestCreator mediumPriorityCreator = new MediumPriorityConcreteCreator(
                "medium",      // Priority
                "12/12/2025",  // Expire Date
                "accepted"     // Status
        );
        System.out.println("\n----- Medium Priority Request -----");
        mediumPriorityCreator.processRequest();

        // Low Priority Request
        RequestCreator lowPriorityCreator = new LowPriorityConcreteCreator(
                "low",         // Priority
                "today",       // Expire Date
                "done"         // Status
        );
        System.out.println("\n----- Low Priority Request -----");
        lowPriorityCreator.processRequest();
    }
}
