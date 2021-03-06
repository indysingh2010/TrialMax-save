/*
   LTLST.H - LEAD ImageList Control module header file
   Copyright (c) 1991-2009 LEAD Technologies, Inc.
   All Rights Reserved.
*/

#if !defined(LTLST_H)
#define LTLST_H

#if !defined(L_LTLST_API)
   #define L_LTLST_API
#endif // #if !defined(L_LTLST_API)

#include "Ltkrn.h"
#include "Ltimg.h"
#include "Ltdis.h"
#include "Ltfil.h"

#define L_HEADER_ENTRY

#include "Ltpck.h"

/* the window class for the ImageList Control */
#define LTIMGLISTCLASS   TEXT("LEADIMGLIST")

///* callback typedefs */
//typedef L_INT32 (pEXT_CALLBACK IMAGELISTMSGCALLBACK) (HWND, UINT, WPARAM, LPARAM);

/* structure typedefs */
typedef struct _LILSELOPTION
{
   L_UINT   uStructSize;
   L_UINT   uAllowSelection;
   L_UINT   uSelectionStyle;
   COLORREF crSelection;    
} LILSELOPTION, * pLILSELOPTION;

/* possible values for uAllowSelection */
#define ALLOWSELECTION_NONE          0
#define ALLOWSELECTION_SINGLE        1
#define ALLOWSELECTION_MULTI         2

/* selection styles */
#define SELECTIONSTYLE_SELECTCOLOR   0
#define SELECTIONSTYLE_PRESSEDBUTTON 1
#define SELECTIONSTYLE_USERBITMAP    2

/* scroll styles */
#define SCROLLSTYLE_VERTICAL         0
#define SCROLLSTYLE_HORIZONTAL       1

/* this is the minimum dimension for an item */
#define MINIMUM_DIMENSION            10

typedef struct _LILITEMOPTION
{
   L_UINT   uStructSize;
   L_UINT   uVerticalSpacing;    /* vert. spacing b/t items, in pixels */
   L_UINT   uHorizontalSpacing;  /* horz. spacing b/t items, in pixels */
   L_UINT   uWidth;              /* item width, in pixels              */
   L_UINT   uHeight;             /* item height, in pixels             */
   COLORREF crBackground;        /* color for item background          */
   L_BOOL   bDisplayItemText;    /* TRUE to display item text          */
   COLORREF crForeground;        /* color for item text                */
   HFONT    hFont;               /* handle to font to use for item text*/
} LILITEMOPTION, * pLILITEMOPTION;

typedef struct _LILITEMA
{
   L_UINT          uStructSize;
   L_UINT32        uMask;       /* mask for getting/setting */
   pBITMAPHANDLE   pBitmap;     /* the item's bitmap        */
   L_UINT          uBitmapStructSize; /* size in bytes of the pBitmap structure */
   L_CHAR *        pText;       /* the item's text          */
   L_INT32         lData;       /* item user data           */
   L_BOOL          bSelected;   /* TRUE if item is selected */
   L_INT32         lIndex;      /* index of the item        */
   L_CHAR *        pTextExt;    /* the item's extended text */
} LILITEMA, * pLILITEMA;

#if defined(FOR_UNICODE)
typedef struct _LILITEM
{
   L_UINT          uStructSize;
   L_UINT32        uMask;       /* mask for getting/setting */
   pBITMAPHANDLE   pBitmap;     /* the item's bitmap        */
   L_UINT          uBitmapStructSize; /* size in bytes of the pBitmap structure */
   L_TCHAR *       pText;       /* the item's text          */
   L_INT32         lData;       /* item user data           */
   L_BOOL          bSelected;   /* TRUE if item is selected */
   L_INT32         lIndex;      /* index of the item        */
   L_TCHAR *       pTextExt;    /* the item's extended text */
} LILITEM, * pLILITEM;
#else
typedef LILITEMA LILITEM;
typedef pLILITEMA pLILITEM;
#endif // #if defined(FOR_UNICODE)

