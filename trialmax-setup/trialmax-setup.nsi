RequestExecutionLevel user 	# start at user level to prevent UAC prompt, this cannot go in a section

# TRIALMAX SETUP NULLSOFT SCRIPT

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "TrialMax"
!define PRODUCT_VERSION "11.0"
!define PRODUCT_PUBLISHER "FTI Consulting"
!define PRODUCT_WEB_SITE "http://www.trialmax.com"

!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\TmaxManager.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

BrandingText " "

var /global is_admin


!include "MUI2.nsh"
!include "UAC.nsh"


# Unused code
!macro Init thing
uac_tryagain:
!insertmacro UAC_RunElevated
MessageBox mb_IconStop|mb_TopMost|mb_SetForeground "STAUS $0 $1"
${Switch} $0
${Case} 0
	${IfThen} $1 = 1 ${|} ${Break}${|} ;we are the outer process, the inner process has done its work, we are done
	${IfThen} $3 <> 0 ${|} Quit ${|} ;we are admin, let the show go on
	${If} $1 = 3 ;RunAs completed successfully, but with a non-admin user
		MessageBox mb_YesNo|mb_IconExclamation|mb_TopMost|mb_SetForeground "This ${thing} requires admin privileges, try again" /SD IDNO IDYES uac_tryagain IDNO 0
	${EndIf}
	;fall-through and die
${Case} 1223
	MessageBox mb_IconStop|mb_TopMost|mb_SetForeground "This ${thing} requires admin privileges, aborting!"
	Quit
${Case} 1062
	MessageBox mb_IconStop|mb_TopMost|mb_SetForeground "Logon service not running, aborting!"
	Quit
${Default}
	MessageBox mb_IconStop|mb_TopMost|mb_SetForeground "Unable to elevate, error $0"
	Quit
${EndSwitch}
 
SetShellVarContext all
!macroend




; MUI Settings
!define MUI_ABORTWARNING
#!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
#!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"
!define MUI_ICON "trialmax-setup-icon.ico"
!define MUI_UNICON "trialmax-setup-icon.ico"


#!define MUI_WELCOMEFINISHPAGE_BITMAP_NOSTRETCH		# This is how to expand the bitmap to size in file
# This is how to set a bitmap
!define MUI_WELCOMEFINISHPAGE_BITMAP "trialmax-setup-image.bmp"
#!define MUI_WELCOMEFINISHPAGE_BITMAP "c:\dev\TrialMax\Common\Resources\TM7splash_.bmp"
#!define MUI_WELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\nsis3-metro.bmp"

#!define MUI_WELCOMEPAGE_TITLE  "CUSTOM TITLE HERE"
#!define MUI_WELCOMEPAGE_TEXT  "CUSTOM TEXT HERE"

!define MUI_COMPONENTSPAGE_NODESC			# remove unwanted component description
!define MUI_COMPONENTSPAGE_TEXT_TOP 		"The following components will be installed"
!define MUI_COMPONENTSPAGE_TEXT_COMPLIST   "Unchecked items are already installed"

!define MUI_FINISHPAGE_NOAUTOCLOSE			# Leave details page open to view errors and messages for DEBUGGING
!define MUI_UNFINISHPAGE_NOAUTOCLOSE			# Leave details page open to view errors and messages for DEBUGGING
!define MUI_FINISHPAGE_RUN_NOTCHECKED		# Uncheck the run program after install

#!define MUI_PAGE_CUSTOMFUNCTION_PRE FinishPre
#Function FinishPre
#!insertmacro MUI_INSTALLOPTIONS_WRITE "ioSpecial.ini" "Field #" "Flags" "DISABLED"
#!insertmacro MUI_INSTALLOPTIONS_WRITE "ioSpecial.ini" "Field #" "State" "0"
#FunctionEnd





; PAGES TO SHOW
!define MUI_PAGE_CUSTOMFUNCTION_PRE init_welcome_page
!insertmacro MUI_PAGE_WELCOME
#!insertmacro MUI_PAGE_LICENSE "..\..\path\to\licence\YourSoftwareLicence.txt"

