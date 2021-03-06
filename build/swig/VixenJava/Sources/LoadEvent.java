/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package Vixen;

public class LoadEvent extends Event {
  private long swigCPtr;

  public LoadEvent(long cPtr, boolean cMemoryOwn) {
    super(VixenLibJNI.LoadEvent_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(LoadEvent obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        VixenLibJNI.delete_LoadEvent(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public LoadEvent(int code, SharedObj sender) {
    this(VixenLibJNI.new_LoadEvent__SWIG_0(code, SharedObj.getCPtr(sender), sender), true);
  }

  public LoadEvent(int code) {
    this(VixenLibJNI.new_LoadEvent__SWIG_1(code), true);
  }

  public LoadEvent() {
    this(VixenLibJNI.new_LoadEvent__SWIG_2(), true);
  }

  public LoadEvent(int code, int size, SharedObj sender) {
    this(VixenLibJNI.new_LoadEvent__SWIG_3(code, size, SharedObj.getCPtr(sender), sender), true);
  }

  public LoadEvent(int code, int size) {
    this(VixenLibJNI.new_LoadEvent__SWIG_4(code, size), true);
  }

  public LoadEvent(Event src) {
    this(VixenLibJNI.new_LoadEvent__SWIG_5(Event.getCPtr(src), src), true);
  }

  public Event Copy(Event arg0) {
    return new Event(VixenLibJNI.LoadEvent_Copy(swigCPtr, this, Event.getCPtr(arg0), arg0), false);
  }

  public void setFileName(String value) {
    VixenLibJNI.LoadEvent_FileName_set(swigCPtr, this, String.getCPtr(value), value);
  }

  public String getFileName() {
    return new String(VixenLibJNI.LoadEvent_FileName_get(swigCPtr, this), false);
  }

}
