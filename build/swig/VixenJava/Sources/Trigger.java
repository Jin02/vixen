/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package Vixen;

public class Trigger extends Engine {
  private long swigCPtr;

  public Trigger(long cPtr, boolean cMemoryOwn) {
    super(VixenLibJNI.Trigger_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(Trigger obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        VixenLibJNI.delete_Trigger(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public Trigger() {
    this(VixenLibJNI.new_Trigger__SWIG_0(), true);
  }

  public Trigger(Trigger arg0) {
    this(VixenLibJNI.new_Trigger__SWIG_1(Trigger.getCPtr(arg0), arg0), true);
  }

  public SharedObj GetColliders() 
	{
		jlong ptr = VixenLibJNI.Trigger_GetColliders__SWIG_0(swigCPtr, this);
		return (SharedObj)  SharedObj.MakeObject(ptr, true);
	}


  public SharedObj GetGeometry() 
	{
		jlong ptr = VixenLibJNI.Trigger_GetGeometry__SWIG_0(swigCPtr, this);
		return (SharedObj)  SharedObj.MakeObject(ptr, true);
	}


  public boolean SetColliders(SharedObj arg0) {
    return VixenLibJNI.Trigger_SetColliders(swigCPtr, this, SharedObj.getCPtr(arg0), arg0);
  }

  public boolean AddCollider(Model arg0) {
    return VixenLibJNI.Trigger_AddCollider(swigCPtr, this, Model.getCPtr(arg0), arg0);
  }

  public boolean RemoveCollider(Model arg0) {
    return VixenLibJNI.Trigger_RemoveCollider(swigCPtr, this, Model.getCPtr(arg0), arg0);
  }

  public boolean SetGeometry(SharedObj arg0) {
    return VixenLibJNI.Trigger_SetGeometry(swigCPtr, this, SharedObj.getCPtr(arg0), arg0);
  }

  public boolean SetGeoSphere(Sphere arg0) {
    return VixenLibJNI.Trigger_SetGeoSphere(swigCPtr, this, Sphere.getCPtr(arg0), arg0);
  }

  public boolean SetGeoBox(Box3 arg0) {
    return VixenLibJNI.Trigger_SetGeoBox(swigCPtr, this, Box3.getCPtr(arg0), arg0);
  }

  public boolean GetGeoSphere(Sphere arg0) {
    return VixenLibJNI.Trigger_GetGeoSphere(swigCPtr, this, Sphere.getCPtr(arg0), arg0);
  }

  public boolean GetGeoBox(Box3 arg0) {
    return VixenLibJNI.Trigger_GetGeoBox(swigCPtr, this, Box3.getCPtr(arg0), arg0);
  }

  public int GetOptions() {
    return VixenLibJNI.Trigger_GetOptions(swigCPtr, this);
  }

  public void SetOptions(int opts) {
    VixenLibJNI.Trigger_SetOptions(swigCPtr, this, opts);
  }

  public boolean Copy(SharedObj arg0) {
    return VixenLibJNI.Trigger_Copy(swigCPtr, this, SharedObj.getCPtr(arg0), arg0);
  }

  public final static int SPHERE = VixenLibJNI.Trigger_SPHERE_get();
  public final static int BOX = VixenLibJNI.Trigger_BOX_get();
  public final static int FIT = VixenLibJNI.Trigger_FIT_get();
  public final static int OUTSIDE = VixenLibJNI.Trigger_OUTSIDE_get();
  public final static int INSIDE = VixenLibJNI.Trigger_INSIDE_get();
  public final static int ENTER = VixenLibJNI.Trigger_ENTER_get();
  public final static int LEAVE = VixenLibJNI.Trigger_LEAVE_get();

}
