using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenQA.Selenium;

namespace MMMHC_Automation.Common
{
    public static class ElementsRepository
    {
        //General
        public static string type_xpath = "xPath";
        public static string type_name = "name";
        public static string ok_btn = "//button[text()='OK']";
        public static string submit_btn = "//button[contains(.,'Submit')]";
        public static string username_input = "//div[label[contains(.,'Username')]]/input[@name='username']";
        public static string username = "username";
        public static string name = "name";
        public static string content = "content";
        public static string password_input = "//div[label[contains(.,'Password')]]//input[@name='password']";
        public static string login_btn = "//button[contains(.,'Login')]";
        public static string answer_input = "//input[@name='answer']";
        public static string logout = "//span[contains(.,'Log out')]";
        public static string search_btn = "//button[contains(.,'Search')]";
        public static string save_btn = "//a[span[contains(.,'Save')]]/em";
        public static string create_btn = "//em[@class='fa fa-plus fa-2x']";
        public static string add_doc_btn = "//button[text()='Add Document']";
        public static string create_doc_btn = "//button[contains(.,'Create')]";
        public static string next_btn = "//button[contains(.,'Next')]";
        public static string calloutbox_next_btn = "//a[contains(.,'Next')]";
        public static string calloutbox_previous_btn = "//a[contains(.,'Previous')]";
        public static string add_btn = "//em[@class='fa fa-plus fa-lg']";
        public static string add_newdoc = "//button[text()='Add']";
        public static string contact_us_btn = "//button[text()='Contact Us']";
        public static string contact_us_header = "//label[contains(.,'Contact InnovaMD Support')]";
        public static string publicDevice = "//p[text()='Is this device public?']/..//input[@value='{0}']";
        public static string innova_homepage = "//span[text()='My InnovaMD']";
        public static string print_btn = "//a[span[contains(.,'Print')]]/em";
        public static string download_btn = "//a[span[contains(.,'Download')]]/em";
        public static string spinner = "This request is taking a few more seconds. Please be patient...";
        public static string group_icon = "//em[@class='fa fa-group']";
        public static string xbutton_tab = "//span//em[@class='fa fa-times']";
        public static string xbutton_beneficiary = "//em[@class='fa fa-times']";
        public static string yes_button = "//button[contains(.,'Yes')]";
        public static string no_button = "//button[contains(.,'No')]";
        public static string cancelbutton_printwindow="//*[@id='print-header']/div/button[2]";
		public static string beneficiary_paging_records_medications = " //div[@ng-show='parameters.totalCount > 0']//ul ";
        public static string landing_innovamd= "//h3[contains(.,'My InnovaMD')]";
        public static string search_pagenavigation_link = "//ul[@ng-show='parameters.totalCount > parameters.pageSize']//li[contains(.,'{0}')]";
        public static string click_pagenavigation_link = "//ul[@ng-show='parameters.totalCount > parameters.pageSize']//li//a[text()='{0}']";
        public static string topic_filter_option = "//li[@ng-repeat='topic in courses.session.topicFilters']//div//label[contains(.,'{0}')]";
        public static string select_check_mark = "//button[@class='btn btn-success btn-sm']";

        //MMM Login
        public static string innovaMD_img = "//img[@src='img/logo.png']";
        public static string mso_img = "//img[@src='img/mso-logo.png']";
        public static string welcome_header = "//h2[contains(.,'Welcome to InnovaMD')]";
        public static string forget_username_lnk = "//a[contains(.,'Forgot username?')]";
        public static string forget_password_lnk = "//a[contains(.,'Forgot password?')]";
        public static string register_message = "//p[contains(.,'If you are a first time user, please click Register button.')]";
        public static string register_btn = "//a[contains(.,'Register')]";
        public static string invalid_username_error_msg = "//span[@class='text-danger ng-binding'][contains(.,'Username must only contain letters or numbers.')]";
        public static string copy_write_notice = "//span[contains(.,'© 2016, InnovaMD')]";
        public static string privacy_link = "//a[text()='Privacy']";
        public static string terms_link = "//a[text()='Terms']";
        public static string invalid_username_pass_msg = "//div[@style='display: block;'][contains(.,'Invalid Username or Password.')]";

        //Registration
        public static string register_page_header = "//h2[text()='Pre Registration']";
        public static string register_billing_NPI = "billingNPI";
        public static string register_rendering_NPI = "renderingNPI";
        public static string register_ssn = "taxId";
        public static string register_captcha_label = "//label[@id='recaptcha-anchor-label']";
        public static string register_captcha_chkmark = "//span[@aria-checked='true']";
        public static string register_termscondition_chk = "//span[contains(.,'I agree to all Terms and Conditions listed above')]";
        public static string pre_registration_error = "//div[contains(.,'We cannot validate your information.Please take note of the error number and click the Contact Us link to contact our support team.')]";

        //MMM_userRoles
        public static string membership_management_span = "//span[text()='membership management']";
        public static string profile_img = "//img[@class='img-circle']";
        public static string group_admin_role = "//span[contains(.,'Group Administrator')]";
        public static string family_med_group = "//div/strong[contains(.,'FAMILY MEDICINE GROUP')]";
        public static string beneficiary_male_icon = " //em[@class='fa fa-fw fa-3x fa-male']";  
        public static string user_icon = "//em[@class='fa fa-fw fa-3x fa-user-md']";
        public static string PCP_header = "//li[contains(@heading,'PCP')]";

