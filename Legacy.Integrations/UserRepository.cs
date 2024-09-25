namespace Legacy.Integrations
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Legacy.Core;
    using Legacy.Core.Models;

    /// <summary>
    /// The repository for <see cref="User"/>.
    /// </summary>
    public sealed class UserRepository : IUserRepository
    {
        private readonly List<User> users = new List<User>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        public UserRepository()
        {
            this.PopulateMockData();
        }

        /// <inheritdoc/>
        public Task<User> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(this.users.Find(user => user.Id == id));
        }

        private void PopulateMockData()
        {
            this.users.Add(new User
            {
                Id = 1,
                Email = "people@email.com",
                Name = "Jake",
                Password = "password",
            });

            this.users.Add(new User
            {
                Id = 2,
                Email = "people@hotmail.com",
                Name = "Lily",
                Password = "password",
            });

            this.users.Add(new User
            {
                Id = 3,
                Email = "people@live.com",
                Name = "Ron",
                Password = "password",
            });
        }
    }
}
