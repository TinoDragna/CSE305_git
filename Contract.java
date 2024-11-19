public class Contract {
    int contractID;
    int propertyID;
    int tenantID;
    double rentAmount;
    @Override
    public String toString() {
        return "Contract [contractID=" + contractID + ", propertyID=" + propertyID +
                ", tenantID=" + tenantID + ", rentAmount=" + rentAmount + "]";
    }
    public Contract(int contractID, int propertyID, int tenantID, double rentAmount) {
        this.contractID = contractID;
        this.propertyID = propertyID;
        this.tenantID = tenantID;
        this.rentAmount = rentAmount;
    }

}