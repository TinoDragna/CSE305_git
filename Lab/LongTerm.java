public class LongTerm implements ContractBuilder{
    private int contractID;
    private int propertyID;
    private int tenantID;
    private double rentAmount;

    @Override
    public void buildContractID(int contractID) {
        this.contractID = contractID;
    }

    @Override
    public void buildPropertyID(int propertyID) {
        this.propertyID = propertyID;
    }

    @Override
    public void buildTenantID(int tenantID) {
        this.tenantID = tenantID;
    }

    @Override
    public void buildRentAmount(double rentAmount) {
        this.rentAmount = rentAmount;
    }

    @Override
    public Contract signContract() {
        return new Contract(contractID, propertyID, tenantID, rentAmount);
    }
}
