public interface ContractBuilder {
    void buildContractID(int contractID);
    void buildPropertyID(int propertyID);
    void buildTenantID(int tenantID);
    void buildRentAmount(double rentAmount);
    Contract signContract();
}
