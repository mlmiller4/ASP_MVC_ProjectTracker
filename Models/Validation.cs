using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectTracker.Models
{
    [MetadataType(typeof(BlockLinkedView1Validation))]
    public partial class BlockLinkedView1
    {
    }
    
    public partial class BlockLinkedView1Validation
    {
        public string Expr1 { get; set; }
        //public Nullable<int> OBJECTID { get; set; }
        [DisplayName("Street Calcs")]
        public Nullable<bool> StreetCalcs { get; set; }
        [DisplayName("Concrete Calcs")]
        public bool ConcreteCalcs { get; set; }
        public Nullable<bool> Geometry { get; set; }
        [DisplayName("MXD Export")]
        public Nullable<bool> MXD_Export { get; set; }
        [DisplayName("Photoline MXD Export")]
        public Nullable<bool> Photoline_MXD_Export { get; set; }
        [DisplayName("CIC Summary")]
        public Nullable<bool> CIC_Summary_Sheet_Export { get; set; }
        [DisplayName("Streets Sketchline Edits")]
        public Nullable<bool> Streets_Sketchline_Edits { get; set; }
        [DisplayName("Concrete Edits")]
        public Nullable<bool> Concrete_Edits { get; set; }
        [DisplayName("MXD PDF")]
        public Nullable<bool> MXD_PDF { get; set; }
        [DisplayName("Photoline PDF")]
        public Nullable<bool> Photoline_PDF { get; set; }
        [DisplayName("Photolog PDF")]
        public Nullable<bool> Photolog_PDF { get; set; }
        [DisplayName("FTP Upload")]
        public Nullable<bool> FTP_Upload { get; set; }
        public Nullable<System.DateTime> Submitted { get; set; }
        public Nullable<System.DateTime> Completed { get; set; }
        public string PageNo { get; set; }
        public System.Guid GlobalID { get; set; }
        public Nullable<System.DateTime> ReviewByDate { get; set; }
        public string ReviewBy { get; set; }
        public string CalcBy { get; set; }
        public Nullable<System.DateTime> CalcByDate { get; set; }
        public string SurveyBy { get; set; }
        public Nullable<System.DateTime> SurveyByDate { get; set; }
        public string strCCEProjectNumber { get; set; }
        public Nullable<int> BlockNo { get; set; }
        public string Notes { get; set; }
        public string testYN { get; set; }
    }
}