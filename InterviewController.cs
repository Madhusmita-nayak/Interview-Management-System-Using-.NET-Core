using IMS_CIS_Controller.Models.MasterTables;
using InterviewManagementSystem.Services;
using InterviewManagementSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewManagementSystem.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class InterviewController : ControllerBase
    {
        private readonly ModeMasterServices _modeMasterService;
        public HrclientRoundServices _hrclient;
        private LevelMasterServices _levelSevice;
        private ResultMasterServices _resultService;
        private IEDStatusMasterServices _iEDStatusService;
        private TechnicalRoundServices _technical;
        private ManagementRoundServices _management;
        private InterviewCommonServices _interview;
        public InterviewController(HrclientRoundServices hrclient, InterviewCommonServices interview, ModeMasterServices modeMasterService, LevelMasterServices levelSevice, ResultMasterServices resultService, IEDStatusMasterServices iEDStatusService, TechnicalRoundServices technical, ManagementRoundServices management)
        {
            _modeMasterService = modeMasterService;
            _levelSevice = levelSevice;
            _resultService = resultService;
            _iEDStatusService = iEDStatusService;
            _technical = technical;
            _management = management;
            _interview = interview;
            _hrclient = hrclient;
        }

        //IED
        [HttpPost("IEDStatusMaster-Add-Data")]
        public IActionResult AddIEDStatus([FromBody] IEDStatusMasterVM iedstatusMaster)
        {
            _iEDStatusService.AddIEDStatus(iedstatusMaster);
            return Ok();
        }
        [HttpGet("IEDStatusMaster-Get-All-Data")]
        public IActionResult GetAllIED()
        {
            var allIED = _iEDStatusService.GetAllIED();
            return Ok(allIED);
        }




        [HttpPut("IEDStatusMaster-Update-Data/{id}")]
        public IActionResult UpdateIED(int id, [FromBody] IEDStatusMasterVM iedstatus)
        {
            var updatedIED = _iEDStatusService.UpdateIEDStatusById(id, iedstatus);
            if (updatedIED != null)
            {
                return Ok(updatedIED);
            }
            return NotFound();

        }
        [HttpDelete("IEDStatusMaster-Delete-Data/{id}")]
        public IActionResult DeleteIEDById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            _iEDStatusService.DeleteIEDById(id);
            return Ok();
        }

        //LevelMaster
        [HttpPost("LevelMaster-Add-Data")]
        public IActionResult AddLevel([FromBody] LevelMasterVM level)
        {


            _levelSevice.AddLevel(level);
            return Ok();
        }

        [HttpGet("LevelMaster-Get-All-Data")]
        public IActionResult GetAllLevels()
        {

            var allLevels = _levelSevice.GetAllLevel();
            return Ok(allLevels);
        }

        [HttpPut("LevelMaster-Update-Data/{id}")]
        public IActionResult UpdateLevel(int id, [FromBody] LevelMasterVM level)
        {
            var updatedLevel = _levelSevice.UpdatelevelById(id, level);
            if (updatedLevel != null)
            {
                return Ok(updatedLevel);
            }
            return NotFound();

        }
        [HttpDelete("LevelMaster-Delete-Data/{id}")]
        public IActionResult DeleteLevelById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            _levelSevice.DeleteLevelById(id);
            return Ok();
        }

        //ModeMaster
        [HttpGet("ModeMaster-Get-All-Data")]
        public async Task<ActionResult<IEnumerable<ModeMaster>>> GetModeMasters()
        {
            var modeMasters = await _modeMasterService.GetAllAsync();
            return Ok(modeMasters);
        }

        [HttpGet("ModeMaster-Get-By-Id/{id}")]
        public async Task<ActionResult<ModeMaster>> GetModeMaster(long id)
        {
            var modeMaster = await _modeMasterService.GetByIdAsync(id);

            if (modeMaster == null)
            {
                return NotFound();
            }

            return Ok(modeMaster);
        }

        [HttpPost("ModeMaster-Add-Data")]
        public async Task<ActionResult> PostModeMaster(ModeMasterViewModel modeMasterViewModel)
        {
            if (modeMasterViewModel == null)
            {
                return BadRequest();
            }

            var modeMaster = new ModeMaster
            {
                Name = modeMasterViewModel.Name,
                CreatedBy = modeMasterViewModel.CreatedBy,
                CreatedOn = modeMasterViewModel.CreatedOn,
                ModifiedBy = modeMasterViewModel.ModifiedBy,
                ModifiedOn = modeMasterViewModel.ModifiedOn,
            };

            await _modeMasterService.CreateAsync(modeMaster);
            return CreatedAtAction("GetModeMaster", new { id = modeMaster.Id }, modeMaster);
        }

        [HttpPut("ModeMaster-Update-Data/{id}")]
        public async Task<IActionResult> PutModeMaster(long id, [FromBody] ModeMaster modeMasterEntity)
        {
            if (id != modeMasterEntity.Id)
            {
                return BadRequest();
            }

            var modeMaster = new ModeMaster
            {
                Id = modeMasterEntity.Id, // Assign the id from the route to the entity
                Name = modeMasterEntity.Name,
                CreatedBy = modeMasterEntity.CreatedBy,
                CreatedOn = modeMasterEntity.CreatedOn,
                ModifiedBy = modeMasterEntity.ModifiedBy,
                ModifiedOn = modeMasterEntity.ModifiedOn,
            };

            await _modeMasterService.UpdateAsync(modeMaster);
            return Ok(modeMaster);
        }



        [HttpDelete("ModeMaster-Delete-Data/{id}")]
        public async Task<ActionResult> DeleteModeMaster(long id)
        {
            await _modeMasterService.DeleteAsync(id);
            return Ok();
        }

        //ResultMaster
        //result
        [HttpPost("ResultMaster-Add-Data")]
        public IActionResult AddResult([FromBody] ResultMasterVM result)
        {


            _resultService.AddResult(result);
            return Ok();
        }
        [HttpGet("ResultMaster-Get-All-Data")]
        public IActionResult GetAllResult()
        {

            var allResult = _resultService.GetAllResult();
            return Ok(allResult);
        }

        [HttpPut("ResultMaster-Update-Data/{id}")]
        public IActionResult UpdateResult(int id, [FromBody] ResultMasterVM result)
        {
            var updatedResult = _resultService.UpdateresultById(id, result);
            if (updatedResult != null)
            {
                return Ok(updatedResult);
            }
            return NotFound();

        }
        [HttpDelete("ResultMaster-Delete-Data/{id}")]
        public IActionResult DeleteResultById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            _resultService.DeleteResultById(id);
            return Ok();
        }


        //Technical Round

        [HttpPost("add-technical")]
        public IActionResult AddTechnical([FromBody] TechnicalRoundVM technical)
        {


            _technical.AddTechnicalRound(technical);
            return Ok();
        }

        [HttpGet("get-all-technicals")]
        public IActionResult GetAllTechnicals()
        {

            var allTechnical = _technical.GetTechnicalTable();
            return Ok(allTechnical);
        }

        [HttpGet("get-technical/{id}")]
        public IActionResult GetTechnicalRoundById(int id)
        {
            var technicalRound = _technical.GetTechnicalRoundById(id);
            if (technicalRound != null)
            {
                return Ok(technicalRound);
            }
            return NotFound();
        }


        [HttpPut("update-technical/{id}")]
        public IActionResult UpdateTechnicalRound(int id, [FromBody] TechnicalRoundVM technical)
        {
            var updatedTechnical = _technical.UpdateTechnicalRoundById(id, technical);
            if (updatedTechnical != null)
            {
                return Ok(updatedTechnical);
            }
            return NotFound();
        }


        [HttpDelete("delete-technical/{id}")]
        public IActionResult DeleteTechnicalRoundById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            _technical.DeleteTechnicalRoundById(id);
            return Ok();
        }



        [HttpPost("add-management")]
        public IActionResult AddManagement([FromBody] ManagementRoundVM management)
        {


            _management.AddManagementRound(management);
            return Ok();
        }

        [HttpGet("get-all-managements")]
        public IActionResult GetAllManagements()
        {

            var allManagement = _management.GetManagementTable();
            return Ok(allManagement);
        }

        [HttpGet("get-management/{id}")]
        public IActionResult GetManagementTableById(int id)
        {
            var managementRound = _management.GetManagementTableById(id);
            if (managementRound != null)
            {
                return Ok(managementRound);
            }
            return NotFound();
        }


        [HttpPut("update-management/{id}")]
        public IActionResult UpdateMangementRound(int id, [FromBody] ManagementRoundVM management)
        {
            var updatedManagement = _management.UpdateManagementRoundById(id, management);
            if (updatedManagement != null)
            {
                return Ok(updatedManagement);
            }
            return NotFound();
        }


        [HttpDelete("delete-management/{id}")]
        public IActionResult DeleteManagementRoundById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            _management.DeleteManagementRoundById(id);
            return Ok();
        }

        [HttpPost("add-interview")]
        public IActionResult AddInterview([FromBody] InterviewCommonVM interview)
        {


            _interview.AddInterviewCommonTable(interview);
            return Ok();
        }

        [HttpGet("get-all-interview")]
        public IActionResult GetInterviewCommon()
        {

            var allInterview = _interview.GetInterviewCommonTable();
            return Ok(allInterview);
        }

        [HttpGet("get-interview-by-Id/{id}")]
        public IActionResult GetInterviewCommonById(int id)
        {
            var interview = _interview.GetInterviewCommonTableById(id);
            return Ok(interview);
        }

        [HttpPut("update-interview/{id}")]
        public IActionResult UpdateInterview(int id, [FromBody] InterviewCommonVM interview)
        {
            var updatedInterview = _interview.UpdateInterviewById(id, interview);
            if (updatedInterview != null)
            {
                return Ok(updatedInterview);
            }
            return NotFound();

        }

        [HttpDelete("delete-interview/{id}")]
        public IActionResult DeleteInterviewById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            _interview.DeleteInterviewById(id);
            return Ok();
        }

        //HrClient api
        [HttpPost("add-hrclient")]
        public IActionResult AddHRClient([FromBody] HrclientRoundVM hrclient)
        {


            _hrclient.AddHrClientRound(hrclient);
            return Ok();
        }
        [HttpGet("get-all-hrclients")]
        public IActionResult GetAllHrclients()
        {

            var allHrclient = _hrclient.GetHrclientTable();
            return Ok(allHrclient);
        }

        [HttpGet("get-allHrclient/{id}")]
        public IActionResult GetHrclientTableById(int id)
        {
            var HrclientRound = _hrclient.GetHrclientRoundById(id);
            if (HrclientRound != null)
            {
                return Ok(HrclientRound);
            }
            return NotFound();
        }


        [HttpPut("update-hrclient/{id}")]
        public IActionResult UpdateHrclientRound(int id, [FromBody] HrclientRoundVM hrclient)
        {
            var updatedHrclient = _hrclient.UpdateHrclientRoundById(id, hrclient);
            if (updatedHrclient != null)
            {
                return Ok(updatedHrclient);
            }
            return NotFound();
        }


        [HttpDelete("delete-hrclient/{id}")]
        public IActionResult DeleteHrclinetRoundById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            _hrclient.DeleteHrclinetRoundById(id);
            return Ok();
        }
    }
}
