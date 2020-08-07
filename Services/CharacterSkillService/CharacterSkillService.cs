using System.Threading.Tasks;
using AutoMapper;
using DOTNET_RPG.Data;
using DOTNET_RPG.Dtos.Character;
using DOTNET_RPG.Dtos.CharacterSkill;
using DOTNET_RPG.Models;
using Microsoft.AspNetCore.Http;

namespace DOTNET_RPG.Services.CharacterSkillService
{
    public class CharacterSkillService : ICharacterSkillService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public CharacterSkillService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharachterSkill)
        {
            throw new System.NotImplementedException();
        }
    }
}