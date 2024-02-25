using IMS_CIS_Controller.Models;
using IMS_CIS_Controller.Services;
using InterviewManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace InterviewMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<IMSDBContext>(options =>
                   options.UseSqlServer(ConnectionString));


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<RoleServices>();
            builder.Services.AddTransient<UserServices>();
            builder.Services.AddTransient<ResourceTypeServices>();
            builder.Services.AddTransient<RequirementInDetailServices>();
            builder.Services.AddTransient<BasicDetailsServices>();
            builder.Services.AddTransient<ApprovalServices>();
            builder.Services.AddTransient<JobSpecificationServices>();
            builder.Services.AddTransient<NameOfDMServices>();
            builder.Services.AddTransient<MrfListServices>();
            builder.Services.AddTransient<AdditionalInformationServices>();
            builder.Services.AddTransient<GradesServices>();
            builder.Services.AddTransient<RequirementTypeServices>();
            builder.Services.AddScoped<SourceServices>();
            builder.Services.AddScoped<RecruiterServices>();
            builder.Services.AddScoped<RecruitmentServices>();
            builder.Services.AddScoped<CandidateServices>();
            builder.Services.AddScoped<StatusServices>();
            builder.Services.AddTransient<IEDStatusMasterServices>();
            builder.Services.AddTransient<ManagementRoundServices>();
            builder.Services.AddTransient<HrclientRoundServices>();
            builder.Services.AddTransient<LevelMasterServices>();
            builder.Services.AddTransient<InterviewCommonServices>();
            builder.Services.AddTransient<ModeMasterServices>();
            builder.Services.AddTransient<ResultMasterServices>();
            builder.Services.AddTransient<TechnicalRoundServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}