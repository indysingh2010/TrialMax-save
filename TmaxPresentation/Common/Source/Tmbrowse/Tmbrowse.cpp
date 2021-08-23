// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.


#include "stdafx.h"
#include "tmbrowse.h"

/////////////////////////////////////////////////////////////////////////////
// CTMBrowse

IMPLEMENT_DYNCREATE(CTMBrowse, CWnd)

/////////////////////////////////////////////////////////////////////////////
// CTMBrowse properties

BOOL CTMBrowse::GetAutoInit()
{
	BOOL result;
	GetProperty(0x1, VT_BOOL, (void*)&result);
	return result;
}

void CTMBrowse::SetAutoInit(BOOL propVal)
{
	SetProperty(0x1, VT_BOOL, propVal);
}

short CTMBrowse::GetVerBuild()
{
	short result;
	GetProperty(0x2, VT_I2, (void*)&result);
	return result;
}

void CTMBrowse::SetVerBuild(short propVal)
{
	SetProperty(0x2, VT_I2, propVal);
}

BOOL CTMBrowse::GetEnableErrors()
{
	BOOL result;
	GetProperty(0x3, VT_BOOL, (void*)&result);
	return result;
}

void CTMBrowse::SetEnableErrors(BOOL propVal)
{
	SetProperty(0x3, VT_BOOL, propVal);
}

short CTMBrowse::GetVerMajor()
{
	short result;
	GetProperty(0x4, VT_I2, (void*)&result);
	return result;
}

void CTMBrowse::SetVerMajor(short propVal)
{
	SetProperty(0x4, VT_I2, propVal);
}

short CTMBrowse::GetVerMinor()
{
	short result;
	GetProperty(0x5, VT_I2, (void*)&result);
	return result;
}

void CTMBrowse::SetVerMinor(short propVal)
{
	SetProperty(0x5, VT_I2, propVal);
}

CString CTMBrowse::GetVerTextLong()
{
	CString result;
	GetProperty(0x6, VT_BSTR, (void*)&result);
	return result;
}

void CTMBrowse::SetVerTextLong(LPCTSTR propVal)
{
	SetProperty(0x6, VT_BSTR, propVal);
}

CString CTMBrowse::GetIniFile()
{
	CString result;
	GetProperty(0x7, VT_BSTR, (void*)&result);
	return result;
}

void CTMBrowse::SetIniFile(LPCTSTR propVal)
{
	SetProperty(0x7, VT_BSTR, propVal);
}

OLE_COLOR CTMBrowse::GetBackColor()
{
	OLE_COLOR result;
	GetProperty(DISPID_BACKCOLOR, VT_I4, (void*)&result);
	return result;
}

void CTMBrowse::SetBackColor(OLE_COLOR propVal)
{
	SetProperty(DISPID_BACKCOLOR, VT_I4, propVal);
}

short CTMBrowse::GetBorderStyle()
{
	short result;
	GetProperty(DISPID_BORDERSTYLE, VT_I2, (void*)&result);
	return result;
}

void CTMBrowse::SetBorderStyle(short propVal)
{
	SetProperty(DISPID_BORDERSTYLE, VT_I2, propVal);
}

OLE_COLOR CTMBrowse::GetForeColor()
{
	OLE_COLOR result;
	GetProperty(DISPID_FORECOLOR, VT_I4, (void*)&result);
	return result;
}

void CTMBrowse::SetForeColor(OLE_COLOR propVal)
{
	SetProperty(DISPID_FORECOLOR, VT_I4, propVal);
}

OLE_HANDLE CTMBrowse::GetHWnd()
{
	OLE_HANDLE result;
	GetProperty(DISPID_HWND, VT_I4, (void*)&result);
	return result;
}

void CTMBrowse::SetHWnd(OLE_HANDLE propVal)
{
	SetProperty(DISPID_HWND, VT_I4, propVal);
}

CString CTMBrowse::GetFilename()
{
	CString result;
	GetProperty(0x8, VT_BSTR, (void*)&result);
	return result;
}

void CTMBrowse::SetFilename(LPCTSTR propVal)
{
	SetProperty(0x8, VT_BSTR, propVal);
}

short CTMBrowse::GetVerQEF()
{
	short result;
	GetProperty(0x100, VT_I2, (void*)&result);
	return result;
}

void CTMBrowse::SetVerQEF(short propVal)
{
	SetProperty(0x100, VT_I2, propVal);
}

CString CTMBrowse::GetVerTextShort()
{
	CString result;
	GetProperty(0x101, VT_BSTR, (void*)&result);
	return result;
}

void CTMBrowse::SetVerTextShort(LPCTSTR propVal)
{
	SetProperty(0x101, VT_BSTR, propVal);
}

CString CTMBrowse::GetVerBuildDate()
{
	CString result;
	GetProperty(0x102, VT_BSTR, (void*)&result);
	return result;
}

void CTMBrowse::SetVerBuildDate(LPCTSTR propVal)
{
	SetProperty(0x102, VT_BSTR, propVal);
}

/////////////////////////////////////////////////////////////////////////////
// CTMBrowse operations

CString CTMBrowse::GetRegisteredPath()
{
	CString result;
	InvokeHelper(0x9, DISPATCH_METHOD, VT_BSTR, (void*)&result, NULL);
	return result;
}

CString CTMBrowse::GetClassIdString()
{
	CString result;
	InvokeHelper(0xa, DISPATCH_METHOD, VT_BSTR, (void*)&result, NULL);
	return result;
}

short CTMBrowse::Initialize()
{
	short result;
	InvokeHelper(0xb, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMBrowse::Load(LPCTSTR lpszFilename)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0xc, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpszFilename);
	return result;
}

void CTMBrowse::AboutBox()
{
	InvokeHelper(0xfffffdd8, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}