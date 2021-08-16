//==============================================================================
//
// File Name:	shareapp.cpp
//
// Description:	This file contains member functions of the CTMShareApp class.
//
// See Also:	shareapp.h
//
// Copyright	FTI Consulting 1997-2002
//
//==============================================================================
//	Date		Revision    Description
//	04-05-02	1.00		Original Release
//==============================================================================

//------------------------------------------------------------------------------
//	INCLUDES
//------------------------------------------------------------------------------
#include <stdafx.h>
#include <shareapp.h>
#include <plugreg.h>
#include <sharectl.h>

//------------------------------------------------------------------------------
//	DEFINES
//------------------------------------------------------------------------------
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

//------------------------------------------------------------------------------
//	REVISION INFORMATION
//------------------------------------------------------------------------------
//
//	_wVerMajor:	Major version identifer is changed when significant changes
//				have been made in the entire suite of controls and applications
//				All controls and applications should ALWAYS have the same
//				major version identifier
//	_wVerMinor:	Minor version identifier is changed when changes have been made
//				to a control and/or application that would render it unusable
//				with the existing release. All controls and applications will
//				have the same minor revision identifier when bundled as a new
//				release but individual controls and/or applications may be
//				upgraded between releases.
//	_wVerBuild:	Build version identifier is used to track controls and 
//				applications during development. This identifier is updated
//				on a weekly basis.
//
//	NOTE:		For ActiveX controls, the associated object definition library
//				(.odl) file MUST be updated when the major or minor version
//				identifiers are changed.
//
//	rev	6.0:	Converted to Visual Studio .NET
//				
//	rev 6.1.0:	Changed Build property to VerBuild
//				Changed TextVer property to VerTextLong
//				Changed MajorVer property to VerMajor
//				Changed MinorVer property to VerMinor
//				Added VerQEF property
//				Added VerTextShort property
//				Added VerBuildDate property
//				Modified constructor to extract version identifiers from
//				the control's Version resource
//				
//------------------------------------------------------------------------------
const WORD	_wVerMajor = 6;
const WORD	_wVerMinor = 4;

//------------------------------------------------------------------------------
//	GLOBALS
//------------------------------------------------------------------------------
CTMShareApp NEAR theApp;

/* Replace 1 */
const GUID CDECL BASED_CODE _tlid =
		{ 0x30ff3a86, 0xccd7, 0x474c, { 0xa7, 0x6, 0xcf, 0x89, 0xb0, 0x21, 0xac, 0xae } };

//------------------------------------------------------------------------------
//	MAPS
//------------------------------------------------------------------------------

//==============================================================================
//
// 	Function Name:	CTMShareApp::ExitInstance()
//
// 	Description:	This is called when a user releases an instance.
//
// 	Returns:		The exit level.
//
//	Notes:			None
//
//==============================================================================
int CTMShareApp::ExitInstance()
{
	return COleControlModule::ExitInstance();
}

//==============================================================================
//
// 	Function Name:	CTMShareApp::InitInstance()
//
// 	Description:	This is called when a user requests an instance.
//
// 	Returns:		TRUE if successful.
//
//	Notes:			None
//
//==============================================================================
BOOL CTMShareApp::InitInstance()
{
	if(COleControlModule::InitInstance())
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}

}

//==============================================================================
//
// 	Function Name:	DllRegisterServer()
//
// 	Description:	This is called to register the ocx control.
//
// 	Returns:		None
//
//	Notes:			None
//
//==============================================================================
STDAPI DllRegisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleRegisterTypeLib(AfxGetInstanceHandle(), _tlid))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(TRUE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}

//==============================================================================
//
// 	Function Name:	DllUnregisterServer()
//
// 	Description:	This is called to unregister the ocx control.
//
// 	Returns:		None
//
//	Notes:			None
//
//==============================================================================
STDAPI DllUnregisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleUnregisterTypeLib(_tlid, _wVerMajor, _wVerMinor))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(FALSE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}

