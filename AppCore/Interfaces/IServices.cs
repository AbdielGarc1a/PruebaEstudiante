using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IServices<T>
    {
        void create(T t);
        void Delete(T t);
        List<T> Read();
    }
}
