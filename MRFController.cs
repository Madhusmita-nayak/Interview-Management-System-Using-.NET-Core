using InterviewManagementSystem.Services;
using InterviewManagementSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewManagementSystem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MRFController : ControllerBase
    {
        private readonly RoleServices _roleService;
        private readonly UserServices _userService;
        private readonly ResourceTypeServices _resourceService;
        private readonly RequirementInDetailServices _requirementInDetailService;
        private readonly JobSpecificationServices _jobSpecificationService;
        private readonly BasicDetailsServices _basicDetailsService;
        private readonly ApprovalServices _approvalServices;
        private readonly MrfListServices _mrfListServices;
        private readonly NameOfDMServices _nameofDMService;
        private readonly AdditionalInformationServices _additionalInformationService;
        private readonly GradesServices _gradesService;
        private readonly RequirementTypeServices _requirementTypeService;

        public MRFController(RoleServices roleService, UserServices userService,
            ResourceTypeServices resourceService,
            RequirementInDetailServices requirementInDetailService,
            JobSpecificationServices jobSpecificationService,
            BasicDetailsServices basicDetailsService,
        ApprovalServices approvalServices,
        MrfListServices mrfListServices,
            NameOfDMServices nameofDMService,
            AdditionalInformationServices additionalInformationService,
            GradesServices gradesService,
            RequirementTypeServices requirementTypeService)
        {
            _roleService = roleService;
            _userService = userService;
            _resourceService = resourceService;
            _requirementInDetailService = requirementInDetailService;
            _jobSpecificationService = jobSpecificationService;
            _basicDetailsService = basicDetailsService;
            _approvalServices = approvalServices;
            _mrfListServices = mrfListServices;
            _nameofDMService = nameofDMService;
            _additionalInformationService = additionalInformationService;
            _gradesService = gradesService;
            _requirementTypeService = requirementTypeService;
        }



        //Get All Roles
        [HttpGet("Get-All-Roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleService.GetAllRoleAsync();
            return Ok(roles);
        }

        [HttpPost("Add-Roles")]
        public async Task<IActionResult> AddRole([FromBody] RoleVM role)
        {
            if (role == null)
            {
                return BadRequest("Role data is invalid.");
            }

            // Set the CreatedOn and ModifiedOn fields
            //role.CreatedOn = DateTime.UtcNow;
            //role.ModifiedOn = DateTime.UtcNow;

            await _roleService.AddRoleAsync(role);

            return Ok("Role added successfully");
        }


        [HttpDelete("Delete-Role/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var success = await _roleService.DeleteRoleAsync(id);

            if (!success)
            {
                return NotFound($"Role with ID {id} not found");
            }

            return Ok("Successfully Deleted");
        }


        //GET ALL USERS
        [HttpGet("Get-All-Users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        //ADD USER
        [HttpPost("Add-User")]
        public async Task<IActionResult> AddUser([FromBody] UserVM user)
        {
            if (user == null)
            {
                return BadRequest("User data is invalid.");
            }

            try
            {
                await _userService.AddUserAsync(user);


                return Ok("User added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //HTTP FOR USER UPDATE
        [HttpPut("Update-User/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserVM updatedUser)
        {
            if (updatedUser == null)
            {
                return BadRequest("Invalid user data");
            }

            var user = await _userService.UpdateUserAsync(id, updatedUser);

            if (user == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            return Ok(user);
        }

        // DELETE api/users/5 DELETE USER
        [HttpDelete("Delete-User/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var success = await _userService.DeleteUserAsync(id);

            if (!success)
            {
                return NotFound($"User with ID {id} not found");
            }

            return NoContent();
        }
        //GetAllResources
        [HttpGet("Get-All-Resources")]
        public async Task<IActionResult> GetAllResources()
        {
            try
            {
                var resources = await _resourceService.GetAllResourcesAsync();
                return Ok(resources);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving resources.");
            }
        }



        //GETRESOURCEBYID
        [HttpGet("Get-Resource-By-Id/{id}")]
        public async Task<ActionResult<ResourceVM>> GetResourceById(int id)
        {
            var resource = await _resourceService.GetResourceByIdAsync(id);

            if (resource == null)
            {
                return NotFound($"Resource with ID {id} not found");
            }

            return Ok(resource);
        }

        //HTTP ADDRESOURCE
        [HttpPost("Add-Resource")]
        public async Task<IActionResult> AddResource([FromBody] ResourceVM resource)
        {
            if (resource == null)
            {
                return BadRequest("Invalid resource data.");
            }

            try
            {
                var addedResource = await _resourceService.AddResourceAsync(resource);

                if (addedResource != null)
                {
                    return Ok(addedResource);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Failed to add the resource.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //HTTP UPDATERESOURCETYPE
        [HttpPut("Update-Resource-By-Id/{id}")]
        public async Task<IActionResult> UpdateResource(int id, [FromBody] ResourceVM updatedResource)
        {
            if (updatedResource == null)
            {
                return BadRequest("Invalid resource data");
            }

            var resource = await _resourceService.UpdateResourceAsync(id, updatedResource);

            if (resource == null)
            {
                return NotFound($"Resource with ID {id} not found");
            }

            return Ok(resource);
        }
        //HTTPDELETERESOURCETYPE
        [HttpDelete("Delete-Resource-By-Id/{id}")]
        public async Task<IActionResult> DeleteResource(int id)
        {
            var success = await _resourceService.DeleteResourceAsync(id);

            if (!success)
            {
                return NotFound($"Resource with ID {id} not found");
            }

            return Ok("Deleted Successfuly");
        }

        //Get All Requirement
        [HttpGet("Get-All-Requirments-Details")]
        public IActionResult GetAllRequirementDetails()
        {
            var AllDetails = _requirementInDetailService.GetRequirementInDetails();
            return Ok(AllDetails);
        }

        [HttpGet("Get-All-Requirement-Details-By-Id/{id}")]
        public IActionResult GetRequirmentDetailsById(int id)
        {
            var AllDetails = _requirementInDetailService.GetRequirementInDetailsById(id);
            return Ok(AllDetails);
        }

        //Add Requirement master
        [HttpPost("Add-Requirement-Details")]
        public IActionResult AddRequirementInDetails([FromBody] RequirementInDetailsVM requirementInDetails)
        {
            _requirementInDetailService.AddRequirementInDetails(requirementInDetails);
            return Ok();
        }


        [HttpPut("Update-Requirement-In-Details-By-Id/{id}")]
        public IActionResult UpdateRequirementInDetails(int id, [FromBody] RequirementInDetailsVM requirementInDetails)
        {
            var AllUpdate = _requirementInDetailService.UpdateRequirementInDetailsbyId(id, requirementInDetails);
            return Ok(AllUpdate);
        }

        [HttpDelete("Delete-Requirement-In-Details-By-Id/{id}")]
        public IActionResult DeleteRequirementInDetails(int id)
        {
            _requirementInDetailService.DeleteRequirementInDetails(id);
            return Ok();
        }


        [HttpGet("Get-All-DM-Names")]
        public IActionResult getAllDetails()
        {
            var allDetails = _nameofDMService.GetDMName();
            return Ok(allDetails);
        }

        [HttpGet("Get-All-DM-Names-By-Id/{id}")]
        public IActionResult getAllDetailsById(int id)
        {
            var details = _nameofDMService.GetDMNameById(id);
            if (details == null)
            {
                return NotFound($"Requirement Type with ID {id} does not exist.");
            }
            return Ok(details);
        }


        [HttpPost("Add-DMName-type")]
        public IActionResult AddDMName([FromBody] DmNameVM dMName)
        {
            if (dMName == null)
            {
                return BadRequest("Is Null. Please Insert Some Values");
            }
            try
            {
                _nameofDMService.AddDM(dMName);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Insertion Failed");
            }
        }

        [HttpPut("update-Dm-details-by-id/{id}")]
        public IActionResult UpdateDMDetailsById(int id, [FromBody] DmNameVM dMName)
        {
            try
            {
                var updatedRequirement = _nameofDMService.UpdateDMNamebyId(id, dMName);
                if (updatedRequirement == null)
                {
                    return NotFound($"Requirement with ID {id} does not exist.");
                }
                return Ok(updatedRequirement);
            }
            catch (Exception)
            {
                return BadRequest("Update Failed");
            }
        }

        [HttpDelete("Delete-DM-Details-By-Id/{id}")]
        public IActionResult DeleteDMDetails(int id)
        {
            try
            {
                _nameofDMService.DeleteDMName(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Delete failed");
            }
        }



        [HttpPost("add-requirement-type")]

        public IActionResult AddRequirementTypes([FromBody] RequirementTypeVM requirement)
        {
            if (requirement == null)
            {
                return BadRequest("Is Null. Please Insert Some Values");
            }
            try
            {
                _requirementTypeService.AddRequirementType(requirement);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Insertion Failed");
            }
        }

        [HttpGet("get-all-requirements")]

        public IActionResult GetAllRequirements()
        {
            var allRequirements = _requirementTypeService.GetRequirementTypes();
            return Ok(allRequirements);

        }

        [HttpGet("get-requirement-by-id/{id}")]

        public IActionResult GetRequirementsById(int id)
        {

            var requirement = _requirementTypeService.GetRequirementTypeById(id);
            if (requirement == null)
            {
                return NotFound($"Requirement Type with ID {id} does not exist.");
            }
            return Ok(requirement);

        }

        [HttpPut("update-requirement-by-id/{id}")]
        public IActionResult UpdateRequirementsById(int id, [FromBody] RequirementTypeVM requirement)
        {
            try
            {
                var updatedRequirement = _requirementTypeService.UpdateRequirementTypebyId(id, requirement);
                if (updatedRequirement == null)
                {
                    return NotFound($"Requirement with ID {id} does not exist.");
                }
                return Ok(updatedRequirement);
            }
            catch (Exception)
            {
                return BadRequest("Update Failed");
            }
        }

        [HttpDelete("delete-requirement-by-id/{id}")]

        public IActionResult DeleteRequirementById(int id)
        {
            try
            {
                _requirementTypeService.DeleteRequirementType(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Delete failed");
            }
        }




        [HttpGet("get-all-grades")]

        public IActionResult GetAllGrades()
        {
            var allGrades = _gradesService.GetAllGrades();
            return Ok(allGrades);

        }

        [HttpGet("get-grade-by-id/{id}")]

        public IActionResult GetGradeById(int id)
        {

            var grade = _gradesService.GetGradeById(id);
            if (grade == null)
            {
                return NotFound($"Grade with ID {id} does not exist.");
            }
            return Ok(grade);

        }

        [HttpPost("add-grades")]

        public IActionResult AddGrade([FromBody] GradeVM grade)
        {
            if (grade == null)
            {
                return BadRequest("Is Null. Please Insert Some Values");
            }
            try
            {
                _gradesService.AddGrade(grade);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Insertion Failed");
            }
        }


        [HttpPut("update-grade-by-id/{id}")]
        public IActionResult UpdateGradeById(int id, [FromBody] GradeVM grade)
        {
            try
            {
                var updatedGrade = _gradesService.UpdateGradebyId(id, grade);
                if (updatedGrade == null)
                {
                    return NotFound($"Grade with ID {id} does not exist.");
                }
                return Ok(updatedGrade);
            }
            catch (Exception)
            {
                return BadRequest("Update Failed");
            }
        }

        [HttpDelete("delete-grade-by-id/{id}")]

        public IActionResult DeleteGradeById(int id)
        {
            try
            {
                _gradesService.DeleteGrade(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Delete failed");
            }
        }



        [HttpGet("get-all-jobspecification")]

        public IActionResult GetAllJobSpecification()
        {
            var alljob = _jobSpecificationService.GetAllJobSpecification();
            return Ok(alljob);
        }

        [HttpGet("get-jobspecification-by-id/{id}")]

        public IActionResult GetJobSpecificationById(int id)
        {
            var singlejob = _jobSpecificationService.GetJobSpecificationById(id);
            return Ok(singlejob);
        }

        [HttpPost("add-jobspecification")]

        public IActionResult AddJobSpecification([FromBody] JobSpecificationVM jobSpecification)
        {
            _jobSpecificationService.AddJobSpecification(jobSpecification);
            return Ok();
        }

        [HttpPut("update-jobspecification-by-id/{id}")]

        public IActionResult UpdateJobSpecificationById(int id, [FromBody] JobSpecificationVM jobSpecification)
        {
            var updatejobspecification = _jobSpecificationService.UpdateJobSpecificationById(id, jobSpecification);
            return Ok(updatejobspecification);
        }


        [HttpDelete("delete-jobspecification-by-id/{id}")]

        public IActionResult DeleteJobSpecificationById(int id)
        {
            _jobSpecificationService.DeleteJobSpecificatonById(id);
            return Ok();
        }





        [HttpGet("get-all-basicdetails")]
        public async Task<IActionResult> GetAllBasicDetails()
        {
            var basicDetails = await _basicDetailsService.GetBasicDetailsAsync();
            return Ok(basicDetails);
        }

        [HttpGet("get-basicdetails-by-id/{id}")]

        public async Task<IActionResult> GetBasicDetailsById(int id)
        {
            var basicDetails = await _basicDetailsService.GetBasic_DetailsByIdAsync(id);

            if (basicDetails != null)
            {
                return Ok(basicDetails);

            }
            else
            {
                return NotFound($"Basic details of that Id {id} don't exist");
            }
        }

        [HttpGet("get-basicdetails-by-jobRequestNumber/{jobReqId}")]

        public async Task<IActionResult> GetBasicDetailsByJobReqNum(int jobReqId)
        {
            var basicDetails = await _basicDetailsService.GetBasic_DetailsByJobRequestAsync(jobReqId);
            if (basicDetails != null)
            {
                return Ok(basicDetails);

            }
            else
            {
                return NotFound($"Basic details of that Job Request Number {jobReqId} don't exist");
            }

        }


        [HttpPost("add-basicdetasils")]

        public async Task<IActionResult> AddBasicDetails([FromBody] BasicDetailsVM basicDetails)
        {
            if (basicDetails == null)
            {
                return BadRequest("Data inserted is invalid");

            }

            try
            {
                await _basicDetailsService.AddBasic_DetailsAsync(basicDetails);
                return Ok("Basic details added successfully");
            }
            catch (Exception)
            {
                return BadRequest("Data insertion failed");
            }
        }

        //Update

        [HttpPut("update_basic-details/{id}")]

        public async Task<IActionResult> UpdateBasicDetails(int id, [FromBody] BasicDetailsVM basicDetails)
        {
            if (basicDetails == null)
            {
                return BadRequest("Invalid Data");
            }
            try
            {
                var basic_details = await _basicDetailsService.UpdateBasicDetailsByIdAsync(id, basicDetails);
                if (basic_details == null)
                {
                    return NotFound($"Basic Details of ID {id} not found");
                }
                return Ok(basic_details);
            }
            catch (Exception ex)
            {
                return BadRequest("Update Failed. Please Fill in all the Required Data.");
            }


        }

        //Delete

        [HttpDelete("delete-basic-details/{id}")]

        public async Task<IActionResult> DeleteBasicDetails(int id)
        {
            var success = await _basicDetailsService.DeleteBasicDetailsAsync(id);
            if (!success)
            {
                return NotFound($"Basic details of ID {id} not found");
            }

            return NoContent();

        }


        [HttpGet("Get-Approval")]
        public IActionResult GetApproval()
        {
            var AllDetails = _approvalServices.GetApprovals();
            return Ok(AllDetails);
        }

        [HttpGet("Get-Approval-By-Id/{id}")]
        public IActionResult GetApprovalById(int id)
        {
            var AllDetails = _approvalServices.GetApproval(id);
            return Ok(AllDetails);
        }

        [HttpPost("Add-Approval")]
        public IActionResult AddApproval([FromBody] ApprovalVM approval)
        {

            _approvalServices.AddApproval(approval);
            return Ok();
        }

        [HttpPut("Update-Approval-By-Id/{id}")]
        public IActionResult UpdateApproval(int id, [FromBody] ApprovalVM approval)
        {
            var AllUpdate = _approvalServices.UpdateApprovalById(id, approval);
            return Ok(AllUpdate);
        }

        [HttpDelete("Delete-Approval/{id}")]
        public IActionResult Approval(int id)
        {
            _approvalServices.DeleteApproval(id);
            return Ok();
        }

        [HttpGet("get-all-mrf-details")]
        public async Task<IActionResult> GetAllMrfList()
        {
            try
            {
                List<MrfVM> mrfList = await _mrfListServices.GetAllMrfDetailsAsync();
                return Ok(mrfList);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }




        [HttpGet("get-all-additionalinformation")]

        public IActionResult GetAllAdditionalInformation()
        {
            var alladditionalinformation = _additionalInformationService.GetAllAdditionalInformation();
            return Ok(alladditionalinformation);
        }

        [HttpGet("get-additionalinformation-by-id/{id}")]

        public IActionResult GetAdditionalInformationById(int id)
        {
            var singleadditionalinformation = _additionalInformationService.GetAdditionalInformationById(id);
            return Ok(singleadditionalinformation);
        }

        [HttpPost("add-additionalinformation")]

        public IActionResult AddAdditionalInformation([FromBody] AdditionalInformationVM additionalInformation)
        {
            _additionalInformationService.AddAdditionalInformation(additionalInformation);
            return Ok();
        }
        [HttpPut("update-additionalinformation-by-id/{id}")]

        public IActionResult UpdateAdditionalInformationById(int id, [FromBody] AdditionalInformationVM aditionalInformation)
        {
            var updateadditionalinformation = _additionalInformationService.UpdateAdditionalInformationById(id, aditionalInformation);
            return Ok(updateadditionalinformation);
        }


        [HttpDelete("delete-additionalinformation-by-id/{id}")]

        public IActionResult DeleteAdditionalInformationById(int id)
        {
            _additionalInformationService.DeleteAdditionalInformationById(id);
            return Ok();
        }
    }
}
