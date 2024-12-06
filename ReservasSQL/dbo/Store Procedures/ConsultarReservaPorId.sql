CREATE PROCEDURE [dbo].[ConsultarReservaPorId]
    @ID INT
AS
    SELECT R.ID, R.SalaID, R.FechaReserva, R.Usuario, S.Nombre AS NombreSala
    FROM Reservas R
    INNER JOIN Salas S ON R.SalaID = S.ID
    WHERE R.ID = @ID;
RETURN 0
