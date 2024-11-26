// Abstract Creator

public abstract class RequestCreator {
    // Factory Method
    public abstract RequestProduct createRequest();

    public void processRequest() {
        RequestProduct product = createRequest(); // Tạo sản phẩm thông qua Factory Method
        product.setPriority();
        product.setExpire();
        product.setStatus();
        product.processRequest();
    }
    
}

