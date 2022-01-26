using EncryptionWebAPI.Models;
using EncryptionWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcryptionController : ControllerBase
    {
        private readonly DataAnalyticsContext _context;
        private readonly IEncryptionWebRepo encryptionWebRepo;

        public EcryptionController(IEncryptionWebRepo encryptionWebRepo, DataAnalyticsContext context)
        {
            this.encryptionWebRepo = encryptionWebRepo;
            _context = context;
        }


        [HttpGet("DecryptAllData")]
        public async Task<ActionResult<PcAccounts1B>> DecryptAllData()
        {
            var encryprionWeb = await encryptionWebRepo.DecryptAllData();

            return Ok(encryprionWeb);
        } 

        [HttpPost("SaveAllData")]
        public async Task<ActionResult<PcAccounts1B>> SaveAllData(List<PcAccounts1B> model)
        {
        //    var encryprionWeb = await encryptionWebRepo.SaveAllData(model);

            return Ok(model);
        }

    }
}
