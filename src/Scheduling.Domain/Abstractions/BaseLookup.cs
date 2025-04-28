using NhsWales.Scheduling.Domain.Types.Ids;

namespace NhsWales.Vaccination.Domain.Interfaces;
public abstract class BaseLookup<T>
{
    /// <summary>
    /// The code identifier for the lookup value. 
    /// </summary>
    public required T Id { get; set; }

    /// <summary>
    /// The display text for the lookup value, this is the
    /// humanly-readable descriptor that should be used
    /// when presenting the data to the end user.
    /// </summary>
    public required string Display { get; set; }

    /// <summary>
    /// The descriptor for the lookup value, that will
    /// give context around the meaning of the specific
    /// lookup value.
    /// </summary>
    public required string Definition { get; set; }

    /// <summary>
    /// The URI indicating the source of the reference data.
    /// For example, the reference data has been sourced
    /// via SNOMED.
    /// </summary>
    public required SystemUriId System { get; set; }

    /// <summary>
    /// Indicates if the reference data is currently being used,
    /// will probably be used in the primary use case of showing
    /// or hiding reference data via the frontend.
    /// </summary>
    public required bool IsActive { get; set; }

    /// <summary>
    /// Indicates the order that the value should display
    /// when returned from the API. Ideally these would start
    /// from 1, as opposed to 0. (Sorry coders!)
    /// </summary>
    public required int DisplayOrder { get; set; }
}
