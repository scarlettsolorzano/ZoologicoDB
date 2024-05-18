﻿using Microsoft.EntityFrameworkCore;
using Zoologico.Modelo;

namespace Zoologico.Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly ZoologicoDBContext _context;

        public RepositorioPersonas(ZoologicoDBContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }
        public async Task<List<Area>> GetAreas()
        {
            return await _context.Areas.ToListAsync();
        }

        public async Task<Persona?> Get(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Update(int id, Persona persona)
        {
            var personaActual = await _context.Personas.FindAsync(id);
            if (personaActual != null)
            {
                personaActual.Nombre = persona.Nombre;
                personaActual.Telefono = persona.Telefono;
                personaActual.AreaId = persona.AreaId;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }
    }
}