#define LILITEM_BITMAP   0x01   /* get/set the bitmap       */
#define LILITEM_TEXT     0x02   /* get/set the text         */
#define LILITEM_DATA     0x04   /* get/set the data         */
#define LILITEM_SELECTED 0x08   /* get/set the selected flag*/
#define LILITEM_TEXTEXT  0x10   /* get/set the extended text*/
#define LILITEM_ALL      LILITEM_BITMAP | LILITEM_TEXT | LILITEM_DATA | LILITEM_SELECTED | LILITEM_TEXTEXT

typedef struct _LILITEMSEL
{
   L_UINT          uStructSize;
   HWND            hWnd;        /* window handle of control */
   L_INT32         lIndex;      /* index of item selected   */
} LILITEMSEL, * pLILITEMSEL;

typedef struct _LILCLICK
{
   L_UINT          uStructSize;
   HWND            hWnd;        /* window handle of control */
   L_INT           xPos;        /* x position of cursor     */
   L_INT           yPos;        /* y position of cursor     */
} LILCLICK, * pLILCLICK;

typedef struct _LILKEYDOWN
{
  L_UINT           uStructSize;
  WORD             wVKey;       /* specifies the virtual key code */
  UINT             flags;       /* always zero */
} LILKEYDOWN, * pLILKEYDOWN;

typedef struct _LILDRAWITEM
{
   L_UINT   uStructSize;
   UINT     uID;                /* control id               */
   HWND     hWnd;               /* window handle of control */
   HDC      hDC;                /* HDC for item output      */
   RECT     rcItem;             /* location of item         */
   RECT     rcItemBack;         /* item background rect.    */
   pLILITEM pItem;              /* pointer to the item      */
} LILDRAWITEM, * pLILDRAWITEM;

/* Insert From List structure */
typedef struct _LILIMPORTBITMAPLISTA
{
   L_UINT         uStructSize;
   HBITMAPLIST    hList;         /* List that contains the bitmap list        */
   L_INT          nStartIndex;   /* The first index to be inserted from       */
   L_INT          nItemsToInsert;/* Number of items to be insert              */
   L_CHAR *       pText;         /* the item's text          */
   L_CHAR *       pTextExt;      /* the item's extended text */
} LILIMPORTBITMAPLISTA, * pLILIMPORTBITMAPLISTA;
#if defined(FOR_UNICODE)
typedef struct _LILIMPORTBITMAPLIST
{
   L_UINT         uStructSize;
   HBITMAPLIST    hList;         /* List that contains the bitmap list        */
   L_INT          nStartIndex;   /* The first index to be inserted from       */
   L_INT          nItemsToInsert;/* Number of items to be insert              */
   L_TCHAR *      pText;         /* the item's text          */
   L_TCHAR *      pTextExt;      /* the item's extended text */
} LILIMPORTBITMAPLIST, * pLILIMPORTBITMAPLIST;
#else
typedef LILIMPORTBITMAPLISTA LILIMPORTBITMAPLIST;
typedef pLILIMPORTBITMAPLISTA pLILIMPORTBITMAPLIST;
#endif // #if defined(FOR_UNICODE)
/* Export To List structure */
typedef struct _LILEXPORTBITMAPLIST
{
   L_UINT      uStructSize;
   HBITMAPLIST hList;         /* List that will contains the bitmap list   */
   L_INT       nStartIndex;   /* The first index to be inserted from       */
   L_INT       nItemsToExport;/* Number of items to be insert              */
} LILEXPORTBITMAPLIST, * pLILEXPORTBITMAPLIST;

/* Sort Options Structure */
typedef struct _LILSORTOPTIONS
{
   L_UINT         uStructSize;
   L_BOOL         bAscending;    /* TRUE to sort ascending, FALSE to sort descending. */
   L_BOOL         bCaseSensitive;/* TRUE to sort with case Sensitive, FALSE to sort case Insensitive. */
   L_BOOL         bUseExtText;   /* TRUE to sort using Ext Text property, FALSE to sort using Text property. */
   L_UINT32       uFlags;        /* Reserved: For Future Use */
} LILSORTOPTIONS, * pLILSORTOPTIONS;

