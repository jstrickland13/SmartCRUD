using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WNCCRM
{
    [Table("ACCESS_HOURS", Schema = "WNCCRM")]
    public partial class ACCESS_HOURS
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String DAY { get; set; }
        public System.String FROMTIME { get; set; }
        public System.String TOTIME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String MODIFIED_USER { get; set; }
        public System.DateTime? MODIFIED_DATE { get; set; }
    }
    [Table("ACCT_PARTY", Schema = "WNCCRM")]
    public partial class ACCT_PARTY
    {
        [Key]
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String ACCT_PARTY_TYPE { get; set; }
        public System.String TITLE { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String MIDDLE_INITIAL { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME_SUFFIX { get; set; }
        public System.String NAME { get; set; }
        public System.String COMPANY_NAME { get; set; }
        public System.String DEPARTMENT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String DO_NOT_EMAIL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
        public System.String OPT_IN_TEXT { get; set; }
        public System.DateTime? OPT_IN_TEXT_DATE { get; set; }
        public System.String PASSCODE { get; set; }
        public System.DateTime? PASSCODE_LAST_UPDATE_DATE { get; set; }
        public System.String DDOS_ALERT { get; set; }
        public System.String MOP_NOTIFICATION { get; set; }
        public System.String FORTIANALYZER_WKLY_REPORT { get; set; }
        public System.String PORTAL_USER { get; set; }
        public System.String LANGUAGE_PREFERENCE { get; set; }
    }
    [Table("ACCT_PARTY_PREFERENCE", Schema = "WNCCRM")]
    public partial class ACCT_PARTY_PREFERENCE
    {
        [Key]
        public System.Decimal ACCT_PARTY_PREFERENCE_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUSINESS_FUNCTION_ID { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ACCT_PARTY_PRIORITY", Schema = "WNCCRM")]
    public partial class ACCT_PARTY_PRIORITY
    {
        [Key]
        public System.Decimal ACCT_PARTY_PRIORITY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String CUST_ACCT_TYPE_ROLE { get; set; }
        public System.Decimal SORT_ORDER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ACCT_PARTY_ROLE", Schema = "WNCCRM")]
    public partial class ACCT_PARTY_ROLE
    {
        public System.Decimal? ACCT_PARTY_ROLE_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.Decimal? PREFERRED_CONTACT_MEDIUM_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String CUST_ACCT_PARTY_ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ACCT_PARTY_WKLY_BKP", Schema = "WNCCRM")]
    public partial class ACCT_PARTY_WKLY_BKP
    {
        public System.Decimal? ACCT_PARTY_WKLY_BKP_ID { get; set; }
        public System.DateTime? INSERT_DATE { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OPT_IN_TEXT { get; set; }
        public System.DateTime? OPT_IN_TEXT_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("ADDRESS_PARSER_CAMS", Schema = "WNCCRM")]
    public partial class ADDRESS_PARSER_CAMS
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String STREET_INFO { get; set; }
        public System.String CITY_INFO { get; set; }
        public System.String ADRS_STR { get; set; }
        public System.String ADDR_LINE2 { get; set; }
        public System.String ADDR_LINE3 { get; set; }
        public System.String ADDR_LINE4 { get; set; }
        public System.String ADDR_LINE5 { get; set; }
        public System.String ADDR_ID { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_DIRECTIONAL_PREFIX { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String STREET_TYPE { get; set; }
        public System.String STREET_DIRECTIONAL_SUFFIX { get; set; }
        public System.String STRUCTURE_TYPE1 { get; set; }
        public System.String STRUCTURE_VALUE1 { get; set; }
        public System.String PARSED_CITY { get; set; }
        public System.String CITY { get; set; }
        public System.String IS_VALID_CITY { get; set; }
        public System.String PARSED_STATE_CODE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String IS_VALID_STATE_CODE { get; set; }
        public System.String PARSED_POSTAL_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String IS_VALID_POSTAL_CODE { get; set; }
        public System.String COMMENTS { get; set; }
        public System.String ERRO_PROC { get; set; }
        public System.String PROCESS_FLAG { get; set; }
    }
    [Table("ADMIN_STATE_LKUP", Schema = "WNCCRM")]
    public partial class ADMIN_STATE_LKUP
    {
        [Key]
        public System.Decimal ADMIN_STATE_LKUP_ID { get; set; }
        public System.String VALUE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_CUST_ACCT", Schema = "WNCCRM")]
    public partial class AGREEMENT_CUST_ACCT
    {
        [Key]
        public System.Decimal AGREEMENT_CUST_ACCT_ID { get; set; }
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.Double? ESTIMATED_MONTHLY_REVENUE { get; set; }
        public System.Double? MIN_MONTHLY_FEE { get; set; }
        public System.Double? PREPAID_AMOUNT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("AGREEMENT_CUST_ACCT_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class AGREEMENT_CUST_ACCT_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_MARKET_PROGRAM", Schema = "WNCCRM")]
    public partial class AGREEMENT_MARKET_PROGRAM
    {
        [Key]
        public System.Decimal AGREEMENT_MARKET_PROGRAM_ID { get; set; }
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.Decimal MARKET_PROGRAM_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_MKT_PROG_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class AGREEMENT_MKT_PROG_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_ORG", Schema = "WNCCRM")]
    public partial class AGREEMENT_ORG
    {
        [Key]
        public System.Decimal AGREEMENT_ORG_ID { get; set; }
        public System.Decimal ORG_ID { get; set; }
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("AGREEMENT_ORG_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class AGREEMENT_ORG_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_PARTY_ROLE", Schema = "WNCCRM")]
    public partial class AGREEMENT_PARTY_ROLE
    {
        [Key]
        public System.Decimal AGREEMENT_PARTY_ROLE_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("AGREEMENT_PARTY_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class AGREEMENT_PARTY_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_REL", Schema = "WNCCRM")]
    public partial class AGREEMENT_REL
    {
        public System.Decimal PARENT_AGREEMENT_ID { get; set; }
        public System.Decimal CHILD_AGREEMENT_ID { get; set; }
        public System.Decimal AGREEMENT_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        [Key]
        public System.Decimal AGREEMENT_REL_ID { get; set; }
    }
    [Table("AGREEMENT_REL_SPEC", Schema = "WNCCRM")]
    public partial class AGREEMENT_REL_SPEC
    {
        [Key]
        public System.Decimal AGREEMENT_REL_SPEC_ID { get; set; }
        public System.Decimal PARENT_AGREEMENT_SPEC_ID { get; set; }
        public System.Decimal CHILD_AGREEMENT_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("AGREEMENT_SPEC", Schema = "WNCCRM")]
    public partial class AGREEMENT_SPEC
    {
        [Key]
        public System.Decimal AGREEMENT_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ALERT_CONFIG", Schema = "WNCCRM")]
    public partial class ALERT_CONFIG
    {
        [Key]
        public System.Decimal ALERT_CONFIG_ID { get; set; }
        public System.String ENVIRONMENT { get; set; }
        public System.String COMPONENT { get; set; }
        public System.String APPLICATION { get; set; }
        public System.String EVENT_APPLICATION { get; set; }
        public System.String LEVEL_1 { get; set; }
        public System.String LEVEL_2 { get; set; }
        public System.String LEVEL_3 { get; set; }
        public System.String SCRIPT_SOURCE { get; set; }
        public System.String EXECUTED_BY_CONTROLLER { get; set; }
        public System.String SCRIPT_TO_RUN { get; set; }
        public System.String POSSIBLE_VALUES { get; set; }
        public System.String THRESHOLD_1_FOR_ERROR { get; set; }
        public System.String THRESHOLD_2_FOR_ERROR { get; set; }
        public System.Decimal? INTERVAL_TO_LOG { get; set; }
        public System.Decimal? ARCHIVE_THRESHOLD { get; set; }
        public System.String DEV_TEAM_PHONE { get; set; }
        public System.String DEV_TEAM_TO { get; set; }
        public System.String DEV_TEAM_CC { get; set; }
        public System.String ESCALATION_THRESHOLD { get; set; }
        public System.String ESCALATION_TEAM_PHONE { get; set; }
        public System.String ESCALATION_TEAM_TO { get; set; }
        public System.String ESCALATION_TEAM_CC { get; set; }
        public System.Decimal? PARENT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_MODIFIED_USER { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String COMMENTS { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("ALERT_DETAIL", Schema = "WNCCRM")]
    public partial class ALERT_DETAIL
    {
        [Key]
        public System.Decimal ALERT_DETAIL_ID { get; set; }
        public System.Decimal? ALERT_CONFIG_ID { get; set; }
        public System.DateTime? EVENT_DATE_TIME { get; set; }
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String POSTED_TO_APM { get; set; }
        public System.Decimal? NOTIFICATION_ID { get; set; }
    }
    [Table("ALL_OBJECTS_AUTOBUILD", Schema = "WNCCRM")]
    public partial class ALL_OBJECTS_AUTOBUILD
    {
        public System.String OWNER { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String OBJECT_TYPE { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime LAST_DDL_TIME { get; set; }
    }
    [Table("APPLICATION_CONFIG", Schema = "WNCCRM")]
    public partial class APPLICATION_CONFIG
    {
        [Key]
        public System.String APPL { get; set; }
        [Key]
        public System.String PARAM { get; set; }
        public System.String VALUE { get; set; }
    }
    [Table("APPLICATION_CONFIG_LOG", Schema = "WNCCRM")]
    public partial class APPLICATION_CONFIG_LOG
    {
        [Key]
        public System.Decimal APPLICATION_CONFIG_LOG_ID { get; set; }
        public System.String NEW_APPL { get; set; }
        public System.String NEW_PARAM { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String OLD_APPL { get; set; }
        public System.String OLD_PARAM { get; set; }
        public System.String OLD_VALUE { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
        public System.String OS_USER { get; set; }
        public System.String MACHINE { get; set; }
        public System.String BUILD { get; set; }
    }
    [Table("APPLICATION_SESSION", Schema = "WNCCRM")]
    public partial class APPLICATION_SESSION
    {
        [Key]
        public System.Decimal APPLICATION_SESSION_ID { get; set; }
        public System.Decimal? LOGIN_HISTORY_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PAGE_TITLE { get; set; }
        public System.String BASE_URL { get; set; }
        public System.String INPUT_PARAMS_CLOB { get; set; }
        public System.String QUERYSTRING { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String SERVICE_FIELD { get; set; }
        public System.String SERVICE_FIELD_VALUE { get; set; }
        public System.String INTERACTION_TYPE { get; set; }
        public System.String INTERACTION_NUMBER { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String USERNAME { get; set; }
        public System.String USERID { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
        public System.String LINK_NAME { get; set; }
        public System.Decimal? APPLICATION_SESSION_SPEC_ID { get; set; }
        public System.String INPUT_PARAMS { get; set; }
        public System.String OUTPUT_PARAMS { get; set; }
    }
    [Table("APPLICATION_SESSION_SPEC", Schema = "WNCCRM")]
    public partial class APPLICATION_SESSION_SPEC
    {
        [Key]
        public System.Decimal APPLICATION_SESSION_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TITLE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String IS_MULTI_ENTRY { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("APS_TEST", Schema = "WNCCRM")]
    public partial class APS_TEST
    {
        public System.Decimal APPLICATION_SESSION_ID { get; set; }
        public System.Decimal? LOGIN_HISTORY_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PAGE_TITLE { get; set; }
        public System.String BASE_URL { get; set; }
        public System.String INPUT_PARAMS { get; set; }
        public System.String QUERYSTRING { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String SERVICE_FIELD { get; set; }
        public System.String SERVICE_FIELD_VALUE { get; set; }
        public System.String INTERACTION_TYPE { get; set; }
        public System.String INTERACTION_NUMBER { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String USERNAME { get; set; }
        public System.String USERID { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
        public System.String LINK_NAME { get; set; }
    }
    [Table("AQ$_QT_CUST_ACCT_REL_I", Schema = "WNCCRM")]
    public partial class AQ_QT_CUST_ACCT_REL_I
    {
        [Key]
        public System.String MSG_QNAME { get; set; }
        [Key]
        public System.String APPNAME { get; set; }
        [Key]
        public System.Decimal MSG_PRIORITY { get; set; }
        [Key]
        public System.DateTime MSG_ENQ_TIME { get; set; }
        public System.String MSG_ENQ_TID { get; set; }
        [Key]
        public System.Decimal MSG_STEP_NO { get; set; }
        [Key]
        public System.Decimal MSG_CHAIN_NO { get; set; }
        [Key]
        public System.Decimal MSG_LOCAL_ORDER_NO { get; set; }
        [Key]
        public System.String MSG_ROWID { get; set; }
        public System.String REMOTE_RECIPIENTS { get; set; }
    }
    [Table("AUDIT_LOG", Schema = "WNCCRM")]
    public partial class AUDIT_LOG
    {
        [Key]
        public System.Decimal AUDIT_LOG_ID { get; set; }
        public System.Decimal TRANSACTION_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.String COLUMN_NAME { get; set; }
        public System.String COLUMN_ALIAS { get; set; }
        public System.String TABLE_ACTION { get; set; }
        public System.Decimal? SOURCE_TBL_ROWID { get; set; }
        public System.String OLD_VALUE { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String ACTION_USER { get; set; }
        public System.DateTime ACTION_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
    }
    [Table("AUDIT_LOG_BACKUP", Schema = "WNCCRM")]
    public partial class AUDIT_LOG_BACKUP
    {
        public System.Decimal AUDIT_LOG_ID { get; set; }
        public System.Decimal TRANSACTION_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.String COLUMN_NAME { get; set; }
        public System.String COLUMN_ALIAS { get; set; }
        public System.String TABLE_ACTION { get; set; }
        public System.Decimal? SOURCE_TBL_ROWID { get; set; }
        public System.String OLD_VALUE { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String ACTION_USER { get; set; }
        public System.DateTime ACTION_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
    }
    [Table("AUTODASHBOARD", Schema = "WNCCRM")]
    public partial class AUTODASHBOARD
    {
        public System.String REQUESTID { get; set; }
        public System.String INCIDENTNUMBER { get; set; }
        public System.String SIMPLERESULT { get; set; }
        public System.String ILECCALLOUT { get; set; }
        public System.String SMARTJACKTEST { get; set; }
        public System.String CSUTEST { get; set; }
        public System.Decimal? RCVDTESTRESULTS { get; set; }
        public System.String RESULTS { get; set; }
        public System.Decimal? STATUSCODE { get; set; }
        public System.String CIRCUITID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String TESTSTATUS { get; set; }
    }
    [Table("BI_DEF_MAP_LKUP", Schema = "WNCCRM")]
    public partial class BI_DEF_MAP_LKUP
    {
        [Key]
        public System.Decimal BI_DEF_MAP_LKUP_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String BASE_URL { get; set; }
        public System.String PARAMETERS_SENT { get; set; }
        public System.String IS_BI_RECORDING_REQUIRED { get; set; }
        public System.String BI_SUMMARY { get; set; }
        public System.String BI_TYPE { get; set; }
        public System.String BI_NUMBER_PARAM_NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("BID_MAP", Schema = "WNCCRM")]
    public partial class BID_MAP
    {
        public System.Decimal? BID_OLD_REF { get; set; }
        public System.Decimal? BID_NEW { get; set; }
    }
    [Table("BILL_DATE", Schema = "WNCCRM")]
    public partial class BILL_DATE
    {
        public System.Decimal? IDENTIFIER { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
    }
    [Table("BILL_ITEMS_BROADVIEW", Schema = "WNCCRM")]
    public partial class BILL_ITEMS_BROADVIEW
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String PARTNER_NAME { get; set; }
    }
    [Table("BILL_ITEMS_CAMS", Schema = "WNCCRM")]
    public partial class BILL_ITEMS_CAMS
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String PARTNER_NAME { get; set; }
    }
    [Table("BILL_ITEMS_CAMS_STG", Schema = "WNCCRM")]
    public partial class BILL_ITEMS_CAMS_STG
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
        public System.String DATA_INSERTED_USER { get; set; }
        public System.DateTime? DATA_INSERTED_DATE { get; set; }
        public System.String DATA_UPDATED_USER { get; set; }
        public System.DateTime? DATA_UPDATED_DATE { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String PARTNER_NAME { get; set; }
    }
    [Table("BILL_ITEMS_REVCHAIN", Schema = "WNCCRM")]
    public partial class BILL_ITEMS_REVCHAIN
    {
        public System.Int64? SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String PARTNER_NAME { get; set; }
    }
    [Table("BILL_ITEMS_REVCHAIN_STG", Schema = "WNCCRM")]
    public partial class BILL_ITEMS_REVCHAIN_STG
    {
        public System.Int64? SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
        public System.String DATA_INSERTED_USER { get; set; }
        public System.DateTime? DATA_INSERTED_DATE { get; set; }
        public System.String DATA_UPDATED_USER { get; set; }
        public System.DateTime? DATA_UPDATED_DATE { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String PARTNER_NAME { get; set; }
    }
    [Table("BILL_PREVIEW", Schema = "WNCCRM")]
    public partial class BILL_PREVIEW
    {
        [Key]
        public System.Decimal BILL_PREVIEW_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("BILL_PREVIEW_BUS_ARTIFACT", Schema = "WNCCRM")]
    public partial class BILL_PREVIEW_BUS_ARTIFACT
    {
        [Key]
        public System.Decimal BILL_PREVIEW_BUS_ARTIFACT_ID { get; set; }
        public System.Decimal? BUS_ARTIFACT_ID { get; set; }
        public System.Decimal? BILL_PREVIEW_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("BILLING_PROFILE", Schema = "WNCCRM")]
    public partial class BILLING_PROFILE
    {
        [Key]
        public System.Decimal BILLING_PROFILE_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String BILL_FREQUENCY { get; set; }
        public System.Int16? BILL_CYCLE { get; set; }
        public System.Int16? BILL_MONTHS { get; set; }
        public System.String PAYMENT_TERMS { get; set; }
        public System.String PAPER_BILL_WAIVER { get; set; }
        public System.String CURRENCY { get; set; }
        public System.Double? PREPAID_AMOUNT { get; set; }
        public System.String TAX_PLAN { get; set; }
        public System.String IS_BILLABLE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String FILE_FORMAT { get; set; }
        public System.String INVOICE_BRANDING { get; set; }
        public System.String IS_TAX_EXEMPT { get; set; }
        public System.String INVOICE_DELIVERY_EMAIL_ADDRESS { get; set; }
        public System.String JURISDICTION_DEFAULT { get; set; }
    }
    [Table("BILLING_PROFILE_JURIS", Schema = "WNCCRM")]
    public partial class BILLING_PROFILE_JURIS
    {
        [Key]
        public System.Decimal BILLING_PROFILE_JURIS_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String JURISDICTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("BOB_CONTACTS_WF_FILE_CHILD", Schema = "WNCCRM")]
    public partial class BOB_CONTACTS_WF_FILE_CHILD
    {
        public System.Decimal? BUSINESS_CRM_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? PARENT_SL_GID { get; set; }
        public System.Decimal? SL_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ATC_ACCOUNT_NUMBER { get; set; }
        public System.String CONTACT_OWNER { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String CONTACT_RECORD_TYPE { get; set; }
        public System.String MAILING_ADDRESS1 { get; set; }
        public System.String MAILING_ADDRESS2 { get; set; }
        public System.String MAILING_CITY { get; set; }
        public System.String MAILING_STATE { get; set; }
        public System.String MAILING_POSTAL_CODE { get; set; }
        public System.String MAILING_COUNTRY { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String PHONE_EXTENSION { get; set; }
        public System.String MOBILE_NUMBER { get; set; }
        public System.String HOME_PHONE { get; set; }
        public System.String FAX_NUMBER { get; set; }
        public System.String EMAIL { get; set; }
        public System.String EMAIL_OPT_OUT { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String CONTACT_TYPE { get; set; }
        public System.String WF_CONTACT_TYPE { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String EMAIL2 { get; set; }
        public System.String PRIMARY_ACCOUNT_MANAGER_ID { get; set; }
    }
    [Table("BOOKMARKED_ORGANIZATION", Schema = "WNCCRM")]
    public partial class BOOKMARKED_ORGANIZATION
    {
        [Key]
        public System.String BOOKMARKEDORGANISATIONID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String USERNAME { get; set; }
        public System.String CUSTOMERNAME { get; set; }
        public System.String LOCATIONNAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ACCOUNTNUMBER { get; set; }
        public System.String BOOKMARKCOMMENT { get; set; }
    }
    [Table("BRAS_SNAPSHOT", Schema = "WNCCRM")]
    public partial class BRAS_SNAPSHOT
    {
        public System.Decimal? ATM_CELLS_DOWN { get; set; }
        public System.Decimal? ATM_CELLS_UP { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("BROADWORKS_SUMMARY", Schema = "WNCCRM")]
    public partial class BROADWORKS_SUMMARY
    {
        [Key]
        public System.Decimal BROADWORKS_SUMMARY_ID { get; set; }
        public System.String ENTERPRISE_ID { get; set; }
        public System.String IS_POOLING { get; set; }
        public System.String GROUP { get; set; }
        public System.Decimal? CALL_PATH { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("BROADWORKS_XREF", Schema = "WNCCRM")]
    public partial class BROADWORKS_XREF
    {
        [Key]
        public System.Decimal BROADWORKS_XREF_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ENTERPRISE_ID { get; set; }
        public System.String GROUP_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? SERV_ITEM_ID { get; set; }
    }
    [Table("BUS_ARTIFACT", Schema = "WNCCRM")]
    public partial class BUS_ARTIFACT
    {
        [Key]
        public System.Decimal BUS_ARTIFACT_ID { get; set; }
        public System.String DETAILS { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DOMAIN { get; set; }
        public System.String LOCATION { get; set; }
    }
    [Table("BUS_INT_AGREEMENT_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class BUS_INT_AGREEMENT_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("BUS_INT_PARTY_ROLE", Schema = "WNCCRM")]
    public partial class BUS_INT_PARTY_ROLE
    {
        [Key]
        public System.Decimal BUS_INT_PARTY_ROLE_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String CUST_ACCT_PARTY_ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("BUS_INTERACTION", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION
    {
        [Key]
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.String AGREEMENT_NUMBER { get; set; }
        public System.Int16? AGREEMENT_TERM { get; set; }
        public System.String NAME { get; set; }
        public System.DateTime? CANCEL_DATE { get; set; }
        public System.DateTime? COMPLETED_DATE { get; set; }
        public System.String CKR { get; set; }
        public System.String OWNER { get; set; }
        public System.String INTERACTION_ACTIVITY { get; set; }
        public System.DateTime? FORECAST_CLOSE_DATE { get; set; }
        public System.Decimal? NON_RECURRING_REVENUE { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String CONTACT_NAME { get; set; }
        public System.String OCN { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
        public System.DateTime? FOC_DATE { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String PON { get; set; }
        public System.String PRIORITY { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.Decimal? PROBABILITY { get; set; }
        public System.String PRODUCT_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? STATUS_DATE { get; set; }
        public System.Decimal? QUOTE_PACKAGE_ID { get; set; }
        public System.String SUBJECT { get; set; }
        public System.Decimal? RECURRING_REVENUE { get; set; }
        public System.String TYPE { get; set; }
        public System.Decimal? VERSION { get; set; }
        public System.DateTime? WON_DATE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_NUMBER { get; set; }
        public System.DateTime? AGREEMENT_SIGN_DATE { get; set; }
        public System.String IS_COORDINATED { get; set; }
        public System.String IS_EXPEDITED { get; set; }
        public System.String IS_ADV_CONFIG { get; set; }
        public System.String IS_ADV_CONFIG_USER_MAINTAINED { get; set; }
        public System.String PROVISIONING_PLAN_NAME { get; set; }
        public System.DateTime? SUBMITTED_DATE { get; set; }
        public System.String PROVISIONING_PLAN_TYPE { get; set; }
        public System.DateTime? CUSTOMER_DESIRED_DUE_DATE { get; set; }
        public System.String PSR_COORDINATOR { get; set; }
        public System.String CUST_DESIRED_DUE_DATE_IS_REQ { get; set; }
        public System.String COORDINATOR { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.Decimal? ORIGIN_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? PARENT_BUS_INTERACTION_ID { get; set; }
        public System.String BUS_INTERACTION_REF { get; set; }
        public System.String TICKET_NUMBER { get; set; }
        public System.Decimal? ADMIN_STATE_LKUP_ID { get; set; }
        public System.String BILLING_ACCOUNT_NO { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_SUPPORT_TICKET { get; set; }
        public System.String SUPPLEMENT_TYPE { get; set; }
        public System.String IS_FAST_TRACK { get; set; }
        public System.DateTime? OBJECT_STATE_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.DateTime? ADMIN_STATE_DATE { get; set; }
        public System.String IS_PROOF_OF_CONCEPT { get; set; }
        public System.String DISTRIBUTION_CHANNEL { get; set; }
    }
    [Table("BUS_INTERACTION_AGREEMENT", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION_AGREEMENT
    {
        [Key]
        public System.Decimal BUS_INTERACTION_AGREEMENT_ID { get; set; }
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("BUS_INTERACTION_BUS_ARTIFACT", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION_BUS_ARTIFACT
    {
        [Key]
        public System.Decimal BUS_INTERACTN_BUS_ARTIFACT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? BUS_ARTIFACT_ID { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("BUS_INTERACTION_REF", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION_REF
    {
        [Key]
        public System.Decimal BUS_INTERACTION_REF_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("BUS_INTERACTION_REL", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION_REL
    {
        [Key]
        public System.Decimal BUS_INTERACTION_REL_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_REL_SPEC_ID { get; set; }
        public System.Decimal CHILD_BUS_INTERACTION_ID { get; set; }
        public System.Decimal PARENT_BUS_INTERACTION_ID { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("BUS_INTERACTION_REL_SPEC", Schema = "WNCCRM")]
    public partial class BUS_INTERACTION_REL_SPEC
    {
        [Key]
        public System.Decimal BUS_INTERACTION_REL_SPEC_ID { get; set; }
        public System.String CHILD_ENTITY_TYPE { get; set; }
        public System.String PARENT_ENTITY_TYPE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("BUS_SIZE_UPD_WF", Schema = "WNCCRM")]
    public partial class BUS_SIZE_UPD_WF
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WINFORCE_ID { get; set; }
        public System.String ID_TYPE { get; set; }
        public System.String BILLING_SYSTEM { get; set; }
        public System.String LOCATION_ACCOUNT_ID { get; set; }
        public System.String BILLABLE_ACCOUNT_ID { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CUSTOMER_DIVISION { get; set; }
        public System.DateTime? RUN_DATE { get; set; }
    }
    [Table("BUS_SYSTEM", Schema = "WNCCRM")]
    public partial class BUS_SYSTEM
    {
        [Key]
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String UNIFIED_CODE_VIEW { get; set; }
    }
    [Table("BUS_SYSTEM_SETTING", Schema = "WNCCRM")]
    public partial class BUS_SYSTEM_SETTING
    {
        [Key]
        public System.Decimal BUS_SYSTEM_SETTING_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.Decimal SETTING_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("CABS_BILLING_MONTHLY", Schema = "WNCCRM")]
    public partial class CABS_BILLING_MONTHLY
    {
        public System.String CIRCUIT_EC_ID { get; set; }
        public System.String ACNA_CODE { get; set; }
        public System.String CARRIER_CODE { get; set; }
        public System.String CARRIER_TYPE { get; set; }
        public System.String CIC_CODE { get; set; }
        public System.String COMP_DESC { get; set; }
        public System.String COMP_NMBR { get; set; }
        public System.String NAME { get; set; }
        public System.String ADDR { get; set; }
        public System.String PO_BOX { get; set; }
        public System.String STATE { get; set; }
        public System.String CITY { get; set; }
        public System.String ZIP { get; set; }
        public System.Decimal? PHONE_NMBR { get; set; }
        public System.String BAN { get; set; }
        public System.String FLAG { get; set; }
    }
    [Table("CABS_CARRIER_LOAD", Schema = "WNCCRM")]
    public partial class CABS_CARRIER_LOAD
    {
        public System.Decimal? ENTERPRISE_CARRIER_ID { get; set; }
        public System.String ENTERPRISE_CARRIER_NAME { get; set; }
        public System.String BILLING_ID { get; set; }
        public System.String BILLING_SYSTEM { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String LAST_MODIFIED_USER { get; set; }
    }
    [Table("CAID", Schema = "WNCCRM")]
    public partial class CAID
    {
        public System.String CUST_CAMS_ID { get; set; }
        public System.DateTime? EFF_DATE { get; set; }
        public System.String ADDR_ID { get; set; }
    }
    [Table("CAMP_API_CALL_LOG", Schema = "WNCCRM")]
    public partial class CAMP_API_CALL_LOG
    {
        public System.Decimal? GID { get; set; }
        public System.DateTime? REQUEST_TIMESTAMP { get; set; }
        public System.String REQUEST { get; set; }
        public System.DateTime? RESPONSE_TIMESTAMP { get; set; }
        public System.String RESPONSE { get; set; }
    }
    [Table("CAMP_LOG", Schema = "WNCCRM")]
    public partial class CAMP_LOG
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String RET_MSG { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
    }
    [Table("CAMP_VALIDATION_COND_RULES", Schema = "WNCCRM")]
    public partial class CAMP_VALIDATION_COND_RULES
    {
        public System.String FIELD_NAME { get; set; }
        public System.String SUB_FIELD_NAME { get; set; }
        public System.Decimal? NUM_OF_CONDS { get; set; }
        public System.String VALIDATION_SQL { get; set; }
        public System.String COND_FIELD_1 { get; set; }
        public System.String COND_SUB_FIELD_1 { get; set; }
        public System.String COND_FIELD_2 { get; set; }
        public System.String COND_SUB_FIELD_2 { get; set; }
        public System.String COND_FIELD_3 { get; set; }
        public System.String COND_SUB_FIELD_3 { get; set; }
        public System.String COND_FIELD_4 { get; set; }
        public System.String COND_SUB_FIELD_4 { get; set; }
        public System.String COND_FIELD_5 { get; set; }
        public System.String COND_SUB_FIELD_5 { get; set; }
        public System.String COND_FIELD_6 { get; set; }
        public System.String COND_SUB_FIELD_6 { get; set; }
        public System.String COND_FIELD_7 { get; set; }
        public System.String COND_SUB_FIELD_7 { get; set; }
        public System.String ERROR_CONTEXT { get; set; }
    }
    [Table("CAMP_VALIDATION_RULES", Schema = "WNCCRM")]
    public partial class CAMP_VALIDATION_RULES
    {
        public System.String FIELD_NAME { get; set; }
        public System.String SUB_FIELD_NAME { get; set; }
        public System.String IS_REQUIRED { get; set; }
        public System.String IS_BOOLEAN { get; set; }
        public System.String IS_EMAIL { get; set; }
        public System.String REF_OBJ_TYPE { get; set; }
    }
    [Table("CAMS_BILLING_REL_RECONCILE_WLY", Schema = "WNCCRM")]
    public partial class CAMS_BILLING_REL_RECONCILE_WLY
    {
        public System.String OBJECT_STATE { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.Decimal PARENT_GID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.Decimal CHILD_GID { get; set; }
    }
    [Table("CAMS_DUPLICATE_GIDS", Schema = "WNCCRM")]
    public partial class CAMS_DUPLICATE_GIDS
    {
        [Key]
        public System.Decimal CAMS_DUP_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.String CUST_ADVOCATE_ID { get; set; }
        public System.String CUST_ADVOCATE_NAME { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String WC_EMAIL_ADDRESS { get; set; }
        public System.String WFC_EMAIL_ADDRESS { get; set; }
        public System.String FIRSTNAME { get; set; }
        public System.String LASTNAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("CAMS_EMP_ID", Schema = "WNCCRM")]
    public partial class CAMS_EMP_ID
    {
        public System.String CAMS_ID { get; set; }
        public System.String EMP_ID { get; set; }
        public System.String CAMS_ID_2 { get; set; }
    }
    [Table("CAMS_PARENTCHILDREL", Schema = "WNCCRM")]
    public partial class CAMS_PARENTCHILDREL
    {
        public System.String BENT_CAMS_ID { get; set; }
        public System.Decimal PARENT_GID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.Decimal CHILD_GID { get; set; }
    }
    [Table("CAMS_SERVICE_ADDR_STG", Schema = "WNCCRM")]
    public partial class CAMS_SERVICE_ADDR_STG
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String WINNING_SELECTION { get; set; }
        public System.String NEW_SVC_ADDRESS { get; set; }
        public System.String CRM_SERVICE_ADDRESS { get; set; }
        public System.Decimal? MTCH_PCT { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String CITY_NAME { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String ZIP_CODE { get; set; }
    }
    [Table("CARE_CASE", Schema = "WNCCRM")]
    public partial class CARE_CASE
    {
        [Key]
        public System.Decimal CARE_CASE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CARE_CASE_QUEUE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String ALT_CONTACT_FIRST_NAME { get; set; }
        public System.String ALT_CONTACT_LAST_NAME { get; set; }
        public System.String ALT_CONTACT_PHONE { get; set; }
        public System.String ALT_CONTACT_PHONE_EXT { get; set; }
        public System.String ALT_CONTACT_PHONE_TYPE { get; set; }
        public System.String ALT_CONTACT_EMAIL { get; set; }
        public System.String TIER_CODE_1 { get; set; }
        public System.String TIER_CODE_2 { get; set; }
        public System.String TIER_CODE_3 { get; set; }
        public System.String TIER_CODE_4 { get; set; }
        public System.String TIER_CODE_5 { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String STATUS { get; set; }
        public System.String SUBSTATUS { get; set; }
        public System.String DISPOSITION { get; set; }
        public System.DateTime? TIMER_DATE { get; set; }
        public System.String TIMER_DESCRIPTION { get; set; }
        public System.String ASSIGNED_USER { get; set; }
        public System.DateTime? ASSIGNED_DATE { get; set; }
        public System.String IS_ESCALATED { get; set; }
        public System.String ESCALATED_USER { get; set; }
        public System.DateTime? ESCALATED_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CLOSED_USER { get; set; }
        public System.DateTime? CLOSED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? LOE { get; set; }
        public System.String SOURCE { get; set; }
        public System.String OFFSHORE_TEAM { get; set; }
        public System.String CONTACT_IS_CUSTOMER_ADVOCATE { get; set; }
        public System.Double? ESTIMATED_DISPUTE_AMOUNT { get; set; }
        public System.Double? TOTAL_CREDIT_ISSUED { get; set; }
        public System.String CONTACT_UPDATED { get; set; }
        public System.Decimal? OFFER_ID { get; set; }
        public System.String OFFER_AVAILABILITY { get; set; }
        public System.String BILLING_ACCOUNT_ID { get; set; }
        public System.String OFFER_SUBMITTED { get; set; }
        public System.Decimal? OFFER_ID_DECLINED { get; set; }
        public System.String OFFER_DECLINED { get; set; }
        public System.Decimal? CARE_CASE_QUEUE_SUB_ID { get; set; }
        public System.String AUTO_ASSIGNED { get; set; }
        public System.String CREDIT_REQUEST_TYPE { get; set; }
        public System.String DISPUTE_REASON { get; set; }
        public System.String DISPUTE_REASON_DETAIL { get; set; }
        public System.Decimal? ACCT_NBR_FOR_BALANCETRANSFER { get; set; }
        public System.String CREDIT_ACTION { get; set; }
        public System.String CREDIT_ACTION_DETAIL { get; set; }
        public System.String DISPUTE_ROOT_CAUSE { get; set; }
        public System.String RESPONSIBLE_DEPARTMENT { get; set; }
        public System.String INVESTIGATION_RESULT { get; set; }
        public System.String RESPONSIBLE_EMPLOYEE_NAME { get; set; }
        public System.String RESPONSIBLE_EMPLOYEE_ID { get; set; }
        public System.Double? CONTRACTUAL_AMOUNT { get; set; }
        public System.Double? GOODWILL_AMOUNT { get; set; }
        public System.DateTime? ISSUE_START_DATE { get; set; }
        public System.DateTime? DISPUTED_DATE { get; set; }
        public System.DateTime? ISSUE_END_DATE { get; set; }
        public System.String LEVEL_1_APPROVAL { get; set; }
        public System.String LEVEL_2_APPROVAL { get; set; }
        public System.String LEVEL_3_APPROVAL { get; set; }
        public System.String LEVEL_4_APPROVAL { get; set; }
        public System.String IS_PROJECT { get; set; }
        public System.String WAS_REOPENED { get; set; }
        public System.String IMPACTED_INVOICES { get; set; }
    }
    [Table("CARE_CASE_AUDIT_LOG", Schema = "WNCCRM")]
    public partial class CARE_CASE_AUDIT_LOG
    {
        [Key]
        public System.Decimal CARE_CASE_AUDIT_LOG_ID { get; set; }
        public System.String ACTION { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.String COLUMN_NAME { get; set; }
        public System.String COLUMN_ALIAS { get; set; }
        public System.Decimal? ROW_ID { get; set; }
        public System.String OLD_VALUE { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String ACTION_USER { get; set; }
        public System.DateTime? ACTION_DATE { get; set; }
        public System.Byte[] TRANSACTION_ID { get; set; }
    }
    [Table("CARE_CASE_AUTO_ASSIGN", Schema = "WNCCRM")]
    public partial class CARE_CASE_AUTO_ASSIGN
    {
        [Key]
        public System.Int64 CC_AUTO_ASSIGN_ID { get; set; }
        public System.String USER_ID { get; set; }
        public System.String IS_ACTIVE { get; set; }
        public System.String CC_QUEUE_IDS { get; set; }
        public System.String BILLING_SYSTEMS { get; set; }
        public System.String PRIOR_COMPANIES { get; set; }
        public System.String TIER_1_CC_TIER_IDS { get; set; }
        public System.Int16? MAX_CASE_COUNT { get; set; }
        public System.String IS_CHECKED_IN { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OPT_IN { get; set; }
    }
    [Table("CARE_CASE_QUEUE", Schema = "WNCCRM")]
    public partial class CARE_CASE_QUEUE
    {
        [Key]
        public System.Decimal CARE_CASE_QUEUE_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String QUEUE_TYPE { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EMPLOYEE_LDAP_GROUP_ASSIGN { get; set; }
        public System.String EMPLOYEE_LDAP_GROUP_ESCALATE { get; set; }
    }
    [Table("CARE_CASE_QUEUE_SUB", Schema = "WNCCRM")]
    public partial class CARE_CASE_QUEUE_SUB
    {
        [Key]
        public System.Decimal CARE_CASE_QUEUE_SUB_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? CARE_CASE_QUEUE_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CARE_CASE_TEMPLATE", Schema = "WNCCRM")]
    public partial class CARE_CASE_TEMPLATE
    {
        [Key]
        public System.Decimal TEMPLATE_ID { get; set; }
        public System.String TEMPLATE_NAME { get; set; }
        public System.String TEMPLATE_DESCRIPTION { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("CARE_CASE_TIER", Schema = "WNCCRM")]
    public partial class CARE_CASE_TIER
    {
        [Key]
        public System.Decimal CARE_CASE_TIER_ID { get; set; }
        public System.String TIER_CODE { get; set; }
        public System.Decimal? PARENT_CARE_CASE_TIER_ID { get; set; }
        public System.Decimal? TIER_LEVEL { get; set; }
        public System.Decimal? CARE_CASE_QUEUE_ID { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CARE_CASE_TIER_ACTION", Schema = "WNCCRM")]
    public partial class CARE_CASE_TIER_ACTION
    {
        [Key]
        public System.Decimal CARE_CASE_TIER_ACTION_ID { get; set; }
        public System.Decimal CARE_CASE_TIER_ID { get; set; }
        public System.String ACTION_TYPE { get; set; }
        public System.String ACTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String PLATFORM { get; set; }
    }
    [Table("CARE_CASE_USER_SEARCH", Schema = "WNCCRM")]
    public partial class CARE_CASE_USER_SEARCH
    {
        [Key]
        public System.Decimal CARE_CASE_USER_SEARCH_ID { get; set; }
        public System.String USER_ID { get; set; }
        public System.String CRM_CONTEXT { get; set; }
        public System.String SEARCH_OBJECT_XML { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CARE_CASE_WORKLOG", Schema = "WNCCRM")]
    public partial class CARE_CASE_WORKLOG
    {
        [Key]
        public System.Decimal CARE_CASE_WORKLOG_ID { get; set; }
        public System.Decimal CARE_CASE_ID { get; set; }
        public System.String WORKLOG_TYPE { get; set; }
        public System.String SOURCE { get; set; }
        public System.String VIEW_ACCESS { get; set; }
        public System.String NOTE_SUMMARY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? EMAIL_COMMUNICATION_ID { get; set; }
        public System.String NOTE { get; set; }
    }
    [Table("CARE_CASE_XF_TEMPLATE", Schema = "WNCCRM")]
    public partial class CARE_CASE_XF_TEMPLATE
    {
        public System.Decimal CARE_CASE_ID { get; set; }
        public System.Decimal CARE_CASE_WORKLOGID { get; set; }
        public System.Decimal TEMPLATE_ID { get; set; }
        public System.String TEMPLATE_DESCRIPTION { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("CARECASEID", Schema = "WNCCRM")]
    public partial class CARECASEID
    {
        public System.Decimal? CARE_CASE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ASSIGNED_USER_DISPLAY { get; set; }
        public System.String CREATED_USER_DISPLAY { get; set; }
        public System.String CARE_CASE_QUEUE_NAME { get; set; }
        public System.String ASSIGNED_USER_SUPERVISOR { get; set; }
    }
    [Table("CASH_REC", Schema = "WNCCRM")]
    public partial class CASH_REC
    {
        public System.Decimal? IDENTIFIER { get; set; }
        public System.DateTime? REC_DATE { get; set; }
    }
    [Table("CAV_CAMS_BENT_LOOKUP", Schema = "WNCCRM")]
    public partial class CAV_CAMS_BENT_LOOKUP
    {
        public System.String ACCOUNT_NAME { get; set; }
        public System.String ACCT_TN { get; set; }
        public System.String CONTROL_DATE { get; set; }
        public System.String CAMS_ACCT_ID { get; set; }
        public System.String APTIS_ACCT_ID { get; set; }
        public System.String DISC_DATE { get; set; }
        public System.String CAMS_BILL_CYCLE { get; set; }
        public System.String APTIS_BILL_CYCLE { get; set; }
        public System.String APTIS_COMPANY_CODE { get; set; }
        public System.String BENT_TYPE { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String TALK_AMERICA_ACCT { get; set; }
        public System.String LPP_CALC { get; set; }
        public System.String STATE { get; set; }
        public System.String DATABASE_REGION { get; set; }
        public System.String ORG_ID { get; set; }
        public System.String TAX_JURISDICTION { get; set; }
    }
    [Table("CAV_CAMS_BENT_LOOKUP_REJECT", Schema = "WNCCRM")]
    public partial class CAV_CAMS_BENT_LOOKUP_REJECT
    {
        public System.String ACCOUNT_NAME { get; set; }
        public System.String ACCT_TN { get; set; }
        public System.String CONTROL_DATE { get; set; }
        public System.String CAMS_ACCT_ID { get; set; }
        public System.String APTIS_ACCT_ID { get; set; }
        public System.String DISC_DATE { get; set; }
        public System.String CAMS_BILL_CYCLE { get; set; }
        public System.String APTIS_BILL_CYCLE { get; set; }
        public System.String APTIS_COMPANY_CODE { get; set; }
        public System.String BENT_TYPE { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String TALK_AMERICA_ACCT { get; set; }
        public System.String LPP_CALC { get; set; }
        public System.String STATE { get; set; }
        public System.String DATABASE_REGION { get; set; }
        public System.String ORG_ID { get; set; }
        public System.String TAX_JURISDICTION { get; set; }
    }
    [Table("CAV_CAMS_SENT_LOOKUP", Schema = "WNCCRM")]
    public partial class CAV_CAMS_SENT_LOOKUP
    {
        public System.String ACCOUNT_NAME { get; set; }
        public System.String ACCT_TN { get; set; }
        public System.String CONTROL_DATE { get; set; }
        public System.String SENT_ACCT_ID { get; set; }
        public System.String CUST_ACCT_ID { get; set; }
        public System.String BENT_TN { get; set; }
        public System.String BENT_ACCT_ID { get; set; }
        public System.String APTIS_ACCT_ID { get; set; }
        public System.String DISC_DATE { get; set; }
        public System.String CAMS_BILL_CYCLE { get; set; }
        public System.String APTIS_BILL_CYCLE { get; set; }
        public System.String APTIS_COMPANY_CODE { get; set; }
        public System.String BENT_TYPE { get; set; }
        public System.String SENT_TYPE { get; set; }
        public System.String TALK_AMERICA_ACCT { get; set; }
        public System.String STATE { get; set; }
        public System.String DATABASE_REGION { get; set; }
        public System.String ORG_ID { get; set; }
        public System.String TAX_JURISDICTION { get; set; }
    }
    [Table("CAV_CAMS_SENT_LOOKUP_REJECT", Schema = "WNCCRM")]
    public partial class CAV_CAMS_SENT_LOOKUP_REJECT
    {
        public System.String ACCOUNT_NAME { get; set; }
        public System.String ACCT_TN { get; set; }
        public System.String CONTROL_DATE { get; set; }
        public System.String SENT_ACCT_ID { get; set; }
        public System.String CUST_ACCT_ID { get; set; }
        public System.String BENT_TN { get; set; }
        public System.String BENT_ACCT_ID { get; set; }
        public System.String APTIS_ACCT_ID { get; set; }
        public System.String DISC_DATE { get; set; }
        public System.String CAMS_BILL_CYCLE { get; set; }
        public System.String APTIS_BILL_CYCLE { get; set; }
        public System.String APTIS_COMPANY_CODE { get; set; }
        public System.String BENT_TYPE { get; set; }
        public System.String SENT_TYPE { get; set; }
        public System.String TALK_AMERICA_ACCT { get; set; }
        public System.String STATE { get; set; }
        public System.String DATABASE_REGION { get; set; }
        public System.String ORG_ID { get; set; }
        public System.String TAX_JURISDICTION { get; set; }
    }
    [Table("CAV_MBSC_ACCOUNT", Schema = "WNCCRM")]
    public partial class CAV_MBSC_ACCOUNT
    {
        public System.String ACCOUNTID { get; set; }
        public System.String CONTACTID { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String ACCT_ROLES { get; set; }
    }
    [Table("CAVALIER_GID_ASSIGN", Schema = "WNCCRM")]
    public partial class CAVALIER_GID_ASSIGN
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ACCOUNT_NUMBER { get; set; }
        public System.String ACCOUNT_STATUS { get; set; }
        [Key]
        public System.Decimal CAVALIER_GID_ASSIGN_ID { get; set; }
    }
    [Table("CCT_ORDER_MOVE_STATUS", Schema = "WNCCRM")]
    public partial class CCT_ORDER_MOVE_STATUS
    {
        public System.Decimal? KEY { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? SUBMISSION_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("CM_BUS_INTERACTION_PREF", Schema = "WNCCRM")]
    public partial class CM_BUS_INTERACTION_PREF
    {
        [Key]
        public System.Decimal BUS_INTERACTION_PREF_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUSINESS_FUNCTION_ID { get; set; }
        public System.String CONTACT_TYPE { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CM_BUSINESS_FUNCTION", Schema = "WNCCRM")]
    public partial class CM_BUSINESS_FUNCTION
    {
        [Key]
        public System.Decimal BUSINESS_FUNCTION_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DISPLAY_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CM_BUSINESS_FUNCTION_MEDIUM", Schema = "WNCCRM")]
    public partial class CM_BUSINESS_FUNCTION_MEDIUM
    {
        [Key]
        public System.Decimal BUSINESS_FUNCTION_MEDIUM_ID { get; set; }
        public System.Decimal BUSINESS_FUNCTION_ID { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String IS_DEFAULT { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("COJACK_ADDRESS", Schema = "WNCCRM")]
    public partial class COJACK_ADDRESS
    {
        [Key]
        public System.Decimal COJACK_ADDRESS_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String COJACK { get; set; }
        public System.String COJACK_SVC_TYPE { get; set; }
        public System.String COJACK_LOC1 { get; set; }
        public System.String COJACK_LOC2 { get; set; }
        public System.String COJACK_ADDR_UNIT_NUM { get; set; }
        public System.String COJACK_NOTES { get; set; }
        public System.Decimal? DF_ADDRESS_ID { get; set; }
        public System.String ADDRESS { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String COJACK_ADDTL_LN_PH_NUM { get; set; }
        public System.String COJACK_ADDTL_LN { get; set; }
        public System.String COJACK_LOC1_ADDTL_LN { get; set; }
        public System.String COJACK_LOC2_ADDTL_LN { get; set; }
    }
    [Table("COLLECTION_AGENCY_ACTION", Schema = "WNCCRM")]
    public partial class COLLECTION_AGENCY_ACTION
    {
        [Key]
        public System.Decimal COLL_AGENCY_ACTION_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String AGENCY { get; set; }
        public System.DateTime? DATE_SENT { get; set; }
        public System.Double? COLLECTION_AMOUNT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("COMMAND_SECURITY", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY
    {
        [Key]
        public System.Decimal COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal GROUPBYID { get; set; }
        public System.Decimal ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String IT_CONTACT_NAME { get; set; }
        public System.String TROUBLESHOOTING_NOTE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String ENTITY_TYPE { get; set; }
    }
    [Table("COMMAND_SECURITY_20180921", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY_20180921
    {
        public System.Decimal COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal GROUPBYID { get; set; }
        public System.Decimal ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String IT_CONTACT_NAME { get; set; }
        public System.String TROUBLESHOOTING_NOTE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String ENTITY_TYPE { get; set; }
    }
    [Table("COMMAND_SECURITY_20181012", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY_20181012
    {
        public System.Decimal COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal GROUPBYID { get; set; }
        public System.Decimal ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String IT_CONTACT_NAME { get; set; }
        public System.String TROUBLESHOOTING_NOTE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String ENTITY_TYPE { get; set; }
    }
    [Table("COMMAND_SECURITY_20181019", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY_20181019
    {
        public System.Decimal COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal GROUPBYID { get; set; }
        public System.Decimal ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String IT_CONTACT_NAME { get; set; }
        public System.String TROUBLESHOOTING_NOTE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String ENTITY_TYPE { get; set; }
    }
    [Table("COMMAND_SECURITY_LOG", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY_LOG
    {
        public System.Decimal? NEW_COMMAND_SECURITY_ID { get; set; }
        public System.String NEW_PAGE_NAME { get; set; }
        public System.String NEW_COMMAND_TYPE { get; set; }
        public System.String NEW_COMMAND_ITEM_LABEL { get; set; }
        public System.String NEW_COMMAND_ITEM_ID { get; set; }
        public System.Decimal? NEW_SECURITY_FUNCTION_ID { get; set; }
        public System.String NEW_CREATE_USERID { get; set; }
        public System.DateTime? NEW_CREATE_DATE { get; set; }
        public System.String NEW_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? NEW_LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? NEW_GROUPBYID { get; set; }
        public System.Decimal? NEW_ORDERBYID { get; set; }
        public System.String NEW_FLAG_ENABLED { get; set; }
        public System.String NEW_COMMAND_ITEM_URL { get; set; }
        public System.Decimal? NEW_FORMID { get; set; }
        public System.String NEW_URL_PARAMETERS { get; set; }
        public System.String NEW_IT_CONTACT_NAME { get; set; }
        public System.String NEW_TROUBLESHOOTING_NOTE { get; set; }
        public System.String NEW_PAGE_TRANSITION { get; set; }
        public System.Decimal? OLD_COMMAND_SECURITY_ID { get; set; }
        public System.String OLD_PAGE_NAME { get; set; }
        public System.String OLD_COMMAND_TYPE { get; set; }
        public System.String OLD_COMMAND_ITEM_LABEL { get; set; }
        public System.String OLD_COMMAND_ITEM_ID { get; set; }
        public System.Decimal? OLD_SECURITY_FUNCTION_ID { get; set; }
        public System.String OLD_CREATE_USERID { get; set; }
        public System.DateTime? OLD_CREATE_DATE { get; set; }
        public System.String OLD_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? OLD_LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? OLD_GROUPBYID { get; set; }
        public System.Decimal? OLD_ORDERBYID { get; set; }
        public System.String OLD_FLAG_ENABLED { get; set; }
        public System.String OLD_COMMAND_ITEM_URL { get; set; }
        public System.Decimal? OLD_FORMID { get; set; }
        public System.String OLD_URL_PARAMETERS { get; set; }
        public System.String OLD_IT_CONTACT_NAME { get; set; }
        public System.String OLD_TROUBLESHOOTING_NOTE { get; set; }
        public System.String OLD_PAGE_TRANSITION { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
        public System.Decimal? LOG_ID { get; set; }
        public System.String OLD_IS_MOBILE { get; set; }
        public System.String NEW_IS_MOBILE { get; set; }
        public System.String NEW_ENTITY_TYPE { get; set; }
        public System.String OLD_ENTITY_TYPE { get; set; }
    }
    [Table("COMMAND_SECURITY_PROD", Schema = "WNCCRM")]
    public partial class COMMAND_SECURITY_PROD
    {
        public System.Decimal COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal GROUPBYID { get; set; }
        public System.Decimal ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String IT_CONTACT_NAME { get; set; }
        public System.String TROUBLESHOOTING_NOTE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String UNIQUETAG { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
    }
    [Table("CONN_SERV_ROLE_TYE_LKUP", Schema = "WNCCRM")]
    public partial class CONN_SERV_ROLE_TYE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("CONNECTION", Schema = "WNCCRM")]
    public partial class CONNECTION
    {
        [Key]
        public System.Decimal CONNECTION_ID { get; set; }
        public System.String ACNA_ORG_ID { get; set; }
        public System.Decimal? BIT_RATE { get; set; }
        public System.String CKR { get; set; }
        public System.String CONNECTION_TYPE { get; set; }
        public System.Decimal? CONNECTION_DESIGN_ID { get; set; }
        public System.String ICSC_ORG_ID { get; set; }
        public System.String LOCATION_CODE_A { get; set; }
        public System.String LOCATION_CODE_Z { get; set; }
        public System.String NAME { get; set; }
        public System.String NAME_TYPE { get; set; }
        public System.String REFERENCE_TYPE { get; set; }
        public System.String RATE_CODE { get; set; }
        public System.Decimal? SERIAL_NUMBER { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.String TECHNOLOGY { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CUST_ACCT_NUMBER { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String TSP_AUTHORIZATION_CODE { get; set; }
        public System.String TSP { get; set; }
        public System.String SANITIZED_NAME { get; set; }
        public System.String TYPE { get; set; }
        public System.Decimal? NETWORK_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? UNIFIED_CONNECTION_DESIGN_ID { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
        public System.DateTime? COMPLETION_DATE { get; set; }
        public System.String NAME_2 { get; set; }
        public System.String NAME_3 { get; set; }
        public System.String NAME_4 { get; set; }
        public System.String NAME_5 { get; set; }
        public System.String NAME_6 { get; set; }
        public System.String ACCESS_LINK { get; set; }
    }
    [Table("CONNECTION_REL", Schema = "WNCCRM")]
    public partial class CONNECTION_REL
    {
        [Key]
        public System.Decimal CONNECTION_REL_ID { get; set; }
        public System.String TYPE { get; set; }
        public System.Decimal? PARENT_CONNECTION_ID { get; set; }
        public System.Decimal? CHILD_CONNECTION_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ROLE { get; set; }
    }
    [Table("CONNECTION_SERVICE", Schema = "WNCCRM")]
    public partial class CONNECTION_SERVICE
    {
        [Key]
        public System.Decimal CONNECTION_SERVICE_ID { get; set; }
        public System.Decimal CONNECTION_ID { get; set; }
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("CONTACT_CLNUP_ACCT_PREF_1", Schema = "WNCCRM")]
    public partial class CONTACT_CLNUP_ACCT_PREF_1
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String CM_OBJECT_STATE { get; set; }
        public System.String PRIMARY_EMAIL_FLAG { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
        public System.Decimal? MIN_GLOBAL_ACCOUNT_PARTY_ID { get; set; }
        public System.String CHECK_TYPE { get; set; }
    }
    [Table("CONTACT_FILE_FOR_WINFORCE", Schema = "WNCCRM")]
    public partial class CONTACT_FILE_FOR_WINFORCE
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String GLOBAL_ACTION { get; set; }
        public System.Decimal? RETAINED_CONTACT_ID { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EXISTS_IN_WINFORCE { get; set; }
        public System.String CHECK_FOR { get; set; }
    }
    [Table("CONTACT_MEDIUM", Schema = "WNCCRM")]
    public partial class CONTACT_MEDIUM
    {
        [Key]
        public System.Decimal CONTACT_MEDIUM_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String CONTACT_MEDIUM_METHOD_TYPE { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PHONE_COUNTRY_CODE { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String PHONE_EXTENSION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String WINLINK_REGISTERED { get; set; }
        public System.String WINLINK_SYSTEM { get; set; }
        public System.DateTime? WINLINK_LASTLOGIN { get; set; }
    }
    [Table("CORRELATION_POLICY", Schema = "WNCCRM")]
    public partial class CORRELATION_POLICY
    {
        public System.Decimal? CORRELATION_POLICY_ID { get; set; }
        public System.Decimal? REQUESTER_BUS_SYSTEM_ID { get; set; }
        public System.String REQUESTER_ACTION { get; set; }
        public System.String BUSINESS_ENTITY { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String ENTERPRISE_STATUS { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String NOTIFY { get; set; }
        public System.Decimal? TARGET_BUS_SYSTEM_ID { get; set; }
        public System.String TARGET_ACTION { get; set; }
        public System.Decimal? TARGET_SEQUENCE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TARGET_BUSINESS_ENTITY { get; set; }
    }
    [Table("CPE_REPLACEMENT_LOG", Schema = "WNCCRM")]
    public partial class CPE_REPLACEMENT_LOG
    {
        public System.Decimal? CPE_REPLACEMENT_LOG_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String MODEL_NUMBER { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String REQUEST { get; set; }
        public System.String RESPONSE { get; set; }
    }
    [Table("CSP_ADDR_COUNTRY_LKP", Schema = "WNCCRM")]
    public partial class CSP_ADDR_COUNTRY_LKP
    {
        [Key]
        public System.Decimal ADDR_COUNTRY_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String ISO_NUMERIC { get; set; }
        public System.String ISO_ALPHA2 { get; set; }
        public System.String ISO_ALPHA3 { get; set; }
        public System.String ISO_ENGLISH_NAME { get; set; }
        public System.String LERG_TRA { get; set; }
    }
    [Table("CSP_ADDR_STATEPROV_LKP", Schema = "WNCCRM")]
    public partial class CSP_ADDR_STATEPROV_LKP
    {
        [Key]
        public System.Decimal ADDR_STATEPROV_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? ADDR_COUNTRY_ID { get; set; }
        public System.String STATE_PROV_CD { get; set; }
        public System.String STATE_PROV_NAME { get; set; }
    }
    [Table("CSP_CATEGORY_LKP", Schema = "WNCCRM")]
    public partial class CSP_CATEGORY_LKP
    {
        [Key]
        public System.Decimal CSP_CATEGORY_ID { get; set; }
        public System.String CSP_CATEGORY_CODE { get; set; }
        public System.String CSP_CATEGORY_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_EL_TYPE_PROP_LKP", Schema = "WNCCRM")]
    public partial class CSP_EL_TYPE_PROP_LKP
    {
        [Key]
        public System.Decimal CSP_EL_TYPE_PROP_ID { get; set; }
        public System.Decimal? CSP_ELEMENT_TYPE_ID { get; set; }
        public System.Decimal? CSP_ELEMENT_PROP_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_ELEMENT_LKP", Schema = "WNCCRM")]
    public partial class CSP_ELEMENT_LKP
    {
        [Key]
        public System.Decimal CSP_ELEMENT_ID { get; set; }
        public System.String CSP_ELEMENT_CLLI { get; set; }
        public System.String CSP_ELEMENT_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? CSP_ELEMENT_TYPE_ID { get; set; }
        public System.Decimal? CSP_PROVIDER_ID { get; set; }
    }
    [Table("CSP_ELEMENT_PROP_LKP", Schema = "WNCCRM")]
    public partial class CSP_ELEMENT_PROP_LKP
    {
        [Key]
        public System.Decimal CSP_ELEMENT_PROP_ID { get; set; }
        public System.String CSP_ELEMENT_PROP_CODE { get; set; }
        public System.String CSP_ELEMENT_PROP_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_ELEMENT_PVALUE_LKP", Schema = "WNCCRM")]
    public partial class CSP_ELEMENT_PVALUE_LKP
    {
        [Key]
        public System.Decimal CSP_ELEMENT_PVALUE_ID { get; set; }
        public System.Decimal? CSP_ELEMENT_ID { get; set; }
        public System.Decimal? CSP_EL_TYPE_PROP_ID { get; set; }
        public System.String CSP_EL_TYPE_PROP_VALUE { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_ELEMENT_TYPE_LKP", Schema = "WNCCRM")]
    public partial class CSP_ELEMENT_TYPE_LKP
    {
        [Key]
        public System.Decimal CSP_ELEMENT_TYPE_ID { get; set; }
        public System.String CSP_ELEMENT_TYPE_CODE { get; set; }
        public System.String CSP_ELEMENT_TYPE_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_GEOGRAPHY_LKP", Schema = "WNCCRM")]
    public partial class CSP_GEOGRAPHY_LKP
    {
        [Key]
        public System.Decimal CSP_GEOGRAPHY_ID { get; set; }
        public System.Decimal? GEOGRAPHY_TYPE_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String RC_NAME_ABBR { get; set; }
        public System.String SWC_CLLI { get; set; }
        public System.String SWC_CLLI_ENTITY { get; set; }
        public System.Decimal? ADDR_COUNTRY_ID { get; set; }
        public System.Decimal? ADDR_STATEPROV_ID { get; set; }
    }
    [Table("CSP_GEOGRAPHY_TYPE_LKP", Schema = "WNCCRM")]
    public partial class CSP_GEOGRAPHY_TYPE_LKP
    {
        [Key]
        public System.Decimal GEOGRAPHY_TYPE_ID { get; set; }
        public System.String GEOGRAPHY_TYPE_CODE { get; set; }
        public System.String GEOGRAPHY_TYPE_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_LATA_LKP", Schema = "WNCCRM")]
    public partial class CSP_LATA_LKP
    {
        public System.Decimal? CSP_LATA_ID { get; set; }
        [Key]
        public System.String LATA { get; set; }
        public System.Decimal? CSP_REGION_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_NETWORK_LKP", Schema = "WNCCRM")]
    public partial class CSP_NETWORK_LKP
    {
        [Key]
        public System.Decimal CSP_NETWORK_ID { get; set; }
        public System.String CSP_NETWORK_CODE { get; set; }
        public System.String CSP_NETWORK_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? RANK { get; set; }
    }
    [Table("CSP_PLATFORM_LKP", Schema = "WNCCRM")]
    public partial class CSP_PLATFORM_LKP
    {
        [Key]
        public System.Decimal CSP_PLATFORM_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String PLATFORM_NAME { get; set; }
        public System.String PLATFORM_DESCRIPTION { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_QUOTE { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_ORDER_ENTRY { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_CARE { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_INVENTORY { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_ORDER_MONITOR { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_BILLING { get; set; }
        public System.Decimal? CSP_SYSTEM_ID_TICKETING { get; set; }
        public System.String PLATFORM_CODE { get; set; }
    }
    [Table("CSP_REGION_LKP", Schema = "WNCCRM")]
    public partial class CSP_REGION_LKP
    {
        [Key]
        public System.Decimal CSP_REGION_ID { get; set; }
        public System.String CSP_REGION_CODE { get; set; }
        public System.String CSP_REGION_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CSP_SERVICE_LKP", Schema = "WNCCRM")]
    public partial class CSP_SERVICE_LKP
    {
        [Key]
        public System.Decimal CSP_SERVICE_ID { get; set; }
        public System.String CSP_SERVICE_CODE { get; set; }
        public System.String CSP_SERVICE_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? CSP_QUALIFICATION_ID { get; set; }
    }
    [Table("CSP_SVC_AVAIL_LKP", Schema = "WNCCRM")]
    public partial class CSP_SVC_AVAIL_LKP
    {
        [Key]
        public System.Decimal CSP_SVC_AVAIL_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? CSP_GEOGRAPHY_ID { get; set; }
        public System.Decimal? CSP_SERVICE_ID { get; set; }
        public System.Decimal? CSP_PLATFORM_ID { get; set; }
        public System.Decimal? CSP_NETWORK_ID { get; set; }
        public System.DateTime? EFFECTIVE_DATE { get; set; }
        public System.DateTime? EXPIRATION_DATE { get; set; }
        public System.String FLAG_REQUIRES_QUALIF { get; set; }
        public System.Decimal? CSP_ELEMENT_ID { get; set; }
    }
    [Table("CSP_SVC_CATEGORY_LKP", Schema = "WNCCRM")]
    public partial class CSP_SVC_CATEGORY_LKP
    {
        [Key]
        public System.Decimal CSP_SVC_CATEGORY_ID { get; set; }
        public System.Decimal? CSP_SERVICE_ID { get; set; }
        public System.Decimal? CSP_CATEGORY_ID { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
    }
    [Table("CTRT_CONV", Schema = "WNCCRM")]
    public partial class CTRT_CONV
    {
        public System.Decimal? ID { get; set; }
        public System.String CTRT_CODE { get; set; }
        public System.String CTRT_TEXT_VALUE { get; set; }
        public System.String CTRT_ORG_COMPANY { get; set; }
    }
    [Table("CTRT_EMAIL_UPDATES", Schema = "WNCCRM")]
    public partial class CTRT_EMAIL_UPDATES
    {
        [Key]
        public System.Decimal ID { get; set; }
        public System.String STN { get; set; }
        public System.String CAMS_ID { get; set; }
        public System.String AGENT_ID { get; set; }
        public System.Decimal? STATUS { get; set; }
        public System.DateTime? ENTERED { get; set; }
        public System.String EMAIL { get; set; }
    }
    [Table("CTS_TEST_MESSAGE", Schema = "WNCCRM")]
    public partial class CTS_TEST_MESSAGE
    {
        [Key]
        public System.String CTS_LOOP_ID { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String ENTITY_VALUE { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String CTS_VER_CODE { get; set; }
        public System.String VER_MESSAGE { get; set; }
        public System.String SIGNATURE_MESSAGE { get; set; }
        public System.String INSULATION_SUM { get; set; }
        public System.String STATUS { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String DEVICE_USED { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.String CTS_COE { get; set; }
        public System.String IS_LOOPCARE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String IS_UPDATED { get; set; }
        public System.String INSULATION_SUM_TWO { get; set; }
        public System.String INSULATION_SUM_THREE { get; set; }
        public System.String INSULATION_SUM_FOUR { get; set; }
    }
    [Table("CUST_ACCT", Schema = "WNCCRM")]
    public partial class CUST_ACCT
    {
        [Key]
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String NAME { get; set; }
        public System.String READ_ONLY { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String MIDDLE_INITIAL { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME_SUFFIX { get; set; }
        public System.String IS_INDIVIDUAL { get; set; }
        public System.String ACCT_URL { get; set; }
        public System.String ENTERPRISE_STATUS { get; set; }
        public System.DateTime? ACCOUNT_REGISTERED_DATE { get; set; }
        public System.DateTime? ACCOUNT_CREATED_DATE { get; set; }
        public System.DateTime? ACCOUNT_ESTABLISHED_DATE { get; set; }
        public System.String REGION { get; set; }
        public System.String COMPANY { get; set; }
        public System.String PRIOR_COMPANY { get; set; }
        public System.String OPERATING_COMPANY { get; set; }
        public System.Decimal PLATFORM { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? CREATOR_BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
    }
    [Table("CUST_ACCT_AUDIT", Schema = "WNCCRM")]
    public partial class CUST_ACCT_AUDIT
    {
        public System.DateTime OP_DTTM { get; set; }
        public System.String OP_TABLE_NAME { get; set; }
        public System.Decimal RECORD_ID { get; set; }
        public System.String OP_CMD { get; set; }
        public System.String USERNAME { get; set; }
        public System.String SCHEMANAME { get; set; }
        public System.String OSUSER { get; set; }
        public System.String MACHINE { get; set; }
        public System.String TERMINAL { get; set; }
        public System.String PROGRAM { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
    }
    [Table("CUST_ACCT_BUS_ARTIFACT", Schema = "WNCCRM")]
    public partial class CUST_ACCT_BUS_ARTIFACT
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        [Key]
        public System.Decimal CUST_ACCT_BUS_ARTIFACT_ID { get; set; }
        public System.Decimal? BUS_ARTIFACT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("CUST_ACCT_CONNECTION", Schema = "WNCCRM")]
    public partial class CUST_ACCT_CONNECTION
    {
        [Key]
        public System.Decimal CUST_ACCT_CONNECTION_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CONNECTION_ID { get; set; }
        public System.String TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? DISCONNECTED_DATE { get; set; }
    }
    [Table("CUST_ACCT_INVOICE_TYPE", Schema = "WNCCRM")]
    public partial class CUST_ACCT_INVOICE_TYPE
    {
        [Key]
        public System.Decimal CUST_ACCT_INVOICE_TYPE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? INVOICE_SPEC_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("CUST_ACCT_MKT_PROG_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class CUST_ACCT_MKT_PROG_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("CUST_ACCT_MKT_PROGRAM", Schema = "WNCCRM")]
    public partial class CUST_ACCT_MKT_PROGRAM
    {
        [Key]
        public System.Decimal CUST_ACCT_MKT_PROGRAM_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal MARKET_PROGRAM_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CUST_ACCT_NOTE", Schema = "WNCCRM")]
    public partial class CUST_ACCT_NOTE
    {
        [Key]
        public System.Decimal CUST_ACCT_NOTE_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
    }
    [Table("CUST_ACCT_ORG", Schema = "WNCCRM")]
    public partial class CUST_ACCT_ORG
    {
        [Key]
        public System.Decimal CUST_ACCT_ORG_ID { get; set; }
        public System.Decimal ORG_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CUST_ACCT_ORG_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class CUST_ACCT_ORG_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("CUST_ACCT_PASSIVE", Schema = "WNCCRM")]
    public partial class CUST_ACCT_PASSIVE
    {
        [Key]
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String BILLING_STATUS { get; set; }
        public System.String PAYMENT_STATUS { get; set; }
        public System.String IS_BILLING { get; set; }
        public System.String CPNI_PIN { get; set; }
        public System.Double? LAST_BILLED_AMOUNT { get; set; }
        public System.Double? ACCOUNT_BALANCE { get; set; }
        public System.Double? REAL_TIME_BALANCE { get; set; }
        public System.Double? MONTHLY_REVENUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.DateTime? NEXT_PAYMENT_DUE_DATE { get; set; }
        public System.DateTime? BILLING_START_DATE { get; set; }
        public System.DateTime? BILLING_END_DATE { get; set; }
        public System.String THREE_MONTH_TOLL_AVERAGE { get; set; }
        public System.Decimal? THIRTY_DAYS_PAST_DUE { get; set; }
        public System.Decimal? SIXTY_DAYS_PAST_DUE { get; set; }
        public System.Decimal? TOTAL_DUE { get; set; }
        public System.String THREE_MNTH_TOLL_AVG_TOOTIP { get; set; }
        public System.Decimal? MONTHLY_RECURRING_REVENUE { get; set; }
        public System.Decimal? TOTAL_BILLED_REVENUE { get; set; }
        public System.Decimal? CHANNEL_PARTNER_MRR { get; set; }
        public System.Decimal? CHANNEL_PARTNER_TBR { get; set; }
        public System.Decimal? INVOICED_REFERRAL_AMOUNT { get; set; }
        public System.Decimal? COMMISSIONABLE_REFERRAL_AMOUNT { get; set; }
        public System.DateTime? MRR_REV_MONTH { get; set; }
        public System.DateTime? TBR_REV_MONTH { get; set; }
    }
    [Table("CUST_ACCT_PASSIVE_CAMP_CALL", Schema = "WNCCRM")]
    public partial class CUST_ACCT_PASSIVE_CAMP_CALL
    {
        [Key]
        public System.Decimal CAMP_CALL_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String BILLING_STATUS { get; set; }
        public System.String PAYMENT_STATUS { get; set; }
        public System.String IS_BILLING { get; set; }
        public System.Decimal? CPNI_PIN { get; set; }
        public System.Double? LAST_BILLED_AMOUNT { get; set; }
        public System.Double? ACCOUNT_BALANCE { get; set; }
        public System.Double? REAL_TIME_BALANCE { get; set; }
        public System.Double? MONTHLY_REVENUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.DateTime? NEXT_PAYMENT_DUE_DATE { get; set; }
        public System.String REQUEST_SENT { get; set; }
        public System.String REQUEST { get; set; }
        public System.String RESPONSE { get; set; }
        public System.String RECORD_UPDATED_USER { get; set; }
        public System.DateTime? RECORD_UDPATED_DATE { get; set; }
        public System.String BUS_SYSTEM { get; set; }
    }
    [Table("CUST_ACCT_PASSIVE_UPD", Schema = "WNCCRM")]
    public partial class CUST_ACCT_PASSIVE_UPD
    {
        [Key]
        public System.Decimal PASSIVE_UPD_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String FIELDS_EFFECTED { get; set; }
        public System.DateTime? TRANS_DATE { get; set; }
        public System.String PROCESSED_FLG { get; set; }
        public System.String PROCESSED_BST_FLG { get; set; }
    }
    [Table("CUST_ACCT_PROFILE", Schema = "WNCCRM")]
    public partial class CUST_ACCT_PROFILE
    {
        [Key]
        public System.Decimal CUST_ACCT_PROFILE_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String MARKET_TYPE { get; set; }
        public System.String SUB_MARKET_TYPE { get; set; }
        public System.String SECURITY_CODE { get; set; }
        public System.String CPNI { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
        public System.String GOVERNMENT_PROGRAM { get; set; }
        public System.String SALES_CHANNEL { get; set; }
        public System.String IS_MAJOR_ACCOUNT { get; set; }
        public System.String MAJOR_ACCOUNT_ID { get; set; }
        public System.String IS_ELITE_ACCOUNT { get; set; }
        public System.String NET_PROMOTER_SCORE { get; set; }
        public System.DateTime? NET_PROMOTER_SCORE_DATE { get; set; }
        public System.String PRIOR_BILLING_SYSTEM { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String IS_NATIONAL_ACCOUNT { get; set; }
        public System.String IS_FEDERAL_ACCOUNT { get; set; }
        public System.String NET_PROMOTER_CATEGORY { get; set; }
        public System.String SALES_REGION { get; set; }
        public System.String PRIMARY_ACCT_CONTACT_TEL { get; set; }
        public System.String SECONDARY_ACCT_CONTACT_TEL { get; set; }
        public System.String SOCIAL_SECURITY_SERIAL { get; set; }
        public System.String IS_CRITICAL_WATCHLIST { get; set; }
        public System.String CUSTOMER_TIER { get; set; }
        public System.String IS_WAN_LAN { get; set; }
        public System.String PIC { get; set; }
        public System.String IPIC { get; set; }
        public System.String CUST_EMAIL { get; set; }
        public System.String PIC_LOCK { get; set; }
        public System.String IS_PORTED { get; set; }
        public System.String ACCOUNT_PASSWORD { get; set; }
        public System.String NET_PROMOTER_SATISFACTION { get; set; }
        public System.String IS_ONBOARDED { get; set; }
    }
    [Table("CUST_ACCT_REL", Schema = "WNCCRM")]
    public partial class CUST_ACCT_REL
    {
        [Key]
        public System.Decimal CUST_ACCT_REL_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CUST_ACCT_REL_TYPE { get; set; }
        public System.Decimal PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal ROOT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("CUST_ACCT_REL_ALFRESCO", Schema = "WNCCRM")]
    public partial class CUST_ACCT_REL_ALFRESCO
    {
        [Key]
        public System.Decimal CUST_ACCT_REL_ALFRESCO_ID { get; set; }
        public System.Decimal? CUST_ACCT_REL_ID { get; set; }
        public System.String CUST_ACCT_REL_TYPE { get; set; }
        public System.Decimal? PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CUST_ACCT_REL_HIST", Schema = "WNCCRM")]
    public partial class CUST_ACCT_REL_HIST
    {
        public System.Decimal CUST_ACCT_REL_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CUST_ACCT_REL_TYPE { get; set; }
        public System.Decimal? PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ROOT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.DateTime? HISTORY_DATE { get; set; }
    }
    [Table("CUST_ACCT_REPORT", Schema = "WNCCRM")]
    public partial class CUST_ACCT_REPORT
    {
        [Key]
        public System.Decimal CUST_ACCT_REPORT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? REPORT_SPEC_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("CUST_ACCT_XREF", Schema = "WNCCRM")]
    public partial class CUST_ACCT_XREF
    {
        [Key]
        public System.Decimal CUST_ACCT_XREF_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("CUST_ADDRESS", Schema = "WNCCRM")]
    public partial class CUST_ADDRESS
    {
        [Key]
        public System.Decimal CUST_ADDRESS_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_MOVE_TO_ADDRESS { get; set; }
        public System.String ADDRESS_TYPE { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String STREET_NUMBER_PREFIX { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_NUMBER_SUFFIX { get; set; }
        public System.String STREET_DIRECTIONAL_PREFIX { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String STREET_TYPE { get; set; }
        public System.String STREET_DIRECTIONAL_SUFFIX { get; set; }
        public System.String CITY { get; set; }
        public System.String COUNTY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String STATE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String STRUCTURE_TYPE1 { get; set; }
        public System.String STRUCTURE_VALUE1 { get; set; }
        public System.String STRUCTURE_TYPE2 { get; set; }
        public System.String STRUCTURE_VALUE2 { get; set; }
        public System.String STRUCTURE_TYPE3 { get; set; }
        public System.String STRUCTURE_VALUE3 { get; set; }
        public System.String IS_VALIDATED { get; set; }
        public System.String IS_OVERRIDDEN { get; set; }
        public System.String IS_NEW_CONSTRUCTION { get; set; }
        public System.Double? LATITUDE { get; set; }
        public System.Double? LONGITUDE { get; set; }
        public System.String SERVING_WIRE_CENTER { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String LATA_NUMBER { get; set; }
        public System.String EXCHANGE { get; set; }
        public System.String NPA_NXX { get; set; }
        public System.String CENTRAL_OFFICE_EQUIPMENT { get; set; }
        public System.String IS_OFFNET { get; set; }
        public System.String TAX_JURISDICTION_CODE { get; set; }
        public System.String ROUTE { get; set; }
        public System.String BOX { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String P_CODE { get; set; }
        public System.String IS_INCORPORATED { get; set; }
        public System.String LOCATION_DETAILS { get; set; }
        public System.String COMMUNITY { get; set; }
        public System.String COUNTY_CODE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ATTENTION { get; set; }
        public System.String COMPOSITE_ADDRESS { get; set; }
        public System.String LATA_NAME { get; set; }
        public System.String OCN { get; set; }
        public System.String OPERATING_COMPANY { get; set; }
        public System.String RECIPIENT { get; set; }
        public System.String SERVICE_GRADE { get; set; }
        public System.String BEX { get; set; }
        public System.String BOID { get; set; }
        public System.String WINDSTREAM_ILEC { get; set; }
        public System.String TIMEZONE { get; set; }
        public System.Decimal? DF_ADDRESS_ID { get; set; }
        public System.String UQUAL_OVERRIDDEN { get; set; }
    }
    [Table("CUST_ADV_EMP_IDS", Schema = "WNCCRM")]
    public partial class CUST_ADV_EMP_IDS
    {
        [Key]
        public System.String EMPLOYEE_ID { get; set; }
        [Key]
        public System.String USER_TYPE { get; set; }
    }
    [Table("CUST_AGREEMENT", Schema = "WNCCRM")]
    public partial class CUST_AGREEMENT
    {
        [Key]
        public System.Decimal CUST_AGREEMENT_ID { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.DateTime? AGREEMENT_SIGN_DATE { get; set; }
        public System.DateTime? AGREEMENT_START_DATE { get; set; }
        public System.DateTime? AGREEMENT_END_DATE { get; set; }
        public System.Int16? AGREEMENT_TERM { get; set; }
        public System.DateTime? LAST_RENEWAL_DATE { get; set; }
        public System.String IS_AUTOMATIC_RENEWAL { get; set; }
        public System.Double? ESTIMATED_MONTHLY_REVENUE { get; set; }
        public System.Double? MIN_MONTHLY_FEE { get; set; }
        public System.Double? MIN_BILL_AMOUNT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String AGREEMENT_NUMBER { get; set; }
        public System.String SIGNED_BY { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal CUST_AGREEMENT_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String CUST_AGREEMENT_REFERENCE { get; set; }
        public System.String NAME { get; set; }
        public System.String CUST_VENDOR_ID { get; set; }
        public System.String CUST_SYSTEM_ID { get; set; }
        public System.String CUST_CUSTOMER_ID { get; set; }
        public System.String CUST_CONTRACT_ID { get; set; }
        public System.String CUST_SITE_ID { get; set; }
        public System.String CUST_AUTHORIZATION_ID { get; set; }
    }
    [Table("CUST_CREDIT_PROFILE", Schema = "WNCCRM")]
    public partial class CUST_CREDIT_PROFILE
    {
        [Key]
        public System.Decimal CUST_CREDIT_PROFILE_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREDIT_CLASS { get; set; }
        public System.Double? NETWORK_CREDIT_LIMIT { get; set; }
        public System.Double? HARDWARE_CREDIT_LIMIT { get; set; }
        public System.Double? CREDIT_LIMIT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CREDIT_DECISION { get; set; }
    }
    [Table("CUST_SERVICE_STG", Schema = "WNCCRM")]
    public partial class CUST_SERVICE_STG
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal TEL_NUM_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.DateTime? MIN_START_DATE { get; set; }
        public System.DateTime? MAX_END_DATE { get; set; }
    }
    [Table("CUST_TYPE", Schema = "WNCCRM")]
    public partial class CUST_TYPE
    {
        [Key]
        public System.Decimal CUST_TYPE_ID { get; set; }
        [Column("CUST_TYPE")]
        public System.String CUST_TYPE_val { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_MODIFIED_USER { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.Decimal CUST_TYPE_SEQUENCE { get; set; }
    }
    [Table("CUSTOMER_TIER_GOV", Schema = "WNCCRM")]
    public partial class CUSTOMER_TIER_GOV
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUSTOMER_TIER { get; set; }
    }
    [Table("CUSTOMER_TIER_STG", Schema = "WNCCRM")]
    public partial class CUSTOMER_TIER_STG
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SALES_ACCOUNT_ID { get; set; }
        public System.String OPPORTUNITY_ID { get; set; }
        public System.String CUSTOMER_TIER { get; set; }
    }
    [Table("DASHBOARD_REGION_SERV_SPEC", Schema = "WNCCRM")]
    public partial class DASHBOARD_REGION_SERV_SPEC
    {
        [Key]
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        [Key]
        public System.Decimal DASHBOARD_REGION_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DASHBOARD_REGION_SPEC", Schema = "WNCCRM")]
    public partial class DASHBOARD_REGION_SPEC
    {
        [Key]
        public System.Decimal DASHBOARD_REGION_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CLASS_WIDTH { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.String MIN_HEIGHT { get; set; }
        public System.String MAX_HEIGHT { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? PRIORITY { get; set; }
    }
    [Table("DASHBOARD_SPEC", Schema = "WNCCRM")]
    public partial class DASHBOARD_SPEC
    {
        [Key]
        public System.Decimal DASHBOARD_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String IS_SERVICE_AWARE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("DASHBOARD_TEMPLATE", Schema = "WNCCRM")]
    public partial class DASHBOARD_TEMPLATE
    {
        [Key]
        public System.Decimal DASHBOARD_TEMPLATE_ID { get; set; }
        public System.Decimal DASHBOARD_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String IS_PUBLIC { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("DASHBOARD_TEMPLATE_SERV_SPEC", Schema = "WNCCRM")]
    public partial class DASHBOARD_TEMPLATE_SERV_SPEC
    {
        public System.Decimal DASHBOARD_TEMPLATE_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DB_BLOCKING_LOCKS", Schema = "WNCCRM")]
    public partial class DB_BLOCKING_LOCKS
    {
        [Key]
        public System.Decimal DB_BLOCKING_LOCKS_ID { get; set; }
        public System.String LOCKING_USERNAME { get; set; }
        public System.String LOCKING_OSUSER { get; set; }
        public System.Decimal? LOCKING_SID { get; set; }
        [Column("LOCKING_SERIAL#")]
        public System.Decimal? LOCKING_SERIAL_ { get; set; }
        public System.String LOCKING_SQL_ID { get; set; }
        public System.String LOCKING_SQL_TEXT { get; set; }
        public System.String LOCKING_SESSION_STATUS { get; set; }
        public System.String LOCKING_MODULE { get; set; }
        public System.String LOCKING_PROGRAM_HOLDING { get; set; }
        public System.String LOCKING_JOB_NAME { get; set; }
        public System.String WAITING_USERNAME { get; set; }
        public System.String WAITING_OSUSER { get; set; }
        public System.Decimal? WAITER_SID { get; set; }
        [Column("WAITER_SERIAL#")]
        public System.Decimal? WAITER_SERIAL_ { get; set; }
        public System.String WAITER_SQL_ID { get; set; }
        public System.String WAITING_SQL_TEXT { get; set; }
        public System.String WAITING_PROGRAM { get; set; }
        public System.String WAITING_JOB_NAME { get; set; }
        public System.String LOCKING_SESSION_KILL { get; set; }
        public System.DateTime? CREATER_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
    }
    [Table("DB_CHG_HIST", Schema = "WNCCRM")]
    public partial class DB_CHG_HIST
    {
        public System.String DB_VERSION_ID { get; set; }
        public System.String FILE_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? START_TIMESTAMP { get; set; }
        public System.DateTime? END_TIMESTAMP { get; set; }
        public System.String USERNAME { get; set; }
    }
    [Table("DB_NON_PROD_DEPLOY_JENKINS", Schema = "WNCCRM")]
    public partial class DB_NON_PROD_DEPLOY_JENKINS
    {
        public System.String SCHEMA_NAME { get; set; }
        public System.Decimal? EXIT_STATUS { get; set; }
        public System.DateTime? LOG_DATE { get; set; }
    }
    [Table("DB_SESSIONS", Schema = "WNCCRM")]
    public partial class DB_SESSIONS
    {
        public System.Decimal? SID { get; set; }
        [Column("SERIAL#")]
        public System.Decimal? SERIAL_ { get; set; }
        public System.String MACHINE { get; set; }
        public System.Decimal? ACTIVE_TIME_HRS { get; set; }
        public System.String TYPE { get; set; }
        public System.DateTime? LOGON_TIME { get; set; }
        public System.String ACTION { get; set; }
        public System.String OSUSER { get; set; }
        public System.String STATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String SCHEMANAME { get; set; }
        public System.String USERNAME { get; set; }
        public System.String WAIT_CLASS { get; set; }
        public System.String MODULE { get; set; }
    }
    [Table("DB_TOP_SQL", Schema = "WNCCRM")]
    public partial class DB_TOP_SQL
    {
        public System.Decimal? DB_TOP_SQL_ID { get; set; }
        public System.Decimal SNAP_ID { get; set; }
        public System.Decimal INSTANCE_NUMBER { get; set; }
        public System.String PARSING_SCHEMA_NAME { get; set; }
        public System.String SQL_ID { get; set; }
        public System.Decimal? FORCE_MATCHING_SIGNATURE { get; set; }
        public System.DateTime BEGIN_INTERVAL_TIME { get; set; }
        public System.DateTime END_INTERVAL_TIME { get; set; }
        public System.Decimal PLAN_HASH_VALUE { get; set; }
        public System.String SQL_PROFILE { get; set; }
        public System.Decimal? EXECUTIONS { get; set; }
        public System.Decimal? PERCENTAGE_OF_TOTAL_CPU { get; set; }
        public System.Decimal? TOTAL_LIO { get; set; }
        public System.Decimal? ROWS_PER_EXEC { get; set; }
        public System.Decimal? PIO_PER_EXEC { get; set; }
        public System.Decimal? LIO_PER_EXEC { get; set; }
        public System.Decimal? CPU_SECS { get; set; }
        public System.Decimal? PIO_SECS { get; set; }
        public System.Decimal? OTHER_SECS { get; set; }
        public System.Decimal? ELAPSED_SECS { get; set; }
        public System.Decimal? ELAPSED_MINUTES { get; set; }
        public System.Decimal? MAX_CPU { get; set; }
        public System.Decimal? AVG_CPU { get; set; }
        public System.Decimal? EXECUTIONS_TOTAL { get; set; }
        public System.Decimal? CPU_TIME_TOTAL { get; set; }
        public System.Decimal? ELAPSED_TIME_TOTAL { get; set; }
        public System.String SQLTEXT { get; set; }
    }
    [Table("DB_VERSION", Schema = "WNCCRM")]
    public partial class DB_VERSION
    {
        public System.String DB_VERSION_ID { get; set; }
        public System.Decimal? DEBUG_LEVEL { get; set; }
    }
    [Table("DB_VERSIONS_LIST", Schema = "WNCCRM")]
    public partial class DB_VERSIONS_LIST
    {
        public System.String DB_VERSION_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? START_TIMESTAMP { get; set; }
        public System.DateTime? END_TIMESTAMP { get; set; }
    }
    [Table("DBA_OBJECTS_P30_INVALID", Schema = "WNCCRM")]
    public partial class DBA_OBJECTS_P30_INVALID
    {
        public System.String OWNER { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String SUBOBJECT_NAME { get; set; }
        public System.Decimal? OBJECT_ID { get; set; }
        public System.Decimal? DATA_OBJECT_ID { get; set; }
        public System.String OBJECT_TYPE { get; set; }
        public System.DateTime? CREATED { get; set; }
        public System.DateTime? LAST_DDL_TIME { get; set; }
        public System.String TIMESTAMP { get; set; }
        public System.String STATUS { get; set; }
        public System.String TEMPORARY { get; set; }
        public System.String GENERATED { get; set; }
        public System.String SECONDARY { get; set; }
        public System.Decimal? NAMESPACE { get; set; }
        public System.String EDITION_NAME { get; set; }
    }
    [Table("DCRIS_DATA_STG", Schema = "WNCCRM")]
    public partial class DCRIS_DATA_STG
    {
        public System.String ORDER_ID { get; set; }
        public System.String ORDER_TN { get; set; }
        public System.String CONTACT_NAME { get; set; }
        public System.String TEXT_OPTION { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CRM_CURRENT_STATUS { get; set; }
        public System.String CRM_NEW_STATUS { get; set; }
        public System.String SO_STATUS { get; set; }
        public System.String CRM_SO_STATUS { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
    }
    [Table("DCRIS_DICT", Schema = "WNCCRM")]
    public partial class DCRIS_DICT
    {
        public System.String TABLE_NAME { get; set; }
        public System.String COLUMN_NAME { get; set; }
        public System.String COLUMN_TYPE { get; set; }
        public System.String COLUMN_DSCRPTN { get; set; }
        public System.Decimal? COLUMN_SEQ { get; set; }
        public System.String TABLE_DSCRPTN { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("DCRIS_ORDER", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER
    {
        [Key]
        public System.Decimal DCRIS_ORDER_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ORDER_ID { get; set; }
        public System.String SO_NMBR { get; set; }
        public System.String SEGMENT_TN { get; set; }
        public System.String WORK_FORCE_ID { get; set; }
        public System.String WORK_UNITS { get; set; }
        public System.String FACILITY_REMARKS { get; set; }
        public System.String ACCESS_REMARKS { get; set; }
        public System.String ID_REMARKS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DCRIS_ORDER_CONTACT", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER_CONTACT
    {
        public System.String ORDER_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String STATUS { get; set; }
        public System.String CBR_PHONE_NUMBER { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String OPT_IN_TEXT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DCRIS_ORDER_DIRECTORY", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER_DIRECTORY
    {
        [Key]
        public System.Decimal DCRIS_ORDER_DIRECTORY_ID { get; set; }
        public System.Decimal DCRIS_ORDER_ID { get; set; }
        public System.Decimal? SEQ_NMBR { get; set; }
        public System.String ACTION { get; set; }
        public System.String LIST_CODE { get; set; }
        public System.String INDENT { get; set; }
        public System.String REMARKS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DCRIS_ORDER_OCC", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER_OCC
    {
        [Key]
        public System.Decimal DCRIS_ORDER_OCC_ID { get; set; }
        public System.Decimal DCRIS_ORDER_ID { get; set; }
        public System.Decimal? SEQ_NMBR { get; set; }
        public System.String ASOC_CODE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.Double? AMOUNT { get; set; }
        public System.String ASOC_TYPE { get; set; }
        public System.String ASOC_CONTINUE_SEQ { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DCRIS_ORDER_REMARKS", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER_REMARKS
    {
        [Key]
        public System.Decimal DCRIS_ORDER_REMARKS_ID { get; set; }
        public System.Decimal DCRIS_ORDER_ID { get; set; }
        public System.String REC_TYPE { get; set; }
        public System.String REMARKS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DCRIS_ORDER_SNE", Schema = "WNCCRM")]
    public partial class DCRIS_ORDER_SNE
    {
        [Key]
        public System.Decimal DCRIS_ORDER_SNE_ID { get; set; }
        public System.Decimal DCRIS_ORDER_ID { get; set; }
        public System.String SEGMENT_TN { get; set; }
        public System.Decimal? SEQ_NMBR { get; set; }
        public System.String ASOC_CODE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String ACTION_CODE { get; set; }
        public System.Double? AMOUNT { get; set; }
        public System.String ASOC_TYPE { get; set; }
        public System.String ASOC_CONTINUE_SEQ { get; set; }
        public System.String REMARKS { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("DDL_LOG", Schema = "WNCCRM")]
    public partial class DDL_LOG
    {
        public System.String OPERATION { get; set; }
        public System.String OBJ_OWNER { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String SQL_TEXT { get; set; }
        public System.String ATTEMPT_BY { get; set; }
        public System.DateTime? ATTEMPT_DT { get; set; }
        public System.String RELEASE_UPGRADE { get; set; }
        public System.String IS_MAILED { get; set; }
    }
    [Table("DEBUG_INFO", Schema = "WNCCRM")]
    public partial class DEBUG_INFO
    {
        [Key]
        public System.Decimal DEBUG_ID { get; set; }
        public System.String SCHEMA_NAME { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String SQL_TEXT { get; set; }
        public System.String COMMENTS { get; set; }
        public System.String OS_USER { get; set; }
        public System.Decimal? SID { get; set; }
        public System.DateTime? ENTRY_DT { get; set; }
        [Column("SERIAL#")]
        public System.Decimal? SERIAL_ { get; set; }
    }
    [Table("DEBUG_OBJECT", Schema = "WNCCRM")]
    public partial class DEBUG_OBJECT
    {
        public System.String OBJECT_NAME { get; set; }
        public System.String SUB_OBJECT_NAME { get; set; }
        public System.String OBJECT_TYPE { get; set; }
    }
    [Table("DEBUG_TEST", Schema = "WNCCRM")]
    public partial class DEBUG_TEST
    {
        public System.String PROCEDURE_NAME { get; set; }
        public System.String PARAMETERS { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
    }
    [Table("DEV_REPL_BUS_INTER_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class DEV_REPL_BUS_INTER_ROLE_LKUP
    {
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_REPL_BUS_INTERACTION", Schema = "WNCCRM")]
    public partial class DEV_REPL_BUS_INTERACTION
    {
        [Key]
        public System.Decimal DEV_REPL_BUS_INTERACTION_ID { get; set; }
        public System.Decimal? DEVICE_REPLACEMENT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_REPL_SERV_ITEM", Schema = "WNCCRM")]
    public partial class DEV_REPL_SERV_ITEM
    {
        [Key]
        public System.Decimal DEV_REPL_SERV_ITEM_ID { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.Decimal? DEVICE_REPLACEMENT_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_REPL_SERV_ITEM_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class DEV_REPL_SERV_ITEM_ROLE_LKUP
    {
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_SNAP_BI_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class DEV_SNAP_BI_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_SNAP_BUS_INTERACTION", Schema = "WNCCRM")]
    public partial class DEV_SNAP_BUS_INTERACTION
    {
        [Key]
        public System.Decimal DEV_SNAP_BUS_INTERACTION_ID { get; set; }
        public System.Decimal? DEV_SNAP_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_SNAP_SERV_ITEM", Schema = "WNCCRM")]
    public partial class DEV_SNAP_SERV_ITEM
    {
        [Key]
        public System.Decimal DEV_SNAP_SERV_ITEM_ID { get; set; }
        public System.Decimal? DEV_SNAP_ID { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEV_SNAP_SERV_ITEM_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class DEV_SNAP_SERV_ITEM_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEVICE", Schema = "WNCCRM")]
    public partial class DEVICE
    {
        [Key]
        public System.Decimal DEVICE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String DEVICE_TYPE { get; set; }
        public System.String MANUFACTURER_NAME { get; set; }
        public System.String MODEL_NBR { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime? END_OF_LIFE { get; set; }
        public System.String PAYMENT_FREQUENCY { get; set; }
        public System.String PROCUREMENT_VENDOR { get; set; }
        public System.String LICENSE_MANAGEMENT_ORG { get; set; }
        public System.String RENEWAL_MODEL { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String HDM_OUI { get; set; }
    }
    [Table("DEVICE_CMTS", Schema = "WNCCRM")]
    public partial class DEVICE_CMTS
    {
        public System.String EXCHANGE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String AREA_CODE { get; set; }
        public System.String HOST_NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String MAKE { get; set; }
        public System.String MODEL { get; set; }
    }
    [Table("DEVICE_CUST", Schema = "WNCCRM")]
    public partial class DEVICE_CUST
    {
        public System.Decimal CUST_ADDRESS_ID { get; set; }
        public System.Decimal DEVICE_ID { get; set; }
        public System.String DEVICE_SERIAL_NBR { get; set; }
        public System.String TN_ASSOCIATED { get; set; }
        public System.DateTime? INSTALL_DATE { get; set; }
        public System.String HOSTNAME { get; set; }
        public System.String IP_ASSOCIATED { get; set; }
        public System.String FIRMWARE_AT_INSTALL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATED_USER { get; set; }
        public System.DateTime? LAST_UPDATED_DATE { get; set; }
        [Key]
        public System.Decimal PHYSICAL_DEVICE_ID { get; set; }
        public System.String MAC_ADDRESS { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.DateTime? LICENSE_START_DATE { get; set; }
        public System.DateTime? LICENSE_END_DATE { get; set; }
        public System.String LICENSE_TERM { get; set; }
        public System.String LICENSE_TYPE { get; set; }
        public System.DateTime? DISCONNECTED_RETRIEVAL_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String MONITORING_STATUS { get; set; }
        public System.DateTime? MONITORING_STATUS_UPD_DATE { get; set; }
        public System.String MONITORING_STATUS_UPD_USER { get; set; }
        public System.String MONITORING_STATUS_UPD_REASON { get; set; }
        public System.String OWNERSHIP { get; set; }
        public System.String TIER { get; set; }
        public System.String MANAGEMENT { get; set; }
        public System.Decimal? CONNECTION_ID { get; set; }
        public System.String VSR_LOCATION_ID { get; set; }
    }
    [Table("DEVICE_REPLACEMENT", Schema = "WNCCRM")]
    public partial class DEVICE_REPLACEMENT
    {
        [Key]
        public System.Decimal DEVICE_REPLACEMENT_ID { get; set; }
        public System.String MANUFACTURER { get; set; }
        public System.String MODEL { get; set; }
        public System.String SERIAL { get; set; }
        public System.String FIRMWARE_VERSION { get; set; }
        public System.String MAC_ADDRESS { get; set; }
        public System.String REPLACEMENT_COVERAGE { get; set; }
        public System.String IS_BILLABLE { get; set; }
        public System.String IS_CUSTOMER_PICKUP { get; set; }
        public System.String IS_RETURN_TAG_SENT { get; set; }
        public System.DateTime? ESTIMATED_SHIP_DATE { get; set; }
        public System.String SHIP_TO_ATTN { get; set; }
        public System.String SHIP_TO_RECIPIENT { get; set; }
        public System.String SHIP_TO_ADDRESS_LINE_1 { get; set; }
        public System.String SHIP_TO_ADDRESS_LINE_2 { get; set; }
        public System.String SHIP_TO_CITY { get; set; }
        public System.String SHIP_TO_STATE { get; set; }
        public System.String SHIP_TO_POSTAL_CODE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEVICE_SERVICE_AVAIL", Schema = "WNCCRM")]
    public partial class DEVICE_SERVICE_AVAIL
    {
        [Key]
        public System.Decimal DEVICE_SERVICE_AVAIL_ID { get; set; }
        public System.Decimal? DEVICE_ID { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.Decimal? PRODUCT_SPEC_ID { get; set; }
        public System.Double? MRC_CHARGE { get; set; }
        public System.String PRODUCT_CHARGE_OCCURRANCE { get; set; }
        public System.Decimal? NRC_CHARGE { get; set; }
    }
    [Table("DEVICE_SNAP", Schema = "WNCCRM")]
    public partial class DEVICE_SNAP
    {
        [Key]
        public System.Decimal DEV_SNAP_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String MANUFACTURER { get; set; }
        public System.String MODEL { get; set; }
        public System.String SERIAL { get; set; }
        public System.String FIRMWARE_VERSION { get; set; }
        public System.String DEVICE_STATUS { get; set; }
        public System.String MAC_ADDRESS { get; set; }
        public System.String IP_ADDRESS_V4 { get; set; }
        public System.String IP_ADDRESS_V6 { get; set; }
        public System.String VPI { get; set; }
        public System.String VCI { get; set; }
        public System.String NSEERNAME { get; set; }
        public System.String ENCAPSULATION { get; set; }
        public System.String IS_WALLED_GARDEN { get; set; }
        public System.String IS_ISPP_REGISTERED { get; set; }
        public System.String SETTING_AUTHENTICATION { get; set; }
        public System.String LAST_KNOWN_IP_ADDRESS_V4 { get; set; }
        public System.String LAST_KNOWN_IP_ADDRESS_V6 { get; set; }
        public System.String IS_THIRD_PARTY_BYPASS { get; set; }
        public System.DateTime? LAST_KNOWN_CONTACT_DATE { get; set; }
        public System.DateTime? LAST_KNOWN_RESET_DATE { get; set; }
        public System.DateTime? LAST_KNOWN_ACTIVATION { get; set; }
        public System.String IS_PING_SUCCESSFUL { get; set; }
        public System.String OAM_RESULT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("DEVICE_SNAPSHOT", Schema = "WNCCRM")]
    public partial class DEVICE_SNAPSHOT
    {
        [Key]
        public System.Decimal DEVICE_SNAPSHOT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String MANUFACTURER { get; set; }
        public System.String MODEL { get; set; }
        public System.String SERIAL { get; set; }
        public System.String FIRMWARE_VERSION { get; set; }
        public System.String DEVICE_STATUS { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String MAC_ADDRESS { get; set; }
        public System.String IP_ADDRESS_V4 { get; set; }
        public System.String IP_ADDRESS_V6 { get; set; }
        public System.String VPI_VCI { get; set; }
        public System.String USERNAME { get; set; }
        public System.String ENCAPSULATION { get; set; }
        public System.String IS_WALLED_GARDEN { get; set; }
        public System.String IS_ISPP_REGISTERED { get; set; }
        public System.String SETTING_AUTHENTICATION { get; set; }
        public System.String LAST_KNOWN_IPADDRESS_V4 { get; set; }
        public System.String LAST_KNOWN_IPADDRESS_V6 { get; set; }
        public System.String IS_THIRD_PARTY_BYPASS { get; set; }
        public System.DateTime? LAST_KNOWN_CONTACT_DATE { get; set; }
        public System.DateTime? LAST_KNOWN_RESET_DATA { get; set; }
        public System.DateTime? LAST_KNOWN_ACTIVATION { get; set; }
        public System.String IS_PING_SUCCESSFUL { get; set; }
        public System.String OAM_RESULT { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String BIRTH_CERTIFICATE { get; set; }
        public System.Decimal? CTS_TEST_ID { get; set; }
        public System.String CLIENT_ID { get; set; }
        public System.String BIRTH_CERTIFICATE_DISPATCH { get; set; }
        public System.String NOTES { get; set; }
    }
    [Table("DEVICE_TRAIN_SNAPSHOT", Schema = "WNCCRM")]
    public partial class DEVICE_TRAIN_SNAPSHOT
    {
        public System.String IS_TRAIN_SUCCESSFUL { get; set; }
        public System.String TRAIN_ADMIN_STATE { get; set; }
        public System.String TRAIN_SPEED_DOWN { get; set; }
        public System.String TRAIN_SPEED_UP { get; set; }
        public System.String TRAIN_ATTENTION_UP { get; set; }
        public System.String TRAIN_ATTENUATION_DOWN { get; set; }
        public System.String TRAIN_SIGNAL_NOISE_DOWN { get; set; }
        public System.String TRAIN_SIGNAL_NOISE_UP { get; set; }
        public System.Decimal? TRAIN_CELLS_DOWN { get; set; }
        public System.Decimal? TRAIN_CELLS_UP { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? DEVICE_SNAPSHOT_ID { get; set; }
    }
    [Table("DIALUP_OUTAGE", Schema = "WNCCRM")]
    public partial class DIALUP_OUTAGE
    {
        [Key]
        public System.Decimal DIAL_UP_OUTAGE_NUM { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal? DIAL_UP_POP { get; set; }
        public System.String DUP_STATUS { get; set; }
        public System.String NOTES { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
    }
    [Table("DISH_AXIOM", Schema = "WNCCRM")]
    public partial class DISH_AXIOM
    {
        [Key]
        public System.Decimal DISH_AXIOM_ID { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.String URL { get; set; }
        public System.String OFFSET { get; set; }
        public System.String DEFAULT_VAL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String LAST_UPDATE_DATE { get; set; }
    }
    [Table("DISPATCH_ALERT", Schema = "WNCCRM")]
    public partial class DISPATCH_ALERT
    {
        [Key]
        public System.Decimal DISPATCH_ALERT_ID { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String BUCKET { get; set; }
        public System.String AREA { get; set; }
        public System.String CLLI { get; set; }
        public System.String ALERT { get; set; }
        public System.Decimal? THRESHOLD { get; set; }
        public System.DateTime? UPDATEDDATE { get; set; }
        public System.String UPDATEDBY { get; set; }
    }
    [Table("DISTRIBUTION_CHANNEL_SPEC", Schema = "WNCCRM")]
    public partial class DISTRIBUTION_CHANNEL_SPEC
    {
        [Key]
        public System.Decimal DISTRIBUTION_CHANNEL_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String DISTRIBUTION_CHANNEL { get; set; }
        public System.String TIER { get; set; }
        public System.Decimal? MINIMUM_REVENUE { get; set; }
        public System.Decimal? MAXIMUM_REVENUE { get; set; }
        public System.String REGIONAL_PRESIDENT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ACCOUNT_OWNER_VP { get; set; }
        public System.String ACCOUNT_OWNER { get; set; }
        public System.String ACCOUNT_OWNER_DIRECTOR { get; set; }
        public System.String SALES_REGION { get; set; }
        public System.String SD_TEAM { get; set; }
    }
    [Table("DSLAMSCRIPT_MATRIX", Schema = "WNCCRM")]
    public partial class DSLAMSCRIPT_MATRIX
    {
        [Key]
        public System.Decimal MATRIX_ID { get; set; }
        public System.Int16 NETWORK { get; set; }
        public System.Int16 LINE_QUALITY { get; set; }
        public System.Int16 MODEM { get; set; }
        public System.Int16 PROJECT_DATE { get; set; }
        public System.Int16 HIGH_SPEED_AVAILABLE { get; set; }
        public System.Decimal SCRIPT_ID { get; set; }
    }
    [Table("DSLAMSCRIPT_SCRIPTS", Schema = "WNCCRM")]
    public partial class DSLAMSCRIPT_SCRIPTS
    {
        [Key]
        public System.Decimal SCRIPT_ID { get; set; }
        public System.String SCRIPT_NAME { get; set; }
        public System.String SCRIPT { get; set; }
    }
    [Table("ELNK_ACCOUNTS", Schema = "WNCCRM")]
    public partial class ELNK_ACCOUNTS
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String ACCT_NBR { get; set; }
        public System.Decimal? SVC_LOC_NBR { get; set; }
        public System.String NAME { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String BUS_SYSTEM_NAME { get; set; }
        public System.String SRC_SYS_CD { get; set; }
        public System.String CURR_BLLR_CD { get; set; }
        public System.String MSTR_ACCT_NBR { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CMID { get; set; }
        public System.Decimal? PRNT_CO_ID { get; set; }
        public System.String IS_DUPLICATE { get; set; }
    }
    [Table("ELNK_ACCOUNTS_MIDAS", Schema = "WNCCRM")]
    public partial class ELNK_ACCOUNTS_MIDAS
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String BUS_SYSTEM_NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("EMAIL_ADDRESS", Schema = "WNCCRM")]
    public partial class EMAIL_ADDRESS
    {
        [Key]
        public System.Decimal EMAIL_ADDRESS_ID { get; set; }
        [Column("EMAIL_ADDRESS")]
        public System.String EMAIL_ADDRESS_val { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("EMAIL_ADDRESS_CUST_ACCT", Schema = "WNCCRM")]
    public partial class EMAIL_ADDRESS_CUST_ACCT
    {
        [Key]
        public System.Decimal EMAIL_ADDRESS_CUST_ACCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal EMAIL_ADDRESS_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("EMAIL_ADDRESS_REL", Schema = "WNCCRM")]
    public partial class EMAIL_ADDRESS_REL
    {
        [Key]
        public System.Decimal EMAIL_ADDRESS_REL_ID { get; set; }
        public System.Decimal PARENT_EMAIL_ADDRESS_ID { get; set; }
        public System.Decimal CHILD_EMAIL_ADDRESS_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("EMAIL_ADDRESS_SERVICE", Schema = "WNCCRM")]
    public partial class EMAIL_ADDRESS_SERVICE
    {
        [Key]
        public System.Decimal EMAIL_ADDRESS_SERVICE_ID { get; set; }
        public System.Decimal EMAIL_ADDRESS_ID { get; set; }
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("EMAIL_ATTACHMENT", Schema = "WNCCRM")]
    public partial class EMAIL_ATTACHMENT
    {
        [Key]
        public System.Decimal EMAIL_ATTACHMENT_ID { get; set; }
        public System.Decimal? EMAIL_COMMUNICATION_ID { get; set; }
        public System.String FILE_NAME { get; set; }
        public System.String FILE_SIZE_IN_BYTES { get; set; }
        public System.String FILE_TYPE { get; set; }
        public System.String STORAGE_LOCATION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("EMAIL_COMMUNICATION", Schema = "WNCCRM")]
    public partial class EMAIL_COMMUNICATION
    {
        [Key]
        public System.Decimal EMAIL_COMMUNICATION_ID { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.Decimal? ENTITY_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String FROM_EMAIL_ADDRESS { get; set; }
        public System.String TO_EMAIL_ADDRESS { get; set; }
        public System.String CC_EMAIL_ADDRESS { get; set; }
        public System.String BCC_EMAIL_ADDRESS { get; set; }
        public System.String DIRECTION { get; set; }
        public System.String SUBJECT { get; set; }
        public System.String BODY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("EMPLOYEE_CID", Schema = "WNCCRM")]
    public partial class EMPLOYEE_CID
    {
        public System.String OWNER_ID { get; set; }
        public System.String OWNER_NAME { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String PACTIVE { get; set; }
        public System.String PNAME { get; set; }
        public System.String PPHONE { get; set; }
        public System.String XP_HOMEPHONE { get; set; }
        public System.String XP_SUPERVISOR { get; set; }
        public System.DateTime? DATE_TIME_LOAD { get; set; }
        public System.DateTime? DATE_TIME_LAST_MODIFIED { get; set; }
        public System.Decimal? PARENT_LEVEL { get; set; }
        public System.String EMP_STATUS { get; set; }
    }
    [Table("EMPLOYEE_CID_STG", Schema = "WNCCRM")]
    public partial class EMPLOYEE_CID_STG
    {
        public System.String OWNER_ID { get; set; }
        public System.String OWNER_NAME { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String PACTIVE { get; set; }
        public System.String PNAME { get; set; }
        public System.String PPHONE { get; set; }
        public System.String XP_HOMEPHONE { get; set; }
        public System.String XP_SUPERVISOR { get; set; }
        public System.DateTime? DATE_TIME_LOAD { get; set; }
        public System.DateTime? DATE_TIME_LAST_MODIFIED { get; set; }
        public System.Decimal? PARENT_LEVEL { get; set; }
        public System.Decimal? ID { get; set; }
    }
    [Table("ENTERPRISE_STATUS", Schema = "WNCCRM")]
    public partial class ENTERPRISE_STATUS
    {
        [Key]
        public System.Decimal ENTERPRISE_STATUS_ID { get; set; }
        [Column("ENTERPRISE_STATUS")]
        public System.String ENTERPRISE_STATUS_val { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_MODIFIED_USER { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.Decimal ENTERPRISE_SEQUENCE { get; set; }
    }
    [Table("ENTITY_OPEN_STATUS", Schema = "WNCCRM")]
    public partial class ENTITY_OPEN_STATUS
    {
        public System.String ENTITY_TYPE { get; set; }
        public System.String STATUS { get; set; }
        public System.String IS_OPEN { get; set; }
    }
    [Table("EQUIPMENT_REQUESTS", Schema = "WNCCRM")]
    public partial class EQUIPMENT_REQUESTS
    {
        [Key]
        public System.Int64 ID { get; set; }
        public System.String CUNAME { get; set; }
        public System.String CUATTN { get; set; }
        public System.String CUADDRESS { get; set; }
        public System.String CUCITY { get; set; }
        public System.String CUSTATE { get; set; }
        public System.Decimal? CUZIP { get; set; }
        public System.String CUDSL { get; set; }
        public System.Decimal? CUCBR { get; set; }
        public System.String TECHISR { get; set; }
        public System.DateTime? REQUESTDATE { get; set; }
        public System.Decimal? CONTRACT { get; set; }
        public System.Decimal? VERBALAGREEMENT { get; set; }
        public System.Decimal? OVERNIGHT { get; set; }
        public System.String REWARDSSSID { get; set; }
        public System.Int64? MODEMORIGSENT { get; set; }
        public System.Int64? SENDMODEM { get; set; }
        public System.Int64? SUPERVISORAPPROVAL { get; set; }
        public System.String SUPERVISORMODEM { get; set; }
        public System.DateTime? MODEMAPPDATE { get; set; }
        public System.String MODEMDRIVER { get; set; }
        public System.String MODEMENCAP { get; set; }
        public System.String REQUESTTYPE { get; set; }
        public System.String TECHCOMMENTS { get; set; }
        public System.String REWARDSCOMMENTS { get; set; }
        public System.String MODEMREASON { get; set; }
        public System.String TS_APPROVAL { get; set; }
        public System.String REW_EMP_ID { get; set; }
        public System.String EMP_ID { get; set; }
        public System.String SKU { get; set; }
        public System.String DCRIS_ORDER_NUMBER { get; set; }
        public System.Int16? MODEMPICKUP { get; set; }
        public System.DateTime? PICKEDUP_DT { get; set; }
        public System.DateTime? PURCHASE_DATE { get; set; }
        public System.String CUEMAIL { get; set; }
        public System.Decimal? TAG_SENT_TO_REWARDS { get; set; }
        public System.String PRODUCT_TYPE { get; set; }
        public System.String PENDING_REASON { get; set; }
        public System.String APPROVER_TYPE { get; set; }
        public System.String PINNACLE_EMP_ID { get; set; }
        public System.String SUPERVISOR_NAME { get; set; }
        public System.String SUPERVISOR_EMP_ID { get; set; }
        public System.Int64? LEASEMODEMAPPROVAL { get; set; }
        public System.String DONT_SEND_REASON { get; set; }
        public System.String DONT_SEND_REASON_DESC { get; set; }
        public System.String REQUEST_DENIED_BY { get; set; }
    }
    [Table("ERROR_LOG", Schema = "WNCCRM")]
    public partial class ERROR_LOG
    {
        [Key]
        public System.Decimal ERROR_LOG_ID { get; set; }
        public System.String WORKSTREAM_CD { get; set; }
        public System.String TABLE_NM { get; set; }
        public System.String PROCESS_NM { get; set; }
        public System.String MSG_CD { get; set; }
        public System.String MSG_DE { get; set; }
        public System.String SEVERITY_CD { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String PARAMETERS { get; set; }
    }
    [Table("ESP_JOB_RUN_DETAILS", Schema = "WNCCRM")]
    public partial class ESP_JOB_RUN_DETAILS
    {
        public System.Decimal? ESP_JOB_RUN_DETAILS_ID { get; set; }
        public System.String JOB_NAME { get; set; }
        public System.DateTime? JOB_START_TIME { get; set; }
        public System.String TASK_NAME { get; set; }
        public System.DateTime? TASK_START_TIME { get; set; }
        public System.DateTime? JOB_END_TIME { get; set; }
    }
    [Table("EVENT_APPLICATION", Schema = "WNCCRM")]
    public partial class EVENT_APPLICATION
    {
        [Key]
        [Column("EVENT_APPLICATION")]
        public System.String EVENT_APPLICATION_val { get; set; }
    }
    [Table("EXCLUDE_SERVICES", Schema = "WNCCRM")]
    public partial class EXCLUDE_SERVICES
    {
        public System.String UI_SCREEN { get; set; }
        public System.String UI_SCREEN_SECTION { get; set; }
        public System.String SERVICE_FAMILY { get; set; }
        public System.String SERVICE_TYPE { get; set; }
    }
    [Table("EXCLUDED_PROD_MAPPING", Schema = "WNCCRM")]
    public partial class EXCLUDED_PROD_MAPPING
    {
        public System.String MAPPING_TYPE { get; set; }
        public System.String FROM_BUS_SYSTEM { get; set; }
        public System.String TO_BUS_SYSTEM { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? EXTERNAL_OBJECT_ID { get; set; }
        public System.String EXTERNAL_NAME { get; set; }
        public System.Decimal? SPEC_GRP_ID { get; set; }
        public System.Decimal? TOP_ITEM_SPEC_ID { get; set; }
        public System.String EXTERNAL_CODE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.Decimal? PARENT_SERVICE_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("EXECUTIVE_OUTAGE_CONTACT", Schema = "WNCCRM")]
    public partial class EXECUTIVE_OUTAGE_CONTACT
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NOTIFY_TYPE { get; set; }
        public System.String ADDRESS { get; set; }
    }
    [Table("FIELD_TECH_ASSIGNMENT_TRACKING", Schema = "WNCCRM")]
    public partial class FIELD_TECH_ASSIGNMENT_TRACKING
    {
        [Key]
        public System.Decimal ASSIGNMENT_ID { get; set; }
        public System.String ACTIVITY_ID { get; set; }
        public System.String EMPLOYEE_ID { get; set; }
        public System.String BUCKET { get; set; }
        public System.String ACTIVITY_TYPE { get; set; }
        public System.DateTime? ACTIVITY_TIME { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String ENTIRY_NUMBER { get; set; }
        public System.String CBR { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String ERROR_MESSAGE_LOG { get; set; }
    }
    [Table("FORM_BEHAVIOR", Schema = "WNCCRM")]
    public partial class FORM_BEHAVIOR
    {
        [Key]
        public System.Decimal BEHAVIORID { get; set; }
        public System.String BEHAVIOR { get; set; }
    }
    [Table("FORM_CONSTRAINT", Schema = "WNCCRM")]
    public partial class FORM_CONSTRAINT
    {
        [Key]
        public System.Decimal CONSTRAINTID { get; set; }
        public System.String CONSTRAINT { get; set; }
    }
    [Table("FORM_ELEMENT", Schema = "WNCCRM")]
    public partial class FORM_ELEMENT
    {
        [Key]
        public System.Decimal ELEMENTID { get; set; }
        public System.String TAGNAME { get; set; }
    }
    [Table("FORM_FOLLOW_UP_ACTIONS", Schema = "WNCCRM")]
    public partial class FORM_FOLLOW_UP_ACTIONS
    {
        public System.String CASE_ID { get; set; }
        public System.String CASE_STATUS { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String APPLICATION_NAME { get; set; }
        public System.String COMMENTS { get; set; }
        public System.String ACTION_TYPE { get; set; }
        public System.DateTime? ORIGINAL_DUE_DATE { get; set; }
        public System.DateTime? REVISED_DUE_DATE { get; set; }
        public System.DateTime? COMPLETED_DATE { get; set; }
        public System.String ACTION_NOTES { get; set; }
        public System.String ACTION_ID { get; set; }
        public System.String RESOLUTION { get; set; }
        public System.DateTime? RESOLUTION_DATE { get; set; }
    }
    [Table("FORM_INSTANCE", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE
    {
        [Key]
        public System.Decimal FORMID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String JQUERY { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.DateTime? DATEMODIFIED { get; set; }
        public System.String GROUPNAME { get; set; }
        public System.String CREATEDBYUSERID { get; set; }
        public System.String CREATEDBYUSERDISPLAY { get; set; }
        public System.String MODIFIEDBYUSERID { get; set; }
        public System.String MODIFIEDBYUSERDISPLAY { get; set; }
        public System.Decimal? SORTORDER { get; set; }
        public System.String UNIQUETAG { get; set; }
        public System.String IS_CLONEABLE_TO_ACCOUNTS { get; set; }
    }
    [Table("FORM_INSTANCE_BEHAVIOR", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_BEHAVIOR
    {
        [Key]
        public System.Decimal INSTANCEBEHAVIORID { get; set; }
        public System.Decimal SOURCEINSTANCEID { get; set; }
        public System.String SOURCEINSTANCEVALUE { get; set; }
        public System.Decimal? TARGETINSTANCEID { get; set; }
        public System.Decimal? TARGETGROUPID { get; set; }
        public System.Decimal TARGETBEHAVIORID { get; set; }
        public System.String JQUERY { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.String DATELASTMODIFIED { get; set; }
        public System.String FORMMODE { get; set; }
    }
    [Table("FORM_INSTANCE_BEHAVIOR_DATA", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_BEHAVIOR_DATA
    {
        [Key]
        public System.Decimal DATAID { get; set; }
        public System.Decimal INSTANCEBEHAVIORID { get; set; }
        public System.String NAME { get; set; }
        public System.String VALUE { get; set; }
    }
    [Table("FORM_INSTANCE_CONSTRAINT", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_CONSTRAINT
    {
        [Key]
        public System.Decimal INSTANCECONSTRAINTID { get; set; }
        public System.Decimal INSTANCEID { get; set; }
        public System.Decimal CONSTRAINTID { get; set; }
        public System.String VALUE { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.DateTime? DATELASTMODIFIED { get; set; }
        public System.String FORMMODE { get; set; }
    }
    [Table("FORM_INSTANCE_ELEMENT", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_ELEMENT
    {
        [Key]
        public System.Decimal INSTANCEID { get; set; }
        public System.Decimal GROUPID { get; set; }
        public System.Decimal ELEMENTID { get; set; }
        public System.String LABEL { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? SORTORDER { get; set; }
        public System.String VISIBLE { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.DateTime? DATELASTMODIFIED { get; set; }
        public System.String DATABINDGROUP { get; set; }
        public System.String DATABINDNAME { get; set; }
        public System.String FORMMODE { get; set; }
        public System.String ISLISTDISPLAY { get; set; }
    }
    [Table("FORM_INSTANCE_GROUP", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_GROUP
    {
        [Key]
        public System.Decimal GROUPID { get; set; }
        public System.Decimal FORMID { get; set; }
        public System.String TITLE { get; set; }
        public System.Decimal? SORTORDER { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.DateTime? DATELASTMODIFIED { get; set; }
    }
    [Table("FORM_INSTANCE_LOOKUP", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_LOOKUP
    {
        [Key]
        public System.Decimal INSTANCELOOKUPID { get; set; }
        public System.Decimal INSTANCEID { get; set; }
        public System.Decimal LOOKUPGROUP { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public System.DateTime? DATELASTMODIFIED { get; set; }
        public System.Decimal LOOKUPVALUEID { get; set; }
        public System.String FORMMODE { get; set; }
    }
    [Table("FORM_INSTANCE_LOOKUP_VALUE", Schema = "WNCCRM")]
    public partial class FORM_INSTANCE_LOOKUP_VALUE
    {
        public System.Decimal LOOKUPVALUEID { get; set; }
        public System.String TEXT { get; set; }
        public System.String VALUE { get; set; }
        public System.Decimal? SORTORDER { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OPTGROUP { get; set; }
        public System.Decimal? OPTGROUPSORTORDER { get; set; }
        [Key]
        public System.Decimal FORM_INSTANCE_LOOKUP_VALUE_ID { get; set; }
    }
    [Table("FORM_SUBMISSION", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION
    {
        [Key]
        public System.Decimal SUBMISSIONID { get; set; }
        public System.String APPLICATIONCONTEXT { get; set; }
        public System.Decimal FORMID { get; set; }
        public System.String CREATEDBYUSERID { get; set; }
        public System.String MODIFIEDBYUSERID { get; set; }
        public System.String CREATEDBYUSERDISPLAY { get; set; }
        public System.String MODIFIEDBYUSERDISPLAY { get; set; }
        public System.String SUBMITTEDBYUSERID { get; set; }
        public System.String SUBMITTEDBYUSERDISPLAY { get; set; }
        public System.String ISLOCKED { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? DATECREATED { get; set; }
        public System.DateTime? DATEMODIFIED { get; set; }
        public System.DateTime? DATESUBMITTED { get; set; }
        public System.DateTime? DATECLOSED { get; set; }
        public System.String CLOSEDBYUSERID { get; set; }
        public System.String CLOSEDBYUSERDISPLAY { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ENRICHMENT_STATUS { get; set; }
        public System.String ORDER_PROCESSING_STATUS { get; set; }
        public System.String ASSIGNED_TO_USER_ID { get; set; }
        public System.String ASSIGNED_TO_USER_DISPLAY { get; set; }
        public System.DateTime? DATE_ASSIGNED_TO { get; set; }
    }
    [Table("FORM_SUBMISSION_ELEMENT", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION_ELEMENT
    {
        [Key]
        public System.Decimal SUBMISSIONELEMENTID { get; set; }
        public System.Decimal FORMSUBMISSIONID { get; set; }
        public System.Decimal INSTANCEID { get; set; }
        public System.DateTime? DATECREATED { get; set; }
    }
    [Table("FORM_SUBMISSION_ELEMENT_EXT", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION_ELEMENT_EXT
    {
        [Key]
        public System.Decimal SUBMISSIONELEMENTEXTID { get; set; }
        public System.Decimal FORMSUBMISSIONID { get; set; }
        public System.Decimal INSTANCEID { get; set; }
        public System.DateTime? DATECREATED { get; set; }
    }
    [Table("FORM_SUBMISSION_VALUE", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION_VALUE
    {
        [Key]
        public System.String FORMSUBMISSIONVALUEID { get; set; }
        public System.Decimal SUBMISSIONELEMENTID { get; set; }
        public System.String VALUE { get; set; }
        public System.DateTime? DATECREATED { get; set; }
    }
    [Table("FORM_SUBMISSION_VALUE_CUSTOM", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION_VALUE_CUSTOM
    {
        [Key]
        public System.Decimal FORMINSTANCECUSTOMID { get; set; }
        public System.Decimal SUBMISSIONID { get; set; }
        public System.Decimal INSTANCEID { get; set; }
        public System.String ELEMENTUNIQUEID { get; set; }
        public System.String VALUE { get; set; }
    }
    [Table("FORM_SUBMISSION_VALUE_EXT", Schema = "WNCCRM")]
    public partial class FORM_SUBMISSION_VALUE_EXT
    {
        [Key]
        public System.Decimal FORMSUBMISSIONVALUEEXTID { get; set; }
        public System.Decimal? SUBMISSIONELEMENTEXTID { get; set; }
        public System.String VALUE { get; set; }
        public System.String CREATEDBYUSERDISPLAY { get; set; }
        public System.DateTime? DATECREATED { get; set; }
    }
    [Table("GEO_ADDRESS", Schema = "WNCCRM")]
    public partial class GEO_ADDRESS
    {
        [Key]
        public System.Decimal GEO_ADDRESS_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String CITY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String COUNTY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String ATTENTION { get; set; }
        public System.String RECIPIENT { get; set; }
        public System.String IS_VALIDATED { get; set; }
        public System.String IS_OVERRIDDEN { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("GOVERNMENT_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class GOVERNMENT_TYPE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("GR_CNTRL_BUCK_BY_STATES", Schema = "WNCCRM")]
    public partial class GR_CNTRL_BUCK_BY_STATES
    {
        [Key]
        public System.Decimal GCB_ID { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String BUCKET { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("GTEMP_CUST_ADDRESS", Schema = "WNCCRM")]
    public partial class GTEMP_CUST_ADDRESS
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SERVICE_ADDRESS { get; set; }
        public System.String LOCATION_NAME { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String STATE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String COUNTRY { get; set; }
    }
    [Table("GTMP_BUS_INTERACTION_ID", Schema = "WNCCRM")]
    public partial class GTMP_BUS_INTERACTION_ID
    {
        public System.Decimal? bus_interaction_id { get; set; }
    }
    [Table("GTMP_CONNECTION_ID", Schema = "WNCCRM")]
    public partial class GTMP_CONNECTION_ID
    {
        public System.Decimal? CONNECTION_ID { get; set; }
    }
    [Table("GTMP_TICKET_DETAILS", Schema = "WNCCRM")]
    public partial class GTMP_TICKET_DETAILS
    {
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String CIRCUIT_ID { get; set; }
        public System.String SERVICE_PHONE_NUMBER { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER1 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER2 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER3 { get; set; }
    }
    [Table("GTT_ACCOUNT", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("GTT_ACCOUNT_CONTACTS", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT_CONTACTS
    {
        public System.String CUSTOMER_STATUS { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String STREET_TYPE { get; set; }
        public System.String STREET_NUMBER_SUFFIX { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String SERVICE_ADDRESS { get; set; }
        public System.String CONTACT_TYPE { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.DateTime? DATE_OF_SALE { get; set; }
        public System.String DCRIS_ORDER_NO { get; set; }
        public System.Decimal? BUSINESS_INTERACTION_ID { get; set; }
    }
    [Table("GTT_ACCOUNT_NOTE_ASOC", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT_NOTE_ASOC
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? PRODUCT_END_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String ACTION { get; set; }
    }
    [Table("GTT_ACCOUNT_NOTES", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT_NOTES
    {
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? RN { get; set; }
        public System.String SERVICE_LOCATION { get; set; }
        public System.Decimal? ACCOUNT_NUMBER { get; set; }
        public System.String BODY { get; set; }
        public System.String SUBJECT { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String NOTE_TYPE { get; set; }
        public System.String IS_SYSTEM_GENERATED { get; set; }
        public System.DateTime? CRITICAL_END_DATE { get; set; }
        public System.String SOURCE_BUS_SYSTEM { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String DEPARTMENT_HEADER { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.Decimal? VERSION { get; set; }
        public System.Decimal? BUS_INTERACTION_NUMBER { get; set; }
        public System.String DEPARTMENT { get; set; }
        public System.String CREATED_USER_ID { get; set; }
        public System.String IS_SHARED { get; set; }
    }
    [Table("GTT_ACCOUNT_PARTY", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT_PARTY
    {
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
    }
    [Table("GTT_ACCOUNT_SERVICES", Schema = "WNCCRM")]
    public partial class GTT_ACCOUNT_SERVICES
    {
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String SERVICE_SPEC_NAME { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.String SERVICE_ITEM_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? IN_SERVICE_DATE { get; set; }
        public System.DateTime? DISCONNECT_DATE { get; set; }
        public System.Decimal? CONNECTION_ID { get; set; }
        public System.String CIRCUIT_ID { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String BILLING_TN { get; set; }
        public System.String MSS_INDICATOR { get; set; }
        public System.String SERVICE_LOCATION { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
    }
    [Table("GTT_ACCT_SERVICE_TN", Schema = "WNCCRM")]
    public partial class GTT_ACCT_SERVICE_TN
    {
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String SERVICE_SPEC_NAME { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.String SERVICE_ITEM_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? IN_SERVICE_DATE { get; set; }
        public System.DateTime? DISCONNECT_DATE { get; set; }
        public System.Decimal? CONNECTION_ID { get; set; }
        public System.String CIRCUIT_ID { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String BILLING_TN { get; set; }
        public System.String MSS_INDICATOR { get; set; }
    }
    [Table("GTT_ACCT_SERVICE_TN_1", Schema = "WNCCRM")]
    public partial class GTT_ACCT_SERVICE_TN_1
    {
        public System.String SERVICE_TN { get; set; }
        public System.String MSS_INDICATOR { get; set; }
    }
    [Table("GTT_ACCT_SERVICE_TN_2", Schema = "WNCCRM")]
    public partial class GTT_ACCT_SERVICE_TN_2
    {
        public System.String SERVICE_TN { get; set; }
        public System.String MSS_INDICATOR { get; set; }
        public System.String SERVICE_TYPE { get; set; }
    }
    [Table("GTT_ASOC_EXPIRED_RECENTLY", Schema = "WNCCRM")]
    public partial class GTT_ASOC_EXPIRED_RECENTLY
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ASOC_STATUS { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
    }
    [Table("GTT_ASOC_GID_ACTIVE", Schema = "WNCCRM")]
    public partial class GTT_ASOC_GID_ACTIVE
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ASOC_STATUS { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
    }
    [Table("GTT_DUP_CUST_ACCT_REL", Schema = "WNCCRM")]
    public partial class GTT_DUP_CUST_ACCT_REL
    {
        public System.String CUST_ACCT_REL_TYPE { get; set; }
        public System.Decimal? PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ROOT_GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("GTT_GID_SERVICE_TN_CKT", Schema = "WNCCRM")]
    public partial class GTT_GID_SERVICE_TN_CKT
    {
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String SERVICE_SPEC_NAME { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.String SERVICE_ITEM_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? IN_SERVICE_DATE { get; set; }
        public System.DateTime? DISCONNECT_DATE { get; set; }
        public System.Decimal? CONNECTION_ID { get; set; }
        public System.String CIRCUIT_ID { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String BILLING_TN { get; set; }
    }
    [Table("GTT_GLOBAL_ACCOUNT", Schema = "WNCCRM")]
    public partial class GTT_GLOBAL_ACCOUNT
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("GTT_INTERACTION_CONDITIONS", Schema = "WNCCRM")]
    public partial class GTT_INTERACTION_CONDITIONS
    {
        public System.String CODE { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String SEVERITY { get; set; }
        public System.String CONTEXT { get; set; }
    }
    [Table("GTT_INTERACTION_SUMMARY", Schema = "WNCCRM")]
    public partial class GTT_INTERACTION_SUMMARY
    {
        public System.String V_VALUE { get; set; }
        public System.String V_DESCRIPTION { get; set; }
        public System.Decimal? V_COUNT_RANGE { get; set; }
        public System.Decimal? V_TOTAL { get; set; }
        public System.String V_ISSELECTED { get; set; }
    }
    [Table("GTT_NEW_SALE_CONTACTS", Schema = "WNCCRM")]
    public partial class GTT_NEW_SALE_CONTACTS
    {
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String PHONE_NUMBER1 { get; set; }
        public System.String PHONE_NUMBER2 { get; set; }
        public System.String PHONE_NUMBER3 { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
    }
    [Table("GTT_NOTIFICATION_USER_PROFILE", Schema = "WNCCRM")]
    public partial class GTT_NOTIFICATION_USER_PROFILE
    {
        public System.Decimal? NOTIFICATION_ID { get; set; }
        public System.String USER_ID { get; set; }
        public System.Decimal? USER_OID { get; set; }
        public System.String PROFILE_DESC { get; set; }
        public System.Decimal? PROFILE_ID { get; set; }
        public System.String SOURCE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("GTT_PRD_TN_ALL_ACTIVE_B", Schema = "WNCCRM")]
    public partial class GTT_PRD_TN_ALL_ACTIVE_B
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("GTT_PRD_TN_FEAT_INACTIVE_A", Schema = "WNCCRM")]
    public partial class GTT_PRD_TN_FEAT_INACTIVE_A
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("GTT_PRD_TN_FEAT_INACTIVE_UPD", Schema = "WNCCRM")]
    public partial class GTT_PRD_TN_FEAT_INACTIVE_UPD
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("GTT_PRD_TN_SERV_INACTIVE", Schema = "WNCCRM")]
    public partial class GTT_PRD_TN_SERV_INACTIVE
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("GTT_PSR_ORDER_NOTES", Schema = "WNCCRM")]
    public partial class GTT_PSR_ORDER_NOTES
    {
        public System.Decimal? NOTES_ID { get; set; }
        public System.Decimal? DOCUMENT_NUMBER { get; set; }
        public System.Decimal? NOTES_SEQUENCE { get; set; }
        public System.String NOTE_TEXT { get; set; }
        public System.String USER_ID { get; set; }
        public System.DateTime? DATE_ENTERED { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? CIRCUIT_DESIGN_ID { get; set; }
        public System.Decimal? DOCUMENT_NUMBER_SRC { get; set; }
        public System.String SYSTEM_GEN_IND { get; set; }
        public System.String CIRCUIT_NOTE_IND { get; set; }
        public System.String EXCHANGE_CARRIER_CIRCUIT_ID { get; set; }
        public System.Decimal? LOCATION_ID { get; set; }
        public System.Decimal? LOCATION_ID_2 { get; set; }
    }
    [Table("GTT_SECURITY_AUDIT", Schema = "WNCCRM")]
    public partial class GTT_SECURITY_AUDIT
    {
        public System.Decimal? STEP_NUMBER { get; set; }
        public System.String SECURITY_PROFILE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String PLATFORM_NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
    }
    [Table("GTT_SERVICES_EXPIRED_RECENTLY", Schema = "WNCCRM")]
    public partial class GTT_SERVICES_EXPIRED_RECENTLY
    {
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
    }
    [Table("GTT_SERVICES_GID_ACTIVE", Schema = "WNCCRM")]
    public partial class GTT_SERVICES_GID_ACTIVE
    {
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
    }
    [Table("GTT_SUPPORT_FLAGS", Schema = "WNCCRM")]
    public partial class GTT_SUPPORT_FLAGS
    {
        public System.String ACTION { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SEGMENT { get; set; }
        public System.String REGION { get; set; }
        public System.String PROFILE { get; set; }
        public System.String REMEDY_CUSTOMER_TYPE { get; set; }
        public System.String ELNK_TOP_200 { get; set; }
        public System.String EMERGING_TECH { get; set; }
        public System.String PLATINUM { get; set; }
        public System.String REFERENCE_CUSTOMER { get; set; }
        public System.String RED_LIST { get; set; }
        public System.String RESERVED_1 { get; set; }
        public System.String RESERVED_2 { get; set; }
        public System.String RESERVED_3 { get; set; }
        public System.String LOADING_NOTES { get; set; }
    }
    [Table("GTT_VALIDATE_ACCT_TN", Schema = "WNCCRM")]
    public partial class GTT_VALIDATE_ACCT_TN
    {
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_NO { get; set; }
        public System.String SERVICE_TN { get; set; }
        public System.String STATUS { get; set; }
        public System.String ERROR { get; set; }
        public System.String SOURCE { get; set; }
        public System.String NAME { get; set; }
        public System.String SERVICE_ADDR { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String BUS_SYSTEM { get; set; }
    }
    [Table("GTT_VALIDATE_ASOC", Schema = "WNCCRM")]
    public partial class GTT_VALIDATE_ASOC
    {
        public System.String PLATFORM { get; set; }
        public System.String ASOC { get; set; }
        public System.Decimal? TOTAL_ACCOUNTS { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String ERROR { get; set; }
        public System.String SOURCE { get; set; }
    }
    [Table("GTT_VALIDATE_PRFL_USR", Schema = "WNCCRM")]
    public partial class GTT_VALIDATE_PRFL_USR
    {
        public System.String PROFILE_DESC { get; set; }
        public System.String USER_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.String SOURCE { get; set; }
        public System.String ERROR { get; set; }
    }
    [Table("GTT_VALIDATE_WC_RC", Schema = "WNCCRM")]
    public partial class GTT_VALIDATE_WC_RC
    {
        public System.String PLATFORM { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.String STATE { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String CITY { get; set; }
        public System.Decimal? TOTAL_ACCOUNTS { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String ERROR { get; set; }
        public System.String SOURCE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("GTT_XML", Schema = "WNCCRM")]
    public partial class GTT_XML
    {
        public System.String XML_STRING { get; set; }
    }
    [Table("HOLIDAY_APPT_CALENDAR", Schema = "WNCCRM")]
    public partial class HOLIDAY_APPT_CALENDAR
    {
        [Key]
        public System.Decimal HOLIDAY_APPT_CALENDAR_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String HOLIDAY_NAME { get; set; }
        public System.DateTime? START_HOLIDAY_DATE { get; set; }
        public System.DateTime? END_HOLIDAY_DATE { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
        public System.String NOTE { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("INTERACTION_WS_CONFIG", Schema = "WNCCRM")]
    public partial class INTERACTION_WS_CONFIG
    {
        [Key]
        public System.Decimal IAWC_ID { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String WS_ENDPOINT { get; set; }
        public System.String PREFETCH_COMMAND { get; set; }
        public System.Decimal? SOURCE_SYSTEM_LKUP_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? STALENESS_LIMIT { get; set; }
        public System.String WS_ENDPOINT_METHOD { get; set; }
        public System.Decimal? DASHBOARD_REGION_SPEC_ID { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String THRESHOLD { get; set; }
    }
    [Table("INVOICE_SPEC", Schema = "WNCCRM")]
    public partial class INVOICE_SPEC
    {
        [Key]
        public System.Decimal INVOICE_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String DELIVERY_TYPE { get; set; }
        public System.String FORMAT_TYPE { get; set; }
        public System.String METHOD_TYPE { get; set; }
        public System.String INVOICE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("IPTV_MARKETS", Schema = "WNCCRM")]
    public partial class IPTV_MARKETS
    {
        [Key]
        public System.Decimal ID { get; set; }
        public System.String EXCHANGE { get; set; }
        public System.String COUNTYNAME { get; set; }
        public System.String ISDEFAULT { get; set; }
        public System.String PLANTTYPE { get; set; }
        public System.String CIC { get; set; }
        public System.String LEGALENTITYNAME { get; set; }
        public System.String FRANCHISENAME { get; set; }
        public System.Decimal? NETLOCCODE { get; set; }
        public System.Decimal? HEADENDCODE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("IPTV_MARKETS_BW", Schema = "WNCCRM")]
    public partial class IPTV_MARKETS_BW
    {
        public System.String MSS_EXCHANGE { get; set; }
        public System.Int16? COUNTY_SEQNUM { get; set; }
        public System.String COUNTY_NAME { get; set; }
        public System.String PLANTTYPE { get; set; }
        public System.String CIC { get; set; }
        public System.String LEGALENTITYNAME { get; set; }
        public System.String FRANCHISE { get; set; }
        public System.String NETLOCCODE { get; set; }
        public System.String HEADEND_CODE { get; set; }
    }
    [Table("ISO_COUNTRY", Schema = "WNCCRM")]
    public partial class ISO_COUNTRY
    {
        [Key]
        public System.String ALPHA2_CODE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ALPHA3_CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ISO_SUBDIVISION", Schema = "WNCCRM")]
    public partial class ISO_SUBDIVISION
    {
        [Key]
        public System.String ISO_SUBDIVISION_CODE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SUBDIVISION_SUBCODE { get; set; }
        public System.String PARENT_SUBDIVISION_CODE { get; set; }
        public System.Decimal? SUBDIVISION_LEVEL { get; set; }
        public System.String NAME { get; set; }
        public System.String ISO_COUNTRY_ALPHA2_CODE { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ISPUSERACCOUNT", Schema = "WNCCRM")]
    public partial class ISPUSERACCOUNT
    {
        public System.String ACCOUNTNUMBER { get; set; }
        public System.String PRIMARYFLAG { get; set; }
        public System.String USERNAME { get; set; }
        public System.String EXTUSERID { get; set; }
        public System.String ALIAS { get; set; }
    }
    [Table("IVR_CALL_DETAILS", Schema = "WNCCRM")]
    public partial class IVR_CALL_DETAILS
    {
        public System.String IID { get; set; }
        public System.DateTime? BEGINTIME { get; set; }
        public System.DateTime? ENDTIME { get; set; }
        public System.String CUSTOMERNAME { get; set; }
        public System.String DIALEDNUMBER { get; set; }
        public System.String DNIS { get; set; }
        public System.String ANI { get; set; }
        public System.String CALLTN { get; set; }
        public System.String PRIMARYPHONE { get; set; }
        public System.String ACCOUNTNUMBER { get; set; }
        public System.String CUSTYPE { get; set; }
        public System.String CALLERTYPE { get; set; }
        public System.String BUSTYPE { get; set; }
        public System.String LANG { get; set; }
        public System.String STATE { get; set; }
        public System.String ZIPCODE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String SERVICES { get; set; }
        public System.String ORIGINALQUEUE { get; set; }
        public System.String VOICESERVERPORT { get; set; }
        public System.String CALLQUEUEASSIGN { get; set; }
        public System.String CALLERENTRY { get; set; }
        public System.String INTENTDESC { get; set; }
        public System.String AUTHENTICATED { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("JDE_INTERM_TABLE", Schema = "WNCCRM")]
    public partial class JDE_INTERM_TABLE
    {
        public System.Decimal? ORDER_CO { get; set; }
        public System.Decimal? ORDER_NUMBER { get; set; }
        public System.String OR_TY { get; set; }
        public System.String LINE_NUMBER { get; set; }
        public System.String BUSINESS_UNIT { get; set; }
        public System.String RELATED_ORDER { get; set; }
        public System.String ORDER_DATE { get; set; }
        public System.String ACTUAL_SHIP_DATE { get; set; }
        public System.String SECOND_ITEM_NUMBER { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String LN_TY { get; set; }
        public System.Decimal? QUANTITY_ORDERED { get; set; }
        public System.Decimal? QUANTITY_SHIPPED { get; set; }
        public System.String UNIT_COST { get; set; }
        public System.String EXTENDED_COST { get; set; }
        public System.String PRINT_MESSAGE { get; set; }
        public System.String ADDRESS_NUMBER { get; set; }
        public System.String LOT_SERIAL_NUMBER { get; set; }
        public System.String CONTAINER_ID { get; set; }
        public System.String MAILING_NAME { get; set; }
        public System.String ADDRESS_LINE_1 { get; set; }
        public System.String ADDRESS_LINE_2 { get; set; }
        public System.String ADDRESS_LINE_3 { get; set; }
        public System.String ADDRESS_LINE_4 { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String CITY { get; set; }
        public System.String ST { get; set; }
        public System.String ALPHA_NAME { get; set; }
        public System.String SALES_DETAIL { get; set; }
        public System.String SALES_HEADER { get; set; }
    }
    [Table("JDE_LICENSE_TABLE", Schema = "WNCCRM")]
    public partial class JDE_LICENSE_TABLE
    {
        public System.String POD { get; set; }
        public System.String SERIAL { get; set; }
        public System.String ADOM { get; set; }
        public System.String ITEM { get; set; }
        public System.String DT_ROWID { get; set; }
        public System.Decimal? DAYS { get; set; }
        public System.String CUSTOMER { get; set; }
        public System.String EXPIRATION { get; set; }
        public System.String TYPE { get; set; }
        public System.String CPE { get; set; }
    }
    [Table("LEXCOM_VOIP", Schema = "WNCCRM")]
    public partial class LEXCOM_VOIP
    {
        [Key]
        public System.String VOIP_KEY { get; set; }
        public System.String USERNAME { get; set; }
        public System.String PASSWORD { get; set; }
    }
    [Table("LIC_PIC_IPIC", Schema = "WNCCRM")]
    public partial class LIC_PIC_IPIC
    {
        public System.String CUST_CAMS_ID { get; set; }
        public System.String NPA { get; set; }
        public System.String NXX { get; set; }
        public System.String CUST_PHONE { get; set; }
        public System.String PIC { get; set; }
        public System.String PURPOSE { get; set; }
        public System.String IPIC { get; set; }
        public System.String CTRT_CODE { get; set; }
        public System.String CTRT_ORG_COMPANY { get; set; }
        public System.DateTime? TRAIT_EFF_DATE { get; set; }
        public System.String PIC_LOCK { get; set; }
    }
    [Table("LIC_PIC_IPIC_OT", Schema = "WNCCRM")]
    public partial class LIC_PIC_IPIC_OT
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PIC_LOCK { get; set; }
    }
    [Table("LIC_PIC_IPIC_OT1", Schema = "WNCCRM")]
    public partial class LIC_PIC_IPIC_OT1
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PIC_LOCK { get; set; }
    }
    [Table("LOAD_SERVICE_DATA", Schema = "WNCCRM")]
    public partial class LOAD_SERVICE_DATA
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.DateTime? MIN_START_DATE { get; set; }
        public System.DateTime? MAX_END_DATE { get; set; }
    }
    [Table("LOCATION", Schema = "WNCCRM")]
    public partial class LOCATION
    {
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.Decimal? POSTAL_CODE { get; set; }
        public System.String HEADEND_CODE { get; set; }
        public System.String GELOBLOEK { get; set; }
        public System.String PLANT_TYPE { get; set; }
        public System.String CIC { get; set; }
        public System.String LEGAL_ENTITY_NAME { get; set; }
        public System.String FRANCHISE { get; set; }
        public System.Decimal? LOCATION_ID { get; set; }
    }
    [Table("LOGIN_HISTORY", Schema = "WNCCRM")]
    public partial class LOGIN_HISTORY
    {
        [Key]
        public System.Decimal LOGINHISTORYID { get; set; }
        public System.String EMPLOYEEID { get; set; }
        public System.String USERNAME { get; set; }
        public System.DateTime LOGINDATE { get; set; }
        public System.DateTime? LOGOUTDATE { get; set; }
        public System.String APPLICATIONNAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String PROFILE_TYPE { get; set; }
        public System.String BROWSER { get; set; }
        public System.String DEVICE_TYPE { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String OS_TYPE { get; set; }
        public System.String SESSIONGUID { get; set; }
    }
    [Table("MARKET_PROGRAM", Schema = "WNCCRM")]
    public partial class MARKET_PROGRAM
    {
        [Key]
        public System.Decimal MARKET_PROGRAM_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
        public System.String IS_UNIVERSAL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("MESSAGE_PROPERTIES", Schema = "WNCCRM")]
    public partial class MESSAGE_PROPERTIES
    {
        [Key]
        public System.Decimal PROPTERTY_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String LOCALE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("METADATA_LOG", Schema = "WNCCRM")]
    public partial class METADATA_LOG
    {
        public System.Decimal? LOG_ID { get; set; }
        public System.String ERROR_VALUE { get; set; }
        public System.String ERROR_MSG { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
    }
    [Table("MISSING_ACCOUNT_DOCS", Schema = "WNCCRM")]
    public partial class MISSING_ACCOUNT_DOCS
    {
        public System.String GLOBALACCOUNTID { get; set; }
        public System.String CATEGORYTYPE { get; set; }
        public System.String CATEGORYID { get; set; }
        public System.String SALESFORCEDOCUMENTNAME { get; set; }
        public System.String NEWCATEGORYID { get; set; }
        public System.String SEQ_NUM { get; set; }
        public System.String PROCESSED { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String OTHER_NUMBER { get; set; }
    }
    [Table("MISSING_OPPORTUNITY_DOCS", Schema = "WNCCRM")]
    public partial class MISSING_OPPORTUNITY_DOCS
    {
        public System.String GLOBALACCOUNTID { get; set; }
        public System.String CATEGORYTYPE { get; set; }
        public System.String CATEGORYID { get; set; }
        public System.String SALESFORCEDOCUMENTNAME { get; set; }
        public System.String NEWCATEGORYID { get; set; }
        public System.String SEQ_NUM { get; set; }
        public System.String PROCESSED { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String OTHER_NUMBER { get; set; }
    }
    [Table("MISSING_QUOTE_DOCS", Schema = "WNCCRM")]
    public partial class MISSING_QUOTE_DOCS
    {
        public System.String GLOBALACCOUNTID { get; set; }
        public System.String CATEGORYTYPE { get; set; }
        public System.String CATEGORYID { get; set; }
        public System.String SALESFORCEDOCUMENTNAME { get; set; }
        public System.String NEWCATEGORYID { get; set; }
        public System.String SEQ_NUM { get; set; }
        public System.String PROCESSED { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String OTHER_NUMBER { get; set; }
    }
    [Table("MISSING_ROLE_IN_WINCARE", Schema = "WNCCRM")]
    public partial class MISSING_ROLE_IN_WINCARE
    {
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String ROLE_IN_WINFORCE { get; set; }
        public System.String CORRESPONDING_ROLE_IN_WINCARE { get; set; }
        public System.Decimal? MAP_GLOBAL_ACCOUNT_PARTY_ID { get; set; }
    }
    [Table("MOBILITY_ACTIVITY_SUMMARY", Schema = "WNCCRM")]
    public partial class MOBILITY_ACTIVITY_SUMMARY
    {
        public System.DateTime? CALENDAR_DATE { get; set; }
        public System.String USER_ID { get; set; }
        public System.String PROFILE_TYPE { get; set; }
        public System.Decimal? WNC_COUNT { get; set; }
        public System.Decimal? MOBILITY_COUNT { get; set; }
        public System.Decimal? NON_MOBILITY_COUNT { get; set; }
    }
    [Table("MOBILITY_ACTIVITY_SUMMARY_HRLY", Schema = "WNCCRM")]
    public partial class MOBILITY_ACTIVITY_SUMMARY_HRLY
    {
        public System.DateTime? CALENDAR_DATE { get; set; }
        public System.String USER_ID { get; set; }
        public System.String PROFILE_TYPE { get; set; }
        public System.Decimal? WNC_COUNT { get; set; }
        public System.Decimal? MOBILITY_COUNT { get; set; }
        public System.Decimal? NON_MOBILITY_COUNT { get; set; }
    }
    [Table("MONITOR_CONFIG", Schema = "WNCCRM")]
    public partial class MONITOR_CONFIG
    {
        [Key]
        public System.Decimal MONITOR_CONFIG_ID { get; set; }
        public System.String SPAN_START_TIME { get; set; }
        public System.Decimal? DATA_FREQUENCY { get; set; }
        public System.String DAY_OF_WEEK { get; set; }
        public System.Decimal? THRESHOLD_COUNT { get; set; }
        public System.String SEVERITY { get; set; }
        public System.Decimal? MONITOR_ENTITY_ID { get; set; }
    }
    [Table("MONITOR_ENTITY", Schema = "WNCCRM")]
    public partial class MONITOR_ENTITY
    {
        [Key]
        public System.Decimal ENTITY_ID { get; set; }
        public System.String SCHEMA { get; set; }
        public System.String TABLENAME { get; set; }
        public System.String PROCESS_NAME { get; set; }
        public System.String COLUMN_NAME { get; set; }
    }
    [Table("MONITOR_LOG", Schema = "WNCCRM")]
    public partial class MONITOR_LOG
    {
        [Key]
        public System.Decimal LOG_ID { get; set; }
        public System.String PROCESS_NAME { get; set; }
        public System.Decimal? MONITOR_CONFIG_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("MSTR_ALL_ESP_JOBS", Schema = "WNCCRM")]
    public partial class MSTR_ALL_ESP_JOBS
    {
        public System.Int32 MSTR_ALL_ESP_JOBS_ID { get; set; }
        [Key]
        public System.String JOB_NAME { get; set; }
        public System.String JOB_STATE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String JOB_TYPE { get; set; }
        public System.String JOB_FOR { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("MV_ACTIVITY_LOG", Schema = "WNCCRM")]
    public partial class MV_ACTIVITY_LOG
    {
        public System.String TICKET_NUMBER { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.String DISPOSITION { get; set; }
    }
    [Table("MV_ALL_PRODUCT_MAPPING", Schema = "WNCCRM")]
    public partial class MV_ALL_PRODUCT_MAPPING
    {
        public System.String MAPPING_TYPE { get; set; }
        public System.String FROM_BUS_SYSTEM { get; set; }
        public System.String TO_BUS_SYSTEM { get; set; }
        public System.Decimal? SPEC_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TYPE { get; set; }
        public System.String IS_CIRCUIT { get; set; }
        public System.String IS_GLOBAL { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String MAPPING_STATE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String SERVICE_OBJECT_STATE { get; set; }
        public System.String SERVICE_TO_SERVICE_TYPE_STATE { get; set; }
        public System.Decimal? ST__SERVICE_SPEC_ID { get; set; }
        public System.String ST_SERVICE_NAME { get; set; }
        public System.String ST_SERVICE_TYPE { get; set; }
        public System.String ST_OBJECT_STATE { get; set; }
        public System.Decimal? SFE__SERVICE_SPEC_ID { get; set; }
        public System.String SFE_SERVICE_NAME { get; set; }
        public System.String SFE_SERVICE_TYPE { get; set; }
        public System.String SFE_OBJECT_STATE { get; set; }
        public System.String ST_TO_SF_STATE { get; set; }
        public System.Decimal? SFAM__SERVICE_SPEC_ID { get; set; }
        public System.String SFAM_SERVICE_NAME { get; set; }
        public System.String SFAM_SERVICE_TYPE { get; set; }
        public System.String SFAM_OBJECT_STATE { get; set; }
        public System.String ST_TO_TSF_STATE { get; set; }
        public System.String TICKET_SERVICE_FAMILY { get; set; }
        public System.String ST_TO_TST_STATE { get; set; }
        public System.String TICKET_SERVICE_TYPE { get; set; }
        public System.Decimal? FROM_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? TO_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_APP_SESSION_LATEST", Schema = "WNCCRM")]
    public partial class MV_APP_SESSION_LATEST
    {
        public System.String USERID { get; set; }
        public System.Decimal APPLICATION_SESSION_ID { get; set; }
    }
    [Table("MV_BILL_ITEMS_BROADVIEW", Schema = "WNCCRM")]
    public partial class MV_BILL_ITEMS_BROADVIEW
    {
        public System.String SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String EXTERNAL_ID { get; set; }
    }
    [Table("MV_BILL_ITEMS_CAMS", Schema = "WNCCRM")]
    public partial class MV_BILL_ITEMS_CAMS
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String EXTERNAL_ID { get; set; }
    }
    [Table("MV_BILL_ITEMS_REVCHAIN", Schema = "WNCCRM")]
    public partial class MV_BILL_ITEMS_REVCHAIN
    {
        public System.Int64? SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
    }
    [Table("MV_BILLING_ACCOUNTS", Schema = "WNCCRM")]
    public partial class MV_BILLING_ACCOUNTS
    {
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("MV_BILLINGACCOUNT", Schema = "WNCCRM")]
    public partial class MV_BILLINGACCOUNT
    {
        public System.Decimal BILLINGACCOUNTID { get; set; }
        public System.String NAME { get; set; }
        public System.String ACCOUNTNUMBER { get; set; }
        public System.String TAXJURIS { get; set; }
        public System.String PRIMARYPHONENUMBER { get; set; }
        public System.Decimal? BILLINGADDRESSID { get; set; }
        public System.String ACCOUNTTYPE { get; set; }
        public System.Decimal? NOTELISTID { get; set; }
        public System.DateTime CREATEDDATE { get; set; }
        public System.Decimal CREATEDBYLOGINHISTORYID { get; set; }
        public System.DateTime? UPDATEDDATE { get; set; }
        public System.Decimal? UPDATEDBYLOGINHISTORYID { get; set; }
        public System.DateTime? CONTROLDATE { get; set; }
        public System.String INTEGRATIONTRANSACTIONID { get; set; }
        public System.Decimal? PRIORBILLINGACCOUNTID { get; set; }
        public System.String ISDELETED { get; set; }
        public System.DateTime? DEPRECATEDDATE { get; set; }
        public System.Decimal? GLOBALACCOUNTID { get; set; }
        public System.String CUSTOMERTYPE { get; set; }
    }
    [Table("MV_CA_OPEN_ORDERS", Schema = "WNCCRM")]
    public partial class MV_CA_OPEN_ORDERS
    {
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal? ORDER_AGE { get; set; }
        public System.DateTime? LAST_STATUS_DATE { get; set; }
        public System.String ORDER_NUMBER { get; set; }
        public System.String ORDER_TYPE { get; set; }
        public System.String IS_OPEN_STATUS { get; set; }
        public System.String ORDER_STATUS { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PROJECT_COORDINATOR_NAME { get; set; }
        public System.String USER_TYPE { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
    }
    [Table("MV_CA_OPEN_TICKETS", Schema = "WNCCRM")]
    public partial class MV_CA_OPEN_TICKETS
    {
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal? TICKET_AGE { get; set; }
        public System.DateTime? LAST_STATUS_DATE { get; set; }
        public System.String TICKET_NUMBER { get; set; }
        public System.String TICKET_STATUS { get; set; }
        public System.String IS_OPEN_STATUS { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String USER_TYPE { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
    }
    [Table("MV_CAR_LERG_1", Schema = "WNCCRM")]
    public partial class MV_CAR_LERG_1
    {
        public System.String OCN { get; set; }
        public System.String OCN_NAME { get; set; }
        public System.String ABBRE_OCN_NAME { get; set; }
        public System.String OCN_STATE { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String OVERALL_OCN { get; set; }
        public System.String LAST_KNOWN_ADDR { get; set; }
        public System.String LASTN { get; set; }
        public System.String FIRSTN { get; set; }
        public System.String MI { get; set; }
        public System.String CO_NAME_SPEC { get; set; }
        public System.String TITLE { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String FLOOR { get; set; }
        public System.String RM { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.String ZIP { get; set; }
        public System.String PHONE { get; set; }
        public System.String TARGET_OCN { get; set; }
        public System.String OVERALL_TARGET_OCN { get; set; }
        public System.String FILLER1 { get; set; }
    }
    [Table("MV_CAR_LERG_5", Schema = "WNCCRM")]
    public partial class MV_CAR_LERG_5
    {
        public System.String REGION { get; set; }
        public System.String LATA { get; set; }
        public System.String LATA_NAME { get; set; }
        public System.String NPA1 { get; set; }
        public System.String NPA2 { get; set; }
        public System.String NPA3 { get; set; }
        public System.String NPA4 { get; set; }
        public System.String NPA5 { get; set; }
        public System.String NPA6 { get; set; }
        public System.String NPA7 { get; set; }
        public System.String NPA8 { get; set; }
        public System.String NPA9 { get; set; }
        public System.String NPA10 { get; set; }
        public System.String NPA11 { get; set; }
        public System.String NPA12 { get; set; }
        public System.String NPA13 { get; set; }
        public System.String NPA14 { get; set; }
        public System.String NPA15 { get; set; }
        public System.String NPA16 { get; set; }
        public System.String NPA17 { get; set; }
        public System.String NPA18 { get; set; }
        public System.String NPA19 { get; set; }
        public System.String NPA20 { get; set; }
        public System.String NPA21 { get; set; }
        public System.String NPA22 { get; set; }
        public System.String NPA23 { get; set; }
        public System.String NPA24 { get; set; }
        public System.String NPA25 { get; set; }
        public System.String NPA26 { get; set; }
        public System.String NPA27 { get; set; }
        public System.String NPA28 { get; set; }
        public System.String NPA29 { get; set; }
        public System.String NPA30 { get; set; }
        public System.String NPA31 { get; set; }
        public System.String NPA32 { get; set; }
        public System.String NPA33 { get; set; }
        public System.String NPA34 { get; set; }
        public System.String NPA35 { get; set; }
        public System.String NPA36 { get; set; }
        public System.String NPA37 { get; set; }
        public System.String NPA38 { get; set; }
        public System.String NPA39 { get; set; }
        public System.String NPA40 { get; set; }
        public System.String NPA41 { get; set; }
        public System.String NPA42 { get; set; }
        public System.String NPA43 { get; set; }
        public System.String NPA44 { get; set; }
        public System.String NPA45 { get; set; }
        public System.String NPA46 { get; set; }
        public System.String NPA47 { get; set; }
        public System.String NPA48 { get; set; }
        public System.String NPA49 { get; set; }
        public System.String NPA50 { get; set; }
        public System.String FILLER { get; set; }
    }
    [Table("MV_CAR_LERG_6", Schema = "WNCCRM")]
    public partial class MV_CAR_LERG_6
    {
        public System.String LATA { get; set; }
        public System.String LATA_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? EFF_DATE { get; set; }
        public System.String NPA { get; set; }
        public System.String NXX { get; set; }
        public System.String BLOCK_ID { get; set; }
        public System.String COC_TYPE { get; set; }
        public System.String SSC { get; set; }
        public System.String DIND { get; set; }
        public System.String TD_EO { get; set; }
        public System.String TD_AT { get; set; }
        public System.String PORTABLE { get; set; }
        public System.String AOCN { get; set; }
        public System.String OCN { get; set; }
        public System.String LOC_NAME { get; set; }
        public System.String LOC_INDEX { get; set; }
        public System.String LOC_STATE { get; set; }
        public System.String RC_ABBRE { get; set; }
        public System.String RC_TYPE { get; set; }
        public System.String LINE_FR { get; set; }
        public System.String LINE_TO { get; set; }
        public System.String SWITCH { get; set; }
        public System.String SHA_INDICATOR { get; set; }
        public System.String TEST_LINE { get; set; }
        public System.String TEST_LINE_RESPONSE { get; set; }
        public System.DateTime? TEST_LINE_EXPIRE_DATE { get; set; }
        public System.String POOLED { get; set; }
        public System.String RC_LOC_LATA { get; set; }
        public System.DateTime? CREATION_DATE { get; set; }
        public System.DateTime? E_STATUS_DATE { get; set; }
        public System.DateTime? LAST_MOD_DATE { get; set; }
    }
    [Table("MV_CAR_LERG_7", Schema = "WNCCRM")]
    public partial class MV_CAR_LERG_7
    {
        public System.String LATA { get; set; }
        public System.String LATA_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? EFF_DATE { get; set; }
        public System.String SWITCH { get; set; }
        public System.String EQP_TYPE { get; set; }
        public System.String AOCN { get; set; }
        public System.String FILLER1 { get; set; }
        public System.String OCN { get; set; }
        public System.String V_COORD { get; set; }
        public System.String H_COORD { get; set; }
        public System.String IDDD { get; set; }
        public System.String SW_STREET { get; set; }
        public System.String SW_CITY { get; set; }
        public System.String SW_STATE { get; set; }
        public System.String SW_ZIP { get; set; }
        public System.String PT_CODE_FLAG { get; set; }
        public System.String CL_45_SW { get; set; }
        public System.String SOF_1_EO { get; set; }
        public System.String SOF_2_HOST { get; set; }
        public System.String SOF_3_REM { get; set; }
        public System.String SOF_4_DA { get; set; }
        public System.String SOF_5_45 { get; set; }
        public System.String SOF_6_WIRELESS { get; set; }
        public System.String FILLER6 { get; set; }
        public System.String FILLER2 { get; set; }
        public System.String SOF_12_FG_B_TDM { get; set; }
        public System.String SOF_13_FG_C_TDM { get; set; }
        public System.String SOF_14_FG_D_TDM { get; set; }
        public System.String SOF_15_OS_TDM { get; set; }
        public System.String SOF_16_INT_OFC { get; set; }
        public System.String SOF_17_DA_TDM { get; set; }
        public System.String SOF_18_911_TANDEM { get; set; }
        public System.String FILLER7 { get; set; }
        public System.String SOF_20_LOCAL_TDM { get; set; }
        public System.String SOF_21_INTRA_TDM { get; set; }
        public System.String SOF_22_CS_DATA_TDM { get; set; }
        public System.String SOF_23_BCR5 { get; set; }
        public System.String SOF_24_BCR6 { get; set; }
        public System.String SOF_25_PRI_64 { get; set; }
        public System.String SOF_26_ISDN_MULT { get; set; }
        public System.String SOF_27_ISDN_FS { get; set; }
        public System.String FILLER8 { get; set; }
        public System.String FILLER9 { get; set; }
        public System.String FILLER10 { get; set; }
        public System.String FILLER3 { get; set; }
        public System.String SOF_34_STP { get; set; }
        public System.String SOF_35_CCS_AC { get; set; }
        public System.String FILLER4 { get; set; }
        public System.String SOF_37_800_SSP { get; set; }
        public System.String SOF_38_LNP { get; set; }
        public System.String SOF_39_LNP_SCP { get; set; }
        public System.String SOF_40_10D_GTT_SCP { get; set; }
        public System.String SOF_41_AIN_ISCP_SCP { get; set; }
        public System.String SOF_42_CIP { get; set; }
        public System.String SOF_43_CSP { get; set; }
        public System.String FILLER5 { get; set; }
        public System.String SOF_45_SW_56 { get; set; }
        public System.String SOF_46_FGD_56 { get; set; }
        public System.String SOF_47_FGD_64 { get; set; }
        public System.String SOF_48_INT_PRSUB { get; set; }
        public System.String SOF_49_CLL_AGNT { get; set; }
        public System.String SOF_50_TRK_GATEWY { get; set; }
        public System.String SOF_51_ACC_GATEWY { get; set; }
        public System.DateTime? CREATION_DATE { get; set; }
        public System.DateTime? E_STATUS_DATE { get; set; }
        public System.DateTime? LAST_MOD_DATE { get; set; }
        public System.String CLN_INDICATOR { get; set; }
        public System.String BILL_TO_ROA { get; set; }
        public System.String SEND_TO_ROA { get; set; }
    }
    [Table("MV_CAR_LERG_8", Schema = "WNCCRM")]
    public partial class MV_CAR_LERG_8
    {
        public System.String LATA { get; set; }
        public System.String LATA_NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? EFF_DATE { get; set; }
        public System.String STATE { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String RC_TYPE { get; set; }
        public System.String RC_FULL_NAME { get; set; }
        public System.String MAJOR_V { get; set; }
        public System.String MAJOR_H { get; set; }
        public System.String MINOR_V { get; set; }
        public System.String MINOR_H { get; set; }
        public System.String NPA { get; set; }
        public System.String NPA2 { get; set; }
        public System.String NPA3 { get; set; }
        public System.String NPA4 { get; set; }
        public System.String NPA5 { get; set; }
        public System.String NPA6 { get; set; }
        public System.String NPA7 { get; set; }
        public System.String NPA8 { get; set; }
        public System.String NPA9 { get; set; }
        public System.String NPA10 { get; set; }
        public System.String MTA1 { get; set; }
        public System.String MTA2 { get; set; }
        public System.String SPLIT_INDICATOR { get; set; }
        public System.String EMP_OVER_NPA1 { get; set; }
        public System.String EMP_OVER_NPA2 { get; set; }
        public System.String EMP_OVER_NPA3 { get; set; }
        public System.String EMP_OVER_NPA4 { get; set; }
    }
    [Table("MV_CAV_CAMS_ACCT_INSERT_WF", Schema = "WNCCRM")]
    public partial class MV_CAV_CAMS_ACCT_INSERT_WF
    {
        public System.Decimal GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String CUSTTYPE__C { get; set; }
        public System.String NAME { get; set; }
        public System.String ENTERPRISE_STATUS__C { get; set; }
        public System.String PLATFORM__C { get; set; }
        public System.String MARKETTYPE__C { get; set; }
        public System.String SUBMARKET_TYPE__C { get; set; }
        public System.String GOV_T_TYPE__C { get; set; }
        public System.String SERVICESTATUS__C { get; set; }
        public System.Double? ESTIMATEDMONTHLYREVENUE__C { get; set; }
        public System.String CPNIPIN__C { get; set; }
        public System.String SIC_CODE__C { get; set; }
        public System.String BILLINGSTREET { get; set; }
        public System.String BILLINGCITY { get; set; }
        public System.String BILLINGSTATECODE__C { get; set; }
        public System.String BILLINGSTATE { get; set; }
        public System.String BILLINGPOSTALCODE { get; set; }
        public System.String BILLINGCOUNTRYCODE__C { get; set; }
        public System.String BILLINGCOUNTRY { get; set; }
        public System.String BILLING_SYSTEM__C { get; set; }
        public System.String BILLINGACCOUNTNUMBER__C { get; set; }
        public System.String MAIN_BTN__C { get; set; }
        public System.String PLATFORMCOMPONENTS__C { get; set; }
        public System.String CAMP_CREATE__C { get; set; }
        public System.String CAMP_ESTABLISH__C { get; set; }
        public System.String CAMP_FINISH__C { get; set; }
        public System.String CAMP_REGISTER__C { get; set; }
        public System.String CAMP_UPDATE__C { get; set; }
        public System.String BUSINESS_SIZE__C { get; set; }
        public System.String BUSINESS_SIZE_TEXT__C { get; set; }
        public System.String LOCATION_NAME__C { get; set; }
        public System.String SHIPPINGSTREET { get; set; }
        public System.String SRV_MSAG_NUMBER__C { get; set; }
        public System.String SRV_MSAG_STREET_NUMBER_SUFFIX { get; set; }
        public System.String SRV_MSAG_PRE_DIRECTION__C { get; set; }
        public System.String SRV_MSAG_STREET_NAME__C { get; set; }
        public System.String SRV_MSAG_STREET_SUFFIX__C { get; set; }
        public System.String SRV_MSAG_POST_DIRECTION__C { get; set; }
        public System.String SHIPPINGCITY { get; set; }
        public System.String SRV_MSAG_CITY__C { get; set; }
        public System.String STATECODE__C { get; set; }
        public System.String SHIPPINGSTATE { get; set; }
        public System.String SRV_MSAG_STATE__C { get; set; }
        public System.String SRV_MSAG_ZIP__C { get; set; }
        public System.String SHIPPINGPOSTALCODE { get; set; }
        public System.String SHIPPINGCOUNTRYCODE__C { get; set; }
        public System.String SHIPPINGCOUNTRY { get; set; }
        public System.String SHIPPINGCOUNTY__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_1__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_2__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_3__C { get; set; }
        public System.String SERVICE_ADDRESS_VERIFIED__C { get; set; }
        public System.String BILLING_ADDRESS_VERIFIED__C { get; set; }
        public System.String SVC_ADDRESS_VALIDATED__C { get; set; }
        public System.String ADDRESS_VALID_INDICATOR__C { get; set; }
        public System.String ISOVERRIDDEN_SERVICE_ADDRESS { get; set; }
        public System.String ISOVERRIDDEN_BILLING_ADDRESS { get; set; }
        public System.String NEW_CONSTRUCTION__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LATITUDE__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LONGITUDE__C { get; set; }
        public System.String SERVING_WIRE_CENTER__C { get; set; }
        public System.String RATE_CENTER__C { get; set; }
        public System.String LATA__C { get; set; }
        public System.String OCN__C { get; set; }
        public System.String EXCHANGE_TEXT__C { get; set; }
        public System.String NPA_NXX__C { get; set; }
        public System.String COE__C { get; set; }
        public System.String PCODE__C { get; set; }
        public System.String OWNERID_UAT05 { get; set; }
        public System.String OWNERID_PROD { get; set; }
        public System.String ACCT_EXECUTIVE_ID { get; set; }
        public System.String ACCT_MANAGER_ID { get; set; }
        public System.String ACCOUNT_STATUS__C { get; set; }
        public System.String RECORD_TYPE_NAME__C { get; set; }
        public System.String RECORDTYPEID { get; set; }
    }
    [Table("MV_CAV_CAMS_ACCT_INSERT_WF2", Schema = "WNCCRM")]
    public partial class MV_CAV_CAMS_ACCT_INSERT_WF2
    {
        public System.Decimal GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String CUSTTYPE__C { get; set; }
        public System.String NAME { get; set; }
        public System.String ENTERPRISE_STATUS__C { get; set; }
        public System.String PLATFORM__C { get; set; }
        public System.String MARKETTYPE__C { get; set; }
        public System.String SUBMARKET_TYPE__C { get; set; }
        public System.String GOV_T_TYPE__C { get; set; }
        public System.String SERVICESTATUS__C { get; set; }
        public System.Double? ESTIMATEDMONTHLYREVENUE__C { get; set; }
        public System.String CPNIPIN__C { get; set; }
        public System.String SIC_CODE__C { get; set; }
        public System.String BILLINGSTREET { get; set; }
        public System.String BILLINGCITY { get; set; }
        public System.String BILLINGSTATECODE__C { get; set; }
        public System.String BILLINGSTATE { get; set; }
        public System.String BILLINGPOSTALCODE { get; set; }
        public System.String BILLINGCOUNTRYCODE__C { get; set; }
        public System.String BILLINGCOUNTRY { get; set; }
        public System.String BILLING_SYSTEM__C { get; set; }
        public System.String BILLINGACCOUNTNUMBER__C { get; set; }
        public System.String MAIN_BTN__C { get; set; }
        public System.String PLATFORMCOMPONENTS__C { get; set; }
        public System.String CAMP_CREATE__C { get; set; }
        public System.String CAMP_ESTABLISH__C { get; set; }
        public System.String CAMP_FINISH__C { get; set; }
        public System.String CAMP_REGISTER__C { get; set; }
        public System.String CAMP_UPDATE__C { get; set; }
        public System.String BUSINESS_SIZE__C { get; set; }
        public System.String BUSINESS_SIZE_TEXT__C { get; set; }
        public System.String LOCATION_NAME__C { get; set; }
        public System.String SHIPPINGSTREET { get; set; }
        public System.String SRV_MSAG_NUMBER__C { get; set; }
        public System.String SRV_MSAG_STREET_NUMBER_SUFFIX { get; set; }
        public System.String SRV_MSAG_PRE_DIRECTION__C { get; set; }
        public System.String SRV_MSAG_STREET_NAME__C { get; set; }
        public System.String SRV_MSAG_STREET_SUFFIX__C { get; set; }
        public System.String SRV_MSAG_POST_DIRECTION__C { get; set; }
        public System.String SHIPPINGCITY { get; set; }
        public System.String SRV_MSAG_CITY__C { get; set; }
        public System.String STATECODE__C { get; set; }
        public System.String SHIPPINGSTATE { get; set; }
        public System.String SRV_MSAG_STATE__C { get; set; }
        public System.String SRV_MSAG_ZIP__C { get; set; }
        public System.String SHIPPINGPOSTALCODE { get; set; }
        public System.String SHIPPINGCOUNTRYCODE__C { get; set; }
        public System.String SHIPPINGCOUNTRY { get; set; }
        public System.String SHIPPINGCOUNTY__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_1__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_2__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_3__C { get; set; }
        public System.String SERVICE_ADDRESS_VERIFIED__C { get; set; }
        public System.String BILLING_ADDRESS_VERIFIED__C { get; set; }
        public System.String SVC_ADDRESS_VALIDATED__C { get; set; }
        public System.String ADDRESS_VALID_INDICATOR__C { get; set; }
        public System.String ISOVERRIDDEN_SERVICE_ADDRESS { get; set; }
        public System.String ISOVERRIDDEN_BILLING_ADDRESS { get; set; }
        public System.String NEW_CONSTRUCTION__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LATITUDE__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LONGITUDE__C { get; set; }
        public System.String SERVING_WIRE_CENTER__C { get; set; }
        public System.String RATE_CENTER__C { get; set; }
        public System.String LATA__C { get; set; }
        public System.String OCN__C { get; set; }
        public System.String EXCHANGE_TEXT__C { get; set; }
        public System.String NPA_NXX__C { get; set; }
        public System.String COE__C { get; set; }
        public System.String PCODE__C { get; set; }
        public System.String OWNERID_UAT05 { get; set; }
        public System.String OWNERID_PROD { get; set; }
        public System.String ACCT_EXECUTIVE_ID { get; set; }
        public System.String ACCT_MANAGER_ID { get; set; }
        public System.String ACCOUNT_STATUS__C { get; set; }
        public System.String RECORD_TYPE_NAME__C { get; set; }
        public System.String RECORDTYPEID { get; set; }
    }
    [Table("MV_CAV_CAMS_ACCT_MERGE_WF", Schema = "WNCCRM")]
    public partial class MV_CAV_CAMS_ACCT_MERGE_WF
    {
        public System.String SALES_FORCE_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String CUSTTYPE__C { get; set; }
        public System.String NAME { get; set; }
        public System.String ENTERPRISE_STATUS__C { get; set; }
        public System.String PLATFORM__C { get; set; }
        public System.String MARKETTYPE__C { get; set; }
        public System.String SUBMARKET_TYPE__C { get; set; }
        public System.String GOV_T_TYPE__C { get; set; }
        public System.String SERVICESTATUS__C { get; set; }
        public System.Double? ESTIMATEDMONTHLYREVENUE__C { get; set; }
        public System.String CPNIPIN__C { get; set; }
        public System.String SIC_CODE__C { get; set; }
        public System.String BILLINGSTREET { get; set; }
        public System.String BILLINGCITY { get; set; }
        public System.String BILLINGSTATECODE__C { get; set; }
        public System.String BILLINGSTATE { get; set; }
        public System.String BILLINGPOSTALCODE { get; set; }
        public System.String BILLINGCOUNTRYCODE__C { get; set; }
        public System.String BILLINGCOUNTRY { get; set; }
        public System.String BILLING_SYSTEM__C { get; set; }
        public System.String BILLINGACCOUNTNUMBER__C { get; set; }
        public System.String MAIN_BTN__C { get; set; }
        public System.String PLATFORMCOMPONENTS__C { get; set; }
        public System.String CAMP_CREATE__C { get; set; }
        public System.String CAMP_ESTABLISH__C { get; set; }
        public System.String CAMP_FINISH__C { get; set; }
        public System.String CAMP_REGISTER__C { get; set; }
        public System.String CAMP_UPDATE__C { get; set; }
        public System.String BUSINESS_SIZE__C { get; set; }
        public System.String BUSINESS_SIZE_TEXT__C { get; set; }
        public System.String LOCATION_NAME__C { get; set; }
        public System.String SHIPPINGSTREET { get; set; }
        public System.String SRV_MSAG_NUMBER__C { get; set; }
        public System.String SRV_MSAG_STREET_NUMBER_SUFFIX { get; set; }
        public System.String SRV_MSAG_PRE_DIRECTION__C { get; set; }
        public System.String SRV_MSAG_STREET_NAME__C { get; set; }
        public System.String SRV_MSAG_STREET_SUFFIX__C { get; set; }
        public System.String SRV_MSAG_POST_DIRECTION__C { get; set; }
        public System.String SHIPPINGCITY { get; set; }
        public System.String SRV_MSAG_CITY__C { get; set; }
        public System.String STATECODE__C { get; set; }
        public System.String SHIPPINGSTATE { get; set; }
        public System.String SRV_MSAG_STATE__C { get; set; }
        public System.String SRV_MSAG_ZIP__C { get; set; }
        public System.String SHIPPINGPOSTALCODE { get; set; }
        public System.String SHIPPINGCOUNTRYCODE__C { get; set; }
        public System.String SHIPPINGCOUNTRY { get; set; }
        public System.String SHIPPINGCOUNTY__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_1__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_2__C { get; set; }
        public System.String SERVICE_ADDRESS_UNIT_3__C { get; set; }
        public System.String SERVICE_ADDRESS_VERIFIED__C { get; set; }
        public System.String BILLING_ADDRESS_VERIFIED__C { get; set; }
        public System.String SVC_ADDRESS_VALIDATED__C { get; set; }
        public System.String ADDRESS_VALID_INDICATOR__C { get; set; }
        public System.String ISOVERRIDDEN_SERVICE_ADDRESS { get; set; }
        public System.String ISOVERRIDDEN_BILLING_ADDRESS { get; set; }
        public System.String NEW_CONSTRUCTION__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LATITUDE__C { get; set; }
        public System.Double? SERVICE_ADDRESS_LONGITUDE__C { get; set; }
        public System.String SERVING_WIRE_CENTER__C { get; set; }
        public System.String RATE_CENTER__C { get; set; }
        public System.String LATA__C { get; set; }
        public System.String OCN__C { get; set; }
        public System.String EXCHANGE_TEXT__C { get; set; }
        public System.String NPA_NXX__C { get; set; }
        public System.String COE__C { get; set; }
        public System.String PCODE__C { get; set; }
        public System.String OWNERID_UAT05 { get; set; }
        public System.String OWNERID_PROD { get; set; }
        public System.String ACCT_EXECUTIVE_ID { get; set; }
        public System.String ACCT_MANAGER_ID { get; set; }
        public System.String ACCOUNT_STATUS__C { get; set; }
        public System.String RECORD_TYPE_NAME__C { get; set; }
        public System.String RECORDTYPEID { get; set; }
    }
    [Table("MV_CONTACT_CLNUP_DUP_AP_NAME_1", Schema = "WNCCRM")]
    public partial class MV_CONTACT_CLNUP_DUP_AP_NAME_1
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String ACCT_PARTY_TYPE { get; set; }
        public System.String TITLE { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String MIDDLE_INITIAL { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME_SUFFIX { get; set; }
        public System.String NAME { get; set; }
        public System.String COMPANY_NAME { get; set; }
        public System.String DEPARTMENT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String DO_NOT_EMAIL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
    }
    [Table("MV_CONTACT_CLNUP_NAME_EMPH_1", Schema = "WNCCRM")]
    public partial class MV_CONTACT_CLNUP_NAME_EMPH_1
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String CM_OBJECT_STATE { get; set; }
        public System.String PRIMARY_EMAIL_FLAG { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
    }
    [Table("MV_CONTACT_NAME_MISMATCH", Schema = "WNCCRM")]
    public partial class MV_CONTACT_NAME_MISMATCH
    {
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String FIRST_NAME_IN_WINCARE { get; set; }
        public System.String LAST_NAME_IN_WINCARE { get; set; }
        public System.String NAME_IN_WINCARE { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String WINFORCE_CONTACT_ID { get; set; }
        public System.String FIRST_NAME_IN_WINFORCE { get; set; }
        public System.String LAST_NAME_IN_WINFORCE { get; set; }
        public System.String NAME_IN_WINFORCE { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
    }
    [Table("MV_CRM_SECURITY_ALL", Schema = "WNCCRM")]
    public partial class MV_CRM_SECURITY_ALL
    {
        public System.Decimal? COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? GROUPBYID { get; set; }
        public System.Decimal? ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String FLAG_SEC_ENABLED { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String SECURITY_PROFILE { get; set; }
        public System.String IS_READONLY { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String DASHBOARD_NAME { get; set; }
        public System.String PORTLET_NAME { get; set; }
    }
    [Table("MV_CRM_SECURITY_PAGEITEM", Schema = "WNCCRM")]
    public partial class MV_CRM_SECURITY_PAGEITEM
    {
        public System.Decimal? COMMAND_SECURITY_ID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.String COMMAND_TYPE { get; set; }
        public System.String COMMAND_ITEM_LABEL { get; set; }
        public System.String COMMAND_ITEM_URL { get; set; }
        public System.String URL_PARAMETERS { get; set; }
        public System.String COMMAND_ITEM_ID { get; set; }
        public System.Decimal? GROUPBYID { get; set; }
        public System.Decimal? ORDERBYID { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.String FLAG_SEC_ENABLED { get; set; }
        public System.Decimal? FORMID { get; set; }
        public System.String PAGE_TRANSITION { get; set; }
        public System.String IS_MOBILE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String SECURITY_PROFILE { get; set; }
        public System.String IS_READONLY { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String DASHBOARD_NAME { get; set; }
        public System.String PORTLET_NAME { get; set; }
    }
    [Table("MV_CURRENT_PROVIDERS", Schema = "WNCCRM")]
    public partial class MV_CURRENT_PROVIDERS
    {
        public System.String OCN_NAME { get; set; }
    }
    [Table("MV_CUST_ACCT_PASS_MTHLY_REV", Schema = "WNCCRM")]
    public partial class MV_CUST_ACCT_PASS_MTHLY_REV
    {
        [Key]
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? MONTHLY_REVENUE { get; set; }
    }
    [Table("MV_CUST_ACCT_REL", Schema = "WNCCRM")]
    public partial class MV_CUST_ACCT_REL
    {
        public System.Decimal CUST_ACCT_REL_ID { get; set; }
        public System.Decimal? PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ROOT_GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("MV_CUST_ADVOCATE_PARENT_GIDS", Schema = "WNCCRM")]
    public partial class MV_CUST_ADVOCATE_PARENT_GIDS
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CHILD_ACCOUNT_NAME { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String USER_TYPE { get; set; }
    }
    [Table("MV_D_CUSTOMER_DEMARC_VX", Schema = "WNCCRM")]
    public partial class MV_D_CUSTOMER_DEMARC_VX
    {
        [Key]
        public System.Decimal CUSTOMER_DEMARC_KEY { get; set; }
        public System.DateTime? FROM_EFF_DATE { get; set; }
        public System.DateTime? TO_EFF_DATE { get; set; }
        public System.String CURRENT_FLAG { get; set; }
        public System.String LOCATION_ACCOUNT_ID { get; set; }
        public System.String BILLABLE_ACCOUNT_ID { get; set; }
        public System.String BILLING_SYSTEM { get; set; }
        public System.String CORP_ID { get; set; }
        public System.String CUSTOMER_DIVISION { get; set; }
        public System.String REASON { get; set; }
        public System.String HH_ID { get; set; }
        public System.String BUSINESS_SEGMENT { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? SALES_ORDER_KEY { get; set; }
        public System.String SALES_CHANNEL_SEG { get; set; }
        public System.String DELIVERY_CHANNEL_SEG { get; set; }
        public System.String CARE_CHANNEL_SEG { get; set; }
        public System.String REPAIR_CHANNEL_SEG { get; set; }
        public System.String MARKETING_CHANNEL_SEG { get; set; }
        public System.String COLLECTIONS_CHANNEL_SEG { get; set; }
        public System.String IVR_SEG { get; set; }
        public System.String BILL_BRAND_SEG { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? V1_CUSTOMER_DEMARC_KEY { get; set; }
        public System.String V1_CUSTOMER_DIVISION { get; set; }
        public System.Decimal? V2_CUSTOMER_DEMARC_KEY { get; set; }
        public System.String V2_CUSTOMER_DIVISION { get; set; }
        public System.Decimal? V3_CUSTOMER_DEMARC_KEY { get; set; }
        public System.String V3_CUSTOMER_DIVISION { get; set; }
        public System.Decimal? DF_CUSTOMER_ID { get; set; }
        public System.Decimal? DF_PARTY_ID { get; set; }
        public System.Decimal? DF_ENTERPRISE_ID { get; set; }
        public System.Decimal? DF_RESOURCE_ID { get; set; }
        public System.Decimal? DF_SALES_ID { get; set; }
        public System.Decimal? DF_SERVICE_ID { get; set; }
        public System.Decimal? DF_PRODUCT_ID { get; set; }
        public System.Decimal? DF_ADDRESS_ID { get; set; }
        public System.DateTime? DF_CREATE_DT { get; set; }
        public System.DateTime? DF_UPDATE_DT { get; set; }
        public System.Decimal? DF_FIRST_REC_ID { get; set; }
        public System.Decimal? DF_LAST_REC_ID { get; set; }
        public System.String DF_DATA_SRC_CD { get; set; }
    }
    [Table("MV_DBA_OBJECTS", Schema = "WNCCRM")]
    public partial class MV_DBA_OBJECTS
    {
        public System.String NAME { get; set; }
        public System.DateTime? LAST_REFRESH_DATE { get; set; }
        public System.String OWNER { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String SUBOBJECT_NAME { get; set; }
        public System.Decimal? OBJECT_ID { get; set; }
        public System.Decimal? DATA_OBJECT_ID { get; set; }
        public System.String OBJECT_TYPE { get; set; }
        public System.DateTime? CREATED { get; set; }
        public System.DateTime? LAST_DDL_TIME { get; set; }
        public System.String TIMESTAMP { get; set; }
        public System.String STATUS { get; set; }
        public System.String TEMPORARY { get; set; }
        public System.String GENERATED { get; set; }
        public System.String SECONDARY { get; set; }
        public System.Decimal? NAMESPACE { get; set; }
        public System.String EDITION_NAME { get; set; }
    }
    [Table("MV_DBA_TAB_PRIVS", Schema = "WNCCRM")]
    public partial class MV_DBA_TAB_PRIVS
    {
        public System.String NAME { get; set; }
        public System.DateTime? LAST_REFRESH_DATE { get; set; }
        public System.String GRANTEE { get; set; }
        public System.String OWNER { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.String GRANTOR { get; set; }
        public System.String PRIVILEGE { get; set; }
        public System.String GRANTABLE { get; set; }
        public System.String HIERARCHY { get; set; }
    }
    [Table("MV_DUP_CNTCT_IN_LST_7_DYS", Schema = "WNCCRM")]
    public partial class MV_DUP_CNTCT_IN_LST_7_DYS
    {
        public System.String NAME_NEW { get; set; }
        public System.String PHONE_NUMBER_NEW { get; set; }
        public System.String EMAIL_ADDRESS_NEW { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID_NEW { get; set; }
        public System.String CREATED_USER_NEW { get; set; }
        public System.DateTime? CREATED_DATE_NEW { get; set; }
        public System.String NAME_OLD { get; set; }
        public System.String PHONE_NUMBER_OLD { get; set; }
        public System.String EMAIL_ADDRESS_OLD { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID_OLD { get; set; }
        public System.String CREATED_USER_OLD { get; set; }
        public System.DateTime? CREATED_DATE_OLD { get; set; }
    }
    [Table("MV_DUP_CONTACT_CUST_HIERARCHY", Schema = "WNCCRM")]
    public partial class MV_DUP_CONTACT_CUST_HIERARCHY
    {
        public System.String CONTACT_NAME { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.Decimal? DUPE_COUNT { get; set; }
        public System.Decimal? ROOT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
    }
    [Table("MV_EMPLOYEES", Schema = "WNCCRM")]
    public partial class MV_EMPLOYEES
    {
        public System.String IDM_USERNAME { get; set; }
        public System.String EMAIL { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String DEPARTMENT { get; set; }
        public System.String TITLE { get; set; }
        public System.String LOCATION { get; set; }
        public System.String LEGACY_COMPANY { get; set; }
        public System.String OFFICE_ADDRESS { get; set; }
        public System.String OFFICE_CITY { get; set; }
        public System.String OFFIC_STATE { get; set; }
        public System.String OFFICE_ZIPCODE { get; set; }
        public System.String MANGER_USERNAME { get; set; }
        public System.String REGION { get; set; }
        public System.String SALES_CHANNEL { get; set; }
        public System.String COST_CENTER { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
        public System.String IS_MANAGER { get; set; }
        public System.String EMPLOYEE_TYPE { get; set; }
        public System.String KINTNA { get; set; }
        public System.String METASOLV { get; set; }
        public System.String MAX_AS400 { get; set; }
        public System.String CONQUEST { get; set; }
        public System.String EXCHANGE { get; set; }
        public System.String ACTIVE_DIRECTORY { get; set; }
        public System.Decimal? AS400_REP_ID { get; set; }
        public System.String EMPLOYEE_FULL_NAME { get; set; }
        public System.String SUPERVISOR_FULL_NAME { get; set; }
        public System.String PS_ENUM { get; set; }
        public System.String APTIS { get; set; }
        public System.String WIN_ENUM { get; set; }
        public System.String EMP_STATUS { get; set; }
        public System.DateTime? EMP_TERM_DATE { get; set; }
        public System.String UPDATE_BY { get; set; }
        public System.DateTime? UPDATE_DATE { get; set; }
        public System.String CREATE_BY { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String REC_STS { get; set; }
        public System.String EMP_STATUS_IDM { get; set; }
        public System.Decimal? KINTANTA_USERID { get; set; }
        public System.String WIN_DEPT_CODE { get; set; }
        public System.String WIN_LOC_CODE { get; set; }
        public System.String WIN_JOB_CODE { get; set; }
        public System.String WIN_JOB_FAMILY { get; set; }
        public System.String WIN_POSITION_NUMBER { get; set; }
        public System.String WIN_SOA { get; set; }
        public System.String REPORTS_TO_POS { get; set; }
        public System.String REPORTS_TO_NAME { get; set; }
        public System.Decimal? EMP_KEY { get; set; }
        public System.String PC_ID { get; set; }
        public System.String NPS_ID { get; set; }
        public System.String TDS_ID { get; set; }
        public System.DateTime? POS_NUMBER_START { get; set; }
        public System.String ICARE { get; set; }
        public System.String CAMS_ID { get; set; }
    }
    [Table("MV_IP_LOOKUP", Schema = "WNCCRM")]
    public partial class MV_IP_LOOKUP
    {
        public System.String NAME { get; set; }
        public System.String STARTADDRSTRING { get; set; }
        public System.Decimal? STARTADDR { get; set; }
        public System.Decimal? ENDADDR { get; set; }
        public System.Int64? BLOCKSIZE { get; set; }
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("MV_KPI_DUNS_SOURCE", Schema = "WNCCRM")]
    public partial class MV_KPI_DUNS_SOURCE
    {
        public System.String KPI_BILLING_SYSTEM { get; set; }
        public System.String CRM_BILLING_SYSTEM { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCATION_ACCOUNT_ID { get; set; }
        public System.String BILLING_ACCOUNT_ID { get; set; }
        public System.String WINFORCE_ID { get; set; }
        public System.String CURRENT_CAMP_DUNS { get; set; }
        public System.String RETENTION_STATUS { get; set; }
        public System.String WIN_DUNS { get; set; }
        public System.String DUNSNBR { get; set; }
        public System.String HEADQUARTERDUNSNBR { get; set; }
        public System.String WIN_DUNS_BILL { get; set; }
        public System.String WIN_DUN_DERV_BY_1 { get; set; }
        public System.String DUNSNBR_1 { get; set; }
        public System.String HEADQUARTERDUNSNBR_1 { get; set; }
    }
    [Table("MV_MATCHING_CONATCT_WC_WF", Schema = "WNCCRM")]
    public partial class MV_MATCHING_CONATCT_WC_WF
    {
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.String GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String ROLE { get; set; }
    }
    [Table("MV_MISSING_CONTACT_IN_WC", Schema = "WNCCRM")]
    public partial class MV_MISSING_CONTACT_IN_WC
    {
        public System.String GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String GLOBALACCTPARTYID__C { get; set; }
        public System.String ID { get; set; }
    }
    [Table("MV_MSS_ELINK_ID", Schema = "WNCCRM")]
    public partial class MV_MSS_ELINK_ID
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String MSS_ID { get; set; }
        public System.String MSS_BUS_SYSTEM_NAME { get; set; }
        public System.String ELINK_ID { get; set; }
        public System.String TRIM_ELINK_ID { get; set; }
        public System.String ELINK_BUS_SYSTEM_NAME { get; set; }
    }
    [Table("MV_MV_REFRESH_IP", Schema = "WNCCRM")]
    public partial class MV_MV_REFRESH_IP
    {
        public System.Decimal? SID { get; set; }
        [Column("SERIAL#")]
        public System.Decimal? SERIAL_ { get; set; }
        public System.String CURRMVOWNER { get; set; }
        public System.String CURRMVNAME { get; set; }
        public System.DateTime? DT { get; set; }
    }
    [Table("MV_OPTIM_WIFI_HEALTH_PROFILE", Schema = "WNCCRM")]
    public partial class MV_OPTIM_WIFI_HEALTH_PROFILE
    {
        public System.DateTime? OPTIM_DATE { get; set; }
        public System.String CUST_MODEM_SN { get; set; }
        public System.String SENT_PHONE { get; set; }
        public System.String CAMS_ID { get; set; }
        public System.Decimal? OPTIM_WIFI_HEALTH_SCORE { get; set; }
    }
    [Table("MV_ORDER_PHASE_MSS", Schema = "WNCCRM")]
    public partial class MV_ORDER_PHASE_MSS
    {
        public System.Decimal? ORDER { get; set; }
        public System.String TYPE { get; set; }
        public System.String ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
        public System.Decimal? ORIGIN_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVIEW { get; set; }
        public System.Decimal? DESIGN { get; set; }
        public System.Decimal? NETWORK { get; set; }
        public System.Decimal? INSTALLATION { get; set; }
        public System.Decimal? ACTIVATION { get; set; }
        public System.Decimal? PROGRESS { get; set; }
        public System.String HOLD_STATUS { get; set; }
        public System.String EXPEDITE { get; set; }
        public System.DateTime? PTD { get; set; }
        public System.DateTime? ACTIVATION_DATE { get; set; }
        public System.DateTime? FORECAST { get; set; }
        public System.String ADDRESS { get; set; }
        public System.String PROVISIONING_PLAN { get; set; }
        public System.Decimal? ACTIVITY { get; set; }
        public System.String PM_NAME { get; set; }
        public System.String PC_EID { get; set; }
        public System.String PC_NAME { get; set; }
        public System.String SALES_EID { get; set; }
        public System.String SALES_NAME { get; set; }
        public System.DateTime? FOLLOWUP_DATE { get; set; }
        public System.DateTime? LOOP_ORDER_DATE { get; set; }
        public System.DateTime? FOC_DATE { get; set; }
        public System.DateTime? LOOP_INSTALLED_DATE { get; set; }
        public System.Decimal? ORDER_AGE_DAYS { get; set; }
        public System.String LEC_NAME { get; set; }
        public System.String PORT_SIZE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("MV_ORDER_PHASE_MSS_STG", Schema = "WNCCRM")]
    public partial class MV_ORDER_PHASE_MSS_STG
    {
        public System.Decimal? ORDER { get; set; }
        public System.String TYPE { get; set; }
        public System.String ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
        public System.Decimal? ORIGIN_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVIEW { get; set; }
        public System.Decimal? DESIGN { get; set; }
        public System.Decimal? NETWORK { get; set; }
        public System.Decimal? INSTALLATION { get; set; }
        public System.Decimal? ACTIVATION { get; set; }
        public System.Decimal? PROGRESS { get; set; }
        public System.String HOLD_STATUS { get; set; }
        public System.String EXPEDITE { get; set; }
        public System.DateTime? PTD { get; set; }
        public System.DateTime? ACTIVATION_DATE { get; set; }
        public System.DateTime? FORECAST { get; set; }
        public System.String ADDRESS { get; set; }
        public System.String PROVISIONING_PLAN { get; set; }
        public System.Decimal? ACTIVITY { get; set; }
        public System.String PM_NAME { get; set; }
        public System.String PC_EID { get; set; }
        public System.String PC_NAME { get; set; }
        public System.String SALES_EID { get; set; }
        public System.String SALES_NAME { get; set; }
        public System.DateTime? FOLLOWUP_DATE { get; set; }
        public System.DateTime? LOOP_ORDER_DATE { get; set; }
        public System.DateTime? FOC_DATE { get; set; }
        public System.DateTime? LOOP_INSTALLED_DATE { get; set; }
        public System.Decimal? ORDER_AGE_DAYS { get; set; }
        public System.String LEC_NAME { get; set; }
        public System.String PORT_SIZE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("MV_PLATFORM_ASOC", Schema = "WNCCRM")]
    public partial class MV_PLATFORM_ASOC
    {
        public System.String CODE { get; set; }
        public System.String PLATFORM_NAME { get; set; }
        public System.Decimal? TOTAL_ACCOUNTS { get; set; }
    }
    [Table("MV_PLATFORM_WC_RC", Schema = "WNCCRM")]
    public partial class MV_PLATFORM_WC_RC
    {
        public System.String PLATFORM_NAME { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.Decimal? TOTAL_ACCOUNTS { get; set; }
    }
    [Table("MV_PRD_TN_ALL_ACTIVE_B", Schema = "WNCCRM")]
    public partial class MV_PRD_TN_ALL_ACTIVE_B
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("MV_PRD_TN_FEAT_INACTIVE_A", Schema = "WNCCRM")]
    public partial class MV_PRD_TN_FEAT_INACTIVE_A
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("MV_PRD_TN_FEAT_INACTIVE_UPD", Schema = "WNCCRM")]
    public partial class MV_PRD_TN_FEAT_INACTIVE_UPD
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String FEATURE_NAME { get; set; }
    }
    [Table("MV_PRD_TN_SERV_INACTIVE", Schema = "WNCCRM")]
    public partial class MV_PRD_TN_SERV_INACTIVE
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("MV_PRD_TN_SERVICES_DLY", Schema = "WNCCRM")]
    public partial class MV_PRD_TN_SERVICES_DLY
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.Decimal? PRODUCT_SPEC_ID { get; set; }
    }
    [Table("MV_PRIME_CONTACT_IN_WC_STG", Schema = "WNCCRM")]
    public partial class MV_PRIME_CONTACT_IN_WC_STG
    {
        public System.String ID { get; set; }
        public System.String TITLE { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME { get; set; }
        public System.String DEPARTMENT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String DO_NOT_EMAIL { get; set; }
    }
    [Table("MV_PRIME_CONTACT_IN_WC_STG1", Schema = "WNCCRM")]
    public partial class MV_PRIME_CONTACT_IN_WC_STG1
    {
        public System.String ID { get; set; }
        public System.String TITLE { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME { get; set; }
        public System.String DEPARTMENT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String DO_NOT_EMAIL { get; set; }
    }
    [Table("MV_PRIOR_COMPANY", Schema = "WNCCRM")]
    public partial class MV_PRIOR_COMPANY
    {
        public System.String PRIOR_COMPANY { get; set; }
    }
    [Table("MV_PRODUCT_CHILD_DLY", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_CHILD_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_CHILD_DLY_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_CHILD_DLY_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_CHILD_PRE_WKD_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_CHILD_PRE_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE_CRM { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.DateTime? END_DATE_CRM { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY_CRM { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME_CRM { get; set; }
        public System.String NAME { get; set; }
        public System.Double? REVENUE_CRM { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID_CRM { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE_CRM { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS_CRM { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME_CRM { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("MV_PRODUCT_CHILD_WKD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_CHILD_WKD
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_CHILD_WKD_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_CHILD_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_COMPONENT", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_COMPONENT
    {
        public System.String EXTERNAL_SOURCE_SYSTEM { get; set; }
        public System.String FEATURE_NAME { get; set; }
        public System.String PRODUCT_CATEGORY { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String REVENUE_CATEGORY { get; set; }
        public System.String SERVICE_NAME { get; set; }
    }
    [Table("MV_PRODUCT_PENDING_NIGHTLY", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_PENDING_NIGHTLY
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.Decimal? PRODUCT_SPEC_ID { get; set; }
    }
    [Table("MV_PRODUCT_PRE_WKD_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_PRE_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE_CRM { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.DateTime? END_DATE_CRM { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY_CRM { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME_CRM { get; set; }
        public System.String NAME { get; set; }
        public System.Double? REVENUE_CRM { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID_CRM { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE_CRM { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS_CRM { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME_CRM { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("MV_PRODUCT_STG_DLY", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_STG_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_STG_DLY_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_STG_DLY_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_STG_WKD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_STG_WKD
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCT_STG_WKD_UPD", Schema = "WNCCRM")]
    public partial class MV_PRODUCT_STG_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("MV_PRODUCTS_CAMS", Schema = "WNCCRM")]
    public partial class MV_PRODUCTS_CAMS
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String MONTHLY_RECURRING { get; set; }
        public System.String EXTERNAL_ID { get; set; }
    }
    [Table("MV_RETAIL_STORES", Schema = "WNCCRM")]
    public partial class MV_RETAIL_STORES
    {
        [Key]
        public System.Int64 STORE_ID { get; set; }
        public System.String LOCATION { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String ADDRESS { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.String ZIP { get; set; }
        public System.String HOURS { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("MV_RETAIL_STORES_EXCHANGES", Schema = "WNCCRM")]
    public partial class MV_RETAIL_STORES_EXCHANGES
    {
        public System.Decimal? STORE_ID { get; set; }
        public System.String NPANXX { get; set; }
    }
    [Table("MV_SA_COMMS_LOC_MRR", Schema = "WNCCRM")]
    public partial class MV_SA_COMMS_LOC_MRR
    {
        public System.DateTime? BUSREV_MONTH { get; set; }
        public System.String ID_TYPE { get; set; }
        public System.String REV_TYPE { get; set; }
        public System.String ID_VALUE { get; set; }
        public System.String GAID { get; set; }
        public System.Decimal? TOTAL_AMOUNT { get; set; }
        public System.Decimal? DIRECT_AMOUNT { get; set; }
        public System.Decimal? CHANNEL_AMOUNT { get; set; }
        public System.Decimal? REFERRAL_AMOUNT { get; set; }
    }
    [Table("MV_SERVICE_LOCATIONS", Schema = "WNCCRM")]
    public partial class MV_SERVICE_LOCATIONS
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION { get; set; }
    }
    [Table("MV_SERVICE_PLATFORM_CUST_CNT", Schema = "WNCCRM")]
    public partial class MV_SERVICE_PLATFORM_CUST_CNT
    {
        public System.String PLATFORM { get; set; }
        public System.String SERVICE { get; set; }
        public System.Decimal PLATFORM_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.Decimal? TOTAL_ACCOUNTS { get; set; }
    }
    [Table("MV_SERVICES_EXPIRED_RECENTLY", Schema = "WNCCRM")]
    public partial class MV_SERVICES_EXPIRED_RECENTLY
    {
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("MV_SMB_ENT_SOURCE", Schema = "WNCCRM")]
    public partial class MV_SMB_ENT_SOURCE
    {
        public System.String KPI_BILLING_SYSTEM { get; set; }
        public System.String CRM_BILLING_SYSTEM { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? KPI_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCATION_ACCOUNT_ID { get; set; }
        public System.String BILLABLE_ACCOUNT_ID { get; set; }
        public System.String WINFORCE_ID { get; set; }
        public System.String HH_ID { get; set; }
        public System.String CURRENT_WNCCRM_VALUE { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String REASON { get; set; }
        public System.String CUSTOMER_DIVISION { get; set; }
    }
    [Table("MV_SOURCE_FIN_LOC_ATTR", Schema = "WNCCRM")]
    public partial class MV_SOURCE_FIN_LOC_ATTR
    {
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.DateTime? CONTRACT_SIGN_DATE { get; set; }
        public System.DateTime? CONTRACT_START_DATE { get; set; }
        public System.DateTime? CONTRACT_END_DATE { get; set; }
        public System.Decimal? TERM { get; set; }
        public System.String AUTO_RENEW { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("MV_TICKET_VIEW", Schema = "WNCCRM")]
    public partial class MV_TICKET_VIEW
    {
        public System.String TICKET_NUMBER { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER1 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER2 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER3 { get; set; }
        public System.String DISPOSITION { get; set; }
    }
    [Table("MV_VOX_CONTACT_LOAD_WF", Schema = "WNCCRM")]
    public partial class MV_VOX_CONTACT_LOAD_WF
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String CONTACT_OWNER { get; set; }
        public System.String CONTACT_RECORD_TYPE { get; set; }
        public System.String RECORDTYPEID { get; set; }
        public System.String COUNTRY_CODE__C { get; set; }
        public System.String EMAIL { get; set; }
        public System.String HASOPTEDOUTOFEMAIL { get; set; }
        public System.String SALUTATION { get; set; }
        public System.String FIRSTNAME { get; set; }
        public System.String LASTNAME { get; set; }
        public System.String OTHER_PHONE { get; set; }
        public System.String PHONE { get; set; }
        public System.String MOBILEPHONE { get; set; }
        public System.String HOMEPHONE { get; set; }
        public System.String PHONE_EXTENSION__C { get; set; }
        public System.String TITLE { get; set; }
        public System.String CONTACT_TYPE__C { get; set; }
        public System.String DEPARTMENT { get; set; }
        public System.String INACTIVE_CONTACT__C { get; set; }
        public System.String Z_LEG_CONTACT_ID__C { get; set; }
        public System.String Z_LEG_CREATEDBY_ID__C { get; set; }
        public System.String Z_LEG_OWNERID__C { get; set; }
        public System.String Z_LEG_REC_TYPE__C { get; set; }
        public System.String SF_ACCOUNT_ID { get; set; }
        public System.String MAILINGADDRESS { get; set; }
        public System.String MAILINGCITY { get; set; }
        public System.String MAILINGSTATE { get; set; }
        public System.String MAILINGPOSTALCODE { get; set; }
        public System.String MAILINGCOUNTRY { get; set; }
        public System.String CAMP_UPDATE__C { get; set; }
        public System.String CAMP_CREATE__C { get; set; }
        public System.String CAMP_ADD__C { get; set; }
        public System.String CAMP_REMOVE__C { get; set; }
    }
    [Table("MV_VOX_CONTACTS_ROLES_WF", Schema = "WNCCRM")]
    public partial class MV_VOX_CONTACTS_ROLES_WF
    {
        public System.String ACCOUNT_ID { get; set; }
        public System.String CONTACT_ID { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String ROLE { get; set; }
    }
    [Table("MV_VOX_TEAM_LOAD_WF", Schema = "WNCCRM")]
    public partial class MV_VOX_TEAM_LOAD_WF
    {
        public System.String USERID_SF { get; set; }
        public System.String ACCOUNTID_SF { get; set; }
        public System.String TEAMMEMBERROLE { get; set; }
    }
    [Table("MV_WC_CAMSACCT_DETAIL", Schema = "WNCCRM")]
    public partial class MV_WC_CAMSACCT_DETAIL
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String WC_BTN { get; set; }
        public System.String WF_ID { get; set; }
        public System.String WF_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WF_CAMS_ID { get; set; }
        public System.String WF_CUST_TYPE { get; set; }
        public System.String WF_PLATFORM { get; set; }
        public System.String WF_SERVICESTATUS { get; set; }
        public System.String WF_MAIN_BTN { get; set; }
    }
    [Table("MV_WC_CAMSACCT_DTL_DLY", Schema = "WNCCRM")]
    public partial class MV_WC_CAMSACCT_DTL_DLY
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String WC_BTN { get; set; }
        public System.String WF_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WF_CAMS_ID { get; set; }
        public System.String WF_CUST_TYPE { get; set; }
        public System.String WF_PLATFORM { get; set; }
        public System.String WF_SERVICESTATUS { get; set; }
        public System.String WF_MAIN_BTN { get; set; }
    }
    [Table("MV_WC_CAMSACCT_DTL_WKLY", Schema = "WNCCRM")]
    public partial class MV_WC_CAMSACCT_DTL_WKLY
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String WC_BTN { get; set; }
        public System.String WF_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WF_CAMS_ID { get; set; }
        public System.String WF_CUST_TYPE { get; set; }
        public System.String WF_PLATFORM { get; set; }
        public System.String WF_SERVICESTATUS { get; set; }
        public System.String WF_MAIN_BTN { get; set; }
    }
    [Table("MV_WECONNECT_CAMSCONSUMER_SERV", Schema = "WNCCRM")]
    public partial class MV_WECONNECT_CAMSCONSUMER_SERV
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? INSERT_DATE { get; set; }
    }
    [Table("MV_WECONNECT_SERVICE_ITEM_DATA", Schema = "WNCCRM")]
    public partial class MV_WECONNECT_SERVICE_ITEM_DATA
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SPEC_GRP_ID { get; set; }
        public System.String GROUP_NAME { get; set; }
        public System.DateTime? INSERT_DATE { get; set; }
    }
    [Table("MV_WECONNECT_VOIP_DATA", Schema = "WNCCRM")]
    public partial class MV_WECONNECT_VOIP_DATA
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.DateTime? INSERT_DATE { get; set; }
    }
    [Table("MV_WF_CIRCUITS", Schema = "WNCCRM")]
    public partial class MV_WF_CIRCUITS
    {
        public System.String CIRCUIT_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String CIRCUIT_EXTERNAL_ID { get; set; }
    }
    [Table("MV_WF_IP_ADDRESS", Schema = "WNCCRM")]
    public partial class MV_WF_IP_ADDRESS
    {
        public System.String IP_ADDRESS { get; set; }
        public System.String START_ADDR_STRING { get; set; }
        public System.Int64? BLOCK_SIZE { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String IP_EXTERNAL_ID { get; set; }
    }
    [Table("MV_WF_PARTNERS", Schema = "WNCCRM")]
    public partial class MV_WF_PARTNERS
    {
        public System.Decimal PARTNER_GID { get; set; }
        public System.String PARTNER_NAME { get; set; }
        public System.Decimal SL_GID { get; set; }
    }
    [Table("MV_WINOM_ORDERS", Schema = "WNCCRM")]
    public partial class MV_WINOM_ORDERS
    {
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal? ORDER_AGE { get; set; }
        public System.DateTime? LAST_STATUS_DATE { get; set; }
        public System.String ORDER_NUMBER { get; set; }
        public System.String ORDER_TYPE { get; set; }
        public System.String IS_OPEN_STATUS { get; set; }
        public System.String ORDER_STATUS { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("MV_WSA_CIRCUITS", Schema = "WNCCRM")]
    public partial class MV_WSA_CIRCUITS
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CABS_CIRCUIT_ID { get; set; }
        public System.String BAN { get; set; }
        public System.String CABS_ACNA { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? CIRCUIT_DESIGN_ID { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String STREET { get; set; }
        public System.String ADR2 { get; set; }
        public System.String CLLI_Z { get; set; }
        public System.String MSS_CIRCUIT_ID { get; set; }
        public System.String RATE_CODE { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String MSS_ACNA { get; set; }
        public System.String MSS_ACNA_NAME { get; set; }
        public System.String TSP { get; set; }
        public System.String STATUS { get; set; }
        public System.String CABS_CKT_ID_TO_MATCH { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? CNT { get; set; }
        public System.String PRODUCT { get; set; }
        public System.String ALOC_STREET { get; set; }
        public System.String ALOC_ADDRESS2 { get; set; }
        public System.String ALOC_CITY { get; set; }
        public System.String ALOC_STATE_CODE { get; set; }
        public System.String ALOC_POSTAL_CODE { get; set; }
    }
    [Table("MV_WSA_REVCHAIN_CIRCUITS", Schema = "WNCCRM")]
    public partial class MV_WSA_REVCHAIN_CIRCUITS
    {
        public System.String PROV_SYSTEM { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Int32 PROV_INT_ID { get; set; }
        public System.String EXCHANGE_CARRIER_CIRCUIT_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String STREET { get; set; }
        public System.String ADR2 { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.String ZIP { get; set; }
        public System.Decimal? DESIGN_ID { get; set; }
        public System.String NETWORK_INDICATOR { get; set; }
        public System.DateTime? LAST_MODIFIED_DATE { get; set; }
        public System.String PRODUCT { get; set; }
        public System.String ALOC_STREET { get; set; }
        public System.String ALOC_ADDRESS2 { get; set; }
        public System.String ALOC_CITY { get; set; }
        public System.String ALOC_STATE_CODE { get; set; }
        public System.String ALOC_POSTAL_CODE { get; set; }
    }
    [Table("MY_TOOLS", Schema = "WNCCRM")]
    public partial class MY_TOOLS
    {
        [Key]
        public System.Decimal PKID { get; set; }
        public System.String USERID { get; set; }
        public System.String LINKNAME { get; set; }
        public System.String LINKURL { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("NAVIGATED_URL", Schema = "WNCCRM")]
    public partial class NAVIGATED_URL
    {
        [Key]
        public System.Decimal NAVIGATED_URL_ID { get; set; }
        public System.String APPLICATION { get; set; }
        public System.String GUID { get; set; }
        public System.String PAGE_NAME { get; set; }
        public System.Decimal? PAGE_ID { get; set; }
        public System.String ENTITY_ID { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_MODIFIED_USER { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.String ENVIRONMENT { get; set; }
    }
    [Table("NEW_SALE_OPTIONAL_PRODUCTS", Schema = "WNCCRM")]
    public partial class NEW_SALE_OPTIONAL_PRODUCTS
    {
        [Key]
        public System.Decimal NEW_SALE_OPTIONAL_PRODUCTS_ID { get; set; }
        public System.Decimal? NEW_SALE_ID { get; set; }
        public System.String BUNDLE_ADDER_NAME { get; set; }
        public System.String BUNDLE_ADDER_PRICE { get; set; }
        public System.String BUNDLE_ADDER_TYPE { get; set; }
        public System.String BUNDLE_ADDER_FREQUENCY_TYPE { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? UPDATED_DATE { get; set; }
        public System.String UPDATED_USER { get; set; }
        public System.Decimal? LINE { get; set; }
    }
    [Table("NEW_SALE_PRODUCT", Schema = "WNCCRM")]
    public partial class NEW_SALE_PRODUCT
    {
        [Key]
        public System.Decimal NEW_SALE_PRODUCT_ID { get; set; }
        public System.Decimal NEW_SALE_ID { get; set; }
        public System.Decimal? LINE { get; set; }
        public System.String IS_DIRECTORY { get; set; }
        public System.String IS_PORTING { get; set; }
        public System.String PRODUCT_OFRNG_OFFER_ID { get; set; }
        public System.String MODEM_PREMIUM_INDICATOR { get; set; }
        public System.String QUALIFIED_SPEED { get; set; }
        public System.String MODEM_INDICATOR { get; set; }
        public System.String STANDARD_PRICE { get; set; }
        public System.String BUNDLE_NAME { get; set; }
        public System.String INSTALL_FEE { get; set; }
        public System.String PROMO_PRICE { get; set; }
        public System.String PROMO_TERM { get; set; }
        public System.String DIRECTORY_TN { get; set; }
        public System.String DIRECTORY_NAME { get; set; }
        public System.String OMIT_ADDRESS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CUST_REQUESTED_TERMINATION { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String CURRENT_CARRIER { get; set; }
        public System.String HUNT_SEQUENCE { get; set; }
        public System.String IPIC_CODE { get; set; }
        public System.String MAINTENANCE_LINE { get; set; }
    }
    [Table("NEW_SALE_PRODUCT_NOTE", Schema = "WNCCRM")]
    public partial class NEW_SALE_PRODUCT_NOTE
    {
        [Key]
        public System.Decimal NEW_SALE_PRODUCT_NOTE_ID { get; set; }
        public System.Decimal NEW_SALE_PRODUCT_ID { get; set; }
        public System.String ASOC { get; set; }
        public System.String ASOC_DESCRIPTION { get; set; }
        public System.String NOTE_BODY { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("NEW_SALES", Schema = "WNCCRM")]
    public partial class NEW_SALES
    {
        [Key]
        public System.Decimal NEW_SALE_ID { get; set; }
        public System.String ACTION { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String BILLING_ACCOUNT_NUMBER { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
        public System.String ADDRESS_STATUS { get; set; }
        public System.String ADDRESS_TYPE { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String BEX { get; set; }
        public System.String BOID { get; set; }
        public System.String CAPTION_TOINCLUDE { get; set; }
        public System.String CITY { get; set; }
        public System.String COE { get; set; }
        public System.String COMPETITOR { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTY { get; set; }
        public System.String CURRENT_PROVIDER { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String DCRIS_ORDER_NUMBER { get; set; }
        public System.String DIRECTORY_NAME { get; set; }
        public System.String EXCHANGE_NPA { get; set; }
        public System.String IS_DIRECTORY { get; set; }
        public System.String IS_NEW_CONSTRUCTION { get; set; }
        public System.String IS_OVERRIDE { get; set; }
        public System.String IS_PORTING { get; set; }
        public System.String IS_VALIDATED { get; set; }
        public System.String LATA { get; set; }
        public System.String LOCATION_NAME { get; set; }
        public System.DateTime? MOVEIN_DATE { get; set; }
        public System.String NO_SALE_DESCRIPTION { get; set; }
        public System.String NO_SALE_REASON { get; set; }
        public System.String NPA { get; set; }
        public System.String NXX { get; set; }
        public System.String OMIT_ADDRESS { get; set; }
        public System.String OPERATING_COMPANY { get; set; }
        public System.String ORDER_NUMBER { get; set; }
        public System.String OTHER_CONTACT_STATE { get; set; }
        public System.String OTHER_CONTACT_TYPE { get; set; }
        public System.String OTHER_EMAIL_ADDRESS { get; set; }
        public System.String OTHER_EXTENSION1 { get; set; }
        public System.String OTHER_EXTENSION2 { get; set; }
        public System.String OTHER_FIRST_NAME { get; set; }
        public System.Decimal? OTHER_GLOBAL_ACCOUNT_PARTY_ID { get; set; }
        public System.String OTHER_LAST_NAME { get; set; }
        public System.String OTHER_PHONE_TYPE1 { get; set; }
        public System.String OTHER_PHONE_TYPE2 { get; set; }
        public System.String OTHER_PHONE1 { get; set; }
        public System.String OTHER_PHONE2 { get; set; }
        public System.String PIN_NUMBER { get; set; }
        public System.String PLATFORM { get; set; }
        public System.String POST_DIRECTIONAL { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String PRE_DIRECTIONAL { get; set; }
        public System.String PRIMARY_BUSINESS_NAME { get; set; }
        public System.String PRIMARY_CONTACT_STATE { get; set; }
        public System.String PRIMARY_CONTACT_TYPE { get; set; }
        public System.String PRIMARY_EMAIL_ADDRESS { get; set; }
        public System.String PRIMARY_EXTENSION1 { get; set; }
        public System.String PRIMARY_EXTENSION2 { get; set; }
        public System.String PRIMARY_FIRST_NAME { get; set; }
        public System.Decimal? PRIMARY_GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String PRIMARY_LAST_NAME { get; set; }
        public System.String PRIMARY_NUMBER { get; set; }
        public System.String PRIMARY_NUMBER_PREFIX { get; set; }
        public System.String PRIMARY_NUMBER_SUFFIX { get; set; }
        public System.String PRIMARY_PHONE_TYPE1 { get; set; }
        public System.String PRIMARY_PHONE_TYPE2 { get; set; }
        public System.String PRIMARY_PHONE1 { get; set; }
        public System.String PRIMARY_PHONE2 { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String SALE_DISPOSITION { get; set; }
        public System.String SECONDARY_CONTACT_STATE { get; set; }
        public System.String SECONDARY_CONTACT_TYPE { get; set; }
        public System.String SECONDARY_EMAIL_ADDRESS { get; set; }
        public System.String SECONDARY_EXTENSION1 { get; set; }
        public System.String SECONDARY_EXTENSION2 { get; set; }
        public System.String SECONDARY_FIRST_NAME { get; set; }
        public System.Decimal? SECONDARY_GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String SECONDARY_LAST_NAME { get; set; }
        public System.String SECONDARY_NUMBER { get; set; }
        public System.String SECONDARY_PHONE_TYPE1 { get; set; }
        public System.String SECONDARY_PHONE_TYPE2 { get; set; }
        public System.String SECONDARY_PHONE1 { get; set; }
        public System.String SECONDARY_PHONE2 { get; set; }
        public System.String SERVING_WIRE_CENTER { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String STREET { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String STREET_SUFFIX { get; set; }
        public System.String STRUCTURE_TYPE1 { get; set; }
        public System.String STRUCTURE_TYPE2 { get; set; }
        public System.String STRUCTURE_TYPE3 { get; set; }
        public System.String STRUCTURE_VALUE1 { get; set; }
        public System.String STRUCTURE_VALUE2 { get; set; }
        public System.String STRUCTURE_VALUE3 { get; set; }
        public System.String SUFFIX { get; set; }
        public System.String TELEPHONE_NUMBER { get; set; }
        public System.String TOWN_CODE { get; set; }
        public System.String UNIT_DESIGNATOR { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String PRODUCT_OFRNG_OFFER_ID { get; set; }
        public System.String PRODUCT_OFRNG_CURR_CUST_CR_IND { get; set; }
        public System.String PRODUCT_OFRNG_TRANSACTION_ID { get; set; }
        public System.String PRODUCT_OFRNG_ERROR_MESSAGE { get; set; }
        public System.String PRODUCT_OFRNG_ERROR_CODE { get; set; }
        public System.String MODEM_PREMIUM_INDICATOR { get; set; }
        public System.String QUALIFIED_SPEED { get; set; }
        public System.String MODEM_INDICATOR { get; set; }
        public System.String STANDARD_PRICE { get; set; }
        public System.String BUNDLE_NAME { get; set; }
        public System.String INSTALL_FEE { get; set; }
        public System.String PROMO_PRICE { get; set; }
        public System.String PROMO_TERM { get; set; }
        public System.DateTime? UPDATED_DATE { get; set; }
        public System.String UPDATED_USER { get; set; }
        public System.String SERVING_DETAIL_PLATFORM_NAME { get; set; }
        public System.String SERVING_DETAIL_NXX { get; set; }
        public System.String IS_NEAR_BY_ADDRESS { get; set; }
        public System.String FEDERAL_TAX_ID { get; set; }
        public System.String DEPOSIT_REQUIRED { get; set; }
        public System.DateTime? REQUESTED_DUE_DATE { get; set; }
        public System.String SALE_DISPOSITION_REMARKS { get; set; }
        public System.String BILL_ADDR_LOCATION_NAME { get; set; }
        public System.String BILL_ADDRESS1 { get; set; }
        public System.String BILL_ADDRESS2 { get; set; }
        public System.String BILL_ADDR_PRE_DIRECTIONAL { get; set; }
        public System.String BILL_ADDR_PRMY_NUMBER_PREFIX { get; set; }
        public System.String BILL_ADDR_PRMY_NUMBER { get; set; }
        public System.String BILL_ADDR_PRMY_NUMBER_SUFFIX { get; set; }
        public System.String BILL_ADDR_STREET_NAME { get; set; }
        public System.String BILL_ADDR_STREET_SUFFIX { get; set; }
        public System.String BILL_ADDR_POST_DIRECTIONAL { get; set; }
        public System.String BILL_ADDR_UNIT_DESIGNATOR { get; set; }
        public System.String BILL_ADDR_SECONDARY_NUMBER { get; set; }
        public System.String BILL_ADDR_CITY { get; set; }
        public System.String BILL_ADDR_STATECODE { get; set; }
        public System.String BILL_ADDR_POSTALCODE { get; set; }
        public System.String BILL_ADDR_COUNTY { get; set; }
        public System.String BILL_ADDR_COUNTRY { get; set; }
        public System.String BILL_ADDR_NPA { get; set; }
        public System.String BILL_ADDR_NXX { get; set; }
        public System.String BILL_ADDR_TOWN_CODE { get; set; }
        public System.String BILL_ADDR_IS_VALIDATED { get; set; }
        public System.String BILL_ADDR_IS_OVERRIDE { get; set; }
        public System.String BILL_ADDR_IS_NEW_CONSTRUCTION { get; set; }
        public System.String BILL_ADDR_STRUCTURE_TYPE1 { get; set; }
        public System.String BILL_ADDR_STRUCTURE_VALUE1 { get; set; }
        public System.String BILL_ADDR_STRUCTURE_TYPE2 { get; set; }
        public System.String BILL_ADDR_STRUCTURE_VALUE2 { get; set; }
        public System.String BILL_ADDR_STRUCTURE_VALUE3 { get; set; }
        public System.String SERVING_BILL_WIRE_CENTER { get; set; }
        public System.String SERVING_BILL_OPERATING_COMPANY { get; set; }
        public System.String SERVING_BILL_RATE_CENTER { get; set; }
        public System.String SERVING_BILL_PLATFORM_NAME { get; set; }
        public System.String SERVING_BILL_COE { get; set; }
        public System.String SERVING_BILL_EXCHANGE_NPA { get; set; }
        public System.String SERVING_BILL_NXX { get; set; }
        public System.String SERVING_BILL_LATA { get; set; }
        public System.String SHIP_ADDR_LOCATION_NAME { get; set; }
        public System.String SHIP_ADDR_ADDRESS1 { get; set; }
        public System.String SHIP_ADDR_ADDRESS2 { get; set; }
        public System.String SHIP_ADDR_PRE_DIRECTIONAL { get; set; }
        public System.String SHIP_ADDR_PRMY_NUMBER_PREFIX { get; set; }
        public System.String SHIP_ADDR_PRMY_NUMBER { get; set; }
        public System.String SHIP_ADDR_PRMY_NUMBER_SUFFIX { get; set; }
        public System.String SHIP_ADDR_STREET_NAME { get; set; }
        public System.String SHIP_ADDR_STREET_SUFFIX { get; set; }
        public System.String SHIP_ADDR_POST_DIRECTIONAL { get; set; }
        public System.String SHIP_ADDR_UNIT_DESIGNATOR { get; set; }
        public System.String SHIP_ADDR_SECONDARY_NUMBER { get; set; }
        public System.String SHIP_ADDR_CITY { get; set; }
        public System.String SHIP_ADDR_STATE_CODE { get; set; }
        public System.String SHIP_ADDR_POSTAL_CODE { get; set; }
        public System.String SHIP_ADDR_COUNTY { get; set; }
        public System.String SHIP_ADDR_COUNTRY { get; set; }
        public System.String SHIP_ADDR_NPA { get; set; }
        public System.String SHIP_ADDR_NXX { get; set; }
        public System.String SHIP_ADDR_TOWN_CODE { get; set; }
        public System.String SHIP_ADDR_IS_VALIDATED { get; set; }
        public System.String SHIP_ADDR_IS_OVERRIDE { get; set; }
        public System.String SHIP_ADDR_IS_NEW_CONSTRUCTION { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_TYPE1 { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_VALUE1 { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_TYPE2 { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_VALUE2 { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_VALUE3 { get; set; }
        public System.String SERVING_SHIP_SERVINGWIRECENTER { get; set; }
        public System.String SERVING_SHIP_OPERATINGCOMPANY { get; set; }
        public System.String SERVING_SHIP_RATECENTER { get; set; }
        public System.String SERVING_SHIP_PLATFORM { get; set; }
        public System.String SERVING_SHIP_COE { get; set; }
        public System.String SERVING_SHIP_EXCHANGENPA { get; set; }
        public System.String SERVING_SHIP_NXX { get; set; }
        public System.String SERVING_SHIP_LATA { get; set; }
        public System.String SHIP_ADDR_STRUCTURE_TYPE3 { get; set; }
        public System.String BILL_ADDR_STRUCTURE_TYPE3 { get; set; }
        public System.String SALE_DSPN_NO_SALE_REASON { get; set; }
        public System.Decimal? RESULT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? RESULT_BUS_INTERACTION_ID { get; set; }
        public System.String EXPECTED_INSTALL_DATE { get; set; }
        public System.String BILL_ADDR_ATTN { get; set; }
        public System.String BILL_ADDR_RECIPIENT { get; set; }
        public System.String SHIP_ADDR_ATTN { get; set; }
        public System.String SHIP_ADDR_RECIPIENT { get; set; }
        public System.Decimal? OPPORTUNITY_NUMBER { get; set; }
        public System.DateTime? START_TIME_WINDOW { get; set; }
        public System.DateTime? END_TIME_WINDOW { get; set; }
    }
    [Table("NOTE_ASOC", Schema = "WNCCRM")]
    public partial class NOTE_ASOC
    {
        [Key]
        public System.Decimal NOTE_ASOC_ID { get; set; }
        public System.Decimal? GLOBAL_NOTE_ID { get; set; }
        public System.String ASOC { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_EXPIRE_RUN_DATE { get; set; }
    }
    [Table("NOTE_BODY", Schema = "WNCCRM")]
    public partial class NOTE_BODY
    {
        [Key]
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? SOURCE_BUS_SYSTEM { get; set; }
        public System.String SUBJECT { get; set; }
        public System.String BODY { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String VISIBILITY { get; set; }
        public System.DateTime? CRITICAL_START_DATE { get; set; }
        public System.DateTime? CRITICAL_END_DATE { get; set; }
        public System.DateTime? VALID_FOR_START_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.DateTime? VALID_FOR_END_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String IS_SYSTEM_GENERATED { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? NOTE_SPEC_ID { get; set; }
        public System.Decimal? GID_TEMP { get; set; }
        public System.Decimal? CREATOR_EXT_NOTE_ID_REF { get; set; }
    }
    [Table("NOTE_HEADER", Schema = "WNCCRM")]
    public partial class NOTE_HEADER
    {
        [Key]
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal SOURCE_BUS_SYSTEM { get; set; }
        public System.String SUBJECT { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String VISIBILITY { get; set; }
        public System.DateTime? CRITICAL_START_DATE { get; set; }
        public System.DateTime? CRITICAL_END_DATE { get; set; }
        public System.DateTime? VALID_FOR_START_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.DateTime? VALID_FOR_END_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String IS_SYSTEM_GENERATED { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? NOTE_SPEC_ID { get; set; }
        public System.Decimal? GID_TEMP { get; set; }
        public System.Decimal? CREATOR_EXT_NOTE_ID_REF { get; set; }
        public System.String IS_SHARED { get; set; }
        public System.String IS_RICH_TEXT { get; set; }
        public System.String DEFINED_BY { get; set; }
        public System.String DEPARTMENT_HEADER { get; set; }
    }
    [Table("NOTE_HEADER_TEMP", Schema = "WNCCRM")]
    public partial class NOTE_HEADER_TEMP
    {
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal SOURCE_BUS_SYSTEM { get; set; }
        public System.String SUBJECT { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String VISIBILITY { get; set; }
        public System.DateTime? CRITICAL_START_DATE { get; set; }
        public System.DateTime? CRITICAL_END_DATE { get; set; }
        public System.DateTime? VALID_FOR_START_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.DateTime? VALID_FOR_END_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String IS_SYSTEM_GENERATED { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? NOTE_SPEC_ID { get; set; }
        public System.Decimal? GID_TEMP { get; set; }
        public System.Decimal? CREATOR_EXT_NOTE_ID_REF { get; set; }
        public System.String IS_SHARED { get; set; }
        public System.String IS_RICH_TEXT { get; set; }
        public System.String DEFINED_BY { get; set; }
    }
    [Table("NOTE_SECURITY_PROF_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class NOTE_SECURITY_PROF_ROLE_LKUP
    {
        [Key]
        public System.Decimal NOTE_SECURITY_PROF_ROLE_LKU_ID { get; set; }
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("NOTE_SECURITY_PROFILE", Schema = "WNCCRM")]
    public partial class NOTE_SECURITY_PROFILE
    {
        [Key]
        public System.Decimal NOTE_SECURITY_PROFILE_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        public System.String ROLE_VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("NOTE_SPEC", Schema = "WNCCRM")]
    public partial class NOTE_SPEC
    {
        [Key]
        public System.Decimal NOTE_SPEC_ID { get; set; }
        public System.String NOTE_TYPE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String PROFILE_ALLOWED { get; set; }
    }
    [Table("NOTE_SPEC_PROF_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class NOTE_SPEC_PROF_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("NOTE_SPEC_SECURITY_PROFILE", Schema = "WNCCRM")]
    public partial class NOTE_SPEC_SECURITY_PROFILE
    {
        [Key]
        public System.Decimal NOTE_SPEC_SECURITY_PROFILE_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal NOTE_SPEC_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("NOTE_TEMPLATE", Schema = "WNCCRM")]
    public partial class NOTE_TEMPLATE
    {
        [Key]
        public System.Decimal NOTE_TEMPLATE_ID { get; set; }
        public System.Decimal NOTE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String SUBJECT { get; set; }
        public System.String IS_SYSTEM_GENERATED { get; set; }
        public System.String IS_RICH_TEXT { get; set; }
        public System.String BODY { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String VISIBILITY { get; set; }
        public System.String IS_PRIORITY_LOCKED { get; set; }
        public System.String IS_VISIBILITY_LOCKED { get; set; }
        public System.String IS_SUBJECT_LOCKED { get; set; }
        public System.String IS_BODY_LOCKED { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("NOTE_TEMPLATE_PROFILE", Schema = "WNCCRM")]
    public partial class NOTE_TEMPLATE_PROFILE
    {
        [Key]
        public System.Decimal NOTE_TEMPLATE_PROFILE_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.Decimal NOTE_TEMPLATE_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("NOTE_WIRE_CENTER_RATE_CENTER", Schema = "WNCCRM")]
    public partial class NOTE_WIRE_CENTER_RATE_CENTER
    {
        [Key]
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        [Key]
        public System.Decimal WIRE_CENTER_RATE_CENTER_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("NOTIFICATION", Schema = "WNCCRM")]
    public partial class NOTIFICATION
    {
        [Key]
        public System.Decimal NOTIFICATION_ID { get; set; }
        public System.String BODY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String NOTIFICATION_URL { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? EXPIRE_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String URL_DESCRIPTION { get; set; }
    }
    [Table("OBJECT_STATE_LKUP", Schema = "WNCCRM")]
    public partial class OBJECT_STATE_LKUP
    {
        [Key]
        public System.Decimal OBJECT_STATE_LKUP_ID { get; set; }
        public System.String VALUE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("OBJECT_XREF", Schema = "WNCCRM")]
    public partial class OBJECT_XREF
    {
        [Key]
        public System.Decimal OBJECT_XREF_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal GLOBAL_OBJECT_ID { get; set; }
        public System.String LOCAL_OBJECT_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String BUSINESS_ENTITY { get; set; }
        public System.String ENTITY_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OBJECTS", Schema = "WNCCRM")]
    public partial class OBJECTS
    {
        public System.String OWNER { get; set; }
        public System.String SEGMENT_NAME { get; set; }
        public System.String SEGMENT_TYPE { get; set; }
        public System.String OBJ_STATE { get; set; }
        public System.Decimal? SIZE_MB { get; set; }
        public System.Decimal? TEMP { get; set; }
        public System.Decimal? CALC { get; set; }
        public System.String REPLICA { get; set; }
        public System.DateTime? CREATED { get; set; }
        public System.DateTime? CHECKED { get; set; }
    }
    [Table("OFFER", Schema = "WNCCRM")]
    public partial class OFFER
    {
        [Key]
        public System.Decimal OFFER_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.Decimal OFFER_IMPORT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String OFFER_CODE { get; set; }
        public System.String OFFER_PUBLISH_MONTH { get; set; }
        public System.String CONTRACT_TERM { get; set; }
        public System.String CONTRACT_CONCESSION { get; set; }
        public System.Decimal? CONTRACT_CREDIT_AMOUNT { get; set; }
        public System.String CONTRACT_CONCESSION_TIMING { get; set; }
        public System.String CONTRACT_ACCOUNT_NUMBERS { get; set; }
        public System.String OFFER_TYPE { get; set; }
        public System.String NEW_TERM { get; set; }
        public System.String SPIFF { get; set; }
        public System.Decimal? CONCESSION { get; set; }
        public System.Decimal? OFFER_PREFERENCE { get; set; }
        public System.String OFFER_AUTHORITY { get; set; }
        public System.String OFFER_DETAIL { get; set; }
        public System.String REV_MONTH { get; set; }
        public System.String DISCOUNT_PERCENTAGE { get; set; }
        public System.String CONTRACT_TEMPLATE_NAME { get; set; }
        public System.String PORTAL_RENEWAL_MSG { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ENT_CUSTOMER_ID { get; set; }
        public System.String AGENT_SPIFF { get; set; }
        public System.String PORTAL_BANNER_LEFT { get; set; }
        public System.String PORTAL_BANNER_TOP { get; set; }
        public System.String PORTAL_BANNER_BUTTON { get; set; }
        public System.String PORTAL_FIELD_5 { get; set; }
        public System.String PARTNER_PORTAL { get; set; }
    }
    [Table("OFFER_DOCUSIGN", Schema = "WNCCRM")]
    public partial class OFFER_DOCUSIGN
    {
        [Key]
        public System.Decimal OFFER_DOCUSIGN_ID { get; set; }
        public System.Decimal? OFFER_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String DS_PROCESSED_YN { get; set; }
        public System.String DS_PROC_FAILURE_YN { get; set; }
        public System.DateTime? DS_PROCESSED_DATE { get; set; }
        public System.String CUSTOMER_CONTACT_NAME { get; set; }
        public System.String CUSTOMER_CONTACT_EMAIL { get; set; }
        public System.String ENVELOPE_ID { get; set; }
        public System.String OFFER_EMAIL_BODY { get; set; }
        public System.String DOCUSIGN_STATUS { get; set; }
        public System.DateTime? DOCUSIGN_STATUS_DATE { get; set; }
        public System.Byte[] DOCUSIGN_PDF_FILE { get; set; }
        public System.Byte[] MANUALSIGN_PDF_FILE { get; set; }
        public System.String OFFER_EXTEND_METHOD { get; set; }
        public System.String OFFERING_EMPLOYEEID { get; set; }
        public System.String CUSTOMER_CONTACT_ADDRESS { get; set; }
        public System.String REASON { get; set; }
        public System.String DOCUSIGN_VOIDED_REASON { get; set; }
        public System.String DOCUSIGN_DECLINED_REASON { get; set; }
        public System.DateTime? DOCUSIGN_VOIDED_DATE { get; set; }
        public System.DateTime? DOCUSIGN_DECLINED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CARE_CARE_EXTENDED_YN { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
    }
    [Table("OFFER_EMAIL", Schema = "WNCCRM")]
    public partial class OFFER_EMAIL
    {
        [Key]
        public System.Decimal OFFER_EMAIL_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String OFFER_EMAIL_TYPE { get; set; }
        public System.String OFFER_EMAIL_SUBJECT { get; set; }
        public System.String OFFER_EMAIL_BODY { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OFFER_FOLLOWUP", Schema = "WNCCRM")]
    public partial class OFFER_FOLLOWUP
    {
        [Key]
        public System.Decimal OFFER_FOLLOWUP_ID { get; set; }
        public System.Decimal OFFER_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String EMAIL_TO { get; set; }
        public System.String EMAIL_BODY { get; set; }
        public System.String DECLINE_REASON { get; set; }
        public System.String CONTACT_NAME { get; set; }
        public System.String CONTACT_PHONE { get; set; }
        public System.String CONTACT_EMAIL { get; set; }
        public System.DateTime? EMAIL_SENT_ON { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OFFER_HISTORY", Schema = "WNCCRM")]
    public partial class OFFER_HISTORY
    {
        [Key]
        public System.Decimal OFFER_HISTORY_ID { get; set; }
        public System.Decimal OFFER_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String OFFER_STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OFFER_IMPORT", Schema = "WNCCRM")]
    public partial class OFFER_IMPORT
    {
        [Key]
        public System.Decimal OFFER_IMPORT_ID { get; set; }
        public System.DateTime OFFER_IMPORT_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("OFFER_MESSAGE_ACCOUNT", Schema = "WNCCRM")]
    public partial class OFFER_MESSAGE_ACCOUNT
    {
        [Key]
        public System.Decimal OFFER_MESSAGE_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? MESSAGE_PREFERENCE { get; set; }
        public System.String VERBIAGE_CODE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OFFER_MESSAGE_VERBIAGE", Schema = "WNCCRM")]
    public partial class OFFER_MESSAGE_VERBIAGE
    {
        [Key]
        public System.Decimal OFFER_MESSAGE_VERBIAGE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String VERBIAGE_CODE { get; set; }
        public System.String UPSELL_CONVERSION_NOTE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("OFSC_DC_STATUS", Schema = "WNCCRM")]
    public partial class OFSC_DC_STATUS
    {
        [Key]
        public System.Decimal OFSC_DC_STATUS_ID { get; set; }
        public System.Decimal? OFSC_DISPATCH_COMM_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? TIME_CONTACTED { get; set; }
        public System.String SCHEDULER_EMPLOYEE_ID { get; set; }
        public System.DateTime? RECORD_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("OFSC_DISPATCH_COMM", Schema = "WNCCRM")]
    public partial class OFSC_DISPATCH_COMM
    {
        [Key]
        public System.Decimal OFSC_DISPATCH_COMM_ID { get; set; }
        public System.Decimal? ACTIVITY_ID { get; set; }
        public System.String BUCKET_ID { get; set; }
        public System.String TECH_ASSIGNED { get; set; }
        public System.String STN { get; set; }
        public System.String TROUBLE_TICKET_NUMBER { get; set; }
        public System.String CUSTOMER_NAME { get; set; }
        public System.String CBR { get; set; }
        public System.String ARRIVAL_WINDOW_START { get; set; }
        public System.String ARRIVAL_WINDOW_END { get; set; }
        public System.DateTime? CURRENT_ARRIVAL { get; set; }
        public System.String STATUS_FLAG { get; set; }
        public System.String SMS_OPT { get; set; }
        public System.DateTime? RECORD_DATE { get; set; }
        public System.String INC_STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String MOBILE_CBR { get; set; }
        public System.String LOCAL_CBR { get; set; }
        public System.String ORDER_NUMBER { get; set; }
        public System.String TIME_SLOT { get; set; }
    }
    [Table("OFSC_SUBSCRIPTION", Schema = "WNCCRM")]
    public partial class OFSC_SUBSCRIPTION
    {
        [Key]
        public System.String OFSC_SUBSCRIPTION_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORDER_ASOC_DETAILS_STG", Schema = "WNCCRM")]
    public partial class ORDER_ASOC_DETAILS_STG
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ORDER_ID { get; set; }
        public System.String SEGMENT_TN { get; set; }
        public System.String ASOC_CODE { get; set; }
        public System.Int32? QUANTITY { get; set; }
        public System.String ACTION { get; set; }
        public System.Double? RATE { get; set; }
        public System.String TYPE { get; set; }
        public System.Int32? SEQUENCE { get; set; }
        public System.String SNEREMARKS { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DUEDATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ORDER_INFO_RESP", Schema = "WNCCRM")]
    public partial class ORDER_INFO_RESP
    {
        public System.Decimal? INFO_ID { get; set; }
        public System.String ORDER_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String BILL_NAME { get; set; }
        public System.String STREET_1 { get; set; }
        public System.String STREET_2 { get; set; }
        public System.String STREET_3 { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE { get; set; }
        public System.String ZIP_CODE { get; set; }
        public System.String OPEN_USER_ID { get; set; }
        public System.String CLOSE_USER_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.DateTime? CANCEL_DATE { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String STATUS { get; set; }
        public System.String CUST_NAME { get; set; }
        public System.String BOID { get; set; }
        public System.String BEX { get; set; }
        public System.Decimal? RECUR_REV { get; set; }
        public System.Decimal? NONRECUR_REV { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? CONNECT_DATE { get; set; }
    }
    [Table("ORDER_PHASE", Schema = "WNCCRM")]
    public partial class ORDER_PHASE
    {
        [Key]
        public System.Decimal ORDER_PHASE_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ORDER_TYPE { get; set; }
        public System.Decimal? MRC { get; set; }
        public System.Decimal? REVIEW { get; set; }
        public System.Decimal? DESIGN { get; set; }
        public System.Decimal? NETWORK { get; set; }
        public System.Decimal? INSTALLATION { get; set; }
        public System.Decimal? ACTIVATION { get; set; }
        public System.Decimal? PROGRESS { get; set; }
        public System.Decimal? ACTIVITY { get; set; }
        public System.String HOLD_STATUS { get; set; }
        public System.String EXPEDITE_ESCALATION { get; set; }
        public System.String PM_NAME { get; set; }
        public System.String SALES_EID { get; set; }
        public System.String SALES_NAME { get; set; }
        public System.DateTime? PTD_SCHED_DATE { get; set; }
        public System.DateTime? ACTIVATION_SCHED_DATE { get; set; }
        public System.DateTime? FORECAST_DATE { get; set; }
        public System.DateTime? FOLLOWUP_DATE { get; set; }
        public System.DateTime? LOOP_ORDER_DATE { get; set; }
        public System.DateTime? FOC_DATE { get; set; }
        public System.DateTime? LOOP_INSTALLED_DATE { get; set; }
        public System.Decimal? ORDER_AGE_DAYS { get; set; }
        public System.String LEC_NAME { get; set; }
        public System.String PORT_SIZE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
        public System.String PM_ENUM { get; set; }
    }
    [Table("ORG_GEO_ADDRESS", Schema = "WNCCRM")]
    public partial class ORG_GEO_ADDRESS
    {
        [Key]
        public System.Decimal ORG_GEO_ADDRESS_ID { get; set; }
        public System.Decimal ORG_ID { get; set; }
        public System.Decimal GEO_ADDRESS_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORG_GEO_ADDRESS_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class ORG_GEO_ADDRESS_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORG_MARKET_PROGRAM", Schema = "WNCCRM")]
    public partial class ORG_MARKET_PROGRAM
    {
        [Key]
        public System.Decimal ORG_MARKET_PROGRAM_ID { get; set; }
        public System.Decimal ORG_ID { get; set; }
        public System.Decimal MARKET_PROGRAM_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORG_MARKET_PROGRAM_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class ORG_MARKET_PROGRAM_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORG_PROFILE", Schema = "WNCCRM")]
    public partial class ORG_PROFILE
    {
        public System.Decimal? ORG_PROFILE_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String DUNS_NUMBER { get; set; }
        public System.Int32? NUMBER_OF_EMPLOYEES { get; set; }
        public System.Int64? ANNUAL_REVENUE { get; set; }
        public System.String TICKER_SYMBOL { get; set; }
        public System.String WEB_SITE { get; set; }
        public System.String INDUSTRY { get; set; }
        public System.String OWNERSHIP { get; set; }
        public System.String TRADESTYLE { get; set; }
        public System.String YEAR_STARTED { get; set; }
        public System.String SIC_CODE { get; set; }
        public System.String SIC_DESCRIPTION { get; set; }
        public System.String NAICS_CODE { get; set; }
        public System.String NAICS_DESCRIPTION { get; set; }
        public System.String COMPANY_DESCRIPTION { get; set; }
        public System.String PHONE { get; set; }
        public System.String FAX { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String RETENTION_STATUS { get; set; }
        public System.String SUPPORT_SEGMENT { get; set; }
        public System.String SUPPORT_REGION { get; set; }
        public System.String SUPPORT_PROFILE { get; set; }
        public System.String REMEDY_CUSTOMER_TYPE { get; set; }
    }
    [Table("ORG_PROFILE_FLAGS", Schema = "WNCCRM")]
    public partial class ORG_PROFILE_FLAGS
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String PROFILE_FLAG { get; set; }
        public System.String PROFILE_FLAG_VALUE { get; set; }
    }
    [Table("ORG_REL", Schema = "WNCCRM")]
    public partial class ORG_REL
    {
        [Key]
        public System.Decimal ORG_REL_ID { get; set; }
        public System.Decimal CHILD_ORG_ID { get; set; }
        public System.Decimal PARENT_ORG_ID { get; set; }
        public System.Decimal ORG_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("ORG_REL_SPEC", Schema = "WNCCRM")]
    public partial class ORG_REL_SPEC
    {
        [Key]
        public System.Decimal ORG_REL_SPEC_ID { get; set; }
        public System.Decimal PARENT_ORG_SPEC_ID { get; set; }
        public System.Decimal CHILD_ORG_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("ORG_SPEC", Schema = "WNCCRM")]
    public partial class ORG_SPEC
    {
        [Key]
        public System.Decimal ORG_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("ORGANIZATION", Schema = "WNCCRM")]
    public partial class ORGANIZATION
    {
        [Key]
        public System.Decimal ORG_ID { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String IDENTIFIER { get; set; }
        public System.String NAME { get; set; }
        public System.String ORG_TYPE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal ORG_SPEC_ID { get; set; }
        public System.String LEGAL_ENTITY_NAME { get; set; }
        public System.Decimal? EIN { get; set; }
        public System.String DUNS_NUMBER { get; set; }
        public System.String CAGE_CODE { get; set; }
        public System.String IS_SAM_REGISTERED { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("PAIRCHANGE_ERROR_CODE", Schema = "WNCCRM")]
    public partial class PAIRCHANGE_ERROR_CODE
    {
        [Key]
        public System.String CODE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String ADDITIONAL_MESSAGE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PASSIVE_ADAPTER", Schema = "WNCCRM")]
    public partial class PASSIVE_ADAPTER
    {
        [Key]
        public System.Decimal CONTEXT_ID { get; set; }
        public System.Decimal? CONTEXT_ID_PREVIOUS { get; set; }
        public System.String SOURCE_TABLE { get; set; }
        public System.String TABLE_ACTION { get; set; }
        public System.String SUB_ID { get; set; }
        public System.String OBJECTID { get; set; }
        public System.String OBJECTID_PREVIOUS { get; set; }
        public System.String BUSINESS_ENTITY { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.String REQUEST_STATUS { get; set; }
        public System.String REQUEST { get; set; }
        public System.String RESPONSE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String ENTITY_TYPE { get; set; }
    }
    [Table("PBCATCOL", Schema = "WNCCRM")]
    public partial class PBCATCOL
    {
        [Key]
        public System.String PBC_TNAM { get; set; }
        public System.Decimal? PBC_TID { get; set; }
        [Key]
        public System.String PBC_OWNR { get; set; }
        [Key]
        public System.String PBC_CNAM { get; set; }
        public System.Decimal? PBC_CID { get; set; }
        public System.String PBC_LABL { get; set; }
        public System.Decimal? PBC_LPOS { get; set; }
        public System.String PBC_HDR { get; set; }
        public System.Decimal? PBC_HPOS { get; set; }
        public System.Decimal? PBC_JTFY { get; set; }
        public System.String PBC_MASK { get; set; }
        public System.Decimal? PBC_CASE { get; set; }
        public System.Decimal? PBC_HGHT { get; set; }
        public System.Decimal? PBC_WDTH { get; set; }
        public System.String PBC_PTRN { get; set; }
        public System.String PBC_BMAP { get; set; }
        public System.String PBC_INIT { get; set; }
        public System.String PBC_CMNT { get; set; }
        public System.String PBC_EDIT { get; set; }
        public System.String PBC_TAG { get; set; }
    }
    [Table("PBCATEDT", Schema = "WNCCRM")]
    public partial class PBCATEDT
    {
        public System.String PBE_NAME { get; set; }
        public System.String PBE_EDIT { get; set; }
        public System.Decimal? PBE_TYPE { get; set; }
        public System.Decimal? PBE_CNTR { get; set; }
        public System.Decimal? PBE_SEQN { get; set; }
        public System.Decimal? PBE_FLAG { get; set; }
        public System.String PBE_WORK { get; set; }
    }
    [Table("PBCATFMT", Schema = "WNCCRM")]
    public partial class PBCATFMT
    {
        public System.String PBF_NAME { get; set; }
        public System.String PBF_FRMT { get; set; }
        public System.Decimal PBF_TYPE { get; set; }
        public System.Decimal? PBF_CNTR { get; set; }
    }
    [Table("PBCATTBL", Schema = "WNCCRM")]
    public partial class PBCATTBL
    {
        [Key]
        public System.String PBT_TNAM { get; set; }
        public System.Decimal? PBT_TID { get; set; }
        [Key]
        public System.String PBT_OWNR { get; set; }
        public System.Decimal? PBD_FHGT { get; set; }
        public System.Decimal? PBD_FWGT { get; set; }
        public System.String PBD_FITL { get; set; }
        public System.String PBD_FUNL { get; set; }
        public System.Decimal? PBD_FCHR { get; set; }
        public System.Decimal? PBD_FPTC { get; set; }
        public System.String PBD_FFCE { get; set; }
        public System.Decimal? PBH_FHGT { get; set; }
        public System.Decimal? PBH_FWGT { get; set; }
        public System.String PBH_FITL { get; set; }
        public System.String PBH_FUNL { get; set; }
        public System.Decimal? PBH_FCHR { get; set; }
        public System.Decimal? PBH_FPTC { get; set; }
        public System.String PBH_FFCE { get; set; }
        public System.Decimal? PBL_FHGT { get; set; }
        public System.Decimal? PBL_FWGT { get; set; }
        public System.String PBL_FITL { get; set; }
        public System.String PBL_FUNL { get; set; }
        public System.Decimal? PBL_FCHR { get; set; }
        public System.Decimal? PBL_FPTC { get; set; }
        public System.String PBL_FFCE { get; set; }
        public System.String PBT_CMNT { get; set; }
    }
    [Table("PBCATVLD", Schema = "WNCCRM")]
    public partial class PBCATVLD
    {
        public System.String PBV_NAME { get; set; }
        public System.String PBV_VALD { get; set; }
        public System.Decimal? PBV_TYPE { get; set; }
        public System.Decimal? PBV_CNTR { get; set; }
        public System.String PBV_MSG { get; set; }
    }
    [Table("PBS_WNCCRM_COMMAND", Schema = "WNCCRM")]
    public partial class PBS_WNCCRM_COMMAND
    {
        [Key]
        public System.Decimal PLATFORM_BUS_SYSTEM_ID { get; set; }
        [Key]
        public System.String COMMAND_PAGE { get; set; }
        public System.String COMMAND_LABEL { get; set; }
        public System.String COMMAND_URL { get; set; }
        public System.String COMMAND_PARMS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        [Key]
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String FLAG_URL_LOCAL { get; set; }
    }
    [Table("PERSONA", Schema = "WNCCRM")]
    public partial class PERSONA
    {
        [Key]
        public System.Decimal PERSONA_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PHY_DEV_LICENSE_REL", Schema = "WNCCRM")]
    public partial class PHY_DEV_LICENSE_REL
    {
        [Key]
        public System.Decimal PHY_DEV_LICENSE_REL_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.Decimal? PHYSICAL_DEVICE_ID { get; set; }
        public System.Decimal? RESOURCE_LICENSE_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.DateTime? VALIDITY_START_DATE_TIME { get; set; }
        public System.DateTime? VALIDITY_END_DATE_TIME { get; set; }
        public System.Decimal? CURRENT_NUMBER_LICENSES { get; set; }
        public System.Decimal? MAX_NUMBER_LICENSES { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PIN_CHANGE_LOG", Schema = "WNCCRM")]
    public partial class PIN_CHANGE_LOG
    {
        [Key]
        public System.Decimal PIN_CHANGE_LOG_ID { get; set; }
        public System.String PIN_1 { get; set; }
        public System.String PIN_1_REASON { get; set; }
        public System.String PIN_2 { get; set; }
        public System.String PIN_2_REASON { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String DSLAM_NAME { get; set; }
        public System.String IS_SUCCESSFUL { get; set; }
        public System.String ERROR_CODE { get; set; }
        public System.String MSS_ERROR_CODE { get; set; }
        public System.String MIROR_ERROR_CODE { get; set; }
        public System.String LEN_ERROR_CODE { get; set; }
        public System.String LEN_BOND_ERROR_CODE { get; set; }
        public System.String USER_ID { get; set; }
        public System.String REQUEST { get; set; }
        public System.String RESPONSE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PKG_VALIDATE_LOG", Schema = "WNCCRM")]
    public partial class PKG_VALIDATE_LOG
    {
        public System.Decimal? LOG_ID { get; set; }
        public System.String FIELD_NAME { get; set; }
        public System.String FIELD_VALUE { get; set; }
        public System.DateTime? LOG_DATE { get; set; }
    }
    [Table("PLATFORM", Schema = "WNCCRM")]
    public partial class PLATFORM
    {
        [Key]
        public System.Decimal PLATFORM_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String REMEDY_BILLING_SYSTEM { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("PLATFORM_BUS_SYSTEM", Schema = "WNCCRM")]
    public partial class PLATFORM_BUS_SYSTEM
    {
        [Key]
        public System.Decimal PLATFORM_BUS_SYSTEM_ID { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String BUS_SYSTEM_ROLE_TYPE { get; set; }
        public System.Int16? DISPLAY_SEQUENCE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PLATFORM_INV_SYSTEM", Schema = "WNCCRM")]
    public partial class PLATFORM_INV_SYSTEM
    {
        [Key]
        public System.Decimal PLATFORM_INV_SYSTEM_ID { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String INV_SYSTEM { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PLATFORM_SERVICE_NOTE", Schema = "WNCCRM")]
    public partial class PLATFORM_SERVICE_NOTE
    {
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.Decimal PLATFORM_ID { get; set; }
        public System.Decimal GLOBAL_NOTE_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("PNIP_SWITCH_INFO", Schema = "WNCCRM")]
    public partial class PNIP_SWITCH_INFO
    {
        [Key]
        public System.Decimal PNIP_SWITCH_INFO_ID { get; set; }
        public System.String CLLI_CODE { get; set; }
        public System.String FGD_TANDEM { get; set; }
        public System.String NPA { get; set; }
        public System.String NXX { get; set; }
        public System.String SWITCH_TYPE { get; set; }
        public System.String COMPANY { get; set; }
        public System.String LINE { get; set; }
        public System.String ORIG_NPA { get; set; }
        public System.String ORIG_NXX { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("POSTAL_MEDIUM", Schema = "WNCCRM")]
    public partial class POSTAL_MEDIUM
    {
        [Key]
        public System.Decimal POSTAL_MEDIUM_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String STATE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String CITY { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.Double? LATITUDE { get; set; }
        public System.Double? LONGITUDE { get; set; }
        public System.Decimal CONTACT_MEDIUM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_ANSWER", Schema = "WNCCRM")]
    public partial class PR_ANSWER
    {
        [Key]
        public System.Decimal PR_ANSWER_ID { get; set; }
        public System.Decimal PR_QUESTION_ID { get; set; }
        public System.String ANSWER_TEXT { get; set; }
        public System.Decimal SORT_ORDER { get; set; }
        public System.String IS_DEFAULT { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ANSWER_VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? PR_ANSWER_TYPE_ID { get; set; }
        public System.String UNIQUE_NAME { get; set; }
        public System.Decimal? MAX_LENGTH { get; set; }
    }
    [Table("PR_BEHAVIOR", Schema = "WNCCRM")]
    public partial class PR_BEHAVIOR
    {
        [Key]
        public System.Decimal PR_BEHAVIOR_ID { get; set; }
        public System.String BEHAVIOR_NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_CONSTRAINT", Schema = "WNCCRM")]
    public partial class PR_CONSTRAINT
    {
        [Key]
        public System.Decimal PR_CONSTRAINT_ID { get; set; }
        public System.String CONSTRAINT_NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_CONSTRAINT_VALUE", Schema = "WNCCRM")]
    public partial class PR_CONSTRAINT_VALUE
    {
        [Key]
        public System.Decimal PR_CONSTRAINT_VALUE_ID { get; set; }
        public System.String CONSTRAINT_VALUE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_PDFSTORE", Schema = "WNCCRM")]
    public partial class PR_PDFSTORE
    {
        public System.Decimal SALE_INTERACTION_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Byte[] PDF { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PR_PRODUCT_OFFERING", Schema = "WNCCRM")]
    public partial class PR_PRODUCT_OFFERING
    {
        [Key]
        public System.Decimal PR_PRODUCT_OFFERING_ID { get; set; }
        public System.Decimal PR_PRODUCT_OFFERING_TYPE_ID { get; set; }
        public System.Decimal SORT_ORDER { get; set; }
        public System.String PRODUCT_OFFERING { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal PR_QUESTION_GROUP_ID { get; set; }
        public System.Decimal? TIER { get; set; }
    }
    [Table("PR_PRODUCT_OFFERING_SUBTYPE", Schema = "WNCCRM")]
    public partial class PR_PRODUCT_OFFERING_SUBTYPE
    {
        [Key]
        public System.Decimal PR_PRODUCT_OFFERING_SUBTYPE_ID { get; set; }
        public System.Decimal PR_PRODUCT_OFFERING_ID { get; set; }
        public System.Decimal PR_PRODUCT_OFFERING_TYPE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_PRODUCT_OFFERING_TYPE", Schema = "WNCCRM")]
    public partial class PR_PRODUCT_OFFERING_TYPE
    {
        [Key]
        public System.Decimal PR_PRODUCT_OFFERING_TYPE_ID { get; set; }
        public System.String PRODUCT_OFFERING_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String UNIQUE_NAME { get; set; }
    }
    [Table("PR_PRODUCT_SELECTED", Schema = "WNCCRM")]
    public partial class PR_PRODUCT_SELECTED
    {
        [Key]
        public System.Decimal PR_PRODUCT_SELECTED_ID { get; set; }
        public System.Decimal? PR_PRODUCT_OFFERING_ID { get; set; }
        public System.String PRODUCT_OFFERING { get; set; }
        public System.String IS_OFFERED { get; set; }
        public System.String IS_SELECTED { get; set; }
        public System.Decimal PR_SUBMISSION_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.Decimal PR_PRODUCT_OFFERING_TYPE_ID { get; set; }
    }
    [Table("PR_QUESTION", Schema = "WNCCRM")]
    public partial class PR_QUESTION
    {
        [Key]
        public System.Decimal PR_QUESTION_ID { get; set; }
        public System.Decimal PR_QUESTION_GROUP_ID { get; set; }
        public System.String QUESTION_TEXT { get; set; }
        public System.String QUESTION_SHORT_TEXT { get; set; }
        public System.Decimal PR_QUESTION_TYPE_ID { get; set; }
        public System.Decimal SORT_ORDER { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String UNIQUE_NAME { get; set; }
        public System.String UPDATES_SUMMARY { get; set; }
        public System.String QUESTION_TEXT_URL { get; set; }
        public System.Decimal? MAX_LENGTH { get; set; }
        public System.String ADDITIONAL_URL_TEXT { get; set; }
        public System.String ADDITIONAL_URL { get; set; }
    }
    [Table("PR_QUESTION_BEHAVIOR", Schema = "WNCCRM")]
    public partial class PR_QUESTION_BEHAVIOR
    {
        [Key]
        public System.Decimal PR_QUESTION_BEHAVIOR_ID { get; set; }
        public System.Decimal PR_BEHAVIOR_ID { get; set; }
        public System.Decimal PR_SOURCE_QUESTION_ID { get; set; }
        public System.Decimal? PR_SOURCE_ANSWER_ID { get; set; }
        public System.Decimal? PR_TARGET_QUESTION_ID { get; set; }
        public System.Decimal? PR_TARGET_ANSWER_ID { get; set; }
        public System.Decimal? PR_TARGET_PRODUCT_OFFERING_ID { get; set; }
        public System.Decimal GROUP_BY { get; set; }
        public System.Decimal IMPORTANCE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_QUESTION_CONSTRAINT", Schema = "WNCCRM")]
    public partial class PR_QUESTION_CONSTRAINT
    {
        [Key]
        public System.Decimal PR_QUESTION_CONSTRAINT_ID { get; set; }
        public System.Decimal PR_QUESTION_ID { get; set; }
        public System.Decimal PR_CONSTRAINT_ID { get; set; }
        public System.Decimal PR_CONSTRAINT_VALUE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_QUESTION_GROUP", Schema = "WNCCRM")]
    public partial class PR_QUESTION_GROUP
    {
        [Key]
        public System.Decimal PR_QUESTION_GROUP_ID { get; set; }
        public System.String GROUP_NAME { get; set; }
        public System.Decimal SORT_ORDER { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String UNIQUE_NAME { get; set; }
        public System.String GROUP_NAME_URL { get; set; }
        public System.String INTRO_TEXT { get; set; }
    }
    [Table("PR_QUESTION_TYPE", Schema = "WNCCRM")]
    public partial class PR_QUESTION_TYPE
    {
        [Key]
        public System.Decimal PR_QUESTION_TYPE_ID { get; set; }
        public System.String QUESTION_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PR_SUBMISSION", Schema = "WNCCRM")]
    public partial class PR_SUBMISSION
    {
        [Key]
        public System.Decimal PR_SUBMISSION_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? DCRIS_BUS_INTERACTION_ID { get; set; }
        public System.String CREATED_USER_DISPLAY { get; set; }
        public System.String LAST_UPDATE_USER_DISPLAY { get; set; }
    }
    [Table("PR_SUBMISSION_ANSWER", Schema = "WNCCRM")]
    public partial class PR_SUBMISSION_ANSWER
    {
        [Key]
        public System.Decimal PR_SUBMISSION_ANSWER_ID { get; set; }
        public System.Decimal PR_SUBMISSION_ID { get; set; }
        public System.Decimal PR_QUESTION_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? PR_ANSWER_ID { get; set; }
        public System.String ANSWER_VALUE { get; set; }
    }
    [Table("PRD_TN_SERVICES_DLY", Schema = "WNCCRM")]
    public partial class PRD_TN_SERVICES_DLY
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.Decimal? PRODUCT_SPEC_ID { get; set; }
    }
    [Table("PRD_TN_SERVICES_WKLY", Schema = "WNCCRM")]
    public partial class PRD_TN_SERVICES_WKLY
    {
        public System.String NAME { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.Decimal? PRODUCT_SPEC_ID { get; set; }
    }
    [Table("PREORDER", Schema = "WNCCRM")]
    public partial class PREORDER
    {
        [Key]
        public System.Decimal PREORDER_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String PRODUCTS_OFFERING { get; set; }
        public System.String REASON_FOR_NO_SALE { get; set; }
        public System.String REASON_DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATED_USER { get; set; }
        public System.DateTime? LAST_UPDATED_DATE { get; set; }
    }
    [Table("PROCESS_PROGRESS", Schema = "WNCCRM")]
    public partial class PROCESS_PROGRESS
    {
        [Key]
        public System.Decimal PROCESS_PROGRESS_ID { get; set; }
        public System.String GUID { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String STATUS { get; set; }
        public System.String OBJECT_TYPE { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
    }
    [Table("PROD_MAPPING_AUDIT", Schema = "WNCCRM")]
    public partial class PROD_MAPPING_AUDIT
    {
        [Key]
        public System.Decimal AUID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_BY { get; set; }
        public System.DateTime LOAD_COMPLETION_DATE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("PROD_SERV_MAPPING", Schema = "WNCCRM")]
    public partial class PROD_SERV_MAPPING
    {
        public System.Decimal AUID { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String ST_SERVICE_NAME { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String IS_CIRCUIT { get; set; }
    }
    [Table("PROD_SPEC_SERV_SPEC", Schema = "WNCCRM")]
    public partial class PROD_SPEC_SERV_SPEC
    {
        [Key]
        public System.Decimal PROD_SPEC_SERV_SPEC_ID { get; set; }
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PROD_SPEC_SERV_SPEC_03_28", Schema = "WNCCRM")]
    public partial class PROD_SPEC_SERV_SPEC_03_28
    {
        public System.Decimal PROD_SPEC_SERV_SPEC_ID { get; set; }
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PROD_SPEC_SERV_SPEC_04_08", Schema = "WNCCRM")]
    public partial class PROD_SPEC_SERV_SPEC_04_08
    {
        public System.Decimal PROD_SPEC_SERV_SPEC_ID { get; set; }
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PROD_SPEC_SERV_SPEC_ROLE_LKUP", Schema = "WNCCRM")]
    public partial class PROD_SPEC_SERV_SPEC_ROLE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PRODUCT", Schema = "WNCCRM")]
    public partial class PRODUCT
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? ADDITIONAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? INITIAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? LAST_INVOICE_DATE { get; set; }
        public System.String IS_CHARGE_WAIVED { get; set; }
        public System.DateTime? ORDER_DATE { get; set; }
        public System.Double? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.Double? PRICE { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? PRECISION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? RATE_PLAN_ID { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
        public System.String IS_MULTI_RESOURCE { get; set; }
        public System.String RATING { get; set; }
        public System.String PACKAGE_NAME { get; set; }
        public System.String BRAND_NAME { get; set; }
    }
    [Table("PRODUCT_AVAILABILITY", Schema = "WNCCRM")]
    public partial class PRODUCT_AVAILABILITY
    {
        public System.String NPA_NXX { get; set; }
        public System.String STATE { get; set; }
        public System.String NPA_NXX_CO { get; set; }
        public System.String MARKET { get; set; }
        public System.String TERRITORY { get; set; }
        public System.String DYNAMIC_IP { get; set; }
        public System.String VIRTUAL_PBX { get; set; }
        public System.String INTEGRATED_T1 { get; set; }
        public System.String DEDICATED_INTERNET { get; set; }
        public System.String ETHERNET_INTERNET { get; set; }
        public System.String VLS { get; set; }
        public System.String MPLS_VPN { get; set; }
        public System.String PRI { get; set; }
        public System.String POTS { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String RC_STATE { get; set; }
        public System.String LATA { get; set; }
        public System.String VOX { get; set; }
        public System.String WIN_ILEC { get; set; }
        public System.String WIN_CLEC { get; set; }
        public System.String PAE { get; set; }
        public System.String LAST_UPDATED_USER { get; set; }
        public System.DateTime? LAST_UPDATED_DATE { get; set; }
        public System.Decimal? OID { get; set; }
        [Key]
        public System.Decimal PRODUCT_AVAILABILITY_ID { get; set; }
    }
    [Table("PRODUCT_CAMS_STG_DLY", Schema = "WNCCRM")]
    public partial class PRODUCT_CAMS_STG_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
    }
    [Table("PRODUCT_CHILD_DLY", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_CHILD_DLY_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_DLY_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_CHILD_PRE_WKD_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_PRE_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE_CRM { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.DateTime? END_DATE_CRM { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY_CRM { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME_CRM { get; set; }
        public System.String NAME { get; set; }
        public System.Double? REVENUE_CRM { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID_CRM { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE_CRM { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS_CRM { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME_CRM { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("PRODUCT_CHILD_STG_DLY", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_STG_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("PRODUCT_CHILD_STG_DLY_A", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_STG_DLY_A
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("PRODUCT_CHILD_WKD", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_WKD
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_CHILD_WKD_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_CHILD_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_COMPONENT", Schema = "WNCCRM")]
    public partial class PRODUCT_COMPONENT
    {
        public System.String EXTERNAL_SOURCE_SYSTEM { get; set; }
        public System.String FEATURE_NAME { get; set; }
        public System.String PRODUCT_CATEGORY { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String REVENUE_CATEGORY { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String PRODUCT_COMP_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("PRODUCT_COMPONENT_STG", Schema = "WNCCRM")]
    public partial class PRODUCT_COMPONENT_STG
    {
        public System.String EXTERNAL_SOURCE_SYSTEM { get; set; }
        public System.String FEATURE_NAME { get; set; }
        public System.String PRODUCT_CATEGORY { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String REVENUE_CATEGORY { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String PRODUCT_COMP_EXTERNAL_ID { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String DATA_INSERTED_USER { get; set; }
        public System.DateTime? DATA_INSERTED_DATE { get; set; }
        public System.String DATA_UPDATED_USER { get; set; }
        public System.DateTime? DATA_UPDATED_DATE { get; set; }
    }
    [Table("PRODUCT_DCRIS_ORD_REL", Schema = "WNCCRM")]
    public partial class PRODUCT_DCRIS_ORD_REL
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? ADDITIONAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? INITIAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? LAST_INVOICE_DATE { get; set; }
        public System.String IS_CHARGE_WAIVED { get; set; }
        public System.DateTime? ORDER_DATE { get; set; }
        public System.Double? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.Double? PRICE { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? PRECISION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? RATE_PLAN_ID { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String ORDER_ID { get; set; }
        public System.String ORDER_STATUS { get; set; }
        public System.String ORDER_REMARKS { get; set; }
        public System.String SO_NMBR { get; set; }
    }
    [Table("PRODUCT_PARENT_DLY", Schema = "WNCCRM")]
    public partial class PRODUCT_PARENT_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_PARENT_DLY_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_PARENT_DLY_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_PRE_WKD_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_PRE_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE_CRM { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.DateTime? END_DATE_CRM { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY_CRM { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME_CRM { get; set; }
        public System.String NAME { get; set; }
        public System.Double? REVENUE_CRM { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID_CRM { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE_CRM { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS_CRM { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME_CRM { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("PRODUCT_REL", Schema = "WNCCRM")]
    public partial class PRODUCT_REL
    {
        [Key]
        public System.Decimal PRODUCT_REL_ID { get; set; }
        public System.Decimal? PARENT_PRODUCT_ID { get; set; }
        public System.Decimal? CHILD_PRODUCT_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PRODUCT_RESOURCE", Schema = "WNCCRM")]
    public partial class PRODUCT_RESOURCE
    {
        [Key]
        public System.Decimal PRODUCT_RESOURCE_ID { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.String TYPE { get; set; }
        public System.String STATUS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PRODUCT_SPEC", Schema = "WNCCRM")]
    public partial class PRODUCT_SPEC
    {
        [Key]
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TYPE { get; set; }
        public System.String IS_CIRCUIT_PRODUCT { get; set; }
        public System.String IS_GLOBAL_PRODUCT { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_SPEC_03_28", Schema = "WNCCRM")]
    public partial class PRODUCT_SPEC_03_28
    {
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TYPE { get; set; }
        public System.String IS_CIRCUIT_PRODUCT { get; set; }
        public System.String IS_GLOBAL_PRODUCT { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_SPEC_04_08", Schema = "WNCCRM")]
    public partial class PRODUCT_SPEC_04_08
    {
        public System.Decimal PRODUCT_SPEC_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TYPE { get; set; }
        public System.String IS_CIRCUIT_PRODUCT { get; set; }
        public System.String IS_GLOBAL_PRODUCT { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_SPEC_REL", Schema = "WNCCRM")]
    public partial class PRODUCT_SPEC_REL
    {
        [Key]
        public System.Decimal PRODUCT_SPEC_REL_ID { get; set; }
        public System.Decimal PARENT_PRODUCT_SPEC_ID { get; set; }
        public System.Decimal CHILD_PRODUCT_SPEC_ID { get; set; }
        public System.Decimal PRODUCT_SPEC_REL_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PRODUCT_SPEC_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class PRODUCT_SPEC_TYPE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PRODUCT_STG", Schema = "WNCCRM")]
    public partial class PRODUCT_STG
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ADDITIONAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? INITIAL_PERIOD_INCREMENT { get; set; }
        public System.DateTime? LAST_INVOICE_DATE { get; set; }
        public System.String IS_CHARGE_WAIVED { get; set; }
        public System.DateTime? ORDER_DATE { get; set; }
        public System.Double? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.Double? PRICE { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? PRECISION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? RATE_PLAN_ID { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PRODUCT_STG_DLY", Schema = "WNCCRM")]
    public partial class PRODUCT_STG_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
    }
    [Table("PRODUCT_STG_WKD", Schema = "WNCCRM")]
    public partial class PRODUCT_STG_WKD
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_STG_WKD_UPD", Schema = "WNCCRM")]
    public partial class PRODUCT_STG_WKD_UPD
    {
        public System.Decimal? PRODUCT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String BENT_CAMS_ID { get; set; }
        public System.String LOCAL_PRODUCT_ID { get; set; }
        public System.DateTime? BILL_THROUGH_DATE { get; set; }
        public System.String CODE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? REVENUE { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.String RATE_PLAN_NAME { get; set; }
        public System.Decimal? ORDERING_BUS_SYSTEM_ID { get; set; }
    }
    [Table("PRODUCT_UPSELL", Schema = "WNCCRM")]
    public partial class PRODUCT_UPSELL
    {
        [Key]
        public System.Decimal PRODUCT_UPSELL_ID { get; set; }
        public System.String CODE { get; set; }
        public System.String SPEED { get; set; }
        public System.String FREE_OFFER { get; set; }
        public System.String PAID_OFFER { get; set; }
        public System.String EQUIPMENT_COST { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PROFILE_DASHBOARD_TEMPLATE", Schema = "WNCCRM")]
    public partial class PROFILE_DASHBOARD_TEMPLATE
    {
        [Key]
        public System.Decimal DASHBOARD_TEMPLATE_ID { get; set; }
        [Key]
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("PROFILE_NOTIFICATION", Schema = "WNCCRM")]
    public partial class PROFILE_NOTIFICATION
    {
        [Key]
        public System.Decimal PROFILE_NOTIFICATION_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal NOTIFICATION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("PROFILE_SETTING", Schema = "WNCCRM")]
    public partial class PROFILE_SETTING
    {
        [Key]
        public System.Decimal PROFILE_SETTING_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal SETTING_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("PROV_PLAN_VALID_LKUP", Schema = "WNCCRM")]
    public partial class PROV_PLAN_VALID_LKUP
    {
        [Key]
        public System.Decimal PROV_PLAN_VALID_LKUP_ID { get; set; }
        public System.String PROVISIONING_PLAN_NAME { get; set; }
        public System.String VALIDATION_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("QT_CUST_ACCT_REL", Schema = "WNCCRM")]
    public partial class QT_CUST_ACCT_REL
    {
        public System.String Q_NAME { get; set; }
        [Key]
        public System.Byte[] MSGID { get; set; }
        public System.String CORRID { get; set; }
        public System.Decimal? PRIORITY { get; set; }
        public System.Decimal? STATE { get; set; }
        public System.DateTime? DELAY { get; set; }
        public System.Decimal? EXPIRATION { get; set; }
        public System.DateTime? TIME_MANAGER_INFO { get; set; }
        public System.Decimal? LOCAL_ORDER_NO { get; set; }
        public System.Decimal? CHAIN_NO { get; set; }
        public System.Decimal? CSCN { get; set; }
        public System.Decimal? DSCN { get; set; }
        public System.DateTime? ENQ_TIME { get; set; }
        public System.Decimal? ENQ_UID { get; set; }
        public System.String ENQ_TID { get; set; }
        public System.DateTime? DEQ_TIME { get; set; }
        public System.Decimal? DEQ_UID { get; set; }
        public System.String DEQ_TID { get; set; }
        public System.Decimal? RETRY_COUNT { get; set; }
        public System.String EXCEPTION_QSCHEMA { get; set; }
        public System.String EXCEPTION_QUEUE { get; set; }
        public System.Decimal? STEP_NO { get; set; }
        public System.Decimal? RECIPIENT_KEY { get; set; }
        public System.Byte[] DEQUEUE_MSGID { get; set; }
        public System.Decimal? REFCOUNT { get; set; }
        public System.Object HISTORY { get; set; }
        public System.Object USER_DATA { get; set; }
    }
    [Table("QUOTE_PACKAGE", Schema = "WNCCRM")]
    public partial class QUOTE_PACKAGE
    {
        public System.Decimal? QUOTE_PACKAGE_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? STATUS_DATE { get; set; }
        public System.Decimal? BUS_ARTIFACT_ID { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        [Key]
        public System.String QUOTE_PACKAGE_NUMBER { get; set; }
        public System.DateTime? SD_ACCEPT_DATE { get; set; }
        public System.DateTime? SD_REJECT_DATE { get; set; }
    }
    [Table("QUOTED_SOLUTION", Schema = "WNCCRM")]
    public partial class QUOTED_SOLUTION
    {
        [Key]
        public System.Decimal QUOTED_SOLUTION_ID { get; set; }
        public System.Decimal? QUOTE_PACKAGE_ID { get; set; }
        public System.String SOLUTION_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? STATUS_DATE { get; set; }
        public System.Decimal? SERVICE_ORDER_NUM { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("RECENT_ITEMS", Schema = "WNCCRM")]
    public partial class RECENT_ITEMS
    {
        public System.String USERNAME { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        [Key]
        public System.Decimal RECENTITEMSID { get; set; }
        public System.String CUSTOMERNAME { get; set; }
        public System.DateTime INSERTEDTIME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ACCOUNTNUMBER { get; set; }
    }
    [Table("RECENT_ITEMS_TMP", Schema = "WNCCRM")]
    public partial class RECENT_ITEMS_TMP
    {
        public System.String USERNAME { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal RECENTITEMSID { get; set; }
        public System.String CUSTOMERNAME { get; set; }
        public System.DateTime INSERTEDTIME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String ACCOUNTNUMBER { get; set; }
    }
    [Table("REF_BUS_OBJ", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ
    {
        [Key]
        public System.Decimal REF_BUS_OBJ_ID { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String REF_OBJ_TYPE { get; set; }
        public System.String VALUE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal BUS_SYSTEMID { get; set; }
        public System.Decimal GLOBAL_VALUE_ID { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("REF_BUS_OBJ_LOG", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_LOG
    {
        public System.Decimal? NEW_REF_BUS_OBJ_ID { get; set; }
        public System.String NEW_ACTIVITY { get; set; }
        public System.String NEW_OBJECT_STATE { get; set; }
        public System.String NEW_REF_OBJ_TYPE { get; set; }
        public System.String NEW_VALUE { get; set; }
        public System.String NEW_DESCRIPTION { get; set; }
        public System.Decimal? NEW_SORT_ORDER { get; set; }
        public System.String NEW_CREATED_USER { get; set; }
        public System.DateTime? NEW_CREATED_DATE { get; set; }
        public System.Decimal? NEW_BUS_SYSTEMID { get; set; }
        public System.Decimal? NEW_GLOBAL_VALUE_ID { get; set; }
        public System.String NEW_CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? NEW_CREATED_SYSTEM_DATE { get; set; }
        public System.String NEW_LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? NEW_LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? OLD_REF_BUS_OBJ_ID { get; set; }
        public System.String OLD_ACTIVITY { get; set; }
        public System.String OLD_OBJECT_STATE { get; set; }
        public System.String OLD_REF_OBJ_TYPE { get; set; }
        public System.String OLD_VALUE { get; set; }
        public System.String OLD_DESCRIPTION { get; set; }
        public System.Decimal? OLD_SORT_ORDER { get; set; }
        public System.String OLD_CREATED_USER { get; set; }
        public System.DateTime? OLD_CREATED_DATE { get; set; }
        public System.Decimal? OLD_BUS_SYSTEMID { get; set; }
        public System.Decimal? OLD_GLOBAL_VALUE_ID { get; set; }
        public System.String OLD_CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? OLD_CREATED_SYSTEM_DATE { get; set; }
        public System.String OLD_LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? OLD_LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
    }
    [Table("REF_BUS_OBJ_PROD", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_PROD
    {
        public System.Decimal REF_BUS_OBJ_ID { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String REF_OBJ_TYPE { get; set; }
        public System.String VALUE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.Decimal BUS_SYSTEMID { get; set; }
        public System.Decimal GLOBAL_VALUE_ID { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("REF_BUS_OBJ_REL", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_REL
    {
        [Key]
        public System.Decimal REF_BUS_OBJ_REL_ID { get; set; }
        public System.Decimal REF_BUS_OBJ_REL_SPEC_ID { get; set; }
        public System.Decimal CHILD_REF_BUS_OBJ_ID { get; set; }
        public System.Decimal PARENT_REF_BUS_OBJ_ID { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("REF_BUS_OBJ_REL_PROD", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_REL_PROD
    {
        public System.String CHILD_ENTITY_TYPE { get; set; }
        public System.String CHILD_REF_OBJ_TYPE { get; set; }
        public System.String CHILD_VALUE { get; set; }
        public System.String PARENT_ENTITY_TYPE { get; set; }
        public System.String PARENT_REF_OBJ_TYPE { get; set; }
        public System.String PARENT_VALUE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
    }
    [Table("REF_BUS_OBJ_REL_SPEC", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_REL_SPEC
    {
        [Key]
        public System.Decimal REF_BUS_OBJ_REL_SPEC_ID { get; set; }
        public System.String CHILD_ENTITY_TYPE { get; set; }
        public System.String PARENT_ENTITY_TYPE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String REL_SPEC_REF { get; set; }
    }
    [Table("REF_BUS_OBJ_REL_SPEC_PROD", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_REL_SPEC_PROD
    {
        public System.String CHILD_ENTITY_TYPE { get; set; }
        public System.String PARENT_ENTITY_TYPE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.String REL_SPEC_REF { get; set; }
    }
    [Table("REF_BUS_OBJ_SPEC", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_SPEC
    {
        [Key]
        public System.String REF_OBJ_TYPE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATED_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATED_USER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String NULL_VALUE_ALLOWABLE { get; set; }
    }
    [Table("REF_BUS_OBJ_SPEC_LOG", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_SPEC_LOG
    {
        public System.String NEW_REF_OBJ_TYPE { get; set; }
        public System.String NEW_CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? NEW_CREATED_SYSTEM_DATE { get; set; }
        public System.String NEW_LAST_UPDATED_SYSTEM_USER { get; set; }
        public System.DateTime? NEW_LAST_UPDATED_SYSTEM_DATE { get; set; }
        public System.String NEW_CREATED_USER { get; set; }
        public System.DateTime? NEW_CREATED_DATE { get; set; }
        public System.String NEW_LAST_UPDATED_USER { get; set; }
        public System.DateTime? NEW_LAST_UPDATED_DATE { get; set; }
        public System.String NEW_OBJECT_STATE { get; set; }
        public System.String NEW_NAME { get; set; }
        public System.String NEW_DESCRIPTION { get; set; }
        public System.String NEW_NULL_VALUE_ALLOWABLE { get; set; }
        public System.String OLD_REF_OBJ_TYPE { get; set; }
        public System.String OLD_CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? OLD_CREATED_SYSTEM_DATE { get; set; }
        public System.String OLD_LAST_UPDATED_SYSTEM_USER { get; set; }
        public System.DateTime? OLD_LAST_UPDATED_SYSTEM_DATE { get; set; }
        public System.String OLD_CREATED_USER { get; set; }
        public System.DateTime? OLD_CREATED_DATE { get; set; }
        public System.String OLD_LAST_UPDATED_USER { get; set; }
        public System.DateTime? OLD_LAST_UPDATED_DATE { get; set; }
        public System.String OLD_OBJECT_STATE { get; set; }
        public System.String OLD_NAME { get; set; }
        public System.String OLD_DESCRIPTION { get; set; }
        public System.String OLD_NULL_VALUE_ALLOWABLE { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
    }
    [Table("REF_BUS_OBJ_SPEC_PROD", Schema = "WNCCRM")]
    public partial class REF_BUS_OBJ_SPEC_PROD
    {
        public System.String REF_OBJ_TYPE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATED_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATED_USER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String NULL_VALUE_ALLOWABLE { get; set; }
    }
    [Table("REF_BUS_QUERY", Schema = "WNCCRM")]
    public partial class REF_BUS_QUERY
    {
        [Key]
        public System.Decimal REF_BUS_QUERY_ID { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String REF_OBJ_QUERY_TYPE { get; set; }
        public System.String VALUE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? SORT_ORDER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("REGION_IN_DASHBOARD", Schema = "WNCCRM")]
    public partial class REGION_IN_DASHBOARD
    {
        [Key]
        public System.Decimal DASHBOARD_REGION_SPEC_ID { get; set; }
        [Key]
        public System.Decimal DASHBOARD_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("REGION_IN_DASHBOARD_TEMPLATE", Schema = "WNCCRM")]
    public partial class REGION_IN_DASHBOARD_TEMPLATE
    {
        [Key]
        public System.Decimal REGION_IN_DASH_TEMP_ID { get; set; }
        public System.Decimal DASHBOARD_SPEC_ID { get; set; }
        public System.Decimal DASHBOARD_TEMPLATE_ID { get; set; }
        public System.Decimal DASHBOARD_REGION_SPEC_ID { get; set; }
        public System.Decimal POSITION { get; set; }
        public System.String IS_COLLAPSED { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String HEIGHT { get; set; }
        public System.String WIDTH { get; set; }
    }
    [Table("REPORT_SPEC", Schema = "WNCCRM")]
    public partial class REPORT_SPEC
    {
        [Key]
        public System.Decimal REPORT_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CUST_REPORT_TYPE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.Decimal? QUANTITY { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String COMMENTS { get; set; }
    }
    [Table("REPORT_TYPE_CODE_STATIC", Schema = "WNCCRM")]
    public partial class REPORT_TYPE_CODE_STATIC
    {
        [Key]
        public System.String REPORT_TYPE_CODE { get; set; }
        public System.String REPORT_TYPE_DESCRIPTION { get; set; }
    }
    [Table("RESOURCE_LICENSE", Schema = "WNCCRM")]
    public partial class RESOURCE_LICENSE
    {
        [Key]
        public System.Decimal RESOURCE_LICENSE_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.String MANUFACTURER_NAME { get; set; }
        public System.String LICENSE_IDENTIFIER { get; set; }
        public System.String LICENSE_KEY { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("RPT_FIELD_AGENTS_LIST", Schema = "WNCCRM")]
    public partial class RPT_FIELD_AGENTS_LIST
    {
        public System.String ID { get; set; }
        public System.String NAME { get; set; }
        public System.String BUS_UNIT { get; set; }
        public System.String BU { get; set; }
        public System.String CLEC_ILEC { get; set; }
        public System.DateTime? HIRE_DATE { get; set; }
        public System.DateTime? SERVICE_DT { get; set; }
        public System.String JOBCD_DESC { get; set; }
        public System.String LOCATION { get; set; }
        public System.String LOCATION_DESCR { get; set; }
        public System.String STATE { get; set; }
        public System.String ROLLOUT { get; set; }
        public System.String SUPER_NAME { get; set; }
        public System.String AC_EXT_LVL00_NA { get; set; }
        public System.String AC_EXT_LVL01_NA { get; set; }
        public System.String AC_EXT_LVL02_NA { get; set; }
        public System.String CHANGE_REPORTS_TO { get; set; }
        public System.String CHANGE_ILEC_CLEC_BU { get; set; }
        public System.String AC_EXT_LVL03_NA { get; set; }
        public System.String AC_EXT_LVL04_NA { get; set; }
        public System.String AC_EXT_LVL05_NA { get; set; }
        public System.String AC_EXT_LVL06_NA { get; set; }
    }
    [Table("RSC_ASOC_MAPPING_TABLE", Schema = "WNCCRM")]
    public partial class RSC_ASOC_MAPPING_TABLE
    {
        [Key]
        public System.Decimal CATEGORY_ID { get; set; }
        public System.String CATEGORY_NAME { get; set; }
        public System.String ASOC { get; set; }
        public System.String MAJOR_CATEGORY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? REVENUE { get; set; }
    }
    [Table("RSC_GOALS", Schema = "WNCCRM")]
    public partial class RSC_GOALS
    {
        [Key]
        public System.Decimal MAGNYS_COMPONENTS_ID { get; set; }
        public System.String MAGNYS_COMPONENTS { get; set; }
        public System.String TARGET_MONTH { get; set; }
        public System.String COMPANY_MONTHLY_QUOTA { get; set; }
        public System.String COMPANY_DAILY_QUOTA { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.Decimal? BUSINESS_DAYS { get; set; }
    }
    [Table("RSC_GOALS_FOR_USER", Schema = "WNCCRM")]
    public partial class RSC_GOALS_FOR_USER
    {
        public System.Decimal? MAGNYS_COMPONENTS_ID { get; set; }
        public System.String MONTHLY_GOAL { get; set; }
        public System.String ACTUAL_MONTH_TOTAL { get; set; }
        public System.String ACTUAL_DAYTOTAL { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String OWNER { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("S1_HDM_ACTIVE_MODEM_STG", Schema = "WNCCRM")]
    public partial class S1_HDM_ACTIVE_MODEM_STG
    {
        public System.String SERIALNUMBER { get; set; }
        public System.String SUBSCRIBERID { get; set; }
        public System.String MACADDRESS { get; set; }
        public System.String SOFTWAREVERSION { get; set; }
        public System.String OUI { get; set; }
        public System.String PRODUCT_CLASS { get; set; }
        public System.DateTime? FIRSTCONTACTTIME { get; set; }
        public System.DateTime? LASTCONTACTTIME { get; set; }
        public System.DateTime? LASTACTIVATIONTIME { get; set; }
        public System.String FLOWSUBSCRIBERTN { get; set; }
        public System.String DV_PPPOE_USERNAME { get; set; }
        public System.String DV_CUST_PHONENUMBER { get; set; }
        public System.String UT_CUST_STATE { get; set; }
        public System.String UT_CUST_NAME { get; set; }
        public System.DateTime? FROM_DATE { get; set; }
        public System.DateTime? TO_DATE { get; set; }
        public System.String ACTIVE_HDM { get; set; }
        public System.DateTime? REPORT_DT { get; set; }
        public System.DateTime? CREATE_DT { get; set; }
        public System.DateTime? UPDATE_DT { get; set; }
        public System.String ST_WG_STATUS { get; set; }
    }
    [Table("SALES_REPS", Schema = "WNCCRM")]
    public partial class SALES_REPS
    {
        [Key]
        public System.String ID { get; set; }
        public System.String NAME { get; set; }
        public System.String COMPANYNAME { get; set; }
        public System.String EMAIL { get; set; }
        public System.String PROFILEID { get; set; }
        public System.String PROFILENAME { get; set; }
        public System.String EMPLOYEENUMBER { get; set; }
        public System.String MANAGERID { get; set; }
        public System.String MANAGER_NAME { get; set; }
        public System.String APPROVER__C { get; set; }
        public System.String APPROVERNAME { get; set; }
        public System.String DIRECTOR_EMPID__C { get; set; }
        public System.String DIRECTOR_NAME__C { get; set; }
        public System.String REGION__C { get; set; }
        public System.String SALES_CHANNEL__C { get; set; }
        public System.String ROLE_NAME__C { get; set; }
        public System.String ISACTIVE { get; set; }
        public System.String POSITION__C { get; set; }
    }
    [Table("SCHEDULER_JOBS", Schema = "WNCCRM")]
    public partial class SCHEDULER_JOBS
    {
        public System.String OWNER { get; set; }
        public System.String JOB_NAME { get; set; }
        public System.String PREV_ENABLED_STATUS { get; set; }
        public System.String ENABLE_STATEMENT { get; set; }
        public System.String DISABLE_STATEMENT { get; set; }
        public System.DateTime? ENTRY_DATE { get; set; }
    }
    [Table("SECURITY_AUDIT", Schema = "WNCCRM")]
    public partial class SECURITY_AUDIT
    {
        public System.Decimal? SECURITY_AUDIT_ID { get; set; }
        public System.String INCIDENT_NUMBER { get; set; }
        public System.String NOTES { get; set; }
    }
    [Table("SECURITY_AUDIT_LOG", Schema = "WNCCRM")]
    public partial class SECURITY_AUDIT_LOG
    {
        [Key]
        public System.Decimal SECURITY_AUDIT_ID { get; set; }
        [Key]
        public System.Decimal LOG_ID { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.String IS_ARCHIVED { get; set; }
        public System.DateTime? ARCHIVED_DATE { get; set; }
        public System.String ARCHIVED_USER { get; set; }
    }
    [Table("SECURITY_FUNCTION", Schema = "WNCCRM")]
    public partial class SECURITY_FUNCTION
    {
        [Key]
        public System.Decimal SECURITY_FUNCTION_ID { get; set; }
        [Column("SECURITY_FUNCTION")]
        public System.String SECURITY_FUNCTION_val { get; set; }
        public System.String SECURITY_FUNCTION_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.String IS_READONLY { get; set; }
    }
    [Table("SECURITY_FUNCTION_LOG", Schema = "WNCCRM")]
    public partial class SECURITY_FUNCTION_LOG
    {
        public System.Decimal? NEW_SECURITY_FUNCTION_ID { get; set; }
        public System.String NEW_SECURITY_FUNCTION { get; set; }
        public System.String NEW_SECURITY_FUNCTION_DESC { get; set; }
        public System.String NEW_CREATE_USERID { get; set; }
        public System.DateTime? NEW_CREATE_DATE { get; set; }
        public System.String NEW_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? NEW_LAST_MODIFIED_DATE { get; set; }
        public System.String NEW_IS_READONLY { get; set; }
        public System.Decimal? OLD_SECURITY_FUNCTION_ID { get; set; }
        public System.String OLD_SECURITY_FUNCTION { get; set; }
        public System.String OLD_SECURITY_FUNCTION_DESC { get; set; }
        public System.String OLD_CREATE_USERID { get; set; }
        public System.DateTime? OLD_CREATE_DATE { get; set; }
        public System.String OLD_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? OLD_LAST_MODIFIED_DATE { get; set; }
        public System.String OLD_IS_READONLY { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
        public System.Decimal? LOG_ID { get; set; }
    }
    [Table("SECURITY_FUNCTION_PROD", Schema = "WNCCRM")]
    public partial class SECURITY_FUNCTION_PROD
    {
        public System.Decimal SECURITY_FUNCTION_ID { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String SECURITY_FUNCTION_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.String IS_READONLY { get; set; }
    }
    [Table("SECURITY_HIERARCHY", Schema = "WNCCRM")]
    public partial class SECURITY_HIERARCHY
    {
        public System.Decimal PLATFORM_ID { get; set; }
        public System.String DEFAULT_HIERARCHY { get; set; }
    }
    [Table("SECURITY_PROFILE", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE
    {
        [Key]
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        [Column("SECURITY_PROFILE")]
        public System.String SECURITY_PROFILE_val { get; set; }
        public System.String SECURITY_PROFILE_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.Decimal RANK { get; set; }
        public System.String FLAG_ADDON_PROFILE { get; set; }
    }
    [Table("SECURITY_PROFILE_ELNK", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE_ELNK
    {
        public System.Decimal SECURITY_PROFL_FUNC_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal SECURITY_FUNCTION_ID { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
    }
    [Table("SECURITY_PROFILE_FUNC_STG", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE_FUNC_STG
    {
        public System.String SECURITY_PROFILE { get; set; }
        public System.String PLATFORM { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String CREATED_USERID { get; set; }
        public System.Decimal? SECURITY_PROFILE_ID { get; set; }
        public System.Decimal? SECURITY_FUNCTION_ID { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String ROW_EXISTS { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
    }
    [Table("SECURITY_PROFILE_LOG", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE_LOG
    {
        public System.Decimal? NEW_SECURITY_PROFILE_ID { get; set; }
        public System.String NEW_SECURITY_PROFILE { get; set; }
        public System.String NEW_SECURITY_PROFILE_DESC { get; set; }
        public System.String NEW_CREATE_USERID { get; set; }
        public System.DateTime? NEW_CREATE_DATE { get; set; }
        public System.String NEW_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? NEW_LAST_MODIFIED_DATE { get; set; }
        public System.String NEW_FLAG_ENABLED { get; set; }
        public System.Decimal? NEW_RANK { get; set; }
        public System.Decimal? OLD_SECURITY_PROFILE_ID { get; set; }
        public System.String OLD_SECURITY_PROFILE { get; set; }
        public System.String OLD_SECURITY_PROFILE_DESC { get; set; }
        public System.String OLD_CREATE_USERID { get; set; }
        public System.DateTime? OLD_CREATE_DATE { get; set; }
        public System.String OLD_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? OLD_LAST_MODIFIED_DATE { get; set; }
        public System.String OLD_FLAG_ENABLED { get; set; }
        public System.Decimal? OLD_RANK { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
        public System.Decimal? LOG_ID { get; set; }
    }
    [Table("SECURITY_PROFILE_PERSONA", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE_PERSONA
    {
        [Key]
        public System.Decimal SECURITY_PROFILE_PERSONA_ID { get; set; }
        public System.Decimal? SECURITY_PROFILE_ID { get; set; }
        public System.Decimal? PERSONA_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SECURITY_PROFILE_PROD", Schema = "WNCCRM")]
    public partial class SECURITY_PROFILE_PROD
    {
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.String SECURITY_PROFILE { get; set; }
        public System.String SECURITY_PROFILE_DESCRIPTION { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.String FLAG_ENABLED { get; set; }
        public System.Decimal RANK { get; set; }
    }
    [Table("SECURITY_PROFL_FUNC", Schema = "WNCCRM")]
    public partial class SECURITY_PROFL_FUNC
    {
        [Key]
        public System.Decimal SECURITY_PROFL_FUNC_ID { get; set; }
        public System.Decimal SECURITY_PROFILE_ID { get; set; }
        public System.Decimal SECURITY_FUNCTION_ID { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String CREATE_USERID { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.String LAST_MODIFIED_USERID { get; set; }
        public System.DateTime LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
    }
    [Table("SECURITY_PROFL_FUNC_LOG", Schema = "WNCCRM")]
    public partial class SECURITY_PROFL_FUNC_LOG
    {
        public System.Decimal? NEW_SECURITY_PROFL_FUNC_ID { get; set; }
        public System.Decimal? NEW_SECURITY_PROFILE_ID { get; set; }
        public System.Decimal? NEW_SECURITY_FUNCTION_ID { get; set; }
        public System.String NEW_CUSTOMER_TYPE { get; set; }
        public System.String NEW_CREATE_USERID { get; set; }
        public System.DateTime? NEW_CREATE_DATE { get; set; }
        public System.String NEW_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? NEW_LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? NEW_PLATFORM_ID { get; set; }
        public System.Decimal? OLD_SECURITY_PROFL_FUNC_ID { get; set; }
        public System.Decimal? OLD_SECURITY_PROFILE_ID { get; set; }
        public System.Decimal? OLD_SECURITY_FUNCTION_ID { get; set; }
        public System.String OLD_CUSTOMER_TYPE { get; set; }
        public System.String OLD_CREATE_USERID { get; set; }
        public System.DateTime? OLD_CREATE_DATE { get; set; }
        public System.String OLD_LAST_MODIFIED_USERID { get; set; }
        public System.DateTime? OLD_LAST_MODIFIED_DATE { get; set; }
        public System.Decimal? OLD_PLATFORM_ID { get; set; }
        public System.String OS_USER { get; set; }
        public System.String OPERATION { get; set; }
        public System.DateTime? OPERATION_DATE { get; set; }
        public System.Decimal? LOG_ID { get; set; }
        public System.String NEW_GOVERNMENT_TYPE { get; set; }
        public System.String OLD_GOVERNMENT_TYPE { get; set; }
    }
    [Table("SECURITY_PROFL_FUNC_PROD", Schema = "WNCCRM")]
    public partial class SECURITY_PROFL_FUNC_PROD
    {
        public System.String SECURITY_PROFILE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String NAME { get; set; }
    }
    [Table("SEGMENT_INFO_RESP", Schema = "WNCCRM")]
    public partial class SEGMENT_INFO_RESP
    {
        public System.Decimal? INFO_ID { get; set; }
        public System.String ORDER_ID { get; set; }
        public System.String SEGMENT_TN { get; set; }
        public System.String TN_ACTION { get; set; }
    }
    [Table("SERV_TYPE_MAPPING", Schema = "WNCCRM")]
    public partial class SERV_TYPE_MAPPING
    {
        public System.Decimal AUID { get; set; }
        public System.String ST_SERVICE_NAME { get; set; }
        public System.Decimal SFAM_SERVICE_ID { get; set; }
        public System.Decimal TICKET_SERVICE_FAMILY_ID { get; set; }
        public System.Decimal TICKET_SERVICE_TYPE_ID { get; set; }
        public System.Decimal? DASHBOARD_REGION_SPEC_ID { get; set; }
    }
    [Table("SERVICE_ADDRESS_DLY", Schema = "WNCCRM")]
    public partial class SERVICE_ADDRESS_DLY
    {
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_MOVE_TO_ADDRESS { get; set; }
        public System.String ADDRESS_TYPE { get; set; }
        [Key]
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String ZIP_CODE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String CITY { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String STATE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String IS_VALIDATED { get; set; }
        public System.String IS_OVERRIDDEN { get; set; }
        public System.String IS_NEW_CONSTRUCTION { get; set; }
        public System.String NPA_NXX { get; set; }
        public System.String IS_OFFNET { get; set; }
        public System.String IS_INCORPORATED { get; set; }
    }
    [Table("SERVICE_ADDRESS_UPDT_DLY", Schema = "WNCCRM")]
    public partial class SERVICE_ADDRESS_UPDT_DLY
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_MOVE_TO_ADDRESS { get; set; }
        public System.String ADDRESS_TYPE { get; set; }
        public System.String CUST_CAMS_ID { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String CITY_NAME { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String ZIP_CODE { get; set; }
        public System.String STATE { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String IS_VALIDATED { get; set; }
        public System.String IS_OVERRIDDEN { get; set; }
        public System.String IS_NEW_CONSTRUCTION { get; set; }
        public System.String NPA_NXX { get; set; }
        public System.String IS_OFFNET { get; set; }
        public System.String IS_INCORPORATED { get; set; }
        public System.String ADDR_ID { get; set; }
        public System.String ADDR_LINE1 { get; set; }
        public System.String ADDR_LINE2 { get; set; }
        public System.String ADDR_LINE3 { get; set; }
        public System.String ADDR_LINE4 { get; set; }
        public System.String ADDR_LINE5 { get; set; }
        public System.String WINNING_SELECTION { get; set; }
    }
    [Table("SERVICE_ADMIN_STATE_LKUP", Schema = "WNCCRM")]
    public partial class SERVICE_ADMIN_STATE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SERVICE_ITEM", Schema = "WNCCRM")]
    public partial class SERVICE_ITEM
    {
        [Key]
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String ADMIN_STATE { get; set; }
        public System.String EXTERNAL_NAME { get; set; }
        public System.String EXTERNAL_CODE { get; set; }
        public System.String EXTERNAL_OBJECT_ID { get; set; }
        public System.Decimal BUS_SYSTEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
    }
    [Table("SERVICE_ITEM_CUST_ACCT", Schema = "WNCCRM")]
    public partial class SERVICE_ITEM_CUST_ACCT
    {
        [Key]
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        [Key]
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
    }
    [Table("SERVICE_ITEM_ID_STG", Schema = "WNCCRM")]
    public partial class SERVICE_ITEM_ID_STG
    {
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
    }
    [Table("SERVICE_ITEM_REL", Schema = "WNCCRM")]
    public partial class SERVICE_ITEM_REL
    {
        [Key]
        public System.Decimal PARENT_SERVICE_ITEM_ID { get; set; }
        [Key]
        public System.Decimal CHILD_SERVICE_ITEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SERVICE_SPEC", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC
    {
        [Key]
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_CIRCUIT_SERVICE { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("SERVICE_SPEC_03_28", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_03_28
    {
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_CIRCUIT_SERVICE { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("SERVICE_SPEC_04_08", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_04_08
    {
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_CIRCUIT_SERVICE { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("SERVICE_SPEC_FIELD", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_FIELD
    {
        [Key]
        public System.Decimal SERVICE_SPEC_FIELD_ID { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String FIELD_LABEL { get; set; }
        public System.String FIELD_VALUE { get; set; }
        public System.String OPERATOR { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("SERVICE_SPEC_REL", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_REL
    {
        [Key]
        public System.Decimal SERVICE_SPEC_REL_ID { get; set; }
        public System.Decimal PARENT_SERVICE_SPEC_ID { get; set; }
        public System.Decimal CHILD_SERVICE_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CUST_TYPE { get; set; }
    }
    [Table("SERVICE_SPEC_REL_03_28", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_REL_03_28
    {
        public System.Decimal? SERVICE_SPEC_REL_ID { get; set; }
        public System.Decimal PARENT_SERVICE_SPEC_ID { get; set; }
        public System.Decimal CHILD_SERVICE_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CUST_TYPE { get; set; }
    }
    [Table("SERVICE_SPEC_REL_04_08", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_REL_04_08
    {
        public System.Decimal? SERVICE_SPEC_REL_ID { get; set; }
        public System.Decimal PARENT_SERVICE_SPEC_ID { get; set; }
        public System.Decimal CHILD_SERVICE_SPEC_ID { get; set; }
        public System.Decimal SERVICE_SPEC_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CUST_TYPE { get; set; }
    }
    [Table("SERVICE_SPEC_REL_SPEC", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_REL_SPEC
    {
        [Key]
        public System.Decimal SERVICE_SPEC_REL_SPEC_ID { get; set; }
        public System.String PARENT_SERVICE_SPEC_TYPE { get; set; }
        public System.String CHILD_SERVICE_SPEC_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("SERVICE_SPEC_STG", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_STG
    {
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.Decimal? SPEED_LOW_DOWN { get; set; }
        public System.Decimal? SPEED_LOW_UP { get; set; }
        public System.String CODE { get; set; }
        public System.String IS_CIRCUIT_SERVICE { get; set; }
        public System.String SERVICE_TYPE_NAME { get; set; }
        public System.String TICKET_SERVICE_TYPE { get; set; }
        public System.String TICKET_SERVICE_FAMILY { get; set; }
        public System.String PLATFORM { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String CUST_TYPE { get; set; }
    }
    [Table("SERVICE_SPEC_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class SERVICE_SPEC_TYPE_LKUP
    {
        [Key]
        public System.String VALUE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SERVICE_TYPE_CHIPSET", Schema = "WNCCRM")]
    public partial class SERVICE_TYPE_CHIPSET
    {
        public System.String CHIPSET { get; set; }
        public System.String SERVICE_TYPE { get; set; }
    }
    [Table("SERVICES", Schema = "WNCCRM")]
    public partial class SERVICES
    {
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CLASS { get; set; }
    }
    [Table("SETTING", Schema = "WNCCRM")]
    public partial class SETTING
    {
        [Key]
        public System.Decimal SETTING_ID { get; set; }
        public System.Decimal? SETTING_SPEC_ID { get; set; }
        public System.Decimal? SETTING_TYPE_LKUP_ID { get; set; }
        public System.Decimal? SEQUENCE { get; set; }
        public System.Decimal? USER_OID { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
        public System.Decimal? PERSONA_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String VALUE { get; set; }
    }
    [Table("SETTING_SPEC", Schema = "WNCCRM")]
    public partial class SETTING_SPEC
    {
        [Key]
        public System.Decimal SETTING_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal? MIN_CARDINALITY { get; set; }
        public System.Decimal? MAX_CARDINALITY { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_SEQUENCED { get; set; }
        public System.String IS_USER_SETTING { get; set; }
        public System.String IS_PERSONA_SETTING { get; set; }
        public System.String IS_SYSTEM_SETTING { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SETTING_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class SETTING_TYPE_LKUP
    {
        [Key]
        public System.Decimal SETTING_TYPE_LKUP_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SF_BULKUPDATE_LOG", Schema = "WNCCRM")]
    public partial class SF_BULKUPDATE_LOG
    {
        public System.String JOBID { get; set; }
        public System.String RESPONSE { get; set; }
        public System.DateTime? CREATEDDATE { get; set; }
        public System.DateTime? UPDATEDATE { get; set; }
    }
    [Table("SOURCE_FIN_LOC_ATTR", Schema = "WNCCRM")]
    public partial class SOURCE_FIN_LOC_ATTR
    {
        public System.String GLOBAL_ACCOUNT_ID { get; set; }
        public System.DateTime? CONTRACT_SIGN_DATE { get; set; }
        public System.DateTime? CONTRACT_START_DATE { get; set; }
        public System.DateTime? CONTRACT_END_DATE { get; set; }
        public System.String TERM { get; set; }
        public System.String AUTO_RENEW { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("SOURCE_SYSTEM_LKUP", Schema = "WNCCRM")]
    public partial class SOURCE_SYSTEM_LKUP
    {
        [Key]
        public System.Decimal SOURCE_SYSTEM_LKUP_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? TIMEOUTVAL { get; set; }
        public System.Decimal? IVRPREFETCH_TIMEOUTVAL { get; set; }
    }
    [Table("SPF_T1", Schema = "WNCCRM")]
    public partial class SPF_T1
    {
        public System.String SECURITY_PROFILE { get; set; }
        public System.String SECURITY_FUNCTION { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String PLATFORM { get; set; }
    }
    [Table("STG_PV_ACCT_CD", Schema = "WNCCRM")]
    public partial class STG_PV_ACCT_CD
    {
        public System.String ACCT_CD { get; set; }
        public System.String ACCOUNTT_CD_DESC { get; set; }
        public System.String PRNT_ACCT_CD { get; set; }
        public System.String PRNT_ACCT_DESC { get; set; }
        [Key]
        public System.Decimal STG_PV_ACCT_CD_ID { get; set; }
    }
    [Table("STG_PV_COMPANY", Schema = "WNCCRM")]
    public partial class STG_PV_COMPANY
    {
        public System.String COMPANY_CD { get; set; }
        public System.String COMPANY { get; set; }
        public System.String PRNT_COMPANY_CD { get; set; }
        public System.String PRNT_COMPANY { get; set; }
        [Key]
        public System.Decimal STG_PV_COMPANY_ID { get; set; }
    }
    [Table("STG_PV_DEPT", Schema = "WNCCRM")]
    public partial class STG_PV_DEPT
    {
        public System.String DEPD_CD { get; set; }
        public System.String DEPARTMENT { get; set; }
        public System.String PRNT_DEPT_CD { get; set; }
        public System.String PRNT_DEPT { get; set; }
        [Key]
        public System.Decimal STG_PV_DEPT_ID { get; set; }
    }
    [Table("STG_PV_MARKET", Schema = "WNCCRM")]
    public partial class STG_PV_MARKET
    {
        public System.String MARKET_CD { get; set; }
        public System.String MARKET { get; set; }
        public System.String PRNT_MARKET_CD { get; set; }
        public System.String PRNT_MARKET { get; set; }
        [Key]
        public System.Decimal STG_PV_MARKET_ID { get; set; }
    }
    [Table("STG_PV_MNA", Schema = "WNCCRM")]
    public partial class STG_PV_MNA
    {
        public System.String MNA_CD { get; set; }
        public System.String CHILD_MNA { get; set; }
        public System.String PRNT_MNA_CD { get; set; }
        public System.String PRNT_MNA { get; set; }
        [Key]
        public System.Decimal STG_PV_MNA_ID { get; set; }
    }
    [Table("SUB_TAX_PLN_EXMP", Schema = "WNCCRM")]
    public partial class SUB_TAX_PLN_EXMP
    {
        public System.Decimal? SUB_TAX_PLN_TYP_ID { get; set; }
        public System.Decimal? TAX_TYP { get; set; }
        public System.DateTime? STRT_DT { get; set; }
        public System.DateTime? END_DT { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? MODIFIED_DATE { get; set; }
        public System.String MODIFIED_USER { get; set; }
        public System.DateTime? PARTITION_DATE { get; set; }
        public System.String EXMP_GEO_CD { get; set; }
    }
    [Table("SUB_TAX_PLN_TYP", Schema = "WNCCRM")]
    public partial class SUB_TAX_PLN_TYP
    {
        public System.Decimal? SUB_TAX_PLN_TYP_ID { get; set; }
        public System.Decimal? SUB_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? MODIFIED_DATE { get; set; }
        public System.String MODIFIED_USER { get; set; }
        public System.DateTime? PARTITION_DATE { get; set; }
    }
    [Table("SUPPORT_CALL", Schema = "WNCCRM")]
    public partial class SUPPORT_CALL
    {
        [Key]
        public System.Decimal SUPPORT_CALL_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String ACTION { get; set; }
        public System.Decimal? CALL_REASON_ID { get; set; }
        public System.Decimal? GROUP_TRANSFERRED_TO { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CONTACT_SOURCE { get; set; }
    }
    [Table("SUPPORT_FLAGS_UPLOAD_LOG", Schema = "WNCCRM")]
    public partial class SUPPORT_FLAGS_UPLOAD_LOG
    {
        [Key]
        public System.Decimal UPLOAD_LOG_ID { get; set; }
        public System.DateTime LOG_CREATED_DATE { get; set; }
        public System.String LOG_CREATED_USER { get; set; }
        public System.String XML_DATA { get; set; }
    }
    [Table("SVC_AVAIL_REQ", Schema = "WNCCRM")]
    public partial class SVC_AVAIL_REQ
    {
        public System.Decimal? SVC_AVAIL_REQ_ID { get; set; }
        public System.String COUNTRYCODE { get; set; }
        public System.String STATECODE { get; set; }
        public System.String RATECENTER { get; set; }
        public System.String SERVINGWIRECENTER { get; set; }
        public System.String NPA_NXX { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        [Key]
        public System.Decimal SVC_AVAIL_REQ_SEQ_ID { get; set; }
    }
    [Table("SWAGGER_INSTANCES", Schema = "WNCCRM")]
    public partial class SWAGGER_INSTANCES
    {
        [Key]
        public System.String NAMESPACE { get; set; }
        [Key]
        public System.String NAME { get; set; }
        public System.String URL { get; set; }
    }
    [Table("T_ADO194730_ACCT_TN_MSNG_SVC", Schema = "WNCCRM")]
    public partial class T_ADO194730_ACCT_TN_MSNG_SVC
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Int32 CUST_ACCT_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String STATUS { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
    }
    [Table("T_CTIB_DATA", Schema = "WNCCRM")]
    public partial class T_CTIB_DATA
    {
        public System.Decimal? BENT_CAMS_ID { get; set; }
        public System.String THREE_MONTH_TOLL_AVERAGE { get; set; }
    }
    [Table("T_ENABLED_JOBS_VOX_MIGRATION", Schema = "WNCCRM")]
    public partial class T_ENABLED_JOBS_VOX_MIGRATION
    {
        public System.String OWNER { get; set; }
        public System.String JOB_NAME { get; set; }
        public System.String JOB_TYPE { get; set; }
        public System.String JOB_ACTION { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.String REPEAT_INTERVAL { get; set; }
        public System.String ENABLED { get; set; }
        public System.String STATE { get; set; }
        public System.DateTime? LAST_START_DATE { get; set; }
        public System.DateTime? NEXT_RUN_DATE { get; set; }
        public System.TimeSpan? LAST_RUN_DURATION { get; set; }
        public System.String COMMENTS { get; set; }
        public System.DateTime? ENABLED_DATE { get; set; }
        public System.DateTime? DISABLED_DATE { get; set; }
        public System.String DISABLE_STMNT { get; set; }
        public System.String ENABLE_STMNT { get; set; }
    }
    [Table("T_LOAD_UAT_SERVICE_DATA1_OT", Schema = "WNCCRM")]
    public partial class T_LOAD_UAT_SERVICE_DATA1_OT
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal TEL_NUM_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String CODE { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.DateTime? START_DATE { get; set; }
        public System.DateTime? END_DATE { get; set; }
        public System.Decimal? SERVICE_ITEM_ID { get; set; }
        public System.DateTime? MIN_START_DATE { get; set; }
        public System.DateTime? MAX_END_DATE { get; set; }
    }
    [Table("T_PRODUCT_SERVICE_SPEC", Schema = "WNCCRM")]
    public partial class T_PRODUCT_SERVICE_SPEC
    {
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.String SPEED_HIGH_DOWN { get; set; }
        public System.String SPEED_HIGH_UP { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String ST_SERVICE_NAME { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ST_SERVICE_TYPE { get; set; }
    }
    [Table("TAB_REC_CNT", Schema = "WNCCRM")]
    public partial class TAB_REC_CNT
    {
        public System.String ONWER_NAME { get; set; }
        public System.String TABLE_NAME { get; set; }
        public System.Decimal? NUM_ROWS_USER_TAB_STATS { get; set; }
        public System.Decimal? BLOCKS_USER_TAB_STATS { get; set; }
        public System.DateTime? LAST_ANALYZED_USER_TAB_STATS { get; set; }
        public System.String STALE_STATS_USER_TAB_STATS { get; set; }
        public System.Decimal? NUM_ROWS_TAB_ACTUAL { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("TAX_TYP", Schema = "WNCCRM")]
    public partial class TAX_TYP
    {
        [Column("TAX_TYP")]
        public System.Decimal? TAX_TYP_val { get; set; }
        public System.String TAX_NM { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? MODIFIED_DATE { get; set; }
        public System.String MODIFIED_USER { get; set; }
        public System.DateTime? PARTITION_DATE { get; set; }
    }
    [Table("TEL_NUM", Schema = "WNCCRM")]
    public partial class TEL_NUM
    {
        [Key]
        public System.Decimal TEL_NUM_ID { get; set; }
        public System.String IS_PORTED_IN { get; set; }
        public System.String IS_PORTED_OUT { get; set; }
        public System.String SERVICE_NAME { get; set; }
        [Column("TEL_NUM")]
        public System.String TEL_NUM_val { get; set; }
        public System.String TEL_NUM_COUNTRY_CODE { get; set; }
        public System.String TEL_NUM_EXTENSION { get; set; }
        public System.String TEL_NUM_TYPE { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String CUST_ACCT_NUMBER { get; set; }
        public System.String TEL_NBR_SUF { get; set; }
    }
    [Table("TEL_NUM_CUST_ACCT", Schema = "WNCCRM")]
    public partial class TEL_NUM_CUST_ACCT
    {
        [Key]
        public System.Decimal TEL_NUM_CUST_ACCT_ID { get; set; }
        public System.String TEL_NUM_CUST_ACCT_ROLE { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? TEL_NUM_ID { get; set; }
        public System.String CREATE_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String STATUS { get; set; }
        public System.DateTime? DISCONNECTED_DATE { get; set; }
    }
    [Table("TEL_NUM_INTERACTIONS", Schema = "WNCCRM")]
    public partial class TEL_NUM_INTERACTIONS
    {
        [Key]
        public System.Decimal TEL_NUM_INTERACTIONS_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.Decimal? FACILITIES_NUMBER { get; set; }
        public System.String NOTES { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? UPDATED_DATE { get; set; }
        public System.String UPDATED_USER { get; set; }
        public System.String IS_SUCCESS { get; set; }
        public System.String STATE_CODE { get; set; }
    }
    [Table("TEL_NUM_INTERACTIONS_CONN", Schema = "WNCCRM")]
    public partial class TEL_NUM_INTERACTIONS_CONN
    {
        [Key]
        public System.Decimal TEL_NUM_INTERACTIONS_CONN_ID { get; set; }
        public System.Decimal TEL_NUM_INTERACTIONS_ID { get; set; }
        public System.Decimal TEL_NUM_SEQUENCE { get; set; }
        public System.String OLDX_CABLE { get; set; }
        public System.String OLDX_PAIR { get; set; }
        public System.String NEWX_CABLE { get; set; }
        public System.String NEWX_PAIR { get; set; }
        public System.String REASON_CODE { get; set; }
        public System.String OLD_TN { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? UPDATED_DATE { get; set; }
        public System.String UPDATED_USER { get; set; }
        public System.String IS_SUCCESS { get; set; }
        public System.String ERROR_CODE { get; set; }
        public System.String NEW_ROUTE_LEAD { get; set; }
        public System.String OLD_ROUTE_LEAD { get; set; }
        public System.String NEW_TERM_NUM { get; set; }
        public System.String OLD_TERM_NUM { get; set; }
    }
    [Table("TEL_NUM_SERVICE", Schema = "WNCCRM")]
    public partial class TEL_NUM_SERVICE
    {
        [Key]
        public System.Decimal TEL_NUM_SERVICE_ID { get; set; }
        public System.Decimal TEL_NUM_ID { get; set; }
        public System.Decimal SERVICE_ITEM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.DateTime? START_DATE { get; set; }
    }
    [Table("TEMP_ASSET_CAMS", Schema = "WNCCRM")]
    public partial class TEMP_ASSET_CAMS
    {
        public System.String ACCOUNT_ID { get; set; }
        public System.String ASSET_NAME { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String ASSET_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String ASSET_ID_C { get; set; }
    }
    [Table("TEMP_ASSET_RC", Schema = "WNCCRM")]
    public partial class TEMP_ASSET_RC
    {
        public System.String ACCOUNT_ID { get; set; }
        public System.String ASSET_NAME { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String ASSET_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String ASSET_ID_C { get; set; }
    }
    [Table("TEMP_BILL_ITEMS_CAMS", Schema = "WNCCRM")]
    public partial class TEMP_BILL_ITEMS_CAMS
    {
        public System.Decimal SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.String DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
    }
    [Table("TEMP_BILL_ITEMS_REVCHAIN", Schema = "WNCCRM")]
    public partial class TEMP_BILL_ITEMS_REVCHAIN
    {
        public System.Int64? SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String ASSET_ID_C { get; set; }
    }
    [Table("TEMP_BILL_ITEMS_REVCHAIN_OLD", Schema = "WNCCRM")]
    public partial class TEMP_BILL_ITEMS_REVCHAIN_OLD
    {
        public System.Int64? SUB_ID { get; set; }
        public System.String SRVC_NM { get; set; }
        public System.String SRVC_CMMT { get; set; }
        public System.String BILLING_FREQUENCY { get; set; }
        public System.String FEAT_BRANDING { get; set; }
        public System.String RTE_PLN_NM { get; set; }
        public System.Decimal? CHARGE_QTY { get; set; }
        public System.Decimal? CHARGE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        public System.Decimal? RECURRING_CHARGE { get; set; }
        public System.String CUSTOMER_ACCOUNT_ID { get; set; }
        public System.String SERVICE_LOCATION_ID { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("TEMP_PRODUCT_COMPONENT", Schema = "WNCCRM")]
    public partial class TEMP_PRODUCT_COMPONENT
    {
        public System.String EXTERNAL_SOURCE_SYSTEM { get; set; }
        public System.String FEATURE_NAME { get; set; }
        public System.String PRODUCT_CATEGORY { get; set; }
        public System.String PRODUCT_CODE { get; set; }
        public System.String PRODUCT_FAMILY { get; set; }
        public System.String REVENUE_CATEGORY { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String PRODUCT_COMP_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("TEMP_WF_BILL_ITEMS_ID", Schema = "WNCCRM")]
    public partial class TEMP_WF_BILL_ITEMS_ID
    {
        public System.String ID { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("TEMP_WF_EXTERNAL_ID", Schema = "WNCCRM")]
    public partial class TEMP_WF_EXTERNAL_ID
    {
        public System.String ID { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("TEMP_WF_EXTERNAL_ID2", Schema = "WNCCRM")]
    public partial class TEMP_WF_EXTERNAL_ID2
    {
        public System.String ID { get; set; }
        public System.String EXTERNAL_ID { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("TEMPLATE", Schema = "WNCCRM")]
    public partial class TEMPLATE
    {
        [Key]
        public System.Decimal TEMPLATE_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.Decimal? CATEGORY_ID { get; set; }
    }
    [Table("TEMPLATE_APPS", Schema = "WNCCRM")]
    public partial class TEMPLATE_APPS
    {
        [Key]
        public System.Decimal TEMPLATE_APP_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String FUNCTION { get; set; }
        public System.String SHORT_DESCRIPTION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String DUPE_CHECK_REQ { get; set; }
        public System.String IS_MULTIPLE_ALLOWED { get; set; }
    }
    [Table("TEMPLATE_FIELD", Schema = "WNCCRM")]
    public partial class TEMPLATE_FIELD
    {
        [Key]
        public System.Decimal TEMPLATE_FIELD_ID { get; set; }
        public System.Decimal TEMPLATE_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String SHORT_DESCRIPTION { get; set; }
        public System.String VALIDATION { get; set; }
        public System.String TYPE { get; set; }
        public System.String CONFIG_REQUIRED { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    }
    [Table("TEST_RESULTS_2", Schema = "WNCCRM")]
    public partial class TEST_RESULTS_2
    {
        public System.String TEST_REQUEST_ID { get; set; }
        public System.String TELEPHONE_NUMBER { get; set; }
        public System.String GW_USED { get; set; }
        public System.String DEVICE_USED { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.String COE { get; set; }
        public System.String TESTING_METHOD { get; set; }
        public System.String DATE_OF_TEST { get; set; }
        public System.String TIME_OF_TEST { get; set; }
        public System.String SEVERITY_MESSAGE { get; set; }
        public System.String SUGGESTED_DISPATCH { get; set; }
        public System.String DC_KOHM_TIP_RING { get; set; }
        public System.String DC_KOHM_TIP_GROUND { get; set; }
        public System.String DC_KOHM_RING_GROUND { get; set; }
        public System.String DC_KOHM_TIP_CROSS { get; set; }
        public System.String DC_KOHM_RING_CROSS { get; set; }
        public System.String AC_KOHM_TIP_RING { get; set; }
        public System.String AC_KOHM_TIP_GROUND { get; set; }
        public System.String AC_KOHM_RING_GROUND { get; set; }
        public System.String DC_VOLTS_TIP_GROUND { get; set; }
        public System.String DC_VOLTS_RING_GROUND { get; set; }
        public System.String AC_VOLTS_TIP_GROUND { get; set; }
        public System.String AC_VOLTS_RING_GROUND { get; set; }
        public System.String CAPACITANCE_TIP_RING { get; set; }
        public System.String CAPACITANCE_TIP_GROUND { get; set; }
        public System.String CAPACITANCE_RING_GROUND { get; set; }
        public System.String INDUCED_AC_TIP_GROUND { get; set; }
        public System.String INDUCED_AC_RING_GROUND { get; set; }
        public System.String NOISE_TO_GROUND { get; set; }
        public System.String METALLIC_NOISE { get; set; }
        public System.String NOISE_BALANCE { get; set; }
        public System.String LINE_LENGTH { get; set; }
        public System.String LINE_LENGTH_UNITS { get; set; }
        public System.String LOAD_0 { get; set; }
        public System.String LENGTH_0 { get; set; }
        public System.String LOAD_1 { get; set; }
        public System.String LENGTH_1 { get; set; }
        public System.String LOAD_2 { get; set; }
        public System.String LENGTH_2 { get; set; }
        public System.String LOAD_3 { get; set; }
        public System.String LENGTH_3 { get; set; }
        public System.String LOAD_4 { get; set; }
        public System.String LENGTH_4 { get; set; }
        public System.String LOAD_5 { get; set; }
        public System.String LENGTH_5 { get; set; }
        public System.String LOAD_6 { get; set; }
        public System.String LENGTH_6 { get; set; }
        public System.String LOAD_7 { get; set; }
        public System.String LENGTH_7 { get; set; }
        public System.String LOAD_8 { get; set; }
        public System.String LENGTH_8 { get; set; }
        public System.String SIGNATURE_MESSAGE { get; set; }
        public System.String INSULATION_SUMMARY_1 { get; set; }
        public System.String INSULATION_SUMMARY_2 { get; set; }
        public System.String INSULATION_SUMMARY_3 { get; set; }
        public System.String INSULATION_SUMMARY_4 { get; set; }
        public System.String TERMINATION_MESSAGE_1 { get; set; }
        public System.String TERMINATION_MESSAGE_2 { get; set; }
        public System.String TERMINATION_MESSAGE_3 { get; set; }
        public System.String TERMINATION_MESSAGE_4 { get; set; }
        public System.String DIALOG_STATUS_MESSAGE { get; set; }
        public System.String RINGER_RING_GROUND { get; set; }
        public System.String RINGER_TIP_GROUND { get; set; }
        public System.String RINGER_TIP_RING { get; set; }
        public System.String LINE_EQUIPMENT_LENGTH { get; set; }
        public System.String DIAL_TONE { get; set; }
        public System.String OWNER { get; set; }
        public System.String REFERENCE_STATUS { get; set; }
        public System.String VER_CODE { get; set; }
        public System.String VER_MESSAGE { get; set; }
        public System.String LC_TST_IND { get; set; }
        public System.String CAPACITANCE_BALANCE { get; set; }
    }
    [Table("TICKET", Schema = "WNCCRM")]
    public partial class TICKET
    {
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String NOTES { get; set; }
        public System.String SUMMARY { get; set; }
        public System.String SERVICE_INFO { get; set; }
        public System.String DISPOSITION { get; set; }
        public System.String EBOND_STATUS { get; set; }
        public System.String IS_REPEAT_REPORT { get; set; }
        public System.DateTime? IMPACT_START { get; set; }
        public System.DateTime? IMPACT_STOP { get; set; }
        public System.DateTime? CURR_SLA_DATE { get; set; }
        public System.String CURR_SLA_TIME { get; set; }
        public System.DateTime? ORIGINAL_COMMITMENT_DATE { get; set; }
        public System.String VENDOR_TICKET_NUMBER { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
        public System.String EMPLOYEE_NAME { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER1 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER2 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER3 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER1 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER2 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER3 { get; set; }
        public System.String RESOLUTION { get; set; }
        public System.String REGULATED_TYPE { get; set; }
        public System.String ASSIGNED_GROUP { get; set; }
        public System.String ASSIGNEE { get; set; }
        public System.String DISPATCH_PRIORITY { get; set; }
        public System.String DISPATCH_TIME_SLOT { get; set; }
        public System.DateTime? DISPATCH_TIME_SLOT_DATE { get; set; }
        public System.String DISPATCH_STATUS { get; set; }
        public System.String DISPATCH_WORK_ZONE { get; set; }
        public System.String DISPATCH_SKILL { get; set; }
        public System.DateTime? ESCALATED_DATE_TIME { get; set; }
        public System.String ESCALATION_LEVEL { get; set; }
        public System.String ESCALATED_TO { get; set; }
        public System.String ESCALATION_NOTES { get; set; }
        public System.String ASSOCIATE_TO_CC { get; set; }
        public System.String OVERRIDE_CC_ASSOCIATION { get; set; }
        public System.Decimal? GLOBAL_ACCOUNTID { get; set; }
        public System.String ACCOUNT_NUMBER { get; set; }
        public System.String CUSTOMER_NAME { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String PLATFORM { get; set; }
        public System.String BILLING_SYSTEM { get; set; }
        public System.String PLATFORM_BILLING_SYSTEM { get; set; }
        public System.String ACNA_CODE { get; set; }
        public System.String ACNA_NAME { get; set; }
        public System.String PROVISIONING_SUBSCRIBER_ID { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String GOVERNMENT_TYPE { get; set; }
        public System.String MARKET_TYPE { get; set; }
        public System.String SUBMARKET_TYPE { get; set; }
        public System.String INVOICE_BRANDING { get; set; }
        public System.String STATURE_IS_CRITICAL { get; set; }
        public System.String STATURE_IS_ELITE { get; set; }
        public System.String STATURE_IS_FEDERAL { get; set; }
        public System.String STATURE_IS_MAJOR { get; set; }
        public System.String STATURE_IS_NATIONAL { get; set; }
        public System.String PRMY_CONTACT_FIRST_NAME { get; set; }
        public System.String PRMY_CONTACT_LAST_NAME { get; set; }
        public System.String PRMY_CONTACT_EMAIL { get; set; }
        public System.String PRMY_CONTACT_PHONE_TYPE { get; set; }
        public System.String PRMY_CONTACT_PHONE_NUMBER { get; set; }
        public System.String PRMY_CONTACT_EXT { get; set; }
        public System.String LOCAL_CONTACT_FIRST_NAME { get; set; }
        public System.String LOCAL_CONTACT_LAST_NAME { get; set; }
        public System.String LOCAL_CONTACT_EMAIL { get; set; }
        public System.String LOCAL_CONTACT_PHONE_TYPE { get; set; }
        public System.String LOCAL_CONTACT_PH_NUMBER { get; set; }
        public System.String LOCAL_CONTACT_EXT { get; set; }
        public System.String CONTACT_FIRST_NAME { get; set; }
        public System.String CONTACT_LAST_NAME { get; set; }
        public System.String CONTACT_EMAIL { get; set; }
        public System.String CONTACT_PHONE_TYPE { get; set; }
        public System.String CONTACT_PHONE_NUMBER { get; set; }
        public System.String CONTACT_EXT { get; set; }
        public System.String CONTACT_TYPE { get; set; }
        public System.String ADDRESS_1 { get; set; }
        public System.String ADDRESS_2 { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String BUCKET { get; set; }
        public System.String ACCESS_NOTES { get; set; }
        public System.String CLLI { get; set; }
        public System.String GRADE { get; set; }
        public System.String MIROR_INSTANCE { get; set; }
        public System.String SUN_ACCESS_HOURS_START { get; set; }
        public System.String SUN_ACCESS_HOURS_END { get; set; }
        public System.String MON_ACCESS_HOURS_START { get; set; }
        public System.String MON_ACCESS_HOURS_END { get; set; }
        public System.String TUE_ACCESS_HOURS_START { get; set; }
        public System.String TUE_ACCESS_HOURS_END { get; set; }
        public System.String WED_ACCESS_HOURS_START { get; set; }
        public System.String WED_ACCESS_HOURS_END { get; set; }
        public System.String THU_ACCESS_HOURS_START { get; set; }
        public System.String THU_ACCESS_HOURS_END { get; set; }
        public System.String FRI_ACCESS_HOURS_START { get; set; }
        public System.String FRI_ACCESS_HOURS_END { get; set; }
        public System.String SAT_ACCESS_HOURS_START { get; set; }
        public System.String SAT_ACCESS_HOURS_END { get; set; }
        public System.String INTRUSIVE_TEST_START { get; set; }
        public System.String INTRUSIVE_TEST_END { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String SERVICE_PHONE_NUMBER { get; set; }
        public System.String SERVICE_PHONE_EXT { get; set; }
        public System.String ECCKT_TYPE { get; set; }
        public System.String CIRCUIT_ID { get; set; }
        public System.String CIRCUIT_SERIAL_NUMBER { get; set; }
        public System.String LEC_CIRCUIT { get; set; }
        public System.String DESIGN_ID { get; set; }
        public System.DateTime? INSERVICE_DATE { get; set; }
        public System.String ACTUAL_COMPLETION_DATE { get; set; }
        public System.DateTime? DISCONNECT_DATE { get; set; }
        public System.String DISCONNECT_REASON { get; set; }
        public System.String TSP { get; set; }
        public System.String TSP_AUTHORIZATION_CODE { get; set; }
        public System.String OTHER_CARRIER { get; set; }
        public System.String INVENTORY_SYSTEM { get; set; }
        public System.String PLATFORM_PROVISIONING_SYSTEM { get; set; }
        public System.String ALL_DEVICES { get; set; }
        public System.String INTERNET_USERNAME { get; set; }
        public System.String INTERNET_PASSWORD { get; set; }
        public System.String DEV_SNAP_MANUFACTURER { get; set; }
        public System.String DEV_SNAP_MODEL { get; set; }
        public System.String DEV_SNAP_SERIAL { get; set; }
        public System.String DEV_SNAP_FIRMWARE_VERSION { get; set; }
        public System.String DEV_SNAP_DEVICE_STATUS { get; set; }
        public System.String DEV_SNAP_MACADDRESS { get; set; }
        public System.String DEV_SNAP_IPADDRESS_V4 { get; set; }
        public System.String DEV_SNAP_IPADDRESS_V6 { get; set; }
        public System.String DEV_SNAP_VPI_VCI { get; set; }
        public System.String DEV_SNAP_USERNAME { get; set; }
        public System.String DEV_SNAP_ENCAPSULATION { get; set; }
        public System.String DEV_SNAP_IS_WALLED_GARDEN { get; set; }
        public System.String DEV_SNAP_IS_ISPP_REGISTERED { get; set; }
        public System.String DEV_SNAP_SETTING_AUTH { get; set; }
        public System.String DEV_SNAP_LAST_KNOWN_IPADD_V4 { get; set; }
        public System.String DEV_SNAP_LAST_KNOWN_IPADD_V6 { get; set; }
        public System.String DEV_SNAP_ISTHIRDPARTY_BYPASS { get; set; }
        public System.DateTime? DEV_SNAP_LAST_KNOWN_CONT_DATE { get; set; }
        public System.DateTime? DEV_SNAP_LAST_KNOWN_RESET_DT { get; set; }
        public System.DateTime? DEV_SNAP_LAST_KNOWN_ACT { get; set; }
        public System.String DEV_SNAP_IS_PING_SUCCESSFUL { get; set; }
        public System.String DEV_SNAP_OAM_RESULT { get; set; }
        public System.DateTime? DEV_SNAP_CREATED_DATE { get; set; }
        public System.String DEV_SNAP_CREATED_USER { get; set; }
        public System.String BRAS_SNAP_ATM_CELLS_DOWN { get; set; }
        public System.String BRAS_SNAP_ATM_CELLS_UP { get; set; }
        public System.DateTime? BRAS_SNAP_CREATED_DATE { get; set; }
        public System.String BRAS_SNAP_CREATED_USER { get; set; }
        public System.String TRAIN_IS_SUCCESSFUL { get; set; }
        public System.String TRAIN_ADMIN_STATE { get; set; }
        public System.String TRAIN_SPEED_DOWN { get; set; }
        public System.String TRAIN_SPEED_UP { get; set; }
        public System.String TRAIN_ATTENUATION_DOWN { get; set; }
        public System.String TRAIN_ATTENTION_UP { get; set; }
        public System.String TRAIN_SIGNAL_NOISE_DOWN { get; set; }
        public System.String TRAIN_SIGNAL_NOISE_UP { get; set; }
        public System.String TRAIN_CELLS_DOWN { get; set; }
        public System.String TRAIN_CELLS_UP { get; set; }
        public System.DateTime? TRAIN_CREATED_DATE { get; set; }
        public System.String TRAIN_CREATED_USER { get; set; }
        public System.String DEV_REPL_MANUFACTURER { get; set; }
        public System.String DEV_REPL_MODEL { get; set; }
        public System.String DEV_REPL_SERIAL { get; set; }
        public System.String DEV_REPL_FIRMWARE_VERSION { get; set; }
        public System.String DEV_REPL_MAC_ADDRESS { get; set; }
        public System.String DEV_REPL_REPLACEMENT_COVERAGE { get; set; }
        public System.String DEV_REPL_IS_BILLABLE { get; set; }
        public System.String DEV_REPL_IS_CUSTOMER_PICKUP { get; set; }
        public System.String DEV_REPL_IS_RETURN_TAG_SENT { get; set; }
        public System.DateTime? DEV_REPL_EST_SHIP_DATE { get; set; }
        public System.String DEV_REPL_SHIP_TO_ATTN { get; set; }
        public System.String DEV_REPL_SHIP_TO_RECIPIENT { get; set; }
        public System.String DEV_REPL_SHIP_TO_ADD_LINE1 { get; set; }
        public System.String DEV_REPL_SHIP_TO_ADD_LINE2 { get; set; }
        public System.String DEV_REPL_SHIP_TO_CITY { get; set; }
        public System.String DEV_REPL_SHIP_TO_STATE_CODE { get; set; }
        public System.String DEV_REPL_SHIP_TO_POSTAL_CODE { get; set; }
        public System.String COE { get; set; }
        public System.String POWER_VERIFIED { get; set; }
        public System.String SITE_NAME { get; set; }
        public System.String SERVICE_DESCRIPTION { get; set; }
        public System.String CIRCUIT_ALIAS { get; set; }
        public System.String AUTHORIZATION { get; set; }
        public System.String SERVING_WIRE_CENTER { get; set; }
        public System.DateTime? APPOINTMENT_SLOT { get; set; }
        public System.String PRMY_CONTACT_PHONE_TYPE_2 { get; set; }
        public System.String PRMY_CONTACT_PHONE_NUMBER_2 { get; set; }
        public System.String PRMY_CONTACT_EXT_2 { get; set; }
        public System.String LOCAL_CONTACT_PHONE_TYPE_2 { get; set; }
        public System.String LOCAL_CONTACT_PH_NUMBER_2 { get; set; }
        public System.String LOCAL_CONTACT_EXT_2 { get; set; }
        public System.String CONTACT_PHONE_TYPE_2 { get; set; }
        public System.String CONTACT_PHONE_NUMBER_2 { get; set; }
        public System.String CONTACT_EXT_2 { get; set; }
        public System.String COUNTY { get; set; }
        public System.String MISSED_APPT_CODE { get; set; }
        public System.String CUSTOMER_TICKET_NUMBER { get; set; }
        public System.String IS_RELATED_TO_MAINT_EVENT { get; set; }
        public System.String MAINT_EVENT_NUMBER { get; set; }
        public System.String DEVICE_NAME { get; set; }
        public System.String TRAIN_PORT_ADDRESS { get; set; }
        public System.String TRAIN2_PORT_ADDRESS { get; set; }
        public System.String TRAIN2_IS_SUCCESSFUL { get; set; }
        public System.String TRAIN2_ADMIN_STATE { get; set; }
        public System.String TRAIN2_SPEED_DOWN { get; set; }
        public System.String TRAIN2_SPEED_UP { get; set; }
        public System.String TRAIN2_ATTENUATION_DOWN { get; set; }
        public System.String TRAIN2_ATTENUATION_UP { get; set; }
        public System.String TRAIN2_SIGNAL_NOISE_DOWN { get; set; }
        public System.String TRAIN2_SIGNAL_NOISE_UP { get; set; }
        public System.String TRAIN2_CELLS_DOWN { get; set; }
        public System.String TRAIN2_CELLS_UP { get; set; }
        public System.DateTime? TRAIN2_CREATED_DATE { get; set; }
        public System.String TRAIN2_CREATED_USER { get; set; }
        public System.String ACTION_TAKEN { get; set; }
        public System.String DEV_REPL_REASON { get; set; }
        public System.String DEV_REPL_CHARGE_FRQ { get; set; }
        public System.Decimal? DEV_REPL_MRC_CHARGE { get; set; }
        public System.Decimal? DEV_REPL_NRC_CHARGE { get; set; }
        public System.String DEV_REPL_DEV_TYPE { get; set; }
        public System.String DEV_REPL_ADD_TYPE { get; set; }
        public System.String CARRIER_TYPE { get; set; }
        public System.String DEVICE_TYPE { get; set; }
        public System.String ELEMENT { get; set; }
        public System.Decimal? CB_BIP_CALL_DEFLECTOR { get; set; }
        public System.Decimal? CB_BIP_MANAGEMENT { get; set; }
        public System.String CURRENT_SLA_TIME { get; set; }
        public System.String CURRENT_SLA_DATE { get; set; }
        public System.String DETAILED_DESCRIPTION { get; set; }
        public System.String TICKET_REASON { get; set; }
        public System.DateTime? REPORTED_DATE { get; set; }
        public System.DateTime? CLOSED_DATE { get; set; }
        public System.Decimal? OUT_REL_TO { get; set; }
        public System.DateTime? OUT_REL_CREATE_DATE { get; set; }
        public System.String OUT_REL_CUST_NAME { get; set; }
        public System.Decimal? OUT_REL_CUST_TYPE { get; set; }
        public System.String OUT_REL_REQ_SUMMARY { get; set; }
        public System.Decimal? OUT_REL_STATUS { get; set; }
        public System.Decimal? OUT_REL_REQ_TYPE { get; set; }
        public System.String WR_TASK_NAME { get; set; }
        public System.DateTime? WR_NEXT_DUE_DATE { get; set; }
        public System.String WR_APPT_NUMBER { get; set; }
        public System.String WR_RECEIVED_FROM { get; set; }
        public System.String WR_WORK_ORDER_NUMBER { get; set; }
        public System.String WR_ASSOCAITE_NUMBER { get; set; }
        public System.String WR_WORK_REQUIRED { get; set; }
        public System.String WR_PREFERRED_TECH { get; set; }
        public System.String WR_EXTERNAL_ID { get; set; }
        public System.String WR_LENGTH { get; set; }
        public System.String WR_WORK_TYPE { get; set; }
        public System.DateTime? WR_START_DATE { get; set; }
        public System.String WR_START_TIME { get; set; }
        public System.String WR_SLA_START { get; set; }
        public System.String WR_SLA_END { get; set; }
        public System.String POTS_CC_NO { get; set; }
        public System.Decimal? POTS_CC_TYPE { get; set; }
        public System.String POTS_CC_STATE { get; set; }
        public System.String POTS_CC_NODE_ID { get; set; }
        public System.String POTS_CC_WIRE_CENTER { get; set; }
        public System.DateTime? POTS_CC_EST_CLEARED_DATE { get; set; }
        public System.String POTS_CC_CABLE { get; set; }
        public System.String POTS_CC_FROM_PAIR { get; set; }
        public System.String POTS_CC_TO_PAIR { get; set; }
        public System.String POTS_CC_LINE_EQ_COE { get; set; }
        public System.String POTS_CC_LINE_EQ_FROM_BAY { get; set; }
        public System.String POTS_CC_LINE_EQ_TO_BAY { get; set; }
        public System.String POTS_CC_LINE_EQ_FROM_SHELF { get; set; }
        public System.String POTS_CC_LINE_EQ_TO_SHELF { get; set; }
        public System.String POTS_CC_LINE_EQ_FROM_CIRCUIT { get; set; }
        public System.String POTS_CC_LINE_EQ_TO_CIRCUIT { get; set; }
        public System.String POTS_CC_LINE_EQ_FROM_LINE { get; set; }
        public System.String POTS_CC_LINE_EQ_TO_LINE { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.String NID_CHECKED { get; set; }
        public System.String PPR_CIPC { get; set; }
        public System.String CC_LEAD_INCIDENT { get; set; }
        public System.String EXAMPLE_NUMBER { get; set; }
        public System.String SYMPTOM { get; set; }
        public System.String ISSUE { get; set; }
        public System.String RATE_CODE { get; set; }
        public System.String DSL_IP_ENCAPSULATION { get; set; }
        public System.String IP_OAM_PING_PERCENTAGE { get; set; }
        public System.String DSLAM_PORT_MODE { get; set; }
        public System.String DSL_PORT_ADMIN_STATE { get; set; }
        public System.String END_USER_DEVICE_PERCENTAGE { get; set; }
        public System.String DSL_ERROR { get; set; }
        public System.String DSLAM_TRAIN_ERROR_MESSAGE { get; set; }
        public System.String DSL_TRAINED { get; set; }
        public System.String DSL_IP_ADDRESS { get; set; }
        public System.String TRAIN_PROVISIONED_UP { get; set; }
        public System.String TRAIN_PROVISIONED_DOWN { get; set; }
        public System.String RB_BIP_CUSTOMER_IMPACTING__C { get; set; }
        public System.String RED_FLAG_NOTES { get; set; }
        public System.String UNIFIED_CODE_VIEW { get; set; }
        public System.String SERVICE_ORDER_NUMBER { get; set; }
        public System.String PRMY_REQUEST_ID { get; set; }
        public System.String LOCAL_REQUEST_ID { get; set; }
        public System.String CONTACT_REQUEST_ID { get; set; }
        public System.String MANAGEMENT_TYPE { get; set; }
        public System.String POTS_CC_TRP_INC_TYPE { get; set; }
        public System.String BONDED_UPGRADE { get; set; }
        public System.String ESCALATION_REASON { get; set; }
    }
    [Table("TICKET_ACCOUNT", Schema = "WNCCRM")]
    public partial class TICKET_ACCOUNT
    {
        [Key]
        public System.Decimal TICKET_ACCOUNT_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String TICKET_LOCAL_ACCOUNT_NO { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String BUSINESS_SIZE { get; set; }
        public System.String IS_MAJOR_ACCOUNT { get; set; }
        public System.String IS_ELITE_ACCOUNT { get; set; }
        public System.String ACCOUNT_NAME { get; set; }
    }
    [Table("TICKET_CAT_PLATFORM", Schema = "WNCCRM")]
    public partial class TICKET_CAT_PLATFORM
    {
        [Key]
        public System.Decimal TICKET_CAT_PLATFORM_ID { get; set; }
        public System.Decimal PLATFORM_ID { get; set; }
        public System.Decimal TICKET_CATEGORY_ID { get; set; }
        public System.String ROLE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_CAT_REL", Schema = "WNCCRM")]
    public partial class TICKET_CAT_REL
    {
        [Key]
        public System.Decimal TICKET_CAT_REL_ID { get; set; }
        public System.Decimal CHILD_TICKET_CAT_ID { get; set; }
        public System.Decimal PARENT_TICKET_CAT_ID { get; set; }
        public System.Decimal ROOT_TICKET_CAT_ID { get; set; }
        public System.Decimal TICKET_CAT_REL_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String DISPATCH { get; set; }
        public System.String REFER { get; set; }
        public System.String RESOLVE { get; set; }
        public System.String IS_CPE_REPLACEMENT { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER1 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER2 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER3 { get; set; }
        public System.String ACTION_TAKEN { get; set; }
        public System.Decimal? INS_OOS_IND { get; set; }
        public System.String TIER2 { get; set; }
        public System.String TIER3 { get; set; }
        public System.String AVAILABLE_TO_TIER1 { get; set; }
        public System.String DUE_DATE_CHECK_IND { get; set; }
    }
    [Table("TICKET_CAT_REL_SPEC", Schema = "WNCCRM")]
    public partial class TICKET_CAT_REL_SPEC
    {
        [Key]
        public System.Decimal TICKET_CAT_REL_SPEC_ID { get; set; }
        public System.Decimal PARENT_TICKET_CAT_SPEC_ID { get; set; }
        public System.Decimal CHILD_TICKET_CAT_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_CAT_SERVICE_SPEC", Schema = "WNCCRM")]
    public partial class TICKET_CAT_SERVICE_SPEC
    {
        [Key]
        public System.Decimal TICKET_CAT_SERVICE_SPEC_ID { get; set; }
        public System.Decimal TICKET_CATEGORY_ID { get; set; }
        public System.Decimal SERVICE_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_CAT_SPEC", Schema = "WNCCRM")]
    public partial class TICKET_CAT_SPEC
    {
        [Key]
        public System.Decimal TICKET_CAT_SPEC_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal TICKET_CAT_SPEC_TYPE_LKUP_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("TICKET_CAT_SPEC_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class TICKET_CAT_SPEC_TYPE_LKUP
    {
        [Key]
        public System.Decimal TICKET_CAT_SPEC_TYPE_LKUP_ID { get; set; }
        public System.String TICKET_CAT_SPEC_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_CATEGORY", Schema = "WNCCRM")]
    public partial class TICKET_CATEGORY
    {
        [Key]
        public System.Decimal TICKET_CATEGORY_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.Decimal TICKET_CAT_SPEC_ID { get; set; }
        public System.Decimal SECURITY_FUNCTION_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("TICKET_CATEGORY_LKUP", Schema = "WNCCRM")]
    public partial class TICKET_CATEGORY_LKUP
    {
        [Key]
        public System.Decimal TICKET_CATEGORY_LKUP_ID { get; set; }
        public System.String NAME { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_DISPATCH_SKILL", Schema = "WNCCRM")]
    public partial class TICKET_DISPATCH_SKILL
    {
        [Key]
        public System.Decimal TICKET_DISPATCH_SKILL_ID { get; set; }
        public System.Decimal? PARENT_TICKET_CATEGORY_ID { get; set; }
        public System.Decimal? TICKET_CAT_REL_ID { get; set; }
        public System.Decimal? SERVICE_FAMILY_ID { get; set; }
        public System.Decimal? SERVICE_TYPE_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String DISPATCH_SKILL { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_OUTAGE_REL", Schema = "WNCCRM")]
    public partial class TICKET_OUTAGE_REL
    {
        public System.String OUTAGE_INCIDENT { get; set; }
        public System.String ASSOC_TICKET { get; set; }
        public System.Int64? OUT_REL_TO { get; set; }
        public System.DateTime? OUT_REL_CREATE_DATE { get; set; }
        public System.String OUT_REL_CUST_NAME { get; set; }
        public System.String OUT_REL_CUST_TYPE { get; set; }
        public System.String OUT_REL_REQ_SUMMARY { get; set; }
        public System.String OUT_REL_STATUS { get; set; }
        public System.Int64? OUT_REL_REQ_TYPE { get; set; }
    }
    [Table("TICKET_SERVICE_TYPE_LKUP", Schema = "WNCCRM")]
    public partial class TICKET_SERVICE_TYPE_LKUP
    {
        [Key]
        public System.Decimal TICKET_SERVICE_TYPE_LKUP_ID { get; set; }
        public System.String TICKET_SERVICE_TYPE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("TICKET_T", Schema = "WNCCRM")]
    public partial class TICKET_T
    {
        public System.String ADDRESS_1 { get; set; }
        public System.DateTime? APPOINTMENT_SLOT { get; set; }
        public System.String ASSIGNED_GROUP { get; set; }
        public System.String ASSIGNEE { get; set; }
        public System.String CATEGORY { get; set; }
        public System.String CC_LEAD_INCIDENT { get; set; }
        public System.String CITY { get; set; }
        public System.DateTime? CURR_SLA_DATE { get; set; }
        public System.String CUSTOMER_NAME { get; set; }
        public System.String CUSTOMER_TYPE { get; set; }
        public System.String DISPATCH_PRIORITY { get; set; }
        public System.String DISPATCH_STATUS { get; set; }
        public System.String DISPOSITION { get; set; }
        public System.DateTime? IMPACT_START { get; set; }
        public System.DateTime? IMPACT_STOP { get; set; }
        public System.String INTERNET_USERNAME { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String MIROR_INSTANCE { get; set; }
        public System.String NOTES { get; set; }
        public System.DateTime? ORIGINAL_COMMITMENT_DATE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String PRMY_CONTACT_FIRST_NAME { get; set; }
        public System.String PRMY_CONTACT_PHONE_NUMBER { get; set; }
        public System.DateTime? REPORTED_DATE { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER1 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER2 { get; set; }
        public System.String REPORTED_TROUBLE_TYPE_TIER3 { get; set; }
        public System.String RESOLUTION { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER1 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER2 { get; set; }
        public System.String RESOLUTION_CATEGORY_TIER3 { get; set; }
        public System.String SERVICE_INFO { get; set; }
        public System.String SERVICE_PHONE_EXT { get; set; }
        public System.String SERVICE_PHONE_NUMBER { get; set; }
        public System.String SOURCE_SYSTEM { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String SUMMARY { get; set; }
        public System.String VENDOR_TICKET_NUMBER { get; set; }
        public System.String TICKET_NUMBER { get; set; }
    }
    [Table("TICKET_TIERS_APPT", Schema = "WNCCRM")]
    public partial class TICKET_TIERS_APPT
    {
        [Key]
        public System.Decimal TICKET_TIERS_APPT_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String SERVICE_FAMILY { get; set; }
        public System.String SYMPTOM { get; set; }
        public System.String ISSUE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String DAY_OF_WEEK { get; set; }
        public System.Decimal? HOURS_INCREASE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String STRICT_HOURSLOT { get; set; }
        public System.Decimal? SECURITY_PROFILE_ID { get; set; }
    }
    [Table("TIERS_STG", Schema = "WNCCRM")]
    public partial class TIERS_STG
    {
        public System.String TROUBLE_TYPE_TIER1 { get; set; }
        public System.String TROUBLE_TYPE_TIER2 { get; set; }
        public System.String TROUBLE_TYPE_TIER3 { get; set; }
        public System.String PRIORITY { get; set; }
        public System.String DISPATCH { get; set; }
        public System.String REFER { get; set; }
        public System.String RESOLVE { get; set; }
        public System.String INIT_DISPOSITION { get; set; }
        public System.String IS_CPE_REPLACEMENT { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String RESOLUTION_TIER1 { get; set; }
        public System.String RESOLUTION_TIER2 { get; set; }
        public System.String RESOLUTION_TIER3 { get; set; }
        public System.String ACTION_TAKEN { get; set; }
        public System.Decimal? INS_OOS_IND { get; set; }
    }
    [Table("TMP_BI_DRAFT_ABANDONED", Schema = "WNCCRM")]
    public partial class TMP_BI_DRAFT_ABANDONED
    {
        public System.Decimal BUS_INTERACTION_ID { get; set; }
    }
    [Table("TMP_BI_DRAFT_ABANDONED_2", Schema = "WNCCRM")]
    public partial class TMP_BI_DRAFT_ABANDONED_2
    {
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal? RN { get; set; }
    }
    [Table("TMP_MSAG_ADDRESS", Schema = "WNCCRM")]
    public partial class TMP_MSAG_ADDRESS
    {
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String STREET_NUMBER { get; set; }
        public System.String STREET_PREFIX { get; set; }
        public System.String STREET_NAME { get; set; }
        public System.String STREET_SUFFIX { get; set; }
        public System.String STREET_POSTFIX { get; set; }
        public System.String STRUCTURE_TYPE1 { get; set; }
        public System.String STRUCTURE_VALUE1 { get; set; }
        public System.String STRUCTURE_TYPE2 { get; set; }
        public System.String STRUCTURE_VALUE2 { get; set; }
        public System.String CITY_NAME { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
    }
    [Table("TOAD_PLAN_TABLE", Schema = "WNCCRM")]
    public partial class TOAD_PLAN_TABLE
    {
        public System.String STATEMENT_ID { get; set; }
        public System.Decimal? PLAN_ID { get; set; }
        public System.DateTime? TIMESTAMP { get; set; }
        public System.String REMARKS { get; set; }
        public System.String OPERATION { get; set; }
        public System.String OPTIONS { get; set; }
        public System.String OBJECT_NODE { get; set; }
        public System.String OBJECT_OWNER { get; set; }
        public System.String OBJECT_NAME { get; set; }
        public System.String OBJECT_ALIAS { get; set; }
        public System.Decimal? OBJECT_INSTANCE { get; set; }
        public System.String OBJECT_TYPE { get; set; }
        public System.String OPTIMIZER { get; set; }
        public System.Decimal? SEARCH_COLUMNS { get; set; }
        public System.Decimal? ID { get; set; }
        public System.Decimal? PARENT_ID { get; set; }
        public System.Decimal? DEPTH { get; set; }
        public System.Decimal? POSITION { get; set; }
        public System.Decimal? COST { get; set; }
        public System.Decimal? CARDINALITY { get; set; }
        public System.Decimal? BYTES { get; set; }
        public System.String OTHER_TAG { get; set; }
        public System.String PARTITION_START { get; set; }
        public System.String PARTITION_STOP { get; set; }
        public System.Decimal? PARTITION_ID { get; set; }
        public System.String OTHER { get; set; }
        public System.String DISTRIBUTION { get; set; }
        public System.Decimal? CPU_COST { get; set; }
        public System.Decimal? IO_COST { get; set; }
        public System.Decimal? TEMP_SPACE { get; set; }
        public System.String ACCESS_PREDICATES { get; set; }
        public System.String FILTER_PREDICATES { get; set; }
        public System.String PROJECTION { get; set; }
        public System.Decimal? TIME { get; set; }
        public System.String QBLOCK_NAME { get; set; }
    }
    [Table("TOOLS", Schema = "WNCCRM")]
    public partial class TOOLS
    {
        [Key]
        public System.Decimal PKID { get; set; }
        public System.String LINKNAME { get; set; }
        public System.String GROUPNAME { get; set; }
        public System.String GROUPDOMAIN { get; set; }
        public System.String ROLEID { get; set; }
        public System.String QUERYSTRINGPARAMETERS { get; set; }
        public System.String LINKURL { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("UNSPEC_SERV_REPORT", Schema = "WNCCRM")]
    public partial class UNSPEC_SERV_REPORT
    {
        [Key]
        public System.Decimal UNSPEC_SERV_REPORT_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.String LOCAL_ACCOUNT_ID { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String PLATFORM { get; set; }
        public System.String BILLING_SYSTEM { get; set; }
        public System.String IS_TN_CIRCUIT { get; set; }
        public System.String TEL_NUM { get; set; }
        public System.String CIRCUIT { get; set; }
        public System.String CODE { get; set; }
        public System.String NAME { get; set; }
        public System.Decimal? EXTERNAL_OBJECT_ID { get; set; }
        public System.String EXTERNAL_NAME { get; set; }
        public System.Decimal? SPEC_GRP_ID { get; set; }
        public System.Decimal? TOP_ITEM_SPEC_ID { get; set; }
        public System.String EXTERNAL_CODE { get; set; }
        public System.Decimal? SERVICE_SPEC_ID { get; set; }
        public System.Decimal? PARENT_SERVICE_SPEC_ID { get; set; }
        public System.String EXISTS_CAMS_PROD_MAPPING_TO_WC { get; set; }
        public System.String EXISTS_IN_ITEM_SPEC_HIER { get; set; }
        public System.String EXISTS_INVENTORY_SVC_MAPPING { get; set; }
        public System.String EXISTS_MSS_PROD_MAPPING_TO_WC { get; set; }
        public System.String EXISTS_SERVICE_ITEM { get; set; }
        public System.String EXISTS_TEL_NUM_SERVICE { get; set; }
        public System.String EXISTS_CONNECTION_SERVICE { get; set; }
        public System.DateTime? UNSPEC_SERV_REPORT_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("US_STATES_LKUP", Schema = "WNCCRM")]
    public partial class US_STATES_LKUP
    {
        [Key]
        public System.String STATE_CODE { get; set; }
        public System.String STATE_DESCRIPTION { get; set; }
    }
    [Table("USER_ACTIVITY_SUMMARY", Schema = "WNCCRM")]
    public partial class USER_ACTIVITY_SUMMARY
    {
        public System.DateTime? CALENDAR_DATE { get; set; }
        public System.String USER_ID { get; set; }
        public System.String PROFILE_TYPE { get; set; }
        public System.Decimal? ACCESS_COUNT { get; set; }
    }
    [Table("USER_ACTIVITY_SUMMARY_HRLY", Schema = "WNCCRM")]
    public partial class USER_ACTIVITY_SUMMARY_HRLY
    {
        public System.DateTime? CALENDAR_DATE { get; set; }
        public System.String USER_ID { get; set; }
        public System.String PROFILE_TYPE { get; set; }
        public System.Decimal? ACCESS_COUNT { get; set; }
    }
    [Table("USER_DASHBOARD_TEMPLATE", Schema = "WNCCRM")]
    public partial class USER_DASHBOARD_TEMPLATE
    {
        [Key]
        public System.Decimal DASHBOARD_TEMPLATE_ID { get; set; }
        [Key]
        public System.String USERS_ID { get; set; }
        public System.String TYPE { get; set; }
        public System.String IS_DEFAULT { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        [Key]
        public System.Decimal DASHBOARD_SPEC_ID { get; set; }
    }
    [Table("USER_NOTIFICATION", Schema = "WNCCRM")]
    public partial class USER_NOTIFICATION
    {
        [Key]
        public System.Decimal USER_NOTIFICATION_ID { get; set; }
        public System.String USERS_ID { get; set; }
        public System.Decimal? USER_OID { get; set; }
        public System.Decimal NOTIFICATION_ID { get; set; }
        public System.Decimal? PROFILE_NOTIFICATION_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String IS_READ { get; set; }
        public System.DateTime? READ_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String FILE_NAME { get; set; }
        public System.Decimal? USER_OID_LAST_DIGIT { get; set; }
    }
    [Table("USER_ROLE", Schema = "WNCCRM")]
    public partial class USER_ROLE
    {
        [Key]
        public System.Byte[] ID { get; set; }
        public System.String NAME { get; set; }
        public System.Int16 TYPEID { get; set; }
        public System.Int16 ENABLED { get; set; }
        public System.DateTime? CREATEED { get; set; }
        public System.Decimal ENUMID { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("USER_SESSION", Schema = "WNCCRM")]
    public partial class USER_SESSION
    {
        [Key]
        public System.Decimal PKID { get; set; }
        public System.String USERID { get; set; }
        public System.String SESSIONID { get; set; }
        public System.DateTime LASTVERFIEDDATETIME { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("USER_SETTING", Schema = "WNCCRM")]
    public partial class USER_SETTING
    {
        [Key]
        public System.Decimal USER_SETTING_ID { get; set; }
        public System.Decimal USER_OID { get; set; }
        public System.Decimal SETTING_ID { get; set; }
        public System.Decimal? SEQ { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String OBJECT_STATE { get; set; }
    }
    [Table("USERS", Schema = "WNCCRM")]
    public partial class USERS
    {
        [Key]
        public System.String USERS_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? USER_OID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.Decimal? LAST_NOTIFICATION_ID { get; set; }
        public System.String NEW_FEATURES_PORTLET_READ_FLAG { get; set; }
    }
    [Table("VALOR_NPA_NXX", Schema = "WNCCRM")]
    public partial class VALOR_NPA_NXX
    {
        public System.Decimal? ID { get; set; }
        public System.String NPA { get; set; }
        public System.String NXX { get; set; }
    }
    [Table("VOX_MBSC_ACCOUNT", Schema = "WNCCRM")]
    public partial class VOX_MBSC_ACCOUNT
    {
        public System.String ACCOUNTID { get; set; }
        public System.String CONTACTID { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String ACCT_ROLES { get; set; }
    }
    [Table("WC_CHNAGE_PAM", Schema = "WNCCRM")]
    public partial class WC_CHNAGE_PAM
    {
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
        public System.String ACCOUNT_SALESFORCE_ID { get; set; }
        public System.String USER_SFID { get; set; }
        public System.String EMPLOYEENUMBER { get; set; }
        public System.String NAME { get; set; }
        public System.String ROLE { get; set; }
        public System.String ACCTPARTYTYPE { get; set; }
        public System.String OPERATION { get; set; }
    }
    [Table("WC_CUST_ACCT_REL", Schema = "WNCCRM")]
    public partial class WC_CUST_ACCT_REL
    {
        public System.Decimal? PARENT_ACCT_GID { get; set; }
        public System.Decimal? CHILD_ACCT_GID { get; set; }
        public System.Decimal? ROOT_ACCT_GID { get; set; }
        public System.String CUSTACCTRELTYPE { get; set; }
    }
    [Table("WC_RC", Schema = "WNCCRM")]
    public partial class WC_RC
    {
        public System.String WIRE_CENTER { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String OCN { get; set; }
    }
    [Table("WCH36_MSA_VISIBLILITY", Schema = "WNCCRM")]
    public partial class WCH36_MSA_VISIBLILITY
    {
        public System.String GAID { get; set; }
        public System.String PROCESSED { get; set; }
        public System.String MESSAGE { get; set; }
        public System.Decimal? SEQ_NUM { get; set; }
        public System.String DOCTYPE { get; set; }
        public System.Decimal? ROOT_GAID { get; set; }
        public System.Decimal? GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("WCPS_175_CAR_DEL", Schema = "WNCCRM")]
    public partial class WCPS_175_CAR_DEL
    {
        public System.String CUST_ACCT_REL_TYPE { get; set; }
        public System.Decimal? PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? CHILD_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? ROOT_GLOBAL_ACCOUNT_ID { get; set; }
    }
    [Table("WCPS1117_ACCT_PARTY", Schema = "WNCCRM")]
    public partial class WCPS1117_ACCT_PARTY
    {
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String ACCT_PARTY_TYPE { get; set; }
        public System.String TITLE { get; set; }
        public System.String NAME_PREFIX { get; set; }
        public System.String FIRST_NAME { get; set; }
        public System.String MIDDLE_INITIAL { get; set; }
        public System.String LAST_NAME { get; set; }
        public System.String NAME_SUFFIX { get; set; }
        public System.String NAME { get; set; }
        public System.String COMPANY_NAME { get; set; }
        public System.String DEPARTMENT_NAME { get; set; }
        public System.String DESCRIPTION { get; set; }
        public System.String DO_NOT_CALL { get; set; }
        public System.String DO_NOT_EMAIL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String GID_TEMP { get; set; }
        public System.String EMPLOYEE_NUMBER { get; set; }
        public System.String SALES_ID { get; set; }
        public System.String OPT_IN_TEXT { get; set; }
        public System.DateTime? OPT_IN_TEXT_DATE { get; set; }
    }
    [Table("WCPS1117_ACCT_PARTY_PREFRENCES", Schema = "WNCCRM")]
    public partial class WCPS1117_ACCT_PARTY_PREFRENCES
    {
        public System.Decimal ACCT_PARTY_PREFERENCE_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.Decimal GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal BUSINESS_FUNCTION_ID { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("WCPS1117_CONTACT_MEDIUM", Schema = "WNCCRM")]
    public partial class WCPS1117_CONTACT_MEDIUM
    {
        public System.Decimal CONTACT_MEDIUM_ID { get; set; }
        public System.Decimal GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String CONTACT_MEDIUM_METHOD_TYPE { get; set; }
        public System.String CONTACT_MEDIUM_TYPE { get; set; }
        public System.String IS_PRIMARY { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PHONE_COUNTRY_CODE { get; set; }
        public System.String PHONE_NUMBER { get; set; }
        public System.String PHONE_EXTENSION { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("WCPS1117_POSTAL_MEDIUM", Schema = "WNCCRM")]
    public partial class WCPS1117_POSTAL_MEDIUM
    {
        public System.Decimal? POSTAL_MEDIUM_ID { get; set; }
        public System.String OBJECT_STATE { get; set; }
        public System.String ACTIVITY { get; set; }
        public System.String ADDRESS1 { get; set; }
        public System.String ADDRESS2 { get; set; }
        public System.String COUNTRY { get; set; }
        public System.String COUNTRY_CODE { get; set; }
        public System.String STATE { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.String CITY { get; set; }
        public System.String POSTAL_CODE { get; set; }
        public System.Double? LATITUDE { get; set; }
        public System.Double? LONGITUDE { get; set; }
        public System.Decimal CONTACT_MEDIUM_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
        public System.DateTime? LAST_UPDATE_SYSTEM_DATE { get; set; }
    }
    [Table("WEB_SERVICE_USAGE", Schema = "WNCCRM")]
    public partial class WEB_SERVICE_USAGE
    {
        public System.String DASHBOARD { get; set; }
        public System.String PORTLET { get; set; }
        public System.String SUBDIVISION { get; set; }
        public System.String WEB_SERVICE_TO { get; set; }
        public System.String WEB_SERVICE_METHOD { get; set; }
    }
    [Table("WF_CIRCUITS", Schema = "WNCCRM")]
    public partial class WF_CIRCUITS
    {
        public System.String CIRCUIT_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String CIRCUIT_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("WF_CIRCUITS_STG", Schema = "WNCCRM")]
    public partial class WF_CIRCUITS_STG
    {
        public System.String CIRCUIT_ID { get; set; }
        public System.String STATUS { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String CIRCUIT_EXTERNAL_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("WF_IP_ADDRESS", Schema = "WNCCRM")]
    public partial class WF_IP_ADDRESS
    {
        public System.String IP_ADDRESS { get; set; }
        public System.String START_ADDR_STRING { get; set; }
        public System.Decimal? BLOCK_SIZE { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String IP_EXTERNAL_ID { get; set; }
        public System.Decimal? RID { get; set; }
    }
    [Table("WF_IP_ADDRESS_STG", Schema = "WNCCRM")]
    public partial class WF_IP_ADDRESS_STG
    {
        public System.String IP_ADDRESS { get; set; }
        public System.String START_ADDR_STRING { get; set; }
        public System.Decimal? BLOCK_SIZE { get; set; }
        public System.String SERVICE_LOCATION__C { get; set; }
        public System.String CUSTOMER__C { get; set; }
        public System.String IP_EXTERNAL_ID { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("WFC_RECON_CUST_ADV_MISMTCH", Schema = "WNCCRM")]
    public partial class WFC_RECON_CUST_ADV_MISMTCH
    {
        public System.String GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String ID { get; set; }
        public System.String LOCALACCOUNTID__C { get; set; }
        public System.String WFC_CUSTOMER_ADV { get; set; }
        public System.String WNCCRM_CUSTOMER_ADV { get; set; }
        public System.String WFC_USER_ID { get; set; }
        public System.String WNC_GID_TEMP { get; set; }
        public System.Decimal? GLOBAL_ACCT_PARTY_ID { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String BILLING_STATUS { get; set; }
        public System.String MODIFIED_BY_EXCLUDED_USER { get; set; }
        public System.String ID_MTCH_NAME_CHG { get; set; }
        public System.String ACCT_LVL { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
    }
    [Table("WIN_ESP_JOBS_LOG", Schema = "WNCCRM")]
    public partial class WIN_ESP_JOBS_LOG
    {
        public System.Decimal? WIN_ESP_JOBS_LOG_ID { get; set; }
        public System.String JOB_NAME { get; set; }
        public System.String PACKAGE_USED { get; set; }
        public System.String PROCEDURE_USED { get; set; }
        public System.DateTime? JOB_EXEC_DATE { get; set; }
        public System.DateTime? START_TIME { get; set; }
        public System.DateTime? END_TIME { get; set; }
        public System.String TIME_TAKEN { get; set; }
        public System.String STATUS { get; set; }
        public System.String ERROR_MSG { get; set; }
        public System.DateTime? RE_START_TIME { get; set; }
        public System.DateTime? RE_END_TIME { get; set; }
        public System.Decimal? ATTEMPT { get; set; }
        public System.String JOB_TYPE { get; set; }
        public System.String JOB_FOR { get; set; }
    }
    [Table("WINLINK_EMAIL_DETAILS", Schema = "WNCCRM")]
    public partial class WINLINK_EMAIL_DETAILS
    {
        [Key]
        public System.Decimal WINLINK_EMAIL_DETAILS_ID { get; set; }
        public System.String EMAIL_ADDRESS { get; set; }
        public System.String PORTAL_ENUM { get; set; }
        public System.DateTime? LAST_LOGIN_DETAILS { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime CREATED_SYSTEM_DATE { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime LAST_UPDATE_SYSTEM_DATE { get; set; }
        public System.String LAST_UPDATE_SYSTEM_USER { get; set; }
    }
    [Table("WINLOG_EVENTS", Schema = "WNCCRM")]
    public partial class WINLOG_EVENTS
    {
        [Key]
        public System.Decimal ID { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String EVENTCOMMENT { get; set; }
        public System.String EVENTLABEL { get; set; }
        public System.Decimal? SOURCESYSTEM { get; set; }
        public System.String SOURCE { get; set; }
        public System.String TARGETSITE { get; set; }
        public System.DateTime EVENTDATETIME { get; set; }
        public System.Decimal? EVENTTYPE { get; set; }
        public System.String INPUTPARAMS { get; set; }
        public System.String OUTPUTPARAMS { get; set; }
        public System.String ADDITONALPARAMS { get; set; }
        public System.String USERID { get; set; }
        public System.String REQUESTOID { get; set; }
        public System.String STACKTRACE_NEW { get; set; }
        public System.String STACKTRACE { get; set; }
    }
    [Table("WINLOG_EVENTS_SUMMARY", Schema = "WNCCRM")]
    public partial class WINLOG_EVENTS_SUMMARY
    {
        [Key]
        public System.Decimal WINLOG_EVENTS_SUMMARY_ID { get; set; }
        public System.String SERVICE_NAME { get; set; }
        public System.String COMMAND { get; set; }
        public System.String EXTERNAL_VS_DB { get; set; }
        public System.Decimal? CALL_COUNT { get; set; }
        public System.Decimal? SHORTEST_TIME_SECS { get; set; }
        public System.Decimal? LONGEST_TIME_SECS { get; set; }
        public System.Decimal? AVERAGE_TIME_SECS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime? CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.Decimal? CURSOR_EXEC_TIME_SECS { get; set; }
    }
    [Table("WINLOG_EVENTS2", Schema = "WNCCRM")]
    public partial class WINLOG_EVENTS2
    {
        public System.Decimal? ID { get; set; }
        public System.String MESSAGE { get; set; }
        public System.String EVENTCOMMENT { get; set; }
        public System.String EVENTLABEL { get; set; }
        public System.Decimal? SOURCESYSTEM { get; set; }
        public System.String SOURCE { get; set; }
        public System.String TARGETSITE { get; set; }
        public System.DateTime? EVENTDATETIME { get; set; }
        public System.Decimal? EVENTTYPE { get; set; }
        public System.String INPUTPARAMS { get; set; }
        public System.String OUTPUTPARAMS { get; set; }
        public System.String ADDITONALPARAMS { get; set; }
        public System.String USERID { get; set; }
        public System.String REQUESTOID { get; set; }
        public System.String STACKTRACE_NEW { get; set; }
        public System.String STACKTRACE { get; set; }
    }
    [Table("WIRE_CENTER_RATE_CENTER", Schema = "WNCCRM")]
    public partial class WIRE_CENTER_RATE_CENTER
    {
        [Key]
        public System.Decimal WIRE_CENTER_RATE_CENTER_ID { get; set; }
        public System.Decimal? PLATFORM_ID { get; set; }
        public System.String WIRE_CENTER { get; set; }
        public System.String RATE_CENTER { get; set; }
        public System.String CITY { get; set; }
        public System.String STATE_CODE { get; set; }
        public System.Decimal? BUS_SYSTEM_ID { get; set; }
    }
    [Table("WKLY_WINFORCE_PARTNER_DATA", Schema = "WNCCRM")]
    public partial class WKLY_WINFORCE_PARTNER_DATA
    {
        [Key]
        public System.Decimal WKLY_WINFORCE_PARTNER_DATA_ID { get; set; }
        public System.String TYPE { get; set; }
        public System.String PARTNER_CLASSIFICATION__C { get; set; }
        public System.String GLOBAL_ACCOUNT_ID__C { get; set; }
        public System.String WF_PARTNER_NAME { get; set; }
        public System.String WFC_PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WFC_ROOT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String WC_CUST_TYPE { get; set; }
        public System.Decimal? WC_PLATFORM_ID { get; set; }
        public System.String WC_PARTNER_NAME { get; set; }
        public System.Decimal? WC_PARENT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.Decimal? WC_ROOT_GLOBAL_ACCOUNT_ID { get; set; }
        public System.String CREATED_SYSTEM_USER { get; set; }
        public System.DateTime? CREATED_SYSTEM_DATE { get; set; }
    }
    [Table("WORKSKILL", Schema = "WNCCRM")]
    public partial class WORKSKILL
    {
        [Key]
        public System.Decimal WORKSKILL_ID { get; set; }
        public System.String CUST_TYPE { get; set; }
        public System.String SERVICE_STATUS { get; set; }
        public System.String SERVICE_TYPE { get; set; }
        public System.String WORKSET_SKILL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("WS_BUS_INTERACTION_ID_DEL", Schema = "WNCCRM")]
    public partial class WS_BUS_INTERACTION_ID_DEL
    {
        public System.Decimal? BUS_INTERACTION_DEL_ID { get; set; }
        public System.Decimal? BUS_INTERACTION_ID { get; set; }
    }
    [Table("WS_CONFIG_REGION_SPEC_REL", Schema = "WNCCRM")]
    public partial class WS_CONFIG_REGION_SPEC_REL
    {
        [Key]
        public System.Decimal IAWC_ID { get; set; }
        [Key]
        public System.Decimal DASHBOARD_REGION_SPEC_ID { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("WS_INTERACTION", Schema = "WNCCRM")]
    public partial class WS_INTERACTION
    {
        [Key]
        public System.Decimal WS_INTERACTION_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal IAWC_ID { get; set; }
        public System.String SOURCE_SYSTEM_URL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("WS_INTERACTION_DTL", Schema = "WNCCRM")]
    public partial class WS_INTERACTION_DTL
    {
        [Key]
        public System.Decimal WS_INTERACTION_ID { get; set; }
        [Key]
        public System.String XML_TYPE { get; set; }
        public System.String XML_DETAILS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
    }
    [Table("WS_INTERACTION_DTL_HIST", Schema = "WNCCRM")]
    public partial class WS_INTERACTION_DTL_HIST
    {
        public System.Decimal WS_INTERACTION_ID { get; set; }
        public System.String XML_TYPE { get; set; }
        public System.String XML_DETAILS { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
    }
    [Table("WS_INTERACTION_HIST", Schema = "WNCCRM")]
    public partial class WS_INTERACTION_HIST
    {
        public System.Decimal WS_INTERACTION_ID { get; set; }
        public System.Decimal BUS_INTERACTION_ID { get; set; }
        public System.Decimal IAWC_ID { get; set; }
        public System.String SOURCE_SYSTEM_URL { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
        public System.DateTime PARTITION_DATE { get; set; }
        public System.String STATUS { get; set; }
    }
    [Table("WSDL_KEY", Schema = "WNCCRM")]
    public partial class WSDL_KEY
    {
        [Key]
        public System.Decimal WSDL_KEY_ID { get; set; }
        public System.String KEY { get; set; }
        public System.String RESPONSE_XML { get; set; }
        public System.String CREATED_USER { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public System.String LAST_UPDATE_USER { get; set; }
        public System.DateTime? LAST_UPDATE_DATE { get; set; }
    }
    [Table("Z_SERVERS", Schema = "WNCCRM")]
    public partial class Z_SERVERS
    {
        public System.String DEVICE_NAME { get; set; }
        public System.String APP { get; set; }
        public System.String APP_AREA { get; set; }
        public System.String DNS { get; set; }
        public System.String CYBERARK_ID { get; set; }
        public System.String CYBERARK_GROUP { get; set; }
        public System.String STATUS { get; set; }
        public System.String ENV { get; set; }
        public System.String TYPE { get; set; }
        public System.String IP { get; set; }
        public System.String OS { get; set; }
        public System.String OS_VER { get; set; }
        public System.String OS_SP { get; set; }
        public System.String LBP { get; set; }
        public System.String REBOOT { get; set; }
        public System.String BACKUP_NOTE { get; set; }
        public System.String WSUS { get; set; }
        public System.String CHG_WINDOW { get; set; }
        public System.String NOTES { get; set; }
        public System.String CPU { get; set; }
        public System.String MEMORY { get; set; }
        public System.String ENV_GRP { get; set; }
        public System.String NEW_DEVICE_NAME { get; set; }
    }
}
