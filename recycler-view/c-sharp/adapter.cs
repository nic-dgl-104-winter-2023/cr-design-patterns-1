using System;

namespace adapterStructure {
    
    class ViewHolder {
        public string name;
        public int idNum;
        public string course;
        
        public ViewHolder() {
            name = HTML.student-name;
            idNum = HTML.student-idNum;
            course = HTML.student-course;
        }

    }


    public class Adapter {
            Student student = new Student();

            public ViewHolder getViewHolder() {
                ViewHolder vh = new viewHolder();

                return vh;
            }


            public void dataBind() {
                ViewHolder vh = getViewHolder();

                vh.name = student.name;
                vh.idNum = student.idNum;
                vh.course = student.course;
            }


            public dataSize() {
                dataSize ds = new DataSize();
                
                return DataSize;
                
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