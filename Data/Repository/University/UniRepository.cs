using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dto;
using System.Xml.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository.University
{
    public class UniRepository : IUniRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public UniRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task<int> AddEducationalOrganization(EducationalOrganization entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationalOrganizations.Add(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<EducationalOrganization>> GetFiltredOrganizations(EduOrgFilter filter)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            IQueryable<EducationalOrganization> query = db.EducationalOrganizations;
            if (filter.ProgramIds is { Count: > 0 })
            {
                query = db.ProgramsEducationalOrganization.Where(peo =>
                        filter.ProgramIds.Contains(peo.EducationProgram.EducationalOrganizationSpecializationId))
                    .Select(peo => peo.EducationalOrganization)
                    .Distinct();
            }
            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(c => c.Name.Contains(filter.Name.ToLower()));
            if (filter.CityId.HasValue)
                query = query.Where(c => c.CityId == filter.CityId);
            if (filter.TypeId.HasValue)
                query = query.Where(c => c.TypeId == filter.TypeId);
                
            return await query.ToListAsync();
        }

        public async Task<int> AddEducationProgram(EducationProgram entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationPrograms.Add(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<TypeEducationalOrganization>> GetEducationalOrganizationType()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.TypeEducationalOrganizations.ToListAsync();
        }

        public async Task<List<City>> GetCities()
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Cities.ToListAsync();
        }

        public async Task<int> AddSpecialization(Specialization entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.Specializations.Add(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> DeleteEducationalOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var organization = await db.EducationalOrganizations.FindAsync(id);
            if (organization == null) return false;
            organization.IsDeleted = true;
            var save = await db.SaveChangesAsync();
            return save > 0;
        }

        
        public async Task<bool> DeleteSpecialization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var spec = await db.Specializations.FindAsync(id);
            if (spec == null) return false;
            spec.IsDeleted = true;
            var save = await db.SaveChangesAsync();
            return save > 0;
        }

        public async Task<bool> EditEducationalOrganization(EducationalOrganization entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationalOrganizations.Attach(entity);

            db.Entry(entity).State = EntityState.Modified;

            try
            {
                var save = await db.SaveChangesAsync();
                return save > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> EditEducationProgram(EducationProgram entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationPrograms.Attach(entity);

            db.Entry(entity).State = EntityState.Modified;

            try
            {
                var save = await db.SaveChangesAsync();
                return save > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> EditSpecialization(Specialization entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.Specializations.Attach(entity);

            db.Entry(entity).State = EntityState.Modified;

            try
            {
                var save = await db.SaveChangesAsync();
                return save > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<List<EducationalOrganization>> GetAllEducationalOrganization()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationalOrganizations.ToListAsync();
        }

        public async Task<List<EducationProgram>> GetAllEducationProgram()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationPrograms.ToListAsync();
        }

        public async Task<EducationalOrganization?> GetEducationalOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationalOrganizations.FirstOrDefaultAsync(c=> c.Id == id);
        }

        public async Task<EducationProgram?> GetEducationProgram(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationPrograms.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Specialization?> GetSpecialization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Specializations.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Specialization>> GetAllSpecializations()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Specializations.ToListAsync();
        }

		public async Task<List<EducationalOrganization>> GetRandomEducationalOrganization(int count)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var countDb = await db.EducationalOrganizations.CountAsync();
            if (countDb <= count) 
            {
                return await GetAllEducationalOrganization();
            }
            else
            {
                var random = new Random();
                return await db.EducationalOrganizations.OrderBy(x => random.Next()).Take(count).ToListAsync();
            }
        }
	}
}