        //BeneficiarySearch
        public static string beneficiary_center = "//div[text()='Beneficiary Center']";
        public static string search_beneficiary_link = "//a[@class='nav-link ng-binding'][contains(.,'Beneficiary (')]";
        public static string search_pcp_link = "//a[@class='nav-link ng-binding'][contains(.,'PCP (')]";
        public static string search_admingrp_link = "//a[@class='nav-link ng-binding'][contains(.,'Administration Group (')]";
        public static string searchCriteriaName = "//input[@name='searchCriteria']"; 
        public static string SearchBeneficiaryButton = "//*[@class='btn btn-primary ng-binding']"; 
        public static string searchedUser = "//*[@class='media-left']/em"; 
        public static string pcp_searchedUser = "//div[@class='col-sm-6']";
        public static string profile_tab = "//span[text()='Profile']";
        public static string advancesrch_genderlabel = "//label[text()='Gender']";
        public static string advancesrch_genderdd = "//select[@ng-model='beneficiaries.session.searchCriteria.gender']";
        public static string malefemale_gender = "//span[text()='{0}']/..//span[text()='Gender']";
        public static string search_LOB = "//div[@class='col-xs-12 col-sm-5 col-sm-text-right ng-binding'][contains(.,'{0}')]";
        public static string advancesrch_type = "//select[@ng-model='administrationGroups.activeSession.searchCriteria.type']";
        public static string type_IPA = "//span[@uib-tooltip='Independent Practice Association'][text()='IPA']";
        public static string type_NGP = "//span[@uib-tooltip='Non-Grouped Providers'][text()='NGP']";
        public static string type_PMG = "//span[@uib-tooltip='Physician Medical Group'][text()='PMG']";
        public static string pcpadvancesrch_admingrp = "//select[@ng-model='pcps.session.searchCriteria.adminGroup']";
        public static string pcpadvancesrch_state = "//select[@ng-model='pcps.session.searchCriteria.state']";
        public static string pcpadvancesrch_city = "//select[@ng-model='pcps.session.searchCriteria.county']";
        public static string pcpadvancesrch_gender = "//select[@ng-model='pcps.session.searchCriteria.gender']";
        public static string group_NGP = "//div[@class='col-sm-text-right ng-binding'][contains(.,'NON-GROUPED PROVIDERS')]";
        public static string search_City = "//span[@ng-if='pcp.addresses[0].county.name'][text()='{0}']";
        public static string search_showing_text = "//div[@ng-show='parameters.totalCount > 0']//span[contains(.,'Showing')]";
        public static string search_show_pagesize = "//div[@ng-show='parameters.totalCount > 0']//span[4]";
        public static string search_show_pagenumbers = "//div[@ng-show='parameters.totalCount > 0']//span[@ng-show='parameters.totalCount > parameters.pageSize']";
		 public static string admingroup_link = "//div[@ng-repeat='administrationGroup in administrationGroups.searchResults'][1]";
        public static string providergroup_link = "//div[contains(@ng-repeat,'pcp in pcps.searchResults')][1]";
        public static string beneficiary_smartpaper_MA_link = "//a[@uib-tooltip='SMART Paper Not Viewed']";
        public static string beneficiary_smartpaper_GHP = "//a[@uib-tooltip='SMART Paper Not Viewed']";
        //SmartPaper
        public static string clinicaltab = "//span[text()='Clinical']";
        public static string startext = "//span[contains(.,'5-Star')]";
        public static string Yeartext = "//span[contains(.,'20')]";
        public static string updatefrequencytext = "//div[text()='Information is updated around the 15th of each month with data from previous month.']";
        public static string testcontents = "";
        public static string currentlyenrolledprogramtext = "//span[contains(.,'Currently Enrolled')]";
        public static string lineofbusinessdropdwonGHP = "//select[@ng-model='beneficiaries.session.lineOfBusiness']";
        public static string smarttiptext = "//span[contains(.,'Tips')]";
        public static string smartpaper_save_button = "//button[contains(.,'Save')]";
        public static string selectlanguage = "//select[@id='lang-options']";
		public static string smartpaper_section = "//div[@ng-if='smartpaper.smartPaper.smartPaperId']";
        public static string smartpaper_print_btn = "//button[@busy-button='print']";
        public static string smartpaper_save_options = "//button[@busy-button='save']/..//ul//li";
        public static string smartpaper_print_options = "//button[@busy-button='print']/..//ul//li";
        public static string pcp_smartpaper = "//a[text()='PCP SMART Paper']";
        public static string patient_smartpaper = "//a[text()='Patient SMART Paper']";
        public static string select_language = "//select[@id='lang-options']";
        public static string enrolledpanel_collapse = " //em[contains(@ng-show,'!enrolledProgramsPanel')] ";
        public static string enrolledpanel_expand = " //em[contains(@ng-show,'enrolledProgramsPanel')] ";
        public static string nonadherence_section = "//strong[@class='mr-sm ng-binding'][contains(.,'Non-Adherence Medications')]";
        public static string nonadherence_content = "//li[@ng-repeat='medication in smartpaper.smartPaper.medicationReconciliation.nonAdheranceMedications']";
        public static string outofscope_section = "//strong[@class='mr-sm ng-binding'][contains(.,'Medications being prescribed by physicians outside of their specialty')]";
        public static string outofscope_content = "//li[@ng-repeat='medication in smartpaper.smartPaper.medicationReconciliation.outOfScopeMedications']";
        public static string medication_reconcile = "//span[text()=' Medication Reconciliation: Consider the Following']";
        public static string recentutilization_section = "//span[text()=' For Your Review: Recent Utilization']";
        public static string last_180days = "//div[text()='Last 180 days']";
        public static string recentutilization_content = "//div[@uib-collapse='recentUtilizationPanel']//ol";
		public static string considerthefollowingtext_MRecon = "//span[contains(.,'Consider the Following')]";
        public static string coding_accuracy = "//span[contains(.,'Coding Accuracy')]";
        public static string specialty_network = "//span[contains(.,'Specialty Network Physicians')]";
        public static string recent_utilization = "//span[contains(.,'Recent Utilization')]";
        public static string recent_utilization_mostfrequentconditions = "//span[contains(.,'Most Frequent Conditions')]";

        public static string Asoftext_codingAccuracy = " //div[@uib-collapse='codigAccuracyPanel']//div[@class='text-primary section-subtitle ng-binding'] ";

        public static string chronicconditions_resubmission = " //div[@ng-if='(subsection.subsectionType.smartPaperSubsectionTypeId === smartpaper.subSections.chronicCondition)']//ol";

        public static string yearoveryear_category_text = "  //strong[contains(.,'Year over year chronic conditions for resubmission and documentation:')] ";
        public static string yearoveryear_text = " //strong[contains(.,'Year over year chronic conditions for resubmission and documentation:')] ";

