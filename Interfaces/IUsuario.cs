using System.Collections.Generic;
using Instadev.Models;

namespace Instadev
{
    public interface IUsuario
    {
         //Cração do CRUD

         //Create
         void Create(Usuario u);

         //Read
         List<Usuario> ReadAll();

         //Update
         void Update(Usuario u);

         //Delete
         void Delete(int id);
    }
}