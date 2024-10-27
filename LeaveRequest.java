import java.util.Date;

public class LeaveRequest {
    private int id;
    private int securityStaffId; // Referencing SecurityStaff
    private Date startDate;
    private Date endDate;
    private String reason;
    private String status; // Pending, Approved, Declined

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getSecurityStaffId() {
        return securityStaffId;
    }

    public void setSecurityStaffId(int securityStaffId) {
        this.securityStaffId = securityStaffId;
    }

    public Date getStartDate() {
        return startDate;
    }

    public void setStartDate(Date startDate) {
        this.startDate = startDate;
    }

    public Date getEndDate() {
        return endDate;
    }

    public void setEndDate(Date endDate) {
        this.endDate = endDate;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }
}
