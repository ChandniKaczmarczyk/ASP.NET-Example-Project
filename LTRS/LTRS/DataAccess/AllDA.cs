using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace LTRS.DataAccess
{
    public static class AllDA
    {
        public const String DATABASE_CONNECTION_STRING = "LTRSConnectionString";

        public const String FETCH_USERNAME_PASSWORD = "FETCH_USERNAME_PASSWORD";

        public const String INSERT_REGISTRATION_DETAILS = "INSERT_REGISTRATION_DETAILS";
        public const String INSERT_PROPERTY_DETAILS = "INSERT_PROPERTY_DETAILS";
        public const String UPDATE_PROPERTY_PHOTO = "UPDATE_PROPERTY_PHOTO";
        public const String FETCH_FIRST_NAME = "FETCH_FIRST_NAME";
        public const String INSERT_REGISTRATION_DETAILS_ADMIN = "INSERT_REGISTRATION_DETAILS_ADMIN";
        public const String FETCH_ADMIN = "FETCH_ADMIN";
        public const String FETCH_MY_ACCOUNT_DATA = "FETCH_MY_ACCOUNT_DATA";
        public const string FETCH_DATA_FOR_RATINGS = "FETCH_DATA_FOR_RATINGS";
        public const string FETCH_RATINGS = "FETCH_RATINGS";
        public const string FETCH_RATINGS_FROM_USER_ID = "FETCH_RATINGS_FROM_USER_ID";
        public const string SEARCH_REPORTS = "SEARCH_REPORTS";
        public const string FETCH_FORGOTPASSWORD_DETAILS = "FETCH_FORGOTPASSWORD_DETAILS";
        public const string INSERT_CONTACT_DETAILS = "INSERT_CONTACT_DETAILS";
        public const string INSERT_SUBMIT_RATINGS_DETAILS = "INSERT_SUBMIT_RATINGS_DETAILS";

        //Request Property

        public const string INSERT_REQUEST_PROPERTY_DATA = "INSERT_REQUEST_PROPERTY_DATA";

        
        public const string FETCH_PROPERTY_DETAILS_LANDLORD = "FETCH_PROPERTY_DETAILS_LANDLORD";
        public const string UPDATE_REQUEST_PROPERTY_STATUS = "UPDATE_REQUEST_PROPERTY_STATUS";

        public const string FETCH_RATINGS_DETAILS_TENANT_WISE = "FETCH_RATINGS_DETAILS_TENANT_WISE";
        public const string FETCH_RATINGS_DETAILS_LANDLORD_WISE = "FETCH_RATINGS_DETAILS_LANDLORD_WISE";

        public const string FETCH_VIEW_RATINGS_DATA = "FETCH_VIEW_RATINGS_DATA";
        

        //update database

        public const string UPDATE_USERMASTER_DATA = "UPDATE_USERMASTER_DATA";

        public const string DELETE_USER_MASTER_DATA = "DELETE_USER_MASTER_DATA";

        //View Ratings

        public const string FETCH_ALL_VIEW_RATINGS = "FETCH_ALL_VIEW_RATINGS";

        //REPORTS
        public const string SEARCH_REPORTS_NEW = "SEARCH_REPORTS_NEW";
        public const string VIEW_POSTED_PROPERTY_LANDLORD = "VIEW_POSTED_PROPERTY_LANDLORD";
        public const string VIEW_ALL_PROPERTY = "VIEW_ALL_PROPERTY";

        //Edit post property
        public const string UPDATE_POST_PROPERTY_WITHOUT_FILE = "UPDATE_POST_PROPERTY_WITHOUT_FILE";
        public const string UPDATE_POST_PROPERTY_WITH_FILE = "UPDATE_POST_PROPERTY_WITH_FILE";
        public const string FETCH_PROPERTY_ID_WISE = "FETCH_PROPERTY_ID_WISE";
        public const string DELETE_PROPERTY = "DELETE_PROPERTY";
        public const string FETCH_RATINGS_REPORTS = "FETCH_RATINGS_REPORTS";
        public const string INSERT_REPORT_DETAILS = "INSERT_REPORT_DETAILS";

        public static void Destroy(ref DbCommand dbCmd)
        {
            try
            {
                if (dbCmd != null)
                {
                    if (dbCmd.Connection.State == ConnectionState.Open)
                    {
                        dbCmd.Connection.Close();
                    }
                }
                dbCmd = null;
            }
            catch (Exception) { }

        }
    }
}