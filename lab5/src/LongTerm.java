public class LongTerm implements Contract{
    private int contractID;
    private int propertyID;
    private int tenantID;
    private double rentAmount;

    @Override
    public Contract buildContractID(int contractID) {
        this.contractID = contractID;
        return this;
    }

    @Override
    public Contract buildPropertyID(int propertyID) {
        this.propertyID = propertyID;
        return this;
    }

    @Override
    public Contract buildTenantID(int tenantID) {
        this.tenantID = tenantID;
        return this;
    }

    @Override
    public Contract buildRentAmount(double rentAmount) {
        this.rentAmount = rentAmount;
        return this;
    }

    @Override
    public Contract signContract() {
        System.out.println("Long term contract signed with details: " + this);
        return this;
    }

    @Override
    public String toString() {
        return "Long term{contractID=" + contractID + ", propertyID=" + propertyID +
                ", tenantID=" + tenantID + ", rentAmount=" + rentAmount + "}";
    }

}
