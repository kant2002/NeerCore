namespace NeerCore.Data.Abstractions;

/// <summary>
///   Defines an entity with the required <see cref="DateTime">Nullable&lt;DateTime&gt;</see>
///   when entity was last <see cref="Updated"/>.
/// </summary>
public interface IUpdatableEntity
{
    /// <summary>
    ///   Gets the <see cref="DateTime"/> the entity was last updated
    ///   (or null if it was created and never updated).
    /// </summary>
    DateTime? Updated { get; }
}

/// <summary>
///   Defines an entity with the required primary key <see cref="IEntity{TKey}.Id"/> property and
///   <see cref="DateTime">Nullable&lt;DateTime&gt;</see> when entity was last <see cref="IUpdatableEntity.Updated"/>.
/// </summary>
/// <typeparam name="TKey"><see cref="IEntity{TKey}.Id"/> type.</typeparam>
public interface IUpdatableEntity<out TKey> : IUpdatableEntity, IEntity<TKey> { }