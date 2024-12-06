CREATE PROCEDURE [dbo].[ActualizarReserva]
    @ID INT,
    @SalaID INT,
    @FechaReserva DATETIME,
    @Usuario VARCHAR(100)
AS
BEGIN
    UPDATE Reservas
    SET SalaID = @SalaID,
        FechaReserva = @FechaReserva,
        Usuario = @Usuario
    WHERE ID = @ID;
END;