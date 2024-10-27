import java.util.List;

public class Manager extends User {
    public void approveLeave(LeaveRequest leaveRequest) {
        leaveRequest.setStatus("Approved");
        // Additional logic for approval
    }

    public void declineLeave(LeaveRequest leaveRequest) {
        leaveRequest.setStatus("Declined");
        // Additional logic for decline
    }

    public void createDutySchedule(List<Duty> duties) {
        // Logic to create duty schedule
    }
}
