using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NgaoApi.Data;
using NgaoApi.Dtos;
using NgaoApi.Models;

namespace NgaoApi.Controllers
{
    
    [Route("api/NgaoApi")]
    [ApiController]
    public class NgaoApiController : ControllerBase
    {
        private readonly INgaoRepo _repository;
        private readonly IMapper _mapper;

        public NgaoApiController(INgaoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
      
        //GET api/NgaoApi
        [HttpGet]
        public ActionResult<IEnumerable<NgaoReadDto>> GettAllNgaoApi()
        {
            var ngaoItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<NgaoReadDto>>(ngaoItems));
        }
        //GET api/NgaoApi/{id}
        [HttpGet("{id}", Name="GetNgaoById")]
        public ActionResult <NgaoReadDto> GetNgaoById(int id)
        {
            var ngaoItems = _repository.GetCommandById(id);
            if(ngaoItems != null)
            {
                return Ok(_mapper.Map<NgaoReadDto>(ngaoItems)); 
            }else{
                return NotFound();
            }
            
        }

        //POST api/NgaoApi
        [HttpPost]
        public ActionResult <NgaoReadDto> CreateNgao(NgaoCreateDto ngaoCreateDto)
        {
            var ngaoModel = _mapper.Map<ngao>(ngaoCreateDto);
            _repository.createngao(ngaoModel);
            _repository.saveChanges();

            var NgaoReadDto = _mapper.Map<NgaoReadDto>(ngaoModel);

            return CreatedAtRoute(nameof(GetNgaoById), new {Id = NgaoReadDto.id}, NgaoReadDto);
           
        }

        //PUT api/NgaoApi
        [HttpPut("{id}")]
        public ActionResult Updatengao (int id, NgaoUpdateDto ngaoUpdateDto)
        {
            var ngaoModelFromREpo = _repository.GetCommandById(id);
            if(ngaoModelFromREpo == null)
            {
                return NotFound();
            }

            _mapper.Map(ngaoUpdateDto, ngaoModelFromREpo);

            _repository.updatengao(ngaoModelFromREpo);

            _repository.saveChanges();

            return NoContent();

        }
        
    }
}