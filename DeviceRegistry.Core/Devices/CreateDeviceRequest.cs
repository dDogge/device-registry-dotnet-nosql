using System.ComponentModel.DataAnnotations;

namespace DeviceRegistry.Core.Devices;

public sealed class CreateDeviceRequest {
    [Required]
    [StringLength(64, MinimumLength = 3)]
    [RegularExpression(@"^[A-Za-z0-9\-_]+$", ErrorMessage = "deviceId can only contain A-Z a-z 0-9 - _")]
    public string DeviceId { get; set; } = default!;

    [Required]
    [StringLength(64)]
    public string Model { get; set; } = default!;

    [Required]
    [StringLength(64)]
    public string FirmwareVersion { get; set; } = default!;

    public DeviceStatus? Status { get; set; } = DeviceStatus.Unknown;

    public Dictionary<string, string>? Metadata { get; set; }
}