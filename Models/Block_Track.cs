
namespace ProjectTracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Block_Track
    {
        public int OBJECTID { get; set; }
        public string PageNo { get; set; }
        public bool StreetCalcs { get; set; }
        public bool ConcreteCalcs { get; set; }
        public bool Geometry { get; set; }
        public bool MXD_Export { get; set; }
        public bool Photoline_MXD_Export { get; set; }
        public bool CIC_Summary_Sheet_Export { get; set; }
        public bool Streets_Sketchline_Edits { get; set; }
        public bool Concrete_Edits { get; set; }
        public bool MXD_PDF { get; set; }
        public bool Photoline_PDF { get; set; }
        public bool Photolog_PDF { get; set; }
        public bool FTP_Upload { get; set; }
        public Nullable<System.DateTime> Submitted { get; set; }
        public Nullable<System.DateTime> Completed { get; set; }
        public Nullable<int> testCalc { get; set; }
        public string Notes { get; set; }
        public string testYN { get; set; }
    }
}
