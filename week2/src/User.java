public class User {
    String userId;
    String password;
    String emai;
    String userType;

    public User(String userId, String password, String emai, String userType) {
        this.userId = userId;
        this.password = password;
        this.emai = emai;
        this.userType = userType;
    }

    public String getUserId() {
        return userId;
    }
    public void setUserId(String userId) {
        this.userId = userId;
    }
    public String getPassword() {
        return password;
    }
    public void setPassword(String password) {
        this.password = password;
    }
    public String getEmai() {
        return emai;
    }
    public void setEmai(String emai) {
        this.emai = emai;
    }
    public String getUserType() {
        return userType;
    }
    public void setUserType(String userType) {
        this.userType = userType;
    }

    
}
