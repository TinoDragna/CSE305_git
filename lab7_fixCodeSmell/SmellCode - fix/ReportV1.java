import java.util.List;

class Property {
    private String name;
    private double rentAmount;
    private String ownerName; 
    private String location;

    public Property(String name, double rentAmount, String ownerName, String location) { // Constructor with a data clump
        this.name = name;
        this.rentAmount = rentAmount;
        this.ownerName = ownerName;
        this.location = location;
    }

    public String getName() {
        return name;
    }

    public double getRentAmount() {
        return rentAmount;
    }

    public String getOwnerName() {
        return ownerName;
    }

    public String getLocation() {
        return location;
    }

    // fix feature envy, long method, duplicate, (đưa các phương thức cần gọi thuộc tính của property về property - fix feature envy)
    // Single Responsibility Principle (SRP)
    public String getPropertyType() {
        return rentAmount > 2000 ? "This is a premium property." : "This is a standard property.";
    }

    public double getYearlyRent() {
        return rentAmount * 12;
    }

    public void printPropertyDetails() {
        System.out.println("Property: " + name);
        System.out.println("Rent Amount: $" + rentAmount);
        System.out.println("Owner: " + ownerName);
        System.out.println("Location: " + location);
        System.out.println(getPropertyType());
        System.out.println("Yearly Rent: $" + getYearlyRent());
    }
}

class FinancialReport {
    private String reportTitle;
    private List<Property> properties;
    // private double totalRent; -- fix Large Class  (Temporary Field and Long-Lived Variable)

    public FinancialReport(String reportTitle, List<Property> properties) {
        this.reportTitle = reportTitle;
        this.properties = properties;
    }

    public void generateReport() {
        double totalRent = 0; 
        System.out.println("Financial Report: " + reportTitle);
        System.out.println("----------------------------");

        
        for (Property property : properties) {
            property.printPropertyDetails();
            totalRent += property.getRentAmount();
            System.out.println("--------------------");
        }

        System.out.println("Total Rent Amount: $" + totalRent);
    }
}

public class ReportV1 {
    public static void main(String[] args) {
        Property property1 = new Property("Apartment A", 1500.0, "John Doe", "City Center");
        Property property2 = new Property("House B", 2000.0, "Jane Smith", "Suburb");
        Property property3 = new Property("Condo C", 1800.0, "Bob Johnson", "Downtown");

        FinancialReport financialReport = new FinancialReport("Monthly Rent Summary", List.of(property1, property2, property3));
        financialReport.generateReport();

    }
}


