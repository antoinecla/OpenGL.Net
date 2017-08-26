
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
		/// [WGL] Value of ERROR_INVALID_PIXEL_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("ERROR_INVALID_PIXEL_TYPE_EXT")]
		[RequiredByFeature("WGL_ARB_make_current_read")]
		[RequiredByFeature("WGL_EXT_make_current_read")]
		public const int ERROR_INVALID_PIXEL_TYPE_ARB = 0x2043;

		/// <summary>
		/// [WGL] Value of ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public const int ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = 0x2054;

		/// <summary>
		/// [WGL] wglMakeContextCurrentARB: Binding for wglMakeContextCurrentARB.
		/// </summary>
		/// <param name="hDrawDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hReadDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public static bool MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeContextCurrentARB != null, "pwglMakeContextCurrentARB not implemented");
			retValue = Delegates.pwglMakeContextCurrentARB(hDrawDC, hReadDC, hglrc);
			LogCommand("wglMakeContextCurrentARB", retValue, hDrawDC, hReadDC, hglrc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetCurrentReadDCARB: Binding for wglGetCurrentReadDCARB.
		/// </summary>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public static IntPtr GetCurrentReadDCARB()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentReadDCARB != null, "pwglGetCurrentReadDCARB not implemented");
			retValue = Delegates.pwglGetCurrentReadDCARB();
			LogCommand("wglGetCurrentReadDCARB", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglMakeContextCurrentARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetCurrentReadDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentReadDCARB();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_make_current_read")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			[RequiredByFeature("WGL_ARB_make_current_read")]
			internal static wglMakeContextCurrentARB pwglMakeContextCurrentARB;

			[RequiredByFeature("WGL_ARB_make_current_read")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr wglGetCurrentReadDCARB();

			[RequiredByFeature("WGL_ARB_make_current_read")]
			internal static wglGetCurrentReadDCARB pwglGetCurrentReadDCARB;

		}
	}

}
