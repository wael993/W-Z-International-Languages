//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W_Z_International_Languages
{
    using System;
    using System.Collections.Generic;
    
    public partial class course_student
    {
        public int course_student_id { get; set; }
        public System.DateTime course_student_datum { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> courseID { get; set; }
    
        public virtual course course { get; set; }
        public virtual student student { get; set; }
    }
}
