using NarvaezEstebanExamen.Interfaces;
using NarvaezEstebanExamen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarvaezEstebanExamen.Repositories
{
    public class RecargaTelefonicaArchivos : IRecargaTelefonicaRepository
    {
        private string _filename = Path.Combine(FileSystem.AppDataDirectory, "recargas.txt");

        public bool CrearRecargaTelefonica(RecargaTelefonica recarga)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(recarga);
                File.WriteAllText(_filename, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public IEnumerable<RecargaTelefonica> DevuelveListadoRecargas()
        {
            throw new NotImplementedException();
        }

        public bool EliminarRecargaTelefonica(int id)
        {
            throw new NotImplementedException();
        }

        bool IRecargaTelefonicaRepository.ActualizarRecargaTelefonica(RecargaTelefonica recarga)
        {
            throw new NotImplementedException();
        }



        RecargaTelefonica IRecargaTelefonicaRepository.DevuelveRecargaTelefonica(int id)
        {
            RecargaTelefonica recarga = new RecargaTelefonica();

            if (File.Exists(_filename))
            {
                string json_data = File.ReadAllText(_filename);
                recarga = JsonConvert.DeserializeObject<RecargaTelefonica>(json_data);
            }
            return recarga;
        }
    }
}
