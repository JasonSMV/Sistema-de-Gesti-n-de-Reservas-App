﻿CREATE PROCEDURE [dbo].[EliminarSala]
    @ID INT
AS
BEGIN
    DELETE FROM Salas WHERE ID = @ID;
END;