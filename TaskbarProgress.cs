using System.Runtime.InteropServices;

namespace Planetoid_DB
{
	/// <summary>
	/// Stellt Methoden zur Steuerung des Taskleistenfortschritts bereit.
	/// </summary>
	public static class TaskbarProgress
	{
		/// <summary>
		/// Definiert die verschiedenen Zustände des Taskleistenfortschritts.
		/// </summary>
		public enum TaskbarStates
		{
			/// <summary>
			/// Kein Fortschritt.
			/// </summary>
			NoProgress = 0,
			/// <summary>
			/// Unbestimmter Fortschritt.
			/// </summary>
			Indeterminate = 0x1,
			/// <summary>
			/// Normaler Fortschritt.
			/// </summary>
			Normal = 0x2,
			/// <summary>
			/// Fehlerhafter Fortschritt.
			/// </summary>
			Error = 0x4,
			/// <summary>
			/// Pausierter Fortschritt.
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
		/// Setzt den Zustand des Taskleistenfortschritts.
		/// </summary>
		/// <param name="windowHandle">Das Handle des Fensters.</param>
		/// <param name="taskbarState">Der neue Zustand des Taskleistenfortschritts.</param>
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
					string value = $"Fehler beim Setzen des Taskleistenstatus: {ex.Message}";
					Console.WriteLine(value: value);
				}
			}
		}

		/// <summary>
		/// Setzt den Fortschrittswert des Taskleistenfortschritts.
		/// </summary>
		/// <param name="windowHandle">Das Handle des Fensters.</param>
		/// <param name="progressValue">Der aktuelle Fortschrittswert.</param>
		/// <param name="progressMax">Der maximale Fortschrittswert.</param>
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
					Console.WriteLine(value: $"Fehler beim Setzen des Taskleistenfortschrittswerts: {ex.Message}");
				}
			}
		}
	}
}