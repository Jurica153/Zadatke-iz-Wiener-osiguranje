CREATE TABLE Partneri2 (
	id INT NOT NULL PRIMARY KEY IDENTITY,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	Address VARCHAR(30) NULL,
	PartnerNumber VARCHAR(20) NOT NULL,
	CroatianPIN VARCHAR(20) NOT NULL,
	PartnerTypeID INT NOT NULL,
	CreatedAtUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	CreatedByUser VARCHAR(255) NOT NULL,
	IsForeign VARCHAR(20) NOT NULL,
	ExternalCode VARCHAR(20) NOT NULL,
	Gender VARCHAR(2) NOT NULL
);

INSERT INTO Partneri2(FirstName, LastName, Address, PartnerNumber, CroatianPIN, PartnerTypeID, CreatedAtUtc, CreatedByUser, IsForeign, ExternalCode, Gender)
VALUES('Ivo', 'Ivic', 'Tomislamova 1, Zagreb', '1', '123456789', '1', '2005/8/25', 'ivoivic@gmail.com', '1', '123456789', 'M');