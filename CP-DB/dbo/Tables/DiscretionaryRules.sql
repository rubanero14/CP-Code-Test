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