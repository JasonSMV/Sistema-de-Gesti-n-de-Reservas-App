CREATE PROCEDURE [dbo].[EliminarReserva]
    @ID INT
AS
BEGIN
    DELETE FROM Reservas WHERE ID = @ID;
END;