        public static string AHA_recieved_text = " //strong[contains(.,'AHA received.')] ";
        public static string network_last180days_text = "//div[@class='panel-wrapper in collapse']//div[contains(.,'Last 180 days')]";

        public static string specialtynetworkphysicians_section = "//li[contains(.,'Referral 13-Apr-2016 - (N20.0) CALCULUS OF KIDNEY, RAFAEL CARRILLO CARAMBOT - Urology')]";

        public static string medicine_list = "//li[contains(@ng-repeat,'medication in smartpaper.smartPaper.medicationReconciliation.outOfScopeMedications')]";

        public static string Frequent_condition_list = " //div[@uib-collapse='frequentConditionsPanel']//ul/li";

        public static string frequentconditioncollapse_button = " //em[contains(@ng-show,'!frequentConditionsPanel')]";

        public static string frequentconditionexpand_button = " //em[contains(@ng-show,'frequentConditionsPanel')]";

        public static string polypharmacy_section = "//strong[contains(.,'Polypharmacy:')]";
       
        public static string drugcount= "//div[@ng-if='subsection.subsectionType.smartPaperSubsectionTypeId === smartpaper.subSections.polypharmacyMa']";
        public static string PotentialHighRisk_Medication = "//strong[contains(.,'Potential High Risk Medication in the Elderly')]";

        public static string PotentialHighRisk_Medication_list = "//div[@uib-collapse='medicationReconcilationPanel']//ul/li[2]/div/ol/li";

        public static string currently_enrolled_program_list = "//div[@uib-collapse='enrolledProgramsPanel']/ol/li";

        public static string currentlyenrolledprogram_collapse_button = "//em[contains(@ng-show,'!enrolledProgramsPanel')]";

        public static string currentlyenrolledprogram_Expand_button = "//em[contains(@ng-show,'enrolledProgramsPanel')]";

        //Encounter
        public static string encounters_tab = "//span[text()='Encounters']";
        public static string search_arrow = "//button[@class='btn btn-primary dropdown-toggle']";
		public static string encounter_create_btn = "//button[contains(.,'Create')]";
        public static string encounter_status = "//select[@ng-model='encounters.session.searchCriteria.encounterStatus']";
        public static string cancel_btn = "//button[contains(.,'Cancel')]";
        public static string cancel_link = "//a[text()='Cancel']";
        public static string discharge_summary = "//div/strong[contains(.,'Discharge Summary')]";
        public static string encounter_Immunization = "//div/strong[contains(.,'Immunization')]";
        public static string referredBySelect = "//select[@name='referredByType']";   // referred by
        public static string physcianSelect = "//select[@name='treatingPhysician']";  // treating physician
        public static string facilityBySelect = "//select[@name='facilityProvider']";  // facility provider
        public static string placeofserviceselect = "//select[@ng-model='general.session.encounter.billing.placeOfServiceId']";
        public static string chiefComplaintInput = ".//*[@id='chiefComplaint']";
        public static string pastMedicalHisInput = ".//*[@id='pastMedicalHistory']";
        public static string close_btn = "//button[contains(.,'Close')]";
        public static string encounters_heading_text = "//h3[contains(.,'Patient Encounter Type')]";

        //Allergies
        public static string allergies_section = "//span[text()='Allergies']";
        public static string search_allergy = "//span[text()='Allergies']";
        public static string plus_btn = "//em[@class='fa fa-plus fa-lg']"; 
        public static string allergy_severity = "td[3]//select[@ng-model='allergy.severityId']";
        public static string allergy_reaction = "td[4]//select[@ng-model='allergy.reactionId']";
        public static string allergy_status = "td[5]//select[@ng-model='allergy.allergyStatusId']";
        public static string allergy_remove_btn = "//em[@class='fa fa-trash-o fa-2x text-danger']";
        public static string allergy_table_rows = "//div[@ng-show='allergies.pagingParameters.totalCount <= 0']//table//tbody//tr";
        public static string no_allergies_reg = "//strong[text()='No Allergies Registered']";
        public static string allergy_srch_placeholder = "//input[@placeholder='Search by Allergen Name']";
        public static string all_allergen_dd = "//button[@id='single-button']/span[@ng-if='!allergies.session.allergiesData.selectedAllergenType']";
        public static string allergy_srch_error = "//li[text()='Please provide at least two (2) characters to search by Allergen Name.']";

        //Diagnosis
        public static string diagnosis_section = "//span[text()='Diagnoses']";
        public static string diagnosis_section_header = "//h3[contains(.,'Diagnoses')]";
        public static string remove_btn = "//table[@class='table table-striped']//tr[2]//td[@class='text-center ng-scope']/a/em";
        public static string primary_radio_change = "//table[@class='table table-striped']//tr[2]//td[@class='text-center']//input[@class='ng-scope']";
        public static string Diagnosis_table_rows = "//div[@ng-show='diagnoses.pagingParameters.totalCount > 0']//table//tbody//tr";
        public static string plus_button = "//table[@class='table table-striped']//tr[z]//td[@class='text-center']//button[@class='btn btn-success btn-sm']";
        public static string diagnosis_Plus_button_WithPrimaryOption = "//table[@class='table table-striped']//tr[5]//td[@class='text-center']//button[@class='btn btn-success btn-sm']";

