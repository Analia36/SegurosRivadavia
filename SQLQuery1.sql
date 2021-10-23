create procedure Ampliacion_Siniestro
@Num_Siniestro int
as
begin

select Ampliacion.id, Ampliacion.Num_Siniestro, Ampliacion.AmpliacionSin, Ampliacion.Fecha, Siniestro.Num_siniestro from Ampliacion inner join Siniestro
on Siniestro.Num_siniestro=Ampliacion.Num_Siniestro where Ampliacion.Num_Siniestro = @Num_Siniestro

end