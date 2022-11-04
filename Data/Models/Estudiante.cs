using System.ComponentModel.DataAnnotations;
using System.Data;
using System;

namespace  Estudiantes.Data.Models;

public class Estudiante
{
    [Key]
    public int estudianteID { get; set; }
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public DateTime FechaNacimiento { get; set; }
    public string? Carrera { get; set; }
    public double Matricula { get; set; }

    public static Estudiante Crear(string nombres, string apellidos, DateTime fechanacimiento, string carrera, double matricula){
        return new Estudiante()
        {
            estudianteID = 0,
            Nombres = nombres,
            Apellidos = apellidos,
            FechaNacimiento = fechanacimiento,
            Carrera = carrera,
            Matricula = matricula
        };
}
    

      public void Update(string nombres, string apellidos, DateTime fechanacimiento, string carrera, double matricula)
   {
     Nombres = nombres;
     Apellidos = apellidos;
     FechaNacimiento = fechanacimiento;
     Carrera = carrera;
     Matricula = matricula;
    }   

}