// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.


#include "stdafx.h"
#include "tmmovie.h"

/////////////////////////////////////////////////////////////////////////////
// CTMMovie

IMPLEMENT_DYNCREATE(CTMMovie, CWnd)

/////////////////////////////////////////////////////////////////////////////
// CTMMovie properties

BOOL CTMMovie::GetAutoInit()
{
	BOOL result;
	GetProperty(0x5, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetAutoInit(BOOL propVal)
{
	SetProperty(0x5, VT_BOOL, propVal);
}

BOOL CTMMovie::GetEnableErrors()
{
	BOOL result;
	GetProperty(0x6, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetEnableErrors(BOOL propVal)
{
	SetProperty(0x6, VT_BOOL, propVal);
}

CString CTMMovie::GetIniFile()
{
	CString result;
	GetProperty(0x7, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetIniFile(LPCTSTR propVal)
{
	SetProperty(0x7, VT_BSTR, propVal);
}

BOOL CTMMovie::GetAutoPlay()
{
	BOOL result;
	GetProperty(0x8, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetAutoPlay(BOOL propVal)
{
	SetProperty(0x8, VT_BOOL, propVal);
}

BOOL CTMMovie::GetScaleVideo()
{
	BOOL result;
	GetProperty(0x9, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetScaleVideo(BOOL propVal)
{
	SetProperty(0x9, VT_BOOL, propVal);
}

OLE_COLOR CTMMovie::GetBackColor()
{
	OLE_COLOR result;
	GetProperty(DISPID_BACKCOLOR, VT_I4, (void*)&result);
	return result;
}

void CTMMovie::SetBackColor(OLE_COLOR propVal)
{
	SetProperty(DISPID_BACKCOLOR, VT_I4, propVal);
}

short CTMMovie::GetBorderStyle()
{
	short result;
	GetProperty(DISPID_BORDERSTYLE, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetBorderStyle(short propVal)
{
	SetProperty(DISPID_BORDERSTYLE, VT_I2, propVal);
}

CString CTMMovie::GetFilename()
{
	CString result;
	GetProperty(0xa, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetFilename(LPCTSTR propVal)
{
	SetProperty(0xa, VT_BSTR, propVal);
}

short CTMMovie::GetUpdateRate()
{
	short result;
	GetProperty(0xb, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetUpdateRate(short propVal)
{
	SetProperty(0xb, VT_I2, propVal);
}

BOOL CTMMovie::GetAutoShow()
{
	BOOL result;
	GetProperty(0xc, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetAutoShow(BOOL propVal)
{
	SetProperty(0xc, VT_BOOL, propVal);
}

BOOL CTMMovie::GetKeepAspect()
{
	BOOL result;
	GetProperty(0xd, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetKeepAspect(BOOL propVal)
{
	SetProperty(0xd, VT_BOOL, propVal);
}

short CTMMovie::GetBalance()
{
	short result;
	GetProperty(0xe, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetBalance(short propVal)
{
	SetProperty(0xe, VT_I2, propVal);
}

short CTMMovie::GetRate()
{
	short result;
	GetProperty(0xf, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetRate(short propVal)
{
	SetProperty(0xf, VT_I2, propVal);
}

short CTMMovie::GetVolume()
{
	short result;
	GetProperty(0x10, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetVolume(short propVal)
{
	SetProperty(0x10, VT_I2, propVal);
}

BOOL CTMMovie::GetUseSnapshots()
{
	BOOL result;
	GetProperty(0x11, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetUseSnapshots(BOOL propVal)
{
	SetProperty(0x11, VT_BOOL, propVal);
}

CString CTMMovie::GetOverlayFile()
{
	CString result;
	GetProperty(0x12, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetOverlayFile(LPCTSTR propVal)
{
	SetProperty(0x12, VT_BSTR, propVal);
}

BOOL CTMMovie::GetOverlayVisible()
{
	BOOL result;
	GetProperty(0x13, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetOverlayVisible(BOOL propVal)
{
	SetProperty(0x13, VT_BOOL, propVal);
}

CString CTMMovie::GetVerTextLong()
{
	CString result;
	GetProperty(0x17, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetVerTextLong(LPCTSTR propVal)
{
	SetProperty(0x17, VT_BSTR, propVal);
}

double CTMMovie::GetPlaylistTime()
{
	double result;
	GetProperty(0x1, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetPlaylistTime(double propVal)
{
	SetProperty(0x1, VT_R8, propVal);
}

double CTMMovie::GetElapsedDesignation()
{
	double result;
	GetProperty(0x2, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetElapsedDesignation(double propVal)
{
	SetProperty(0x2, VT_R8, propVal);
}

double CTMMovie::GetElapsedPlaylist()
{
	double result;
	GetProperty(0x3, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetElapsedPlaylist(double propVal)
{
	SetProperty(0x3, VT_R8, propVal);
}

double CTMMovie::GetDesignationTime()
{
	double result;
	GetProperty(0x4, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetDesignationTime(double propVal)
{
	SetProperty(0x4, VT_R8, propVal);
}

double CTMMovie::GetStartPosition()
{
	double result;
	GetProperty(0x14, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetStartPosition(double propVal)
{
	SetProperty(0x14, VT_R8, propVal);
}

double CTMMovie::GetStopPosition()
{
	double result;
	GetProperty(0x15, VT_R8, (void*)&result);
	return result;
}

void CTMMovie::SetStopPosition(double propVal)
{
	SetProperty(0x15, VT_R8, propVal);
}

BOOL CTMMovie::GetEnableAxErrors()
{
	BOOL result;
	GetProperty(0x16, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetEnableAxErrors(BOOL propVal)
{
	SetProperty(0x16, VT_BOOL, propVal);
}

BOOL CTMMovie::GetDetachBeforeLoad()
{
	BOOL result;
	GetProperty(0x101, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetDetachBeforeLoad(BOOL propVal)
{
	SetProperty(0x101, VT_BOOL, propVal);
}

BOOL CTMMovie::GetHideTaskBar()
{
	BOOL result;
	GetProperty(0x102, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetHideTaskBar(BOOL propVal)
{
	SetProperty(0x102, VT_BOOL, propVal);
}

BOOL CTMMovie::GetEnableSimulation()
{
	BOOL result;
	GetProperty(0x103, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetEnableSimulation(BOOL propVal)
{
	SetProperty(0x103, VT_BOOL, propVal);
}

CString CTMMovie::GetSimulationText()
{
	CString result;
	GetProperty(0x104, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetSimulationText(LPCTSTR propVal)
{
	SetProperty(0x104, VT_BSTR, propVal);
}

short CTMMovie::GetVerMajor()
{
	short result;
	GetProperty(0x105, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetVerMajor(short propVal)
{
	SetProperty(0x105, VT_I2, propVal);
}

short CTMMovie::GetVerMinor()
{
	short result;
	GetProperty(0x106, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetVerMinor(short propVal)
{
	SetProperty(0x106, VT_I2, propVal);
}

short CTMMovie::GetVerQEF()
{
	short result;
	GetProperty(0x108, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetVerQEF(short propVal)
{
	SetProperty(0x108, VT_I2, propVal);
}

short CTMMovie::GetVerBuild()
{
	short result;
	GetProperty(0x107, VT_I2, (void*)&result);
	return result;
}

void CTMMovie::SetVerBuild(short propVal)
{
	SetProperty(0x107, VT_I2, propVal);
}

CString CTMMovie::GetVerTextShort()
{
	CString result;
	GetProperty(0x109, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetVerTextShort(LPCTSTR propVal)
{
	SetProperty(0x109, VT_BSTR, propVal);
}

CString CTMMovie::GetVerBuildDate()
{
	CString result;
	GetProperty(0x10a, VT_BSTR, (void*)&result);
	return result;
}

void CTMMovie::SetVerBuildDate(LPCTSTR propVal)
{
	SetProperty(0x10a, VT_BSTR, propVal);
}

BOOL CTMMovie::GetShowAudioImage()
{
	BOOL result;
	GetProperty(0x10b, VT_BOOL, (void*)&result);
	return result;
}

void CTMMovie::SetShowAudioImage(BOOL propVal)
{
	SetProperty(0x10b, VT_BOOL, propVal);
}

/////////////////////////////////////////////////////////////////////////////
// CTMMovie operations

short CTMMovie::Unload()
{
	short result;
	InvokeHelper(0x18, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::Initialize()
{
	short result;
	InvokeHelper(0x19, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::Play()
{
	short result;
	InvokeHelper(0x1a, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::Pause()
{
	short result;
	InvokeHelper(0x1b, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::Stop()
{
	short result;
	InvokeHelper(0x1c, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::Resume()
{
	short result;
	InvokeHelper(0x1d, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::IsReady()
{
	BOOL result;
	InvokeHelper(0x1e, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

short CTMMovie::GetState()
{
	short result;
	InvokeHelper(0x1f, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

float CTMMovie::GetFrameRate()
{
	float result;
	InvokeHelper(0x20, DISPATCH_METHOD, VT_R4, (void*)&result, NULL);
	return result;
}

short CTMMovie::GetSrcWidth()
{
	short result;
	InvokeHelper(0x21, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::GetSrcHeight()
{
	short result;
	InvokeHelper(0x22, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::ShowVideoProps()
{
	short result;
	InvokeHelper(0x23, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::CheckType(LPCTSTR lpFilename)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x24, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpFilename);
	return result;
}

short CTMMovie::GetPlaylistState()
{
	short result;
	InvokeHelper(0x25, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::GetType()
{
	short result;
	InvokeHelper(0x26, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

void CTMMovie::ShowVideo(BOOL bShow)
{
	static BYTE parms[] =
		VTS_BOOL;
	InvokeHelper(0x27, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 bShow);
}

BOOL CTMMovie::IsVideoVisible()
{
	BOOL result;
	InvokeHelper(0x28, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::CanSetVolume()
{
	BOOL result;
	InvokeHelper(0x29, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::CanSetBalance()
{
	BOOL result;
	InvokeHelper(0x2a, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::CanSetRate()
{
	BOOL result;
	InvokeHelper(0x2b, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::IsLoaded()
{
	BOOL result;
	InvokeHelper(0x2c, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

short CTMMovie::Update()
{
	short result;
	InvokeHelper(0x2d, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

short CTMMovie::GetResolution()
{
	short result;
	InvokeHelper(0x2e, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

long CTMMovie::ShowSnapshot()
{
	long result;
	InvokeHelper(0x2f, DISPATCH_METHOD, VT_I4, (void*)&result, NULL);
	return result;
}

short CTMMovie::Capture(LPCTSTR lpFilespec, BOOL bResume)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR VTS_BOOL;
	InvokeHelper(0x30, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpFilespec, bResume);
	return result;
}

CString CTMMovie::GetRegFilters(long* pCount)
{
	CString result;
	static BYTE parms[] =
		VTS_PI4;
	InvokeHelper(0x31, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms,
		pCount);
	return result;
}

void CTMMovie::ShowFilterInfo()
{
	InvokeHelper(0x32, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}

CString CTMMovie::GetActFilters(BOOL bVendorInfo, long* pCount)
{
	CString result;
	static BYTE parms[] =
		VTS_BOOL VTS_PI4;
	InvokeHelper(0x33, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms,
		bVendorInfo, pCount);
	return result;
}

LPUNKNOWN CTMMovie::GetInterface(short sInterface)
{
	LPUNKNOWN result;
	static BYTE parms[] =
		VTS_I2;
	InvokeHelper(0x34, DISPATCH_METHOD, VT_UNKNOWN, (void*)&result, parms,
		sInterface);
	return result;
}

void CTMMovie::SetDefaultRate(double dFrameRate)
{
	static BYTE parms[] =
		VTS_R8;
	InvokeHelper(0x35, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 dFrameRate);
}

double CTMMovie::GetDefaultRate()
{
	double result;
	InvokeHelper(0x36, DISPATCH_METHOD, VT_R8, (void*)&result, NULL);
	return result;
}

short CTMMovie::SetPlaylistRange(long lStart, long lStop)
{
	short result;
	static BYTE parms[] =
		VTS_I4 VTS_I4;
	InvokeHelper(0x37, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lStart, lStop);
	return result;
}

CString CTMMovie::GetClassIdString()
{
	CString result;
	InvokeHelper(0x38, DISPATCH_METHOD, VT_BSTR, (void*)&result, NULL);
	return result;
}

CString CTMMovie::GetRegisteredPath()
{
	CString result;
	InvokeHelper(0x39, DISPATCH_METHOD, VT_BSTR, (void*)&result, NULL);
	return result;
}

short CTMMovie::AddFilter(LPCTSTR lpszName)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x3a, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpszName);
	return result;
}

short CTMMovie::RemoveFilter(LPCTSTR lpszName)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x3b, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpszName);
	return result;
}

CString CTMMovie::GetUserFilters(long* pCount)
{
	CString result;
	static BYTE parms[] =
		VTS_PI4;
	InvokeHelper(0x3c, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms,
		pCount);
	return result;
}

double CTMMovie::GetMinTime()
{
	double result;
	InvokeHelper(0x3d, DISPATCH_METHOD, VT_R8, (void*)&result, NULL);
	return result;
}

double CTMMovie::GetMaxTime()
{
	double result;
	InvokeHelper(0x3e, DISPATCH_METHOD, VT_R8, (void*)&result, NULL);
	return result;
}

double CTMMovie::GetPosition()
{
	double result;
	InvokeHelper(0x3f, DISPATCH_METHOD, VT_R8, (void*)&result, NULL);
	return result;
}

long CTMMovie::ConvertToFrames(double dSeconds)
{
	long result;
	static BYTE parms[] =
		VTS_R8;
	InvokeHelper(0x40, DISPATCH_METHOD, VT_I4, (void*)&result, parms,
		dSeconds);
	return result;
}

short CTMMovie::SetMaxCuePosition(double dPosition)
{
	short result;
	static BYTE parms[] =
		VTS_R8;
	InvokeHelper(0x41, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		dPosition);
	return result;
}

short CTMMovie::SetMinCuePosition(double dPosition)
{
	short result;
	static BYTE parms[] =
		VTS_R8;
	InvokeHelper(0x42, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		dPosition);
	return result;
}

short CTMMovie::SetRange(double dStart, double dStop)
{
	short result;
	static BYTE parms[] =
		VTS_R8 VTS_R8;
	InvokeHelper(0x43, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		dStart, dStop);
	return result;
}

short CTMMovie::Cue(short sType, double dSeconds, BOOL bResume)
{
	short result;
	static BYTE parms[] =
		VTS_I2 VTS_R8 VTS_BOOL;
	InvokeHelper(0x44, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		sType, dSeconds, bResume);
	return result;
}

short CTMMovie::Load(LPCTSTR lpszFilename, double dStart, double dStop, BOOL bPlay)
{
	short result;
	static BYTE parms[] =
		VTS_BSTR VTS_R8 VTS_R8 VTS_BOOL;
	InvokeHelper(0x45, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lpszFilename, dStart, dStop, bPlay);
	return result;
}

short CTMMovie::Step(double dFrom, double dTo)
{
	short result;
	static BYTE parms[] =
		VTS_R8 VTS_R8;
	InvokeHelper(0x46, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		dFrom, dTo);
	return result;
}

double CTMMovie::ConvertToTime(long lFrame)
{
	double result;
	static BYTE parms[] =
		VTS_I4;
	InvokeHelper(0x47, DISPATCH_METHOD, VT_R8, (void*)&result, parms,
		lFrame);
	return result;
}

short CTMMovie::CuePlaylist(short sType, double dSeconds, BOOL bResume, BOOL bPlayToEnd)
{
	short result;
	static BYTE parms[] =
		VTS_I2 VTS_R8 VTS_BOOL VTS_BOOL;
	InvokeHelper(0x48, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		sType, dSeconds, bResume, bPlayToEnd);
	return result;
}

short CTMMovie::PlayPlaylist(long pPlaylist, long lStart, long lStop, double dPosition)
{
	short result;
	static BYTE parms[] =
		VTS_I4 VTS_I4 VTS_I4 VTS_R8;
	InvokeHelper(0x49, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		pPlaylist, lStart, lStop, dPosition);
	return result;
}

short CTMMovie::CueDesignation(long lDesignation, double dPosition, short bResume)
{
	short result;
	static BYTE parms[] =
		VTS_I4 VTS_R8 VTS_I2;
	InvokeHelper(0x4a, DISPATCH_METHOD, VT_I2, (void*)&result, parms,
		lDesignation, dPosition, bResume);
	return result;
}

double CTMMovie::GetDuration(LPCTSTR lpszFilename)
{
	double result;
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x4b, DISPATCH_METHOD, VT_R8, (void*)&result, parms,
		lpszFilename);
	return result;
}

short CTMMovie::UpdateScreenPosition()
{
	short result;
	InvokeHelper(0x4c, DISPATCH_METHOD, VT_I2, (void*)&result, NULL);
	return result;
}

BOOL CTMMovie::GetIsAudio()
{
	BOOL result;
	InvokeHelper(0x4d, DISPATCH_METHOD, VT_BOOL, (void*)&result, NULL);
	return result;
}

void CTMMovie::ShowVideoBar()
{
	InvokeHelper(0x4e, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}

void CTMMovie::HideVideoBar()
{
	InvokeHelper(0x4f, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}
