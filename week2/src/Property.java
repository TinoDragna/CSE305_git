public class Property {
    String propertyId;
    String decription;
    String propertyOwnerId;

    public Property(String propertyId, String decription, String propertyOwnerId) {
        this.propertyId = propertyId;
        this.decription = decription;
        this.propertyOwnerId = propertyOwnerId;
    }

    public String getPropertyId() {
        return propertyId;
    }

    public void setPropertyId(String propertyId) {
        this.propertyId = propertyId;
    }

    public String getDecription() {
        return decription;
    }

    public void setDecription(String decription) {
        this.decription = decription;
    }

    public String getPropertyOwnerId() {
        return propertyOwnerId;
    }

    public void setPropertyOwnerId(String propertyOwnerId) {
        this.propertyOwnerId = propertyOwnerId;
    }

}
