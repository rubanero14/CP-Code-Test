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