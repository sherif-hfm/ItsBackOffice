
Declare @SqlStr nvarchar(MAX)
Set @SqlStr='
Select Sec_Users.UserID,Sec_Users.UserLogin,Sec_Users.Name_Ara,Sec_Users.Name_Eng,Sec_Users.Password,Sec_Users.IsAdmin,
Sec_UsersGroup.GroupID
from Sec_Users
left outer  join Sec_UsersGroup on Sec_Users.UserID=Sec_UsersGroup.UserID
'
update Srch_SearchMaster set SearchSQL_Ara=@SqlStr,SearchSQL_Eng=@SqlStr where SearchID=1