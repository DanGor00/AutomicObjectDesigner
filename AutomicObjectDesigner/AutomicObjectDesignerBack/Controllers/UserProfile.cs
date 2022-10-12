﻿using AutomicObjectDesignerBack.Controllers.ObjectContollers;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.List;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Repository;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize(Roles = "User,Admin")]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;
        private readonly IWindowsGeneralRepository _windowsGeneralRepository;
        private readonly IUnixGeneralRepository _unixGeneralRepository;
        private readonly ISapSimpleRepository _sapSimpleRepository;
        private readonly ISapJobBwChainRepository _sapJobBwChainRepository;

        public UserProfileController(AppDatabaseContext context, ILogger<UserProfileController> logger,
            IWindowsGeneralRepository windowsRepository, IUnixGeneralRepository unixGeneralRepository,
            ISapSimpleRepository sapSimpleRepository, ISapJobBwChainRepository sapJobBwChainRepository)
        {
            _windowsGeneralRepository = windowsRepository;
            _unixGeneralRepository = unixGeneralRepository;
            _sapSimpleRepository = sapSimpleRepository;
            _sapJobBwChainRepository = sapJobBwChainRepository;
            _logger = logger;
        }
        // GET  https://localhost:7017/api/UserProfile
        [HttpGet]
        public ActionResult<ListObjects> GetFiles(int userId)
        {
            _logger.LogInformation($"UserProfile called with User ID: {userId}...");

            var win = _windowsGeneralRepository.FindByCondition((h => h.Id == userId)).ToList();

            var windowsGeneral = _windowsGeneralRepository.GetAll().ToList();
            var sapJobBwChain = _sapJobBwChainRepository.GetAll().ToList();
            var unixGeneral = _unixGeneralRepository.GetAll().ToList();
            var sapSimple = _sapSimpleRepository.GetAll().ToList();


            var listObjects = new ListObjects(windowsGeneral, sapJobBwChain, unixGeneral, sapSimple);

            return Ok(listObjects);
        }
    }
}