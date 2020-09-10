CREATE DATABASE BDViajesTerrestres
GO
USE BDViajesTerrestres
GO
CREATE TABLE Bus(
BusId INT IDENTITY PRIMARY KEY,
Placa VARCHAR(6),
Capacidad INT,
)
GO
CREATE TABLE Pasajero(
PasajeroId INT IDENTITY PRIMARY KEY,
NombrePasajero VARCHAR(30),
Tapabocas BIT,
)
GO
CREATE TABLE Municipio(
MunicipioId INT IDENTITY PRIMARY KEY,
NombreMunicipio VARCHAR(30),
)
GO
CREATE TABLE Conductor(
ConductorId INT IDENTITY PRIMARY KEY,
BusRefId INT ,
NombreConductor VARCHAR(30) 
CONSTRAINT RelacionConductorBus FOREIGN KEY (BusRefId) REFERENCES Bus (BusId),
)
GO
CREATE TABLE Ruta(
RutaId INT IDENTITY PRIMARY KEY,
MunicipioOrigenId INT ,
MunicipioDestinoId INT ,
BusRefId INT
CONSTRAINT RelacionRutaMunicipioOrigen FOREIGN KEY (MunicipioOrigenId) REFERENCES Municipio (MunicipioId),
CONSTRAINT RelacionRutaMunicipioDestino FOREIGN KEY (MunicipioDestinoId) REFERENCES Municipio (MunicipioId),
CONSTRAINT RelacionRutaBus FOREIGN KEY (BusRefId) REFERENCES Bus (BusId),
)
GO
CREATE TABLE Escala(
EscalaId INT IDENTITY PRIMARY KEY,
RutaRefId INT ,
ParadaEscala INT
CONSTRAINT RelacionEscalaRuta FOREIGN KEY (RutaRefId) REFERENCES Ruta (RutaId),
)
GO
CREATE TABLE Ticket(
TicketId INT IDENTITY PRIMARY KEY,
PasajeroRefId INT ,
RutaRefId INT ,
NumeroDeSilla INT
CONSTRAINT RelacionTicketPasajero FOREIGN KEY (PasajeroRefId) REFERENCES Pasajero (PasajeroId),
CONSTRAINT RelacionTicketRuta FOREIGN KEY (RutaRefId) REFERENCES ruta (RutaId),
)
GO

use master
drop database BDViajesTerrestres
go

select * from Municipio