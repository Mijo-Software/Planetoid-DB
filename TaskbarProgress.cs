using System.Runtime.InteropServices;

namespace Planetoid_DB
{
	/// <summary>
	/// Provides methods to control taskbar progress.
	/// </summary>
	public static class TaskbarProgress
	{
		/// <summary>
		/// Defines the different states of the taskbar progress.
		/// </summary>
		public enum TaskbarStates
		{
			/// <summary>
			/// No progress.
			/// </summary>
			NoProgress = 0,
			/// <summary>
			/// Indeterminate Progress.
			/// </summary>
			Indeterminate = 0x1,
			/// <summary>
			/// Normal progress.
			/// </summary>
			Normal = 0x2,
			/// <summary>
			/// Faulty progress.
			/// </summary>
			Error = 0x4,
			/// <summary>
			/// Paused progress.
			/// </summary>
			Paused = 0x8
		}

		[ComImport]
		[Guid(guid: "ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
		[InterfaceType(interfaceType: ComInterfaceType.InterfaceIsIUnknown)]
		private interface ITaskbarList3
		{
			// ITaskbarList
			[PreserveSig]
			void HrInit();
			[PreserveSig]
			void AddTab(IntPtr hwnd);
			[PreserveSig]
			void DeleteTab(IntPtr hwnd);
			[PreserveSig]
			void ActivateTab(IntPtr hwnd);
			[PreserveSig]
			void SetActiveAlt(IntPtr hwnd);

			// ITaskbarList2
			[PreserveSig]
			void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(unmanagedType: UnmanagedType.Bool)] bool fFullscreen);

			// ITaskbarList3
			[PreserveSig]
			void SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);
			[PreserveSig]
			void SetProgressState(IntPtr hwnd, TaskbarStates state);
		}

		[Guid(guid: "56FDF344-FD6D-11d0-958A-006097C9A090")]
		[ClassInterface(classInterfaceType: ClassInterfaceType.None)]
		[ComImport]
		private class TaskbarInstance
		{
		}

		private static readonly ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();
		private static readonly bool taskbarSupported = Environment.OSVersion.Version >= new Version(major: 6, minor: 1);

		/// <summary>
		/// Sets the state of the taskbar progress.
		/// </summary>
		/// <param name="windowHandle">The handle of the window.</param>
		/// <param name="taskbarState">The new state of the taskbar progress.</param>
		public static void SetState(IntPtr windowHandle, TaskbarStates taskbarState)
		{
			if (taskbarSupported)
			{
				try
				{
					taskbarInstance.SetProgressState(hwnd: windowHandle, state: taskbarState);
				}
				catch (Exception ex)
				{
					// Fehlerbehandlung hinzufügen
					string value = $"Error setting taskbar status: {ex.Message}";
					Console.WriteLine(value: value);
				}
			}
		}

		/// <summary>
		/// Sets the progress value of the taskbar progress.
		/// </summary>
		/// <param name="windowHandle">The handle of the window.</param>
		/// <param name="progressValue">The current progress value.</param>
		/// <param name="progressMax">The maximum progress value.</param>
		public static void SetValue(IntPtr windowHandle, double progressValue, double progressMax)
		{
			if (taskbarSupported)
			{
				try
				{
					taskbarInstance.SetProgressValue(hwnd: windowHandle, ullCompleted: (ulong)progressValue, ullTotal: (ulong)progressMax);
				}
				catch (Exception ex)
				{
					// Fehlerbehandlung hinzufügen
					Console.WriteLine(value: $"Error setting taskbar progress value: {ex.Message}");
				}
			}
		}
	}
}