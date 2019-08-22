using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WEBAPIRESTFULL.Utils
{
	public class Single<T> : IDisposable
	{
		private static object _instance = null;

		public static T getInstance()
		{
			if (_instance == null)
			{
				//var obj = new Single<T>();
				_instance = Activator.CreateInstance<T>();//Cria instancia e já separa
			}
			return (T)_instance;
		}
		SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

		#region IDisposable Support
		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects).
					handle.Dispose();
				}

				// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
				// TODO: set large fields to null.

				disposedValue = true;
			}
		}

		// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
		// ~Single()
		// {
		//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		//   Dispose(false);
		// }

		// This code added to correctly implement the disposable pattern.
		void IDisposable.Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			_instance = null;
			Dispose(true);
			GC.SuppressFinalize(this);
			// TODO: uncomment the following line if the finalizer is overridden above.
			// GC.SuppressFinalize(this);
		}
		#endregion

	}
}