namespace RambleOn.Domain.Contracts;

public interface IDateTimeService
{
    DateTimeOffset CurrentTime { get; }
}