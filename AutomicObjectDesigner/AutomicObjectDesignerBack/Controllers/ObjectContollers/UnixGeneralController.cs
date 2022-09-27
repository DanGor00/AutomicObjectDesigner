﻿using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Controllers.Functions;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Repository.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text;
using System.Linq;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    // https://localhost:7017/api/UnixGeneral
    [ApiController]
    [Route("api/[controller]")]
    public class UnixGeneralController : ControllerBase
    {
        private readonly IUnixGeneralRepository _unixGeneralRepository;
        private readonly ILogger<UnixGeneralController> _logger;

        public UnixGeneralController(AppDatabaseContext context, ILogger<UnixGeneralController> logger,
            IUnixGeneralRepository repository)
        {
            _unixGeneralRepository = repository;
            _logger = logger;
        }

        //GET https://localhost:7017/api/UnixGeneral
        [HttpGet]
        public async Task<ActionResult<List<UnixGeneral>>> GetUnixGeneral()
        {
            _logger.LogInformation("GetUnixGeneral called...");
            var unixGeneral = _unixGeneralRepository.GetAll();

            return Ok(unixGeneral);

        }

        //GET https://localhost:7017/api/UnixGeneral/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UnixGeneral>> GetUnixGeneral(int id)
        {
            _logger.LogInformation($"GetUnixGeneral called with parameter id = {id}");
            var unixGeneral = _unixGeneralRepository.FindByCondition((x => x.Id == id));

            if (unixGeneral == null)
            {
                return NotFound();
            }

            return Ok(unixGeneral);
        }

        //DELETE https://localhost:7017/api/UnixGeneral/{id}
        [HttpDelete("{id}", Name = "DeleteUnixGeneral")]
        public async Task<ActionResult<List<UnixGeneral>>> DeleteUnixGeneral(int id)
        {
            var unixObject = new UnixGeneral() { Id = id };


            if (unixObject == null)
            {
                return NotFound();
            }

            _unixGeneralRepository.Delete(unixObject);
            _unixGeneralRepository.Save();

            return NoContent();

        }

        //POST https://localhost:7017/api/UnixGeneral/step1
        [HttpPost("step1", Name = "CreateUnixGeneral_Step1")]
        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneral([FromBody] UnixGeneralStep1Dto UnixGeneralStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixGeneral = new UnixGeneral
            {
                UnixServer = UnixGeneralStep1Dto.UnixServer,
                UnixLogin = UnixGeneralStep1Dto.UnixLogin,
                SapSid = UnixGeneralStep1Dto.SapSid,
                SapClient = UnixGeneralStep1Dto.SapClient,
                RoutineJob = UnixGeneralStep1Dto.RoutineJob,
                ProcessName = UnixGeneralStep1Dto.ProcessName,
                NameSuffix = UnixGeneralStep1Dto.NameSuffix,
                ObjectName = $"<{UnixGeneralStep1Dto.SapSid}>.<{UnixGeneralStep1Dto.SapClient}>#<{UnixGeneralStep1Dto.RoutineJob}>" +
                             $"#<{UnixGeneralStep1Dto.ProcessName}>#LNX_<{UnixGeneralStep1Dto.NameSuffix}>.JOBS"

            };

            _unixGeneralRepository.Create(unixGeneral);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step1", new { id = unixGeneral.Id }, unixGeneral);
        }

        //POST https://localhost:7017/api/UnixGeneral/step2
        [HttpPost("step2", Name = "CreateUnixGeneral_Step2")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep2([FromBody] UnixGeneralStep2Dto UnixGeneralStep2Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x=>x.Id ==UnixGeneralStep2Dto.Id).FirstOrDefault();
            if (unixObject == null)
            {
                return NotFound();
            }

            unixObject.ObjectName = UnixGeneralStep2Dto.ObjectName;

            _unixGeneralRepository.Update(unixObject);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step2", new { id = unixObject.Id }, unixObject);
        }

        //POST https://localhost:7017/api/UnixGeneral/step3
        [HttpPost("step3", Name = "CreateUnixGeneral_Step3")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep3([FromBody] UnixGeneralStep3Dto UnixGeneralStep3Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep3Dto.Id).FirstOrDefault();
            
            if (unixObject == null)
            {
                return NotFound();
            }

            unixObject.Process = UnixGeneralStep3Dto.Process;

            _unixGeneralRepository.Update(unixObject);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step3", new { id = unixObject.Id }, unixObject);
        }

        //POST https://localhost:7017/api/UnixGeneral/step4
        [HttpPost("step4", Name = "CreateUnixGeneral_Step4")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep4([FromBody] UnixGeneralStep4Dto UnixGeneralStep4Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep4Dto.Id).FirstOrDefault();
            if (unixObject == null)
            {
                return NotFound();
            }

            unixObject.Documentation = UnixGeneralStep4Dto.Documentation;

            _unixGeneralRepository.Update(unixObject);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step4", new { id = unixObject.Id }, unixObject);
        }

        //POST https://localhost:7017/api/UnixGeneral/step5
        [HttpPost("step5", Name = "CreateUnixGeneral_Step5")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep5([FromBody] UnixGeneralStep5Dto UnixGeneralStep5Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep5Dto.Id).FirstOrDefault();
            if (unixObject == null)
            {
                return NotFound();
            }

            unixObject.Archive1 = UnixGeneralStep5Dto.Archive1;
            unixObject.Archive2 = UnixGeneralStep5Dto.Archive2;
            unixObject.Folder = UnixGeneralStep5Dto.Folder;
            unixObject.InternalAccount = UnixGeneralStep5Dto.InternalAccount;
            unixObject.Title = UnixGeneralStep5Dto.Title;

            _unixGeneralRepository.Update(unixObject);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step5", new { id = unixObject.Id }, unixObject);
        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/UnixGeneral/GetUnixGeneralStep6/{id}
        [HttpGet("GetUnixGeneralStep6/{id:int}", Name = "GetUnixGeneralStep6")]
        public async Task<ActionResult<UnixGeneral>> GetUnixGeneralStep6(int id)
        {
            _logger.LogInformation($"GetUnixGeneral called with parameter id = {id}");

            var unixGeneral = _unixGeneralRepository.FindByCondition((h => h.Id == id));

            UnixGeneral unix = new UnixGeneral
            {
                Id = id,
                UnixServer = unixGeneral.FirstOrDefault().UnixServer,
                UnixLogin = unixGeneral.FirstOrDefault().UnixLogin,
                ObjectName = unixGeneral.FirstOrDefault().ObjectName,
                OwnerId = unixGeneral.FirstOrDefault().OwnerId,
                Active = unixGeneral.FirstOrDefault().Active,
                NameSuffix = unixGeneral.FirstOrDefault().NameSuffix,
                MaxParallelTasks = unixGeneral.FirstOrDefault().MaxParallelTasks,
                Process = unixGeneral.FirstOrDefault().Process,
                PreProcess = unixGeneral.FirstOrDefault().PreProcess,
                PostProcess = unixGeneral.FirstOrDefault().PostProcess,
                SapClient = unixGeneral.FirstOrDefault().SapClient,
                SapSid = unixGeneral.FirstOrDefault().SapSid,
                RoutineJob = unixGeneral.FirstOrDefault().RoutineJob,
                ProcessName = unixGeneral.FirstOrDefault().ProcessName,
                Documentation = unixGeneral.FirstOrDefault().Documentation,
                Title = unixGeneral.FirstOrDefault().Title,
                Archive1 = unixGeneral.FirstOrDefault().Archive1,
                Archive2 = unixGeneral.FirstOrDefault().Archive2,
                InternalAccount = unixGeneral.FirstOrDefault().InternalAccount,
                Folder = unixGeneral.FirstOrDefault().Folder,
                Queue = unixGeneral.FirstOrDefault().Queue,
                Agent = unixGeneral.FirstOrDefault().Agent,
                Login = unixGeneral.FirstOrDefault().Login

            };

            return Ok(unix);
        }

        // Function returns required Data ready for modification after step 1 was filled.
        //Get https://localhost:7017/api/UnixGeneral/GetUnixGeneralStep2/{id}
        [HttpGet("GetUnixGeneralStep2/{id:int}", Name = "GetUnixGeneralStep2")]
        public async Task<ActionResult<UnixGeneral>> GetUnixGeneralStep2(int id)
        {
            _logger.LogInformation($"GetUnixGeneral called with parameter id = {id}");

            var unixGeneral = _unixGeneralRepository.FindByCondition((h => h.Id == id));
            UnixGeneralStep2Dto unix = new UnixGeneralStep2Dto

            {
                Id = id,
                ObjectName = unixGeneral.FirstOrDefault().ObjectName,

            };

            return Ok(unix);
        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/UnixGeneral/DownloadCsvFile/{id}
        [HttpGet("DownloadUnixGeneralCsvFile/{id:int}", Name = "DownloadUnixGeneralCsvFile")]
        public IActionResult DownloadCsvFile(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            };

            var unixGeneral = _unixGeneralRepository.FindByCondition((h => h.Id == id)).FirstOrDefault();
            if (unixGeneral == null)
            {
                return NotFound();
            };



            string[] columnNames = new string[]
            {
                "Id", "UnixServer", "UnixLogin", "ObjectName", "OwnerId", "Active", "NameSuffix", "MaxParallelTasks",
                "Process", "PreProcess", "PostProcess", "SapClient",
                "SapSid", "RoutineJob", "ProcessName", "Documentation", "Title",
                "Archive1", "Archive2", "InternalAccount",
                "Folder", "Queue", "Agent", "Login"
            };
            var unixs = _unixGeneralRepository.FindByCondition((h => h.Id == id));
            string csv = String.Empty;

            foreach (string columnName in columnNames)
            {
                csv += columnName + ',';
            }

            csv += "\r\n";

            foreach (var unix in unixs)
            {
                csv += '"' + unix.Id.ToString().Replace(",", ";") + "\",";
                csv += '"' + unix.UnixServer.Replace(",", ";") + "\",";
                csv += '"' + unix.UnixLogin.Replace(",", ";") + "\",";
                csv += '"' + unix.ObjectName.Replace(",", ";") + "\",";
                csv += '"' + unix.OwnerId.ToString().Replace(",", ";") + "\",";
                csv += '"' + unix.Active.ToString().Replace(",", ";") + "\",";
                csv += '"' + unix.NameSuffix.Replace(",", ";") + "\",";
                csv += '"' + unix.MaxParallelTasks.ToString().Replace(",", ";") + "\",";
                csv += '"' + unix.Process.Replace(",", ";") + "\",";
                csv += '"' + unix.PreProcess.Replace(",", ";") + "\",";
                csv += '"' + unix.PostProcess.Replace(",", ";") + "\",";
                csv += '"' + unix.SapClient.Replace(",", ";") + "\",";
                csv += '"' + unix.SapSid.Replace(",", ";") + "\",";
                csv += '"' + unix.RoutineJob.ToString().Replace(",", ";") + "\",";
                csv += '"' + unix.ProcessName.Replace(",", ";") + "\",";
                csv += '"' + unix.Documentation.Replace(",", ";") + "\",";
                csv += '"' + unix.Title.Replace(",", ";") + "\",";
                csv += '"' + unix.Archive1.Replace(",", ";") + "\",";
                csv += '"' + unix.Archive2.Replace(",", ";") + "\",";
                csv += '"' + unix.InternalAccount.Replace(",", ";") + "\",";
                csv += '"' + unix.Folder.Replace(",", ";") + "\",";
                csv += '"' + unix.Queue?.Replace(",", ";") + "\",";
                csv += '"' + unix.Agent?.Replace(",", ";") + "\",";
                csv += '"' + unix.Login?.Replace(",", ";") + "\",";

                csv += "\r\n";

            }

            byte[] bytes = Encoding.ASCII.GetBytes(csv);
            return File(bytes, "text/csv", "unix.csv");

        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/UnixGeneral/DownloadJsonFile/{id}
        [HttpGet("DownloadUnixGeneralJsonFile/{id:int}", Name = "DownloadUnixGeneralJsonFile")]
        public IActionResult DownloadJsonFile(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            };

            var unixGeneral = _unixGeneralRepository.FindByCondition((h => h.Id == id)).FirstOrDefault();
            if (unixGeneral == null)
            {
                return NotFound();
            };

            UnixGeneral unixJson = new UnixGeneral
            {
                Id = id,
                UnixServer = unixGeneral.UnixServer,
                UnixLogin = unixGeneral.UnixLogin,
                ObjectName = unixGeneral.ObjectName,
                OwnerId = unixGeneral.OwnerId,
                Active = unixGeneral.Active,
                NameSuffix = unixGeneral.NameSuffix,
                MaxParallelTasks = unixGeneral.MaxParallelTasks,
                Process = unixGeneral.Process,
                PreProcess = unixGeneral.PreProcess,
                PostProcess = unixGeneral.PostProcess,
                SapClient = unixGeneral.SapClient,
                SapSid = unixGeneral.SapSid,
                RoutineJob = unixGeneral.RoutineJob,
                ProcessName = unixGeneral.ProcessName,
                Documentation = unixGeneral.Documentation,
                Title = unixGeneral.Title,
                Archive1 = unixGeneral.Archive1,
                Archive2 = unixGeneral.Archive2,
                InternalAccount = unixGeneral.InternalAccount,
                Folder = unixGeneral.Folder,
                Queue = unixGeneral.Queue,
                Agent = unixGeneral.Agent,
                Login = unixGeneral.Login
            };

            string fileName = "sap.json";
            string jsonString = JsonSerializer.Serialize(unixGeneral, new JsonSerializerOptions { WriteIndented = true });

            byte[] bytes = Encoding.ASCII.GetBytes(jsonString);
            return File(bytes, "application/json", "unix.json");

        }


        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<UnixGeneralDto>>> UpdateUnixGeneral([FromBody] UnixGeneral updateUnixGeneral)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    //TODO:
        //    var unixGeneral = await _context.UnixGeneral.FindAsync(updateUnixGeneral);

        //    if (unixGeneral == null)
        //    {
        //        return NotFound();
        //    }

        //    unixGeneral.SapReport = updateUnixGeneral.SapReport;
        //    unixGeneral.UnixLogin = updateUnixGeneral.UnixLogin;
        //    unixGeneral.UnixServer = updateUnixGeneral.UnixServer;
        //    unixGeneral.Agent = updateUnixGeneral.Agent;
        //    unixGeneral.Active = updateUnixGeneral.Active;
        //    unixGeneral.Folder = updateUnixGeneral.Folder;
        //    unixGeneral.Login = updateUnixGeneral.Login;
        //    unixGeneral.Queue = updateUnixGeneral.Queue;
        //    unixGeneral.MaxParallelTasks = updateUnixGeneral.MaxParallelTasks;
        //    unixGeneral.OwnerId = updateUnixGeneral.OwnerId;
        //    unixGeneral.Process = updateUnixGeneral.Process;
        //    unixGeneral.ProcessName = updateUnixGeneral.ProcessName;
        //    unixGeneral.PreProcess = updateUnixGeneral.PreProcess;
        //    unixGeneral.PostProcess = updateUnixGeneral.PostProcess;

        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }

}
