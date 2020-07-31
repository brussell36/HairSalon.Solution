![Bright hair salon](https://andreashogue.com/images/slide-home-1.jpg)
# Eau Claire's Salon

#### C# Friday Independant Project, 07.31.2020

## By Benjamin Russell

## Description

_This application will help a salon owner keep track of all the stylists who work in their salon and all the clients each stylist works with. The owner will be able to see a list of all stylists, their details and the clients they work with. The owner will also be able to add new stylists when they are hired and should be able to remove stylists who no longer work there._

## Setup/Installation Requirements

* Clone this repository from GitHub https://github.com/brussell36/HairSalon.Solution
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) 
* To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
* Run dotnet restore in terminal to get all dependencies.
* Run the program with the command dotnet run.

#### Additional Setup/Installation Notes:

* You will need to have MySQL installed on your computer to start the database for this project. 
* Once you have it installed open your terminal and run mysql -uroot -pepicodus. This will start the mysql server on your computer. 
* With mysql running in your terminal copy/paste the code snippet below.

```DROP DATABASE IF EXISTS `benjamin_russell`;
CREATE DATABASE `benjamin_russell`;

USE DATABASE `benjamin_russell`;

CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `ClientName` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  `Appointment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;```

* Then you will have the database correctly set up and you can start the project in a separate terminal that the one running mysql by running dotnet run.

## Specifications

| Behavior | Input | Output |
| -------- | ----- | ------ |
| 1. The salon owner will be able to see a list of stylists |  | List of all stylists |
| 2. Allow owner to select a stylist, see their details and a list of clients associated with that stylist |  | Anna's details and clients |
| 3. Allow owner to add new stylists to system as they are hired | Name: Lisa Specialty: Coloring  | Lisa's details and clients |
| 4. Add clients to a specific stylist, should not be able to add a client if no stylists have been added | Anna's client list |  |


## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

Please feel free to contact me through GitHub (username: brussell36) with any questions, ideas or concerns.  

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 
* MySQL Workbench
* MySQL Database
* Entity Framework


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Russell_**