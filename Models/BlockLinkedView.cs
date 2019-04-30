

namespace ProjectTracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlockLinkedView
    {
        public string strCCEProjectNumber { get; set; }
        public Nullable<int> Block_Number { get; set; }
        public string GIS_Processor { get; set; }
        public Nullable<System.DateTime> Processed_By_Date { get; set; }
        public string Reviewer { get; set; }
        public Nullable<System.DateTime> Review_By_Date { get; set; }
        public Nullable<bool> StreetCalcs { get; set; }


        public bool ConcreteCalcs { get; set; }
        public Nullable<bool> Geometry { get; set; }
        public Nullable<bool> MXD_Export { get; set; }
        public Nullable<bool> Photoline_MXD_Export { get; set; }
        public Nullable<bool> CIC_Summary_Sheet_Export { get; set; }
        public Nullable<bool> Streets_Sketchline_Edits { get; set; }
        public Nullable<bool> Concrete_Edits { get; set; }
        public Nullable<bool> MXD_PDF { get; set; }
        public Nullable<bool> Photoline_PDF { get; set; }
        public Nullable<bool> Photolog_PDF { get; set; }
        public Nullable<bool> FTP_Upload { get; set; }
        public Nullable<System.DateTime> Submitted { get; set; }
        public Nullable<System.DateTime> Completed { get; set; }
        public string PageNo { get; set; }
        public string Notes { get; set; }
        public string testYN { get; set; }
    }
}
