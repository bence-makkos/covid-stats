using CsvHelper.Configuration.Attributes;
using System;

namespace CovidStats
{
    public class Record
    {
        [Name("date_published")]
        public DateTime DatePublished { get; set; }

        [Name("clinic_state")]
        public string ClinicState { get; set; }

        [Name("test_name")]
        public string TestName { get; set; }

        [Name("swab_type")]
        public string SwabType { get; set; }

        [Name("covid19_test_results")]
        public string Covid19TestResults { get; set; }

        [Name("age")]
        public int Age { get; set; }

        [Name("high_risk_exposure_occupation")]
        public bool? HighRiskExposureOccupation { get; set; }

        [Name("high_risk_interactions")]
        public bool? HighRiskInteractions { get; set; }

        [Name("diabetes")]
        public bool Diabetes { get; set; }

        [Name("chd")]
        public bool Chd { get; set; }

        [Name("htn")]
        public bool Htn { get; set; }

        [Name("cancer")]
        public bool Cancer { get; set; }

        [Name("asthma")]
        public bool Asthma { get; set; }

        [Name("copd")]
        public bool Copd { get; set; }

        [Name("autoimmune_dis")]
        public bool AutoimmuneDis { get; set; }

        [Name("temperature")]
        public double? Temperature { get; set; }

        [Name("pulse")]
        public int? Pulse { get; set; }

        [Name("sys")]
        public int? Sys { get; set; }

        [Name("dia")]
        public int? Dia { get; set; }

        [Name("rr")]
        public int? Rr { get; set; }

        [Name("sats")]
        public int? Sats { get; set; }

        [Name("rapid_flu_results")]
        public string RapidFluResults { get; set; }

        [Name("rapid_strep_results")]
        public string RapidStrepResults { get; set; }

        [Name("days_since_symptom_onset")]
        public int? DaysSinceSymptomOnset { get; set; }

        [Name("ctab")]
        public bool? Ctab { get; set; }

        [Name("labored_respiration")]
        public bool? LaboredRespiration { get; set; }

        [Name("rhonchi")]
        public bool? Rhonchi { get; set; }

        [Name("wheezes")]
        public bool? Wheezes { get; set; }

        [Name("cough")]
        public bool? Cough { get; set; }

        [Name("cough_severity")]
        public string CoughSeverity { get; set; }

        [Name("fever")]
        public bool? Fever { get; set; }

        [Name("sob")]
        public bool? Sob { get; set; }

        [Name("sob_severity")]
        public string SobSeverity { get; set; }

        [Name("diarrhea")]
        public bool? Diarrhea { get; set; }

        [Name("fatigue")]
        public bool? Fatigue { get; set; }

        [Name("headache")]
        public bool? Headache { get; set; }

        [Name("loss_of_smell")]
        public bool? LossOfSmell { get; set; }

        [Name("loss_of_taste")]
        public bool? LossOfTaste { get; set; }

        [Name("runny_nose")]
        public bool? RunnyNose { get; set; }

        [Name("muscle_sore")]
        public bool? MuscleSore { get; set; }

        [Name("sore_throat")]
        public bool? SoreThroat { get; set; }

        [Name("cxr_findings")]
        public string CxrFindings { get; set; }

        [Name("cxr_impression")]
        public string CxrImpression { get; set; }

        [Name("cxr_link")]
        public string CxrLink { get; set; }

        [Name("er_referral")]
        public bool ErReferral { get; set; }

    }
}