        //services        
        public static string services_tab = "//span[text()='Services']";
        public static string validgreencheck = "//em[@class='fa fa-check-circle fa-fw text-success']";
        public static string services_providername = "//dd[@class='ng-scope']//span[text()='maria  santiago marquez']";
		public static string service_delivery_status = "//select[@ng-model='eservices.session.searchCriteria.serviceRequestDeliveryStatusId']";
        public static string noresults_search = "//span[text()='No results were found for the search criteria provided.']";
        public static string requesting_provider_tab = "//a[contains(.,'Requesting Provider')]";
        public static string requesting_provider_header = "//h3[contains(.,'Requesting Provider')]";
        public static string servicing_provider_tab = "//a[contains(.,'Servicing Provider')]";
        public static string servicing_provider_header = "//h3[contains(.,'Servicing Provider')]";
        public static string servicing_provider_speciality = "specialty";
        public static string additional_information_header = "//h3[contains(.,'Additional Information')]";
        public static string review_header = "//h3[contains(.,'Review')]";
        public static string submit_confirm_title = "//h2[text()='Service Submit Confirmation']";
        public static string submit_confirm_message = "By submitting this service for approval you certify that all information is correct.\r\n\r\nDo you want to submit this service?";
        public static string submit_response_title = "//h2[text()='Service Submit Response']";
        public static string submit_response_message = "Service submission completed successfully.\r\n\r\nDo you want to create another service for the same diagnosis?";
        public static string services_X_button = "//span[@class='close close-tab ng-scope']//em[contains(@class,'fa fa-times')]";
        public static string general_SRN = " //span[text()='Service Request Number']/..//span[2] ";
        public static string general_RN = " //span[text()='Referral Number']/..//span[2] ";
        public static string general_ST = " //span[text()='Service Type']/..//span[2] ";
        public static string general_Status = " //span[text()='Status']/..//span[2] ";
        public static string general_ReceivedDate = " //span[text()='Received Date']/..//span[2] ";
        public static string general_ExpirationDate = " //span[text()='Expiration Date']/..//span[2] ";
        public static string general_CreatedDate = " //span[text()='Created Date']/..//span[2] ";
        public static string general_CreatedBy = " //span[text()='Created By']/..//span[2] ";
        public static string general_ReviewType = " //span[text()='Review Type']/..//span[2] ";
        public static string general_PANumber = " //span[text()='PA Number']/..//span[2] ";
        public static string general_DecisionDate = " //span[text()='Decision Date']/..//span[2] ";
		public static string services_benf_name = "//a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-10 col-sm-6 col-lg-5']//span[1]/strong";
        public static string services_reqprovider_name = "  //a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-10 col-sm-6 col-lg-5']//span[2]";
        public static string services_serviceprovider_name = "//a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-10 col-sm-6 col-lg-5']//span[3]";
        public static string services_procedures = "//a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-10 col-sm-6 col-lg-5']//span[5]";
        public static string services_agesex = "//a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-2 col-sm-1 col-lg-2 ng-binding']";
        public static string services_status = " //a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-12 col-sm-5 col-sm-text-right']/span[1]/strong";
        public static string services_servicenumber = "//a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-12 col-sm-5 col-sm-text-right']/span[2]";
        public static string services_authid = " //a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-12 col-sm-5 col-sm-text-right']/span[3]";
        public static string services_created_by = "  //a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-12 col-sm-5 col-sm-text-right']/span[4]";
        public static string services_created_on = " //a[@ng-repeat='service in eservices.session.searchResults'][1]//div[@class='col-xs-12 col-sm-5 col-sm-text-right']/span[6]";
        public static string services_section = "//a[@ng-repeat='section in service.session.sections'][span[text()='{0}']]";

        //Vitals
        public static string Vitals_section = "//span[text()='Vitals']";
        public static string vitals_feet = "//input[@name='feet']";
        public static string vitals_inches = " //input[@name='inches']";
        public static string vitals_systolic = "//input[@name='systolic']";
        public static string vitals_diastolic = "//input[@name='diastolic']";
        public static string vitals_weight = "//input[@name='weight']";
        public static string vitals_pulse = "//input[@name='pulse']";
        public static string vitals_temperature = "//input[@name='temperature']";

        public static string feet_validationrange_zerotonine = "//li[contains(.,'Feet must be between 0 and 9 feet.')]";
        public static string feet_validationmessage_greaterthanzero = "//li[contains(.,'Feet value must be numeric and start with a number greater than 0.')]";
        public static string inches_validationmessage_betweenzerotoeleven = "//li[contains(.,'Inches must be between 0 and 11 inches.')]";
        public static string weightnegativevalidationmessage = "//li[contains(.,'Weight value must be numeric and start with a number greater than 0.')]";
        public static string weightoverrangevalidationmessage = "//li[contains(.,'Weight value must be numeric and start with a number greater than 0.')]";
        public static string systolicvalidation1 = "//li[contains(.,'Systolic must be between 1 and 501.')]";
        public static string systolicvalidation2 = " //li[contains(.,' Please complete all required fields for this section.')]";
        public static string diastolicpositivevalidation1 = "//li[contains(.,'Diastolic must be between 1 and 501.')]";
        public static string diastolicpositivevalidation2 = "//li[contains(.,' Please complete all required fields for this section.')]";
        public static string diastoliczerovalidation = "//li[contains(.,'Diastolic must be between 1 and 501.')]";
        public static string diastolicnegativevalidation = "//li[contains(.,'Diastolic value must be numeric and start with a number greater than 0.')]";
        public static string pulsevalidation1 = "//li[contains(.,'Pulse must be between 30 and 300')]";
        public static string pulsevalidation2 = "//li[contains(.,'Pulse must be between 30 and 300')]";
        public static string temperaturevalidation1 = "//li[contains(.,'Temperature must be between 25 and 120 F.')]";
        public static string temperaturevalidation2 = "//li[contains(.,'Temperature must be between 25 and 120 F.')]";
        public static string temperaturevalidation3 = "//li[contains(.,'Temperature value must be integer.')]";
        public static string invalidfields= "//h4[Contains(.,'Invalid fields')]";
        public static string bmifield = "//div[@class='col-md-3 mb-lg']//div[@class='form-group']/b";


		//Clinical laboratory
        public static string clinicalLab_section = "//span[text()='Clinical Laboratory']";
        public static string clinical_lab_date = "//tr//td[text()='{0}']/..//td//div//input[@ng-model='laboratoryOrder.requestedDate']";
        public static string clinical_lab_uploadIcon = "//tr//td[text()='{0}']/..//td//a//em[@class='fa fa-2x text-success fa-upload']";
        public static string require_fields_error = "//em[contains(.,'Please complete all required fields for this section')]";
        public static string clinical_lab_remove = "//tr//td[text()='{0}']/..//td//a//em[@class='fa fa-trash-o fa-2x text-danger']";
        public static string clinical_lab_addlist = "//div[@id='searchResutls']//table[@class='table table-striped']/tbody/tr/td/button";

        public static string result_button = "//em[@class='fa fa-2x text-success fa-upload']";
      
