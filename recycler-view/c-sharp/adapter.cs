using System;

namespace adapterStructure {
    
    public class ViewHolder {
        var name = HTML.student-name;
        var idNum = HTML.student-idNum;
        var course = HTML.student-course;
    }


    public class Adapter {

            public ViewHolder(View view) {
                Console.WriteLine("Student Name: " + {name} + "\n");
                Console.WriteLine("Student ID: " + {idNum} + "\n");
                Console.WriteLine("Student Course: " + {course} + "\n");
                //returns students
            }
            public void DataBind() {
                
            }
            public DataSize() {
                var dS = new DataSize;
                //creates datasize
                Console.WriteLine({DataSize});
                //returns datasize
            }
        
        }
    }



// CLASS Adapter
//     GET dataset from model

//     FUNCTION create a ViewHolder instance
//         RETURN the ViewHolder instance
//     ENDFUNCTION

//     FUNCTION bind data to ViewHolder instance
//         GET a ViewHolder instance
//         SET data from dataset to appropriate view
//     ENDFUNCTION

//     FUNCTION get dataset size
//         RETURN size of dataset
//     ENDFUNCTION
// ENDCLASS
//From Mr.B