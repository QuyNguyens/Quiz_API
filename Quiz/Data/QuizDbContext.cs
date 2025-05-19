using Microsoft.EntityFrameworkCore;
using Quiz.Entities;

namespace Quiz.Data
{
    /// <summary>
    /// QuizDbContext context
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class QuizDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuizDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        /// <value>
        /// The question.
        /// </value>
        public DbSet<Question> Question { get; set; }

        /// <summary>
        /// Gets or sets the answer.
        /// </summary>
        /// <value>
        /// The answer.
        /// </value>
        public DbSet<Answer> Answer { get; set; }

        /// <summary>
        /// Gets or sets the quiz attempt.
        /// </summary>
        /// <value>
        /// The quiz attempt.
        /// </value>
        public DbSet<QuizAttempt> QuizAttempt { get; set; }

        /// <summary>
        /// Gets or sets the user answer.
        /// </summary>
        /// <value>
        /// The user answer.
        /// </value>
        public DbSet<UserAnswer> UserAnswer { get; set; }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// <para>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run. However, it will still run when creating a compiled model.
        /// </para>
        /// <para>
        /// See <see href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</see> for more information and
        /// examples.
        /// </para>
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
