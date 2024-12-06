CREATE PROCEDURE [dbo].[AgregarReserva]
    @SalaID INT,
    @FechaReserva DATETIME,
    @Usuario VARCHAR(100)
AS
BEGIN
    INSERT INTO Reservas (SalaID, FechaReserva, Usuario)
    VALUES (@SalaID, @FechaReserva, @Usuario);
END;
