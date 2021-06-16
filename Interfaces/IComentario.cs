using System.Collections.Generic;
using Instadev.Models;

namespace Instadev.Interfaces
{
    public interface IComentario
    {
        //Criação do CRUD

        //Create
        void Create(Comentario c);

        //Read
        List<Comentario> ReadAll();

        //Update
        void Update(Comentario c);
        
        //Delete
        void Delete(int id); 
    }
}