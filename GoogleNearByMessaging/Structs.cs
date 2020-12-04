using System;
using ObjCRuntime;

namespace GoogleNearByMessageBinding
{
	[Native]
	public enum GNSOperationStatus : ulong
	{
		Inactive,
		Starting,
		Active
	}

	[Flags]
	[Native]
	public enum GNSDiscoveryMode : long
	{
		Broadcast = 1L << 0,
		Scan = 1L << 1,
		Default = Broadcast | Scan
	}

	[Flags]
	[Native]
	public enum GNSDiscoveryMediums : long
	{
		Audio = 1L << 0,
		Ble = 1L << 1,
		Default = Audio | Ble
	}

	[Flags]
	[Native]
	public enum GNSDeviceTypes : long
	{
		UsingNearby = 1L << 0,
		BLEBeacon = 1L << 1
	}
}
