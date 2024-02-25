using IMS_CIS_Controller.Models.MasterTables;
using IMS_CIS_Controller.Models.TransactionTables;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace IMS_CIS_Controller.Models
{
    public class IMSDBContext : DbContext
    {

        public IMSDBContext(DbContextOptions<IMSDBContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MRF Tables
            //foreign key relationships
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserMaster>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<UserMaster>()
                .HasOne(u => u.CreatedBy)
                .WithMany()
                .HasForeignKey(u => u.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserMaster>()
                .HasOne(u => u.ModifiedBy)
                .WithMany()
                .HasForeignKey(u => u.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoleMaster>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResourceTypeMaster>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(rt => rt.CreatedById)
               .HasPrincipalKey(u => u.Id)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResourceTypeMaster>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(rt => rt.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RequirementTypeMaster>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(rt => rt.CreatedById)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RequirementTypeMaster>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(rt => rt.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeMaster>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(rt => rt.CreatedById)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeMaster>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(rt => rt.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DmNameMaster>()
              .HasOne<UserMaster>()
              .WithMany()
              .HasForeignKey(rt => rt.CreatedById)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DmNameMaster>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(rt => rt.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
               .HasOne<GradeMaster>()
               .WithMany()
               .HasForeignKey(bd => bd.Grade)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
               .HasOne<RequirementTypeMaster>()
               .WithMany()
               .HasForeignKey(bd => bd.RequirementType)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
                .HasOne<ResourceTypeMaster>()
                .WithMany()
                .HasForeignKey(bd => bd.ResourceType)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
                .HasOne<DmNameMaster>()
                .WithMany()
                .HasForeignKey(bd => bd.DmId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(bd => bd.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BasicDetail>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(bd => bd.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);
            //JOB SPECIFICATION
            modelBuilder.Entity<JobSpecification>()
              .HasOne<BasicDetail>()
              .WithMany()
              .HasForeignKey(js => js.BasicDetailId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobSpecification>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(js => js.CreatedBy)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobSpecification>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(js => js.ModifiedBy)
                 .OnDelete(DeleteBehavior.Restrict);
            //REQUIREMENT IN DETAILS
            modelBuilder.Entity<RequirementInDetail>()
            .HasOne<BasicDetail>()
            .WithMany()
            .HasForeignKey(js => js.BasicDetailId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RequirementInDetail>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(js => js.CreatedBy)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RequirementInDetail>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(js => js.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);
            //APPROVAL
            modelBuilder.Entity<Approval>()
           .HasOne<BasicDetail>()
           .WithMany()
           .HasForeignKey(js => js.BasicDetailId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Approval>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(js => js.CreatedBy)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Approval>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(js => js.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);
            //ADDITIONALINFORMATION
            modelBuilder.Entity<Additionalnformation>()
           .HasOne<BasicDetail>()
           .WithMany()
           .HasForeignKey(js => js.BasicDetailId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Additionalnformation>()
                .HasOne<UserMaster>()
                .WithMany()
                .HasForeignKey(js => js.CreatedBy)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Additionalnformation>()
               .HasOne<UserMaster>()
               .WithMany()
               .HasForeignKey(js => js.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Additionalnformation>()
              .Property(ai => ai.Project_Revenue)
              .HasColumnType("decimal(18, 2)");
           


            //CIS Tables
            modelBuilder.Entity<Candidate>()
                .HasOne(Candidate=>Candidate.CreatedByAppUser)
                .WithMany(user => user.CandidateCreated)
                .HasForeignKey(candidate => candidate.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict)
                ;

            modelBuilder.Entity<Candidate>()
                 .HasOne(Candidate=>Candidate.ModifiedByAppUser)
                 .WithMany(user=>user.CandidateModified)
                 .HasForeignKey(candidate => candidate.ModifiedBy)
                 .OnDelete(DeleteBehavior.NoAction);





            modelBuilder.Entity<Recruiter>()
                .HasOne(Recruiter=>Recruiter.CreatedByAppUser)
                .WithMany(User=>User.RecruiterCreated)
                .HasForeignKey(recruiter => recruiter.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Recruiter>()
                .HasOne(Recruiter=>Recruiter.ModifiedByAppUser)
                .WithMany(User=>User.RecruiterModified)
                .HasForeignKey(recruiter => recruiter.ModifiedBy)
                .OnDelete(DeleteBehavior.NoAction);




            modelBuilder.Entity<Status>()
                .HasOne(Status=>Status.CreatedByAppUser)
                .WithMany(User=>User.StatusCreated)
                .HasForeignKey(status => status.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Status>()
                .HasOne(Status=>Status.ModifiedByAppUser)
                .WithMany(User=>User.StatusModified)
                .HasForeignKey(status => status.ModifiedBy)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Source>()
                .HasOne(Source=>Source.CreatedByAppUser)
                .WithMany(User=>User.SourceCreated)
                .HasForeignKey(source => source.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Source>()
                .HasOne(Source=>Source.ModifiedByAppUser)
                .WithMany(User=>User.SourceModified)
                .HasForeignKey(source => source.ModifiedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Recruitment>()
                .HasOne(Recruitment=>Recruitment.CreatedByAppUser)
                .WithMany()
                .HasForeignKey(recruitment => recruitment.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Recruitment>()
                .HasOne(Recruitment=>Recruitment.ModifiedByAppUser)
                .WithMany()
                .HasForeignKey(recruitment => recruitment.ModifiedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Recruitment>()
                .HasOne(recruitment => recruitment.candidate)
                .WithMany(appUser => appUser.Recruitment)
                .HasForeignKey(recruitment => recruitment.CandidateID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Recruitment>()
                .HasOne(recruitment => recruitment.recruiter)
                .WithMany(appUser => appUser.Recruitment)
                .HasForeignKey(recruitment => recruitment.RecruiterID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Recruitment>()
                .HasOne(recruitment => recruitment.source)
                .WithMany(appUser => appUser.Recruitment)
                .HasForeignKey(recruitment => recruitment.SourceID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Recruitment>()
                .HasOne(recruitment => recruitment.Status)
                .WithMany(appUser => appUser.Recruitment)
                .HasForeignKey(recruitment => recruitment.StatusId)
                .OnDelete(DeleteBehavior.NoAction);

            //Interview Tables
            // Relationship between HRClientRound and InterviewCommon
            modelBuilder.Entity<HRClientRound>()
                .HasOne(hr => hr.InterviewCommon)
                .WithMany(ic => ic.HRClientRounds)
                .HasForeignKey(hr => hr.InterviewCommonId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between HRClientRound and ModeMaster
            modelBuilder.Entity<HRClientRound>()
                .HasOne(hr => hr.ModeMaster)
                .WithMany()
                .HasForeignKey(hr => hr.ModeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between HRClientRound and ResultMaster
            modelBuilder.Entity<HRClientRound>()
                .HasOne(hr => hr.ResultMaster)
                .WithMany()
                .HasForeignKey(hr => hr.ResultId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between HRClientRound and IEDStatusMaster
            modelBuilder.Entity<HRClientRound>()
                .HasOne(hr => hr.IEDStatusMaster)
                .WithMany()
                .HasForeignKey(hr => hr.IEDStatusId)
                .OnDelete(DeleteBehavior.NoAction);

            // And similar relationships for other entities...

            // Relationship between TechnicalRound and InterviewCommon
            modelBuilder.Entity<TechnicalRound>()
                .HasOne(tr => tr.InterviewCommon)
                .WithMany(ic => ic.TechnicalRounds)
                .HasForeignKey(tr => tr.InterviewCommonId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between TechnicalRound and ModeMaster
            modelBuilder.Entity<TechnicalRound>()
                .HasOne(tr => tr.ModeMaster)
                .WithMany()
                .HasForeignKey(tr => tr.ModeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between TechnicalRound and ResultMaster
            modelBuilder.Entity<TechnicalRound>()
                .HasOne(tr => tr.ResultMaster)
                .WithMany()
                .HasForeignKey(tr => tr.ResultId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between TechnicalRound and IEDStatusMaster
            modelBuilder.Entity<TechnicalRound>()
                .HasOne(tr => tr.IEDStatusMaster)
                .WithMany()
                .HasForeignKey(tr => tr.IEDStatusId)
                .OnDelete(DeleteBehavior.NoAction);

            // Other relationships...

            // Relationship between ManagementRound and InterviewCommon
            modelBuilder.Entity<ManagementRound>()
                .HasOne(mr => mr.InterviewCommon)
                .WithMany(ic => ic.ManagementRounds)
                .HasForeignKey(mr => mr.InterviewCommonId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between TechnicalRound and LevelMaster
            modelBuilder.Entity<TechnicalRound>()
                .HasOne(tr => tr.LevelMaster)
                .WithMany()
                .HasForeignKey(tr => tr.LevelId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between ManagementRound and ModeMaster
            modelBuilder.Entity<ManagementRound>()
                .HasOne(mr => mr.ModeMaster)
                .WithMany()
                .HasForeignKey(mr => mr.ModeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship between ManagementRound and ResultMaster
            modelBuilder.Entity<ManagementRound>()
                .HasOne(mr => mr.ResultMaster)
                .WithMany()
                .HasForeignKey(mr => mr.ResultId)
                .OnDelete(DeleteBehavior.NoAction);
            // Relationship between Each table with UserMaster table
            modelBuilder.Entity<IEDStatusMaster>()
               .HasOne(Candidate => Candidate.CreatedByAppUser)
               .WithMany(user => user.IEDStatusCreated)
               .HasForeignKey(candidate => candidate.CreatedBy)
               .OnDelete(DeleteBehavior.Restrict)
               ;
            modelBuilder.Entity<IEDStatusMaster>()
               .HasOne(Candidate => Candidate.ModifiedByAppUser)
               .WithMany(user => user.IEDStatusModified)
               .HasForeignKey(candidate => candidate.CreatedBy)
               .OnDelete(DeleteBehavior.Restrict)
               ;
            modelBuilder.Entity<LevelMaster>()
              .HasOne(Candidate => Candidate.CreatedByAppUser)
              .WithMany(user => user.LevelMasterCreated)
              .HasForeignKey(candidate => candidate.CreatedBy)
              .OnDelete(DeleteBehavior.Restrict)
              ;
            modelBuilder.Entity<LevelMaster>()
              .HasOne(Candidate => Candidate.ModifiedByAppUser)
              .WithMany(user => user.LevelModified)
              .HasForeignKey(candidate => candidate.CreatedBy)
              .OnDelete(DeleteBehavior.Restrict)
              ;
            modelBuilder.Entity<ModeMaster>()
             .HasOne(Candidate => Candidate.CreatedByAppUser)
             .WithMany(user => user.ModeMasterCreated)
             .HasForeignKey(candidate => candidate.CreatedBy)
             .OnDelete(DeleteBehavior.Restrict)
             ;
            modelBuilder.Entity<ModeMaster>()
             .HasOne(Candidate => Candidate.ModifiedByAppUser)
             .WithMany(user => user.ModeMasterModified)
             .HasForeignKey(candidate => candidate.CreatedBy)
             .OnDelete(DeleteBehavior.Restrict)
             ;
            modelBuilder.Entity<ResultMaster>()
            .HasOne(Candidate => Candidate.CreatedByAppUser)
            .WithMany(user => user.ResultMasterCreated)
            .HasForeignKey(candidate => candidate.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict)
            ;
            modelBuilder.Entity<ResultMaster>()
            .HasOne(Candidate => Candidate.ModifiedByAppUser)
            .WithMany(user => user.ResultMasterModified)
            .HasForeignKey(candidate => candidate.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict)
            ;
            modelBuilder.Entity<HRClientRound>()
           .HasOne(Candidate => Candidate.CreatedByAppUser)
           .WithMany(user => user.HRClientRoundCreated)
           .HasForeignKey(candidate => candidate.CreatedBy)
           .OnDelete(DeleteBehavior.Restrict)
           ;
         modelBuilder.Entity<HRClientRound>()
          .HasOne(Candidate => Candidate.ModifiedByAppUser)
          .WithMany(user => user.HRClientRoundModified)
          .HasForeignKey(candidate => candidate.CreatedBy)
          .OnDelete(DeleteBehavior.Restrict)
          ;
         modelBuilder.Entity<InterviewCommon>()
            .HasOne(Candidate => Candidate.CreatedByAppUser)
            .WithMany(user => user.InterviewCommonCreated)
            .HasForeignKey(candidate => candidate.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict)
            ;
         modelBuilder.Entity<InterviewCommon>()
            .HasOne(Candidate => Candidate.ModifiedByAppUser)
            .WithMany(user => user.InterviewCommonModified)
            .HasForeignKey(candidate => candidate.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict)
            ;
         modelBuilder.Entity<ManagementRound>()
             .HasOne(Candidate => Candidate.CreatedByAppUser)
             .WithMany(user => user.ManagementRoundCreated)
             .HasForeignKey(candidate => candidate.CreatedBy)
             .OnDelete(DeleteBehavior.Restrict)
             ;
         modelBuilder.Entity<ManagementRound>()
             .HasOne(Candidate => Candidate.ModifiedByAppUser)
             .WithMany(user => user.ManagementRoundModified)
             .HasForeignKey(candidate => candidate.CreatedBy)
             .OnDelete(DeleteBehavior.Restrict)
             ;
         modelBuilder.Entity<TechnicalRound>()
             .HasOne(Candidate => Candidate.CreatedByAppUser)
             .WithMany(user => user.TechnicalRoundCreated)
             .HasForeignKey(candidate => candidate.CreatedBy)
             .OnDelete(DeleteBehavior.Restrict)
             ;
         modelBuilder.Entity<TechnicalRound>()
            .HasOne(Candidate => Candidate.ModifiedByAppUser)
            .WithMany(user => user.TechnicalRoundModified)
            .HasForeignKey(candidate => candidate.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict)
            ;


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserMaster> User { get; set; }
        public DbSet<RoleMaster> Role { get; set; }
        public DbSet<GradeMaster> Grade { get; set; }

        public DbSet<Approval> Approval { get; set; }
        public DbSet<DmNameMaster> DmName { get; set; }

        public DbSet<ResourceTypeMaster> ResourceType { get; set; }
        public DbSet<BasicDetail> BasicDetail { get; set; }

        public DbSet<RequirementTypeMaster> RequirementType { get; set; }
        public DbSet<JobSpecification> JobSpecification { get; set; }

        public DbSet<RequirementInDetail> RequirementInDetail { get; set; }

        public DbSet<Additionalnformation> AdditionalInformation { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }

        public DbSet<Source> Source { get; set; }
        public DbSet<Status> Status { get; set; }

        public DbSet<Recruitment> Recruitment { get; set; }
        public DbSet<InterviewCommon> InterviewCommon { get; set; }
        public DbSet<HRClientRound> HRClientRound { get; set; }
        public DbSet<ManagementRound> ManagementRound { get; set; }
        public DbSet<TechnicalRound> TechnicalRound { get; set; }
        public DbSet<ModeMaster> ModeMaster { get; set; }
        public DbSet<ResultMaster> ResultMaster { get; set; }
        public DbSet<IEDStatusMaster> IEDStatusMaster { get; set; }
        public DbSet<LevelMaster> LevelMaster { get; set; }
    }
}