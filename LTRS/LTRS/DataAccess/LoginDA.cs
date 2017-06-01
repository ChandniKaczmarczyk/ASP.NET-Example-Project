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
    public class LoginDA
    {
        public DataSet Fetchusernamepassword(string username,string password)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_USERNAME_PASSWORD);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String,username);
                db.AddInParameter(dbCmd, "@PASSWORD", DbType.String, password);
                //Execute database commands and store results in dataset
                ds = db.ExecuteDataSet(dbCmd);
            }
            catch(Exception ex)
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

        public DataSet InsertregistrationDetails(string fname,string lname,string username,string password,string phonenumber,string address,string city,string state, string zipcode,string recoveryemail)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_REGISTRATION_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
                db.AddInParameter(dbCmd, "@PASSWORD", DbType.String, password);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phonenumber);
                db.AddInParameter(dbCmd, "@ADDRESS", DbType.String, address);
                db.AddInParameter(dbCmd, "@CITY", DbType.String, city);
                db.AddInParameter(dbCmd, "@STATE", DbType.String, state);
                db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, zipcode);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, recoveryemail);
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
        public DataSet FetchFirstname(int userid)
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

        //public DataSet InsertregistrationDetailsAdmin(string fname, string lname, string username, string password, string phonenumber, string address, string city, string state, string zipcode, string recoveryemail,string adminpassword, string securityque,string securityanswer,string usertype)
        //{
        //    Database db = null;
        //    DbCommand dbCmd = null;
        //    DataSet dsData = null;

        //    try
        //    {
        //        //Database Connection String
        //        db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
        //        //Access Stored Procedure
        //        dbCmd = db.GetStoredProcCommand(AllDA.INSERT_REGISTRATION_DETAILS_ADMIN);
        //        //Pass parameteres in stored procedure
        //        db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
        //        db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
        //        db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
        //        db.AddInParameter(dbCmd, "@PASSWORD", DbType.String, password);
        //        db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phonenumber);
        //        db.AddInParameter(dbCmd, "@ADDRESS", DbType.String, address);
        //        db.AddInParameter(dbCmd, "@CITY", DbType.String, city);
        //        db.AddInParameter(dbCmd, "@STATE", DbType.String, state);
        //        db.AddInParameter(dbCmd, "@ZIPCODE", DbType.String, zipcode);
        //        db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, recoveryemail);
        //        db.AddInParameter(dbCmd, "@DBA_PASSWORD", DbType.String, adminpassword);
        //        db.AddInParameter(dbCmd, "@SECURITY_QUE", DbType.String, securityque);
        //        db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, securityanswer);
        //        db.AddInParameter(dbCmd, "@USER_TYPE", DbType.String, usertype);
                
        //        //Execute database commands and store results in dataset
        //        dsData = db.ExecuteDataSet(dbCmd);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        AllDA.Destroy(ref dbCmd);
        //    }
        //    //return dataset 
        //    return dsData;
        //}

        public DataSet Fetchalldata()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_ADMIN);
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


        public DataSet Fetchmyaccountdata(int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_MY_ACCOUNT_DATA);
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

        public DataSet InsertregistrationDetailsAdmin(string fname, string lname, string username, string password, string phonenumber,string recoveryemail, string adminpassword, string securityque, string securityanswer, string usertype)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_REGISTRATION_DETAILS_ADMIN);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
                db.AddInParameter(dbCmd, "@PASSWORD", DbType.String, password);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phonenumber);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, recoveryemail);
                db.AddInParameter(dbCmd, "@DBA_PASSWORD", DbType.String, adminpassword);
                db.AddInParameter(dbCmd, "@SECURITY_QUE", DbType.String, securityque);
                db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, securityanswer);
                db.AddInParameter(dbCmd, "@USER_TYPE", DbType.String, usertype);

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


        public DataTable Fetchalldatadropdown()
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_ADMIN);
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
            return ds.Tables[0];
        }

        public DataSet fetchreportsbyfilter(int userid, string firstname, string lastname,string username,string phone,string email,string seqanswer,string usertype,string status)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.SEARCH_REPORTS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.Int32, userid);
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, firstname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lastname);
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phone);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, email);
                db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, seqanswer);
                db.AddInParameter(dbCmd, "@USER_TYPE", DbType.String, usertype);
                db.AddInParameter(dbCmd, "@USER_STATUS", DbType.String, status);
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

        //Contact us

        public DataSet FetchEmailID(string USER_NAME)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet ds = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.FETCH_FORGOTPASSWORD_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, USER_NAME);

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
        public DataSet Insertcontactdetails(string fname, string lname, string email, string contactnumber, string inquiry, string chkemail, string chkcontactnum)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_CONTACT_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
                db.AddInParameter(dbCmd, "@EMAIL", DbType.String, email);
                db.AddInParameter(dbCmd, "@CONTACT_NUMBER", DbType.String, contactnumber);
                db.AddInParameter(dbCmd, "@INQUIRY", DbType.String, inquiry);
                db.AddInParameter(dbCmd, "@CHECK_EMAIL", DbType.String, chkemail);
                db.AddInParameter(dbCmd, "@CHECK_CONTACT_NUMBER", DbType.String, chkcontactnum);


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

        public DataSet updateusermaster(int userid,string fname, string lname, string email, string contactnumber,string securityanswers)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.UPDATE_USERMASTER_DATA);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.Int32, userid);
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, email);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, contactnumber);
                db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, securityanswers);

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

        public DataSet deleteusermasterdata(int userid)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.DELETE_USER_MASTER_DATA);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.Int32, userid);
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

        public DataSet fetchreportsbyfilterNEW(int userid, string firstname, string lastname, string username, string phone, string email, string seqanswer, string usertype, string status, string datestemp)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.SEARCH_REPORTS_NEW);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@USER_ID", DbType.Int32, userid);
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, firstname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lastname);
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phone);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, email);
                db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, seqanswer);
                db.AddInParameter(dbCmd, "@USER_TYPE", DbType.String, usertype);
                db.AddInParameter(dbCmd, "@USER_STATUS", DbType.String, status);
                db.AddInParameter(dbCmd, "@DATE_STAMP", DbType.String,datestemp );
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

        // Insert New record in Database when we change the record

        public DataSet Insertdatabasechangerecord(string fname, string lname, string username, string password, string phonenumber, string recoveryemail, string adminpassword, string securityque, string securityanswer, string usertype)
        {
            Database db = null;
            DbCommand dbCmd = null;
            DataSet dsData = null;

            try
            {
                //Database Connection String
                db = DatabaseFactory.CreateDatabase(AllDA.DATABASE_CONNECTION_STRING);
                //Access Stored Procedure
                dbCmd = db.GetStoredProcCommand(AllDA.INSERT_REPORT_DETAILS);
                //Pass parameteres in stored procedure
                db.AddInParameter(dbCmd, "@FIRST_NAME", DbType.String, fname);
                db.AddInParameter(dbCmd, "@LAST_NAME", DbType.String, lname);
                db.AddInParameter(dbCmd, "@USER_NAME", DbType.String, username);
                db.AddInParameter(dbCmd, "@PASSWORD", DbType.String, password);
                db.AddInParameter(dbCmd, "@PHONE_NUMBER", DbType.String, phonenumber);
                db.AddInParameter(dbCmd, "@RECOVERY_EMAIL", DbType.String, recoveryemail);
                db.AddInParameter(dbCmd, "@DBA_PASSWORD", DbType.String, adminpassword);
                db.AddInParameter(dbCmd, "@SECURITY_QUE", DbType.String, securityque);
                db.AddInParameter(dbCmd, "@SECURITY_ANSWER", DbType.String, securityanswer);
                db.AddInParameter(dbCmd, "@USER_TYPE", DbType.String, usertype);

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


    }

}