!define MUI_PAGE_CUSTOMFUNCTION_PRE init_components_page
!insertmacro MUI_PAGE_COMPONENTS

!define MUI_PAGE_CUSTOMFUNCTION_PRE init_directory_page
!insertmacro MUI_PAGE_DIRECTORY

!define MUI_PAGE_CUSTOMFUNCTION_PRE pre_instfiles_page
!define MUI_PAGE_CUSTOMFUNCTION_SHOW show_instfiles_page
!insertmacro MUI_PAGE_INSTFILES

!define MUI_PAGE_CUSTOMFUNCTION_PRE init_finish_page
!define MUI_FINISHPAGE_RUN "$INSTDIR\TmaxManager.exe"
!insertmacro MUI_PAGE_FINISH
; Uninstaller pages
!insertmacro MUI_UNPAGE_COMPONENTS
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Release\trialmax-setup.exe"
InstallDir "$PROGRAMFILES\FTI\TrialMax"
#InstallDir "$PROGRAMFILES\TrialMax"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

#Icon "${PACKAGE}\App\AppInfo\appicon.ico"
Icon "trialmax-setup-icon.ico"
VIProductVersion "${PRODUCT_VERSION}.0.0"	# requied, must be x.x.x.x appears in FileVerison in properties details
VIAddVersionKey FileVersion "3.4.5.6"  # required, but value is ignored
VIAddVersionKey ProductName "${PRODUCT_NAME}"
VIAddVersionKey CompanyName "FTI Consulting"
VIAddVersionKey LegalCopyright "FTI Consulting"
VIAddVersionKey FileDescription "${PRODUCT_NAME} ${PRODUCT_VERSION}"
VIAddVersionKey ProductVersion ${PRODUCT_VERSION}


Function init_components_page
  # if doing an update (i.e running as user not admin)
  # skip the components page
  # Alternatively run with a /S option
  ${if} $is_admin == 0
    Abort
  ${Endif}
FunctionEnd

Function init_welcome_page
  ${if} $is_admin == 0
    Abort
  ${Endif}
FunctionEnd

Function init_directory_page
  ${if} $is_admin == 0
    Abort
  ${Endif}
FunctionEnd

Function pre_instfiles_page
  ${if} $is_admin == 0
    GetDlgItem $0 $HWNDPARENT 1
    SendMessage $0 ${WM_SETTEXT} "0" "STR:TESTING1"
	# NOT WORKING - change is transient
	# overwritten at the end , using a leave function does not help
  ${Endif}
FunctionEnd
Function show_instfiles_page
  ${if} $is_admin == 0
    GetDlgItem $0 $HWNDPARENT 1
    SendMessage $0 ${WM_SETTEXT} "0" "STR:TESTING2"
	# NOT WORKING - change is transient
	# overwritten at the end , using a leave function does not help
  ${Endif}
FunctionEnd

Function init_finish_page
  ${if} $is_admin == 0
    Abort
  ${Endif}
FunctionEnd




; Install Prerequisites
Section "Crystal Reports 2008 Runtime" Crystal_Reports_section_id
    SetOutPath $INSTDIR
    File "..\Install\Bootstrapper-Packages\Crystal Reports 2008\CRRedist2008_x86.msi"
    #ExecWait '"$INSTDIR\CRRedist2008_x86.msi" /passive' -FAILS if you try to run the .msi file
    ExecWait 'msiexec /i "$INSTDIR\CRRedist2008_x86.msi" /passive'
    Delete "$INSTDIR\CRRedist2008_x86.msi"

SectionEnd

Section "Visual C++ 2015-2019 Runtime" VC2019_section_id
    SetOutPath $INSTDIR
    File "..\Install\Bootstrapper-Packages\vcredist_x86\VC_redist.x86.exe"
    ExecWait "$INSTDIR\VC_redist.x86.exe /passive"
    Delete "$INSTDIR\VC_redist.x86.exe"
SectionEnd

