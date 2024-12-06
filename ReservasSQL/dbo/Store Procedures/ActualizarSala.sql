CREATE PROCEDURE [dbo].[ActualizarSala]
    @ID INT,
    @Nombre VARCHAR(80),
    @Capacidad INT,
    @Disponibilidad BIT
AS
BEGIN
    UPDATE Salas
    SET Nombre = @Nombre,
        Capacidad = @Capacidad,
        Disponibilidad = @Disponibilidad
    WHERE ID = @ID;
END;