using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class Service<T> : IServices<T>
    {
        IModel<T> model;

        public Service(IModel<T> model)
        {
            this.model = model;
        }

        public void create(T t)
        {
            model.create(t);
        }

        public void Delete(T t)
        {
            model.Delete(t);
        }

        public List<T> Read()
        {
            return model.Read();
        }
    }
}
