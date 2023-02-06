import java.util.ArrayList;

public class Model {
    
    String studentName;
    int studentID;
    ArrayList<String> enrolledCourses;

    public Model(){
        this.studentName = "unknown";
        this.studentID = 0;
        this.enrolledCourses = new ArrayList<>();
    }

    public Model(String studentName, int studentID, ArrayList<String> enrolledCourses){
        this.studentName = studentName;
        this.studentID = studentID;
        this.enrolledCourses = enrolledCourses;
    }

    public String getStudentName(){
        return this.studentName;
    }

    public int getStudentID(){
        return this.studentID;
    }

    public ArrayList<String> getEnrolledCourses(){
        return this.enrolledCourses;
    }

}
