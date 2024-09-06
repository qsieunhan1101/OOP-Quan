using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Interface
{
    public interface IDao<T>
    {
        T findByName( string name);
        List<BaseRow> search(string name);

    }
}
