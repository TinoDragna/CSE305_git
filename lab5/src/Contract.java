public interface  Contract {
    Contract buildContractID(int contractID);
    Contract buildPropertyID(int propertyID);
    Contract buildTenantID(int tenantID);
    Contract buildRentAmount(double rentAmount);
    Contract signContract();
}
