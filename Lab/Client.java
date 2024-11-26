public class Client {
    public static void requestCreateRentalContract(ContractBuilder contract, int contractID, int propertyID, int tenantID, double rentAmount) { 
            contract.buildContractID(contractID); 
            contract.buildPropertyID(propertyID); 
            contract.buildTenantID(tenantID); 
            contract.buildRentAmount(rentAmount); 
            contract.signContract();
        }
        public static void main(String[] args) {
            Permanent permanentContract = new Permanent();
            permanentContract.buildContractID(1);
            permanentContract.buildPropertyID(2);
            permanentContract.buildTenantID(3);
            permanentContract.buildRentAmount(15000);
            System.out.println(permanentContract.signContract());

            LongTerm longTermContract = new LongTerm();
            requestCreateRentalContract(longTermContract, 2, 1, 1, 123456);

            NormalDocument document = new NormalDocument();
            document.saveFile("requestClientA", permanentContract.toString());
            document.buildDocument();

            ConfidentialDocument document2 = new ConfidentialDocument();
            document2.saveFile("requestClientB", longTermContract.toString(), null);
    }
}
