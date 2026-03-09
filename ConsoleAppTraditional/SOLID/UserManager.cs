using ConsoleAppTraditional.LogImplementations;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppTraditional.SOLID
{

    interface IUserValidator
    {
        void Validate(User user);
    }

    class UserValidator : IUserValidator
    {
       
        public void Validate(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (string.IsNullOrWhiteSpace(user.UserName))
            {
                throw new InvalidOperationException("Username is required.");
            }

            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
            {
                throw new InvalidOperationException("Invalid email.");
            }
        }
    }

    interface IUserRepository
    {
        void Save(User user);
        void Delete(User user);
        void Update(User user);

        User GetUserById(int id);
    }

    class UserRepository : IUserRepository
    {
        private readonly IUserValidator userValidator;
        private List<User> users = new List<User>();

        public UserRepository(IUserValidator userValidator)
        {
            this.userValidator = userValidator;
        }

        public void Delete(User user)
        {
            users.RemoveAll(u => u.UserId == user.UserId);
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.UserId == id);
        }

        public void Save(User user)
        {
            user.UserId = users.Count + 1;
            users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = users.Find(u => u.UserId == user.UserId);

            userValidator.Validate(existingUser);
            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
        }
    }

    class UserManager
    {   
        private readonly IUserValidator validator;
        private readonly ILogger logger;
        private readonly IUserRepository userRepository;

        public UserManager(IUserValidator validator,
            ILogger logger,
            IUserRepository userRepository)
        {
            this.validator = validator;
            this.logger = logger;
            this.userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            validator.Validate(user);

            userRepository.Save(user);
            logger.LogInformation($"User {user.UserName} added with id {user.UserId}");
            logger.LogInformation($"[{DateTime.Now}] Added user {user.UserName} {user.Email}\n");
        }

        public void DeleteUser(User user)
        {
            validator.Validate(user);
            userRepository.Delete(user);

            logger.LogInformation($"User {user.UserName} deleted");
            logger.LogInformation($"[{DateTime.Now}] Deleted user {user.UserName}\n");
        }

        public void UpdateUser(User user)
        {
            validator.Validate(user);

            var existingUser = userRepository.GetUserById(user.UserId);
            validator.Validate(existingUser);
            userRepository.Update(user);

            logger.LogInformation($"User {user.UserId} updated to {user.UserName}");
            logger.LogInformation($"[{DateTime.Now}] Updated user {user.UserId} {user.UserName} {user.Email}\n");
        }
    }
}
