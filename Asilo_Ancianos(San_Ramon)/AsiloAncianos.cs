using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class AsiloAncianos
    {
        private Medico[] medicos = new Medico[4];
        private Enfermero[] enfermeros = new Enfermero[12];
        private Coordinador coordinador = new Coordinador();
        private Cuidador[] cuidadores = new Cuidador[30];
        private Psicologo[] psicologos = new Psicologo[3];
        private Anciano[] ancianos = new Anciano[100];
        private int nm, ne, nc, np, na;


        public AsiloAncianos() { }
        public void addMedico(Medico m)
        {
            this.medicos[nm] = m;
            this.nm++;
        }
        public void addEnfermero(Enfermero e)
        {
            this.enfermeros[ne] = e;
            this.ne++;
        }
        public void addCoordinador(Coordinador c)
        {
            this.coordinador = c;
        }
        public void addCuidadores(Cuidador c) 
        {
            this.cuidadores[nc] = c;
            this.nc++;
        }
        public void addPsicologo(Psicologo p)
        {
            this.psicologos[np] = p;
            this.np++;
        }
        
    }
}
