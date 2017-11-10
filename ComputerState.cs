using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("0F5A9835-1E25-4D43-963B-1ED23E0EFA08")]
	[ClassInterface(ClassInterfaceType.None)]
	class ComputerState : IComputerState
	{
		[DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

		public void SetHibernate()
		{
			SetSuspendState(true, true, true);
		}

		public void SetStandBy()
		{
			SetSuspendState(false, true, true);
		}
	}
}
