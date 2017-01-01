namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TDMUDbContext : DbContext
    {
        public TDMUDbContext()
            : base("name=TDMUDbContext")
        {
        }

        public virtual DbSet<CategoryCourse> CategoryCourses { get; set; }
        public virtual DbSet<CategoryNew> CategoryNews { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleStaff> RoleStaffs { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryCourse>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryCourse>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<CategoryNew>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryNew>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<Photo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Photo>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<RoleStaff>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.ImageLoad)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<Staff>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.lang)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
