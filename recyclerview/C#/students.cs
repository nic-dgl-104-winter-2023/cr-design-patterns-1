using system;

namespace students {
    
    public static class Student {
        public string name {get; set;};
        public int idNum {get; set;};
        public string course {get; set;};

        public student (string name, int idNum, string course)
    }

    static void Main (string[] args) {
        Student stud1 = new Student();
            stud1.name = "Brandon";
            stud1.idNum = 01023;
            stud1.course = "Android App Development";

        Student stud2 = new Student();
            stud1.name = "Jacob";
            stud1.idNum = 01098;
            stud1.course = "Android App Development";


        Student stud3 = new Student();
            stud1.name = "Brandon";
            stud1.idNum = 01076;
            stud1.course = "Android App Development";


        Console.WriteLine(stud1.name + " " + stud1.idNum + " " + stud1.course);
    }

}

//all based on https://dotnettutorials.net/lesson/adapter-design-pattern/ 