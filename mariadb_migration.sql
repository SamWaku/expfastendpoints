CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

CREATE DATABASE IF NOT EXISTS `public`
START TRANSACTION;
CREATE TABLE `investment_houses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CompanyName` longtext NULL,
    `InstitutionType` longtext NULL,
    `CompanyRegistrationNumber` longtext NULL,
    `Tpin` longtext NULL,
    `CountryOfIncorporation` longtext NULL,
    `DateOfIncorporation` date NOT NULL,
    `PhysicalAddress` longtext NULL,
    `PostalAddress` longtext NULL,
    `TelephoneNumber` longtext NULL,
    `MobileNumber` longtext NULL,
    `EmailAddress` longtext NULL,
    `CertificateOfIncorporation` tinyint(1) NULL,
    `TaxClearanceCertificate` tinyint(1) NULL,
    `TradingLicense` tinyint(1) NULL,
    `Financials` tinyint(1) NULL,
    `DateCreated` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ContactPerson` (
    `InvestmentHouseId` int NOT NULL,
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` longtext NULL,
    `Phone` longtext NULL,
    `Email` longtext NULL,
    `Position` longtext NULL,
    PRIMARY KEY (`InvestmentHouseId`, `Id`),
    CONSTRAINT `FK_ContactPerson_investment_houses_InvestmentHouseId` FOREIGN KEY (`InvestmentHouseId`) REFERENCES `investment_houses` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Director` (
    `InvestmentHouseId` int NOT NULL,
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` longtext NULL,
    `Phone` longtext NULL,
    `Email` longtext NULL,
    `Position` longtext NULL,
    PRIMARY KEY (`InvestmentHouseId`, `Id`),
    CONSTRAINT `FK_Director_investment_houses_InvestmentHouseId` FOREIGN KEY (`InvestmentHouseId`) REFERENCES `investment_houses` (`Id`) ON DELETE CASCADE
);

COMMIT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617100023_investmenthousenewfields', '9.0.5');

START TRANSACTION;
ALTER TABLE `investment_houses` DROP COLUMN `CompanyName`;

ALTER TABLE `investment_houses` DROP COLUMN `MobileNumber`;

ALTER TABLE `investment_houses` DROP COLUMN `PhysicalAddress`;

ALTER TABLE `investment_houses` MODIFY `Tpin` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `TelephoneNumber` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `PostalAddress` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `InstitutionType` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `EmailAddress` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `CountryOfIncorporation` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` MODIFY `CompanyRegistrationNumber` longtext NOT NULL DEFAULT '';

ALTER TABLE `investment_houses` ADD `Address` longtext NOT NULL;

ALTER TABLE `investment_houses` ADD `ContactNumber` longtext NOT NULL;

ALTER TABLE `investment_houses` ADD `Name` longtext NOT NULL;

ALTER TABLE `Director` MODIFY `Position` longtext NOT NULL DEFAULT '';

ALTER TABLE `Director` MODIFY `Phone` longtext NOT NULL DEFAULT '';

ALTER TABLE `Director` MODIFY `Name` longtext NOT NULL DEFAULT '';

ALTER TABLE `Director` MODIFY `Email` longtext NOT NULL DEFAULT '';

ALTER TABLE `ContactPerson` MODIFY `Position` longtext NOT NULL DEFAULT '';

ALTER TABLE `ContactPerson` MODIFY `Phone` longtext NOT NULL DEFAULT '';

ALTER TABLE `ContactPerson` MODIFY `Name` longtext NOT NULL DEFAULT '';

ALTER TABLE `ContactPerson` MODIFY `Email` longtext NOT NULL DEFAULT '';

CREATE TABLE `fixed_term_deposits` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Amount` double NOT NULL,
    `InvestmentHouseId` int NOT NULL,
    `InterestRate` double NOT NULL,
    `Tenure` int NOT NULL,
    `StartDate` date NOT NULL,
    `MaturityDate` date NOT NULL,
    `InterestAmount` double NOT NULL,
    `MaturityAmount` double NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    `DateCreated` datetime(6) NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_fixed_term_deposits_investment_houses_InvestmentHouseId` FOREIGN KEY (`InvestmentHouseId`) REFERENCES `investment_houses` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_fixed_term_deposits_InvestmentHouseId` ON `public`.`fixed_term_deposits` (`InvestmentHouseId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617100755_investmenthousenewfieldsnew', '9.0.5');

ALTER TABLE `investment_houses` MODIFY `Tpin` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `TelephoneNumber` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `PostalAddress` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `Name` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `InstitutionType` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `EmailAddress` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `DateOfIncorporation` date NULL;

ALTER TABLE `investment_houses` MODIFY `CountryOfIncorporation` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `ContactNumber` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `CompanyRegistrationNumber` longtext NULL;

ALTER TABLE `investment_houses` MODIFY `Address` longtext NULL;

ALTER TABLE `Director` MODIFY `Position` longtext NULL;

ALTER TABLE `Director` MODIFY `Phone` longtext NULL;

ALTER TABLE `Director` MODIFY `Name` longtext NULL;

ALTER TABLE `Director` MODIFY `Email` longtext NULL;

ALTER TABLE `ContactPerson` MODIFY `Position` longtext NULL;

ALTER TABLE `ContactPerson` MODIFY `Phone` longtext NULL;

ALTER TABLE `ContactPerson` MODIFY `Name` longtext NULL;

ALTER TABLE `ContactPerson` MODIFY `Email` longtext NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617101259_investmenthousenewfieldsnullable', '9.0.5');

ALTER TABLE `investment_houses` MODIFY `UpdatedAt` datetime(6) NULL;

ALTER TABLE `investment_houses` MODIFY `DateCreated` datetime(6) NULL;

ALTER TABLE `fixed_term_deposits` MODIFY `DateCreated` datetime(6) NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617102214_investmenthousenewfieldsnullable1', '9.0.5');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617102507_investmenthousenewfieldsnullable2', '9.0.5');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617103207_investmenthousenewfieldsnullable3', '9.0.5');

ALTER TABLE investment_houses RENAME investment_houses;

ALTER TABLE fixed_term_deposits RENAME fixed_term_deposits;

ALTER TABLE Director RENAME Director;

ALTER TABLE ContactPerson RENAME ContactPerson;

ALTER TABLE `fixed_term_deposits` MODIFY `DateCreated` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617104620_investmenthousenewfieldsnullable4', '9.0.5');

ALTER TABLE `fixed_term_deposits` DROP CONSTRAINT `FK_fixed_term_deposits_investment_houses_InvestmentHouseId`;

ALTER TABLE fixed_term_deposits RENAME FixedTermDeposit;

ALTER TABLE `FixedTermDeposit` RENAME INDEX `IX_fixed_term_deposits_InvestmentHouseId` TO `IX_FixedTermDeposit_InvestmentHouseId`;

ALTER TABLE `FixedTermDeposit` ADD CONSTRAINT `FK_FixedTermDeposit_investment_houses_InvestmentHouseId` FOREIGN KEY (`InvestmentHouseId`) REFERENCES `investment_houses` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617110143_investmenthousenewfieldsnullable5', '9.0.5');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617130206_investmenthousenewfieldsnullable7', '9.0.5');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617130846_investmenthousenewfieldsnullable8', '9.0.5');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250617131425_AddInvestmentHouseFields', '9.0.5');

COMMIT;