/* Control Styles */
#define L_ILS_OWNERDRAWITEM      0x00000001L /* user will draw items */
#define L_ILS_ZOOMSMALLITEMS     0x00000002L /* small images are displayed zoomed */
#define L_ILS_CENTERVERTICAL     0x00000004L /* images are centered VERT */
#define L_ILS_KEEPCOMPRESSED     0x00000008L /* images are compressed in memory */
#if !defined(FOR_WINCE)
#define L_ILS_ACCEPTDROPFILES    0x00000010L /* accepts dropped files */
#endif // #if !defined(FOR_WINCE)

/* window messages */
#define L_ILM_GETSELOPTIONS      WM_USER + 1
#define L_ILM_SETSELOPTIONS      WM_USER + 2
#define L_ILM_GETITEMOPTIONS     WM_USER + 3
#define L_ILM_SETITEMOPTIONS     WM_USER + 4
#define L_ILM_GETROWCOUNT        WM_USER + 5
#define L_ILM_GETCOLCOUNT        WM_USER + 6
#define L_ILM_GETITEMCOUNT       WM_USER + 7
#define L_ILM_GETITEM            WM_USER + 8
#define L_ILM_CLEAR              WM_USER + 9
#define L_ILM_INSERT             WM_USER + 10
#define L_ILM_INSERTAT           WM_USER + 11
#define L_ILM_SETITEM            WM_USER + 12
#define L_ILM_REMOVE             WM_USER + 13
#define L_ILM_SORT               WM_USER + 14
#define L_ILM_HITTEST            WM_USER + 15
#define L_ILM_SCROLLITEMS        WM_USER + 16
#define L_ILM_ENSUREVISIBLE      WM_USER + 17
#define L_ILM_GETSELCOUNT        WM_USER + 18
#define L_ILM_GETSELITEMS        WM_USER + 19
#define L_ILM_GETBACKCOLOR       WM_USER + 20
#define L_ILM_SETBACKCOLOR       WM_USER + 21
#define L_ILM_GETBORDERCOLOR     WM_USER + 22
#define L_ILM_SETBORDERCOLOR     WM_USER + 23
#define L_ILM_SELECTALL          WM_USER + 24
#define L_ILM_GETSCROLLSTYLE     WM_USER + 25
#define L_ILM_SETSCROLLSTYLE     WM_USER + 26
#define L_ILM_ITEMSELECTED       WM_USER + 27
#define L_ILM_GETPAGECOUNT       WM_USER + 28
#define L_ILM_GETPAGE            WM_USER + 29
#if !defined(FOR_WINCE)
#define L_ILM_ENABLEKEYBOARD     WM_USER + 30
#endif // #if !defined(FOR_WINCE)
#define L_ILM_SETDISPLAYFLAGS    WM_USER + 31
#if !defined(FOR_WINCE)
#define L_ILM_SETSELBITMAP       WM_USER + 32
#endif // #if !defined(FOR_WINCE)
#define L_ILM_ITEMUNSELECTED     WM_USER + 33
#define L_ILM_SAVEDATABASE       WM_USER + 34
#define L_ILM_LOADDATABASE       WM_USER + 35
#define L_ILM_DRAWITEM           WM_USER + 36
#define L_ILM_GETVIEWSIZE        WM_USER + 37
#define L_ILM_GETFIRSTVISIBLE    WM_USER + 38
#define L_ILM_CANCELDB           WM_USER + 39
#define L_ILM_DBSTATUS           WM_USER + 40
#define L_ILM_IMPORTBITMAPLIST   WM_USER + 41
#define L_ILM_EXPORTBITMAPLIST   WM_USER + 42
#if !defined(FOR_WINCE)
#define L_ILM_DROPFILES          WM_USER + 43
#endif // #if !defined(FOR_WINCE)
#if !defined(FOR_WINCE)
#define L_ILM_SORTEXT            WM_USER + 44
#endif // #if !defined(FOR_WINCE)
#if !defined(FOR_WINCE)
#define L_ILM_INSERTA            WM_USER + 45
#define L_ILM_INSERTATA          WM_USER + 46
#define L_ILM_GETITEMA           WM_USER + 47
#define L_ILM_GETSELITEMSA       WM_USER + 48
#define L_ILM_SETITEMA           WM_USER + 49
#define L_ILM_IMPORTBITMAPLISTA  WM_USER + 50
#define L_ILM_LOADDATABASEA      WM_USER + 51
#define L_ILM_SAVEDATABASEA      WM_USER + 52
#endif // #if !defined(FOR_WINCE)

