-- Validar disponibilidad de una sala
CREATE PROCEDURE [dbo].[ValidarDisponibilidad]
    @SalaID INT,
    @FechaReserva DATETIME
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Reservas
        WHERE SalaID = @SalaID AND FechaReserva = @FechaReserva
    )
        SELECT 0 AS Disponible; -- No disponible
    ELSE
        SELECT 1 AS Disponible; -- Disponible
END;
