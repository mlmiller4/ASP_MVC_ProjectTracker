
namespace ProjectTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CDOT_Tracker_DB : DbContext
    {
        public CDOT_Tracker_DB()
            : base("name=CDOT_Tracker_DB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BLOCKS_FINALCALCS_VW> BLOCKS_FINALCALCS_VW { get; set; }
        public virtual DbSet<Block_Track> Block_Track { get; set; }
        public virtual DbSet<BlockLinkedView1> BlockLinkedView1 { get; set; }
        public virtual DbSet<testDomain> testDomain { get; set; }
    }
}