/* control notification codes */
#define L_ILN_SETFOCUS           0x100
#define L_ILN_KILLFOCUS          0x101
#define L_ILN_HSCROLL            0x200
#define L_ILN_VSCROLL            0x201
#define L_ILN_CLICKED            0x300
#define L_ILN_DBLCLCK            0x301
#define L_ILN_ITEMSEL            0x400
#define L_ILN_ITEMUNSEL          0x401
#define L_ILN_KEYDOWN            0x500
#define L_ILN_LOADDBSTATUS       0x600
#define L_ILN_SAVEDBSTATUS       0x601
#define L_ILN_DROPFILES          0x700
#define L_ILN_YIELD              0x999

/* external prototypes */
L_LTLST_API L_VOID EXT_FUNCTION L_UseImageListControl(L_VOID);

L_LTLST_API HWND EXT_FUNCTION L_CreateImageListControl(DWORD dwStyle,
                                           L_INT x,
                                           L_INT y,
                                           L_INT nWidth,
                                           L_INT nHeight,
                                           HWND hWndParent,
                                           L_INT nID,
                                           COLORREF crBack);

L_LTLST_API L_INT EXT_FUNCTION L_RenderImageListControl(HWND hWnd, HDC hDC, RECT * prcBounds, RECT * prcInvalid, L_UINT32 uFlags);


/* Some Useful Macros */
#if defined(__AFXWIN_H__)
   #define IMGLISTSENDMESSAGE ::SendMessage
#else
   #define IMGLISTSENDMESSAGE SendMessage
#endif // #if defined(__AFXWIN_H__)

#if !defined(FOR_ATLOCX)
   #define L_ImgListSetSelOptions(hWnd, pSelOptions) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETSELOPTIONS, 0, (LPARAM)(pLILSELOPTION)pSelOptions)
   #define L_ImgListGetSelOptions(hWnd, pSelOptions) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETSELOPTIONS, 0, (LPARAM)(pLILSELOPTION)pSelOptions)

   #define L_ImgListSetItemOptions(hWnd, pItemOptions) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETITEMOPTIONS, 0, (LPARAM)(pLILITEMOPTION)pItemOptions)

   #define L_ImgListGetItemOptions(hWnd, pItemOptions) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETITEMOPTIONS, 0, (LPARAM)(pLILITEMOPTION)pItemOptions)

   #define L_ImgListGetRowCount(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETROWCOUNT, 0, 0L)
   #define L_ImgListGetColumnCount(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETCOLCOUNT, 0, 0L)
   #define L_ImgListGetItemCount(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETITEMCOUNT, 0, 0L)

#if defined(FOR_UNICODE)
   #define L_ImgListGetItem(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETITEM, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)
#else
   #define L_ImgListGetItem(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETITEMA, (WPARAM)uIndex, (LPARAM)(pLILITEMA)pItem)
#endif // #if defined(FOR_UNICODE)

   #define L_ImgListClear(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_CLEAR, 0, 0L)