Section "Visual C++ 2005 Runtime" VC2005_section_id
    SetOutPath $INSTDIR
    File "..\Install\Bootstrapper-Packages\VC++ 2005 Runtime Libraries (x86)\vcredist_x86.exe"
    ExecWait "$INSTDIR\vcredist_x86.exe /q"
    Delete "$INSTDIR\vcredist_x86.exe"
SectionEnd

Section "K-Lite Codec Pack 1105" KLite_section_id
    SetOutPath $INSTDIR
    File "..\Install\Bootstrapper-Packages\K-Lite Codec Pack\K-Lite_Codec_Pack_1105_Full.exe"
    ExecWait "$INSTDIR\K-Lite_Codec_Pack_1105_Full.exe /silent"
    Delete "$INSTDIR\K-Lite_Codec_Pack_1105_Full.exe"
SectionEnd

Section "TrialMax" tmax_section_id
  SetOutPath "$INSTDIR"
  !include "exe-files.nsh"
  !include "dll-files.nsh"
  !include "data-files.nsh"
  #SetOutPath "$SYSDIR"
  !include "lead-files.nsh"
  #SetOutPath "$INSTDIR\Common"
  !include "ocx-files.nsh"
  SetOutPath "$INSTDIR\PDFManager"
  !include "pdfmanager-files.nsh"

  SetOutPath "$INSTDIR"		# this has no effect for RegDLL function
  # REGISTER DLLS
  DetailPrint "REGISTERING *.ocx"
  ${if} $is_admin == 1
    FindFirst $0 $1 "$INSTDIR\*.ocx"
    loop:
      StrCmp $1 "" done
      RegDLL "$INSTDIR\$1"
      FindNext $0 $1
      Goto loop
    done:
    FindClose $0
  ${endif}

  AccessControl::GrantOnFile  "$INSTDIR" "(S-1-5-32-545)" "FullAccess"
  AccessControl::GrantOnFile  "$INSTDIR\PDFManager" "(S-1-5-32-545)" "FullAccess"
  AccessControl::GrantOnFile  "$INSTDIR\..\FTIORE" "(S-1-5-32-545)" "FullAccess"
  AccessControl::GrantOnFile  "$INSTDIR\..\Common" "(S-1-5-32-545)" "FullAccess"
  
  SetOutPath "$INSTDIR"			# This sets the 'Start In' directory in the shortcut
  CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\TrialMax.lnk" "$INSTDIR\TmaxManager.exe"
  CreateShortCut "$DESKTOP\TrialMax.lnk" "$INSTDIR\TmaxManager.exe"
  
  #WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  #CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\uninstall.exe"
  
  # WIP FTIORE PATH  
  WriteRegStr HKLM "SOFTWARE\FTIORE" "" "$INSTDIR"
  
  # Show this message is update mode in case of silent operation
  ${if} $is_admin == 0
    ${andif} ${Silent}
    MessageBox MB_OK "$(^Name) was successfully updated on your computer."
  ${Endif}
SectionEnd



!include LogicLib.nsh ; So we don't have to use all these labels

# ONINIT - This is where we can check or uncheck components (sections)
# or make the check box read only
Function .onInit
  var /global need_admin
  StrCpy $need_admin 0

  IntOp $0 ${SF_SELECTED} | ${SF_RO}
  SectionSetFlags ${tmax_section_id} $0

  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{9120a466-433b-4dd9-a5e0-3092abd2cc1d}" "DisplayVersion"
  ${If} $0 != ""
    SectionSetFlags ${VC2019_section_id} 0
  ${else}
    StrCpy $need_admin 1
  ${EndIf}
  
  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{A49F249F-0C91-497F-86DF-B2585E8E76B7}" "DisplayVersion"
  ${If} $0 != ""
    SectionSetFlags ${VC2005_section_id} 0
  ${else}
    StrCpy $need_admin 1
  ${EndIf}

  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{CE26F10F-C80F-4377-908B-1B7882AE2CE3}" "DisplayVersion"
  ${If} $0 != ""
    SectionSetFlags ${Crystal_Reports_section_id} 0
  ${else}
    StrCpy $need_admin 1
  ${EndIf}
  
  ReadRegStr $0 HKLM "SOFTWARE\\Microsoft\Windows\CurrentVersion\Uninstall\KLiteCodecPack_is1" "DisplayVersion"
  ${If} $0 != ""
    SectionSetFlags ${KLite_section_id} 0
  ${else}
    StrCpy $need_admin 1
  ${EndIf}
  #MessageBox MB_OK "HERE 1 Need admin = $need_admin"
  !insertmacro UAC_IsAdmin # returns 1 in $0 after elevation and 0 before
  strcpy $is_admin $0
  #MessageBox MB_OK "HERE 2 IS admin = $is_admin"
  ${if} $need_admin == 1
    ${andif} $is_admin == 0
      !insertmacro UAC_RunElevated
	  # ERROR HANDLING
	  Abort
  ${endif}
  # Continue here, we are either already admin or we don't need admin
  #MessageBox MB_OK "HERE 3 CONTINUE cmdline=$CMDLINE"
