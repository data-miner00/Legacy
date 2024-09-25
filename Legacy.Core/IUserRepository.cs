namespace Legacy.Core
{
    using System.Threading;
    using System.Threading.Tasks;
    using Legacy.Core.Models;

    /// <summary>
    /// The interface for a <see cref="User"/> repository.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the user by Id.
        /// </summary>
        /// <param name="id">The Id of the user.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The found user.</returns>
        Task<User> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
