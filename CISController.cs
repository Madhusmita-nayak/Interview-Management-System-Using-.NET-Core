using IMS_CIS_Controller.Services;
using IMS_CIS_Controller.ViewModels;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IMS_CIS_Controller.ViewModels.RecruitementsVM;

namespace IMS_CIS_Controller.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CISController : ControllerBase
    {
        private readonly SourceServices sourceService;
        private readonly CandidateServices candidateServices;
        private readonly RecruiterServices recruiterServices;
        private readonly RecruitmentServices recruitmentServices;
        private readonly StatusServices statusServices;

        public CISController(SourceServices sourceService, CandidateServices candidateServices, RecruiterServices recruiterServices, RecruitmentServices recruitmentServices, StatusServices statusServices)
        {
            this.sourceService = sourceService;
            this.candidateServices = candidateServices;
            this.recruiterServices = recruiterServices;
            this.recruitmentServices = recruitmentServices;
            this.statusServices = statusServices;
        }

        //Source Table
        [HttpPost("Add-Source")]
        public async Task<IActionResult> AddSource([FromBody] SourceVM _source)
        {
            string result =sourceService.AddSource(_source);
            if(result== "Successful")
                 return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpPut("Edit-Source")]
        public IActionResult UpdateSourceById(int id, [FromBody] SourceVM source)
        {
            var UpdateSource = sourceService.UpdateSourceById(id, source);
            if (UpdateSource != null)
            {
                return Ok(UpdateSource);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("Delete-Source")]
        public IActionResult DeleteSource(int id)
        {
            var result=sourceService.DeleteSource(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            { 
                return NotFound(result);
            }
        }

        [HttpGet("Get-Source-List")]
        public IActionResult GetSourceList()
        {
            try
            {
                var _result = sourceService.GetSourceList();
                return Ok(_result);
            }
            catch (Exception)
            {
                return BadRequest("Cannot fetch");
            }
        }
        [HttpGet("GetSourceDetail/{id}")]
        public IActionResult GetSourceDetail(int id)
        {
            var source = sourceService.GetSourceDetail(id);
            if (source == null)
            {
                return NotFound();
            }
            return Ok(source);
        }

        //Status Table
        [HttpPost("Add-Status")]
        public IActionResult AddStatus([FromBody] StatusVM _status)
        {
            statusServices.AddStatus(_status);
            return Ok();
        }
        [HttpPut("Edit-Status")]
        public IActionResult UpdateStatusById(int id, [FromBody] StatusVM status)
        {
            var UpdateSource = statusServices.EditStatus(id,status);
            return Ok(UpdateSource);
        }
        [HttpDelete("Delete-Status")]
        public IActionResult DeleteStatus(int id)
        {
            statusServices.DeleteStatus(id);
            return Ok();
        }

        [HttpGet("Get-Status-List")]
        public IActionResult GetStatusList()
        {
            try
            {
                var _result = statusServices.GetStatusName();
                return Ok(_result);
            }
            catch (Exception)
            {
                return BadRequest("Cannot fetch");
            }
        }
        [HttpGet("Get_Status_Detail/{id}")]
        public IActionResult GetStatusDetail(int id)
        {
            var source = statusServices.GetStatusDetails(id);
            if (source == null)
            {
                return NotFound();
            }
            return Ok(source);
        }


        //Recruiter Table
        [HttpPost("Add-Recruiter")]
        public IActionResult AddRecruiter([FromBody] RecruiterVM recruiterVM)
        {

            try
            {
                recruiterServices.AddRecruiter(recruiterVM);
                return Ok("Done");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Edit-Recruiter")]
        public IActionResult UpdateRecruiterDetailById(int id, [FromBody] RecruiterVM recruiterVM)
        {
            try
            {
                recruiterServices.EditRecruiterDetail(id, recruiterVM);
                return Ok("updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete-Recruiter{id}")]
        public IActionResult DeleteRecruiter(int id)
        {
            try
            {
                recruiterServices.DeleteRecruiter(id);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Get-Recruiter-Detail/{id}")]
        public IActionResult GetRecruiterDetail(int id)
        {
            try
            {
                var result = recruiterServices.GetRecruiterDetail(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Get-Recruiter-List")]
        public IActionResult GetRecruiterList()
        {
            try
            {
                var result = recruiterServices.GetRecruiterList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //candidate table
        [HttpPost("Add-Candidate")]
        public IActionResult AddCandidate([FromBody] CandidateVM candidate)
        {
            candidateServices.AddCandidate(candidate);
            return Ok();
        }
        [HttpPut("Edit-Candidate")]
        public IActionResult UpdateSourceById(int id, [FromBody] CandidateVM candidate)
        {
            var UpdateSource = candidateServices.EditCandidate(id, candidate);
            return Ok(UpdateSource);
        }
        [HttpDelete("Delete-Candidate")]
        public IActionResult DeleteCandidate(int id)
        {
            string status = candidateServices.DeleteCandidate(id);
            if (status == "Successful")
            {
                return Ok(status);
            }
            else
            {
                return NotFound(status);
            }
        }

        [HttpGet("Get-Candidate-List")]
        public IActionResult GetCandidateList()
        {
            try
            {
                var _result = candidateServices.GetCandidateList();
                return Ok(_result);
            }
            catch (Exception)
            {
                return BadRequest("Cannot fetch");
            }
        }
        [HttpGet("GetCandidateDetail/{id}")]
        public IActionResult GetCandidateDetail(int id)
        {
            var source = candidateServices.GetCandidateDetail(id);
            if (source == null)
            {
                return NotFound();
            }
            return Ok(source);
        }



        //recruitment table

        [HttpPost("Save-Recruitment-Detail")]
        public IActionResult SaveRecruitmentDetail([FromBody] RecruitmentCandidateVM recruitmentCandidateVM)
        {
            recruitmentServices.SaveRecruitmentWithCandidate(recruitmentCandidateVM);
            return Ok();
        }

        [HttpPut("Edit-Recruitment-Details")]

        public IActionResult UpdateRecruitmentDetails(int recruitmentID, [FromBody] RecruitmentVM recruitmentVM)
        {
            var updateRecruitment = recruitmentServices.UpdateRecruitmentDetails(recruitmentID, recruitmentVM);
            return Ok(updateRecruitment);
        }

        [HttpDelete("Delete-Recruitment")]
        public IActionResult DeleteRecruitment(int recruitmentID)
        {
            recruitmentServices.DeleteRecruitment(recruitmentID);
            return Ok();
        }
        [HttpGet("Get-Recruitment-list")]
        public IActionResult GetRecruitmentList()
        {

            try
            {
                var _result = recruitmentServices.GetRecruitmentList();
                return Ok(_result);
            }
            catch (Exception)
            {
                return BadRequest("Cannot Get Recruitment List");
            }
        }

        [HttpGet("Get-Interested-Candidate-list")]
        public IActionResult GetInterestedCandidateList()
        {

            try
            {
                var _result = recruitmentServices.GetInterestedCandidateList();
                return Ok(_result);
            }
            catch (Exception)
            {
                return BadRequest("Cannot Get Recruitment List");
            }
        }

    }
}
