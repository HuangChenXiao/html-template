﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custom.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TuoZhanEntities : DbContext
    {
        public TuoZhanEntities()
            : base("name=TuoZhanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BA_Advertisement> BA_Advertisement { get; set; }
        public virtual DbSet<Cu_Menu> Cu_Menu { get; set; }
        public virtual DbSet<Cu_User> Cu_User { get; set; }
        public virtual DbSet<Cu_UserAuthority> Cu_UserAuthority { get; set; }
        public virtual DbSet<P_CITYCALSS> P_CITYCALSS { get; set; }
        public virtual DbSet<TZ_Carousel> TZ_Carousel { get; set; }
        public virtual DbSet<TZ_Customized> TZ_Customized { get; set; }
        public virtual DbSet<TZ_ExpandActivity> TZ_ExpandActivity { get; set; }
        public virtual DbSet<TZ_ExpandProject> TZ_ExpandProject { get; set; }
        public virtual DbSet<TZ_ExpandProjectDetail> TZ_ExpandProjectDetail { get; set; }
        public virtual DbSet<TZ_ExpandType> TZ_ExpandType { get; set; }
        public virtual DbSet<TZ_ProjectType> TZ_ProjectType { get; set; }
        public virtual DbSet<TZ_Seo> TZ_Seo { get; set; }
        public virtual DbSet<ExpandActivity_Project_View> ExpandActivity_Project_View { get; set; }
        public virtual DbSet<TZ_ExpandProject_View> TZ_ExpandProject_View { get; set; }
    }
}
