using NarvaezEstebanExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarvaezEstebanExamen.Interfaces
{
    interface IRecargaTelefonicaRepository
    {
        IEnumerable<RecargaTelefonica> DevuelveListadoRecargas();
        RecargaTelefonica DevuelveRecargaTelefonica(int id);
        bool CrearRecargaTelefonica(RecargaTelefonica recarga);
        bool ActualizarRecargaTelefonica(RecargaTelefonica recarga);
        bool EliminarRecargaTelefonica(int id);
    }
}
