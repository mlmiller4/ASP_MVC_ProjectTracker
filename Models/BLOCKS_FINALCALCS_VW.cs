
namespace ProjectTracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BLOCKS_FINALCALCS_VW
    {
        public Nullable<int> OBJECTID { get; set; }
        public Nullable<int> lngProjectID { get; set; }
        public Nullable<int> BlockNo { get; set; }
        public string strCCEProjectNumber { get; set; }
        public string SurveyBy { get; set; }
        public Nullable<System.DateTime> SurveyByDate { get; set; }
        public string CalcBy { get; set; }
        public Nullable<System.DateTime> CalcByDate { get; set; }
        public string strReportLocation { get; set; }
        public string strReportFrom { get; set; }
        public string strReportTo { get; set; }
        public Nullable<int> lngMenuID { get; set; }
        public Nullable<int> lngWardID { get; set; }
        public Nullable<int> ASResurfSY { get; set; }
        public Nullable<int> ASResurfTons { get; set; }
        public Nullable<int> ASGrindingTons { get; set; }
        public Nullable<int> ASPvMark4inLF { get; set; }
        public Nullable<int> ASPvMark6inLF { get; set; }
        public Nullable<int> ASPvMark12inLF { get; set; }
        public Nullable<int> ASPvMark24inLF { get; set; }
        public Nullable<int> ASPvMarkLandSF { get; set; }
        public Nullable<int> RSCurbGutT3LF { get; set; }
        public Nullable<int> RSCurbGutRampT3LF { get; set; }
        public Nullable<int> RSVertCurbGutT4 { get; set; }
        public Nullable<int> RSVertCurbRampT4 { get; set; }
        public Nullable<int> RS5inPCCSidewalkSF { get; set; }
        public Nullable<int> RS5inPCCSidewalkRampSF { get; set; }
        public Nullable<int> RS5inPCCSidewalkRampNum { get; set; }
        public Nullable<int> RS8inPCCSidewalkSF { get; set; }
        public Nullable<int> RS8inPCCSidewalkRampSF { get; set; }
        public Nullable<int> RS7ftPCCBaseCourseSY { get; set; }
        public Nullable<int> RS7ftPCCATOTons { get; set; }
        public Nullable<int> RSSawCutLF { get; set; }
        public Nullable<int> RSDrivewayAlleyATOTons { get; set; }
        public Nullable<int> RSDrivewayAlleyConcreteSY { get; set; }
        public Nullable<int> RSTopsoilCY { get; set; }
        public Nullable<int> RSHydroseedSY { get; set; }
        public string StrMenuName { get; set; }
        public string PageNo { get; set; }
        public Nullable<int> PaintedCurbLF { get; set; }
        public Nullable<int> RSDrivewayAlleyAsphalt { get; set; }
        public Nullable<int> RSDrivewayAlleyAsph { get; set; }
        public Nullable<decimal> Rotation { get; set; }
        public string strMenu { get; set; }
        public Nullable<int> RSBAckside { get; set; }
        public Nullable<int> AAPDSArea { get; set; }
        public Nullable<int> AAIHCArea { get; set; }
        public Nullable<int> AASpeedHumpCnt { get; set; }
        public Nullable<int> AAPDSPaving { get; set; }
        public Nullable<int> AAIHCGrindings { get; set; }
        public Nullable<int> AAIHCPaving { get; set; }
        public string strBlockLocation { get; set; }
        public string strBlockTo { get; set; }
        public string strBlockCornerHouse { get; set; }
        public string strBlockFrom { get; set; }
        public Nullable<int> CICEarthExec_CoreCY { get; set; }
        public Nullable<int> CICPaveRemove_CoreSY { get; set; }
        public Nullable<int> CICDrvAlleyPaveRemove_CoreSY { get; set; }
        public Nullable<int> CICT4CurbRemove_CoreFT { get; set; }
        public Nullable<int> CICCurbGutRemove_CoreFT { get; set; }
        public Nullable<int> CICSidewalkRemove_CoreSF { get; set; }
        public Nullable<int> CICPCCSW5inGreater1800_CoreSF { get; set; }
        public Nullable<int> CICSubGranMatTypeB_CoreCY { get; set; }
        public Nullable<int> CICPCCBaseCourse10in_CoreSY { get; set; }
        public Nullable<int> CICPCCBaseCourse12in_CoreSY { get; set; }
        public Nullable<int> CICAlleyHESPCC8in_CoreSY { get; set; }
        public Nullable<int> CICDriveHESPCC8in_CoreSY { get; set; }
        public Nullable<int> CICSidewalkHESPCC8in_CoreSY { get; set; }
        public Nullable<int> CICPCCSW5inLess1800_CoreSF { get; set; }
        public Nullable<int> CICBitumMatPrimeCoat_CoreGAL { get; set; }
        public Nullable<int> CICCurbGutLess300_CoreLFT { get; set; }
        public Nullable<int> CICCurbGutGreater300_CoreLFT { get; set; }
        public Nullable<int> CICDrillGroutTieBars_CoreEA { get; set; }
        public Nullable<int> CICVertCurbT4_CoreLFT { get; set; }
        public Nullable<int> CICCurbGutT3_CoreLFT { get; set; }
        public Nullable<int> CICDrainUtilityAdj_CoreEA { get; set; }
        public Nullable<int> CICWaterShutRem_CoreEA { get; set; }
        public Nullable<int> CICCatchBasinMHEtc_CoreEA { get; set; }
        public Nullable<int> CICTreeProtection_CoreEA { get; set; }
        public Nullable<int> CICPulvTopsoilMix_CoreCY { get; set; }
        public Nullable<int> CICRootPruning_CoreEA { get; set; }
        public Nullable<int> CICShredHardwoodBark_CoreCY { get; set; }
        public Nullable<int> CICHydraulicSeed_CoreSY { get; set; }
        public Nullable<int> CICCrushedStone_CoreTON { get; set; }
        public Nullable<int> CICEarthExec_ADA_CY { get; set; }
        public Nullable<int> CICT4CurbRemove_ADA_FT { get; set; }
        public Nullable<int> CICCurbGutRemove_ADA_FT { get; set; }
        public Nullable<int> CICSidewalkRemove_ADA_SF { get; set; }
        public Nullable<int> CICSubGranMatTypeB_ADA_CY { get; set; }
        public Nullable<int> CICPCCBaseCourse7in_ADA_SY { get; set; }
        public Nullable<int> CICPCCBaseCourse9in_ADA_SY { get; set; }
        public Nullable<int> CICPCCADACurbRamp5in_ADA_SF { get; set; }
        public Nullable<int> CICPCCADACurbRamp8in_ADA_SF { get; set; }
        public Nullable<int> CICLinearDetWarnTiles_ADA_SF { get; set; }
        public Nullable<int> CICBitumMatPrimeCoat_ADA_GAL { get; set; }
        public Nullable<int> CICCurbGutLess300_ADA_FT { get; set; }
        public Nullable<int> CICCurbGutGreater300_ADA_FT { get; set; }
        public Nullable<int> CICProtConcSealer_CoreLFT { get; set; }
        public Nullable<int> CICVertCurbT4_ADA_FT { get; set; }
        public Nullable<int> CICThermoPave6in_CoreLFT { get; set; }
        public Nullable<int> CICThermoPave24in_CoreLFT { get; set; }
        public Nullable<int> CICPaveMarkRemove_CoreSF { get; set; }
        public string AACompDirtYN { get; set; }
        public string AACompConcreteYN { get; set; }
        public string AACompCobblestoneYN { get; set; }
        public string AACompCasphaultYN { get; set; }
        public string temp_ { get; set; }
        public string type { get; set; }
        public Nullable<int> RS8inPCCSidewalkRampNum { get; set; }
        public Nullable<int> CICThermoPave4in_CoreLFT { get; set; }
        public Nullable<int> CICHMAN30Type1_CoreSY { get; set; }
        public Nullable<int> CICHMAN30Type2_CoreSY { get; set; }
        public Nullable<int> CICHMAN70Type1_CoreSY { get; set; }
        public Nullable<int> CICHMAN70Type2_CoreSY { get; set; }
        public Nullable<int> CICHMAN30Type1_ADA_SY { get; set; }
        public Nullable<int> CICHMAN30Type2_ADA_SY { get; set; }
        public Nullable<int> CICHMAN70Type1_ADA_SY { get; set; }
        public Nullable<int> CICHMAN70Type2_ADA_SY { get; set; }
        public Nullable<int> CICDrillGroutTieBars_ADA_EA { get; set; }
        public string ReviewBy { get; set; }
        public Nullable<System.DateTime> ReviewByDate { get; set; }
        public System.Data.Entity.Spatial.DbGeometry SHAPE { get; set; }
        public string created_user { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string last_edited_user { get; set; }
        public Nullable<System.DateTime> last_edited_date { get; set; }
        public System.Guid GlobalID { get; set; }
        public Nullable<long> SDE_STATE_ID { get; set; }
        public string strCDOTProjectNumber { get; set; }
        public Nullable<int> RSRampTotalNum { get; set; }
        public Nullable<int> RSBusPadSY { get; set; }
        public Nullable<int> RSConcPaveSY { get; set; }
        public Nullable<int> RSSpeedHumpNum { get; set; }
        public string ProjectType { get; set; }
        public string Comments { get; set; }
        public string AACompOther { get; set; }
        public string AACompOtherYN { get; set; }
        public Nullable<int> CICHMASurfRemVD_CoreSY { get; set; }
        public Nullable<int> CICHMASurfRemVD_ADASY { get; set; }
        public Nullable<int> CICHMAN30HM_CoreTON { get; set; }
        public Nullable<int> CICHMAN70HM_CoreTON { get; set; }
        public Nullable<int> CICHMAN30HM_ADATON { get; set; }
        public Nullable<int> CICHMAN70HM_ADATON { get; set; }
    }
}
