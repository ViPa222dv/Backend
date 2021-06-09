using ApiPractice.Models;
using ApiPractice.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPractice.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await _playerRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayers(int id)
        {
            return await _playerRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayers([FromBody] Player player)
        {
            var newPlayer = await _playerRepository.Create(player);
            return CreatedAtAction(nameof(GetPlayers), new { id = newPlayer.Id }, newPlayer);
        }
    }
}
