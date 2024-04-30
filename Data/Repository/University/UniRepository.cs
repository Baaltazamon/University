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
            IQueryable<EducationalOrganization> query = db.EducationalOrganizations.Where(c=> !c.IsDeleted);
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

        public async Task<List<EducationalOrganizationContact>> GetEducationalOrganizationContact(int organizationId)
        {
	        await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
	        return await db.EducationalOrganizationContacts.Where(c => c.EducationalOrganizationId == organizationId).ToListAsync();
        }

        public async Task<int> AddContact(EducationalOrganizationContact contact)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationalOrganizationContacts.Add(contact);
            await db.SaveChangesAsync();
            return contact.Id;
        }

        public async Task<bool> DeleteContact(int contactId)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var contact = await db.EducationalOrganizationContacts.SingleOrDefaultAsync(c => c.Id == contactId);
            if (contact == null) 
                return false;
            db.EducationalOrganizationContacts.Remove(contact);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<List<TypeContact>> GetAllType()
        {
			await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.TypesContact.Where(c=> !c.IsDeleted).ToListAsync();
		}

        public async Task<int> AddEducationProgram(EducationProgram entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            db.EducationPrograms.Add(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<TypeEducationalOrganization?>> GetEducationalOrganizationType()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.TypeEducationalOrganizations.ToListAsync();
        }

        public async Task<TypeEducationalOrganization?> GetEducationalOrganizationTypeOnOrganization(int id)
        {
			await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
			return await db.TypeEducationalOrganizations.FirstOrDefaultAsync(c =>
				!c.IsDeleted && c.Id == db.EducationalOrganizations.FirstOrDefault(x => x.Id == id)!.TypeId);
        }

        public async Task<List<City>> GetCities()
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Cities.ToListAsync();
        }

        public async Task<List<TypeEducationalOrganization>> GetTypesEducationalOrganization()
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.TypeEducationalOrganizations.Where(c=> !c.IsDeleted).ToListAsync();
        }

        public async Task<List<ProgramEducationalOrganization>> GetProgramEducationalOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.ProgramsEducationalOrganization
                .Where(p => p.EducationalOrganizationId == id && !p.IsDeleted).ToListAsync();
        }

        public async Task<List<EducationLevel>> GetAllEducationalLevel()
        {
	        await using var db = new UniversityDbContext(_serviceProvider
		        .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationLevel.Where(c => !c.IsDeleted).ToListAsync();
		}

        public async Task<List<Discipline>> GetAllDisciplines()
        {
			await using var db = new UniversityDbContext(_serviceProvider
				.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Disciplines.Where(c=> !c.IsDeleted).ToListAsync();
		}

        public async Task<List<DisciplineEducationProgram>> GetOrganizationProgramDisciplines(int id)
        {
			await using var db = new UniversityDbContext(_serviceProvider
				.GetRequiredService<DbContextOptions<UniversityDbContext>>());
			var programs = (await GetOrganizationEducationProgram(id)).Select(c=> c.Id);
            return await db.DisciplinesEducationProgram.Where(c=> programs.Contains(c.EducationProgramId)).ToListAsync();
        }

        public async Task<List<PassingScore>> GetOrganizationPassingScore(int id)
        {
			await using var db = new UniversityDbContext(_serviceProvider
				.GetRequiredService<DbContextOptions<UniversityDbContext>>());
			var orgProg = (await GetProgramEducationalOrganization(id)).Select(c=> c.Id);
            return await db.PassingScores.Where(c=> orgProg.Contains(c.ProgramEducationalOrganizationId)).ToListAsync();
        }

        public async Task<ProgramEducationalOrganization?> GetOrganizationProgramEducationalOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.ProgramsEducationalOrganization.Where(c => c.Id == id)
                .Include(c => c.EducationProgram).FirstOrDefaultAsync();

        }

        public async Task<int> AddProgramEducationOrganization(ProgramEducationalOrganization entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            await db.ProgramsEducationalOrganization.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> DeleteProgramEducationOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var prog = await db.ProgramsEducationalOrganization.FirstOrDefaultAsync(c => c.Id == id);
            if (prog == null)
                return 0;
            prog.IsDeleted = true;
            await db.SaveChangesAsync();
            return prog.EducationalOrganizationId;
        }

        public async Task<List<DisciplineEducationProgram>> GetDisciplineEducationPrograms(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var disciplines = await db.DisciplinesEducationProgram.Where(c=> c.EducationProgramId == id).ToListAsync();
            return disciplines;
        }

        public async Task<int> AddDisciplineEducationProgram(DisciplineEducationProgram entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            await db.DisciplinesEducationProgram.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> DeleteDisciplineEducationPrograms(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var discipline = await db.DisciplinesEducationProgram.FirstOrDefaultAsync(c => c.Id == id);
            if (discipline == null) return 0;
            db.DisciplinesEducationProgram.Remove(discipline);
            await db.SaveChangesAsync();
            return discipline.EducationProgramId;
        }

        public async Task<List<PassingScore>> GetPassingScore(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.PassingScores.Where(c=> c.ProgramEducationalOrganizationId == id).ToListAsync();
        }

        public async Task<int> AddPassingScore(PassingScore entity)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            await db.PassingScores.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> DeletePassingScore(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider
                .GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var score = await db.PassingScores.FindAsync(id);
            if (score == null) 
                return 0;
            db.PassingScores.Remove(score);
            await db.SaveChangesAsync();
            return score.ProgramEducationalOrganizationId;
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

        public async Task<bool> DeleteEducationProgram(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var organization = await db.EducationPrograms.FindAsync(id);
            if (organization == null) return false;
            organization.IsDeleted = true;
            var save = await db.SaveChangesAsync();
            return save > 0;
        }

        public async Task<List<EducationProgram>> GetOrganizationEducationProgram(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var educationPrograms = await db.EducationPrograms
                .Where(c => db.ProgramsEducationalOrganization
                    .Where(p => p.EducationalOrganizationId == id)
                    .Select(p => p.EducationProgramId)
                    .Contains(c.Id))
                .ToListAsync();
            return educationPrograms;
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

        public async Task<List<Specialization>> GetSpecializationOnUniversity(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var programs = await GetOrganizationEducationProgram(id);
            var ids = programs.Select(x => x.EducationalOrganizationSpecializationId).Distinct().ToList();
			return await db.Specializations
                .Where(c => ids.Contains(c.Id)).ToListAsync();
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

        public async Task<bool> CheckUsers()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var f = db.Users.Count() > 0;
            return db.Users.Any();
        }


        public async Task<List<EducationalOrganization>> GetAllEducationalOrganization()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationalOrganizations.Where(c => !c.IsDeleted).Include(c=> c.TypeEducationalOrganization)
                .Include(c=> c.City).ToListAsync();
        }

        public async Task<List<EducationProgram>> GetAllEducationProgram()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationPrograms.Where(c=> !c.IsDeleted).ToListAsync();
        }

        public async Task<List<string?>> GetRandomEducationProgram(int count)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var countDb = await db.EducationPrograms.CountAsync();
            if (countDb <= count)
            {
                return (await GetAllEducationProgram()).Select(c => c.Image).ToList();
            }
            else
            {
                var random = new Random();
                var programs = await db.EducationPrograms
                    .Select(c => c.Image)
                    .ToListAsync();
                return programs.OrderBy(_ => random.Next()).Take(count).ToList();
            }
        }

        public async Task<EducationalOrganization?> GetEducationalOrganization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationalOrganizations.FirstOrDefaultAsync(c=> c.Id == id && !c.IsDeleted);
        }

        public async Task<EducationProgram?> GetEducationProgram(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.EducationPrograms.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Specialization?> GetSpecialization(int id)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Specializations.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }

        public async Task<List<Specialization>> GetAllSpecializations()
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            return await db.Specializations.Where(c => !c.IsDeleted).ToListAsync();
        }

		public async Task<List<EducationalOrganization>> GetRandomEducationalOrganization(int count)
        {
            await using var db = new UniversityDbContext(_serviceProvider.GetRequiredService<DbContextOptions<UniversityDbContext>>());
            var countDb = await db.EducationalOrganizations.Where(c => !c.IsDeleted).CountAsync();
            if (countDb <= count) 
            {
                return await GetAllEducationalOrganization();
            }
            else
            {
                var random = new Random();
                var vuz = await db.EducationalOrganizations.Where(c=> !c.IsDeleted).ToListAsync();
                return vuz.OrderBy(x => random.Next()).Take(count).ToList();
            }
        }
	}
}
