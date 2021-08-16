#if !defined(AFX_TMXML_H__7E6CD9E1_B768_4E4E_ADDF_2AE59E306BFC__INCLUDED_)
#define AFX_TMXML_H__7E6CD9E1_B768_4E4E_ADDF_2AE59E306BFC__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.

/////////////////////////////////////////////////////////////////////////////
// CTMXml wrapper class

class CTMXml : public CWnd
{
protected:
	DECLARE_DYNCREATE(CTMXml)
public:
	CLSID const& GetClsid()
	{
		static CLSID const clsid
			= { 0x6a8f7fe8, 0x265a, 0x431b, { 0xab, 0x92, 0xa3, 0x66, 0x18, 0x48, 0xd4, 0xa1 } };
		return clsid;
	}
	virtual BOOL Create(LPCTSTR lpszClassName,
		LPCTSTR lpszWindowName, DWORD dwStyle,
		const RECT& rect,
		CWnd* pParentWnd, UINT nID,
		CCreateContext* pContext = NULL)
	{ return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID); }

    BOOL Create(LPCTSTR lpszWindowName, DWORD dwStyle,
		const RECT& rect, CWnd* pParentWnd, UINT nID,
		CFile* pPersist = NULL, BOOL bStorage = FALSE,
		BSTR bstrLicKey = NULL)
	{ return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID,
		pPersist, bStorage, bstrLicKey); }

// Attributes
public:
	short GetVerBuild();
	void SetVerBuild(short);
	OLE_COLOR GetBackColor();
	void SetBackColor(OLE_COLOR);
	OLE_COLOR GetForeColor();
	void SetForeColor(OLE_COLOR);
	BOOL GetEnableErrors();
	void SetEnableErrors(BOOL);
	short GetVerMajor();
	void SetVerMajor(short);
	short GetVerMinor();
	void SetVerMinor(short);
	CString GetVerTextLong();
	void SetVerTextLong(LPCTSTR);
	BOOL GetAutoInit();
	void SetAutoInit(BOOL);
	CString GetFilename();
	void SetFilename(LPCTSTR);
	BOOL GetDockPrintProgress();
	void SetDockPrintProgress(BOOL);
	short GetVerQEF();
	void SetVerQEF(short);
	CString GetVerTextShort();
	void SetVerTextShort(LPCTSTR);
	CString GetVerBuildDate();
	void SetVerBuildDate(LPCTSTR);

// Operations
public:
	short Initialize();
	short LoadFile(LPCTSTR lpFilename);
	CString GetClassIdString();
	CString GetRegisteredPath();
	short loadDocument(LPCTSTR lpszUrl);
	short jumpToPage(LPCTSTR lpszPageId);
	void AboutBox();
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TMXML_H__7E6CD9E1_B768_4E4E_ADDF_2AE59E306BFC__INCLUDED_)
