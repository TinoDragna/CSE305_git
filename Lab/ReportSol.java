import java.util.List;

class PropertyDetails {
    private String name;
    private double rentAmount;
    private String ownerName;
    private String location;

    public PropertyDetails(String name, double rentAmount, String ownerName, String location) {
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
}

class Property {
    private PropertyDetails details;

    public Property(PropertyDetails details) {
        this.details = details;
    }

    public PropertyDetails getDetails() {
        return details;
    }

    public void printPropertyDetails() {
        System.out.printf("Property: %s%nRent Amount: $%.2f%nOwner: %s%nLocation: %s%n",
                details.getName(), details.getRentAmount(), details.getOwnerName(), details.getLocation());
    }
}

class FinancialReport {
    private String reportTitle;
    private List<Property> properties;
    private double totalRent;

    public FinancialReport(String reportTitle, List<Property> properties) {
        this.reportTitle = reportTitle;
        this.properties = properties;
    }

    public void generateReport() {
        totalRent = 0;
        System.out.printf("Financial Report: %s%n----------------------------%n", reportTitle);
        for (Property property : properties) {
            property.printPropertyDetails();
            totalRent += property.getDetails().getRentAmount();
            printPropertyType(property.getDetails().getRentAmount());
            printYearlyRent(property.getDetails().getRentAmount());
            System.out.println("--------------------");
        }
        System.out.printf("Total Rent Amount: $%.2f%n", totalRent);
    }

    private void printPropertyType(double rentAmount) {
        if (rentAmount > 2000) {
            System.out.println("This is a premium property.");
        } else {
            System.out.println("This is a standard property.");
        }
    }

    private void printYearlyRent(double rentAmount) {
        double yearlyRent = rentAmount * 12;
        System.out.printf("Yearly Rent: $%.2f%n", yearlyRent);
    }
}

public class ReportSol {
    public static void main(String[] args) {
        Property property1 = new Property(new PropertyDetails("Apartment A", 1500.0, "John Doe", "City Center"));
        Property property2 = new Property(new PropertyDetails("House B", 2000.0, "Jane Smith", "Suburb"));
        Property property3 = new Property(new PropertyDetails("Condo C", 1800.0, "Bob Johnson", "Downtown"));

        FinancialReport financialReport = new FinancialReport("Monthly Rent Summary",
                List.of(property1, property2, property3));
        financialReport.generateReport();
    }
}