#if defined(FOR_UNICODE)
   #define L_ImgListInsert(hWnd, pItem) \
                       IMGLISTSENDMESSAGE(hWnd, L_ILM_INSERT, 0, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListInsertAt(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_INSERTAT, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListSetItem(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETITEM, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)
#else
   #define L_ImgListInsert(hWnd, pItem) \
                       IMGLISTSENDMESSAGE(hWnd, L_ILM_INSERTA, 0, (LPARAM)(pLILITEMA)pItem)
   #define L_ImgListInsertAt(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_INSERTATA, (WPARAM)uIndex, (LPARAM)(pLILITEMA)pItem)
   #define L_ImgListSetItem(hWnd, uIndex, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETITEMA, (WPARAM)uIndex, (LPARAM)(pLILITEMA)pItem)
#endif // #if defined(FOR_UNICODE)

   #define L_ImgListRemove(hWnd, uIndex) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_REMOVE, (WPARAM)uIndex, 0L)
   #define L_ImgListSort(hWnd, bAscending) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SORT, (WPARAM)bAscending, 0L)
   #define L_ImgListHitTest(hWnd, pPoint) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_HITTEST, 0, (LPARAM)(LPPOINT)pPoint)
   #define L_ImgListScrollItems(hWnd, uCount) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SCROLLITEMS, 0, (LPARAM)uCount)
   #define L_ImgListEnsureVisible(hWnd, uItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_ENSUREVISIBLE, (WPARAM)uItem, 0L)
   #define L_ImgListGetSelCount(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETSELCOUNT, 0, 0L)
#if defined(FOR_UNICODE)
   #define L_ImgListGetSelItems(hWnd, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETSELITEMS, 0, (LPARAM)(pLILITEM)pItem)
#else
   #define L_ImgListGetSelItems(hWnd, pItem) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETSELITEMSA, 0, (LPARAM)(pLILITEMA)pItem)
#endif // #if defined(FOR_UNICODE)
   #define L_ImgListSelectAll(hWnd, bFlag) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SELECTALL, (WPARAM)bFlag, 0L)

   #define L_ImgListGetBackColor(hWnd, pcrBack) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETBACKCOLOR, 0, (LPARAM)(COLORREF *)pcrBack)
   #define L_ImgListSetBackColor(hWnd, crBack) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETBACKCOLOR, 0, (LPARAM)crBack)
   #define L_ImgListGetBorderColor(hWnd, pcrBorder) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETBORDERCOLOR, 0, (LPARAM)(COLORREF *)pcrBorder)
   #define L_ImgListSetBorderColor(hWnd, crBorder) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETBORDERCOLOR, 0, (LPARAM)crBorder)

   #define L_ImgListGetScrollStyle(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETSCROLLSTYLE, 0, 0L)
   #define L_ImgListSetScrollStyle(hWnd, uStyle) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETSCROLLSTYLE, (WPARAM)uStyle, 0L)

   #define L_ImgListGetPageCount(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETPAGECOUNT, 0, 0L)
   #define L_ImgListGetPage(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETPAGE, 0, 0L)

   #define L_ImgListEnableKeyboard(hWnd, bFlag) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_ENABLEKEYBOARD, (WPARAM)bFlag, 0L)

   #define L_ImgListSetDisplayFlags(hWnd, uFlags) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETDISPLAYFLAGS, 0, (LPARAM)uFlags)

   #define L_ImgListSetSelBitmap(hWnd, crTransparent, pBitmap) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SETSELBITMAP, (WPARAM)crTransparent, (LPARAM)pBitmap)

#if defined(FOR_UNICODE)
   #define L_ImgListSaveDatabase(hWnd, bSelected, pszFilename) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SAVEDATABASE, (WPARAM)bSelected, (LPARAM)pszFilename)

   #define L_ImgListLoadDatabase(hWnd, pszFilename) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_LOADDATABASE, (WPARAM)0, (LPARAM)pszFilename)
#else
   #define L_ImgListSaveDatabase(hWnd, bSelected, pszFilename) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SAVEDATABASEA, (WPARAM)bSelected, (LPARAM)pszFilename)

   #define L_ImgListLoadDatabase(hWnd, pszFilename) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_LOADDATABASEA, (WPARAM)0, (LPARAM)pszFilename)
#endif // #if defined(FOR_UNICODE)

   #define L_ImgListGetViewSize(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETVIEWSIZE, (WPARAM)0, (LPARAM)0)

   #define L_ImgListGetFirstVisible(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_GETFIRSTVISIBLE, (WPARAM)0, (LPARAM)0)
   #define L_ImgListCancelDB(hWnd) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_CANCELDB, (WPARAM)0, (LPARAM)0)

#if defined(FOR_UNICODE)
   #define L_ImgListImportBitmapList(hWnd, pImportList) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_IMPORTBITMAPLIST, (WPARAM)0, (LPARAM)pImportList)
#else
   #define L_ImgListImportBitmapList(hWnd, pImportList) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_IMPORTBITMAPLISTA, (WPARAM)0, (LPARAM)pImportList)
#endif

#define L_ImgListExportBitmapList(hWnd, pExportList) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_EXPORTBITMAPLIST, (WPARAM)0, (LPARAM)pExportList)

   #define L_ImgListSortExt(hWnd, pSortOptions) \
                    IMGLISTSENDMESSAGE(hWnd, L_ILM_SORTEXT, (WPARAM)0, (LPARAM)(pLILSORTOPTIONS)pSortOptions)

#else
   #define L_ImgListSetSelOptions(pSelOptions) \
                    SendMessage(L_ILM_SETSELOPTIONS, 0, (LPARAM)(pLILSELOPTION)pSelOptions)
   #define L_ImgListGetSelOptions(pSelOptions) \
                    SendMessage(L_ILM_GETSELOPTIONS, 0, (LPARAM)(pLILSELOPTION)pSelOptions)

   #define L_ImgListSetItemOptions(pItemOptions) \
                    SendMessage(L_ILM_SETITEMOPTIONS, 0, (LPARAM)(pLILITEMOPTION)pItemOptions)
   #define L_ImgListGetItemOptions(pItemOptions) \
                    SendMessage(L_ILM_GETITEMOPTIONS, 0, (LPARAM)(pLILITEMOPTION)pItemOptions)

   #define L_ImgListGetRowCount() \
                    SendMessage(L_ILM_GETROWCOUNT, 0, 0L)
   #define L_ImgListGetColumnCount() \
                    SendMessage(L_ILM_GETCOLCOUNT, 0, 0L)
   #define L_ImgListGetItemCount() \
                    SendMessage(L_ILM_GETITEMCOUNT, 0, 0L)

   #define L_ImgListGetItem(uIndex, pItem) \
                    SendMessage(L_ILM_GETITEM, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)

   #define L_ImgListClear() \
                    SendMessage(L_ILM_CLEAR, 0, 0L)
   #define L_ImgListInsert(pItem) \
                    SendMessage(L_ILM_INSERT, 0, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListInsertAt(uIndex, pItem) \
                    SendMessage(L_ILM_INSERTAT, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListSetItem(uIndex, pItem) \
                    SendMessage(L_ILM_SETITEM, (WPARAM)uIndex, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListRemove(uIndex) \
                    SendMessage(L_ILM_REMOVE, (WPARAM)uIndex, 0L)
   #define L_ImgListSort(bAscending) \
                    SendMessage(L_ILM_SORT, (WPARAM)bAscending, 0L)
   #define L_ImgListHitTest(pPoint) \
                    SendMessage(L_ILM_HITTEST, 0, (LPARAM)(LPPOINT)pPoint)
   #define L_ImgListScrollItems(uCount) \
                    SendMessage(L_ILM_SCROLLITEMS, 0, (LPARAM)uCount)
   #define L_ImgListEnsureVisible(uItem) \
                    SendMessage(L_ILM_ENSUREVISIBLE, (WPARAM)uItem, 0L)
   #define L_ImgListGetSelCount() \
                    SendMessage(L_ILM_GETSELCOUNT, 0, 0L)
   #define L_ImgListGetSelItems(pItem) \
                    SendMessage(L_ILM_GETSELITEMS, 0, (LPARAM)(pLILITEM)pItem)
   #define L_ImgListSelectAll(bFlag) \
                    SendMessage(L_ILM_SELECTALL, (WPARAM)bFlag, 0L)

   #define L_ImgListGetBackColor(pcrBack) \
                    SendMessage(L_ILM_GETBACKCOLOR, 0, (LPARAM)(COLORREF *)pcrBack)
   #define L_ImgListSetBackColor(crBack) \
                    SendMessage(L_ILM_SETBACKCOLOR, 0, (LPARAM)crBack)
   #define L_ImgListGetBorderColor(pcrBorder) \
                    SendMessage(L_ILM_GETBORDERCOLOR, 0, (LPARAM)(COLORREF *)pcrBorder)
   #define L_ImgListSetBorderColor(crBorder) \
                    SendMessage(L_ILM_SETBORDERCOLOR, 0, (LPARAM)crBorder)

   #define L_ImgListGetScrollStyle() \
                    SendMessage(L_ILM_GETSCROLLSTYLE, 0, 0L)
   #define L_ImgListSetScrollStyle(uStyle) \
                    SendMessage(L_ILM_SETSCROLLSTYLE, (WPARAM)uStyle, 0L)

   #define L_ImgListGetPageCount() \
                    SendMessage(L_ILM_GETPAGECOUNT, 0, 0L)
   #define L_ImgListGetPage() \
                    SendMessage(L_ILM_GETPAGE, 0, 0L)

   #define L_ImgListEnableKeyboard(bFlag) \
                    SendMessage(L_ILM_ENABLEKEYBOARD, (WPARAM)bFlag, 0L)

   #define L_ImgListSetSelBitmap(crTransparent, pBitmap) \
                    SendMessage(L_ILM_SETSELBITMAP, (WPARAM)crTransparent, (LPARAM)pBitmap)

   #define L_ImgListSetDisplayFlags(uFlags) \
                    SendMessage(L_ILM_SETDISPLAYFLAGS, 0, (LPARAM)uFlags)
#if defined(FOR_UNICODE)
   #define L_ImgListSaveDatabase(bSelected, pszFilename) \
                    SendMessage(L_ILM_SAVEDATABASE, (WPARAM)bSelected, (LPARAM)pszFilename)

   #define L_ImgListLoadDatabase(pszFilename) \
                    SendMessage(L_ILM_LOADDATABASE, (WPARAM)0, (LPARAM)pszFilename)
#else
   #define L_ImgListSaveDatabase(bSelected, pszFilename) \
                    SendMessage(L_ILM_SAVEDATABASEA, (WPARAM)bSelected, (LPARAM)pszFilename)

   #define L_ImgListLoadDatabase(pszFilename) \
                    SendMessage(L_ILM_LOADDATABASEA, (WPARAM)0, (LPARAM)pszFilename)
#endif // #if defined(FOR_UNICODE)
   #define L_ImgListGetViewSize() \
                    IMGLISTSENDMESSAGE(L_ILM_GETVIEWSIZE, (WPARAM)0, (LPARAM)0)

   #define L_ImgListGetFirstVisible() \
                    IMGLISTSENDMESSAGE(L_ILM_GETFIRSTVISIBLE, (WPARAM)0, (LPARAM)0)

   #define L_ImgListCancelDB() \
                    IMGLISTSENDMESSAGE(L_ILM_CANCELDB, (WPARAM)0, (LPARAM)0)

   #define L_ImgListImportBitmapList(pImportList) \
                    IMGLISTSENDMESSAGE(L_ILM_IMPORTBITMAPLIST, (WPARAM)0, (LPARAM)pImportList)
   #define L_ImgListExportBitmapList(pExportList) \
                    IMGLISTSENDMESSAGE(L_ILM_EXPORTBITMAPLIST, (WPARAM)0, (LPARAM)pExportList)
   #define L_ImgListSortExt(pSortOptions) \
                    IMGLISTSENDMESSAGE(L_ILM_SORTEXT, (WPARAM)0, (LPARAM)(pLILSORTOPTIONS)pSortOptions)

#endif // #if !defined(FOR_ATLOCX)

#undef L_HEADER_ENTRY
#include "Ltpck.h"

#endif // #if !defined(LTLST_H)


