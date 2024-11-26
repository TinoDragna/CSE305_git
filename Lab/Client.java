public class Client {
    public static void requestCreateRentalContract(ContractBuilder contract) { 
            contract.buildContractID(2); 
            contract.buildPropertyID(1); 
            contract.buildTenantID(1); 
            contract.buildRentAmount(12546); 
            System.out.println(contract.signContract());
        }
        public static void main(String[] args) {
            Permanent permanentContract = new Permanent();
            permanentContract.buildContractID(1);
            permanentContract.buildPropertyID(2);
            permanentContract.buildTenantID(3);
            permanentContract.buildRentAmount(15000);
            System.out.println(permanentContract.signContract());

            LongTerm longTermContract = new LongTerm();
            requestCreateRentalContract(longTermContract);

            NormalDocument document = new NormalDocument();
            document.buildDocument().saveFile("requestClientA", "normal content");
    }
}
