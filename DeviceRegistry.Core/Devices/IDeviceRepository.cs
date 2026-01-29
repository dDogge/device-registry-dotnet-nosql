namespace DeviceRegistry.Core.Devices;

public interface IDeviceRepository {
    Task<IReadOnlyList<Device>> GetAllAsync(CancellationToken ct);
    Task<Device?> GetByIdAsync(Guid id, CancellationToken ct);
    Task<Device?> GetByDeviceIdAsync(string deviceId, CancellationToken ct);
    Task AddAsync(Device device, CancellationToken ct);
}
