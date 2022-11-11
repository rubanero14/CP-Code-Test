
INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('1','1','<DiscretionaryRules xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" CustomerBuy="false" CustomerSell="false" ConsultantBuy="false" ConsultantSell="false" />',0,0,0,0)
GO

INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('1','2','<DiscretionaryRules xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" CustomerBuy="true" CustomerSell="false" ConsultantBuy="true" ConsultantSell="false" />',0,0,0,0)
GO

INSERT INTO [DiscretionaryRules](ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell)
VALUES('2','3',null,0,0,0,0)
GO

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(1,'John','Dow','PJ','M','1973-03-12','0123456789','john@dow.com')
GO

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(1,'Sheila','James','KL','F','1993-09-22','0172257789','sheila@james.com')
GO

INSERT INTO [CustomerInfo](ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress)
VALUES(2,'Patrick','Squid','Subang','M','2001-01-03','0164264553','patrick@squid.com')
GO

INSERT INTO [ConsultantInfo](FirstName,LastName,EmailAddress,MobileNo)
VALUES('Kylian','George','kylian@george.com','0122133311')
GO

INSERT INTO [ConsultantInfo](FirstName,LastName,EmailAddress,MobileNo)
VALUES('Karen','Smith','karen@smith.com','0163356711')
GO
