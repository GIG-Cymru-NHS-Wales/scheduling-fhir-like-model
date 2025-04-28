using MediatR;
using Microsoft.VisualBasic;
using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using NhsWales.CommunityCommon.Domain.Types.Pharmacy;
using System.Buffers.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<int>))]
[TypeConverter(typeof(LookupTypeConverter<int, ServiceTypeEnum>))]
public record ServiceTypeEnum : Lookup<int>
{
    public ServiceTypeEnum(int id, string code, string name) : base(id, code, name) { }

    public static readonly ServiceTypeEnum AdoptionPermanentCareInfoSupport = new(1, "adoptionPermanentCareInfoSupport", "Adoption & permanent care information/support");

public static readonly ServiceTypeEnum AgedCareAssessment = new(2, "agedCareAssessment", "Aged care assessment");

public static readonly ServiceTypeEnum AgedCareInformationReferral = new(3, "agedCareInformationReferral", "Aged Care information/referral");

public static readonly ServiceTypeEnum AgedResidentialCare = new(4, "agedResidentialCare", "Aged Residential Care");

public static readonly ServiceTypeEnum CaseManagementforOlderPersons = new(5, "caseManagementforOlderPersons", "Case management for older persons");

public static readonly ServiceTypeEnum DeliveredMeals = new (6, "deliveredMeals", "Delivered meals(meals on wheels)");

public static readonly ServiceTypeEnum FriendlyVisiting = new(7, "friendlyVisiting", "Friendly visiting");

public static readonly ServiceTypeEnum HomeCareHousekeepingAssistance = new(8, "homeCareHousekeepingAssistance", "Home care/housekeeping assistance");

public static readonly ServiceTypeEnum HomeMaintenanceandRepair = new(9, "homeMaintenanceandRepair", "Home maintenance and repair");

public static readonly ServiceTypeEnum PersonalAlarmsAlerts = new(10, "personalAlarmsAlerts", "Personal alarms/alerts");

public static readonly ServiceTypeEnum PersonalCareforOlderPersons = new(11, "personalCareforOlderPersons", "Personal care for older persons");

public static readonly ServiceTypeEnum PlannedActivityGroups = new(12, "plannedActivityGroups", "Planned activity groups");

public static readonly ServiceTypeEnum Acupuncture = new(13, "acupuncture", "Acupuncture");

public static readonly ServiceTypeEnum AlexanderTechniqueTherapy = new(14, "alexanderTechniqueTherapy", "Alexander technique therapy");

public static readonly ServiceTypeEnum Aromatherapy = new(15, "aromatherapy", "Aromatherapy");

public static readonly ServiceTypeEnum BiorhythmServices = new(16, "biorhythmServices", "Biorhythm services");

public static readonly ServiceTypeEnum BowenTherapy = new(17, "bowenTherapy", "Bowen therapy");

public static readonly ServiceTypeEnum ChineseHerbalMedicine = new(18, "chineseHerbalMedicine", "Chinese herbal medicine");

public static readonly ServiceTypeEnum Feldenkrais = new(19, "feldenkrais", "Feldenkrais");

public static readonly ServiceTypeEnum Homoeopathy = new(20, "homoeopathy", "Homoeopathy");

public static readonly ServiceTypeEnum Hydrotherapy = new(21, "hydrotherapy", "Hydrotherapy");


public static readonly ServiceTypeEnum Kinesiology = new(23, "kinesiology", "Kinesiology");

public static readonly ServiceTypeEnum MagneticTherapy = new(24, "magneticTherapy", "Magnetic therapy");

public static readonly ServiceTypeEnum MassageTherapy = new(25, "massageTherapy", "Massage therapy");

public static readonly ServiceTypeEnum Meditation = new(26, "meditation", "Meditation");

public static readonly ServiceTypeEnum Myotherapy = new(27, "myotherapy", "Myotherapy");

public static readonly ServiceTypeEnum Naturopathy = new(28, "naturopathy", "Naturopathy");

public static readonly ServiceTypeEnum Reflexology = new(29, "reflexology", "Reflexology");

public static readonly ServiceTypeEnum Reiki = new(30, "reiki", "Reiki");

public static readonly ServiceTypeEnum RelaxationTherapy = new(31, "relaxationTherapy", "Relaxation therapy");

public static readonly ServiceTypeEnum Shiatsu = new(32, "shiatsu", "Shiatsu");

public static readonly ServiceTypeEnum WesternHerbalMedicine = new(33, "WesternHerbalMedicine", "Western herbal medicine");

public static readonly ServiceTypeEnum FamilyDaycare = new(34, "FamilyDaycare", "Family day care");

public static readonly ServiceTypeEnum HolidayPrograms = new(35, "HolidayPrograms", "Holiday programs");

public static readonly ServiceTypeEnum KindergartenInclusionSupport = new(36, "KindergartenInclusionSupport", "Kindergarten inclusion support for children with a disability");

public static readonly ServiceTypeEnum KindergartenPreschool = new(37, "KindergartenPreschool", "Kindergarten/preschool");

public static readonly ServiceTypeEnum LongDayChildCare = new(38, "LongDayChildCare", "Long day child care");

public static readonly ServiceTypeEnum OccasionalChildCare = new(39, "OccasionalChildCare", "Occasional child care");

public static readonly ServiceTypeEnum OutsideSchoolHoursCare = new(40, "OutsideSchoolHoursCare", "Outside school hours care");

public static readonly ServiceTypeEnum ChildrensPlayPrograms = new(41, "ChildrensPlayPrograms", "Children's play programs");

public static readonly ServiceTypeEnum ParentingFamilySupportEducation = new(42, "ParentingFamilySupportEducation", "Parenting & family management support/education");

public static readonly ServiceTypeEnum Playgroup = new(43, "Playgroup", "Playgroup");

public static readonly ServiceTypeEnum SchoolNursing = new(44, "SchoolNursing", "School nursing");

public static readonly ServiceTypeEnum ToyLibrary = new(45, "ToyLibrary", "Toy library");

public static readonly ServiceTypeEnum ChildProtectionChildAbuseReport = new(46, "ChildProtectionChildAbuseReport", "Child protection/child abuse report");

public static readonly ServiceTypeEnum FosterCare = new(47, "FosterCare", "Foster care");

public static readonly ServiceTypeEnum ResidentialOutofHomeCare = new (48, "ResidentialOut-of-HomeCare", "Residential/ out of home care");

public static readonly ServiceTypeEnum SupportYoungPeopleLeavingCare = new (49, "Support-YoungPeopleLeavingCare", "Support for young people leaving care");

public static readonly ServiceTypeEnum Audiology = new(50, "Audiology", "Audiology");

public static readonly ServiceTypeEnum BloodDonation = new(51, "BloodDonation", "Blood donation");

public static readonly ServiceTypeEnum Chiropractic = new(52, "Chiropractic", "Chiropractic");

public static readonly ServiceTypeEnum Dietetics = new(53, "Dietetics", "Dietetics");

public static readonly ServiceTypeEnum FamilyPlanning = new(54, "FamilyPlanning", "Family planning");

public static readonly ServiceTypeEnum HealthAdvocacyLiaisonService = new(55, "HealthAdvocacyLiaisonService", "Health advocacy/Liaison service");

public static readonly ServiceTypeEnum HealthInformationReferral = new(56, "HealthInformationReferral", "Health information/referral");

public static readonly ServiceTypeEnum Immunization = new(57, "Immunization", "Immunization");

public static readonly ServiceTypeEnum MaternalChildHealth = new (58, "Maternal&ChildHealth", "Maternal & child health");

public static readonly ServiceTypeEnum Nursing = new(59, "Nursing", "Nursing");

public static readonly ServiceTypeEnum Nutrition = new(60, "Nutrition", "Nutrition");

public static readonly ServiceTypeEnum OccupationalTherapy = new(61, "OccupationalTherapy", "Occupational therapy");

public static readonly ServiceTypeEnum Optometry = new(62, "Optometry", "Optometry");

public static readonly ServiceTypeEnum Osteopathy = new(63, "Osteopathy", "Osteopathy");

public static readonly ServiceTypeEnum Pharmacy = new(64, "Pharmacy", "Pharmacy");

public static readonly ServiceTypeEnum Physiotherapy = new(65, "Physiotherapy", "Physiotherapy");

public static readonly ServiceTypeEnum Podiatry = new(66, "Podiatry", "Podiatry");

public static readonly ServiceTypeEnum SexualHealth = new(67, "SexualHealth", "Sexual health");

public static readonly ServiceTypeEnum SpeechPathologyTherapy = new(68, "SpeechPathologyTherapy", "Speech pathology/therapy");

public static readonly ServiceTypeEnum BereavementCounselling = new(69, "BereavementCounselling", "Bereavement counselling");

public static readonly ServiceTypeEnum CrisisCounselling = new(70, "CrisisCounselling", "Crisis counselling");

public static readonly ServiceTypeEnum FamilyCounsellingTherapy = new(71, "FamilyCounsellingTherapy", "Family counselling and/or family therapy");

public static readonly ServiceTypeEnum FamilyViolenceCounselling = new(72, "FamilyViolenceCounselling", "Family violence counselling");

public static readonly ServiceTypeEnum FinancialCounselling = new(73, "FinancialCounselling", "Financial counselling");

public static readonly ServiceTypeEnum GeneralistCounselling = new(74, "GeneralistCounselling", "Generalist counselling");

public static readonly ServiceTypeEnum GeneticCounselling = new(75, "GeneticCounselling", "Genetic counselling");

public static readonly ServiceTypeEnum HealthCounselling = new(76, "HealthCounselling", "Health counselling");

public static readonly ServiceTypeEnum Mediation = new(77, "Mediation", "Mediation");

public static readonly ServiceTypeEnum ProblemGamblingCounselling = new(78, "ProblemGamblingCounselling", "Problem gambling counselling");

public static readonly ServiceTypeEnum RelationshipCounselling = new(79, "RelationshipCounselling", "Relationship counselling");

public static readonly ServiceTypeEnum SexualAssaultCounselling = new(80, "SexualAssaultCounselling", "Sexual assault counselling");

public static readonly ServiceTypeEnum TraumaCounselling = new(81, "TraumaCounselling", "Trauma counselling");

public static readonly ServiceTypeEnum VictimsofCrimeCounselling = new(82, "VictimsofCrimeCounselling", "Victims of crime counselling");

public static readonly ServiceTypeEnum CemeteryOperation = new(83, "CemeteryOperation", "Cemetery operation");

public static readonly ServiceTypeEnum Cremation = new(84, "Cremation", "Cremation");

public static readonly ServiceTypeEnum DeathServiceInformation = new(85, "DeathServiceInformation", "Death service information");

public static readonly ServiceTypeEnum FuneralServices = new(86, "FuneralServices", "Funeral services");

public static readonly ServiceTypeEnum Endodontic = new(87, "Endodontic", "Endodontic");

public static readonly ServiceTypeEnum GeneralDental = new(88, "GeneralDental", "General dental");

public static readonly ServiceTypeEnum OralMedicine = new(89, "OralMedicine", "Oral medicine");

public static readonly ServiceTypeEnum OralSurgery = new(90, "OralSurgery", "Oral surgery");

public static readonly ServiceTypeEnum Orthodontic = new(91, "Orthodontic", "Orthodontic");

public static readonly ServiceTypeEnum PaediatricDentistry = new(92, "PaediatricDentistry", "Paediatric Dentistry");

public static readonly ServiceTypeEnum Periodontic = new(93, "Periodontic", "Periodontic");

public static readonly ServiceTypeEnum Prosthodontic = new(94, "Prosthodontic", "Prosthodontic");

public static readonly ServiceTypeEnum AcquiredBrainInjuryInfoReferral = new(95, "AcquiredBrainInjuryInfoReferral", "Acquired brain injury information/referral");

public static readonly ServiceTypeEnum DisabilityAdvocacy = new(96, "DisabilityAdvocacy", "Disability advocacy");

public static readonly ServiceTypeEnum DisabilityAidsEquipment = new (97, "DisabilityAids&Equipment", "Disability aids & equipment");

public static readonly ServiceTypeEnum DisabilityCaseManagement = new(98, "DisabilityCaseManagement", "Disability case management");

public static readonly ServiceTypeEnum DisabilityDayProgramsActivities = new(99, "DisabilityDayProgramsActivities", "Disability day programs & activities");

public static readonly ServiceTypeEnum DisabilityInformationReferral = new(100, "DisabilityInformationReferral", "Disability information/referral");

public static readonly ServiceTypeEnum DisabilitySupportPackages = new(101, "DisabilitySupportPackages", "Disability support packages");

public static readonly ServiceTypeEnum DisabilitySupportedAccommodation = new(102, "DisabilitySupportedAccommodation", "Disability supported accommodation");

public static readonly ServiceTypeEnum EarlyChildhoodIntervention = new(103, "EarlyChildhoodIntervention", "Early childhood intervention");

public static readonly ServiceTypeEnum HearingAidsEquipment = new (104, "HearingAids&Equipment", "Hearing aids & equipment");

public static readonly ServiceTypeEnum DrugandorAlcoholCounselling = new(105, "DrugandorAlcoholCounselling", "Drug and/or alcohol counselling");

public static readonly ServiceTypeEnum DrugAlcoholInformationReferral = new(106, "DrugAlcoholInformationReferral", "Drug and/or alcohol information/referral");

public static readonly ServiceTypeEnum NeedleSyringeExchange = new (107, "Needle&SyringeExchange", "Needle & Syringe exchange");

public static readonly ServiceTypeEnum NonresidAlcoholDrugTreatment = new (108, "Non-resid.AlcoholDrugTreatment", "Non-residential alcohol and/or drug dependence treatment");

public static readonly ServiceTypeEnum Pharmacotherapy = new(109, "Pharmacotherapy", "Pharmacotherapy(eg.methadone) program");

public static readonly ServiceTypeEnum QuitProgram = new(110, "QuitProgram", "Quit program");

public static readonly ServiceTypeEnum ResidentialAlcoholDrugTreatment = new(111, "ResidentialAlcoholDrugTreatment", "Residential alcohol and/or drug dependence treatment");

public static readonly ServiceTypeEnum AdultCommunityEducation = new(112, "AdultCommunityEducation", "Adult/community education");

public static readonly ServiceTypeEnum HigherEducation = new(113, "HigherEducation", "Higher education");

public static readonly ServiceTypeEnum PrimaryEducation = new(114, "PrimaryEducation", "Primary education");

public static readonly ServiceTypeEnum SecondaryEducation = new(115, "SecondaryEducation", "Secondary education");

public static readonly ServiceTypeEnum TrainingVocationalEducation = new (116, "Training&VocationalEducation", "Training & vocational education");

public static readonly ServiceTypeEnum EmergencyMedical = new(117, "EmergencyMedical", "Emergency medical");

public static readonly ServiceTypeEnum EmploymentPlacementandorSupport = new(118, "EmploymentPlacementandorSupport", "Employment placement and/or support");

public static readonly ServiceTypeEnum VocationalRehabilitation = new(119, "VocationalRehabilitation", "Vocational Rehabilitation");

public static readonly ServiceTypeEnum WorkSafetyAccidentPrevention = new(120, "WorkSafetyAccidentPrevention", "Workplace safety and/or accident prevention");

public static readonly ServiceTypeEnum FinancialAssistance = new(121, "FinancialAssistance", "Financial assistance");

public static readonly ServiceTypeEnum FinancialInformationAdvice = new(122, "FinancialInformationAdvice", "Financial information/advice");

public static readonly ServiceTypeEnum MaterialAid = new(123, "MaterialAid", "Material aid");

public static readonly ServiceTypeEnum GeneralPractice = new(124, "GeneralPractice", "General Practice/GP(doctor)");

public static readonly ServiceTypeEnum AccommodationPlacementSupport = new(125, "AccommodationPlacementSupport", "Accommodation placement and/or support");

public static readonly ServiceTypeEnum CrisisEmergencyAccommodation = new(126, "CrisisEmergencyAccommodation", "Crisis/emergency accommodation");

public static readonly ServiceTypeEnum HomelessnessSupport = new(127, "HomelessnessSupport", "Homelessness support");

public static readonly ServiceTypeEnum HousingInformationReferral = new(128, "HousingInformationReferral", "Housing information/referral");

public static readonly ServiceTypeEnum PublicRentalHousing = new(129, "PublicRentalHousing", "Public rental housing");

public static readonly ServiceTypeEnum InterpretingMultilingualService = new(130, "InterpretingMultilingualService", "Interpreting/Multilingual/Language service");

public static readonly ServiceTypeEnum JuvenileJustice = new(131, "JuvenileJustice", "Juvenile Justice");

public static readonly ServiceTypeEnum LegalAdvocacy = new(132, "LegalAdvocacy", "Legal advocacy");

public static readonly ServiceTypeEnum LegalInformationAdviceReferral = new(133, "LegalInformationAdviceReferral", "Legal information/advice/referral");

public static readonly ServiceTypeEnum MentalHealthAdvocacy = new(134, "MentalHealthAdvocacy", "Mental health advocacy");

public static readonly ServiceTypeEnum MentalHealthAssessTriageCrisisResponse = new(135, "MentalHealthAssessTriageCrisisResponse", "Mental health assessment/triage/crisis response");

public static readonly ServiceTypeEnum MentalHealthCaseManagement = new(136, "MentalHealthCaseManagement", "Mental health case management/continuing care");

public static readonly ServiceTypeEnum MentalHealthInformationReferral = new(137, "MentalHealthInformationReferral", "Mental health information/referral");

public static readonly ServiceTypeEnum MentalHealthInpatientServices = new(138, "MentalHealthInpatientServices", "Mental health inpatient services(hospital psychiatric unit) - requires referral");

public static readonly ServiceTypeEnum MentalHealthNonresidentialRehab = new (139, "MentalHealthNon-residentialRehab", "Mental health non-residential rehabilitation");

public static readonly ServiceTypeEnum MentalHealthResidentialRehabCCU = new(140, "MentalHealthResidentialRehabCCU", "Mental health residential rehabilitation/community care unit");

public static readonly ServiceTypeEnum PsychiatryRequiresReferral = new (141, "Psychiatry(RequiresReferral)", "Psychiatry(requires referral)");

public static readonly ServiceTypeEnum Psychology = new(142, "Psychology", "Psychology");

public static readonly ServiceTypeEnum MartialArts = new(143, "MartialArts", "Martial arts");

public static readonly ServiceTypeEnum PersonalFitnessTraining = new(144, "PersonalFitnessTraining", "Personal fitness training");

public static readonly ServiceTypeEnum PhysicalActivityGroup = new(145, "PhysicalActivityGroup", "Physical activity group");

public static readonly ServiceTypeEnum PhysicalActivityPrograms = new(146, "PhysicalActivityPrograms", "Physical activity programs");

public static readonly ServiceTypeEnum PhysicalFitnessTesting = new(147, "PhysicalFitnessTesting", "Physical fitness testing");

public static readonly ServiceTypeEnum Pilates = new(148, "Pilates", "Pilates");

public static readonly ServiceTypeEnum SelfDefence = new (149, "Self-Defence", "Self defence");

public static readonly ServiceTypeEnum SportingClub = new(150, "SportingClub", "Sporting club");

public static readonly ServiceTypeEnum Yoga = new(151, "Yoga", "Yoga");

public static readonly ServiceTypeEnum FoodSafety = new(152, "FoodSafety", "Food safety");

public static readonly ServiceTypeEnum HealthRegulatoryInspectionCert = new (153, "HealthRegulatoryInspectionCert.", "Health regulatory, inspection and/or certification");

public static readonly ServiceTypeEnum WorkHealthSafetyInspectionCert = new (154, "WorkHealthSafetyInspectionCert.", "Workplace health and/or safety inspection and/or certification");

public static readonly ServiceTypeEnum CarerSupport = new(155, "CarerSupport", "Carer support");

public static readonly ServiceTypeEnum RespiteCare = new(156, "RespiteCare", "Respite care");

public static readonly ServiceTypeEnum AnatomicalPathology = new(157, "AnatomicalPathology", "Anatomical Pathology(including Cytopathology & Forensic Pathology)");

public static readonly ServiceTypeEnum PathologyClinicalChemistry = new (158, "Pathology-ClinicalChemistry", "Pathology - Clinical Chemistry");

public static readonly ServiceTypeEnum PathologyGeneral = new (159, "Pathology-General", "Pathology - General");

public static readonly ServiceTypeEnum PathologyGenetics = new (160, "Pathology-Genetics", "Pathology - Genetics");

public static readonly ServiceTypeEnum PathologyHaematology = new (161, "Pathology-Haematology", "Pathology - Haematology");

public static readonly ServiceTypeEnum PathologyImmunology = new (162, "Pathology-Immunology", "Pathology - Immunology");

public static readonly ServiceTypeEnum PathologyMicrobiology = new (163, "Pathology-Microbiology", "Pathology - Microbiology");

public static readonly ServiceTypeEnum AnaesthesiologyPainMedicine = new (164, "Anaesthesiology-PainMedicine", "Anaesthesiology - Pain Medicine");

public static readonly ServiceTypeEnum Cardiology = new(165, "Cardiology", "Cardiology");

public static readonly ServiceTypeEnum ClinicalGenetics = new(166, "ClinicalGenetics", "Clinical Genetics");

public static readonly ServiceTypeEnum ClinicalPharmacology = new(167, "ClinicalPharmacology", "Clinical Pharmacology");

public static readonly ServiceTypeEnum Dermatology = new(168, "Dermatology", "Dermatology");

public static readonly ServiceTypeEnum Endocrinology = new(169, "Endocrinology", "Endocrinology");

public static readonly ServiceTypeEnum GastroenterologyHepatology = new (170, "Gastroenterology&Hepatology", "Gastroenterology & Hepatology");

public static readonly ServiceTypeEnum GeriatricMedicine = new(171, "GeriatricMedicine", "Geriatric medicine");

public static readonly ServiceTypeEnum ImmunologyAllergy = new (172, "Immunology&Allergy", "Immunology & Allergy");

public static readonly ServiceTypeEnum InfectiousDiseases = new(173, "InfectiousDiseases", "Infectious diseases");

public static readonly ServiceTypeEnum IntensiveCareMedicine = new(174, "IntensiveCareMedicine", "Intensive care medicine");

public static readonly ServiceTypeEnum MedicalOncology = new(175, "MedicalOncology", "Medical Oncology");

public static readonly ServiceTypeEnum Nephrology = new(176, "Nephrology", "Nephrology");

public static readonly ServiceTypeEnum Neurology = new(177, "Neurology", "Neurology");

public static readonly ServiceTypeEnum OccupationalMedicine = new(178, "OccupationalMedicine", "Occupational Medicine");

public static readonly ServiceTypeEnum PalliativeMedicine = new(179, "PalliativeMedicine", "Palliative Medicine");

public static readonly ServiceTypeEnum PublicHealthMedicine = new(180, "PublicHealthMedicine", "Public Health Medicine");

public static readonly ServiceTypeEnum RehabilitationMedicine = new(181, "RehabilitationMedicine", "Rehabilitation Medicine");

public static readonly ServiceTypeEnum Rheumatology = new(182, "Rheumatology", "Rheumatology");

public static readonly ServiceTypeEnum SleepMedicine = new(183, "SleepMedicine", "Sleep Medicine");

public static readonly ServiceTypeEnum ThoracicMedicine = new(184, "ThoracicMedicine", "Thoracic medicine");

public static readonly ServiceTypeEnum GynaecologicalOncology = new(185, "GynaecologicalOncology", "Gynaecological Oncology");

public static readonly ServiceTypeEnum ObstetricsGynaecology = new (186, "Obstetrics&Gynaecology", "Obstetrics & Gynaecology");

public static readonly ServiceTypeEnum ReproductiveEndocrinologyInfertility = new(187, "ReproductiveEndocrinologyInfertility", "Reproductive Endocrinology & Infertility");

public static readonly ServiceTypeEnum Urogynaecology = new(188, "Urogynaecology", "Urogynaecology");

public static readonly ServiceTypeEnum NeonatologyPerinatology = new (189, "Neonatology&Perinatology", "Neonatology & Perinatology");

public static readonly ServiceTypeEnum PaediatricCardiology = new(190, "PaediatricCardiology", "Paediatric Cardiology");

public static readonly ServiceTypeEnum PaediatricClinicalGenetics = new(191, "PaediatricClinicalGenetics", "Paediatric Clinical Genetics");

public static readonly ServiceTypeEnum PaediatricClinicalPharmacology = new(192, "PaediatricClinicalPharmacology", "Paediatric Clinical Pharmacology");

public static readonly ServiceTypeEnum PaediatricEndocrinology = new(193, "PaediatricEndocrinology", "Paediatric Endocrinology");

public static readonly ServiceTypeEnum PaedGastroenterologyHepatology = new (194, "Paed.GastroenterologyHepatology", "Paediatric Gastroenterology & Hepatology");

public static readonly ServiceTypeEnum PaediatricHaematology = new(195, "PaediatricHaematology", "Paediatric Haematology");

public static readonly ServiceTypeEnum PaediatricImmunologyAllergy = new (196, "PaediatricImmunology&Allergy", "Paediatric Immunology & Allergy");

public static readonly ServiceTypeEnum PaediatricInfectiousDiseases = new(197, "PaediatricInfectiousDiseases", "Paediatric Infectious diseases");

public static readonly ServiceTypeEnum PaediatricIntensiveCareMedicine = new(198, "PaediatricIntensiveCareMedicine", "Paediatric intensive care medicine");

public static readonly ServiceTypeEnum PaediatricMedicalOncology = new(199, "PaediatricMedicalOncology", "Paediatric Medical Oncology");

public static readonly ServiceTypeEnum PaediatricMedicine = new(200, "PaediatricMedicine", "Paediatric Medicine");

public static readonly ServiceTypeEnum PaediatricNephrology = new(201, "PaediatricNephrology", "Paediatric Nephrology");

public static readonly ServiceTypeEnum PaediatricNeurology = new(202, "PaediatricNeurology", "Paediatric Neurology");

public static readonly ServiceTypeEnum PaediatricNuclearMedicine = new(203, "PaediatricNuclearMedicine", "Paediatric Nuclear Medicine");

public static readonly ServiceTypeEnum PaediatricRehabilitationMedicine = new(204, "PaediatricRehabilitationMedicine", "Paediatric Rehabilitation Medicine");

public static readonly ServiceTypeEnum PaediatricRheumatology = new(205, "PaediatricRheumatology", "Paediatric Rheumatology");

public static readonly ServiceTypeEnum PaediatricSleepMedicine = new(206, "PaediatricSleepMedicine", "Paediatric Sleep Medicine");

public static readonly ServiceTypeEnum PaediatricSurgery = new(207, "PaediatricSurgery", "Paediatric Surgery");

public static readonly ServiceTypeEnum PaediatricThoracicMedicine = new(208, "PaediatricThoracicMedicine", "Paediatric Thoracic Medicine");

public static readonly ServiceTypeEnum DiagRadiologyXrayCTFluoroscopy = new (209, "Diag.RadiologyXrayCTFluoroscopy", "Diagnostic Radiology/Xray/CT/Fluoroscopy");

public static readonly ServiceTypeEnum DiagnosticUltrasound = new(210, "DiagnosticUltrasound", "Diagnostic Ultrasound");

public static readonly ServiceTypeEnum MagneticResonanceImagingMRI = new (211, "MagneticResonanceImaging(MRI)", "Magnetic Resonance Imaging(MRI)");

public static readonly ServiceTypeEnum NuclearMedicine = new(212, "NuclearMedicine", "Nuclear Medicine");

public static readonly ServiceTypeEnum ObstetricGynaecologicalUltrasound = new(213, "ObstetricGynaecologicalUltrasound", "Obstetric & Gynaecological Ultrasound");

public static readonly ServiceTypeEnum RadiationOncology = new(214, "RadiationOncology", "Radiation oncology");

public static readonly ServiceTypeEnum CardiothoracicSurgery = new(215, "CardiothoracicSurgery", "Cardiothoracic surgery");

public static readonly ServiceTypeEnum Neurosurgery = new(216, "Neurosurgery", "Neurosurgery");

public static readonly ServiceTypeEnum Ophthalmology = new(217, "Ophthalmology", "Ophthalmology");

public static readonly ServiceTypeEnum OrthopaedicSurgery = new(218, "OrthopaedicSurgery", "Orthopaedic surgery");

public static readonly ServiceTypeEnum OtolaryngologyHeadNeckSurgery = new (219, "OtolaryngologyHead&NeckSurgery", "Otolaryngology - Head & Neck Surgery");

public static readonly ServiceTypeEnum PlasticReconstructiveSurgery = new (220, "Plastic&ReconstructiveSurgery", "Plastic & Reconstructive Surgery");

public static readonly ServiceTypeEnum SurgeryGeneral = new (221, "Surgery-General", "Surgery - General");

public static readonly ServiceTypeEnum Urology = new(222, "Urology", "Urology");

public static readonly ServiceTypeEnum VascularSurgery = new(223, "VascularSurgery", "Vascular surgery");

public static readonly ServiceTypeEnum SupportGroups = new(224, "SupportGroups", "Support groups");

public static readonly ServiceTypeEnum Airambulance = new(225, "Airambulance", "Air ambulance");

public static readonly ServiceTypeEnum Ambulance = new(226, "Ambulance", "Ambulance");

public static readonly ServiceTypeEnum BloodTransport = new(227, "BloodTransport", "Blood transport");

public static readonly ServiceTypeEnum CommunityBus = new(228, "CommunityBus", "Community bus");

public static readonly ServiceTypeEnum FlyingDoctorService = new(229, "FlyingDoctorService", "Flying doctor service");

public static readonly ServiceTypeEnum PatientTransport = new(230, "PatientTransport", "Patient transport");

public static readonly ServiceTypeEnum AE = new (231, "A&E", "A&E");

public static readonly ServiceTypeEnum AEP = new (232, "A&EP", "A&EP");

public static readonly ServiceTypeEnum Abuse = new(233, "Abuse", "Abuse");

public static readonly ServiceTypeEnum ACAS = new(234, "ACAS", "ACAS");

public static readonly ServiceTypeEnum Access = new(235, "Access", "Access");

public static readonly ServiceTypeEnum Accident = new(236, "Accident", "Accident");

public static readonly ServiceTypeEnum AcuteInpatientServ = new(237, "AcuteInpatientServ", "Acute Inpatient Service's");

public static readonly ServiceTypeEnum AdultDayPrograms = new(238, "AdultDayPrograms", "Adult Day Programs");

public static readonly ServiceTypeEnum AdultMentalHealthServices = new(239, "AdultMentalHealthServices", "Adult Mental Health Services");

public static readonly ServiceTypeEnum Advice = new(240, "Advice", "Advice");

public static readonly ServiceTypeEnum Advocacy = new(241, "Advocacy", "Advocacy");

public static readonly ServiceTypeEnum AgedPersonsMental = new(242, "AgedPersonsMental", "Aged Persons Mental Health Residential Units");

public static readonly ServiceTypeEnum Aids = new(245, "Aids", "Aids");

public static readonly ServiceTypeEnum AlAnon = new (246, "Al-Anon", "Al-Anon");

public static readonly ServiceTypeEnum Alcohol = new(247, "Alcohol", "Alcohol");

public static readonly ServiceTypeEnum AlTeen = new (248, "Al-Teen", "Al-Teen");

public static readonly ServiceTypeEnum Antenatal = new(249, "Antenatal", "Antenatal");

public static readonly ServiceTypeEnum Anxiety = new(250, "Anxiety", "Anxiety");

public static readonly ServiceTypeEnum Arthritis = new(251, "Arthritis", "Arthritis");

public static readonly ServiceTypeEnum Assessment = new(252, "Assessment", "Assessment");

public static readonly ServiceTypeEnum Assistance = new(253, "Assistance", "Assistance");

public static readonly ServiceTypeEnum Asthma = new(254, "Asthma", "Asthma");

public static readonly ServiceTypeEnum ATSS = new(255, "ATSS", "ATSS");

public static readonly ServiceTypeEnum AttendantCare = new(256, "AttendantCare", "Attendant Care");

public static readonly ServiceTypeEnum Babies = new(257, "Babies", "Babies");

public static readonly ServiceTypeEnum BathroomModificatio = new(258, "BathroomModificatio", "Bathroom Modification");

public static readonly ServiceTypeEnum Behavior = new(259, "Behavior", "Behavior");

public static readonly ServiceTypeEnum BehaviorInterventi = new(260, "BehaviorInterventi", "Behavior Intervention");

public static readonly ServiceTypeEnum Bereavement = new(261, "Bereavement", "Bereavement");

public static readonly ServiceTypeEnum Bipolar = new(262, "Bipolar", "Bipolar");

public static readonly ServiceTypeEnum Birth = new(263, "Birth", "Birth");

public static readonly ServiceTypeEnum BirthControl = new(264, "BirthControl", "Birth Control");

public static readonly ServiceTypeEnum BirthingOptions = new(265, "BirthingOptions", "Birthing Options");

public static readonly ServiceTypeEnum BIST = new(266, "BIST", "BIST");

public static readonly ServiceTypeEnum Blood = new(267, "Blood", "Blood");

public static readonly ServiceTypeEnum Bone = new(268, "Bone", "Bone");

public static readonly ServiceTypeEnum Bowel = new(269, "Bowel", "Bowel");

public static readonly ServiceTypeEnum Brain = new(270, "Brain", "Brain");

public static readonly ServiceTypeEnum BreastFeeding = new(271, "BreastFeeding", "Breast Feeding");

public static readonly ServiceTypeEnum BreastScreen = new(272, "BreastScreen", "Breast Screen");

public static readonly ServiceTypeEnum Brokerage = new(273, "Brokerage", "Brokerage");

public static readonly ServiceTypeEnum Cancer = new(274, "Cancer", "Cancer");

public static readonly ServiceTypeEnum CancerSupport = new(275, "CancerSupport", "Cancer Support");

public static readonly ServiceTypeEnum CardiovascularDisea = new(276, "CardiovascularDisea", "Cardiovascular Disease");

public static readonly ServiceTypeEnum CarePackages = new(277, "CarePackages", "Care Packages");

public static readonly ServiceTypeEnum Carer = new(278, "Carer", "Carer");

public static readonly ServiceTypeEnum CaseManagement = new(279, "CaseManagement", "Case Management");

public static readonly ServiceTypeEnum Casualty = new(280, "Casualty", "Casualty");

public static readonly ServiceTypeEnum Centrelink = new(281, "Centrelink", "Centrelink");

public static readonly ServiceTypeEnum Chemists = new(282, "Chemists", "Chemists");

public static readonly ServiceTypeEnum ChildAndAdolescent = new(283, "ChildAndAdolescent", "Child And Adolescent Mental Health Services");

public static readonly ServiceTypeEnum ChildCare = new(284, "ChildCare", "Child Care");

public static readonly ServiceTypeEnum ChildServices = new(285, "ChildServices", "Child Services");

public static readonly ServiceTypeEnum Children = new(286, "Children", "Children");

public static readonly ServiceTypeEnum ChildrensServices = new(287, "ChildrensServices", "Children's Services");

public static readonly ServiceTypeEnum Cholesterol = new(288, "Cholesterol", "Cholesterol");

public static readonly ServiceTypeEnum Clothing = new(289, "Clothing", "Clothing");

public static readonly ServiceTypeEnum CommunityBasedAcco = new(290, "CommunityBasedAcco", "Community Based Accommodation");

public static readonly ServiceTypeEnum CommunityCareUnit = new(291, "CommunityCareUnit", "Community Care Unit");

public static readonly ServiceTypeEnum CommunityChildAnd = new(292, "CommunityChildAnd", "Community Child And Adolescent Mental Health Services");

public static readonly ServiceTypeEnum CommunityHealth = new(293, "CommunityHealth", "Community Health");

public static readonly ServiceTypeEnum CommunityResidentia = new(294, "CommunityResidentia", "Community Residential Unit");

public static readonly ServiceTypeEnum CommunityTransport = new(295, "CommunityTransport", "Community Transport");

public static readonly ServiceTypeEnum CompanionVisiting = new(296, "CompanionVisiting", "Companion Visiting");

public static readonly ServiceTypeEnum Companionship = new(297, "Companionship", "Companionship");

public static readonly ServiceTypeEnum ConsumerAdvice = new(298, "ConsumerAdvice", "Consumer Advice");

public static readonly ServiceTypeEnum ConsumerIssues = new(299, "ConsumerIssues", "Consumer Issues");

public static readonly ServiceTypeEnum ContinuingCareServ = new(300, "ContinuingCareServ", "Continuing Care Services");

public static readonly ServiceTypeEnum ContraceptionInform = new(301, "ContraceptionInform", "Contraception Information");

public static readonly ServiceTypeEnum CoordinatingBodies = new(302, "CoordinatingBodies", "Coordinating Bodies");

public static readonly ServiceTypeEnum CorrectionalService = new(303, "CorrectionalService", "Correctional Services");

public static readonly ServiceTypeEnum CouncilEnvironmenta = new(304, "CouncilEnvironmenta", "Council Environmental Health");

public static readonly ServiceTypeEnum Counselling = new(305, "Counselling", "Counselling");

public static readonly ServiceTypeEnum Criminal = new(306, "Criminal", "Criminal");

public static readonly ServiceTypeEnum Crises = new(307, "Crises", "Crises");

public static readonly ServiceTypeEnum CrisisAssessmentAn = new(308, "CrisisAssessmentAn", "Crisis Assessment And Treatment Services(Cats)");

public static readonly ServiceTypeEnum CrisisAssistance = new(309, "CrisisAssistance", "Crisis Assistance");

public static readonly ServiceTypeEnum CrisisRefuge = new(310, "CrisisRefuge", "Crisis Refuge");

public static readonly ServiceTypeEnum DayProgram = new(311, "DayProgram", "Day Program");

public static readonly ServiceTypeEnum Deaf = new(312, "Deaf", "Deaf");

public static readonly ServiceTypeEnum DentalHygiene = new(313, "DentalHygiene", "Dental Hygiene");

public static readonly ServiceTypeEnum Dentistry = new(314, "Dentistry", "Dentistry");

public static readonly ServiceTypeEnum Dentures = new(315, "Dentures", "Dentures");

public static readonly ServiceTypeEnum Depression = new(316, "Depression", "Depression");

public static readonly ServiceTypeEnum Detoxification = new(317, "Detoxification", "Detoxification");

public static readonly ServiceTypeEnum Diabetes = new(318, "Diabetes", "Diabetes");

public static readonly ServiceTypeEnum DiaphragmFitting = new(319, "DiaphragmFitting", "Diaphragm Fitting");

public static readonly ServiceTypeEnum Dieticians = new(320, "Dieticians", "Dieticians");

public static readonly ServiceTypeEnum DisabledParking = new(321, "DisabledParking", "Disabled Parking");

public static readonly ServiceTypeEnum DistrictNursing = new(322, "DistrictNursing", "District Nursing");

public static readonly ServiceTypeEnum Divorce = new(323, "Divorce", "Divorce");

public static readonly ServiceTypeEnum Doctors = new(324, "Doctors", "Doctors");

public static readonly ServiceTypeEnum DrinkDrive = new (325, "Drink-Drive", "Drink-Drive");

public static readonly ServiceTypeEnum DualDiagnosisServi = new(326, "DualDiagnosisServi", "Dual Diagnosis Services");

public static readonly ServiceTypeEnum EarlyChoice = new(327, "EarlyChoice", "Early Choice");

public static readonly ServiceTypeEnum EatingDisorder = new(328, "EatingDisorder", "Eating Disorder");

public static readonly ServiceTypeEnum EmergencyRelief = new(330, "EmergencyRelief", "Emergency Relief");

public static readonly ServiceTypeEnum EmploymentAndTrain = new(331, "EmploymentAndTrain", "Employment And Training");

public static readonly ServiceTypeEnum Environment = new(332, "Environment", "Environment");

public static readonly ServiceTypeEnum Equipment = new(333, "Equipment", "Equipment");

public static readonly ServiceTypeEnum Exercise = new(334, "Exercise", "Exercise");

public static readonly ServiceTypeEnum Facility = new(335, "Facility", "Facility");

public static readonly ServiceTypeEnum FamilyChoice = new(336, "FamilyChoice", "Family Choice");

public static readonly ServiceTypeEnum FamilyLaw = new(337, "FamilyLaw", "Family Law");

public static readonly ServiceTypeEnum FamilyOptions = new(338, "FamilyOptions", "Family Options");

public static readonly ServiceTypeEnum FamilyServices = new(339, "FamilyServices", "Family Services");

public static readonly ServiceTypeEnum FFYA = new(340, "FFYA", "FFYA");

public static readonly ServiceTypeEnum FinancialAid = new(341, "FinancialAid", "Financial Aid");

public static readonly ServiceTypeEnum Fitness = new(342, "Fitness", "Fitness");

public static readonly ServiceTypeEnum FlexibleCarePackag = new(343, "FlexibleCarePackag", "Flexible Care Packages");

public static readonly ServiceTypeEnum Food = new(344, "Food", "Food");

public static readonly ServiceTypeEnum FoodVouchers = new(345, "FoodVouchers", "Food Vouchers");

public static readonly ServiceTypeEnum ForensicMentalHeal = new(346, "ForensicMentalHeal", "Forensic Mental Health Services");

public static readonly ServiceTypeEnum Futures = new(347, "Futures", "Futures");

public static readonly ServiceTypeEnum FuturesForYoungAd = new(348, "FuturesForYoungAd", "Futures For Young Adults");

public static readonly ServiceTypeEnum GeneralPractitioner = new(349, "GeneralPractitioner", "General Practitioners");

public static readonly ServiceTypeEnum Grants = new(350, "Grants", "Grants");

public static readonly ServiceTypeEnum Grief = new(351, "Grief", "Grief");

public static readonly ServiceTypeEnum GriefCounselling = new(352, "GriefCounselling", "Grief Counselling");

public static readonly ServiceTypeEnum HACC = new(353, "HACC", "HACC");

public static readonly ServiceTypeEnum HeartDisease = new(354, "HeartDisease", "Heart Disease");

public static readonly ServiceTypeEnum Help = new(355, "Help", "Help");

public static readonly ServiceTypeEnum HighBloodPressure = new(356, "HighBloodPressure", "High Blood Pressure");

public static readonly ServiceTypeEnum HomeHelp = new(357, "HomeHelp", "Home Help");

public static readonly ServiceTypeEnum HomeNursing = new(358, "HomeNursing", "Home Nursing");

public static readonly ServiceTypeEnum Homefirst = new(359, "Homefirst", "Homefirst");

public static readonly ServiceTypeEnum HospiceCare = new(360, "HospiceCare", "Hospice Care");

public static readonly ServiceTypeEnum HospitalServices = new(361, "HospitalServices", "Hospital Services");

public static readonly ServiceTypeEnum HospitalToHome = new(362, "HospitalToHome", "Hospital To Home");

public static readonly ServiceTypeEnum Hostel = new(364, "Hostel", "Hostel");

public static readonly ServiceTypeEnum HostelAccommodation = new(365, "HostelAccommodation", "Hostel Accommodation");

public static readonly ServiceTypeEnum HouseholdItems = new(366, "HouseholdItems", "Household Items");

public static readonly ServiceTypeEnum Hypertension = new(367, "Hypertension", "Hypertension");

public static readonly ServiceTypeEnum Illness = new(368, "Illness", "Illness");

public static readonly ServiceTypeEnum IndependentLiving = new(369, "IndependentLiving", "Independent Living");

public static readonly ServiceTypeEnum Information = new(370, "Information", "Information");

public static readonly ServiceTypeEnum Injury = new(371, "Injury", "Injury");

public static readonly ServiceTypeEnum Intake = new(372, "Intake", "Intake");

public static readonly ServiceTypeEnum IntensiveMobileYou = new(373, "IntensiveMobileYou", "Intensive Mobile Youth Outreach Services(Imyos)");

public static readonly ServiceTypeEnum Intervention = new(374, "Intervention", "Intervention");

public static readonly ServiceTypeEnum JobSearching = new(375, "JobSearching", "Job Searching");

public static readonly ServiceTypeEnum Justice = new(376, "Justice", "Justice");

public static readonly ServiceTypeEnum Leisure = new(377, "Leisure", "Leisure");

public static readonly ServiceTypeEnum Loans = new(378, "Loans", "Loans");

public static readonly ServiceTypeEnum LowIncomeEarners = new(379, "LowIncomeEarners", "Low Income Earners");

public static readonly ServiceTypeEnum Lung = new(380, "Lung", "Lung");

public static readonly ServiceTypeEnum MakingADifference = new(381, "MakingADifference", "Making A Difference");

public static readonly ServiceTypeEnum MedicalServices = new(382, "MedicalServices", "Medical Services");

public static readonly ServiceTypeEnum MedicalSpecialists = new(383, "MedicalSpecialists", "Medical Specialists");

public static readonly ServiceTypeEnum MedicationAdministr = new(384, "MedicationAdministr", "Medication Administration");

public static readonly ServiceTypeEnum MenstrualInformatio = new(385, "MenstrualInformatio", "Menstrual Information");

public static readonly ServiceTypeEnum Methadone = new(386, "Methadone", "Methadone");

public static readonly ServiceTypeEnum MobileSupportAndT = new(387, "MobileSupportAndT", "Mobile Support And Treatment Services(MSTS)");

public static readonly ServiceTypeEnum MotorNeurone = new(388, "MotorNeurone", "Motor Neurone");

public static readonly ServiceTypeEnum MultipleSclerosis = new(389, "MultipleSclerosis", "Multiple Sclerosis");

public static readonly ServiceTypeEnum NeighbourhoodHouse = new(390, "NeighbourhoodHouse", "Neighbourhood House");

public static readonly ServiceTypeEnum NursingHome = new(391, "NursingHome", "Nursing Home");

public static readonly ServiceTypeEnum NursingMothers = new(392, "NursingMothers", "Nursing Mothers");

public static readonly ServiceTypeEnum Obesity = new(393, "Obesity", "Obesity");

public static readonly ServiceTypeEnum OccupationalHealth = new(394, "OccupationalHealth", "Occupational Health & Safety");

public static readonly ServiceTypeEnum Optometrist = new(395, "Optometrist", "Optometrist");

public static readonly ServiceTypeEnum OralHygiene = new(396, "OralHygiene", "Oral Hygiene");

public static readonly ServiceTypeEnum Outpatients = new(397, "Outpatients", "Outpatients");

public static readonly ServiceTypeEnum OutreachService = new(398, "OutreachService", "Outreach Service");

public static readonly ServiceTypeEnum PADP = new(399, "PADP", "PADP");

public static readonly ServiceTypeEnum Pain = new(400, "Pain", "Pain");

public static readonly ServiceTypeEnum PapSmear = new(401, "PapSmear", "Pap Smear");

public static readonly ServiceTypeEnum Parenting = new(402, "Parenting", "Parenting");

public static readonly ServiceTypeEnum PeakOrganizations = new(403, "PeakOrganizations", "Peak Organizations");

public static readonly ServiceTypeEnum PersonalCare = new(404, "PersonalCare", "Personal Care");

public static readonly ServiceTypeEnum Pharmacies = new(405, "Pharmacies", "Pharmacies");

public static readonly ServiceTypeEnum Phobias = new(406, "Phobias", "Phobias");

public static readonly ServiceTypeEnum Physical = new(407, "Physical", "Physical");

public static readonly ServiceTypeEnum PhysicalActivity = new(408, "PhysicalActivity", "Physical Activity");

public static readonly ServiceTypeEnum Postnatal = new(409, "Postnatal", "Postnatal");

public static readonly ServiceTypeEnum Pregnancy = new(410, "Pregnancy", "Pregnancy");

public static readonly ServiceTypeEnum PregnancyTests = new(411, "PregnancyTests", "Pregnancy Tests");

public static readonly ServiceTypeEnum Preschool = new(412, "Preschool", "Preschool");

public static readonly ServiceTypeEnum Prescriptions = new(413, "Prescriptions", "Prescriptions");

public static readonly ServiceTypeEnum PrimaryMentalHealt = new(414, "PrimaryMentalHealt", "Primary Mental Health And Early Intervention Teams");

public static readonly ServiceTypeEnum PropertyMaintenance = new(415, "PropertyMaintenance", "Property Maintenance");

public static readonly ServiceTypeEnum Prostate = new(416, "Prostate", "Prostate");

public static readonly ServiceTypeEnum Psychiatric = new(417, "Psychiatric", "Psychiatric");

public static readonly ServiceTypeEnum PsychiatricDisabili = new(418, "PsychiatricDisabili", "Psychiatric Disability Support Services - Home-Based Outreach");

public static readonly ServiceTypeEnum PsychiatricSupport = new(423, "PsychiatricSupport", "Psychiatric Support");

public static readonly ServiceTypeEnum Recreation = new(424, "Recreation", "Recreation");

public static readonly ServiceTypeEnum Referral = new(425, "Referral", "Referral");

public static readonly ServiceTypeEnum Refuge = new(426, "Refuge", "Refuge");

public static readonly ServiceTypeEnum RentAssistance = new(427, "RentAssistance", "Rent Assistance");

public static readonly ServiceTypeEnum ResidentialFaciliti = new(428, "ResidentialFaciliti", "Residential Facilities");

public static readonly ServiceTypeEnum ResidentialRespite = new(429, "ResidentialRespite", "Residential Respite");

public static readonly ServiceTypeEnum Respiratory = new(430, "Respiratory", "Respiratory");

public static readonly ServiceTypeEnum Response = new(431, "Response", "Response");

public static readonly ServiceTypeEnum RoomingHouses = new(432, "RoomingHouses", "Rooming Houses");

public static readonly ServiceTypeEnum SafeSex = new(433, "SafeSex", "Safe Sex");

public static readonly ServiceTypeEnum SecureExtendedCare = new(434, "SecureExtendedCare", "Secure Extended Care Inpatient Services");

public static readonly ServiceTypeEnum SelfHelp = new(435, "SelfHelp", "Self Help");

public static readonly ServiceTypeEnum Separation = new(436, "Separation", "Separation");

public static readonly ServiceTypeEnum Services = new(437, "Services", "Services");

public static readonly ServiceTypeEnum SexEducation = new(438, "SexEducation", "Sex Education");

public static readonly ServiceTypeEnum SexualAbuse = new(439, "SexualAbuse", "Sexual Abuse");

public static readonly ServiceTypeEnum SexualIssues = new(440, "SexualIssues", "Sexual Issues");

public static readonly ServiceTypeEnum SexuallyTransmitted = new(441, "SexuallyTransmitted", "Sexually Transmitted Diseases");

public static readonly ServiceTypeEnum SIDS = new(442, "SIDS", "SIDS");

public static readonly ServiceTypeEnum SocialSupport = new(443, "SocialSupport", "Social Support");

public static readonly ServiceTypeEnum Socialisation = new(444, "Socialisation", "Socialisation");

public static readonly ServiceTypeEnum SpecialNeeds = new(445, "SpecialNeeds", "Special Needs");

public static readonly ServiceTypeEnum SpeechTherapist = new(446, "SpeechTherapist", "Speech Therapist");

public static readonly ServiceTypeEnum Splinting = new(447, "Splinting", "Splinting");

public static readonly ServiceTypeEnum Sport = new(448, "Sport", "Sport");

public static readonly ServiceTypeEnum StatewideAndSpecia = new(449, "StatewideAndSpecia", "Statewide And Specialist Services");

public static readonly ServiceTypeEnum STD = new(450, "STD", "STD");

public static readonly ServiceTypeEnum STI = new(451, "STI", "STI");

public static readonly ServiceTypeEnum Stillbirth = new(452, "Stillbirth", "Stillbirth");

public static readonly ServiceTypeEnum StomalCare = new(453, "StomalCare", "Stomal Care");

public static readonly ServiceTypeEnum Stroke = new(454, "Stroke", "Stroke");

public static readonly ServiceTypeEnum SubstanceAbuse = new(455, "SubstanceAbuse", "Substance Abuse");

public static readonly ServiceTypeEnum Support = new(456, "Support", "Support");

public static readonly ServiceTypeEnum Syringes = new(457, "Syringes", "Syringes");

public static readonly ServiceTypeEnum Teeth = new(458, "Teeth", "Teeth");

public static readonly ServiceTypeEnum TenancyAdvice = new(459, "TenancyAdvice", "Tenancy Advice");

public static readonly ServiceTypeEnum TerminalIllness = new(460, "TerminalIllness", "Terminal Illness");

public static readonly ServiceTypeEnum Therapy = new(461, "Therapy", "Therapy");

public static readonly ServiceTypeEnum Transcription = new(462, "Transcription", "Transcription");

public static readonly ServiceTypeEnum TranslatingServices = new(463, "TranslatingServices", "Translating Services");

public static readonly ServiceTypeEnum Translator = new(464, "Translator", "Translator");

public static readonly ServiceTypeEnum Transport = new(465, "Transport", "Transport");

public static readonly ServiceTypeEnum Vertebrae = new(466, "Vertebrae", "Vertebrae");

public static readonly ServiceTypeEnum Violence = new(467, "Violence", "Violence");

public static readonly ServiceTypeEnum VocationalGuidance = new(468, "VocationalGuidance", "Vocational Guidance");

public static readonly ServiceTypeEnum Weight = new(469, "Weight", "Weight");

public static readonly ServiceTypeEnum WelfareAssistance = new(470, "WelfareAssistance", "Welfare Assistance");

public static readonly ServiceTypeEnum WelfareCounselling = new(471, "WelfareCounselling", "Welfare Counselling");

public static readonly ServiceTypeEnum Wheelchairs = new(472, "Wheelchairs", "Wheelchairs");

public static readonly ServiceTypeEnum WoundManagement = new(473, "WoundManagement", "Wound Management");

public static readonly ServiceTypeEnum YoungPeopleAtRisk = new(474, "YoungPeopleAtRisk", "Young People At Risk");

public static readonly ServiceTypeEnum FurtherDesCommunityHealthCare = new(475, "FurtherDesc.-CommunityHealthCare", "Further Description - Community Health Care");

public static readonly ServiceTypeEnum Library = new(476, "Library", "Library");

public static readonly ServiceTypeEnum CommunityHours = new(477, "CommunityHours", "Community Hours");

public static readonly ServiceTypeEnum FurtherDesSpecialistMedical = new(478, "FurtherDesc.-SpecialistMedical", "Further Description - Specialist Medical");

public static readonly ServiceTypeEnum Hepatology = new(479, "Hepatology", "Hepatology");

public static readonly ServiceTypeEnum Gastroenterology = new(480, "Gastroenterology", "Gastroenterology");

public static readonly ServiceTypeEnum Gynaecology = new(481, "Gynaecology", "Gynaecology");

public static readonly ServiceTypeEnum Obstetrics = new(482, "Obstetrics", "Obstetrics");

public static readonly ServiceTypeEnum FurtherDescSpecialistSurgical = new(483, "FurtherDesc.-SpecialistSurgical", "Further Description - Specialist Surgical");

public static readonly ServiceTypeEnum PlacementProtection = new(484, "PlacementProtection", "Placement Protection");

public static readonly ServiceTypeEnum FamilyViolence = new(485, "FamilyViolence", "Family Violence");

public static readonly ServiceTypeEnum IntegratedFamilyServices = new(486, "IntegratedFamilyServices", "Integrated Family Services");

public static readonly ServiceTypeEnum DiabetesEducator = new(488, "DiabetesEducator", "Diabetes Educator");

public static readonly ServiceTypeEnum KinshipCare = new(489, "KinshipCare", "Kinship Care");

public static readonly ServiceTypeEnum GeneralMentalHealthServices = new(490, "GeneralMentalHealthServices", "General Mental Health Services");

public static readonly ServiceTypeEnum ExercisePhysiology = new(491, "ExercisePhysiology", "Exercise Physiology");

public static readonly ServiceTypeEnum MedicalResearch = new(492, "MedicalResearch", "Medical Research");

public static readonly ServiceTypeEnum Youth = new(493, "Youth", "Youth");

public static readonly ServiceTypeEnum YouthServices = new(494, "YouthServices", "Youth Services");

public static readonly ServiceTypeEnum YouthHealth = new(495, "YouthHealth", "Youth Health");

public static readonly ServiceTypeEnum ChildandFamilySer = new(496, "ChildandFamilySer", "Child and Family Services");

public static readonly ServiceTypeEnum HomeVisits = new(497, "HomeVisits", "Home Visits");

public static readonly ServiceTypeEnum MobileServices = new(498, "MobileServices", "Mobile Services");

public static readonly ServiceTypeEnum BeforeandorAfter = new(500, "BeforeandorAfter", "Before and/or After School Care");

public static readonly ServiceTypeEnum CancerServices = new(501, "CancerServices", "Cancer Services");

public static readonly ServiceTypeEnum IntegratedCancerSe = new(502, "IntegratedCancerSe", "Integrated Cancer Services");

public static readonly ServiceTypeEnum MultidisciplinarySe = new(503, "MultidisciplinarySe", "Multidisciplinary Services");

public static readonly ServiceTypeEnum MultidisciplinaryCa = new(504, "MultidisciplinaryCa", "Multidisciplinary Cancer Services");

public static readonly ServiceTypeEnum Meetings = new(505, "Meetings", "Meetings");

public static readonly ServiceTypeEnum Bloodpressuremonit = new(506, "Bloodpressuremonit", "Blood pressure monitoring");

public static readonly ServiceTypeEnum Doseadministration = new(507, "Doseadministration", "Dose administration aid");

public static readonly ServiceTypeEnum MedicalEquipmentHi = new(508, "MedicalEquipmentHi", "Medical Equipment Hire");

public static readonly ServiceTypeEnum DeputisingService = new(510, "DeputisingService", "Deputising Service");

public static readonly ServiceTypeEnum CancerSupportGroups = new(513, "CancerSupportGroups", "Cancer Support Groups");

public static readonly ServiceTypeEnum CommunityCancerServices = new(514, "CommunityCancerServices", "Community Cancer Services");

public static readonly ServiceTypeEnum DisabilityCareTransport = new(530, "DisabilityCareTransport", "Disability Care Transport");

public static readonly ServiceTypeEnum AgedCareTransport = new(531, "AgedCareTransport", "Aged Care Transport");

public static readonly ServiceTypeEnum DiabetesEducations = new(532, "DiabetesEducations", "Diabetes Education service");

public static readonly ServiceTypeEnum CardiacRehabilitati = new(533, "CardiacRehabilitati", "Cardiac Rehabilitation Service");

public static readonly ServiceTypeEnum YoungAdultDiabetes = new(534, "YoungAdultDiabetes", "Young Adult Diabetes services(YADS)");

public static readonly ServiceTypeEnum PulmonaryRehabilita = new(535, "PulmonaryRehabilita", "Pulmonary Rehabilitation Service");

public static readonly ServiceTypeEnum Arttherapy = new(536, "Arttherapy", "Art therapy");

public static readonly ServiceTypeEnum MedicationReviews = new(537, "MedicationReviews", "Medication Reviews");

public static readonly ServiceTypeEnum TelephoneCounselling = new(538, "TelephoneCounselling", "Telephone Counselling");

public static readonly ServiceTypeEnum TelephoneHelpLine = new(539, "TelephoneHelpLine", "Telephone Help Line");

public static readonly ServiceTypeEnum OnlineService = new(540, "OnlineService", "Online Service");

public static readonly ServiceTypeEnum CrisisMentalHealth = new (541, "Crisis-MentalHealth", "Crisis - Mental Health");

public static readonly ServiceTypeEnum YouthCrisis = new(542, "YouthCrisis", "Youth Crisis");

public static readonly ServiceTypeEnum SexualAssault = new(543, "SexualAssault", "Sexual Assault");

public static readonly ServiceTypeEnum GPAHOther = new(544, "GPAHOther", "GPAH Other");

public static readonly ServiceTypeEnum PaediatricDermatology = new(545, "PaediatricDermatology", "Paediatric Dermatology");

public static readonly ServiceTypeEnum VeteransServices = new(546, "VeteransServices", "Veterans Services");

public static readonly ServiceTypeEnum Veterans = new(547, "Veterans", "Veterans");

public static readonly ServiceTypeEnum FoodReliefFoodMeals = new(548, "FoodReliefFoodMeals", "Food Relief/food/meals");

public static readonly ServiceTypeEnum DementiaCare = new(550, "DementiaCare", "Dementia Care");

public static readonly ServiceTypeEnum Alzheimer = new(551, "Alzheimer", "Alzheimer");

public static readonly ServiceTypeEnum DrugandorAlcoholSupportGroups = new(552, "DrugandorAlcoholSupportGroups", "Drug and/or alcohol support groups");

public static readonly ServiceTypeEnum OneonOneSupportMentoringCoaching = new (553, "1on1", "One on One Support/Mentoring/Coaching");

public static readonly ServiceTypeEnum ChronicDiseaseManagement = new(554, "ChronicDiseaseManagement", "Chronic Disease Management");

public static readonly ServiceTypeEnum LiaisonServices = new(555, "LiaisonServices", "Liaison Services");

public static readonly ServiceTypeEnum WalkinCentreNonEmergency = new (556, "WalkinCentreNon-Emergency", "Walk in Centre / non emergency");

public static readonly ServiceTypeEnum Inpatients = new(557, "Inpatients", "Inpatients");

public static readonly ServiceTypeEnum SpiritualCounselling = new(558, "SpiritualCounselling", "Spiritual Counselling");

public static readonly ServiceTypeEnum WomensHealth = new(559, "WomensHealth", "Women's Health");

public static readonly ServiceTypeEnum MensHealth = new(560, "MensHealth", "Men's Health");

public static readonly ServiceTypeEnum HealthEducationAwarenessProgram = new(561, "HealthEducationAwarenessProgram", "Health education/Health awareness program");

public static readonly ServiceTypeEnum TestMessage = new(562, "TestMessage", "Test Message");

public static readonly ServiceTypeEnum RemedialMassage = new(563, "RemedialMassage", "Remedial Massage");

public static readonly ServiceTypeEnum AdolescentMentalHealthServices = new(564, "AdolescentMentalHealthServices", "Adolescent Mental Health Services");

public static readonly ServiceTypeEnum YouthDropInAssistanceSupport = new(565, "YouthDropInAssistanceSupport", "Youth drop in/assistance/support");

public static readonly ServiceTypeEnum AboriginalHealthWorker = new(566, "AboriginalHealthWorker", "Aboriginal Health Worker");

public static readonly ServiceTypeEnum WomensHealthClinic = new(567, "WomensHealthClinic", "Women's Health Clinic");

public static readonly ServiceTypeEnum MensHealthClinic = new(568, "MensHealthClinic", "Men's Health Clinic");

public static readonly ServiceTypeEnum MigrantHealthClinic = new(569, "MigrantHealthClinic", "Migrant Health Clinic");

public static readonly ServiceTypeEnum RefugeeHealthClinic = new(570, "RefugeeHealthClinic", "Refugee Health Clinic");

public static readonly ServiceTypeEnum AboriginalHealthClinic = new(571, "AboriginalHealthClinic", "Aboriginal Health Clinic");

public static readonly ServiceTypeEnum NursePractitionerLeadClinics = new(572, "NursePractitionerLeadClinics", "Nurse Practitioner lead Clinic/s");

public static readonly ServiceTypeEnum NurseLeadClinics = new(573, "NurseLeadClinics", "Nurse lead Clinic/s");

public static readonly ServiceTypeEnum CulturallyTailoredSupportGroups = new(574, "CulturallyTailoredSupportGroups", "Culturally tailored support groups");

public static readonly ServiceTypeEnum CulturallyTailoredHealthPromotion = new(575, "CulturallyTailoredHealthPromotion", "Culturally tailored health promotion");

public static readonly ServiceTypeEnum Rehabilitation = new(576, "Rehabilitation", "Rehabilitation");

public static readonly ServiceTypeEnum EducationInformationReferral = new(577, "EducationInformationReferral", "Education information/referral");

public static readonly ServiceTypeEnum SocialWork = new(580, "SocialWork", "Social Work");

public static readonly ServiceTypeEnum Haematology = new(581, "Haematology", "Haematology");

public static readonly ServiceTypeEnum MaternitySharedCar = new(582, "MaternitySharedCar", "Maternity Shared Care");

public static readonly ServiceTypeEnum RehabilitationServi = new(583, "RehabilitationServi", "Rehabilitation Service");

public static readonly ServiceTypeEnum CraniosacralTherapy = new (584, "Cranio-sacralTherapy", "Cranio-Sacral Therapy");

public static readonly ServiceTypeEnum ProstheticsOrthotics = new (585, "Prosthetics&Orthotics", "Prosthetics & Orthotics");

public static readonly ServiceTypeEnum HomeMedicineReview = new(589, "HomeMedicineReview", "Home Medicine Review");

public static readonly ServiceTypeEnum GPAHMedical = new (590, "GPAH-Medical", "GPAH - Medical");

public static readonly ServiceTypeEnum MusicTherapy = new(591, "MusicTherapy", "Music Therapy");

public static readonly ServiceTypeEnum FallsPrevention = new(593, "FallsPrevention", "Falls Prevention");

public static readonly ServiceTypeEnum AccommodationTenancy = new(599, "AccommodationTenancy", "Accommodation/Tenancy");

public static readonly ServiceTypeEnum AssesSkillAbilityNeeds = new (600, "Assess-Skill,Ability,Needs", "Assess-Skill, Ability, Needs");

public static readonly ServiceTypeEnum AssistAccessMaintainEmploy = new(601, "AssistAccessMaintainEmploy", "Assist Access/Maintain Employ");

public static readonly ServiceTypeEnum AssistProdPersCareSafety = new (602, "AssistProd-PersCareSafety", "Assist Prod-Pers Care/Safety");

public static readonly ServiceTypeEnum AssistIntegrateSchoolEd = new (603, "Assist-IntegrateSchoolEd", "Assist-Integrate School/Ed");

public static readonly ServiceTypeEnum AssistLifeStageTransition = new (604, "Assist-LifeStage,Transition", "Assist-Life Stage, Transition");

public static readonly ServiceTypeEnum AssistPersonalActivities = new (605, "Assist-PersonalActivities", "Assist-Personal Activities");

public static readonly ServiceTypeEnum AssistTravelTransport = new (606, "Assist-TravelTransport", "Assist-Travel/Transport");

public static readonly ServiceTypeEnum AssistiveEquipGeneralTasks = new (607, "AssistiveEquip-GeneralTasks", "Assistive Equip-General Tasks");

public static readonly ServiceTypeEnum AssistiveEquipRecreation = new (608, "AssistiveEquip-Recreation", "Assistive Equip-Recreation");

public static readonly ServiceTypeEnum AssistiveProdHouseholdTask = new (609, "AssistiveProd-HouseholdTask", "Assistive Prod-Household Task");

public static readonly ServiceTypeEnum BehaviorSupport = new(610, "BehaviorSupport", "Behavior Support");

public static readonly ServiceTypeEnum CommsInfoEquipment = new (611, "Comms&InfoEquipment", "Comms & Info Equipment");

public static readonly ServiceTypeEnum CommunityNursingCare = new(612, "CommunityNursingCare", "Community Nursing Care");

public static readonly ServiceTypeEnum DailyTasksSharedLiving = new(613, "DailyTasksSharedLiving", "Daily Tasks/Shared Living");

public static readonly ServiceTypeEnum DevelopmentLifeSkills = new (614, "Development-LifeSkills", "Development-Life Skills");

public static readonly ServiceTypeEnum EarlyChildhoodSupports = new(615, "EarlyChildhoodSupports", "Early Childhood Supports");

public static readonly ServiceTypeEnum EquipmentSpecialAssessSetup = new(616, "EquipmentSpecialAssessSetup", "Equipment Special Assess Setup");

public static readonly ServiceTypeEnum HearingEquipment = new(617, "HearingEquipment", "Hearing Equipment");

public static readonly ServiceTypeEnum HomeModification = new(618, "HomeModification", "Home Modification");

public static readonly ServiceTypeEnum HouseholdTasks = new(619, "HouseholdTasks", "Household Tasks");

public static readonly ServiceTypeEnum InterpretTranslate = new(620, "InterpretTranslate", "Interpret/Translate");

public static readonly ServiceTypeEnum OtherInnovativeSupports = new(621, "OtherInnovativeSupports", "Other Innovative Supports");

public static readonly ServiceTypeEnum ParticipateCommunity = new(622, "ParticipateCommunity", "Participate Community");

public static readonly ServiceTypeEnum PersonalMobilityEquipment = new(623, "PersonalMobilityEquipment", "Personal Mobility Equipment");

public static readonly ServiceTypeEnum PhysicalWellbeing = new(624, "PhysicalWellbeing", "Physical Wellbeing");

public static readonly ServiceTypeEnum PlanManagement = new(625, "PlanManagement", "Plan Management");

public static readonly ServiceTypeEnum TherapeuticSupports = new(626, "TherapeuticSupports", "Therapeutic Supports");

public static readonly ServiceTypeEnum TrainingTravelIndependence = new (627, "Training-TravelIndependence", "Training-Travel Independence");

public static readonly ServiceTypeEnum Vehiclemodifications = new(628, "Vehiclemodifications", "Vehicle modifications");

public static readonly ServiceTypeEnum VisionEquipment = new(629, "VisionEquipment", "Vision Equipment");

}