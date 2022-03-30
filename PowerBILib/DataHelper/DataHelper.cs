using GRC.Connect.Libraries.PowerBILib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRC.Connect.Libraries.PowerBILib
{
    public class DataHelper : DataContext
    {

        #region Dataset Data Helper

        /// <summary>
        /// Insert Dataset access
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        private static int InsertDatasetAccess(int datasetId, int clientId, string userId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@DatasetId", datasetId),
                new SqlParameter("@ClientId", clientId),
                new SqlParameter("@UserId", userId)
            };
            return ExecuteScalar("[PBI].[InsertDatasetAccess]", CommandType.StoredProcedure, parameters);
        }


        /// <summary>
        /// Delete dataset by dataset Id
        /// </summary>
        /// <param name="datasetId"></param>
        /// <returns></returns>
        public static object DeleteDatasetById(int datasetId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@DatasetId", datasetId)
            };
            return ExecuteScalar("[PBI].[DeleteDataset]", CommandType.StoredProcedure, parameters);
        }


        /// <summary>
        /// Get list of datasets 
        /// </summary>
        /// <returns></returns>
        public static List<PBDatasetMaster> GetDatasets()
        {
            SqlParameter[] parameters = new SqlParameter[] {

            };
            var dt = Execute("[PBI].[GetDatasets]", CommandType.StoredProcedure, parameters);
            return dt.AsEnumerable().Select((row, index) => new PBDatasetMaster
            {
                ID = Convert.ToInt32(row["ID"]),
                DataSetName = row["DataSetName"] != DBNull.Value ? row["DataSetName"].ToString() : string.Empty
            }).ToList();
        }

        /// <summary>
        /// Get the defalut dataset
        /// </summary>
        /// <param name="gSafeID"></param>
        /// <returns></returns>
        public static string GetDefaultDataset(string gSafeID)
        {
            var userInfo = GetUserInformation(gSafeID).AsEnumerable().Select((row) => (
                LoginId: Convert.ToInt32(row["LoginId"]),
                PBUserName: row["PowerBIUserName"].ToString()
            )).FirstOrDefault();

            if (userInfo.LoginId != 0)
            {
                SqlParameter[] parameters = new SqlParameter[] {
                        new SqlParameter("@UserID", userInfo.LoginId)
                };
                var dt = Execute("[PBI].[GetDefaultDataset]", CommandType.StoredProcedure, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.AsEnumerable().Select((row, index) => new
                    {
                        DataSetId = row["DataSetId"] != DBNull.Value ? row["DataSetId"].ToString() : string.Empty
                    }).FirstOrDefault().DataSetId;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Insert Dataset Access
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="clientId"></param>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public static int InsertUserDatasetAccess(int datasetId, int clientId, string userIds)
        {
            if (userIds.Equals(string.Empty))
                userIds = "-1"; //For all users
            return InsertDatasetAccess(datasetId, clientId, userIds);
        }

        /// <summary>
        /// Delete Dataset access
        /// </summary>
        /// <param name="datasetAccessId"></param>
        /// <returns></returns>
        public static int DeleteDatasetAccessById(int datasetAccessId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@DatasetAccessID", datasetAccessId)
            };
            return ExecuteScalar("[PBI].[DeleteDatasetAccess]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Get list of dataset and access details
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDatasetAccessList()
        {
            SqlParameter[] parameters = new SqlParameter[] {
            };
            return Execute("[PBI].[GetDatasetAccess]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Insert and Update Dataset
        /// </summary>
        /// <param name="dsmaster"></param>
        /// <returns></returns>
        public static int InertUpdateDataset(PBDatasetMaster dsmaster)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID ", dsmaster.ID),
                new SqlParameter("@DatasetName", dsmaster.DataSetName),
                new SqlParameter("@DatasetID", dsmaster.DatasetID),
                new SqlParameter("@WorkSpaceID", dsmaster.WorkSpaceID),
                new SqlParameter("@IsActive", dsmaster.IsActive),
                new SqlParameter("@IsDefault", dsmaster.IsDefault),
                new SqlParameter("@AccountID", dsmaster.AccountID)
            };
            return ExecuteScalar("[PBI].[InsertUpdateDataset]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Search Dataset by defined parameters
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="accountId"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static DataTable GetDatasetSearch(string datasetName = "", int accountId = 1, bool isActive = true)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@DatasetName", datasetName),
                new SqlParameter("@AccountId", accountId),
                new SqlParameter("@IsActive", isActive),

            };
            return Execute("[PBI].[GetDatasetsSearch]", CommandType.StoredProcedure, parameters);
        }
        #endregion

        #region Report Data Helper
        /// <summary>
        /// Search Reports by defined parameters
        /// </summary>
        /// <param name="reportCategoryID"></param>
        /// <param name="reportName"></param>
        /// <param name="reportType"></param>
        /// <param name="accountId"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static DataTable GetReportSearch(int reportCategoryID = 1, string reportName = "", string reportType = "", int accountId = 1, bool isActive = true)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportCategoryID", reportCategoryID),
                new SqlParameter("@ReportName", reportName),
                new SqlParameter("@ReportType", reportType),
                new SqlParameter("@AccountId", accountId),
                new SqlParameter("@IsActive", isActive),

            };
            return Execute("[PBI].[GetReportsSearch]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Get list of reports by CategoryId to populate the dropdown for Access Page to show all active reports
        /// </summary>
        /// <returns></returns>
        public static List<PBReportMaster> GetReportsByCategory(int reportCategoryID)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportCategoryID", reportCategoryID)
            };
            var dt = Execute("[PBI].[GetReportsByCategory]", CommandType.StoredProcedure, parameters);
            return dt.AsEnumerable().Select((row, index) => new PBReportMaster
            {
                ID = Convert.ToInt32(row["ID"]),
                ReportName = row["ReportName"] != DBNull.Value ? row["ReportName"].ToString() : string.Empty
            }).ToList();
        }

        /// <summary>
        /// Get all Reports categories
        /// </summary>
        /// <returns></returns>
        public static DataTable GetReportCategories(Boolean excludeUserReportCategory = false)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ExcludeUserReportCagegory",excludeUserReportCategory)
            };
            return Execute("[PBI].[GetReportCategories]", CommandType.StoredProcedure, parameters);

        }

        /// <summary>
        /// Return Report types - Dashboard or Report
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetReportTypes()
        {
            var rType = new Dictionary<string, string>
                {
                    { "Select", "-1" },
                    { "Dashboard", "Dashboard" },
                    { "Report", "Report" }
                };
            return rType;
        }

        /// <summary>
        /// Returns list of active accounts to poplate the dropdown
        /// </summary>
        /// <returns></returns>
        public static List<PBAccount> GetAccounts()
        {
            var dt = Execute("[PBI].[GetAccounts]", CommandType.StoredProcedure, null);
            var lst = dt.AsEnumerable().Select((row, index) => new PBAccount
            {
                ID = Convert.ToInt32(row["ID"]),
                AccountName = row["AccountName"] != DBNull.Value ? row["AccountName"].ToString() : string.Empty,
                AccessID = row["AccessID"] != DBNull.Value ? row["AccessID"].ToString() : string.Empty,
                AccessSecret = row["AccessSecret"] != DBNull.Value ? row["AccessSecret"].ToString() : string.Empty,
                ApplicationID = row["ApplicationID"] != DBNull.Value ? Guid.Parse(row["ApplicationID"].ToString()) : Guid.Empty,
                AuthenticationType = row["AuthenticationType"] != DBNull.Value ? row["AuthenticationType"].ToString() : string.Empty,
                IsActive = Convert.ToBoolean(row["IsActive"])
            });
            return lst.ToList();
        }

        /// <summary>
        /// Get list of reports and access details
        /// </summary>
        /// <returns></returns>
        public static DataTable GetReportAccessList()
        {
            SqlParameter[] parameters = new SqlParameter[] {
            };
            return Execute("[PBI].[GetReportAccess]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Get All clients
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllClients()
        {
            SqlParameter[] parameters = new SqlParameter[] { };
            return Execute("[PBI].[GetClients]", CommandType.StoredProcedure, parameters);

        }

        /// <summary>
        /// Get Users by Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static DataTable GetUsersByClientId(int clientId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ClientId", clientId)
            };
            return Execute("[PBI].[GetUsersByClientID]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Insert Report Access
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="clientId"></param>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public static int InsertUserAccess(int reportId, int clientId, string userIds)
        {
            if (userIds.Equals(string.Empty))
                userIds = "-1"; //For all users
            return InsertReportAccess(reportId, clientId, userIds);
        }

        /// <summary>
        /// Delete report access
        /// </summary>
        /// <param name="reportAccessId"></param>
        /// <returns></returns>
        public static int DeleteReportAccessById(int reportAccessId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportAccessID", reportAccessId)
            };
            return ExecuteScalar("[PBI].[DeleteReportAccess]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Delete report along with report access
        /// </summary>
        /// <param name="reportAccessId"></param>
        /// <returns></returns>
        public static int DeleteReportById(int reportId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportID", reportId)
            };
            return ExecuteScalar("[PBI].[DeleteReport]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Delete user reports by report ID
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static int DeleteUserReportById(int reportId, int userId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportID", reportId),
                new SqlParameter("@UserID", userId)
            };
            return ExecuteScalar("[PBI].[DeleteUserReport]", CommandType.StoredProcedure, parameters);
        }


        /// <summary>
        /// Insert and Update Report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public static int InertUpdateReport(PBReportMaster report)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID ", report.ID),
                new SqlParameter("@ReportName", report.ReportName),
                new SqlParameter("@ReportID", report.ReportID),
                new SqlParameter("@ReportType", report.ReportType),
                new SqlParameter("@WorkSpaceID", report.WorkSpaceID),
                new SqlParameter("@ReportCategoryID", report.ReportCategoryID),
                new SqlParameter("@IsActive", report.IsActive),
                new SqlParameter("@AccountID", report.AccountID)
            };
            return ExecuteScalar("[PBI].[InsertUpdateReport]", CommandType.StoredProcedure, parameters);



        }

        /// <summary>
        /// Insert Report access
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        private static int InsertReportAccess(int reportId, int clientId, string userId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportId", reportId),
                new SqlParameter("@ClientId", clientId),
                new SqlParameter("@UserId", userId)
            };
            return ExecuteScalar("[PBI].[InsertReportAccess]", CommandType.StoredProcedure, parameters);
        }


        #endregion

        #region MANAGE PAGE
        public static DataTable GetUserInformation(string gsafeId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@GSafeID", gsafeId)
            };
            return Execute("[PBI].[UserInformation]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Get list of reports by CategoryId to populate the dropdown for Access Page to show all active reports
        /// </summary>
        /// <returns></returns>
        public static List<PBReportMaster> GetAuthorizedReports(int userId, int reportCategoryID)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@ReportCategoryID", reportCategoryID)
            };
            var dt = Execute("[PBI].[GetAuthorizedReports]", CommandType.StoredProcedure, parameters);
            return dt.AsEnumerable().Select((row, index) => new PBReportMaster
            {
                ID = Convert.ToInt32(row["ID"]),
                ReportName = row["ReportName"] != DBNull.Value ? row["ReportName"].ToString() : string.Empty
            }).ToList();
        }

        /// <summary>
        /// Get User reports
        /// </summary>
        /// <param name="gsafeId"></param>
        /// <returns></returns>
        public static DataTable GetUserReports(string gsafeId)
        {
            //Get LoginId based on GsafeId
            var userInfo = DataHelper.GetUserInformation(gsafeId).AsEnumerable().Select((row, index) => (
                RowIndex: index,
                LoginId: Convert.ToInt32(row["LoginId"])
            )).FirstOrDefault();

            //Check if received LoginId is correct, based on that get authorized reports.
            if (userInfo.LoginId > 0)
            {
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserID", userInfo.LoginId)
            };
                var dt = Execute("[PBI].[GetUserReports]", CommandType.StoredProcedure, parameters);
                return dt;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Update IsPublic flag based on the previous value (Toggle)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="reportId"></param>
        /// <returns></returns>
        public static int UpdateIsPublicFlag(int userId, int reportId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@ReportID", reportId)
            };
            return ExecuteScalar("[PBI].[UpdateIsPublicFlag]", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// Rename report by report id 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="reportId"></param>
        /// <param name="newReportName"></param>
        /// <returns></returns>
        public static int RenameReportNameById(int userId, int reportId, string newReportName)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ReportId", reportId),
                new SqlParameter("@UserId", userId),
                new SqlParameter("@ReportName", newReportName)
            };
            return ExecuteScalar("[PBI].[RenameReport]", CommandType.StoredProcedure, parameters);
        }


        #endregion
    }
}