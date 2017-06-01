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
    public class SubmitRatingDA
    {
        public DataSet fetchdataforratings()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_DATA_FOR_RATINGS);
                //Pass parameteres in stored procedure
               
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

        public DataSet fetchratingsforrepeater()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_RATINGS);
                //Pass parameteres in stored procedure

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

        public DataSet fetchratingsforrepeaterbyuserid(int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_RATINGS_FROM_USER_ID);
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
        public DataSet INSERT_SUBMIT_RATINGS_DETAILS(int ratingid, int fromuserid, int touserid, int ratings, string reviews, string propertyaddress, string city, string state, string zipcode,int propertyid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_SUBMIT_RATINGS_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@RATING_ID", DbType.Int32, ratingid);
                db.AddInParameter(dbCmd, "@FROM_USER_ID", DbType.Int32, fromuserid);
                db.AddInParameter(dbCmd, "@TO_USER_ID", DbType.Int32, touserid);
                db.AddInParameter(dbCmd, "@RATINGS", DbType.Int32, ratings);
                db.AddInParameter(dbCmd, "@REVIEWS", DbType.String, reviews);
                db.AddInParameter(dbCmd, "@PROPERTY_ADDRESS", DbType.String, propertyaddress);
                db.AddInParameter(dbCmd, "@CITY", DbType.String, city);
                db.AddInParameter(dbCmd, "@STATE", DbType.String, state);
                db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, zipcode);
                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                //Execute database commands and store results in dataset
                dsData = db.ExecuteDataSet(dbCmd);

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
            return dsData;
        }


        public DataSet FetchRatingDataForTenant(int tenantid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_RATINGS_DETAILS_TENANT_WISE);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@REQUEST_SENDER_TENANT_ID", DbType.Int32, tenantid);
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


        public DataSet FetchRatingDataForLandlord(int landlordid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_RATINGS_DETAILS_LANDLORD_WISE);
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

        public DataSet FetchViewProfileData(int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_VIEW_RATINGS_DATA);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@TO_USER_ID", DbType.Int32, userid);
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

        public DataSet FetchViewRatingsallData()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_ALL_VIEW_RATINGS);
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


        public DataSet FetchRatingreports()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_RATINGS_REPORTS);
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