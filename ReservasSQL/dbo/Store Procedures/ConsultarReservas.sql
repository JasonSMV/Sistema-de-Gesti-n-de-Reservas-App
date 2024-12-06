CREATE PROCEDURE [dbo].[ConsultarReservas]
AS
BEGIN
    SELECT R.ID, R.SalaID, R.FechaReserva, R.Usuario, S.Nombre AS NombreSala
    FROM Reservas R
    INNER JOIN Salas S ON R.SalaID = S.ID;
END;
