import java.util.ArrayList;
import java.util.List;

public class Routine {
    private int id;
    private List<Duty> duties;

    public Routine() {
        duties = new ArrayList<>();
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public List<Duty> getDuties() {
        return duties;
    }

    public void addDuty(Duty duty) {
        duties.add(duty);
    }

    public void removeDuty(Duty duty) {
        duties.remove(duty);
    }
}
