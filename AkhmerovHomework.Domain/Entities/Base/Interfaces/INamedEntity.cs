namespace AkhmerovHomework.Domain.Entities.Base.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Entity with name
    /// </summary>
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
