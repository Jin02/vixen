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

public class FloatArray : SharedFloatArray, System.Collections.Generic.IList< float >, System.Collections.Specialized.INotifyCollectionChanged {
  private HandleRef swigCPtr;

  internal FloatArray(IntPtr cPtr, bool cMemoryOwn) : base(VixenLibPINVOKE.FloatArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FloatArray obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VixenLibPINVOKE.delete_FloatArray(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	public FloatArray(System.Collections.ICollection c) : this()
	{
		if (c == null)
			throw new ArgumentNullException("c");
		foreach (float element in c)
			this.Append(element);
	}

    protected void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (CollectionChanged != null)
            CollectionChanged(this, e);
    }

	public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
	public bool	IsFixedSize		{ get { return false; } }
	public bool	IsReadOnly		{ get { return false; } }
	public int	Count			{ get { return (int) GetSize(); } }
	public bool	IsSynchronized	{ get { return false; } }

	public float this[int index]
	{
		get { return getitem(index); }
		set { setitem(index, value); OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Replace, value, index)); }
	}

	public float this[long index]
	{
		get { return getitem(index); }
		set { setitem(index, value); OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Replace, value, index)); }
	}

	public int Capacity
	{
		get { return (int) GetMaxSize(); }
		set { SetMaxSize(value); }
	}

	public void Add(float v)
	{
		Append(v);
		OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Add, v));
	}

	public void Clear()
	{
		Empty();
		OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
	}

	public void CopyFrom(float[] srcarray)
		{ CopyFrom(srcarray, 0, 0); }

	public void CopyTo(float[] dstarray)
		{ CopyTo(0, dstarray, 0, this.Count); }

	public void CopyTo(float[] dstarray, int dstindex)
		{ CopyTo(0, dstarray, dstindex, this.Count); }

	public void CopyFrom(float[] srcarray, long dstindex)
		{ CopyFrom(srcarray, 0, dstindex); }

	public void CopyTo(long srcindex, float[] dstarray, long dstindex, long count)
	{
		if (dstarray == null)
			throw new ArgumentNullException("dstarray");
		if (srcindex < 0)
			throw new ArgumentOutOfRangeException("srcindex", "Value is less than zero");
		if (dstindex < 0)
			throw new ArgumentOutOfRangeException("dstindex", "Value is less than zero");
		if (count < 0)
			throw new ArgumentOutOfRangeException("count", "Value is less than zero");
		if (dstarray.Rank > 1)
			throw new ArgumentException("Multi dimensional array.", "dstarray");
		if (dstindex + count > dstarray.Length)
			throw new ArgumentException("Number of elements to copy is too large.");
		for (int i = 0; i < count; i++)
			dstarray[dstindex + i] = getitem(srcindex + i);
	}

	public void CopyFrom(float[] srcarray, long srcindex, long dstindex)
	{
		int count;

		if (srcarray == null)
			throw new ArgumentNullException("srcarray");
		if (dstindex < 0)
			throw new ArgumentOutOfRangeException("dstindex", "Value is less than zero");
		if (srcindex < 0)
			throw new ArgumentOutOfRangeException("srcindex", "Value is less than zero");
		if (srcarray.Rank > 1)
			throw new ArgumentException("Multi dimensional array.", "srcarray");
		count = srcarray.Length;
		for (int i = 0; i < count; i++)
			setitem(dstindex + i, srcarray[srcindex + i]);
		OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Replace, this));
	}

	System.Collections.Generic.IList<float> ToList()
	{
		return this as System.Collections.Generic.IList<float>;
	}

	System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<float>.GetEnumerator()
	{
		return new FloatArrayEnumerator(this);
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return new FloatArrayEnumerator(this);
	}

	public FloatArrayEnumerator GetEnumerator()
	{
		return new FloatArrayEnumerator(this);
	}

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
	public sealed class FloatArrayEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<float>
	{
		private FloatArray collectionRef;
		private long currentIndex;
		private object currentObject;
		private long currentSize;

		public FloatArrayEnumerator(FloatArray collection)
		{
			collectionRef = collection;
			currentIndex = -1;
			currentObject = null;
			currentSize = collectionRef.Count;
		}

		// Type-safe iterator Current
		public float Current
		{
			get
			{
				if (currentIndex == -1)
					throw new InvalidOperationException("Enumeration not started.");
				if (currentIndex > currentSize - 1)
					throw new InvalidOperationException("Enumeration finished.");
				if (currentObject == null)
					throw new InvalidOperationException("Collection modified.");
				return (float) currentObject;
			}
		}

		// Type-unsafe IEnumerator.Current
		object System.Collections.IEnumerator.Current { get { return Current; } }

		public bool MoveNext()
		{
			int size = collectionRef.Count;
			bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
			if (moveOkay)
			{
				currentIndex++;
				currentObject = collectionRef[currentIndex];
			}
			else
				currentObject = null;
		  return moveOkay;
		}

		public void Reset()
		{
			currentIndex = -1;
			currentObject = null;
			if (collectionRef.GetSize() != currentSize)
				throw new InvalidOperationException("Collection modified.");
		}

		public void Dispose()
		{
			currentIndex = -1;
			currentObject = null;
		}
		
		public void Reverse()
		{
			collectionRef.Reverse(0, (int) currentSize);
		}
	}

  public FloatArray(long size) : this(VixenLibPINVOKE.new_FloatArray__SWIG_0(size), true) {
  }

  public FloatArray() : this(VixenLibPINVOKE.new_FloatArray__SWIG_1(), true) {
  }

  private float getitem(long index) {
    float ret = VixenLibPINVOKE.FloatArray_getitem(swigCPtr, index);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(long index, float val) {
    VixenLibPINVOKE.FloatArray_setitem(swigCPtr, index, val);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(SharedFloatArray values) {
    VixenLibPINVOKE.FloatArray_AddRange(swigCPtr, SharedFloatArray.getCPtr(values));
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatArray GetRange(int index, int count) 
	{
		IntPtr cPtr = VixenLibPINVOKE.FloatArray_GetRange(swigCPtr, index, count);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
		return (FloatArray)  SharedObj.MakeObject(cPtr, true);
	}


  public void Insert(int index, float x) {
    VixenLibPINVOKE.FloatArray_Insert(swigCPtr, index, x);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, SharedFloatArray values) {
    VixenLibPINVOKE.FloatArray_InsertRange(swigCPtr, index, SharedFloatArray.getCPtr(values));
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    VixenLibPINVOKE.FloatArray_RemoveAt(swigCPtr, index);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveElem(int index) {
    VixenLibPINVOKE.FloatArray_RemoveElem(swigCPtr, index);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    VixenLibPINVOKE.FloatArray_RemoveRange(swigCPtr, index, count);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FloatArray Repeat(float value, int count) 
	{
		IntPtr cPtr = VixenLibPINVOKE.FloatArray_Repeat(value, count);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
		return (FloatArray)  SharedObj.MakeObject(cPtr, true);
	}


  public void Reverse(int index, int count) {
    VixenLibPINVOKE.FloatArray_Reverse(swigCPtr, index, count);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, SharedFloatArray values) {
    VixenLibPINVOKE.FloatArray_SetRange(swigCPtr, index, SharedFloatArray.getCPtr(values));
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(float value) {
    bool ret = VixenLibPINVOKE.FloatArray_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(float value) {
    int ret = VixenLibPINVOKE.FloatArray_IndexOf(swigCPtr, value);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(float value) {
    int ret = VixenLibPINVOKE.FloatArray_LastIndexOf(swigCPtr, value);
    if (VixenLibPINVOKE.SWIGPendingException.Pending) throw VixenLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(float value) {
    bool ret = VixenLibPINVOKE.FloatArray_Remove(swigCPtr, value);
    return ret;
  }

}

}