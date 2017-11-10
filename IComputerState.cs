using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("E6F2F33E-1546-4A9A-A017-E7B2DFABA70E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	interface IComputerState
	{
		[DispId(1)]
		void SetHibernate();
		[DispId(2)]
		void SetStandBy();
	}
}
