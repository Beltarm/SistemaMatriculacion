 

INSERT INTO dbo.ESTUDIANTE
(
    MATRICULA,
    NOMBRE_ESTUDIANTE,
    APELLIDO_ESTUDIANTE,
    FECHA_NACIMIENTO_ESTUDIANTE,
    SEXO_ESTUDIANTE,
    DIRECCION_ESTUDIANTE
)
VALUES
(   '1',        -- MATRICULA - varchar(8)
    'Enmanuel',        -- NOMBRE_ESTUDIANTE - varchar(20)
    'Reyes',        -- APELLIDO_ESTUDIANTE - varchar(20)
    '2005-05-12', -- FECHA_NACIMIENTO_ESTUDIANTE - date
    'M',        -- SEXO_ESTUDIANTE - varchar(1)
    'Los tres brazos'         -- DIRECCION_ESTUDIANTE - varchar(200)

)


INSERT INTO dbo.ESTUDIANTE
(
    MATRICULA,
    NOMBRE_ESTUDIANTE,
    APELLIDO_ESTUDIANTE,
    FECHA_NACIMIENTO_ESTUDIANTE,
    SEXO_ESTUDIANTE,
    DIRECCION_ESTUDIANTE
)
VALUES
(   '2',        -- MATRICULA - varchar(8)
    'Esteban',        -- NOMBRE_ESTUDIANTE - varchar(20)
    'Rodriguez',        -- APELLIDO_ESTUDIANTE - varchar(20)
    '2003-02-16', -- FECHA_NACIMIENTO_ESTUDIANTE - date
    'M',        -- SEXO_ESTUDIANTE - varchar(1)
    'Alma Rosa #56'         -- DIRECCION_ESTUDIANTE - varchar(200)
    )

	
