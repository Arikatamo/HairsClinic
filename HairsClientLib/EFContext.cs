using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib
{
    public class EFContext: DbContext
    {
        public EFContext() : base("ConnectionLocal") { }
        public DbSet<ContactS> Contacts { get; set; }
        public DbSet<GenderS> Genders { get; set; }
        public DbSet<StatusesForPatient> StatusesPatient { get; set; }
        public DbSet<CommentaryToVisit> CommentToVisits { get; set; }
        public DbSet<CommentaryType> CommentTypes { get; set; }
        public DbSet<ResearchStatus> ResearStatus { get; set; }
        public DbSet<Diagnoses> Diagnos { get; set; }
        public DbSet<Objectives> Objectivs { get; set; }
        public DbSet<ConfigHairSize> ConfHairSizes { get; set; }
        public DbSet<ConfigStaticNormales> ConfigStaticNormales { get; set; }
        public DbSet<ConfigHair> ConfigHairs { get; set; }
        public DbSet<Photoses> Photos { get; set; }
        public DbSet<Hair> Hairs { get; set; }
        public DbSet<FieldVariants> FieldVariant { get; set; }
        public DbSet<FieldType> FieldTypes { get; set; }
        public DbSet<Reportfield> ReportFields { get; set; }
        public DbSet<ImageLogo> ImageLogos { get; set; }
        public DbSet<ReportTemplate> ReportTemplates { get; set; }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Research> Research { get; set; }
        public DbSet<AccesRight> Access { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Visit> Visits { get; set; }


    }
}
