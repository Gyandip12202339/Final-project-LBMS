Create procedure sp_Login
@Username nvarchar(20),
@Password nvarchar(20)
AS
Begin 
Select* From Login where Username= @Username  
 and Password= @Password
 END