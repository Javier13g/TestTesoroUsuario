using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace TestTesoroUsuario.Data
{
    public interface IServicioTesoro
    {
        Task<List<TesoroUser>> GetAllTreasure (Guid Uid);
        Task<TesoroUser> GetTreasure (Guid Tid);
        Task<bool> SetTreasure (TesoroUser T);
        Task<Coordenadas_Tesoro> GetCoordinate (Guid Tid);
        Task<List<Coordenadas_Tesoro>> GetAllCoordinate (Guid Uid);
        
        
    }

    public class ServiceTesoro : IServicioTesoro
    {
       private readonly ApplicationDbContext db ;
        public ServiceTesoro(ApplicationDbContext _dbContext){
            db = _dbContext;
        }
        public Task<List<Coordenadas_Tesoro>> GetAllCoordinate(Guid Uid)
        {
            List<Coordenadas_Tesoro> coordinates = db.Coordenadas
            .Where( c => c.Uid.Equals(Uid)).ToList<Coordenadas_Tesoro>();
            return Task.FromResult(coordinates);
        }

        public async Task<List<TesoroUser>> GetAllTreasure(Guid _Uid)
        {
            List<TesoroUser> treasures = await db.Tesoros
            .Where( t => t.Id_Usuario.Equals(_Uid) )
            .ToListAsync<TesoroUser>();
            return await Task.FromResult(treasures);
        }

        public Task<Coordenadas_Tesoro> GetCoordinate(Guid Tid)
        {
            Coordenadas_Tesoro coordinate = db.Coordenadas
            .Where( c => c.Tid.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(coordinate);
        }

        public Task<TesoroUser> GetTreasure(Guid Tid)
        {
            TesoroUser treasure = db.Tesoros
            .Where( t => t.Id.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(treasure);
        }

        public Task<bool> SetTreasure(TesoroUser T)
        {
            bool status = false;
            try{
                db.Tesoros.Add(T);
                db.SaveChanges();
                status = true;
            }catch(Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }

        
    }
}