        public static string documentfield_result = "//input[@class='form-control ']";
        public static string notesfield_results = "//input[@ng-model='modal.result.notes']";
        public static string cancel_button_clinical_lab_result = "//button[@ng-click='$dismiss()']";
        public static string done_button_clinical_lab_result = " //button[contains(.,'Done')]";
        public static string lab_register = "//p[contains(.,'Register Lab Order for this encounter')]";

        public static string sampledate_lab = " //input[@is-open='modal.datePicker.properties.date.open']";
        public static string resultdate_lab = " //input[@is-open='modal.datePicker.properties.resultDate.open']";

        //Procedures
        public static string procedure_type = "//strong[text()='{0}']";
        public static string encounter_procedure_section = "//span[text()='Procedures']";
        public static string encounter_procedure_date = "//table[@class='table table-striped']//tr[z]//td[@class='text-center has-error']//div//input[@ng-model='procedure.procedureDate']";
        public static string procedure_table_rows = "//table[@class='table table-striped']//tbody//tr";

        //Settings
        public static string settings_caret_btn = "//b[@class='caret']";
        public static string settings_link = "//a[contains(.,'Settings')]";
        public static string settings_Account_text = "//div[contains(.,'Account')]";
        public static string settings_Account_icon = "//div[contains(.,'Account')]//i[@class='fa fa-user']";
        public static string settings_Account_username = "//span[text()='User Name']";
        public static string settings_Account_name = "//span[text()='Name']";
        public static string settings_Account_email = "//span[text()='Email']";
        public static string settings_Account_phone = "//span[text()='Phone']";
        public static string settings_Account_roles = "//span[text()='Roles']";
		public static string settings_security_tab = "//span[contains(.,'Security')]";
        public static string settings_delegates_tab = "//span[contains(.,'User Delegates')]";
        public static string security_userdelagates_label = "//span[contains(.,'User Delegates')]";
        public static string security_label = "//div[@class='page-header mt0 h3 text-bold text-primary border-primary ng-binding'][contains(.,'Security')]";
        public static string security_key = "//i[@class='fa fa-key']";
        public static string action_button = "//button[contains(.,'Actions')]";
        public static string changepassword_label = "//a[contains(.,'Change Password')] ";
        public static string changesecurityquestion_label = " //a[contains(.,'Change Security Questions')] ";
        public static string security_passwordlastchange_label = "//span[contains(.,'Password Last Changed')]";
        public static string security_passwordlastchange_time = " //span[@ng-if='profile.securityInfo.lastPasswordUpdate'] ";
        public static string security_questionchange_label = "//span[contains(.,'Security Questions Last Changed')]";
        public static string security_questionchange_time = " //span[@ng-if='profile.securityInfo.lastSecurityQuestionsUpdate'] ";
        public static string security_lastlogin_label = "//span[contains(.,'Last Login Date')]";
        public static string security_lastlogin_time = " //span[@ng-if='profile.securityInfo.lastLoginDateTime'] ";
        public static string changepassword_Heading = " //h4[contains(.,'Change Password')] ";
        public static string currentPassword_label = " //label[contains(.,'Current Password')] ";
        public static string newpassword_label = "  //label[contains(.,'New Password')] ";
        public static string confirmpassword_label = "   //label[contains(.,'Confirm Password')] ";
        public static string password_Rules = "  //strong[contains(.,'Password Rules:')] ";
        public static string change_btn = " //button[contains(.,'Change')] ";
        public static string changepassword_btn = "//a[text()='Change Password'] ";
        public static string changesecurityquestion_btn = "//a[text()='Change Security Questions'] "; 
        public static string ChangeSecurityQuestion_heading = " //h4[contains(.,'Change Security Questions')] ";
        public static string ChangeSecurityQuestion1_label = " //label[contains(.,'Question 1')] ";
        public static string ChangeSecurityQuestion1_dropdown = " //select[@name='question1'] ";
        public static string ChangeSecurityQuestion2_label = " //label[contains(.,'Question 2')] ";
        public static string ChangeSecurityQuestion2_dropdown = " //select[@name='question2'] ";
        public static string ChangeSecurityQuestion3_label = " //label[contains(.,'Question 3')] ";
        public static string ChangeSecurityQuestion3_dropdown = " //select[@name='question3'] ";
        public static string ChangeSecurityAnswer1_field = " //input[@name='answer1'] ";
        public static string ChangeSecurityAnswer2_field = " //input[@name='answer2'] ";
        public static string ChangeSecurityAnswer3_field = " //input[@name='answer3'] ";
        public static string account_tab = " //span[contains(.,'Account')] ";   
        public static string username_field = " //span[contains(.,'User Name')] ";
        public static string name_field = " //span[contains(.,'Name')] ";
        public static string email_filed = " //span[contains(.,'Email')] ";
        public static string phone_field = "  //span[contains(.,'Phone')] ";
        public static string roles_field = " //span[contains(.,'Roles')] ";
        public static string roles_list = " //ul[@class='list-unstyled']//li[@class='ng-binding ng-scope'] ";
        public static string Account_label = "//div[@class='page-header mt0 h3 text-bold text-primary border-primary ng-binding ng-scope'][contains(.,'Account')]";
        public static string Account_icon = " //div[@class='page-header mt0 h3 text-bold text-primary border-primary ng-binding ng-scope']//i ";
        public static string Account_username_txt = " //div[@class='col-sm-4 mb-lg']//span[@class='ng-binding'] ";
        public static string Account_name_txt = " //div[@class='col-sm-4 mb-lg']//span[@class='text-capitalize ng-binding'] ";
        public static string Account_email_txt = " //div[@class='col-sm-4 mb-lg']//span[@ng-if='profile.user.email'] ";
        public static string Account_phone_txt = " //div[@class='col-sm-4 mb-lg']//span[@ng-if='profile.user.phone'] ";

