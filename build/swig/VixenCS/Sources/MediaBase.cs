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

public class MediaBase : Engine {
  private HandleRef swigCPtr;

  internal MediaBase(IntPtr cPtr, bool cMemoryOwn) : base(VixenLibPINVOKE.MediaBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MediaBase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaBase() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VixenLibPINVOKE.delete_MediaBase(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MediaBase() : this(VixenLibPINVOKE.new_MediaBase(), true) {
  }

  public static bool ComputeTexSize(SWIGTYPE_p_int width, SWIGTYPE_p_int height) {
    bool ret = VixenLibPINVOKE.MediaBase_ComputeTexSize(SWIGTYPE_p_int.getCPtr(width), SWIGTYPE_p_int.getCPtr(height));
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool InitImage(Texture image, int width, int height, int depth) {
    bool ret = VixenLibPINVOKE.MediaBase_InitImage__SWIG_0(Texture.getCPtr(image), width, height, depth);
    return ret;
  }

  public static bool InitImage(Texture image, int width, int height) {
    bool ret = VixenLibPINVOKE.MediaBase_InitImage__SWIG_1(Texture.getCPtr(image), width, height);
    return ret;
  }

  public static bool CopyImage(Texture image, string srcpixels, int srcwidth, int srcheight, int srcstride) {
    bool ret = VixenLibPINVOKE.MediaBase_CopyImage(Texture.getCPtr(image), srcpixels, srcwidth, srcheight, srcstride);
    return ret;
  }

  public int Options {
    set {
      VixenLibPINVOKE.MediaBase_Options_set(swigCPtr, value);
    } 
    get {
      int ret = VixenLibPINVOKE.MediaBase_Options_get(swigCPtr);
      return ret;
    } 
  }

  public int FPS {
    set {
      VixenLibPINVOKE.MediaBase_FPS_set(swigCPtr, value);
    } 
    get {
      int ret = VixenLibPINVOKE.MediaBase_FPS_get(swigCPtr);
      return ret;
    } 
  }

  public string FileName {
    set {
      VixenLibPINVOKE.MediaBase_FileName_set(swigCPtr, value);
    } 
    get {
      string ret = VixenLibPINVOKE.MediaBase_FileName_get(swigCPtr);
      return ret;
    } 
  }

  public string CaptureSource {
    set {
      VixenLibPINVOKE.MediaBase_CaptureSource_set(swigCPtr, value);
    } 
    get {
      string ret = VixenLibPINVOKE.MediaBase_CaptureSource_get(swigCPtr);
      return ret;
    } 
  }

  public Vec2 TexSize {
    set {
      VixenLibPINVOKE.MediaBase_TexSize_set(swigCPtr, Vec2.getCPtr(value));
      if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Vec2 ret = new Vec2(VixenLibPINVOKE.MediaBase_TexSize_get(swigCPtr), false);
      if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Vec2 VideoSize {
    set {
      VixenLibPINVOKE.MediaBase_VideoSize_set(swigCPtr, Vec2.getCPtr(value));
      if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Vec2 ret = new Vec2(VixenLibPINVOKE.MediaBase_VideoSize_get(swigCPtr), false);
      if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static readonly int LIVE = VixenLibPINVOKE.MediaBase_LIVE_get();

}

}