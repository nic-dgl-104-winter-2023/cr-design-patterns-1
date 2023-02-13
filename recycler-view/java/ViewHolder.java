import java.io.File;

public class ViewHolder {
    
    String studentName;
    int studentID;
    ArrayList<String> enrolledCourses;

    public viewHolder(){
        this.studentName = HTML.studentName;
        this.studentID = HTML.studentID;
        this.enrolledCourses = HTML.enrolledCourses;
    }
    
    
    
    
    
    /*String reference;

    {
        try {
            File htmlFile = new File("view.html");
            this.reference = htmlFile.toString();
        } catch (Exception e) {
            System.out.println("Something went wrong");
        }*/

    }
}
