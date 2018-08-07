create proc insertar_datos_estudiantes
@id_estudiante int,
@Nombre_estudiante varchar(20),
@Apellido_estudiante varchar(20),
@Fecha_nacimiento date,
@Sexo_estudiante varchar(1),
@Direccion_Estudiante varchar(200)
as
insert into ESTUDIANTE
(ID_ESTUDIANTE, NOMBRE_ESTUDIANTE, APELLIDO_ESTUDIANTE, FECHA_NACIMIENTO_ESTUDIANTE, SEXO_ESTUDIANTE, DIRECCION_ESTUDIANTE )
VALUES
(@id_estudiante, @Nombre_estudiante, @Apellido_estudiante, @Fecha_nacimiento, @Sexo_estudiante,  @Direccion_Estudiante )



CREATE PROC buscar_matricula
@ID_ESTUDIANTE INT
as
select*from ESTUDIANTE
where ID_ESTUDIANTE=@ID_ESTUDIANTE
go


create proc eliminar_estudiante
@ID_ESTUDIANTE INT
as
delete ESTUDIANTE
where ID_ESTUDIANTE=@ID_ESTUDIANTE


create proc insertar_datos_profesor
@id_profesor int,
@Nombre_profesor varchar(20),
@Apellido_profesor varchar(20),
@Fecha_nacimiento date,
@Sexo_profesor varchar(1),
@Direccion_profesor varchar(200),
@telefono_profesor varchar(11)
as
insert into PROFESOR
(ID_PROFESOR, NOMBRE_PROFESOR, APELLIDO_PROFESOR, FECHA_NACIMIENTO_PROFESOR, SEXO_PROFESOR, DIRECCION_PROFESOR, TELEFONO_PROFESOR )
VALUES
(@id_profesor, @Nombre_profesor, @Apellido_profesor, @Fecha_nacimiento, @Sexo_profesor,  @Direccion_profesor, @telefono_profesor )