INSERT INTO dbo.ESTUDIANTE
(
    MATRICULA,
    NOMBRE_ESTUDIANTE,
    APELLIDO_ESTUDIANTE,
    FECHA_NACIMIENTO_ESTUDIANTE,
    SEXO_ESTUDIANTE,
    DIRECCION_ESTUDIANTE
)
VALUES
(   '3',        -- MATRICULA - varchar(8)
    'Pamela',        -- NOMBRE_ESTUDIANTE - varchar(20)
    'Alcántara',        -- APELLIDO_ESTUDIANTE - varchar(20)
    '2009-07-22', -- FECHA_NACIMIENTO_ESTUDIANTE - date
    'F',        -- SEXO_ESTUDIANTE - varchar(1)
    'Las Palmeras #32'         -- DIRECCION_ESTUDIANTE - varchar(200)
    )


		
	INSERT INTO dbo.TUTOR
	(
	    CEDULA_TUTOR,
	    NOMBRE_TUTOR,
	    APELLIDO_TUTOR,
	    RELACION_ESTUDIANTE,
	    SEXO_TUTOR,
	    TELEFONO
	)
	VALUES
	(   '00177777777', -- CEDULA_TUTOR - varchar(11)
	    'Madeline', -- NOMBRE_TUTOR - varchar(15)
	    'Pineda', -- APELLIDO_TUTOR - varchar(15)
	    'Madre', -- RELACION_ESTUDIANTE - varchar(10)
	    'F', -- SEXO_TUTOR - varchar(1)
	    '8098954747'  -- TELEFONO - varchar(10)
	    )


		
	INSERT INTO dbo.TUTOR
	(
	    CEDULA_TUTOR,
	    NOMBRE_TUTOR,
	    APELLIDO_TUTOR,
	    RELACION_ESTUDIANTE,
	    SEXO_TUTOR,
	    TELEFONO
	)
	VALUES
	(   '00188888888', -- CEDULA_TUTOR - varchar(11)
	    'Fernando', -- NOMBRE_TUTOR - varchar(15)
	    'Alcántara', -- APELLIDO_TUTOR - varchar(15)
	    'Padre', -- RELACION_ESTUDIANTE - varchar(10)
	    'M', -- SEXO_TUTOR - varchar(1)
	    '8096522522'  -- TELEFONO - varchar(10)
	    )
		
	INSERT INTO dbo.TUTOR
	(
	    CEDULA_TUTOR,
	    NOMBRE_TUTOR,
	    APELLIDO_TUTOR,
	    RELACION_ESTUDIANTE,
	    SEXO_TUTOR,
	    TELEFONO
	)
	VALUES
	(   '00133355558', -- CEDULA_TUTOR - varchar(11)
	    'Lucia', -- NOMBRE_TUTOR - varchar(15)
	    'Hernández', -- APELLIDO_TUTOR - varchar(15)
	    'Abuela', -- RELACION_ESTUDIANTE - varchar(10)
	    'F', -- SEXO_TUTOR - varchar(1)
	    '8092548787'  -- TELEFONO - varchar(10)
	    )

		INSERT INTO dbo.PROFESOR
		(
		    ID_PROFESOR,
		    NOMBRE_PROFESOR,
		    APELLIDO_PROFESOR,
		    FECHA_NACIMIENTO_PROFESOR,
		    SEXO_PROFESOR,
		    DIRECCION_PROFESOR,
		    TELEFONO_PROFESOR
		)
		VALUES
		(   1,         -- ID_PROFESOR - int
		    'Casimiro',        -- NOMBRE_PROFESOR - varchar(20)
		    'Peña ',        -- APELLIDO_PROFESOR - varchar(20)
		    '1980-04-25', -- FECHA_NACIMIENTO_PROFESOR - date
		    'M',        -- SEXO_PROFESOR - varchar(1)
		    'Villa Mella #43',        -- DIRECCION_PROFESOR - varchar(200)
		    '8292541745'         -- TELEFONO_PROFESOR - varchar(11)
		    )

			INSERT INTO dbo.PROFESOR
		(
		    ID_PROFESOR,
		    NOMBRE_PROFESOR,
		    APELLIDO_PROFESOR,
		    FECHA_NACIMIENTO_PROFESOR,
		    SEXO_PROFESOR,
		    DIRECCION_PROFESOR,
		    TELEFONO_PROFESOR
		)
		VALUES
		(   2,         -- ID_PROFESOR - int
		    'Susana',        -- NOMBRE_PROFESOR - varchar(20)
		    'Mejía ',        -- APELLIDO_PROFESOR - varchar(20)
		    '1975-07-06', -- FECHA_NACIMIENTO_PROFESOR - date
		    'F',        -- SEXO_PROFESOR - varchar(1)
		    'Cancino #24',        -- DIRECCION_PROFESOR - varchar(200)
		    '8095556565'         -- TELEFONO_PROFESOR - varchar(11)
		    )

			INSERT INTO dbo.MATERIA
			(
			    ID_MATERIA,
			    NOMBRE_MATERIA
			)
			VALUES
			(   1, -- ID_MATERIA - int
			    'Matemáticas' -- NOMBRE_MATERIA - varchar(20)
			    )

             INSERT INTO dbo.MATERIA
			(
			    ID_MATERIA,
			    NOMBRE_MATERIA
			)
			VALUES
			(   2, -- ID_MATERIA - int
			    'Física' -- NOMBRE_MATERIA - varchar(20)
			    )

				INSERT INTO dbo.MATERIA
			(
			    ID_MATERIA,
			    NOMBRE_MATERIA
			)
			VALUES
			(   3, -- ID_MATERIA - int
			    'Historia' -- NOMBRE_MATERIA - varchar(20)
			    )

				INSERT INTO dbo.ESTUDIANTE_TUTOR
				(
				    MATRICULA,
				    CEDULA_TUTOR
				)
				VALUES
				(   '1', -- MATRICULA - varchar(8)
				    '00133355558'  -- CEDULA_TUTOR - varchar(11)
				    )

              INSERT INTO dbo.ESTUDIANTE_TUTOR
				(
				    MATRICULA,
				    CEDULA_TUTOR
				)
				VALUES
				(   '2', -- MATRICULA - varchar(8)
				    '00188888888'  -- CEDULA_TUTOR - varchar(11)
				    )

				
              INSERT INTO dbo.ESTUDIANTE_TUTOR
				(
				    MATRICULA,
				    CEDULA_TUTOR
				)
				VALUES
				(   '3', -- MATRICULA - varchar(8)
				    '00177777777'  -- CEDULA_TUTOR - varchar(11)
				    )

				INSERT INTO dbo.SECCION
				(
				    ID_SECCION,
				    NOMBRE_SECCION,
				    CANTIDAD_ESTUDIANTES
				    
				)
				VALUES
				(   1,  -- ID_SECCION - int
				    '1A', -- NOMBRE_SECCION - varchar(10)
				    35  -- CANTIDAD_ESTUDIANTES - int
				   
				 )

				 INSERT INTO dbo.SECCION
				(
				    ID_SECCION,
				    NOMBRE_SECCION,
				    CANTIDAD_ESTUDIANTES
				    
				)
				VALUES
				(   2,  -- ID_SECCION - int
				    '3D', -- NOMBRE_SECCION - varchar(10)
				    26  -- CANTIDAD_ESTUDIANTES - int
				   
				 )

				 INSERT INTO dbo.SECCION
				(
				    ID_SECCION,
				    NOMBRE_SECCION,
				    CANTIDAD_ESTUDIANTES
				    
				)
				VALUES
				(   3,  -- ID_SECCION - int
				    '4B', -- NOMBRE_SECCION - varchar(10)
				    30  -- CANTIDAD_ESTUDIANTES - int
				   
				 )
                
				INSERT INTO dbo.ESTUDIANTE_SECCION
				(
				    MATRICULA,
				    ID_SECCION
				)
				VALUES
				(   '1', -- MATRICULA - varchar(8)
				    2  -- ID_SECCION - int
				    )
                
                INSERT INTO dbo.ESTUDIANTE_SECCION
				(
				    MATRICULA,
				    ID_SECCION
				)
				VALUES
				(   '2', -- MATRICULA - varchar(8)
				    1  -- ID_SECCION - int
				    )
                
				INSERT INTO dbo.ESTUDIANTE_SECCION
				(
				    MATRICULA,
				    ID_SECCION
				)
				VALUES
				(   '3', -- MATRICULA - varchar(8)
				    3  -- ID_SECCION - int
				    )
                
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
                
				SELECT * FROM dbo.SECCION

				INSERT INTO dbo.ESTUDIANTE_SECCION
				(
				    MATRICULA,
				    ID_SECCION
				)
				VALUES
				(   '2', -- MATRICULA - varchar(8)
				    2   -- ID_SECCION - int
				    )

				
         GO 
				
				 CREATE TRIGGER TRG_ELIMINAR_ESTUDIANTE
				 ON dbo.ESTUDIANTE
				 INSTEAD OF DELETE
				 AS
				 begin
                 DELETE FROM dbo.ESTUDIANTE_SECCION WHERE MATRICULA IN (SELECT MATRICULA FROM Deleted);
				 DELETE FROM  dbo.ESTUDIANTE_TUTOR WHERE MATRICULA IN (SELECT MATRICULA FROM Deleted);

				 DELETE dbo.ESTUDIANTE FROM Deleted AS D INNER JOIN dbo.ESTUDIANTE AS E 
				 ON D.MATRICULA = E.MATRICULA;
 
				 end
				
				 GO

				 INSERT INTO dbo.SECCION_MATERIA
				 (
				     ID_SECCION,
				     ID_MATERIA,
				     ID_PROFESOR,
				     HORARIO
				 )
				 VALUES
				 (   2, -- ID_SECCION - int
				     2, -- ID_MATERIA - int
				     1, -- ID_PROFESOR - int
				     '11-2PM' -- HORARIO - varchar(50)
				     )
				
	            DELETE FROM dbo.ESTUDIANTE WHERE MATRICULA = 2

				DELETE FROM dbo.PROFESOR WHERE ID_PROFESOR = 1

			SELECT * FROM dbo.ESTUDIANTE_TUTOR