        //delegates
        public static string delegates_edit_btn = " //table[@class='table table-striped ng-scope']//tr[1]//td[@class='actions text-right pr-lg ng-scope']//i[@class='fa fa-edit fa-lg'] ";
        public static string delegates_status_dropdown = "//select[@name='status'] ";
        public static string delegate_status_reqmessage = " //li[contains(@ng-show,'error.required')] ";
        public static string delegate_save_btn = " //button[@type='submit'] ";
        public static string delegate_ok_btn = " //button[contains(.,'OK')] ";
        public static string delegate_icon = "  //h3[@class='text-primary section-header ng-binding ng-scope']//i[@class='fa fa-group'] ";
        public static string delegate_CreateUserDelegate = "//a[contains(.,'Create User Delegate')]  ";
        public static string delegate_title = " //h3[contains(.,'User Delegates')]  ";
        public static string delegate_heading = " //span[contains(.,'Create User Delegate')] ";
        public static string delegate_username_field = "   //input[@name='username'] ";
        public static string delegate_name_field = "   //input[@name='name']";
        public static string delegate_email_field = "    //input[@type='email'] ";
        public static string delegate_phone_field = "   //input[@name='phone'] ";
        public static string delegate_securitysection_label = " //label[contains(.,'Security')] ";
        public static string delegate_securitysection_text = "   //div[contains(.,'Please select access options for the delegate')] ";
        public static string delegate_provider_tab = "  //div[@class='context-selector active']//span[@class='ng-binding'] ";
        public static string delegate_admingroup_tab = "//div[@class='context-selector']//span[@class='ng-binding'] ";
        public static string delegate_tabs_collection = " //div[contains(@class,'centered-title text-primary ng-binding')] ";
        public static string delegate_Edit_heading = " //span[contains(.,'Edit User Delegate')]";
        public static string delegate_validation_username = "//li[contains(.,'Username is required.')]";
        public static string delegate_validation_name = "//li[contains(.,'Name is required.')]";
        public static string delegate_validation_status = "//li[contains(.,'Status is required.')]";
        public static string delegate_validation_email = "//li[contains(.,'Email is required.')]";
        public static string delegate_validation_phone = "//li[contains(.,'Phone is required.')]";

        //provider Navigational tabs
        public static string providers_icon = " //nav[@class='sidebar']/ul/li[2] ";
        public static string practice_center_link = " //ul[@class='nav sidebar-subnav ng-scope collapse nav-floating']//a/span[contains(.,'Practice Center')] ";
        public static string practice_center_title = "  //span[contains(., 'Practice Center')] ";
        public static string practice_center_icon = " //i[contains(@class,'fa fa-user-md')] ";
        public static string provider_namewithNPI = "  //div[@class='bg-primary record-info-header']//h3[@class='text-capitalize ng-binding'][contains(.,'{0}')] ";
        public static string provider_profile_tab = "   //span[text()='Profile'] ";
        public static string provider_services_tab = " //span[text()='Services'] ";
        public static string provider_encounters_tab = " //span[text()='Encounters'] ";
        public static string provider_NPI_field = " //span[contains(.,'NPI')] ";
        public static string search_field = " //input[@name='searchCriteria'] ";
        public static string general_NPI_field = " //span[text()='NPI']/..//span[2] ";
        public static string general_name_field = "//span[text()='Name']/..//span[2] ";
        public static string general_gender_field = "   //span[text()='Gender']/..//span[2]";
        public static string general_email = "   //li[@ng-repeat='email in provider.general.emails'] ";
        public static string general_phone = " //span[text()='Phone']/..//span[2] ";
        public static string general_fax = " //span[text()='Fax']/..//span[2] ";
        public static string general_address = "   //span[contains(.,'Address')]/..//ul/li[1] ";
        public static string languages = "  //span[text()='Languages']/..//ul/li[1] ";
        public static string specialties = "   //span[text()='Specialties']/..//ul/li[1] ";
        public static string administrative = "    //span[contains(.,'Administrative')]/..//ul/li[1] ";
        public static string hospital_privileges = " //span[contains(.,'Hospital Privileges')] ";
        public static string hospital_privileges_name = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[1] ";
        public static string hospital_privileges_privilege = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[2] ";        
        public static string credentails_information = " //span[contains(.,'Credentials')] ";
        public static string credentails_name = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[1] ";
        public static string credentails_number = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[2] ";
        public static string credentails_effectivedate = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[3] ";
        public static string credentails_expirationdate = "  //table[@class='table table-striped ng-scope']//tbody//tr//td[4] ";
        public static string products_grid_name = " //div[@class='panel panel-default ng-scope']//table[@class='table table-striped ng-scope']/thead/tr/th[1]/span[text()='Name'] ";
        public static string products_grid_lob = " //div[@class='panel panel-default ng-scope']//table[@class='table table-striped ng-scope']/thead/tr/th[2]/span[text()='Line of Business'] ";
        public static string products_grid_healthplan = " //div[@class='panel panel-default ng-scope']//table[@class='table table-striped ng-scope']/thead/tr/th[3]/span[text()='Health Plan']";
        public static string products_grid_data = " //div[@class='panel panel-default ng-scope']//table[@class='table table-striped ng-scope']/tbody ";
        public static string Products = " //span[contains(.,'Products')] ";
        public static string quick_filter_services = " //a[@ng-repeat='filter in eservices.session.filters'][contains(.,'{0}')] ";
        public static string services_searchbox = "//input[@name='searchCriteria'][@placeholder='Search by Service Number, Authorization Number, Referral Number, Provider Name, Beneficiary Name or Beneficiary ID']";
        public static string quick_filter_encounters = " //a[@ng-repeat='globalCount in encounters.session.globalCounts'][contains(.,'{0}')] ";
        public static string encounters_searchbox = "//input[@name='searchCriteria'][@placeholder='Search by Beneficiary Name, Beneficiary ID, Provider Name or Provider NPI']";
        public static string healthplan = "//label[contains(.,'Health Plan')]";
        public static string Affiliations ="//div[@ng-repeat='aff in provider.affiliations']";
        public static string Affiliations_tab = "//span[contains(.,'Affiliations')]";
        //Info Center
        public static string info_center_icon = " //nav[@class='sidebar']/ul/li[6] ";
        public static string support_center_link = " //ul[@class='nav sidebar-subnav ng-scope collapse nav-floating']//a/span[contains(.,'Support Center')] ";
        public static string learning_center_link = " //ul[@class='nav sidebar-subnav ng-scope collapse nav-floating']//li//a/span[contains(.,'Learning Center')] ";
        public static string support_center_header = "//h1[text()='Welcome to InnovaMD Support Center']";
        public static string get_support_btn = "//button[contains(.,'Get Support')]";
        public static string contact_support_header = "//label[text()='Contact InnovaMD Support']";
        public static string business_hours_header = "//label[text()='Business Hours']";
        public static string monday_to_friday = "//label[text()='Monday to Friday 7:00 AM – 7:00 PM']";
        public static string answer_to_question = "//label[contains(.,'find the answer to your question, please contact us via the form on this page.')]";
        public static string by_email_header = "//label[text()='By Email']";
        public static string contact_department = "//select[@name='department']";
        public static string contact_reason = "//select[@name='reason']";
        public static string contact_email = "//input[@name='email']";
        public static string contact_module = "//select[@name='module']";
        public static string contact_identifier = "//input[@name='identifier']";
        public static string contact_feature = "//select[@name='feature']";
        public static string contact_phone = "//input[@name='phone']";
        public static string contact_errorcode = "//input[@ng-model='supportrequest.session.request.errorCode']";
        public static string contact_address = "//textarea[@name='address']";
        public static string contact_message = "//textarea[@name='message']";
        public static string contact_files = "//div[text()='Files']";
        public static string contact_filename = "//td[text()='Name']";
        public static string contact_filesize = "//td[text()='Size']";
        public static string contact_fileremove = "//td[text()='Remove']";
        public static string contact_filebrowse = "//span[text()='Browse...']";
        public static string contact_file_maxsize = "//p[text()='Maximum size: 10MB']";
        public static string contact_fileformats = "//p[text()='Allowed file format: .PDF,.GIF,.JPG,.JPEG']";
        public static string search_advance_filter = " //span[contains(.,'No Advanced Filter Applied')]";
        public static string search_result_rows_anchor = "//div[@class='panel panel-default']//div[@block-ui='documentsSearchResults']/a";
        public static string search_result_text = " div/div[2]/div/div/span/strong ";
        public static string search_result_coursetopic = "div/div[2]/div/div[2]/span[2]";
        public static string course_search_criteria = "//input[contains(@name,'SearchCriteria')]";
        public static string course_search_button = "//button[@type='submit']";
		public static string learningcenter_mylearningplan = " //div[@class='list-group']/a[1] ";
        public static string learningcenter_coursesinprogress = " //div[@class='list-group']/a[2] ";
        public static string learningcenter_coursescompleted = "//div[@class='list-group']/a[3]";
        public static string learningcenter_allcourses = " //div[@class='list-group']/a[4]";
        public static string learningcenter_topicfilter = "//div[@class='panel-heading']/h4";
        public static string learningcenter_topicslist = " //div[@class='panel panel-default filter-panel']//ul/li";
        public static string course_name = " //div[@class='col-xs-6']//span//strong";
        public static string course_publish_date = " //span[@ng-if ='courseSearchResult.publishDate']";
        public static string course_expiry_date = " //span[@ng-if ='courseSearchResult.expirationDate']";
        public static string course_status = "//div[@class='col-xs-6']//span//strong[@class='ng-binding ng-scope']";
        public static string course_topic = " //span[@class='text-capitalize pull-right ng-binding'][contains(.,'Topic:')]";
        public static string course_completed_lessions = " //span[@class='text-capitalize pull-right ng-binding'][contains(.,'Completed Lessions:')]";
        public static string course_lessons = " //span[@class='text-capitalize pull-left ng-binding'][contains(.,'Lessons:')]";

