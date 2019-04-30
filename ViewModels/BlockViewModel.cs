using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.ViewModels
{
    public class BlockViewModel
    {
        [DisplayName("")]
        public string Project_Number { get; set; }
        [DisplayName("")]
        public Nullable<int> Block_Number { get; set; }
        [DisplayName("")]
        public string GIS_Processor { get; set; }
        [DisplayName("")]
        public Nullable<System.DateTime> Processed_By_Date { get; set; }
        [DisplayName("")]
        public string Reviewer { get; set; }
        [DisplayName("")]
        public Nullable<System.DateTime> Review_By_Date { get; set; }
        [DisplayName("")]
        public Nullable<bool> StreetCalcs { get; set; }
        [DisplayName("")]
        public Nullable<bool> ConcreteCalcs { get; set; }
        [DisplayName("")]
        public Nullable<bool> Geometry { get; set; }
        [DisplayName("")]
        public Nullable<bool> MXD_Export { get; set; }
        [DisplayName("")]
        public Nullable<bool> Photoline_MXD_Export { get; set; }
        [DisplayName("")]
        public Nullable<bool> CIC_Summary_Sheet_Export { get; set; }
        [DisplayName("")]
        public Nullable<bool> Streets_Sketchline_Edits { get; set; }
        [DisplayName("")]
        public Nullable<bool> Concrete_Edits { get; set; }
        [DisplayName("")]
        public Nullable<bool> MXD_PDF { get; set; }
        [DisplayName("")]
        public Nullable<bool> Photoline_PDF { get; set; }
        [DisplayName("")]
        public Nullable<bool> Photolog_PDF { get; set; }
        [DisplayName("")]
        public Nullable<bool> FTP_Upload { get; set; }
        [DisplayName("")]
        public Nullable<System.DateTime> Submitted { get; set; }
        [DisplayName("")]
        public Nullable<System.DateTime> Completed { get; set; }
        [DisplayName("")]
        public string Notes { get; set; }
        
        [DisplayName("testYN: ")]
        public string testYN { get; set; }
        //[DisplayName("testYN: ")]
        //public int YN { get; set; }
        //public List<YN> YN { get; set; }
    }
}