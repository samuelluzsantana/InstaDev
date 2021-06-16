using System.Collections.Generic;
using Instadev.Models;

namespace Instadev.Interfaces
{
    public interface IPublicacao
    {
        //Criação do CRUD

        //Create
        void Create(Publicacao p);

        //Read
        List<Publicacao> ReadAll();

        //Update
        void Update(Publicacao p);
        
        //Delete
        void Delete(int id);
    }
}