        //My Tasks
        public static string my_tasks_icon = "//div[@class='text-uppercase ng-binding'][text()='{0}']";
        public static string calloutbox_items_services = "//div[@block-ui='services']//div[@class='list-group']//div[@class='list-group-item ng-scope']";
        public static string calloutbox_items_encounters = "//div[@block-ui='encounters']//div[@class='list-group']//div[@class='list-group-item ng-scope']";
        public static string general_header = "//h3[contains(.,'General')]";
		public static string callout_box_items = "//div[@block-ui='services']//div[@class='list-group']//div[@class='list-group-item ng-scope']";

		//AHA widget
        public static string calloutbox_items_aha = "//div[@block-ui='aha']//div[@class='list-group']//div[@class='list-group-item ng-scope']";
        public static string calloutbox_aha_benf_link = " //a[@ng-click='mytask.navigateToBeneficiaries()']";

        //smartpaper widget
        public static string calloutbox_items_smartpaper = "//div[@block-ui='smartpaper']//div[@class='list-group']//div[@class='list-group-item ng-scope']";
        public static string calloutbox_smartpaper_benf_link = "//a[contains(.,'Open Beneficiary Center')]";

        //Learning center
        public static string calloutbox_items_learningcenter = "//div[@block-ui='learning']//div[@class='list-group']//div[@class='list-group-item ng-scope']";
        public static string calloutbox_learningcenter_link = "//a[contains(.,'Open Learning Center')] ";
        public static string learningcenter_searchCriteriaName = "//input[@name='SearchCriteria']";

        //Documents
        public static string document_center_link = " //div[@class='col-md-2 text-center bg-info pv-lg']//em[@class='fa fa-folder-open-o fa-3x'] ";
        public static string category_filter_text = "//div[@class='col-sm-3']/div[2]//div[@class='panel-heading']/h4";
        public static string category_filter_list = " //div[@class='panel panel-default filter-panel']//ul[@class='list-group list-group-scroller'] ";
        public static string advancedfilter_button = "  //button[@class='btn btn-primary dropdown-toggle'] ";
        public static string docstatus_dropdown = " //select[@ng-model='providerdocuments.session.searchCriteria.DCDocumentStatusId'] ";
        public static string publishdate_from = " //input[@name='publishDateFrom'][@date-parser='MM/dd/yyyy']";
        public static string publishdate_to = " //input[@name='publishDateTo'][@date-parser='MM/dd/yyyy']";
        public static string lastviewdate_from = " //input[@name='lastViewDateFrom'][@date-parser='MM/dd/yyyy'] ";
        public static string lastviewdate_to = "  //input[@name='lastViewDateTo'][@date-parser='MM/dd/yyyy'] ";
        public static string documenttab = "//span[text()='Documents']";