FunctionEnd




Section -Post
  WriteUninstaller "$INSTDIR\uninstall.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\TmaxManager.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninstall.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\TmaxManager.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Function un.onInit
  #MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  #Abort
FunctionEnd

Section "un.Crystal Reports 2008 Runtime"
  # msiexec, no quiet string
  DetailPrint "Uninstalling Crystal Reports 2008 Runtime"
  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{CE26F10F-C80F-4377-908B-1B7882AE2CE3}" "UninstallString"
  ${If} $0 != ""
    ExecWait '$0 /passive'
  ${EndIf}
SectionEnd

Section "un.Visual C++ 2015-2019 Runtime"
  DetailPrint "Uninstalling Visual C++ 2015-2019 Runtime"
  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{9120a466-433b-4dd9-a5e0-3092abd2cc1d}" "QuietUninstallString"
  ${If} $0 != ""
    ExecWait $0
  ${EndIf}
SectionEnd

Section "un.Visual C++ 2005 Runtime"
  # msiexec, no quiet string
  DetailPrint "Uninstalling Visual C++ 2005 Runtime"
  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{A49F249F-0C91-497F-86DF-B2585E8E76B7}" "UninstallString"
  ${If} $0 != ""
    ExecWait '$0 /passive'
  ${EndIf}
SectionEnd

Section "un.K-Lite Codec Pack 1105"
  DetailPrint "Uninstalling K-Lite Codec Pack 1105"
  ReadRegStr $0 HKLM "SOFTWARE\\Microsoft\Windows\CurrentVersion\Uninstall\KLiteCodecPack_is1" "QuietUninstallString"
  ${If} $0 != ""
    ExecWait $0
  ${EndIf}
SectionEnd



Section "un.TrialMax"
  FindFirst $0 $1 "$INSTDIR\..\Common\*.ocx"
  loop:
    StrCmp $1 "" done
    #DetailPrint $1
    UnRegDLL "$INSTDIR\..\Common\$1"
    FindNext $0 $1
    Goto loop
  done:
  FindClose $0

  #Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninstall.exe"
  Delete "$INSTDIR\TmaxManager.exe"

  Delete "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk"
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\Website.lnk"
  Delete "$DESKTOP\TrialMax.lnk"
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\TrialMax.lnk"

  RMDir "$SMPROGRAMS\${PRODUCT_NAME}"
  RMDir /r "$INSTDIR"	# This is to get rid of the ...\FTI\ folder does not exist error message
  sleep 500				# If TrialMax folder is open in explorer
  RMDir /r "$INSTDIR\..\..\FTI"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose false
SectionEnd


#Function un.onUninstSuccess
  #HideWindow
  #MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
#FunctionEnd

# NOTES:
# We get error message that Lead tools cannot be loaded when tmaxpresentation.exe is run
# if the Lead tools cannot cannot be found in the PATH in the current (TrialMax) directory
# Path includes system directory $SYSDIR (C:\Windows\SYSWOW64 on 64 bit systems)
# At install time the current directory is not TrialMax, it is the directory where the OCX files are
# The ony directory that works for both install time and run-time is $sysdir
# Solution is to put the lead tools dlls in the $sysdir or 
# put the ocx files in the TrialMax directory
#

