
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[CustomerID] [int] NULL,
	[TaxiID] [int] NULL,
	[BookingDate] [date] NOT NULL,
	[TripDate] [date] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[SourceAddress] [varchar](100) NOT NULL,
	[DestinationAddress] [varchar](100) NOT NULL,
	[FeedBack] [varchar](100) NULL,
	[Fare] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[PhoneNumber] [char](10) NOT NULL,
	[EmailID] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](100) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](10) NOT NULL,
	[EmailID] [varchar](100) NOT NULL,
	[Address] [varchar](300) NOT NULL,
	[DrivingLicenseNumber] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeRoster]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRoster](
	[RosterID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[FromDate] [date] NOT NULL,
	[ToDate] [date] NOT NULL,
	[InTime] [time](7) NOT NULL,
	[OutTime] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RosterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Taxi]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Taxi](
	[TaxiID] [int] NOT NULL,
	[TaxiModel] [varchar](30) NOT NULL,
	[Color] [varchar](10) NOT NULL,
	[Registration Number] [varchar](10) NOT NULL,
	[TaxiType] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaxiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[LoginID] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[EmployeeID] [int] NULL,
	[CustomerID] [int] NULL,
	[Role] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1004, 1, 16, 1, CAST(N'2021-03-28' AS Date), CAST(N'2021-04-02' AS Date), CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), N'saf', N'sacdsa', NULL, 100.0000)
INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1005, 1, 16, 2, CAST(N'2021-03-28' AS Date), CAST(N'2021-03-28' AS Date), CAST(N'03:00:00' AS Time), CAST(N'10:00:00' AS Time), N'sss', N'ddd', NULL, 100.0000)
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (1, N'Naveen', N'8908471454', N'Nave@gmail.com', N'Bhubaneswar')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (2, N'Ravi', N'7988471454', N'Ravi@gmail.com', N'Chennai')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (3, N'Mohinder', N'8908176454', N'Mohan@gmail.com', N'Bangalore')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (4, N'Manav', N'9338226002', N'Manu@gmail.com', N'Hyderabad')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (5, N'Amrita Anindita', N'8847832808', N'a@gmail.com', N'dfghj')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (6, N'Amrita', N'8797832808', N'b@gmail.com', N'cuttack')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (8, N'am', N'9437771669', N'c@gmail.com', N'hgfd')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (9, N'ARNAB', N'8847858918', N'C@GMAIL.COM', N'CDA,CUTTACK')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (11, N'Ani', N'6147258369', N'f@gmail.com', N'bbsr')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (13, N'Subham', N'8900002222', N'a@abc.com', N'Cuttack')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (14, N'Hello World', N'8900000122', N'a@abc.com', N'cuttack')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (16, N'Test', N'6777788888', N'a@abc.com', N'sfsadfdsaf')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (17, N'Ar', N'6549873219', N'a@gmail.com', N'cda')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (19, N'Amrita Anindita', N'6122232142', N'a@234.com', N'sadsad')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [EmailID], [Address]) VALUES (21, N'Arun', N'8879321654', N'a@gmail.com', N'cda')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Designation], [PhoneNumber], [EmailID], [Address], [DrivingLicenseNumber]) VALUES (1, N'Abhi', N'Driver', N'9178472707', N'abhi@gmail.com', N'Bhubaneswar', N'OD1234567892323')
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Designation], [PhoneNumber], [EmailID], [Address], [DrivingLicenseNumber]) VALUES (2, N'Rahul', N'Driver', N'8978472707', N'rv@gmail.com', N'Chennai', N'CH2234567892367')
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Designation], [PhoneNumber], [EmailID], [Address], [DrivingLicenseNumber]) VALUES (3, N'Siv', N'Driver', N'6978479707', N'siv@gmail.com', N'Bangalore', N'KA2234897892367')
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Designation], [PhoneNumber], [EmailID], [Address], [DrivingLicenseNumber]) VALUES (4, N'Ram', N'Driver', N'9237000076', N'Rami@gmail.com', N'Hyderabad', N'HD1234566789239')
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[EmployeeRoster] ON 

