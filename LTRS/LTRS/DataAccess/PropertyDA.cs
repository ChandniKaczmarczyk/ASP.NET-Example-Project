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
    public class PropertyDA
    {
        public DataSet Postpropertyforrent(string propertytype, string ownername, string contactnumber, string propertyaddress, string propertycity, string propertystate, string propertyzipcode, string builtdate, string bedbath, string photo, double rent,int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_PROPERTY_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@PROPERTY_TYPE", DbType.String, propertytype);
                db.AddInParameter(dbCmd, "@OWNER_NAME", DbType.String, ownername);
                db.AddInParameter(dbCmd, "@CONTACT_NUMBER", DbType.String, contactnumber);
                db.AddInParameter(dbCmd, "@PROPERTY_ADDRESS", DbType.String, propertyaddress);
                db.AddInParameter(dbCmd, "@CITY", DbType.String, propertycity);
                db.AddInParameter(dbCmd, "@STATE", DbType.String, propertystate);
                db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, propertyzipcode);
                db.AddInParameter(dbCmd, "@BUILTDATE", DbType.String, builtdate);
                db.AddInParameter(dbCmd, "@BED_BATH", DbType.String, bedbath);
                db.AddInParameter(dbCmd, "@PHOTOS", DbType.String, photo);
                db.AddInParameter(dbCmd, "@RENT", DbType.Double, rent);
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


        public DataSet Updatephoto(int propertyid,string photo)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.UPDATE_PROPERTY_PHOTO);
                //Pass parameteres in stored procedure

                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                db.AddInParameter(dbCmd, "@PHOTOS", DbType.String, photo);
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
        public DataSet insertrequestpropertydetail(int propertyid, int tenantid,int landlordid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_REQUEST_PROPERTY_DATA);
                //Pass parameteres in stored procedure

                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                db.AddInParameter(dbCmd, "@REQUEST_SENDER_TENANT_ID", DbType.Int32, tenantid);
                db.AddInParameter(dbCmd, "@REQUEST_RECEIVER_LANDLORD_ID", DbType.String, landlordid);
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
        public DataSet Viewpostedproperty( int landlordid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.VIEW_POSTED_PROPERTY_LANDLORD);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.String, landlordid);
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
        public DataSet ViewAllProperty()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.VIEW_ALL_PROPERTY);
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


        //update property with file
        public DataSet updatepropertywithfile(int propertyid,string propertytype, string ownername, string contactnumber, string propertyaddress, string propertycity, string propertystate, string propertyzipcode, string builtdate, string bedbath, string photo, double rent, int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.UPDATE_POST_PROPERTY_WITH_FILE);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                db.AddInParameter(dbCmd, "@PROPERTY_TYPE", DbType.String, propertytype);
                db.AddInParameter(dbCmd, "@OWNER_NAME", DbType.String, ownername);
                db.AddInParameter(dbCmd, "@CONTACT_NUMBER", DbType.String, contactnumber);
                db.AddInParameter(dbCmd, "@PROPERTY_ADDRESS", DbType.String, propertyaddress);
                db.AddInParameter(dbCmd, "@CITY", DbType.String, propertycity);
                db.AddInParameter(dbCmd, "@STATE", DbType.String, propertystate);
                db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, propertyzipcode);
                db.AddInParameter(dbCmd, "@BUILTDATE", DbType.String, builtdate);
                db.AddInParameter(dbCmd, "@BED_BATH", DbType.String, bedbath);
                db.AddInParameter(dbCmd, "@PHOTOS", DbType.String, photo);
                db.AddInParameter(dbCmd, "@RENT", DbType.Double, rent);
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


        //update property without file

        public DataSet updatepropertywithoutfile(int propertyid, string propertytype, string ownername, string contactnumber, string propertyaddress, string propertycity, string propertystate, string propertyzipcode, string builtdate, string bedbath,double rent, int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.UPDATE_POST_PROPERTY_WITHOUT_FILE);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
                db.AddInParameter(dbCmd, "@PROPERTY_TYPE", DbType.String, propertytype);
                db.AddInParameter(dbCmd, "@OWNER_NAME", DbType.String, ownername);
                db.AddInParameter(dbCmd, "@CONTACT_NUMBER", DbType.String, contactnumber);
                db.AddInParameter(dbCmd, "@PROPERTY_ADDRESS", DbType.String, propertyaddress);
                db.AddInParameter(dbCmd, "@CITY", DbType.String, propertycity);
                db.AddInParameter(dbCmd, "@STATE", DbType.String, propertystate);
                db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, propertyzipcode);
                db.AddInParameter(dbCmd, "@BUILTDATE", DbType.String, builtdate);
                db.AddInParameter(dbCmd, "@BED_BATH", DbType.String, bedbath);
                db.AddInParameter(dbCmd, "@RENT", DbType.Double, rent);
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
        public DataSet FetchpropertyIdWise(int propertyid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_PROPERTY_ID_WISE);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
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
        public DataSet DeleteProperty(int propertyid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.DELETE_PROPERTY);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@PROPERTY_ID", DbType.Int32, propertyid);
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