        public static string doc_icon = " //h3[@class='page-header mt0 text-bold text-primary border-primary mb-sm ng-binding']/i";

        public static string dateofservice_doc = "  //div[@class='col-xs-6 col-sm-3 col-md-2 mt-lg']//div[@class='ng-binding']";

        public static string status_doc = "//div[@class='col-xs-6 col-sm-3 col-md-1 col-lg-2 mt-lg']//div[1]//span";

        public static string lastviewed_uploaded_doc = "//div[@class='col-xs-6 col-sm-3 col-md-3 col-lg-2 mt-lg']/div";

        public static string uploadedby_doc = "//div[@class='col-xs-6 col-sm-3 col-md-3 col-lg-4 mt-lg']/div";

        public static string close_button_doc = " //span[@class='close close-tab ng-scope']//em[@class='fa fa-times']";

        public static string alldocs_tab = " //a[@ng-click='documents.changeFilter(filter.filterKey)'][5]";
        public static string searcheddoc_link = "  //div[@class='panel panel-default']//div[@block-ui='documentsSearchResults']/a[1]";

        //medications
        public static string medicine_srch_error = " //li[contains(.,'Please provide at least two (2) characters to search by Drug Name.')] ";
        public static string medications_section = "//span[text()='Prescribed Medication']";
        public static string no_medicines_reg = "//strong[text()='No Prescribed Medications Registered']";
        public static string prescribedmedication = "  //p[contains(.,'Register Prescribed Medications for this encounter.')] ";
        public static string gridcol_withoutrecord_drug = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[1]/span[text()='Drug']";
        public static string gridcol_withoutrecord_Sig = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[2]/span[text()='Sig']";
        public static string gridcol_withoutrecord_Qty = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[3]/span[text()='Qty']";
        public static string gridcol_withoutrecord_Remove = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[4]/span[text()='Remove']";
        public static string gridcol_withrecord_drug = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[1]/span[text()='Drug']";
        public static string gridcol_withrecord_type = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[2]/span[text()='Type']";
        public static string gridcol_withrecord_unit = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[3]/span[text()='Unit']";
        public static string gridcol_withrecord_add = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[4]/span[text()='Add']";
        public static string grid_paging_records_medications = " //div[@ng-show='parameters.totalCount > 0']//ul ";        
        public static string Administeredmedications_section = "//span[text()='Administered Medication']";
        public static string CarePlan_section = " //span[text()='Care Plan']";
        public static string Clinicallaboratory_section = "//span[text()='Clinical Laboratory']";
        public static string no_Administeredmedicines_reg = "//strong[text()='No Administered Medications Registered']";
        public static string Administeredmedication = "  //p[contains(.,'Register Administered Medications for this encounter.')] ";
        public static string Administered_gridcol_withoutrecord_drug = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[1]/span[text()='Drug']";
        public static string Administered_gridcol_withoutrecord_Sig = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[2]/span[text()='Sig']";
        public static string Administered_gridcol_withoutrecord_Qty = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[3]/span[text()='Qty']";
        public static string Administered_gridcol_withoutrecord_Date = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[4]/span[text()='Date']";
        public static string Administered_gridcol_withoutrecord_Remove = "//div[@class='panel panel-default ng-scope']//table[@class='table table-striped']/thead/tr/th[5]/span[text()='Remove']";
        public static string Administered_gridcol_withrecord_drug = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[1]/span[text()='Drug']";
        public static string Administered_gridcol_withrecord_type = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[2]/span[text()='Type']";
        public static string Administered_gridcol_withrecord_unit = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[3]/span[text()='Unit']";
        public static string Administered_gridcol_withrecord_add = "//div[@id='searchResutls']//table[@class='table table-striped']/thead/tr/th[4]/span[text()='Add']";
        public static string Administered_grid_paging_records_medications = " //div[@ng-show='parameters.totalCount > 0']//ul ";
        public static string errorrequiredfields_medication = " //h4[contains(.,'Please complete all required fields for this section.')]";

        //careplan

        public static string careplan_heading = " //h3[contains(.,'Physical Activity')]";
        public static string careplan_checkbox_physicalactivity = "//div[@class='checkbox c-checkbox ng-scope']/label/input";
        public static string careplan_notes_physicalactivity = "//div[@class='col-md-6']/input";       

        //Billing
        public static string billing_section = "//span[text()='Billing']";
        public static string billing_npi_lbl = " //label[contains(.,'Billing NPI')]";
        public static string placeofservice_lbl = " //label[contains(.,'Place of Service')] ";
        public static string service_lbl = " //label[text()='Service']";
        public static string patientamount_lbl = " //label[contains(.,'Patient Amount')]";
        public static string billing_npi_name = "//div[@class='form-group']//div[@class='ng-binding']";
        public static string placeofservice_value = "//label[contains(.,'Place of Service')]/..";
        public static string service_drpdown = " //select[@ng-model='billing.session.encounter.billing.serviceProcedureId']";
        public static string patient_amount = "//input[@ng-model='billing.session.encounter.billing.patientAmount']";
        public static string patient_amt_validation = " //li[contains(.,'Please remove invalid characters.')]";

        //Affiliations
        public static string affiliations_section = "//span[text()='Affiliations']";
        public static string affiliations_header = "//div[contains(.,'Affiliations')]";
        public static string affiliations_provider = "//span[text()='Provider']";
        public static string affiliations_since = "//span[text()='Affiliated Since']";
        public static string affiliations_homevisit = "//span[text()='Home Visit']";
        public static string affiliations_acceptnew_patients = "//span[text()='Accept New Patients']";
        public static string affiliations_address_arrow = "//span[@ng-click='affiliation.manageProviderAddressesDisplay($event, affiliation)']";
        public static string affiliations_address = "//div[@data-part='addresses']//div[@data-part='address-card']";
        public static string affiliations_location = "//div[@data-part='location']";
        public static string affiliations_phone = "//div[@data-part='contacts']//div[@ng-if='address.phones[0]']";
        public static string affiliations_fax = "//div[@data-part='contacts']//div[@ng-if='address.phones[1]']";
        public static string affiliations_primaryicon = "//div[@class=' fa fa-star text-green']";

    }
}
