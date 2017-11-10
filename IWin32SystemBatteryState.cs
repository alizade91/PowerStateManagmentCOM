using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("26ADAA5D-9A7B-4DE8-92F5-632A2A17C3FB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	interface IWin32SystemBatteryState
	{
		[DispId(1)]
		SystemBatteryState GetSystemBatteryState();
	}
}
