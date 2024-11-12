public class Client {
    public void requestCreateRentalcontract(){
        
    }
    public static void main(String[] args) {
        Contract permanentContract = new Permanent()
                .buildContractID(101)
                .buildPropertyID(201)
                .buildTenantID(301)
                .buildRentAmount(1500.0)
                .signContract();
        System.out.println(permanentContract);
    }
}
