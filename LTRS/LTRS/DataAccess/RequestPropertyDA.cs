using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
namespace LTRS.DataAccess
{
    public class RequestPropertyDA
    {
        public DataSet fetchrequestedpropertyLandlordside(int landlordid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_PROPERTY_DETAILS_LANDLORD);
                //Pass parameteres in stored procedure

                db.AddInParameter(dbCmd, "@REQUEST_RECEIVER_LANDLORD_ID", DbType.Int32, landlordid);

                //Execute database commands and store results in dataset
                ds = db.ExecuteDataSet(dbCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AllDA.Destroy(ref dbCmd);
            }
            //return dataset 
            return ds;
        }
        public DataSet UpdaterequestStatus(int propertyid,int landlordid,int tenantid,string status)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.UPDATE_REQUEST_PROPERTY_STATUS);
                //Pass parameteres in stored procedure

                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                db.AddInParameter(dbCmd, "@REQUEST_RECEIVER_LANDLORD_ID", DbType.Int32, landlordid);
                db.AddInParameter(dbCmd, "@REQUEST_SENDER_TENANT_ID", DbType.Int32, tenantid);
                db.AddInParameter(dbCmd, "@REQUEST_STATUS", DbType.String, status);
                //Execute database commands and store results in dataset
                ds = db.ExecuteDataSet(dbCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AllDA.Destroy(ref dbCmd);
            }
            //return dataset 
            return ds;
        }

        public DataSet FetchEmailaddressforproperty(int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_FIRST_NAME);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.Int32, userid);

                //Execute database commands and store results in dataset
                ds = db.ExecuteDataSet(dbCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AllDA.Destroy(ref dbCmd);
            }
            //return dataset 
            return ds;
        }
    }
}