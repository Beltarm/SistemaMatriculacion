 USE Sistema_matriculacion

                GO
	             
				CREATE TRIGGER cantidad_estudiantes
				ON ESTUDIANTE_SECCION
				For INSERT 
				AS
				UPDATE dbo.SECCION
				SET CANTIDAD_ESTUDIANTES= CANTIDAD_ESTUDIANTES + 1
				FROM dbo.SECCION INNER JOIN Inserted
				ON  dbo.SECCION.ID_SECCION =  Inserted.ID_SECCION

				GO

