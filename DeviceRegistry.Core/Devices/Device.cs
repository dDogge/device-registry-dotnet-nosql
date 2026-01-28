namespace DeviceRegistry.Core.Devices;

public sealed record Device(
    Guid Id,
    string DeviceId,
    string Model,
    string FirmwareVersion,
    DeviceStatus Status,
    IReadOnlyDictionary<string, string> Metadata,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt,
);