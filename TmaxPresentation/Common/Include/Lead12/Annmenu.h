#if !defined(AFX_ANNMENU_H__31A112CE_5F5B_11D5_8F0A_00802966F8C1__INCLUDED_)
#define AFX_ANNMENU_H__31A112CE_5F5B_11D5_8F0A_00802966F8C1__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.

/////////////////////////////////////////////////////////////////////////////
// CAnnMenu wrapper class

class CAnnMenu : public COleDispatchDriver
{
public:
	CAnnMenu() {}		// Calls COleDispatchDriver default constructor
	CAnnMenu(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CAnnMenu(const CAnnMenu& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

// Attributes
public:
	short GetCount();
	void SetCount(short);

// Operations
public:
	CString GetItemString(short iIndex);
	void SetItemString(short iIndex, LPCTSTR lpszNewValue);
	long GetItemID(short iIndex);
	void SetItemID(short iIndex, long nNewValue);
	short GetItemType(short iIndex);
	void SetItemType(short iIndex, short nNewValue);
	BOOL GetItemChecked(short iIndex);
	void SetItemChecked(short iIndex, BOOL bNewValue);
	BOOL GetItemEnabled(short iIndex);
	void SetItemEnabled(short iIndex, BOOL bNewValue);
	short DeleteItem(short iIndex);
	short AddItem(LPCTSTR pszString, short iType, long nID, short iIndexBefore);
	CAnnMenu GetSubMenu(short iIndex);
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ANNMENU_H__31A112CE_5F5B_11D5_8F0A_00802966F8C1__INCLUDED_)