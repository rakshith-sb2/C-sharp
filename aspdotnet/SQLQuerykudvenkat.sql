CREATE TABLE [dbo].[tblUsers]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[UserName] nvarchar(100),
	[Password] nvarchar(200),
	[Email] nvarchar(200)
)


CREATE PROC spRegisterUser 
@UserName NVARCHAR(100),
@Password NVARCHAR(200),
@Email NVARCHAR(200)
AS
BEGIN
DECLARE @Count INT
DECLARE @ReturnCode INT

SELECT @Count = COUNT(UserName)
FROM tblUsers
WHERE UserName = @UserName

IF @Count > 0
BEGIN
SET @ReturnCode = - 1
END
ELSE
BEGIN
SET @ReturnCode = 1

INSERT INTO tblUsers
VALUES (
@UserName
,@Password
,@Email
)
END

SELECT @ReturnCode AS ReturnValue
END

Create Procedure spAuthenticateUser
@UserName nvarchar(100),
@Password nvarchar(100)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(UserName) from tblUsers
 where [UserName] = @UserName and [Password] = @Password
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End