CREATE PROCEDURE [dbo].[FiltrarReservas]
    @SalaID INT = NULL,
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.ID,
        s.Nombre AS NombreSala,
        r.FechaReserva,
        r.Usuario
    FROM 
        Reservas r
    INNER JOIN 
        Salas s ON r.SalaID = s.ID
    WHERE 
        (@SalaID IS NULL OR r.SalaID = @SalaID)
        AND (@FechaDesde IS NULL OR r.FechaReserva >= @FechaDesde)
        AND (@FechaHasta IS NULL OR r.FechaReserva <= @FechaHasta)
    ORDER BY 
        r.FechaReserva DESC;
END;
