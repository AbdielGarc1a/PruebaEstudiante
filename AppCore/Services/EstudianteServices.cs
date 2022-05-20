using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class EstudianteServices : IEstudianteServices
    {
        IEstudianteModel model;

        public EstudianteServices(IEstudianteModel model)
        {
            this.model = model;
        }

        public void create(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Asset no puede ser null.");
            }

            model.create(t);
        }

        public void Delete(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Asset no puede ser null.");
            }

            model.Delete(t);
        }

        public Estudiante FindById(int id)
        {
            return model.FindById(id);
        }

        public List<Estudiante> Read()
        {
            return model.Read();
        }
    }
}