INSERT [dbo].[EmployeeRoster] ([RosterID], [EmployeeID], [FromDate], [ToDate], [InTime], [OutTime]) VALUES (1, 1, CAST(N'2021-03-15' AS Date), CAST(N'2021-03-21' AS Date), CAST(N'12:30:00' AS Time), CAST(N'01:20:00' AS Time))
INSERT [dbo].[EmployeeRoster] ([RosterID], [EmployeeID], [FromDate], [ToDate], [InTime], [OutTime]) VALUES (2, 2, CAST(N'2021-03-14' AS Date), CAST(N'2021-03-20' AS Date), CAST(N'02:30:00' AS Time), CAST(N'03:20:00' AS Time))
INSERT [dbo].[EmployeeRoster] ([RosterID], [EmployeeID], [FromDate], [ToDate], [InTime], [OutTime]) VALUES (3, 3, CAST(N'2021-03-13' AS Date), CAST(N'2021-03-19' AS Date), CAST(N'03:30:00' AS Time), CAST(N'04:20:00' AS Time))
SET IDENTITY_INSERT [dbo].[EmployeeRoster] OFF
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (1, N'Datson_Go', N'Blue', N'OD 02 9620', N'Micro')
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (2, N'Toyota_Etios', N'Red', N'OD 02 2012', N'Sedan')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'', N'', NULL, 17, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Abhi', N'Hello123', NULL, NULL, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Amrita', N'Hello123', NULL, 19, N'Customer')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Ar', N'Arnab', NULL, NULL, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Arnab', N'hello123', NULL, NULL, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Arun', N'arun123', NULL, 21, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'ARUN123', N'hklhlkj', NULL, NULL, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'David', N'sdscxcsc', NULL, NULL, N'Customer')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Hello', N'Hello', NULL, 16, N'CUSTOMER')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Rajsam', N'uy544', 1, NULL, N'Employee')
INSERT [dbo].[Users] ([LoginID], [Password], [EmployeeID], [CustomerID], [Role]) VALUES (N'Subham', N'Hello123', NULL, NULL, N'CUSTOMER')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Customer__85FB4E38B3994C76]    Script Date: 29-03-2021 11:46:34 ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Taxi__E851808E3F20E7CA]    Script Date: 29-03-2021 11:46:34 ******/
ALTER TABLE [dbo].[Taxi] ADD UNIQUE NONCLUSTERED 
(
	[Registration Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([TaxiID])
REFERENCES [dbo].[Taxi] ([TaxiID])
GO
ALTER TABLE [dbo].[EmployeeRoster]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [fk_Users_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [fk_Users_CustomerID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [fk_Users_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [fk_Users_EmployeeID]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [chk_mail] CHECK  (([EmailID] like '%_@__%.__%'))
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [chk_mail]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [chk_number] CHECK  (([PhoneNumber] like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [chk_number]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [chk_email] CHECK  (([EmailID] like '%_@__%.__%'))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [chk_email]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [chk_phone] CHECK  (([PhoneNumber] like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [chk_phone]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [chk_Users_Role] CHECK  (([Role]='Employee' OR [ROLE]='Customer'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [chk_Users_Role]
GO
/****** Object:  StoredProcedure [dbo].[usp_FetchDataFromCustomer]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_FetchDataFromCustomer]

as
begin
select * from Customer
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoBooking]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_InsertIntoBooking]
(
@CUSTOMERID INT,
--@BOOKINGDATE DATE ,
@TRIPDATE DATE ,
@STARTTIME TIME ,
@ENDTIME TIME,
@SOURCEADDRESS VARCHAR(100) ,
@DESTINATIONADDRESS VARCHAR(100),
@FARE MONEY 

)
AS
BEGIN
INSERT BOOKING(CUSTOMERID, BOOKINGDATE, TRIPDATE, STARTTIME,ENDTIME, SOURCEADDRESS, DESTINATIONADDRESS,FARE)
VALUES(@CUSTOMERID, CONVERT(DATE, GETDATE()), @TRIPDATE, @STARTTIME,@ENDTIME, @SOURCEADDRESS, @DESTINATIONADDRESS,@FARE)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoCustomer]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_InsertIntoCustomer]
(
@CustomerName	Varchar(50),
@PhoneNumber	Char(10),
@EmailID	Varchar(100),
@Address	Varchar(300)
)
as
begin
insert Customer(CustomerName,PhoneNumber,EmailID,[Address])
values( @CustomerName,@PhoneNumber,@EmailID,@Address)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoEmployee]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_InsertIntoEmployee]
(
 
@EmployeeName varchar(100), 
@Designation Varchar(50), 
@PhoneNumber Char(10),
@EmailID Varchar(100), 
@Address Varchar(300), 
@DrivingLicenseNumber Varchar(15)
)
as
begin
insert Employee values(@EmployeeName,@Designation,@PhoneNumber,@EmailID,@Address,@DrivingLicenseNumber)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoEmployeeRoster]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_InsertIntoEmployeeRoster]
( 
@EmployeeID int,
@FromDate Date,
@ToDate Date, 
@InTime Time,
@OutTime Time
)
as
begin
insert EmployeeRoster values(@EmployeeID ,@FromDate ,@ToDate , @InTime ,@OutTime )
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoUsers]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_InsertIntoUsers]
(
@LoginID varchar(50),
@Password varchar(max),
@EmployeeID int ,
@CustomerID int ,
@Role varchar(8)
)
as
begin
insert Users values(@LoginID, @Password,@EmployeeID,@CustomerID,@Role)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertIntoUsersPass]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_InsertIntoUsersPass]
(

@Password varchar(max)

)
as
return Select * from Users
where
password=@Password

GO
/****** Object:  StoredProcedure [dbo].[usp_InsertUserLogin]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_InsertUserLogin]
(
@LoginID VARCHAR(50),
@Password VARCHAR(MAX),
@Role VARCHAR(8)
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM USERS WHERE LoginID=@LoginID AND [Role]=@Role)
	BEGIN
		INSERT INTO USERS (LoginID,[Password],[Role]) 
		VALUES (@LoginID,@Password,@Role) 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_RegisterCustomer]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_RegisterCustomer]
(
@LoginID VARCHAR(50),
@CustomerID INT
)
AS
BEGIN
	UPDATE  USERS SET CustomerID = @CustomerID 
	WHERE LoginID=@LoginID AND [Role]='CUSTOMER' AND CustomerID IS NULL
END



GO
/****** Object:  StoredProcedure [dbo].[usp_SearchFromEmployeeRoster]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_SearchFromEmployeeRoster]
(
@EmployeeID int
)
as
begin
select RosterID, EmployeeID,FromDate,ToDate,InTime,OutTime from EmployeeRoster where EmployeeID =@EmployeeID 
end
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUsersPassword]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UpdateUsersPassword]
(@LoginID varchar(50), @Password varchar(max))
as
begin
UPDATE Users SET [Password]=@Password WHERE LoginID=@LoginID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_VerifyUserLogin]    Script Date: 29-03-2021 11:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_VerifyUserLogin]
(
@LoginID VARCHAR(50),
@Password VARCHAR(MAX),
@Role VARCHAR(8)
)
AS
BEGIN
	SELECT (CASE WHEN EmployeeID IS NULL THEN 0 ELSE EmployeeID END) AS EmployeeID,
	(CASE WHEN CustomerID IS NULL THEN 0 ELSE CustomerID END) AS CustomerID,
	[Role] 
	FROM USERS 
	WHERE LoginID=@LoginID AND [Password]=@Password AND [Role]=@Role
END

Create PROC usp_InsertIntoUsersEmployee
(
@LoginID varchar(50),
@Password varchar(max),
@EmployeeID int,
@Role varchar(8)
)
as
begin
INSERT INTO Users(LoginID,[Password],EmployeeID,[Role])
values(@LoginID,@Password,@EmployeeID,@Role)
end

CREATE Proc usp_GetCustomerDetails
as
SELECT LoginID, [Password], CustomerID, [Role] FROM Users WHERE EmployeeID IS NULL AND CustomerID IS NOT NULL;

CREATE Proc usp_GetEmployeeDetails
as
SELECT LoginID, [Password], EmployeeID, [Role] FROM Users WHERE CustomerID IS NULL AND EmployeeID IS NOT NULL;

CREATE PROC usp_GetAvailableEmployee
as
begin
SELECT EmployeeName, EmployeeID FROM Employee WHERE EmployeeID IN (SELECT EmployeeID FROM EmployeeRoster WHERE GETDATE()>ToDate)
end

--EXEC usp_GetAvailableEmployee

--SELECT * FROM Employee

CREATE PROC usp_GetEmployeeID
@EmployeeName varchar(100)
as
begin
SELECT EmployeeID FROM Employee WHERE EmployeeName = @EmployeeName
end

create PROC usp_CreateRoster
(
@EmployeeID int,
@FromDate Date,
@ToDate Date,
@InTime Time,
@OutTime Time
)
as
begin
INSERT INTO EmployeeRoster(EmployeeID, FromDate, ToDate, InTime, OutTime)
Values(@EmployeeID, @FromDate, @ToDate, @InTime, @OutTime)
end

EXEC usp_CreateRoster
@EmployeeID=1,
@FromDate= '2021-03-31',
@ToDate = '2021-04-06',
@InTime = '00:00:00',
@OutTime = '00:00:00'

SELECT * FROM EmployeeRoster
CAST(N'2021-03-21' AS Date)

--EXEC usp_GetEmployeeID
--@EmployeeName = 'Rinz'

sp_help EmployeeRoster

SELECT * FROM Booking

sp_help Booking

ALTER TABLE Employee ADD CONSTRAINT unq_employee_phoneNumber UNIQUE (PhoneNumber)

ALTER TABLE Employee ADD CONSTRAINT unq_employee_emailID UNIQUE (EmailID)

ALTER TABLE Employee ADD CONSTRAINT unq_employee_driverLicenceNumber UNIQUE (DrivingLicenseNumber)

ALTER TABLE Customer ADD CONSTRAINT unq_customer_phoneNumber UNIQUE (PhoneNumber)

ALTER TABLE Customer ADD CONSTRAINT unq_customer_emailID UNIQUE (EmailID)

ALTER TABLE Users ADD CONSTRAINT unq_users_loginID UNIQUE (LoginID)

Create proc usp_GetBookingStatus
(
@TripDate datetime
)
as
begin
select * From Booking  where TripDate=@TripDate
end

Create proc usp_TaxiAvailability
as
begin
select * from Taxi where TaxiID Not in (select taxiID from Booking where TaxiID is  not null)
end

exec usp_TaxiAvailability

Create proc usp_UpdateBooking
(
@EmployeeID int ,
@TaxiID int,
@BookingID int
)
as
update Booking set EmployeeID=@EmployeeID, TaxiID=@TaxiID where BookingID=@BookingID

create proc usp_GetAllemployeeRoaster
(
@EmployeeID int
)
as
begin 
Select * from EmployeeRoster where EmployeeID=@EmployeeID 
end

Create proc usp_AvailableBooking
as
begin
select * from Booking where EmployeeID is null and TaxiID is null
end

exec usp_AvailableBooking

SET IDENTITY_INSERT [dbo].[Booking] ON 
INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1008, Null, 16, null, CAST(N'2021-04-03' AS Date), CAST(N'2021-04-06' AS Date), CAST(N'11:00:00' AS Time), CAST(N'22:00:00' AS Time), N'Manpur', N'Gaya', NULL, 104.0000)
INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1009, Null, 16, null, CAST(N'2021-04-05' AS Date), CAST(N'2021-04-05' AS Date), CAST(N'2:00:00' AS Time), CAST(N'4:00:00' AS Time), N'Nard', N'Gaya', NULL, 145.0000)
INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1111, Null, 16, null, CAST(N'2021-04-06' AS Date), CAST(N'2021-04-07' AS Date), CAST(N'1:00:00' AS Time), CAST(N'4:00:00' AS Time), N'Shrtm', N'Gaya', NULL, 123.0000)
INSERT [dbo].[Booking] ([BookingID], [EmployeeID], [CustomerID], [TaxiID], [BookingDate], [TripDate], [StartTime], [EndTime], [SourceAddress], [DestinationAddress], [FeedBack], [Fare]) VALUES (1011, Null, 16, null, CAST(N'2021-04-07' AS Date), CAST(N'2021-04-08' AS Date), CAST(N'3:00:00' AS Time), CAST(N'4:00:00' AS Time), N'Cherk', N'Gaya', NULL, 105.0000)

INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (3, N'alto', N'Red', N'OD 02 2013', N'mini')
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (4, N'ITEN', N'White', N'OD 04 2013', N'mini')
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (5, N'safari', N'Red', N'OD 03 2013', N'Sedan')
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (6, N'Harrier', N'Black', N'OD 03 2017', N'Suv')
INSERT [dbo].[Taxi] ([TaxiID], [TaxiModel], [Color], [Registration Number], [TaxiType]) VALUES (7, N'MGHector', N'White', N'BR 04 2013', N'Suv')

SELECT * FROM Users

create proc usp_GetWeeklyOrMonthlyBookingReport
(
@FromDate date,
@ToDate date
)
as
begin
select * From Booking where BookingDate between @FromDate and @ToDate
end

Create proc usp_GetDailyBookingReport
as
begin
select * From Booking where BookingDate = GetDate()
end
select * from Users