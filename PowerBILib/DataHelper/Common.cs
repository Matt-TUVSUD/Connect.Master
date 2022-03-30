using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRC.Connect.Libraries.PowerBILib
{

    public class Common
    {
        public const string REPORT_CATEGORY = "ReportCategory";
        public const string REPORT_TYPE = "ReportType";
        public const string REPORT_ACCOUNTS = "Accounts";
        public const string REPORT_AUTHENTICATIONTYPES = "AuthenticationTypes";

        public const string RECORD_SAVED_SUCCESS = "Record saved successfully.";
        public const string RECORD_DELETED_SUCCESS = "Record deleted successfully.";
        public const string RECORD_ALREADY_EXISTS = "Record already exists.";

        public const string RECORD_DELETED_EXCEPTION = "You can't delete default dataset";

        public const string REPORT_ID_REQUIRED = "Please select report";
        public const string GSAFE_ID_REQUIRED = "GSafe ID is required";
        public static readonly string DEFAULT_REPORT_CATEGORY = ConfigurationManager.AppSettings["DefaultReportCategory"].ToString();
        public static readonly string DEFAULT_REPORT = ConfigurationManager.AppSettings["DefaultReport"].ToString();
        
        public const string INVALID_USER = "You don't have access for any reports to view.";
        public const string ERROR_MESSAGE = "You don't have access to perform this operation";
        public const string NO_RECORDS = "No user reports available";
        public const string NO_DATASET_ACCESS = "You don't have access of any dataset to Create Report.";


    }
}
