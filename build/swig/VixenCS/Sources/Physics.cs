/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Vixen {

using System;
using System.Runtime.InteropServices;

public class Physics : Engine {
  private HandleRef swigCPtr;

  internal Physics(IntPtr cPtr, bool cMemoryOwn) : base(VixenLibPINVOKE.Physics_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Physics obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Physics() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VixenLibPINVOKE.delete_Physics(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Physics(SWIGTYPE_p_void world) : this(VixenLibPINVOKE.new_Physics__SWIG_0(SWIGTYPE_p_void.getCPtr(world)), true) {
  }

  public Physics() : this(VixenLibPINVOKE.new_Physics__SWIG_1(), true) {
  }

  public int GetNumThreads() {
    int ret = VixenLibPINVOKE.Physics_GetNumThreads(swigCPtr);
    return ret;
  }

  public void SetNumThreads(int n) {
    VixenLibPINVOKE.Physics_SetNumThreads(swigCPtr, n);
  }

  public float GetTimeStep() {
    float ret = VixenLibPINVOKE.Physics_GetTimeStep(swigCPtr);
    return ret;
  }

  public void Clear() {
    VixenLibPINVOKE.Physics_Clear(swigCPtr);
  }

  public static bool Startup() {
    bool ret = VixenLibPINVOKE.Physics_Startup();
    return ret;
  }

  public static void Shutdown(int threadtype) {
    VixenLibPINVOKE.Physics_Shutdown__SWIG_0(threadtype);
  }

  public static void Shutdown() {
    VixenLibPINVOKE.Physics_Shutdown__SWIG_1();
  }

  public static Physics Get() 
	{
		IntPtr cPtr = VixenLibPINVOKE.Physics_Get();
		return (Physics)  SharedObj.MakeObject(cPtr, true);
	}


  public static bool IsRunning() {
    bool ret = VixenLibPINVOKE.Physics_IsRunning();
    return ret;
  }

  public string FileName {
    set {
      VixenLibPINVOKE.Physics_FileName_set(swigCPtr, value);
    } 
    get {
      string ret = VixenLibPINVOKE.Physics_FileName_get(swigCPtr);
      return ret;
    } 
  }

}

}