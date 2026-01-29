namespace DeviceRegistry.Core.Devices;

public sealed class DeviceAlreadyExistsException : Exception {
    public DeviceAlreadyExistsException(string deviceId) : base($"Device with deviceId '{deviceId}' already exists") {}
}

public sealed class DeviceService {
    private readonly IDeviceRepository _repo;

    public DeviceService(IDeviceRepository rep0) => _repo = _repo;

    public Task<IReadOnlyList<Device>> GetAllASync(CancellationToken ct) => _repo.GetAllAsync(ct);

    public async Task<Device> CreateAsync(CreateDeviceRequest req, CancellationToken ct) {
        var existing = await _repo.GetByDeviceIdAsync(req.DeviceId, ct);
        if (existing is not null) throw new DeviceAlreadyExistsException(req.DeviceId);

        var now = DateTimeOffset.UtcNow;
        var device = new Device(
            Id: Guid.NewGuid(),
            DeviceId: req.DeviceId,
            Model: req.Model,
            FirmwareVersion: req.FirmwareVersion,
            Status: req.Status ?? DeviceStatus.Unknown,
            Metadata: req.Metadata ?? new Dictionary<string, string>(),
            CreatedAt: now,
            UpdatedAt: now
        );

        await _repo.AddAsync(device, ct);
        return device;
    }
}
