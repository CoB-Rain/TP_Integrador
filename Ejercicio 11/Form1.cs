using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class Form1: Form
    {
        #region Consigna
        /*
            Un hospital privado necesita un sistema que le permita gestionar las historias clínicas de sus pacientes.
            El hospital está dividido en diferentes especialidades, donde cada especialidad tiene diferentes estudios
            que el paciente puede realizarse. Cada estudio tiene un costo, y debe estar acompañado de la orden médica
            con la firma médico fue el que lo solicitó, además el cupo para realizar los estudios es limitado por día.
            
            Cada médico clínico tiene un costo, y este costo se encarece en un 15% por cada especialización que éste posea.
            También los médicos tienen agendas de pacientes, para lo cual, se debe reservar el turno con antelación
            y evitar que los turnos se superpongan. Los médicos de guardia son los únicos que pueden atender demanda espontánea.

            Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
                1) Carga de especialidades, médicos y pacientes.
                2) Carga de derivaciones y estudios.
                3) Registrar los resultados de los estudios.
                4) Generar la receta médica correspondiente al diagnóstico del médico.
                5) Listar La historia clínica de un paciente ordenada de forma descendiente por fecha.
                6) Listar la historia clínica de un paciente filtrada por especialidad.
                7) Obtener el costo total que el paciente debe abonar por su tratamiento.
                8) Obtener la ganancia total del hospital.
                9) Listar de forma ascendente las especialidades ordenada por ganancia acumulada.
                10) Listar de manera descendente las especialidades ordenadas por cantidad de pacientes.

            Se requiere:
                • Desarrollar con Windows Application y Dll
                • Uso de eventos
                • Uso de interfaces
         */
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
