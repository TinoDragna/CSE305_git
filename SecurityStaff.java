import java.util.List;

public class SecurityStaff extends User {
    private int totalLeavesTaken;
    private int remainingLeaves;
    private List<Duty> duties;

    public int getTotalLeavesTaken() {
        return totalLeavesTaken;
    }

    public void setTotalLeavesTaken(int totalLeavesTaken) {
        this.totalLeavesTaken = totalLeavesTaken;
    }

    public int getRemainingLeaves() {
        return remainingLeaves;
    }

    public void setRemainingLeaves(int remainingLeaves) {
        this.remainingLeaves = remainingLeaves;
    }

    public List<Duty> getDuties() {
        return duties;
    }

    public void setDuties(List<Duty> duties) {
        this.duties = duties;
    }
}
