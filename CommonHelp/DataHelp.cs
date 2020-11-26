using CommonHelp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommonHelp
{
    public class DataHelp
    {
        LogHelper logHelper = new LogHelper();
        #region System_User
        public List<System_User> GetUsers(System_User user)
        {
            logHelper.InfoLog("", "GetUsers");
            return DapperHelper<System_User>.Query("select * from [System_User] where UserName=@UserName and Password=@Password", user);
        }
        #endregion

        #region TAS_user
        public List<TAS_User> GetTAS_UserAll()
        {
            logHelper.InfoLog("",  "GetTAS_UserAll");
            return DapperHelper<TAS_User>.Query(@"SELECT *
                                          FROM [dbo].[TAS_User] ", new object());
        }
        public List<TAS_User> GetTAS_users(TAS_User tAS_user)
        {
            logHelper.InfoLog("",  "GetTAS_users");
            return DapperHelper<TAS_User>.Query(@"SELECT *
                                          FROM [dbo].[TAS_User] 
                                              where UId=@UId and Fname=@Fname and @Lname=Lname and Title=@Title and StaffNo=@StaffNo and Type=@Type", tAS_user);
        }

        public int AddTAS_users(TAS_User tAS_user)
        {
            logHelper.InfoLog("",  "AddTAS_users");
            return DapperHelper<TAS_User>.Execute(@"INSERT INTO [dbo].[TAS_User]
           ([UId]
           ,[Fname]
           ,[Lname]
           ,[Title]
           ,[StaffNo]
           ,[Type])
     VALUES
           (@UId
           ,@Fname
           ,@Lname
           ,@Title
           ,@StaffNo
           ,@Type)", tAS_user);
        }

        public int DelectTAS_users(TAS_User tAS_user)
        {
            logHelper.InfoLog("",  "DelectTAS_users");
            return DapperHelper<TAS_User>.Execute(@"DELETE FROM [dbo].[TAS_User]
      WHERE id=@Id", tAS_user);
        }
        #endregion

        #region TAS_Staff
        public List<TAS_Staff> GetTAS_StaffsAll()
        {
            logHelper.InfoLog("",  "GetTAS_StaffsAll");
            return DapperHelper<TAS_Staff>.Query(@"SELECT *
                                          FROM [dbo].[TAS_Staff]  ", new object());
        }

        public List<TAS_Staff> GetTAS_Staffs(TAS_Staff tAS_Staff)
        {
            logHelper.InfoLog("",  "GetTAS_Staffs");
            return DapperHelper<TAS_Staff>.Query(@"SELECT *
                                          FROM [dbo].[TAS_Staff] 
                                              where No=@No and CostCentre=@CostCentre and Dept=@Dept and Role=@Role", tAS_Staff);
        }

        public int AddTAS_Staff(TAS_Staff tAS_Staff)
        {
            logHelper.InfoLog("",  "tAS_Staff");
            return DapperHelper<TAS_Staff>.Execute(@"INSERT INTO [dbo].[TAS_Staff]
           ([No]
           ,[CostCentre]
           ,[Dept]
           ,[Role])
     VALUES
           (@No
           ,@CostCentre
           ,@Dept
           ,@Role)", tAS_Staff);
        }

        #endregion

        #region TAS_Duty

        public List<TAS_Duty> GetTAS_DutysAll()
        {
            logHelper.InfoLog("",  "GetTAS_DutysAll");
            return DapperHelper<TAS_Duty>.Query(@"SELECT *
                                          FROM [dbo].[TAS_Duty]", new object());
        }

        public List<TAS_Duty> GetTAS_Dutys(TAS_Duty tAS_Duty)
        {
            logHelper.InfoLog("",  "GetTAS_Dutys");
            return DapperHelper<TAS_Duty>.Query(@"SELECT *
                                          FROM [dbo].[TAS_Duty] 
                                              where StaffNo=@StaffNo and CostCentre=@CostCentre and Hours=@Hours and Duty=@Duty", tAS_Duty);
        }

        public int AddTAS_Dutys(TAS_Duty tAS_Duty)
        {
            logHelper.InfoLog("",  "AddTAS_Dutys");
            return DapperHelper<TAS_Duty>.Execute(@"INSERT INTO [dbo].[TAS_Duty]
           ([StaffNo]
           ,[CostCentre]
           ,[Hours]
           ,[Duty])
     VALUES
           (@StaffNo
           ,@CostCentre
           ,@Hours
           ,@Duty)", tAS_Duty);
        }
        #endregion

        #region TAS_CourseRecord

        public List<TAS_CourseRecord> GetTAS_CourseRecordAll()
        {
            logHelper.InfoLog("",  "GetTAS_CourseRecordAll");
            return DapperHelper<TAS_CourseRecord>.Query(@"SELECT *
                                          FROM [dbo].[TAS_CourseRecord]", new object());
        }

        public List<TAS_CourseRecord> GetTAS_CourseRecords(TAS_CourseRecord tAS_CourseRecord)
        {
            logHelper.InfoLog("",  "GetTAS_CourseRecords");
            return DapperHelper<TAS_CourseRecord>.Query(@"SELECT *
                                          FROM [dbo].[TAS_CourseRecord] 
                                              where CourseCode=@CourseCode and CourseTitle=@CourseTitle and Type=@Type and Hours=@Hours and Dept=@Dept and UId=@UId and Schooltime=@Schooltime and HQ=@HQ and UNITA=@UNITA and UNITB=@UNITB and UNITC=@UNITC and ITGY=@ITGY and MSAF=@MSAF and SMG=@SMG and", tAS_CourseRecord);
        }

        public int AddTAS_CourseRecords(TAS_CourseRecord tAS_CourseRecord)
        {
            logHelper.InfoLog("",  "AddTAS_CourseRecords");
            return DapperHelper<int>.Query(@"INSERT INTO [dbo].[TAS_CourseRecord]
           ([CourseCode]
           ,[CourseTitle] 
           ,[Dept] 
           ,[Schooltime]
           ,[HQ]
           ,[UNITA]
           ,[UNITB]
           ,[UNITC]
           ,[ITGY]
           ,[MSAF]
           ,[SMG])
     VALUES
           (@CourseCode
           ,@CourseTitle 
           ,@Dept 
           ,@Schooltime
           ,@HQ
           ,@UNITA
           ,@UNITB
           ,@UNITC
           ,@ITGY
           ,@MSAF
           ,@SMG);SELECT CAST(SCOPE_IDENTITY() as int)", tAS_CourseRecord).FirstOrDefault();
        }

        public TAS_CourseRecord GetTAS_CourseRecord(TAS_CourseRecord tAS_CourseRecord)
        {
            logHelper.InfoLog("",  "GetTAS_CourseRecord");
            return DapperHelper<TAS_CourseRecord>.QueryFirst(@"SELECT *
                                          FROM [dbo].[TAS_CourseRecord] 
                                              where Id=@id", tAS_CourseRecord);
        }
        #endregion

        #region TAS_ClassesRecord
        public List<TAS_ClassesRecord> GetTAS_ClassesRecordByCourseId(TAS_ClassesRecord tAS_CourseRecord)
        {
            logHelper.InfoLog("",  "GetTAS_ClassesRecordByCourseId");
            return DapperHelper<TAS_ClassesRecord>.Query(@"SELECT *  FROM [dbo].[TAS_ClassesRecord] where CourseID=@CourseID", tAS_CourseRecord);
        }
        public class ByCourseIdsModel
        {
            public int[] ids { get; set; }
        }
        public List<TAS_ClassesRecord> GetTAS_ClassesRecordByCourseIds(ByCourseIdsModel byCourseIdsModel)
        {
            logHelper.InfoLog("",  "GetTAS_ClassesRecordByCourseIds");
            return DapperHelper<TAS_ClassesRecord>.Query(@"SELECT *  FROM [dbo].[TAS_ClassesRecord] where CourseID in @ids", byCourseIdsModel);
        }
        public List<TAS_ClassesRecord> GetTAS_ClassesRecordAll()
        {
            logHelper.InfoLog("",  "GetTAS_ClassesRecordAll");
            return DapperHelper<TAS_ClassesRecord>.Query(@"SELECT * FROM [dbo].[TAS_ClassesRecord]", new object());
        }

        public List<TAS_ClassesRecord> GetTAS_ClassesRecords(TAS_ClassesRecord tAS_CourseRecord)
        {

            logHelper.InfoLog("",  "GetTAS_ClassesRecords");
            return DapperHelper<TAS_ClassesRecord>.Query(@"SELECT * FROM [dbo].[TAS_ClassesRecord] where CourseID=@CourseID and Hours=@Hours and ClasseTitle=@ClasseTitle and UId=@UId and Position=@Position", tAS_CourseRecord);
        }

        public int AddTAS_ClassesRecords(TAS_ClassesRecord tAS_CourseRecord)
        {
            logHelper.InfoLog("",  "AddTAS_ClassesRecords");
            return DapperHelper<TAS_ClassesRecord>.Execute(@"INSERT INTO [dbo].[TAS_ClassesRecord]
           ([CourseID]
           ,[Hours]
           ,[ClasseTitle]
           ,[UId]
           ,[Position])
     VALUES
           (@CourseID
           ,@Hours
           ,@ClasseTitle
           ,@UId
           ,@Position)", tAS_CourseRecord);
        }
        #endregion
    }
}
