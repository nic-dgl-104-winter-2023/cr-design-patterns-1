import java.io.File;

public class ViewHolder {

    String reference;

    {
        try {
            File htmlFile = new File("view.html");
            this.reference = htmlFile.toString();
        } catch (Exception e) {
            System.out.println("Something went wrong");
        }

    }
}
