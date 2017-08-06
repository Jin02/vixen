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

public class PoseMapper : Engine {
  private HandleRef swigCPtr;

  internal PoseMapper(IntPtr cPtr, bool cMemoryOwn) : base(VixenLibPINVOKE.PoseMapper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PoseMapper obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PoseMapper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VixenLibPINVOKE.delete_PoseMapper(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PoseMapper() : this(VixenLibPINVOKE.new_PoseMapper(), true) {
  }

  public IntArray GetBoneMap() {
    IntArray ret = new IntArray(VixenLibPINVOKE.PoseMapper_GetBoneMap(swigCPtr), false);
    return ret;
  }

  public void SetBoneMap(int[] intArray) {
    VixenLibPINVOKE.PoseMapper_SetBoneMap(swigCPtr, intArray);
  }

  public bool SelectBoneMap(string mapname) {
    bool ret = VixenLibPINVOKE.PoseMapper_SelectBoneMap(swigCPtr, mapname);
    return ret;
  }

  public virtual bool MapLocalToTarget() {
    bool ret = VixenLibPINVOKE.PoseMapper_MapLocalToTarget(swigCPtr);
    return ret;
  }

  public virtual bool MapWorldToTarget() {
    bool ret = VixenLibPINVOKE.PoseMapper_MapWorldToTarget(swigCPtr);
    return ret;
  }

  public virtual bool MapWorldToSource() {
    bool ret = VixenLibPINVOKE.PoseMapper_MapWorldToSource(swigCPtr);
    return ret;
  }

  public static void MakeBoneMap(IntArray bonemap, Skeleton srcskel, Skeleton dstskel) {
    VixenLibPINVOKE.PoseMapper_MakeBoneMap(IntArray.getCPtr(bonemap), Skeleton.getCPtr(srcskel), Skeleton.getCPtr(dstskel));
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Skeleton Source {
    set {
      VixenLibPINVOKE.PoseMapper_Source_set(swigCPtr, Skeleton.getCPtr(value));
    } 
	get
	{
		IntPtr cPtr = VixenLibPINVOKE.PoseMapper_Source_get(swigCPtr);
		return (Skeleton) SharedObj.MakeObject(cPtr, false);
	}

  }

}

}