CREATE PROCEDURE [dbo].[ConsultarSalaPorId]
    @ID INT
AS
BEGIN
    SELECT * FROM Salas WHERE ID = @ID;
END;