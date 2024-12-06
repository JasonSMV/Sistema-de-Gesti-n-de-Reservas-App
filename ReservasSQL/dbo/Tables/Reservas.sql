﻿CREATE TABLE Reservas (
    ID INT PRIMARY KEY IDENTITY,
    SalaID INT NOT NULL FOREIGN KEY REFERENCES Salas(ID),
    FechaReserva DATETIME NOT NULL DEFAULT GETDATE(),
    Usuario VARCHAR(100) NOT NULL
);