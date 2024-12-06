CREATE PROCEDURE [dbo].[AgregarSala]
    @Nombre VARCHAR(100),
    @Capacidad INT,
    @Disponibilidad BIT
AS
BEGIN
    INSERT INTO Salas (Nombre, Capacidad, Disponibilidad)
    VALUES (@Nombre, @Capacidad, @Disponibilidad);
END;
