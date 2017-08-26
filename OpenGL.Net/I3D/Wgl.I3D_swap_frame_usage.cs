
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
		/// [WGL] wglGetFrameUsageI3D: Binding for wglGetFrameUsageI3D.
		/// </summary>
		/// <param name="pUsage">
		/// A <see cref="T:float []"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool GetFrameUsageI3D([Out] float [] pUsage)
		{
			bool retValue;

			unsafe {
				fixed (float * p_pUsage = pUsage)
				{
					Debug.Assert(Delegates.pwglGetFrameUsageI3D != null, "pwglGetFrameUsageI3D not implemented");
					retValue = Delegates.pwglGetFrameUsageI3D(p_pUsage);
					LogCommand("wglGetFrameUsageI3D", retValue, pUsage					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBeginFrameTrackingI3D: Binding for wglBeginFrameTrackingI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool BeginFrameTrackingI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBeginFrameTrackingI3D != null, "pwglBeginFrameTrackingI3D not implemented");
			retValue = Delegates.pwglBeginFrameTrackingI3D();
			LogCommand("wglBeginFrameTrackingI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglEndFrameTrackingI3D: Binding for wglEndFrameTrackingI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool EndFrameTrackingI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEndFrameTrackingI3D != null, "pwglEndFrameTrackingI3D not implemented");
			retValue = Delegates.pwglEndFrameTrackingI3D();
			LogCommand("wglEndFrameTrackingI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryFrameTrackingI3D: Binding for wglQueryFrameTrackingI3D.
		/// </summary>
		/// <param name="pFrameCount">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="pMissedFrames">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="pLastMissedUsage">
		/// A <see cref="T:float []"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool QueryFrameTrackingI3D(Int32[] pFrameCount, Int32[] pMissedFrames, float [] pLastMissedUsage)
		{
			bool retValue;

			unsafe {
				fixed (Int32* p_pFrameCount = pFrameCount)
				fixed (Int32* p_pMissedFrames = pMissedFrames)
				fixed (float * p_pLastMissedUsage = pLastMissedUsage)
				{
					Debug.Assert(Delegates.pwglQueryFrameTrackingI3D != null, "pwglQueryFrameTrackingI3D not implemented");
					retValue = Delegates.pwglQueryFrameTrackingI3D(p_pFrameCount, p_pMissedFrames, p_pLastMissedUsage);
					LogCommand("wglQueryFrameTrackingI3D", retValue, pFrameCount, pMissedFrames, pLastMissedUsage					);
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
			[DllImport(Library, EntryPoint = "wglGetFrameUsageI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetFrameUsageI3D(float * pUsage);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglBeginFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglBeginFrameTrackingI3D();

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglEndFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglEndFrameTrackingI3D();

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameTrackingI3D(Int32* pFrameCount, Int32* pMissedFrames, float * pLastMissedUsage);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglGetFrameUsageI3D(float * pUsage);

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			internal static wglGetFrameUsageI3D pwglGetFrameUsageI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool wglBeginFrameTrackingI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			internal static wglBeginFrameTrackingI3D pwglBeginFrameTrackingI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool wglEndFrameTrackingI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			internal static wglEndFrameTrackingI3D pwglEndFrameTrackingI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryFrameTrackingI3D(Int32* pFrameCount, Int32* pMissedFrames, float * pLastMissedUsage);

			[RequiredByFeature("WGL_I3D_swap_frame_usage")]
			internal static wglQueryFrameTrackingI3D pwglQueryFrameTrackingI3D;

		}
	}

}
