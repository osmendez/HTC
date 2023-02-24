using System.Drawing;
using System.Reflection;
using System.Xml.Linq;
using System;

namespace HTC.Models
{
    public class HCTOrders
    {
        public string Schedule { get; set; }
        public string RevisedDate { get; set; }
        public string Reason { get; set; }
        public string MRN { get; set; }
        public string Active { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Heightcm { get; set; }
        public string Weightkg { get; set; }
        public string HeightandWeightComment { get; set; }
        public string ADJBWType { get; set; }
        public string Regimen { get; set; }
        public string IRBNumber { get; set; }
        public string StartDate { get; set; }
        public string TransplantPhysician { get; set; }
        public string NurseCoordinator { get; set; }
        public string MUDNurseCoordinator { get; set; }
        public string CMV { get; set; }
        public string NMDP { get; set; }
        public string ABO { get; set; }
        public string HLA_A_1 { get; set; }
        public string HLA_A_2 { get; set; }
        public string HLA_B_1 { get; set; }
        public string HLA_B_2 { get; set; }
        public string HLA_C_1 { get; set; }
        public string HLA_C_2 { get; set; }
        public string HLA_DRB1_1 { get; set; }
        public string HLA_DRB1_2 { get; set; }
        public string HLA_DQB1_1 { get; set; }
        public string HLA_DQB1_2 { get; set; }
        public string HLA_DPB1_1 { get; set; }
        public string HLA_DPB1_2 { get; set; }
        public string DiagnosisAcuteLymphocyticLeukemia { get; set; }
        public string DiagnosisAcuteMyelogenousLeukemia { get; set; }
        public string DiagnosisChronicLymphocyticLeukemia { get; set; }
        public string DiagnosisChronicMyelogenousLeukemia { get; set; }
        public string DiagnosisGermCell { get; set; }
        public string DiagnosisHodgkinDisease { get; set; }
        public string DiagnosisMyelodysplasticSyndrome { get; set; }
        public string DiagnosisMultipleMyeloma { get; set; }
        public string DiagnosisNon_HodgkinLymphoma { get; set; }
        public string DiagnosisOther { get; set; }
        public string ReferringMD { get; set; }
        public string DonorType { get; set; }
        public string DonorMRN_NMDP_URDCordNum { get; set; }
        public string DonorCORDAKANum { get; set; }
        public string DonorName { get; set; }
        public string DonorABO { get; set; }
        public string DonorCMV { get; set; }
        public string DonorDateOfBirth { get; set; }
        public string DonorGender { get; set; }
        public string DonorTNC { get; set; }
        public string DonorHLA_A_1 { get; set; }
        public string DonorHLA_A_2 { get; set; }
        public string DonorHLA_B_1 { get; set; }
        public string DonorHLA_B_2 { get; set; }
        public string DonorHLA_C_1 { get; set; }
        public string DonorHLA_C_2 { get; set; }
        public string DonorHLA_DRB1_1 { get; set; }
        public string DonorHLA_DRB1_2 { get; set; }
        public string DonorHLA_DQB1_1 { get; set; }
        public string DonorHLA_DQB1_2 { get; set; }
        public string DonorHLA_DPB1_1 { get; set; }
        public string DonorHLA_DPB1_2 { get; set; }
        public string Donor2URDCordNumber { get; set; }
        public string Donor2CORDAKANumber { get; set; }
        public string Donor2ABO { get; set; }
        public string Donor2CMV { get; set; }
        public string Donor2DateOfBirth { get; set; }
        public string Donor2Gender { get; set; }
        public string Donor2TNC { get; set; }
        public string Donor2HLA_A_1 { get; set; }
        public string Donor2HLA_A_2 { get; set; }
        public string Donor2HLA_B_1 { get; set; }
        public string Donor2HLA_B_2 { get; set; }
        public string Donor2HLA_C_1 { get; set; }
        public string Donor2HLA_C_2 { get; set; }
        public string Donor2HLA_DRB1_1 { get; set; }
        public string Donor2HLA_DRB1_2 { get; set; }
        public string Donor2HLA_DQB1_1 { get; set; }
        public string Donor2HLA_DQB1_2 { get; set; }
        public string Donor2HLA_DPB1_1 { get; set; }
        public string Donor2HLA_DPB1_2 { get; set; }
        public string Comments { get; set; }
        public string AssignedTo { get; set; }
        public string StartYear { get; set; }
    }
}
