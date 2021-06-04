
begin transaction 

-- Insertar un domicilio
INSERT INTO Domicilio(Calle,Numero,Piso,Dpto,Provincia,Localidad,Cod_Postal) VALUES ('Publica',11,2,10,'Córdoba','Córdoba',5000);

-- insertar vehiculo
INSERT INTO vehiculo(Marca,Modelo,Anio,Color,Patente,Capital) VALUES ('Renault','Clio Mio',2013,'Negro','BIO968',500000);

-- Insertar estado inicial 
INSERT INTO Estado values(GETDATE(),TRY_CONVERT (TIME,'12:05:06'),'Inicial');

-- datos para login
insert into Login values ('daniela','1234'),  ('candy','1234'), ('analia','1234'), ('alina','1234'), ('jonathan','1234');

-- poliza antes debe existir asociado y vehiculo y poner sus id como clave foranea
INSERT INTO poliza(cobertura,id_asociado,id_vehiculo) VALUES ('parcial',1,1);

-- un siniestro de prueba id_poliza e id_estado deben existir y ponerlos como foranea
INSERT INTO Siniestro(Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado)
       VALUES (TRY_CONVERT (TIME,'12:05:06'),GETDATE(),'Declaraion de prueba','Calle Rumipal barrio los naranjos',1,1);


commit;

