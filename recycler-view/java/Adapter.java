import java.util.ArrayList;

public class Adapter {
    
    public String studentName;
    public int studentID;
    ArrayList<String> enrolledCourses = new ArrayList();
    enrolledCourses.add("course");
    Model student3 = new Model("Bob", 11111, enrolledCourses);

    public Adapter(){
        this.studentName = HTML.studentName;
        this.studentID = HTML.studentID;
        this.enrolledCourses = HTML.enrolledCourses;
    }

    public ViewHolder onCreateViewHolder(){
        ViewHolder vh = new ViewHolder();
        return vh;
    }

    public bind(){
        ViewHolder vh = onCreateViewHolder();
        vh.studentName = student3.getStudentName();

    }

}
