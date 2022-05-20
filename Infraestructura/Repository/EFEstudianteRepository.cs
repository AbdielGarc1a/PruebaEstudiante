using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class EFEstudianteRepository : IEstudianteModel
    {
        public IEstudianteDBContext estudianteDBContext;

        public EFEstudianteRepository(IEstudianteDBContext estudianteDBContext)
        {
            this.estudianteDBContext = estudianteDBContext;
        }

        public void create(Estudiante t)
        {
            try
            {
                estudianteDBContext.Estudiante.Add(t);
                estudianteDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Estudiante t)
        {
            try
            {
                estudianteDBContext.Estudiante.Remove(t);
                estudianteDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return estudianteDBContext.Estudiante.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> Read()
        {
            try
            {
                return estudianteDBContext.Estudiante.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
