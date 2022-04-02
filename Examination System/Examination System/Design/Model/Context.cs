using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Design.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<GradeStudentCourse> GradeStudentCourses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentExamCourse> StudentExamCourses { get; set; }
        public virtual DbSet<StudentExamQuestion> StudentExamQuestions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_User>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<C_User>()
                .Property(e => e.FName)
                .IsFixedLength();

            modelBuilder.Entity<C_User>()
                .Property(e => e.LName)
                .IsFixedLength();

            modelBuilder.Entity<C_User>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<C_User>()
                .Property(e => e.UserType)
                .IsFixedLength();

            modelBuilder.Entity<C_User>()
                .HasOptional(e => e.Instructor)
                .WithRequired(e => e.C_User);

            modelBuilder.Entity<C_User>()
                .HasOptional(e => e.Student)
                .WithRequired(e => e.C_User);

            modelBuilder.Entity<Choice>()
                .Property(e => e.Choice1)
                .IsUnicode(false);

            modelBuilder.Entity<Choice>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .Property(e => e.CName)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .HasMany(e => e.GradeStudentCourses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentExamCourses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Instructors)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("InstructorCourse").MapLeftKey("CId").MapRightKey("InsId"));

            modelBuilder.Entity<Department>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DeptId);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamQuestions)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.StudentExamCourses)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.StudentExamQuestions)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.ManagerID);

            modelBuilder.Entity<Question>()
                .Property(e => e.QDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Model_Answer)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Choices)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ExamQuestions)
                .WithRequired(e => e.Question)
                .HasForeignKey(e => e.QId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ExamQuestions1)
                .WithRequired(e => e.Question1)
                .HasForeignKey(e => e.QId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.StudentExamQuestions)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.GradeStudentCourses)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.SId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentExamCourses)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.SId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentExamQuestions)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.SId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentExamQuestion>()
                .Property(e => e.StudentAnswer)
                .IsFixedLength();

            modelBuilder.Entity<Topic>()
                .Property(e => e.TopicName)
                .IsUnicode(false);
        }
    }
}
