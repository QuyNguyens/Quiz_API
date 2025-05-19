using Quiz.Core.Factory;
using Quiz.Data;

namespace Quiz.Core.Manager
{
    /// <summary>
    /// DataManager
    /// </summary>
    public partial class DataManager
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly QuizDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataManager"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DataManager(QuizDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// The question factory
        /// </summary>
        private QuestionFactory questionFactory;

        /// <summary>
        /// The quiz attempt factory
        /// </summary>
        private QuizAttemptFactory quizAttemptFactory;

        /// <summary>
        /// The user answer factory
        /// </summary>
        private UserAnswerFactory userAnswerFactory;

        /// <summary>
        /// Gets or sets the question factory.
        /// </summary>
        /// <value>
        /// The question factory.
        /// </value>
        public QuestionFactory QuestionFactory
        {
            get
            {
                if (questionFactory == null)
                {
                    questionFactory = new QuestionFactory(this.context);
                }
                return questionFactory;
            }
            set
            {
                questionFactory = value;
            }
        }

        /// <summary>
        /// Gets or sets the quiz attempt factory.
        /// </summary>
        /// <value>
        /// The quiz attempt factory.
        /// </value>
        public QuizAttemptFactory QuizAttemptFactory
        {
            get
            {
                if (quizAttemptFactory == null)
                {
                    quizAttemptFactory = new QuizAttemptFactory(this.context);
                }
                return quizAttemptFactory;
            }
            set
            {
                quizAttemptFactory = value;
            }
        }

        /// <summary>
        /// Gets or sets the user answer factory.
        /// </summary>
        /// <value>
        /// The user answer factory.
        /// </value>
        public UserAnswerFactory UserAnswerFactory
        {
            get
            {
                if (userAnswerFactory == null)
                {
                    userAnswerFactory = new UserAnswerFactory(this.context);
                }
                return userAnswerFactory;
            }
            set
            {
                userAnswerFactory = value;
            }
        }
    }
}
