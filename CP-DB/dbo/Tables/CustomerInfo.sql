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