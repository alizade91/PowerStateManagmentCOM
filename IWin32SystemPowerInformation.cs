using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("BBD54FE0-128E-4971-8716-88600366DC84")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	interface IWin32SystemPowerInformation
	{
		[DispId(1)]
		SystemPowerInformation GetSystemPowerInformation();
	}
}
