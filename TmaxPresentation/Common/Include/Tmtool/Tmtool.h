#if !defined(AFX_TMTOOL_H__36B9CA1F_C21A_4359_A47D_73995C12E21B__INCLUDED_)
#define AFX_TMTOOL_H__36B9CA1F_C21A_4359_A47D_73995C12E21B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.

/////////////////////////////////////////////////////////////////////////////
// CTMTool wrapper class

class CTMTool : public CWnd
{
protected:
	DECLARE_DYNCREATE(CTMTool)
public:
	CLSID const& GetClsid()
	{
		static CLSID const clsid
			= { 0x2341b5a2, 0x769b, 0x49cc, { 0x86, 0x52, 0xb8, 0x91, 0x49, 0x92, 0xaf, 0xb1 } };
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
	OLE_COLOR GetBackColor();
	void SetBackColor(OLE_COLOR);
	BOOL GetEnabled();
	void SetEnabled(BOOL);
	CString GetIniFile();
	void SetIniFile(LPCTSTR);
	short GetOrientation();
	void SetOrientation(short);
	short GetButtonSize();
	void SetButtonSize(short);
	short GetVerBuild();
	void SetVerBuild(short);
	short GetVerMajor();
	void SetVerMajor(short);
	short GetVerMinor();
	void SetVerMinor(short);
	BOOL GetAutoInit();
	void SetAutoInit(BOOL);
	BOOL GetEnableErrors();
	void SetEnableErrors(BOOL);
	short GetStyle();
	void SetStyle(short);
	BOOL GetStretch();
	void SetStretch(BOOL);
	CString GetButtonMask();
	void SetButtonMask(LPCTSTR);
	BOOL GetToolTips();
	void SetToolTips(BOOL);
	BOOL GetConfigurable();
	void SetConfigurable(BOOL);
	CString GetVerTextLong();
	void SetVerTextLong(LPCTSTR);
	CString GetIniSection();
	void SetIniSection(LPCTSTR);
	short GetButtonRows();
	void SetButtonRows(short);
	BOOL GetAutoReset();
	void SetAutoReset(BOOL);
	BOOL GetUseSystemBackground();
	void SetUseSystemBackground(BOOL);
	short GetVerQEF();
	void SetVerQEF(short);
	CString GetVerTextShort();
	void SetVerTextShort(LPCTSTR);
	CString GetVerBuildDate();
	void SetVerBuildDate(LPCTSTR);

// Operations
public:
	short GetBarWidth();
	short GetBarHeight();
	short SetButtonImage(short sId, short sImage);
	short Initialize();
	short ResetFrame();
	short SetColorButton(short sId);
	short SetToolButton(short sId);
	BOOL IsButton(short sId);
	CString GetButtonLabel(short sId);
	short SetButtonMap(short* pMap);
	short SetPlayButton(BOOL bPlaying);
	short SetSplitButton(BOOL bSplit, BOOL bHorizontal);
	short SetLinkButton(BOOL bDisabled);
	short Configure();
	short SetButtonLabel(short sId, LPCTSTR lpLabel);
	short CheckButton(short sId, BOOL bCheck);
	short EnableButton(short sId, BOOL bEnable);
	short HideButton(short sId, BOOL bHide);
	short Popup(long hWnd);
	short GetImageIndex(short sId);
	short GetButtonId(short sImageIndex);
	short SetShapeButton(short sId);
	short GetButtonMap(short* paMap);
	short Save();
	CString GetClassIdString();
	CString GetRegisteredPath();
	short Reset();
	short SetZoomButton(BOOL bZoom, BOOL bRestricted);
	short GetSortOrder(short* pOrder);
	short GetSortedId(short sId);
	short GetButtonActualWidth();
	short GetBarXPosition();
	short GetButtonXPosition(short sId);
	void AboutBox();
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TMTOOL_H__36B9CA1F_C21A_4359_A47D_73995C12E21B__INCLUDED_)
