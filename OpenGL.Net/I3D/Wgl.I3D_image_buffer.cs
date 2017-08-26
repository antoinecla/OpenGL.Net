
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_IMAGE_BUFFER_MIN_ACCESS_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		[Log(BitmaskName = "WGLImageBufferMaskI3D")]
		public const int IMAGE_BUFFER_MIN_ACCESS_I3D = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_IMAGE_BUFFER_LOCK_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		[Log(BitmaskName = "WGLImageBufferMaskI3D")]
		public const int IMAGE_BUFFER_LOCK_I3D = 0x00000002;

		/// <summary>
		/// [WGL] wglCreateImageBufferI3D: Binding for wglCreateImageBufferI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dwSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uFlags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateImageBufferI3D != null, "pwglCreateImageBufferI3D not implemented");
			retValue = Delegates.pwglCreateImageBufferI3D(hDC, dwSize, uFlags);
			LogCommand("wglCreateImageBufferI3D", retValue, hDC, dwSize, uFlags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDestroyImageBufferI3D: Binding for wglDestroyImageBufferI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyImageBufferI3D != null, "pwglDestroyImageBufferI3D not implemented");
			retValue = Delegates.pwglDestroyImageBufferI3D(hDC, pAddress);
			LogCommand("wglDestroyImageBufferI3D", retValue, hDC, pAddress			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglAssociateImageBufferEventsI3D: Binding for wglAssociateImageBufferEventsI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pEvent">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="pSize">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, Int32[] pSize, UInt32 count)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_pEvent = pEvent)
				fixed (IntPtr* p_pAddress = pAddress)
				fixed (Int32* p_pSize = pSize)
				{
					Debug.Assert(Delegates.pwglAssociateImageBufferEventsI3D != null, "pwglAssociateImageBufferEventsI3D not implemented");
					retValue = Delegates.pwglAssociateImageBufferEventsI3D(hDC, p_pEvent, p_pAddress, p_pSize, count);
					LogCommand("wglAssociateImageBufferEventsI3D", retValue, hDC, pEvent, pAddress, pSize, count					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleaseImageBufferEventsI3D: Binding for wglReleaseImageBufferEventsI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr[] pAddress, UInt32 count)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_pAddress = pAddress)
				{
					Debug.Assert(Delegates.pwglReleaseImageBufferEventsI3D != null, "pwglReleaseImageBufferEventsI3D not implemented");
					retValue = Delegates.pwglReleaseImageBufferEventsI3D(hDC, p_pAddress, count);
					LogCommand("wglReleaseImageBufferEventsI3D", retValue, hDC, pAddress, count					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreateImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDestroyImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglAssociateImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglReleaseImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_image_buffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);

			[RequiredByFeature("WGL_I3D_image_buffer")]
			internal static wglCreateImageBufferI3D pwglCreateImageBufferI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);

			[RequiredByFeature("WGL_I3D_image_buffer")]
			internal static wglDestroyImageBufferI3D pwglDestroyImageBufferI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);

			[RequiredByFeature("WGL_I3D_image_buffer")]
			internal static wglAssociateImageBufferEventsI3D pwglAssociateImageBufferEventsI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);

			[RequiredByFeature("WGL_I3D_image_buffer")]
			internal static wglReleaseImageBufferEventsI3D pwglReleaseImageBufferEventsI3D;

		}
	}

}
