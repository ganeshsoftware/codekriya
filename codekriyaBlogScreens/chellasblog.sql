CREATE TABLE Member
(
ID INT PRIMARY KEY NONCLUSTERED IDENTITY(1,1),
Name VARCHAR(100) NOT NULL,
MailID VARCHAR(100) NOT NULL,
MobileNumber VARCHAR(20) NOT NULL,
Location VARCHAR(50) NOT NULL,
DOB VARCHAR(20) NOT NULL,
UserID VARCHAR(50) NOT NULL,
[Password] VARCHAR(50) NOT NULL,
IsActive CHAR(1) NOT NULL
)


INSERT INTO Member(Name,MailID,MobileNumber,Location,DOB,UserID,[Password],IsActive) 
VALUES 
('Ganesh N','ganeshsoftarch@gmail.com','9845564427','Bengaluru','11101974','ganeshn','ganeshn@123','y')

INSERT INTO Member(Name,MailID,MobileNumber,Location,DOB,UserID,[Password],IsActive) 
VALUES 
('Padmapriya Ganesh','padmaganeshbiochem@gmail.com','9902293549','Bengaluru','24041982','priyag','Yogiram2411','y')

INSERT INTO Member(Name,MailID,MobileNumber,Location,DOB,UserID,[Password],IsActive) 
VALUES 
('User 1','user1@gmail.com','5555555555','Bengaluru','01121930','user1','user1@123','y')

INSERT INTO Member(Name,MailID,MobileNumber,Location,DOB,UserID,[Password],IsActive) 
VALUES 
('User 2','user2@gmail.com','7777777777','Bengaluru','01121930','user2','user2@123','y')



CREATE PROCEDURE MemberAuth(@UserID VARCHAR(50), @Pass VARCHAR(50))
AS
BEGIN
	SELECT * FROM Member WHERE UserID=@UserID and [Password] = @Pass
END



CREATE PROCEDURE MemberRegister(
@v_Name VARCHAR(100), 
@v_MailID VARCHAR(100), 
@v_MobileNumber VARCHAR(20),
@v_Location VARCHAR(50),
@v_DOB VARCHAR(20),
@v_UserID VARCHAR(50),
@v_Password VARCHAR(50),
)
AS
BEGIN
INSERT INTO Member(Name, MailID, MobileNumber,Location,DOB,UserID,[Password],IsActive) 
VALUES
(@v_Name,@v_MailID, @v_MobileNumber,@v_Location,@v_DOB,@v_UserID,@v_Password,'Y') 
END


