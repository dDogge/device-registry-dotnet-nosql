namespace DeviceRegistry.Core.Devices;

public sealed record DeviceDto(
    Guid Id,
    string DeviceId,
    string Model,
    string FirmwareVersion,
    DeviceStatus Status,
    IReadOnlyDictionary<string, string> Metadata,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt
);

public static class DeviceMappings {
    public static DeviceDto ToDto(this Device d) =>
        new(d.Id, d.DeviceId, d.Model, d.FirmwareVersion, d.Status, d.Metadata, d.CreatedAt, d.UpdatedAt);
}
