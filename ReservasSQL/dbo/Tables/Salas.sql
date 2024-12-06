CREATE TABLE Salas (
    ID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(80) NOT NULL,
    Capacidad INT NOT NULL,
    Disponibilidad BIT NOT NULL
);