CREATE TABLE [DiscretionaryRules](
	[DiscretionaryRuleID] [int] IDENTITY(-999999999,1) NOT NULL,
	[ConsultantID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Rules] [xml] NULL,
	[CustomerBuy] [bit] NULL,
	[CustomerSell] [bit] NULL,
	[ConsultantBuy] [bit] NULL,
	[ConsultantSell] [bit] NULL,
 CONSTRAINT [PK_Discretion] PRIMARY KEY CLUSTERED 
(
	[DiscretionaryRuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [CustomerInfo](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[ConsultantId] [int] NULL,
	[FirstName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Address] [nvarchar](150) NULL,
	[Gender] [nvarchar](20) NULL,
	[DOB] [date] NULL,
	[MobileNo] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 

CREATE TABLE [ConsultantInfo](
	[ConsultantInfoId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](255) NULL,
	[MobileNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_ConsultantInfo] PRIMARY KEY CLUSTERED 
(
	[ConsultantInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 

INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('1','1','<DiscretionaryRules xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" CustomerBuy="false" CustomerSell="false" ConsultantBuy="false" ConsultantSell="false" />',0,0,0,0)

INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('1','2','<DiscretionaryRules xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" CustomerBuy="true" CustomerSell="false" ConsultantBuy="true" ConsultantSell="false" />',0,0,0,0)

INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('2','3',null,0,0,0,0)

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(1,'John','Dow','PJ','M','1973-03-12','0123456789','john@dow.com')

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(1,'Sheila','James','KL','F','1993-09-22','0172257789','sheila@james.com')

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(2,'Patrick','Squid','Subang','M','2001-01-03','0164264553','patrick@squid.com')

INSERT INTO [ConsultantInfo](FirstName,LastName,EmailAddress,MobileNo)
VALUES('Kylian','George','kylian@george.com','0122133311')

INSERT INTO [ConsultantInfo](FirstName,LastName,EmailAddress,MobileNo)
VALUES('Karen','Smith','karen@smith.com','0163356711')