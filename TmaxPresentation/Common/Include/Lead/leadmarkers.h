#if !defined(AFX_LEADMARKERS_H__93076CDF_9919_40E0_BAC6_7B5260D96D81__INCLUDED_)
#define AFX_LEADMARKERS_H__93076CDF_9919_40E0_BAC6_7B5260D96D81__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.


// Dispatch interfaces referenced by this interface
class CLEADMarker;

/////////////////////////////////////////////////////////////////////////////
// CLEADMarkers wrapper class

class CLEADMarkers : public COleDispatchDriver
{
public:
	CLEADMarkers() {}		// Calls COleDispatchDriver default constructor
	CLEADMarkers(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CLEADMarkers(const CLEADMarkers& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

// Attributes
public:
	long GetCount();
	void SetCount(long);

// Operations
public:
	short Delete(long lType, long lCount);
	short Insert(long lIndex, LPDISPATCH pMarker);
	short Insert2(long lIndex, long lType, long lSize, const VARIANT& vData);
	LPDISPATCH Clone();
	CLEADMarker GetMarker(long lIndex);
	void SetRefMarker(long lIndex, LPDISPATCH newValue);
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_LEADMARKERS_H__93076CDF_9919_40E0_BAC6_7B5260D96D81__INCLUDED_)