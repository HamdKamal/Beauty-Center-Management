SELECT 
SUM(DATEDIFF(MINUTE,Entery_Date,Attend_Time)) SUM_IN_MINUTE,
SUM(DATEDIFF(HOUR,Entery_Date,Attend_Time)) SUM_IN_HOUR 
FROM dbo.TBL_Attendance WHERE EmpID = 1 